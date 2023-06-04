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
    public partial class UserManagementForm : DevExpress.XtraEditors.XtraForm
    {
        public UserManagementForm()
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
        private void GetUserList()
        {
            if (!bwGetUser.IsBusy)
            {
                ShowLoading("Loading...");
                bwGetUser.RunWorkerAsync();
            }
        }

        DataTable dtUser = new DataTable();
        private void bwGetUser_DoWork(object sender, DoWorkEventArgs e)
        {
            dtUser = Users.GetUser();
            bwGetUser.CancelAsync();
        }

        private void bwGetUser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Users.GetUserSucessful)
                dtUsers.DataSource = dtUser;
            else
                MessageBox.Show(Users.GetUserErrorMessage);
        }


    }
}