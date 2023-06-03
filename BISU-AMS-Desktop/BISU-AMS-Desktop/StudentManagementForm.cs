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
    public partial class StudentManagementForm : DevExpress.XtraEditors.XtraForm
    {
        public StudentManagementForm()
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
        public bool AddingIsSuccessful = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudentForm asf = new AddStudentForm();
            asf.ShowDialog();
        }
        DataTable dtstudentlist;
        private void bwStudent_Management_DoWork(object sender, DoWorkEventArgs e)
        {
            dtstudentlist = Students.GetStudents();
            bwgetstudents.CancelAsync();
        }

        private void bwgetstudents_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Students.GetStudentsSucessful)
            {
                dtStudent.DataSource = dtstudentlist;
            }

        }

        private void StudentManagementForm_Shown(object sender, EventArgs e)
        {
            bwgetstudents.RunWorkerAsync();
        }

    }
}