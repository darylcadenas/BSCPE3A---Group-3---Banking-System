using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BISU_AMS_Desktop.Dal;
namespace BISU_AMS_Desktop
{
    public partial class AddStudentForm : DevExpress.XtraEditors.XtraForm
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }
        #region UTIL
        bool loadingIsAlreadyShowing = false;
        private void ShowLoading(string message)
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }

                if (!loadingIsAlreadyShowing)
                {
                    loadingIsAlreadyShowing = true;
                    splashScreenManager1.ShowWaitForm();
                }
                splashScreenManager1.SetWaitFormDescription(message);
            }
            catch { }
        }

        private void HideLoading()
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    c.Enabled = true;
                }

                loadingIsAlreadyShowing = false;
                splashScreenManager1.CloseWaitForm();
            }
            catch { }
        }

        #endregion
        private void AddStudentForm_Shown(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadDepartments()
        {
            if (!bwLoadDepartment.IsBusy)
            {
                ShowLoading("Loading...");
                bwLoadDepartment.RunWorkerAsync();
            }
        }
        DataTable dtDepartments;
        private void bwLoadDepartment_DoWork(object sender, DoWorkEventArgs e)
        {
            dtDepartments = Academe.GetDepartment();
            bwLoadDepartment.CancelAsync();
        }

        private void bwLoadDepartment_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Academe.GetDepartmentSucessful)
            {
                cmbDepartment.Properties.DataSource = dtDepartments;
                cmbDepartment.Properties.DisplayMember = "abbreviation";
                cmbDepartment.Properties.ValueMember = "id";
            }
            else
                MessageBox.Show(Academe.GetDepartmentErrorMessage);
        }
        int DepartmentId;
        private void cmbDepartment_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbDepartment.EditValue) >= 0)
            {
                DepartmentId = Convert.ToInt32(cmbDepartment.EditValue);
                //display child course
                GetCoursePerDepartment();
            }
        }
        private void GetCoursePerDepartment()
        {
            if (!bwLoadCourse.IsBusy)
            {
                ShowLoading("Loading...");
                bwLoadCourse.RunWorkerAsync();
            }
        }
        DataTable dtCourses;
        private void bwLoadCourse_DoWork(object sender, DoWorkEventArgs e)
        {
            dtCourses = Academe.GetCourse(DepartmentId);
            bwLoadCourse.CancelAsync();
        }

        private void bwLoadCourse_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Academe.GetCourseSucessful)
            {
                cmbCourse.Properties.DataSource = dtCourses;
                cmbCourse.Properties.DisplayMember = "abbreviation";
                cmbCourse.Properties.ValueMember = "id";
            }
            else
                MessageBox.Show(Academe.GetCourseErrorMessage);
        }

    }
}