namespace BISU_AMS_Desktop
{
    partial class AttendanceForm
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
            this.txtStudentID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtAttendances = new DevExpress.XtraGrid.GridControl();
            this.gvAttendances = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StudentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Time_In = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Time_Out = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Time_In_PM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Time_Out_PM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.splashScreenManager3 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BISU_AMS_Desktop.WaitForm1), true, true);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbEvents = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTimeMode = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAttendances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAttendances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEvents.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimeMode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(17, 63);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Properties.Appearance.Options.UseFont = true;
            this.txtStudentID.Size = new System.Drawing.Size(612, 64);
            this.txtStudentID.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Student ID";
            // 
            // dtAttendances
            // 
            this.dtAttendances.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dtAttendances.Location = new System.Drawing.Point(17, 236);
            this.dtAttendances.MainView = this.gvAttendances;
            this.dtAttendances.Margin = new System.Windows.Forms.Padding(4);
            this.dtAttendances.Name = "dtAttendances";
            this.dtAttendances.Size = new System.Drawing.Size(1317, 413);
            this.dtAttendances.TabIndex = 2;
            this.dtAttendances.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAttendances});
            // 
            // gvAttendances
            // 
            this.gvAttendances.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.StudentID,
            this.Time_In,
            this.Time_Out,
            this.Time_In_PM,
            this.Time_Out_PM});
            this.gvAttendances.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvAttendances.GridControl = this.dtAttendances;
            this.gvAttendances.Name = "gvAttendances";
            this.gvAttendances.OptionsFind.AlwaysVisible = true;
            this.gvAttendances.OptionsView.ShowGroupPanel = false;
            this.gvAttendances.OptionsView.ShowIndicator = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "id";
            this.ID.Name = "ID";
            // 
            // StudentID
            // 
            this.StudentID.Caption = "Student ID";
            this.StudentID.FieldName = "student_id";
            this.StudentID.Name = "StudentID";
            this.StudentID.Visible = true;
            this.StudentID.VisibleIndex = 0;
            // 
            // Time_In
            // 
            this.Time_In.Caption = "Time - IN (AM)";
            this.Time_In.FieldName = "am_time_in";
            this.Time_In.Name = "Time_In";
            this.Time_In.Visible = true;
            this.Time_In.VisibleIndex = 1;
            // 
            // Time_Out
            // 
            this.Time_Out.Caption = "Time - Out (AM)";
            this.Time_Out.FieldName = "am_time_out";
            this.Time_Out.Name = "Time_Out";
            this.Time_Out.Visible = true;
            this.Time_Out.VisibleIndex = 2;
            // 
            // Time_In_PM
            // 
            this.Time_In_PM.Caption = "Time - In (PM)";
            this.Time_In_PM.FieldName = "pm_time_in";
            this.Time_In_PM.Name = "Time_In_PM";
            this.Time_In_PM.Visible = true;
            this.Time_In_PM.VisibleIndex = 3;
            // 
            // Time_Out_PM
            // 
            this.Time_Out_PM.Caption = "Time - Out (PM)";
            this.Time_Out_PM.FieldName = "pm_time_out";
            this.Time_Out_PM.Name = "Time_Out_PM";
            this.Time_Out_PM.Visible = true;
            this.Time_Out_PM.VisibleIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(17, 184);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(364, 46);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Recent Attendance";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(17, 134);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 28);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Event :";
            // 
            // cmbEvents
            // 
            this.cmbEvents.Location = new System.Drawing.Point(95, 131);
            this.cmbEvents.Name = "cmbEvents";
            this.cmbEvents.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEvents.Properties.Appearance.Options.UseFont = true;
            this.cmbEvents.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEvents.Size = new System.Drawing.Size(223, 34);
            this.cmbEvents.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(328, 134);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 28);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Mode : ";
            // 
            // cmbTimeMode
            // 
            this.cmbTimeMode.Location = new System.Drawing.Point(406, 131);
            this.cmbTimeMode.Name = "cmbTimeMode";
            this.cmbTimeMode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimeMode.Properties.Appearance.Options.UseFont = true;
            this.cmbTimeMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTimeMode.Properties.Items.AddRange(new object[] {
            "AM-In",
            "AM-Out",
            "PM-In",
            "PM-Out"});
            this.cmbTimeMode.Properties.NullText = "AM-In";
            this.cmbTimeMode.Properties.PopupSizeable = true;
            this.cmbTimeMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTimeMode.Size = new System.Drawing.Size(223, 34);
            this.cmbTimeMode.TabIndex = 9;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 666);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmbEvents);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dtAttendances);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.cmbTimeMode);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAttendances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAttendances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEvents.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimeMode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
        private DevExpress.XtraEditors.TextEdit txtStudentID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dtAttendances;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAttendances;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn StudentID;
        private DevExpress.XtraGrid.Columns.GridColumn Time_In;
        private DevExpress.XtraGrid.Columns.GridColumn Time_Out;
        private DevExpress.XtraGrid.Columns.GridColumn Time_In_PM;
        private DevExpress.XtraGrid.Columns.GridColumn Time_Out_PM;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit cmbEvents;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTimeMode;
    }
}