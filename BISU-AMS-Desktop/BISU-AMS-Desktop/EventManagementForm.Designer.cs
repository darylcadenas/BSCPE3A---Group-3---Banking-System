namespace BISU_AMS_Desktop
{
    partial class EventManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventManagementForm));
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BISU_AMS_Desktop.WaitForm1), true, true);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtEvents = new DevExpress.XtraGrid.GridControl();
            this.gvEvents = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EventName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fines = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EventDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.txtEventName = new DevExpress.XtraEditors.TextEdit();
            this.txtFines = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.bw = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dtEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEventName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFines.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(701, 53);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 29);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Event Name";
            // 
            // dtEvents
            // 
            this.dtEvents.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dtEvents.Location = new System.Drawing.Point(17, 53);
            this.dtEvents.MainView = this.gvEvents;
            this.dtEvents.Margin = new System.Windows.Forms.Padding(4);
            this.dtEvents.Name = "dtEvents";
            this.dtEvents.Size = new System.Drawing.Size(649, 430);
            this.dtEvents.TabIndex = 3;
            this.dtEvents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEvents});
            // 
            // gvEvents
            // 
            this.gvEvents.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.EventName,
            this.Fines,
            this.EventDate});
            this.gvEvents.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvEvents.GridControl = this.dtEvents;
            this.gvEvents.Name = "gvEvents";
            this.gvEvents.OptionsFind.AlwaysVisible = true;
            this.gvEvents.OptionsView.ShowGroupPanel = false;
            this.gvEvents.OptionsView.ShowIndicator = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "id";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // EventName
            // 
            this.EventName.Caption = "Event Name";
            this.EventName.FieldName = "name";
            this.EventName.Name = "EventName";
            this.EventName.Visible = true;
            this.EventName.VisibleIndex = 1;
            // 
            // Fines
            // 
            this.Fines.Caption = "Fines";
            this.Fines.FieldName = "fines";
            this.Fines.Name = "Fines";
            this.Fines.Visible = true;
            this.Fines.VisibleIndex = 2;
            // 
            // EventDate
            // 
            this.EventDate.Caption = "Date";
            this.EventDate.FieldName = "event_date";
            this.EventDate.Name = "EventDate";
            this.EventDate.Visible = true;
            this.EventDate.VisibleIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(17, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(181, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(156, 40);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(346, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 40);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(510, 4);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(156, 40);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(701, 92);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Properties.Appearance.Options.UseFont = true;
            this.txtEventName.Size = new System.Drawing.Size(294, 36);
            this.txtEventName.TabIndex = 8;
            // 
            // txtFines
            // 
            this.txtFines.Location = new System.Drawing.Point(701, 184);
            this.txtFines.Margin = new System.Windows.Forms.Padding(4);
            this.txtFines.Name = "txtFines";
            this.txtFines.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFines.Properties.Appearance.Options.UseFont = true;
            this.txtFines.Size = new System.Drawing.Size(294, 36);
            this.txtFines.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(701, 145);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 29);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Fines";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(701, 277);
            this.dateEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit1.Properties.Appearance.Options.UseFont = true;
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(294, 36);
            this.dateEdit1.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(701, 239);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(117, 29);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Event Date";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(840, 341);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 40);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            // 
            // bw
            // 
            this.bw.WorkerSupportsCancellation = true;
            // 
            // EventManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 519);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.txtFines);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtEvents);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EventManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EventManagementForm";
            this.Shown += new System.EventHandler(this.EventManagementForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEventName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFines.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dtEvents;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEvents;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn EventName;
        private DevExpress.XtraGrid.Columns.GridColumn Fines;
        private DevExpress.XtraGrid.Columns.GridColumn EventDate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.TextEdit txtEventName;
        private DevExpress.XtraEditors.TextEdit txtFines;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.ComponentModel.BackgroundWorker bw;
    }
}