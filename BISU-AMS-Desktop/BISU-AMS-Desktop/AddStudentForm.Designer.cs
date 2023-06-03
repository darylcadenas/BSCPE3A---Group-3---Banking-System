namespace BISU_AMS_Desktop
{
    partial class AddStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            this.bwLoadDepartment = new System.ComponentModel.BackgroundWorker();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BISU_AMS_Desktop.WaitForm1), true, true);
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtStudentID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbDepartment = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCourse = new DevExpress.XtraEditors.LookUpEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.bwLoadCourse = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCourse.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bwLoadDepartment
            // 
            this.bwLoadDepartment.WorkerSupportsCancellation = true;
            this.bwLoadDepartment.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadDepartment_DoWork);
            this.bwLoadDepartment.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadDepartment_RunWorkerCompleted);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(755, 194);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 40);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(315, 96);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(126, 29);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Department";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(315, 52);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Properties.Appearance.Options.UseFont = true;
            this.txtMiddleName.Size = new System.Drawing.Size(294, 36);
            this.txtMiddleName.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(315, 13);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(138, 29);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Middle Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(13, 52);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Properties.Appearance.Options.UseFont = true;
            this.txtFirstName.Size = new System.Drawing.Size(294, 36);
            this.txtFirstName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(124, 29);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "First Name ";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(617, 52);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Properties.Appearance.Options.UseFont = true;
            this.txtLastName.Size = new System.Drawing.Size(294, 36);
            this.txtLastName.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(617, 13);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(114, 29);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Last Name";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(13, 135);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Properties.Appearance.Options.UseFont = true;
            this.txtStudentID.Size = new System.Drawing.Size(294, 36);
            this.txtStudentID.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(13, 96);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(114, 29);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Student ID";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Location = new System.Drawing.Point(315, 134);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.Properties.Appearance.Options.UseFont = true;
            this.cmbDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDepartment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("abbreviation", "department"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "Name2", 20, DevExpress.Utils.FormatType.None, global::BISU_AMS_Desktop.Properties.Resources.DefaultIconFile, false, DevExpress.Utils.HorzAlignment.Default)});
            this.cmbDepartment.Properties.NullText = "--SELECT DEPARTMENT--";
            this.cmbDepartment.Properties.PopupSizeable = false;
            this.cmbDepartment.Properties.ShowFooter = false;
            this.cmbDepartment.Properties.ShowHeader = false;
            this.cmbDepartment.Size = new System.Drawing.Size(294, 36);
            this.cmbDepartment.TabIndex = 5;
            this.cmbDepartment.EditValueChanged += new System.EventHandler(this.cmbDepartment_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(617, 96);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 29);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "Course";
            // 
            // cmbCourse
            // 
            this.cmbCourse.Location = new System.Drawing.Point(617, 134);
            this.cmbCourse.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourse.Properties.Appearance.Options.UseFont = true;
            this.cmbCourse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCourse.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("abbreviation", "abb"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 20, DevExpress.Utils.FormatType.None, global::BISU_AMS_Desktop.Properties.Resources.DefaultIconFile, false, DevExpress.Utils.HorzAlignment.Default)});
            this.cmbCourse.Properties.NullText = "--SELECT COURSE--";
            this.cmbCourse.Properties.PopupSizeable = false;
            this.cmbCourse.Properties.ShowFooter = false;
            this.cmbCourse.Properties.ShowHeader = false;
            this.cmbCourse.Size = new System.Drawing.Size(294, 36);
            this.cmbCourse.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(591, 194);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 40);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bwLoadCourse
            // 
            this.bwLoadCourse.WorkerSupportsCancellation = true;
            this.bwLoadCourse.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoadCourse_DoWork);
            this.bwLoadCourse.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoadCourse_RunWorkerCompleted);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 263);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(956, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(935, 263);
            this.Name = "AddStudentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddStudentForm";
            this.Shown += new System.EventHandler(this.AddStudentForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCourse.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bwLoadDepartment;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMiddleName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtStudentID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit cmbDepartment;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit cmbCourse;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.ComponentModel.BackgroundWorker bwLoadCourse;
    }
}