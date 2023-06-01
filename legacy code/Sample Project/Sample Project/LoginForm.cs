using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sample_Project.Dal;
namespace Sample_Project
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
            MessageBox.Show("Hello");
        }

        private void Login() 
        {
            if (!bwLogin.IsBusy)
            {
                ShowLoading("Loading...");
                bwLogin.RunWorkerAsync();
            }
        }
        DataTable dtUserInfo = new DataTable();
        private void bwLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            dtUserInfo = User.GetLogin(txtUserName.Text, txtPassword.Text);
            bwLogin.CancelAsync();
        }

        private void bwLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (User.GetUserDataSuccessful)
            {
                MessageBox.Show("Welcome [" + dtUserInfo.Rows[0][3].ToString() + "]");
                MainForm mf = new MainForm();
                mf.ShowDialog();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid credentials" + User.GetUserDataError);
        }
    }
}
