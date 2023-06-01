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
using System.IO;
namespace BISU_AMS_Desktop
{
    public partial class AcademeManagementForm : DevExpress.XtraEditors.XtraForm
    {
        public AcademeManagementForm()
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
        private void GetDepartmentList()
        {
            if (!bwGetDepartment.IsBusy)
            {
                ShowLoading("Loading...");
                bwGetDepartment.RunWorkerAsync();
            }
        }
        DataTable dtDepartments = new DataTable();
        private void bwGetDepartment_DoWork(object sender, DoWorkEventArgs e)
        {
            dtDepartments = Academe.GetDepartment();
            bwGetDepartment.CancelAsync();
        }

        private void bwGetDepartment_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Academe.GetDepartmentSucessful)
                dtDepartment.DataSource = dtDepartments;
            else
                MessageBox.Show(Academe.GetDepartmentErrorMessage);
        }

        private void AcademeManagementForm_Shown(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.BisuIcon;
            GetDepartmentList();
        }
        int DepartmentId;
        private void gvDepartment_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DepartmentSelection();
        }
        private bool DepartmentSelection() {
            if (gvDepartment.SelectedRowsCount > 0)
            {
                var focusRowView = (DataRowView)gvDepartment.GetFocusedRow();
                DepartmentId = Convert.ToInt32(focusRowView.Row[0].ToString());
                txtDepartmentName.Text = focusRowView.Row[1].ToString();
                txtAbbreviation.Text = focusRowView.Row[2].ToString();
                GetCourseList();
                return true;
            }
            return false;
        }
        private void GetCourseList()
        {
            if (!bwGetCourse.IsBusy)
            {
                ShowLoading("Loading...");
                bwGetCourse.RunWorkerAsync();
            }
        }
        DataTable dtCourseList = new DataTable();
        private void bwGetCourse_DoWork(object sender, DoWorkEventArgs e)
        {
            dtCourseList = Academe.GetCourse(DepartmentId);
            bwGetCourse.CancelAsync();
        }

        private void bwGetCourse_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Academe.GetCourseSucessful)
            {
                dtCourses.DataSource = dtCourseList;
                dtCourses.Enabled = true;
            }
            else
                MessageBox.Show(Academe.GetCourseErrorMessage);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                CRUDEControl(false);
                btnSave.Text = "Add";
                txtDepartmentName.Enabled = true;
                txtAbbreviation.Enabled = true;
                txtDepartmentName.Text = string.Empty;
                txtAbbreviation.Text = string.Empty;
                btnSave.Enabled = true;
                btnCancelDept.Enabled = true;
                pnlCourse.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DepartmentSelection())
            {
                CRUDEControl(false);
                btnSave.Text = "Save";
                txtDepartmentName.Enabled = true;
                txtAbbreviation.Enabled = true;
                btnSave.Enabled = true;
                btnCancelDept.Enabled = true;
                pnlCourse.Enabled = false;
            }
            else
                MessageBox.Show("No row selected!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DepartmentSelection())
            { 
                //delete
                DeleteDepartment();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetDepartmentList();
        }
        private void SaveDepartment()
        {
            if (!bwDepartmentSave.IsBusy)
            {
                ShowLoading("Saving...");
                bwDepartmentSave.RunWorkerAsync();
            }
        }
        private void bwDepartmentSave_DoWork(object sender, DoWorkEventArgs e)
        {
            Academe.SaveDepartment(DepartmentId, txtDepartmentName.Text, txtAbbreviation.Text, btnSave.Text);
            bwDepartmentSave.CancelAsync();
        }

        private void bwDepartmentSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Academe.SaveDepartmentSucessful)
            {
                MessageBox.Show("Department Saved!");
                GetDepartmentList();
                txtDepartmentName.Enabled = false;
                txtAbbreviation.Enabled = false;
                btnSave.Enabled = false;
                CRUDEControl(true);
            }
            else
                MessageBox.Show(Academe.SaveDepartmentErrorMessage);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDepartment();
        }

        private void DeleteDepartment() 
        {
            if (!bwDeleteDepartment.IsBusy)
            {
                ShowLoading("Deleting...");
                bwDeleteDepartment.RunWorkerAsync();
            }
        }
        private void bwDeleteDepartment_DoWork(object sender, DoWorkEventArgs e)
        {
            Academe.DeleteDepartment(DepartmentId);
            bwDeleteDepartment.CancelAsync();
        }

        private void bwDeleteDepartment_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Academe.DeleteDepartmentSucessful)
            {
                MessageBox.Show("Department Deleted!");
                GetDepartmentList();
            }
            else
                MessageBox.Show(Academe.DeleteDepartmentErrorMessage);
        }

        private void btnCancelDept_Click(object sender, EventArgs e)
        {
            txtDepartmentName.Text = string.Empty;
            pnlCourse.Enabled = true;
            txtAbbreviation.Text = string.Empty;
            btnSave.Enabled = false;
            btnCancelDept.Enabled = false;
            txtDepartmentName.Enabled = false;
            txtAbbreviation.Enabled = false;
            CRUDEControl(true);
        }
        private void CRUDEControl(bool operation)
        {
            btnAdd.Enabled = operation;
            btnEdit.Enabled = operation;
            btnDelete.Enabled = operation;
            btnRefresh.Enabled = operation;
        }

        private void btnCourseAdd_Click(object sender, EventArgs e)
        {
            pnlDepartment.Enabled = false;
            dtCourses.Enabled = false;
            btnSaveCourse.Text = "Add";
            txtCourseName.Text = string.Empty;
            txtCourseAbb.Text = string.Empty;
            txtCourseName.Enabled = true;
            txtCourseAbb.Enabled = true;
            btnSaveCourse.Enabled = true;
            btnCancelCourse.Enabled = true;
            txtCourseName.Focus();
            txtCourseName.Select();
        }

        private void btnCourseRefresh_Click(object sender, EventArgs e)
        {
            GetCourseList();
        }

        private void btnCourseDelete_Click(object sender, EventArgs e)
        {
            DeleteCourse();
        }

        private void btnCourseEdit_Click(object sender, EventArgs e)
        {
            if (CourseSelection())
            {
                btnSaveCourse.Text = "Save";
                txtCourseName.Enabled = true;
                txtCourseAbb.Enabled = true;
                btnSaveCourse.Enabled = true;
                btnCancelCourse.Enabled = true;
                txtCourseName.Focus();
                txtCourseName.Select();
            }
        }

        private void btnCancelCourse_Click(object sender, EventArgs e)
        {
            btnSaveCourse.Text = "Save";
            txtCourseName.Text = string.Empty;
            txtCourseAbb.Text = string.Empty;
            txtCourseName.Enabled = false;
            txtCourseAbb.Enabled = false;
            btnSaveCourse.Enabled = false;
            btnCancelCourse.Enabled = false;
            pnlDepartment.Enabled = true;
            dtCourses.Enabled = true;
        }

        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
            AddCourse();
        }
        
        private void AddCourse() 
        {
            if (!bwAddCourse.IsBusy)
            {
                ShowLoading("Adding...");
                bwAddCourse.RunWorkerAsync();
            }
        }
        private void bwAddCourse_DoWork(object sender, DoWorkEventArgs e)
        {
            Academe.SaveCourse(DepartmentId, CourseId, txtCourseName.Text, txtCourseAbb.Text, btnSaveCourse.Text);
            bwAddCourse.CancelAsync();
        }

        private void bwAddCourse_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Academe.SaveCourseSucessful)
            {
                MessageBox.Show("Added Successfully!");
                GetCourseList();
                txtCourseName.Enabled = false;
                txtCourseAbb.Enabled = false;
                btnSaveCourse.Enabled = false;
                btnCancelCourse.Enabled = false;
            }
            else
                MessageBox.Show(Academe.SaveCourseErrorMessage);
        }

        private void gvCourses_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CourseSelection();
        }
        int CourseId;
        private bool CourseSelection()
        {
            if (gvCourses.SelectedRowsCount > 0)
            {
                var focusRowView = (DataRowView)gvCourses.GetFocusedRow();
                CourseId = Convert.ToInt32(focusRowView.Row[0].ToString());
                txtCourseName.Text = focusRowView.Row[1].ToString();
                txtCourseAbb.Text = focusRowView.Row[2].ToString();
                return true;
            }
            return false;
        }
        private void DeleteCourse()
        {
            if (!bwDeleteCourse.IsBusy)
            {
                ShowLoading("Deleting...");
                bwDeleteCourse.RunWorkerAsync();
            }
        }
        private void bwDeleteCourse_DoWork(object sender, DoWorkEventArgs e)
        {
            Academe.DeleteCourse(CourseId);
            bwDeleteCourse.CancelAsync();
        }

        private void bwDeleteCourse_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Academe.DeleteCourseSucessful)
            {
                MessageBox.Show("Deleted Successfully!");
                GetCourseList();
            }
            else
                MessageBox.Show(Academe.DeleteCourseErrorMessage);
        }

        private void AcademeManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}