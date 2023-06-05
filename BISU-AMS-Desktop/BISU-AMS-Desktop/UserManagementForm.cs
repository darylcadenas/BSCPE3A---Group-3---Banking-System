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

        private void UserManagementForm_Shown(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.BisuIcon;
            GetUserList();
        }

        private void CRUDEControl(bool operation)
        {
            btnAdd.Enabled = operation;
            btnEdit.Enabled = operation;
            btnDelete.Enabled = operation;
            btnRefresh.Enabled = operation;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CRUDEControl(false);
            btnSave.Text = "Add";
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            txtFullName.Enabled = true;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtFullName.Text = string.Empty;
            //cmbPrivilege.Enabled = true;
            //cmbPrivilege.Text = string.Empty;
            btnSave.Enabled = true;
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (UserSelection())
            {
                CRUDEControl(false);
                btnSave.Text = "Save";
                txtUserName.Enabled = false;
                txtPassword.Enabled = true;
                txtFullName.Enabled = false;
                //cmbPrivilege.Enabled = true;
                //cmbPrivilege.Text = string.Empty;
                btnSave.Enabled = true;
            }
            else
                MessageBox.Show("No row selected!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UserSelection())
            {
                DeleteUser();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetUserList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Enter Required Fields.");
            }
            else SaveUser();
        }

        private void gvUsers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UserSelection();
        }
        string userID;
        private bool UserSelection()
        {
            if (gvUsers.SelectedRowsCount > 0)
            {
                var focusRowView = (DataRowView)gvUsers.GetFocusedRow();
                userID = focusRowView.Row[0].ToString();
                txtUserName.Text = focusRowView.Row[1].ToString();
                txtFullName.Text = focusRowView.Row[2].ToString();
                cmbPrivilege.Text = focusRowView.Row[3].ToString();
                return true;
            }
            return false;
        }

        private void SaveUser()
        {
            if (!bwUserSave.IsBusy)
            {
                ShowLoading("Saving...");
                bwUserSave.RunWorkerAsync();
            }
        }

        private void bwUserSave_DoWork(object sender, DoWorkEventArgs e)
        {
            Users.SaveUser(txtUserName.Text, txtPassword.Text, txtFullName.Text, cmbPrivilege.Text, btnSave.Text);
            bwUserSave.CancelAsync();
        }

        private void bwUserSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Users.SaveUserSucessful)
            {
                MessageBox.Show("User Saved!");
                GetUserList();
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
                txtFullName.Enabled = false;
                btnSave.Enabled = false;
                CRUDEControl(true);
            }
            else
                MessageBox.Show(Users.SaveUserErrorMessage);
        }

        private void DeleteUser()
        {
            if (!bwUserDelete.IsBusy)
            {
                ShowLoading("Deleting...");
                bwUserDelete.RunWorkerAsync();
            }
        }

        private void bwUserDelete_DoWork(object sender, DoWorkEventArgs e)
        {
            Users.DeleteUser(txtUserName.Text, txtPassword.Text, txtFullName.Text, cmbPrivilege.Text);
            bwUserDelete.CancelAsync();
        }

        private void bwUserDelete_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Users.DeleteUserSucessful)
            {
                MessageBox.Show("User Deleted!");
                GetUserList();
            }
            else
                MessageBox.Show(Users.DeleteUserErrorMessage);
        }

        
    }
}