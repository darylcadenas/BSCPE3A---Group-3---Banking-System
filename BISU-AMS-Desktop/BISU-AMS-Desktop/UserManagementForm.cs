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
        // GETTING USER LIST
        private void GetUserList()
        {
            if (!bwGetUser.IsBusy)
            {
                ShowLoading("Loading...");
                bwGetUser.RunWorkerAsync(); //START BACKGROUND WORK
            }
        }

        //BACKGROUND WORK FOR GET USER
        DataTable dtUser = new DataTable();
        private void bwGetUser_DoWork(object sender, DoWorkEventArgs e)
        {
            //GETTING INFO TO USERS.CS NGA FILE
            dtUser = Users.GetUser();
            bwGetUser.CancelAsync();
        }

        //BACKGROUND WORK COMPLETE
        private void bwGetUser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Users.GetUserSucessful)
            {
                dtUsers.DataSource = dtUser; //DISPLAY DATA
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
                txtFullName.Enabled = false;
                cmbPrivilege.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                CRUDEControl(true);
            }
            else
                MessageBox.Show(Users.GetUserErrorMessage);
        }

        //ICON PROPERTIES RA
        private void UserManagementForm_Shown(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.BisuIcon;
            GetUserList();
        }

        //TEXT FIELD CONTROLS
        private void CRUDEControl(bool operation)
        {
            btnAdd.Enabled = operation;
            btnEdit.Enabled = operation;
            btnDelete.Enabled = operation;
            btnRefresh.Enabled = operation;
        }

        //FUNCTION KUNG I CLICK ANG ADD BUTTON
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //PROCEDD TO ADD DETAILS
            CRUDEControl(false);
            btnSave.Text = "Add";
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            txtFullName.Enabled = true;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtFullName.Text = string.Empty;
            cmbPrivilege.Enabled = true;
            //cmbPrivilege.Text = string.Empty;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        //FUNCTION KUNG I CLICK ANG EDIT BUTTON
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (UserSelection()) //KUNG NAAY NA CLICK NGA DATA SA TABLE
            {
                //PROCEDD TO EDIT DETAILS
                CRUDEControl(false);
                btnSave.Text = "Save";
                txtUserName.Enabled = false;
                txtPassword.Enabled = true;
                txtFullName.Enabled = false;
                cmbPrivilege.Enabled = true;
                //cmbPrivilege.Text = string.Empty;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
            else
                MessageBox.Show("No row selected!");
        }

        //FUNCTION KUNG I CLICK ANG DELETE BUTTON
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UserSelection())
            {
                // DELETE FUNCTION
                DeleteUser();
            }
        }

        //FUNCTION KUNG I CLICK ANG REFRESH BUTTON
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // GETTING USER LIST
            GetUserList();
        }

        //FUNCTION KUNG I CLICK ANG SAVE BUTTON
        private void btnSave_Click(object sender, EventArgs e)
        {
            // KUNG WALAY SUD ANG MGA TEXT FIELDS, MAG ERROR
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Enter Required Fields.");
            }
            // ELSE PROCEDD TO SAVE USER
            else SaveUser();
        }

        // DETECTION SA CLICKS SA DATA SA TABLE
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

        // SAVING USER
        private void SaveUser()
        {
            if (!bwUserSave.IsBusy)
            {
                ShowLoading("Saving...");
                bwUserSave.RunWorkerAsync(); // STARTING BACKGROUND WORK
            }
        }

        // BACKGROUND WORK
        private void bwUserSave_DoWork(object sender, DoWorkEventArgs e)
        {
            // GETTING STATEMENTS SA USER.CS NGA FILE
            Users.SaveUser(txtUserName.Text, txtPassword.Text, txtFullName.Text, cmbPrivilege.Text, btnSave.Text);
            bwUserSave.CancelAsync();
        }

        // BACKGROUND WORK
        private void bwUserSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Users.SaveUserSucessful)
            {
                //SHOW MESSEGE
                MessageBox.Show("User Saved!");
                GetUserList();
                //REPEATING CYCLE
            }
            else
                MessageBox.Show(Users.SaveUserErrorMessage);
        }

        //DELETING USER
        private void DeleteUser()
        {
            if (!bwUserDelete.IsBusy)
            {
                ShowLoading("Deleting...");
                bwUserDelete.RunWorkerAsync(); // STARTING BACKGROUND WORK
            }
        }

        // BACKGROUND WORK
        private void bwUserDelete_DoWork(object sender, DoWorkEventArgs e)
        {
            // GETTING STATEMENTS SA USER.CS NGA FILE
            Users.DeleteUser(txtUserName.Text, txtFullName.Text);
            bwUserDelete.CancelAsync();
        }

        private void bwUserDelete_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Users.DeleteUserSucessful)
            {
                //SHOW MESSEGE
                MessageBox.Show("User Deleted!");
                GetUserList();
                txtPassword.Text = string.Empty;
                //REPEATING CYCLE
            }
            else
                MessageBox.Show(Users.DeleteUserErrorMessage);
        }

        //CANCEL BUTTON
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            txtFullName.Enabled = false;
            cmbPrivilege.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            CRUDEControl(true);
        }
    }
}