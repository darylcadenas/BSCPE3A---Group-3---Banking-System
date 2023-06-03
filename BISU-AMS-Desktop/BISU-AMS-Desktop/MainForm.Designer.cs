namespace BISU_AMS_Desktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAttendance = new DevExpress.XtraBars.BarButtonItem();
            this.btnStudents = new DevExpress.XtraBars.BarButtonItem();
            this.btnFines = new DevExpress.XtraBars.BarButtonItem();
            this.btnUserManagement = new DevExpress.XtraBars.BarButtonItem();
            this.btnEventManagement = new DevExpress.XtraBars.BarButtonItem();
            this.btnAcademe = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpAdmin = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnAttendance,
            this.btnStudents,
            this.btnFines,
            this.btnUserManagement,
            this.btnEventManagement,
            this.btnAcademe});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.rpAdmin});
            this.ribbon.Size = new System.Drawing.Size(1684, 194);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnAttendance
            // 
            this.btnAttendance.Caption = "Attendance";
            this.btnAttendance.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAttendance.Glyph")));
            this.btnAttendance.Id = 1;
            this.btnAttendance.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAttendance.LargeGlyph")));
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAttendance_ItemClick);
            // 
            // btnStudents
            // 
            this.btnStudents.Caption = "Students";
            this.btnStudents.Glyph = ((System.Drawing.Image)(resources.GetObject("btnStudents.Glyph")));
            this.btnStudents.Id = 2;
            this.btnStudents.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnStudents.LargeGlyph")));
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStudents_ItemClick);
            // 
            // btnFines
            // 
            this.btnFines.Caption = "Student Fines";
            this.btnFines.Glyph = ((System.Drawing.Image)(resources.GetObject("btnFines.Glyph")));
            this.btnFines.Id = 3;
            this.btnFines.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnFines.LargeGlyph")));
            this.btnFines.Name = "btnFines";
            this.btnFines.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFines_ItemClick);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Caption = "User Management";
            this.btnUserManagement.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUserManagement.Glyph")));
            this.btnUserManagement.Id = 4;
            this.btnUserManagement.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnUserManagement.LargeGlyph")));
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUserManagement_ItemClick);
            // 
            // btnEventManagement
            // 
            this.btnEventManagement.Caption = "Event Management";
            this.btnEventManagement.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEventManagement.Glyph")));
            this.btnEventManagement.Id = 5;
            this.btnEventManagement.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEventManagement.LargeGlyph")));
            this.btnEventManagement.Name = "btnEventManagement";
            this.btnEventManagement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEventManagement_ItemClick);
            // 
            // btnAcademe
            // 
            this.btnAcademe.Caption = "Academe Managment";
            this.btnAcademe.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAcademe.Glyph")));
            this.btnAcademe.Id = 6;
            this.btnAcademe.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAcademe.LargeGlyph")));
            this.btnAcademe.Name = "btnAcademe";
            this.btnAcademe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAcademe_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "AMS";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAttendance);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Attendance";
            // 
            // rpAdmin
            // 
            this.rpAdmin.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rpAdmin.Name = "rpAdmin";
            this.rpAdmin.Text = "Administrator";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnStudents);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnFines);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUserManagement);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnEventManagement);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAcademe);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Management";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 789);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1684, 39);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 828);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnAttendance;
        private DevExpress.XtraBars.BarButtonItem btnStudents;
        private DevExpress.XtraBars.BarButtonItem btnFines;
        private DevExpress.XtraBars.BarButtonItem btnUserManagement;
        private DevExpress.XtraBars.BarButtonItem btnEventManagement;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAdmin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnAcademe;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
    }
}