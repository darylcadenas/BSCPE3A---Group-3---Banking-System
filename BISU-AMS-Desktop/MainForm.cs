using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.IO;

namespace BISU_AMS_Desktop
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static bool StudentManagementFormIsOpen = false;
        private void btnStudents_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!StudentManagementFormIsOpen)
            {
                StudentManagementFormIsOpen = true;
                StudentManagementForm af = new StudentManagementForm();
                af.MdiParent = this;
                af.WindowState = FormWindowState.Maximized;
                af.Show();
            }
            else
            {
                Form fc = Application.OpenForms["StudentManagementForm"];
                if (fc == null)
                {
                    StudentManagementForm a1 = new StudentManagementForm();
                    a1.MdiParent = this;
                    a1.Show();
                }
                else
                    fc.Activate();
            }
        }

        private void btnFines_ItemClick(object sender, ItemClickEventArgs e)
        {
            FinesManagementForm fmf = new FinesManagementForm();
            fmf.ShowDialog();
        }

        private void btnUserManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserManagementForm umf = new UserManagementForm();
            umf.ShowDialog();
        }

        private void btnEventManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            EventManagementForm emf = new EventManagementForm();
            emf.ShowDialog();
        }

        public static bool AttendanceFormIsOpen = false;
        private void btnAttendance_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!AttendanceFormIsOpen)
            {
                AttendanceFormIsOpen = true;
                AttendanceForm af = new AttendanceForm();
                af.MdiParent = this;
                af.WindowState = FormWindowState.Maximized;
                af.Show();
            }
            else
            {
                Form fc = Application.OpenForms["AttendanceForm"];
                if (fc == null)
                {
                    AttendanceForm a1 = new AttendanceForm();
                    a1.MdiParent = this;
                    a1.Show();
                }
                else
                    fc.Activate();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            ////non-static background image
            //string LocalDirectory = Directory.GetCurrentDirectory();
            //string BgFilePath = LocalDirectory + "\\images\\MFbackground.jpg";
            //this.BackgroundImage = Image.FromFile(BgFilePath);
            //this.BackgroundImageLayout = ImageLayout.Stretch;
            //string IconFilePath = LocalDirectory + "\\images\\icon.ico";
            //this.Icon = Properties.Resources.BisuIcon;
        }

        private void btnAcademe_ItemClick(object sender, ItemClickEventArgs e)
        {
            AcademeManagementForm amf = new AcademeManagementForm();
            amf.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}