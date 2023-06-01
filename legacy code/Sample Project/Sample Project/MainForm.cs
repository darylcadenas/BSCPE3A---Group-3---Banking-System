using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Sample_Project.Dal;
using DevExpress.XtraEditors;

namespace Sample_Project
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        #region WaitForm
        bool loadingIsAlreadyShowing = false;
        private void ShowLoading(string message)
        {
            try
            {
                this.Enabled = false;
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
                this.Enabled = true;
                loadingIsAlreadyShowing = false;
                splashScreenManager1.CloseWaitForm();
            }
            catch { }
        }
        #endregion

        private void GetList() 
        {
            if (!bwGetUsers.IsBusy)
            {
                ShowLoading("Loading...");
                bwGetUsers.RunWorkerAsync();
            }
        }
        DataTable dtUsers = new DataTable();
        private void bwGetUsers_DoWork(object sender, DoWorkEventArgs e)
        {
            dtUsers = User.GetList();
            bwGetUsers.CancelAsync();
        }

        private void bwGetUsers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (User.GetListSuccessful)
            {
                if (dtUsers.Rows.Count > 0)
                {
                    dtUserlist.DataSource = dtUsers;
                }
            }
            else
                MessageBox.Show(User.GetListError);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            GetList();
        }

        private void AddUser() 
        {
            if (!bwAdd.IsBusy)
            {
                ShowLoading("Adding...");
                bwAdd.RunWorkerAsync();
            }
        }
        private void bwAdd_DoWork(object sender, DoWorkEventArgs e)
        {
            User.AddUser(txtUserName.Text, txtPassword.Text, txtFullName.Text);
            bwAdd.CancelAsync();
        }

        private void bwAdd_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (User.AddUserSuccessful)
            {
                MessageBox.Show("User Added!");
                clearTextFields();
                GetList();
            }
            else
                MessageBox.Show(User.AddUserErrorMessage);
        }

        private void clearTextFields()
        {
            txtFullName.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectionPass())
                EditUser();
        }

        private void GetDetails()
        {
            var focusRowView = (DataRowView)gvUsers.GetFocusedRow();
            userId = focusRowView.Row[0].ToString();
            txtUserName.Text = focusRowView.Row[1].ToString();
            txtFullName.Text = focusRowView.Row[3].ToString();
        }
        string userId;
        private void EditUser() 
        {
            if (!bwEdit.IsBusy)
            {
                ShowLoading("Editing..");
                bwEdit.RunWorkerAsync();
            }
        }

        private void bwEdit_DoWork(object sender, DoWorkEventArgs e)
        {
            User.EditUser(txtUserName.Text, txtPassword.Text, txtFullName.Text,userId);
            bwEdit.CancelAsync();
        }

        private void bwEdit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (User.EditUserSuccessful)
            {
                MessageBox.Show("User Edited!");
                clearTextFields();
                GetList();
            }
            else
                MessageBox.Show(User.EditUserrErrorMessage);
        }

        private void gvUsers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (SelectionPass())
            {
                GetDetails();
            }
        }
        private bool SelectionPass()
        {
            if (gvUsers.SelectedRowsCount > 0)
            {
                return true;
            }
            return false;
        }

        private void DeleteUser() 
        {
            if (!bwDelete.IsBusy)
            {
                ShowLoading("Deleting...");
                bwDelete.RunWorkerAsync();
            }
        }
        private void bwDelete_DoWork(object sender, DoWorkEventArgs e)
        {
            User.DeleteUser(userId);
            bwDelete.CancelAsync();
        }

        private void bwDelete_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (User.DeleteUserSuccessful)
            {
                MessageBox.Show("User Deleted!");
                clearTextFields();
                GetList();
            }
            else
                MessageBox.Show(User.DeleteUserErrorMessage);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }
    }
}