namespace BISU_AMS_Desktop
{
    partial class AcademeManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcademeManagementForm));
            this.pnlDepartment = new DevExpress.XtraEditors.PanelControl();
            this.btnCancelDept = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtAbbreviation = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDepartmentName = new DevExpress.XtraEditors.TextEdit();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dtDepartment = new DevExpress.XtraGrid.GridControl();
            this.gvDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deptAbb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.pnlCourse = new DevExpress.XtraEditors.PanelControl();
            this.btnCancelCourse = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCourseAbb = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtCourses = new DevExpress.XtraGrid.GridControl();
            this.gvCourses = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.courseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Abbreviation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSaveCourse = new DevExpress.XtraEditors.SimpleButton();
            this.btnCourseRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnCourseDelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtCourseName = new DevExpress.XtraEditors.TextEdit();
            this.btnCourseAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCourseEdit = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BISU_AMS_Desktop.WaitForm1), true, true);
            this.bwGetDepartment = new System.ComponentModel.BackgroundWorker();
            this.bwGetCourse = new System.ComponentModel.BackgroundWorker();
            this.bwDepartmentSave = new System.ComponentModel.BackgroundWorker();
            this.bwDeleteDepartment = new System.ComponentModel.BackgroundWorker();
            this.bwAddCourse = new System.ComponentModel.BackgroundWorker();
            this.bwDeleteCourse = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDepartment)).BeginInit();
            this.pnlDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAbbreviation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCourse)).BeginInit();
            this.pnlCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseAbb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDepartment
            // 
            this.pnlDepartment.Controls.Add(this.btnCancelDept);
            this.pnlDepartment.Controls.Add(this.labelControl5);
            this.pnlDepartment.Controls.Add(this.txtAbbreviation);
            this.pnlDepartment.Controls.Add(this.labelControl2);
            this.pnlDepartment.Controls.Add(this.btnSave);
            this.pnlDepartment.Controls.Add(this.labelControl1);
            this.pnlDepartment.Controls.Add(this.txtDepartmentName);
            this.pnlDepartment.Controls.Add(this.btnRefresh);
            this.pnlDepartment.Controls.Add(this.btnDelete);
            this.pnlDepartment.Controls.Add(this.btnEdit);
            this.pnlDepartment.Controls.Add(this.btnAdd);
            this.pnlDepartment.Controls.Add(this.dtDepartment);
            this.pnlDepartment.Location = new System.Drawing.Point(8, 8);
            this.pnlDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDepartment.Name = "pnlDepartment";
            this.pnlDepartment.Size = new System.Drawing.Size(373, 648);
            this.pnlDepartment.TabIndex = 0;
            // 
            // btnCancelDept
            // 
            this.btnCancelDept.Enabled = false;
            this.btnCancelDept.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelDept.Image")));
            this.btnCancelDept.Location = new System.Drawing.Point(144, 612);
            this.btnCancelDept.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelDept.Name = "btnCancelDept";
            this.btnCancelDept.Size = new System.Drawing.Size(110, 25);
            this.btnCancelDept.TabIndex = 17;
            this.btnCancelDept.Text = "Cancel";
            this.btnCancelDept.Click += new System.EventHandler(this.btnCancelDept_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(4, 3);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(181, 31);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "DEPARTMENT";
            // 
            // txtAbbreviation
            // 
            this.txtAbbreviation.Enabled = false;
            this.txtAbbreviation.Location = new System.Drawing.Point(145, 584);
            this.txtAbbreviation.Margin = new System.Windows.Forms.Padding(2);
            this.txtAbbreviation.Name = "txtAbbreviation";
            this.txtAbbreviation.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbbreviation.Properties.Appearance.Options.UseFont = true;
            this.txtAbbreviation.Size = new System.Drawing.Size(223, 26);
            this.txtAbbreviation.TabIndex = 15;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(46, 586);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 19);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Abbreviation:";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(258, 612);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 25);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(4, 559);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(135, 19);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Department Name:";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Enabled = false;
            this.txtDepartmentName.Location = new System.Drawing.Point(145, 557);
            this.txtDepartmentName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentName.Properties.Appearance.Options.UseFont = true;
            this.txtDepartmentName.Size = new System.Drawing.Size(223, 26);
            this.txtDepartmentName.TabIndex = 11;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(282, 37);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 29);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(192, 37);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 29);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(101, 37);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 29);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(3, 37);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtDepartment
            // 
            this.dtDepartment.Location = new System.Drawing.Point(4, 70);
            this.dtDepartment.MainView = this.gvDepartment;
            this.dtDepartment.Name = "dtDepartment";
            this.dtDepartment.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.dtDepartment.Size = new System.Drawing.Size(365, 481);
            this.dtDepartment.TabIndex = 6;
            this.dtDepartment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDepartment});
            // 
            // gvDepartment
            // 
            this.gvDepartment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.deptAbb,
            this.name});
            this.gvDepartment.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvDepartment.GridControl = this.dtDepartment;
            this.gvDepartment.Name = "gvDepartment";
            this.gvDepartment.OptionsBehavior.Editable = false;
            this.gvDepartment.OptionsBehavior.ReadOnly = true;
            this.gvDepartment.OptionsFind.AlwaysVisible = true;
            this.gvDepartment.OptionsView.ShowGroupPanel = false;
            this.gvDepartment.OptionsView.ShowIndicator = false;
            this.gvDepartment.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDepartment_FocusedRowChanged);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "id";
            this.ID.Name = "ID";
            // 
            // deptAbb
            // 
            this.deptAbb.Caption = "Abbreviation";
            this.deptAbb.FieldName = "abbreviation";
            this.deptAbb.MaxWidth = 100;
            this.deptAbb.Name = "deptAbb";
            this.deptAbb.Visible = true;
            this.deptAbb.VisibleIndex = 0;
            this.deptAbb.Width = 30;
            // 
            // name
            // 
            this.name.AppearanceCell.Options.UseTextOptions = true;
            this.name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.name.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.name.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.name.AppearanceHeader.Options.UseTextOptions = true;
            this.name.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.name.Caption = "Department Name";
            this.name.ColumnEdit = this.repositoryItemMemoEdit1;
            this.name.FieldName = "name";
            this.name.Name = "name";
            this.name.OptionsColumn.AllowEdit = false;
            this.name.OptionsColumn.ReadOnly = true;
            this.name.OptionsEditForm.RowSpan = 0;
            this.name.OptionsEditForm.StartNewRow = true;
            this.name.Visible = true;
            this.name.VisibleIndex = 1;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            this.repositoryItemMemoEdit1.ReadOnly = true;
            // 
            // pnlCourse
            // 
            this.pnlCourse.Controls.Add(this.btnCancelCourse);
            this.pnlCourse.Controls.Add(this.labelControl6);
            this.pnlCourse.Controls.Add(this.txtCourseAbb);
            this.pnlCourse.Controls.Add(this.labelControl3);
            this.pnlCourse.Controls.Add(this.dtCourses);
            this.pnlCourse.Controls.Add(this.btnSaveCourse);
            this.pnlCourse.Controls.Add(this.btnCourseRefresh);
            this.pnlCourse.Controls.Add(this.labelControl4);
            this.pnlCourse.Controls.Add(this.btnCourseDelete);
            this.pnlCourse.Controls.Add(this.txtCourseName);
            this.pnlCourse.Controls.Add(this.btnCourseAdd);
            this.pnlCourse.Controls.Add(this.btnCourseEdit);
            this.pnlCourse.Location = new System.Drawing.Point(386, 8);
            this.pnlCourse.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCourse.Name = "pnlCourse";
            this.pnlCourse.Size = new System.Drawing.Size(372, 648);
            this.pnlCourse.TabIndex = 1;
            // 
            // btnCancelCourse
            // 
            this.btnCancelCourse.Enabled = false;
            this.btnCancelCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelCourse.Image")));
            this.btnCancelCourse.Location = new System.Drawing.Point(144, 612);
            this.btnCancelCourse.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelCourse.Name = "btnCancelCourse";
            this.btnCancelCourse.Size = new System.Drawing.Size(110, 25);
            this.btnCancelCourse.TabIndex = 18;
            this.btnCancelCourse.Text = "Cancel";
            this.btnCancelCourse.Click += new System.EventHandler(this.btnCancelCourse_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(4, 3);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(107, 31);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "COURSE";
            // 
            // txtCourseAbb
            // 
            this.txtCourseAbb.Enabled = false;
            this.txtCourseAbb.Location = new System.Drawing.Point(144, 584);
            this.txtCourseAbb.Margin = new System.Windows.Forms.Padding(2);
            this.txtCourseAbb.Name = "txtCourseAbb";
            this.txtCourseAbb.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseAbb.Properties.Appearance.Options.UseFont = true;
            this.txtCourseAbb.Size = new System.Drawing.Size(224, 26);
            this.txtCourseAbb.TabIndex = 20;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(47, 586);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 19);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Abbreviation:";
            // 
            // dtCourses
            // 
            this.dtCourses.Location = new System.Drawing.Point(3, 70);
            this.dtCourses.MainView = this.gvCourses;
            this.dtCourses.Name = "dtCourses";
            this.dtCourses.Size = new System.Drawing.Size(365, 481);
            this.dtCourses.TabIndex = 16;
            this.dtCourses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCourses});
            // 
            // gvCourses
            // 
            this.gvCourses.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.courseName,
            this.Abbreviation});
            this.gvCourses.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvCourses.GridControl = this.dtCourses;
            this.gvCourses.Name = "gvCourses";
            this.gvCourses.OptionsBehavior.Editable = false;
            this.gvCourses.OptionsBehavior.ReadOnly = true;
            this.gvCourses.OptionsFind.AlwaysVisible = true;
            this.gvCourses.OptionsView.ShowGroupPanel = false;
            this.gvCourses.OptionsView.ShowIndicator = false;
            this.gvCourses.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCourses_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // courseName
            // 
            this.courseName.Caption = "Course Name";
            this.courseName.FieldName = "name";
            this.courseName.Name = "courseName";
            this.courseName.Visible = true;
            this.courseName.VisibleIndex = 1;
            // 
            // Abbreviation
            // 
            this.Abbreviation.Caption = "Abbreviation";
            this.Abbreviation.FieldName = "abbreviation";
            this.Abbreviation.MaxWidth = 100;
            this.Abbreviation.Name = "Abbreviation";
            this.Abbreviation.Visible = true;
            this.Abbreviation.VisibleIndex = 0;
            // 
            // btnSaveCourse
            // 
            this.btnSaveCourse.Enabled = false;
            this.btnSaveCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCourse.Image")));
            this.btnSaveCourse.Location = new System.Drawing.Point(258, 612);
            this.btnSaveCourse.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveCourse.Name = "btnSaveCourse";
            this.btnSaveCourse.Size = new System.Drawing.Size(110, 25);
            this.btnSaveCourse.TabIndex = 18;
            this.btnSaveCourse.Text = "Save";
            this.btnSaveCourse.Click += new System.EventHandler(this.btnSaveCourse_Click);
            // 
            // btnCourseRefresh
            // 
            this.btnCourseRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnCourseRefresh.Image")));
            this.btnCourseRefresh.Location = new System.Drawing.Point(283, 37);
            this.btnCourseRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnCourseRefresh.Name = "btnCourseRefresh";
            this.btnCourseRefresh.Size = new System.Drawing.Size(86, 29);
            this.btnCourseRefresh.TabIndex = 19;
            this.btnCourseRefresh.Text = "Refresh";
            this.btnCourseRefresh.Click += new System.EventHandler(this.btnCourseRefresh_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(41, 559);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 19);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Course Name:";
            // 
            // btnCourseDelete
            // 
            this.btnCourseDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnCourseDelete.Image")));
            this.btnCourseDelete.Location = new System.Drawing.Point(192, 37);
            this.btnCourseDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnCourseDelete.Name = "btnCourseDelete";
            this.btnCourseDelete.Size = new System.Drawing.Size(86, 29);
            this.btnCourseDelete.TabIndex = 18;
            this.btnCourseDelete.Text = "Delete";
            this.btnCourseDelete.Click += new System.EventHandler(this.btnCourseDelete_Click);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Enabled = false;
            this.txtCourseName.Location = new System.Drawing.Point(144, 557);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Properties.Appearance.Options.UseFont = true;
            this.txtCourseName.Size = new System.Drawing.Size(224, 26);
            this.txtCourseName.TabIndex = 16;
            // 
            // btnCourseAdd
            // 
            this.btnCourseAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnCourseAdd.Image")));
            this.btnCourseAdd.Location = new System.Drawing.Point(4, 37);
            this.btnCourseAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnCourseAdd.Name = "btnCourseAdd";
            this.btnCourseAdd.Size = new System.Drawing.Size(94, 29);
            this.btnCourseAdd.TabIndex = 16;
            this.btnCourseAdd.Text = "Add";
            this.btnCourseAdd.Click += new System.EventHandler(this.btnCourseAdd_Click);
            // 
            // btnCourseEdit
            // 
            this.btnCourseEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnCourseEdit.Image")));
            this.btnCourseEdit.Location = new System.Drawing.Point(102, 37);
            this.btnCourseEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnCourseEdit.Name = "btnCourseEdit";
            this.btnCourseEdit.Size = new System.Drawing.Size(86, 29);
            this.btnCourseEdit.TabIndex = 17;
            this.btnCourseEdit.Text = "Edit";
            this.btnCourseEdit.Click += new System.EventHandler(this.btnCourseEdit_Click);
            // 
            // bwGetDepartment
            // 
            this.bwGetDepartment.WorkerSupportsCancellation = true;
            this.bwGetDepartment.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetDepartment_DoWork);
            this.bwGetDepartment.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetDepartment_RunWorkerCompleted);
            // 
            // bwGetCourse
            // 
            this.bwGetCourse.WorkerSupportsCancellation = true;
            this.bwGetCourse.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetCourse_DoWork);
            this.bwGetCourse.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwGetCourse_RunWorkerCompleted);
            // 
            // bwDepartmentSave
            // 
            this.bwDepartmentSave.WorkerSupportsCancellation = true;
            this.bwDepartmentSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDepartmentSave_DoWork);
            this.bwDepartmentSave.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwDepartmentSave_RunWorkerCompleted);
            // 
            // bwDeleteDepartment
            // 
            this.bwDeleteDepartment.WorkerSupportsCancellation = true;
            this.bwDeleteDepartment.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDeleteDepartment_DoWork);
            this.bwDeleteDepartment.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwDeleteDepartment_RunWorkerCompleted);
            // 
            // bwAddCourse
            // 
            this.bwAddCourse.WorkerSupportsCancellation = true;
            this.bwAddCourse.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAddCourse_DoWork);
            this.bwAddCourse.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwAddCourse_RunWorkerCompleted);
            // 
            // bwDeleteCourse
            // 
            this.bwDeleteCourse.WorkerSupportsCancellation = true;
            this.bwDeleteCourse.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDeleteCourse_DoWork);
            this.bwDeleteCourse.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwDeleteCourse_RunWorkerCompleted);
            // 
            // AcademeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 664);
            this.Controls.Add(this.pnlCourse);
            this.Controls.Add(this.pnlDepartment);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1119, 1019);
            this.Name = "AcademeManagementForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AcademeManagementForm";
            this.Shown += new System.EventHandler(this.AcademeManagementForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDepartment)).EndInit();
            this.pnlDepartment.ResumeLayout(false);
            this.pnlDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAbbreviation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCourse)).EndInit();
            this.pnlCourse.ResumeLayout(false);
            this.pnlCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseAbb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCourseName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlDepartment;
        private DevExpress.XtraEditors.PanelControl pnlCourse;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl dtDepartment;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraEditors.TextEdit txtAbbreviation;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDepartmentName;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private System.ComponentModel.BackgroundWorker bwGetDepartment;
        private DevExpress.XtraEditors.TextEdit txtCourseAbb;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl dtCourses;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCourses;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn courseName;
        private DevExpress.XtraEditors.SimpleButton btnSaveCourse;
        private DevExpress.XtraEditors.SimpleButton btnCourseRefresh;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnCourseDelete;
        private DevExpress.XtraEditors.TextEdit txtCourseName;
        private DevExpress.XtraEditors.SimpleButton btnCourseAdd;
        private DevExpress.XtraEditors.SimpleButton btnCourseEdit;
        private DevExpress.XtraGrid.Columns.GridColumn deptAbb;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private System.ComponentModel.BackgroundWorker bwGetCourse;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn Abbreviation;
        private System.ComponentModel.BackgroundWorker bwDepartmentSave;
        private System.ComponentModel.BackgroundWorker bwDeleteDepartment;
        private DevExpress.XtraEditors.SimpleButton btnCancelDept;
        private DevExpress.XtraEditors.SimpleButton btnCancelCourse;
        private System.ComponentModel.BackgroundWorker bwAddCourse;
        private System.ComponentModel.BackgroundWorker bwDeleteCourse;
    }
}