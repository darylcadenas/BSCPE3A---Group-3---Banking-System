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
        // CLICK SA LOGIN BUTTON
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //KUNG WALAY SUD ANG USERNAME UG PASSWORD
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please Input Username and Password.");
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    //FOCUS SA USERNAME KUNG WALAY SUD SI USERNAME
                    txtUserName.Focus();
                    txtUserName.Select();
                }
                else if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    //FOCUS SA PASSWORD KUNG WALAY SUD SI PASSWORD
                    txtPassword.Focus();
                    txtPassword.Select();
                }
            }
            // KUNG NAAY SUD SI USERNAME UG PASSWORD
            else
            {
                //VERIFY
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

        //VERIFY
        private void verifyLogin()
        {
            if (!bwLogin.IsBusy)
            {
                ShowLoading("Logging in...");
                bwLogin.RunWorkerAsync(); // STARTING BACKGROUND WORK
            }
        }

        //BACKGROUND WORK
        DataTable userinfo;
        private void bwLogin_DoWork(object sender, DoWorkEventArgs e)
            {
                //GETTING INFO TO USERS.CS NGA FILE
                userinfo = Users.GetLogin(txtUserName.Text, txtPassword.Text);
                bwLogin.CancelAsync();
            }

        //BACKGROUND WORK COMPLETE
        private void bwLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideLoading();
            if (Users.GetLoginSucessful)
            {
                //SHOW MESSEGE
                MessageBox.Show("Login successful!");
                MainForm mf = new MainForm();
                this.Hide();
                //NEW WINDOW POINT TO MAINFORM
                mf.Show();
            }
            //ERROR MESSEGE IF WALA ANG CREDENTIALS SA TABLE
            else
            {
                MessageBox.Show("Invalid Login.\nCheck Username and Password.");
            }
        }
    }
}
