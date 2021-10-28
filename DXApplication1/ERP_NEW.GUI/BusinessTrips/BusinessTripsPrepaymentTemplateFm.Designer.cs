namespace ERP_NEW.GUI.BusinessTrips
{
    partial class BusinessTripsPrepaymentTemplateFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessTripsPrepaymentTemplateFm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.businessTripsEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.docNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.docDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.startDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.endDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fullNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.prepaymentsGrid = new DevExpress.XtraGrid.GridControl();
            this.prepaymentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.selectedCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prepaymentRepository = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.prepaymentDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountsNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prepaymentSumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prepaymentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepaymentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepaymentRepository)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = ((System.Drawing.Font)(resources.GetObject("groupControl1.AppearanceCaption.Font")));
            this.groupControl1.AppearanceCaption.ForeColor = ((System.Drawing.Color)(resources.GetObject("groupControl1.AppearanceCaption.ForeColor")));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.businessTripsEdit);
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Name = "groupControl1";
            // 
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // businessTripsEdit
            // 
            resources.ApplyResources(this.businessTripsEdit, "businessTripsEdit");
            this.businessTripsEdit.Name = "businessTripsEdit";
            this.businessTripsEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.businessTripsEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("businessTripsEdit.Properties.Buttons"))))});
            this.businessTripsEdit.Properties.ImmediatePopup = true;
            this.businessTripsEdit.Properties.PopupFormSize = new System.Drawing.Size(883, 0);
            this.businessTripsEdit.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize;
            this.businessTripsEdit.Properties.View = this.gridView1;
            this.businessTripsEdit.EditValueChanged += new System.EventHandler(this.businessTripsEdit_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.docNumberCol,
            this.docDateCol,
            this.startDateCol,
            this.endDateCol,
            this.accountNumberCol,
            this.fullNameCol});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.SearchInPreview = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // docNumberCol
            // 
            resources.ApplyResources(this.docNumberCol, "docNumberCol");
            this.docNumberCol.FieldName = "Doc_Number";
            this.docNumberCol.Name = "docNumberCol";
            // 
            // docDateCol
            // 
            resources.ApplyResources(this.docDateCol, "docDateCol");
            this.docDateCol.FieldName = "Doc_Date";
            this.docDateCol.Name = "docDateCol";
            // 
            // startDateCol
            // 
            resources.ApplyResources(this.startDateCol, "startDateCol");
            this.startDateCol.FieldName = "StartDate";
            this.startDateCol.Name = "startDateCol";
            // 
            // endDateCol
            // 
            resources.ApplyResources(this.endDateCol, "endDateCol");
            this.endDateCol.FieldName = "EndDate";
            this.endDateCol.Name = "endDateCol";
            // 
            // accountNumberCol
            // 
            resources.ApplyResources(this.accountNumberCol, "accountNumberCol");
            this.accountNumberCol.FieldName = "AccountNumber";
            this.accountNumberCol.Name = "accountNumberCol";
            this.accountNumberCol.OptionsColumn.AllowEdit = false;
            this.accountNumberCol.OptionsColumn.AllowFocus = false;
            this.accountNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // fullNameCol
            // 
            resources.ApplyResources(this.fullNameCol, "fullNameCol");
            this.fullNameCol.FieldName = "FullName";
            this.fullNameCol.Name = "fullNameCol";
            this.fullNameCol.OptionsColumn.AllowEdit = false;
            this.fullNameCol.OptionsColumn.AllowFocus = false;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = ((System.Drawing.Font)(resources.GetObject("groupControl2.AppearanceCaption.Font")));
            this.groupControl2.AppearanceCaption.ForeColor = ((System.Drawing.Color)(resources.GetObject("groupControl2.AppearanceCaption.ForeColor")));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.prepaymentsGrid);
            resources.ApplyResources(this.groupControl2, "groupControl2");
            this.groupControl2.Name = "groupControl2";
            // 
            // prepaymentsGrid
            // 
            resources.ApplyResources(this.prepaymentsGrid, "prepaymentsGrid");
            this.prepaymentsGrid.MainView = this.prepaymentsGridView;
            this.prepaymentsGrid.Name = "prepaymentsGrid";
            this.prepaymentsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.prepaymentRepository});
            this.prepaymentsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.prepaymentsGridView});
            // 
            // prepaymentsGridView
            // 
            this.prepaymentsGridView.Appearance.FooterPanel.Font = ((System.Drawing.Font)(resources.GetObject("prepaymentsGridView.Appearance.FooterPanel.Font")));
            this.prepaymentsGridView.Appearance.FooterPanel.Options.UseFont = true;
            this.prepaymentsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.selectedCol,
            this.prepaymentDateCol,
            this.accountsNumCol,
            this.prepaymentSumCol});
            this.prepaymentsGridView.GridControl = this.prepaymentsGrid;
            this.prepaymentsGridView.Name = "prepaymentsGridView";
            this.prepaymentsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.prepaymentsGridView.OptionsView.ShowAutoFilterRow = true;
            this.prepaymentsGridView.OptionsView.ShowFooter = true;
            this.prepaymentsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // selectedCol
            // 
            resources.ApplyResources(this.selectedCol, "selectedCol");
            this.selectedCol.ColumnEdit = this.prepaymentRepository;
            this.selectedCol.FieldName = "Selected";
            this.selectedCol.Image = ((System.Drawing.Image)(resources.GetObject("selectedCol.Image")));
            this.selectedCol.Name = "selectedCol";
            this.selectedCol.OptionsColumn.ShowCaption = false;
            // 
            // prepaymentRepository
            // 
            resources.ApplyResources(this.prepaymentRepository, "prepaymentRepository");
            this.prepaymentRepository.Name = "prepaymentRepository";
            // 
            // prepaymentDateCol
            // 
            this.prepaymentDateCol.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("prepaymentDateCol.AppearanceHeader.Font")));
            this.prepaymentDateCol.AppearanceHeader.Options.UseFont = true;
            this.prepaymentDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.prepaymentDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.prepaymentDateCol, "prepaymentDateCol");
            this.prepaymentDateCol.FieldName = "Prepayment_Date";
            this.prepaymentDateCol.Name = "prepaymentDateCol";
            this.prepaymentDateCol.OptionsColumn.AllowEdit = false;
            this.prepaymentDateCol.OptionsColumn.AllowFocus = false;
            this.prepaymentDateCol.OptionsFilter.AllowAutoFilter = false;
            this.prepaymentDateCol.OptionsFilter.AllowFilter = false;
            this.prepaymentDateCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("prepaymentDateCol.Summary"))), resources.GetString("prepaymentDateCol.Summary1"), resources.GetString("prepaymentDateCol.Summary2"))});
            // 
            // accountsNumCol
            // 
            this.accountsNumCol.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("accountsNumCol.AppearanceHeader.Font")));
            this.accountsNumCol.AppearanceHeader.Options.UseFont = true;
            this.accountsNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.accountsNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.accountsNumCol, "accountsNumCol");
            this.accountsNumCol.FieldName = "AccountsNum";
            this.accountsNumCol.Name = "accountsNumCol";
            this.accountsNumCol.OptionsColumn.AllowEdit = false;
            this.accountsNumCol.OptionsColumn.AllowFocus = false;
            // 
            // prepaymentSumCol
            // 
            this.prepaymentSumCol.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("prepaymentSumCol.AppearanceHeader.Font")));
            this.prepaymentSumCol.AppearanceHeader.Options.UseFont = true;
            this.prepaymentSumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.prepaymentSumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.prepaymentSumCol, "prepaymentSumCol");
            this.prepaymentSumCol.DisplayFormat.FormatString = "### ### ##0.##";
            this.prepaymentSumCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.prepaymentSumCol.FieldName = "Prepayment";
            this.prepaymentSumCol.Name = "prepaymentSumCol";
            this.prepaymentSumCol.OptionsColumn.AllowEdit = false;
            this.prepaymentSumCol.OptionsColumn.AllowFocus = false;
            this.prepaymentSumCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("prepaymentSumCol.Summary"))), resources.GetString("prepaymentSumCol.Summary1"), resources.GetString("prepaymentSumCol.Summary2"))});
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.cancelBtn, "cancelBtn");
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            resources.ApplyResources(this.saveBtn, "saveBtn");
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // BusinessTripsPrepaymentTemplateFm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusinessTripsPrepaymentTemplateFm";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prepaymentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepaymentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepaymentRepository)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit businessTripsEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn fullNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn accountNumberCol;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl prepaymentsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView prepaymentsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn selectedCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit prepaymentRepository;
        private DevExpress.XtraGrid.Columns.GridColumn prepaymentDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn accountsNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn prepaymentSumCol;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraGrid.Columns.GridColumn docNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn docDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn startDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn endDateCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;

    }
}