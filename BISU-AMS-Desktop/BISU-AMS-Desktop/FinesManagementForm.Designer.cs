namespace BISU_AMS_Desktop
{
    partial class FinesManagementForm
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
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BISU_AMS_Desktop.WaitForm1), true, true);
            this.dtAttendances = new DevExpress.XtraGrid.GridControl();
            this.gvAttendances = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StudentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Course = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Department = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbEvents = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbDepartment = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCourse = new DevExpress.XtraEditors.LookUpEdit();
            this.bw = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dtAttendances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAttendances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEvents.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCourse.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtAttendances
            // 
            this.dtAttendances.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dtAttendances.Location = new System.Drawing.Point(13, 84);
            this.dtAttendances.MainView = this.gvAttendances;
            this.dtAttendances.Margin = new System.Windows.Forms.Padding(4);
            this.dtAttendances.Name = "dtAttendances";
            this.dtAttendances.Size = new System.Drawing.Size(1290, 623);
            this.dtAttendances.TabIndex = 4;
            this.dtAttendances.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAttendances});
            // 
            // gvAttendances
            // 
            this.gvAttendances.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.StudentID,
            this.FullName,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Course,
            this.Department});
            this.gvAttendances.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvAttendances.GridControl = this.dtAttendances;
            this.gvAttendances.Name = "gvAttendances";
            this.gvAttendances.OptionsFind.AlwaysVisible = true;
            this.gvAttendances.OptionsView.ShowGroupPanel = false;
            this.gvAttendances.OptionsView.ShowIndicator = false;
            this.gvAttendances.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvAttendances_RowClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "id";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // StudentID
            // 
            this.StudentID.Caption = "Student ID";
            this.StudentID.FieldName = "student_id";
            this.StudentID.Name = "StudentID";
            this.StudentID.Visible = true;
            this.StudentID.VisibleIndex = 1;
            // 
            // FullName
            // 
            this.FullName.Caption = "Full Name";
            this.FullName.FieldName = "fullname";
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 2;
            // 
            // FirstName
            // 
            this.FirstName.Caption = "First Name";
            this.FirstName.FieldName = "first_name";
            this.FirstName.Name = "FirstName";
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 3;
            // 
            // MiddleName
            // 
            this.MiddleName.Caption = "Middle Name";
            this.MiddleName.FieldName = "middle_name";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Visible = true;
            this.MiddleName.VisibleIndex = 4;
            // 
            // LastName
            // 
            this.LastName.Caption = "Last Name";
            this.LastName.FieldName = "last_name";
            this.LastName.Name = "LastName";
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 5;
            // 
            // Course
            // 
            this.Course.Caption = "Course";
            this.Course.FieldName = "course";
            this.Course.Name = "Course";
            this.Course.Visible = true;
            this.Course.VisibleIndex = 6;
            // 
            // Department
            // 
            this.Department.Caption = "Department";
            this.Department.FieldName = "department";
            this.Department.Name = "Department";
            this.Department.Visible = true;
            this.Department.VisibleIndex = 7;
            // 
            // cmbEvents
            // 
            this.cmbEvents.Location = new System.Drawing.Point(91, 34);
            this.cmbEvents.Name = "cmbEvents";
            this.cmbEvents.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEvents.Properties.Appearance.Options.UseFont = true;
            this.cmbEvents.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEvents.Size = new System.Drawing.Size(223, 34);
            this.cmbEvents.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(13, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 28);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Event :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(335, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(143, 28);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Department : ";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Location = new System.Drawing.Point(484, 34);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.Properties.Appearance.Options.UseFont = true;
            this.cmbDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDepartment.Size = new System.Drawing.Size(223, 34);
            this.cmbDepartment.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(720, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 28);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Course : ";
            // 
            // cmbCourse
            // 
            this.cmbCourse.Location = new System.Drawing.Point(817, 34);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourse.Properties.Appearance.Options.UseFont = true;
            this.cmbCourse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCourse.Size = new System.Drawing.Size(223, 34);
            this.cmbCourse.TabIndex = 9;
            // 
            // bw
            // 
            this.bw.WorkerSupportsCancellation = true;
            // 
            // FinesManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 720);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbEvents);
            this.Controls.Add(this.dtAttendances);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinesManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FinesManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtAttendances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAttendances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEvents.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCourse.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraGrid.GridControl dtAttendances;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAttendances;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn StudentID;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn MiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn Course;
        private DevExpress.XtraGrid.Columns.GridColumn Department;
        private DevExpress.XtraEditors.LookUpEdit cmbEvents;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit cmbDepartment;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit cmbCourse;
        private System.ComponentModel.BackgroundWorker bw;
    }
}