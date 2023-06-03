using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BISU_AMS_Desktop.Dal;

namespace BISU_AMS_Desktop
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please Input Username and Password.");
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    txtUserName.Focus();
                    txtUserName.Select();
                }
                else if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    txtPassword.Focus();
                    txtPassword.Select();
                }
            }
            else
            {
                verifyLogin();
            }
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            //non-static background image
            //string LocalDirectory = Directory.GetCurrentDirectory();
            //string BgFilePath = LocalDirectory + "\\images\\background.jpg";
            //this.BackgroundImage = Image.FromFile(BgFilePath);
            //this.BackgroundImageLayout = ImageLayout.Stretch;
            //string IconFilePath = LocalDirectory + "\\images\\icon.ico";
            //this.Icon = Properties.Resources.BisuIcon;
        }
        private void verifyLogin()
        {
            if (!bwLogin.IsBusy)
            {
                ShowLoading("Logging in...");
                bwLogin.RunWorkerAsync();
            }
        }

        DataTable userinfo;
        private void bwLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            userinfo = Users.GetLogin(txtUserName.Text, txtPassword.Text);
            bwLogin.CancelAsync();
        }

        private void bwLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Users.GetLoginSucessful)
            {
                MessageBox.Show("Login successful!");
                MainForm mf = new MainForm();
                this.Hide();
                mf.Show();
            }
        }
    }
}
