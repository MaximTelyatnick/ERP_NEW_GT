namespace ERP_NEW.GUI.Classifiers
{
    partial class LogEditFm
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
            this.nameGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.nameGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProfessionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.modeGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TaskCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nameGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nameGridLookUpEdit
            // 
            this.nameGridLookUpEdit.EditValue = "";
            this.nameGridLookUpEdit.Location = new System.Drawing.Point(23, 38);
            this.nameGridLookUpEdit.Name = "nameGridLookUpEdit";
            this.nameGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nameGridLookUpEdit.Properties.View = this.nameGridLookUpEditView;
            this.nameGridLookUpEdit.Size = new System.Drawing.Size(388, 20);
            this.nameGridLookUpEdit.TabIndex = 1;
            // 
            // nameGridLookUpEditView
            // 
            this.nameGridLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AccountNumber,
            this.Fio,
            this.ProfessionName});
            this.nameGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.nameGridLookUpEditView.Name = "nameGridLookUpEditView";
            this.nameGridLookUpEditView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.nameGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.nameGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // AccountNumber
            // 
            this.AccountNumber.Caption = "Таб.№";
            this.AccountNumber.FieldName = "AccountNumber";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Visible = true;
            this.AccountNumber.VisibleIndex = 0;
            // 
            // Fio
            // 
            this.Fio.Caption = "Користувач";
            this.Fio.FieldName = "Fio";
            this.Fio.Name = "Fio";
            this.Fio.Visible = true;
            this.Fio.VisibleIndex = 1;
            // 
            // ProfessionName
            // 
            this.ProfessionName.Caption = "Професія";
            this.ProfessionName.FieldName = "ProfessionName";
            this.ProfessionName.Name = "ProfessionName";
            this.ProfessionName.Visible = true;
            this.ProfessionName.VisibleIndex = 2;
            // 
            // modeGridLookUpEdit
            // 
            this.modeGridLookUpEdit.Location = new System.Drawing.Point(23, 64);
            this.modeGridLookUpEdit.Name = "modeGridLookUpEdit";
            this.modeGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.modeGridLookUpEdit.Properties.View = this.gridView1;
            this.modeGridLookUpEdit.Size = new System.Drawing.Size(388, 20);
            this.modeGridLookUpEdit.TabIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TaskCaption});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // TaskCaption
            // 
            this.TaskCaption.Caption = "Режим";
            this.TaskCaption.FieldName = "TaskCaption";
            this.TaskCaption.Name = "TaskCaption";
            this.TaskCaption.Visible = true;
            this.TaskCaption.VisibleIndex = 0;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(23, 12);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Size = new System.Drawing.Size(100, 20);
            this.dateEdit.TabIndex = 4;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(262, 113);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(68, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(349, 113);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // LogEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 148);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dateEdit);
            this.Controls.Add(this.modeGridLookUpEdit);
            this.Controls.Add(this.nameGridLookUpEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogEditFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogEdit";
            ((System.ComponentModel.ISupportInitialize)(this.nameGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GridLookUpEdit nameGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView nameGridLookUpEditView;
        private DevExpress.XtraEditors.GridLookUpEdit modeGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Columns.GridColumn Fio;
        private DevExpress.XtraGrid.Columns.GridColumn TaskCaption;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private DevExpress.XtraGrid.Columns.GridColumn ProfessionName;
        private DevExpress.XtraGrid.Columns.GridColumn AccountNumber;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
    }
}