namespace ERP_NEW.GUI.BusinessTrips
{
    partial class BusinessTripsPaymentTemplateFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessTripsPaymentTemplateFm));
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
            this.paymentsGrid = new DevExpress.XtraGrid.GridControl();
            this.paymentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.selectedPaymentCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selectPaymentRepository = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.docDatePaymentCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reportNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.commentCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.startReportDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.endReportDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vatAccountNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vatPaymentCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.currencyNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.currencyPaymentCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paymentSumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPaymentRepository)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.businessTripsEdit);
            this.groupControl1.Location = new System.Drawing.Point(12, 11);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1356, 60);
            this.groupControl1.TabIndex = 49;
            this.groupControl1.Text = "Інформація про заявку";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 13);
            this.labelControl3.TabIndex = 48;
            this.labelControl3.Text = "Номер заявки:";
            // 
            // businessTripsEdit
            // 
            this.businessTripsEdit.Location = new System.Drawing.Point(107, 32);
            this.businessTripsEdit.Name = "businessTripsEdit";
            this.businessTripsEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.businessTripsEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.businessTripsEdit.Properties.ImmediatePopup = true;
            this.businessTripsEdit.Properties.PopupFormSize = new System.Drawing.Size(883, 0);
            this.businessTripsEdit.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize;
            this.businessTripsEdit.Properties.View = this.gridView1;
            this.businessTripsEdit.Size = new System.Drawing.Size(757, 20);
            this.businessTripsEdit.TabIndex = 7;
            this.businessTripsEdit.ToolTip = "П.І.Б працівника";
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
            this.docNumberCol.Caption = "Номер заявки";
            this.docNumberCol.FieldName = "Doc_Number";
            this.docNumberCol.Name = "docNumberCol";
            this.docNumberCol.Visible = true;
            this.docNumberCol.VisibleIndex = 0;
            // 
            // docDateCol
            // 
            this.docDateCol.Caption = "Дата заявки";
            this.docDateCol.FieldName = "Doc_Date";
            this.docDateCol.Name = "docDateCol";
            this.docDateCol.Visible = true;
            this.docDateCol.VisibleIndex = 1;
            // 
            // startDateCol
            // 
            this.startDateCol.Caption = "Дата початку";
            this.startDateCol.FieldName = "StartDate";
            this.startDateCol.Name = "startDateCol";
            this.startDateCol.Visible = true;
            this.startDateCol.VisibleIndex = 2;
            // 
            // endDateCol
            // 
            this.endDateCol.Caption = "Дата завершення";
            this.endDateCol.FieldName = "EndDate";
            this.endDateCol.Name = "endDateCol";
            this.endDateCol.Visible = true;
            this.endDateCol.VisibleIndex = 3;
            // 
            // accountNumberCol
            // 
            this.accountNumberCol.Caption = "Таб. номер";
            this.accountNumberCol.FieldName = "AccountNumber";
            this.accountNumberCol.Name = "accountNumberCol";
            this.accountNumberCol.OptionsColumn.AllowEdit = false;
            this.accountNumberCol.OptionsColumn.AllowFocus = false;
            this.accountNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.accountNumberCol.Visible = true;
            this.accountNumberCol.VisibleIndex = 4;
            this.accountNumberCol.Width = 68;
            // 
            // fullNameCol
            // 
            this.fullNameCol.Caption = "ПІБ працівника";
            this.fullNameCol.FieldName = "FullName";
            this.fullNameCol.Name = "fullNameCol";
            this.fullNameCol.OptionsColumn.AllowEdit = false;
            this.fullNameCol.OptionsColumn.AllowFocus = false;
            this.fullNameCol.Visible = true;
            this.fullNameCol.VisibleIndex = 5;
            this.fullNameCol.Width = 140;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.paymentsGrid);
            this.groupControl2.Location = new System.Drawing.Point(12, 75);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1356, 512);
            this.groupControl2.TabIndex = 51;
            this.groupControl2.Text = "Аванс на заявку";
            // 
            // paymentsGrid
            // 
            this.paymentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentsGrid.Location = new System.Drawing.Point(2, 20);
            this.paymentsGrid.MainView = this.paymentsGridView;
            this.paymentsGrid.Name = "paymentsGrid";
            this.paymentsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.selectPaymentRepository});
            this.paymentsGrid.Size = new System.Drawing.Size(1352, 490);
            this.paymentsGrid.TabIndex = 51;
            this.paymentsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.paymentsGridView});
            // 
            // paymentsGridView
            // 
            this.paymentsGridView.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.paymentsGridView.Appearance.FooterPanel.Options.UseFont = true;
            this.paymentsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.selectedPaymentCol,
            this.docDatePaymentCol,
            this.reportNameCol,
            this.commentCol,
            this.startReportDateCol,
            this.endReportDateCol,
            this.vatAccountNum,
            this.vatPaymentCol,
            this.currencyNameCol,
            this.currencyPaymentCol,
            this.accountNumCol,
            this.paymentSumCol});
            this.paymentsGridView.GridControl = this.paymentsGrid;
            this.paymentsGridView.Name = "paymentsGridView";
            this.paymentsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.paymentsGridView.OptionsView.ShowAutoFilterRow = true;
            this.paymentsGridView.OptionsView.ShowFooter = true;
            this.paymentsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // selectedPaymentCol
            // 
            this.selectedPaymentCol.Caption = "gridColumn1";
            this.selectedPaymentCol.ColumnEdit = this.selectPaymentRepository;
            this.selectedPaymentCol.FieldName = "Selected";
            this.selectedPaymentCol.Image = ((System.Drawing.Image)(resources.GetObject("selectedPaymentCol.Image")));
            this.selectedPaymentCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.selectedPaymentCol.Name = "selectedPaymentCol";
            this.selectedPaymentCol.OptionsColumn.ShowCaption = false;
            this.selectedPaymentCol.Visible = true;
            this.selectedPaymentCol.VisibleIndex = 0;
            this.selectedPaymentCol.Width = 29;
            // 
            // selectPaymentRepository
            // 
            this.selectPaymentRepository.AutoHeight = false;
            this.selectPaymentRepository.Name = "selectPaymentRepository";
            // 
            // docDatePaymentCol
            // 
            this.docDatePaymentCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.docDatePaymentCol.AppearanceHeader.Options.UseFont = true;
            this.docDatePaymentCol.AppearanceHeader.Options.UseTextOptions = true;
            this.docDatePaymentCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.docDatePaymentCol.Caption = "Дата звіту";
            this.docDatePaymentCol.FieldName = "Doc_Date";
            this.docDatePaymentCol.Name = "docDatePaymentCol";
            this.docDatePaymentCol.OptionsColumn.AllowEdit = false;
            this.docDatePaymentCol.OptionsColumn.AllowFocus = false;
            this.docDatePaymentCol.OptionsFilter.AllowAutoFilter = false;
            this.docDatePaymentCol.OptionsFilter.AllowFilter = false;
            this.docDatePaymentCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Payment_Date", "Всього: {0}")});
            this.docDatePaymentCol.Visible = true;
            this.docDatePaymentCol.VisibleIndex = 1;
            this.docDatePaymentCol.Width = 79;
            // 
            // reportNameCol
            // 
            this.reportNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.reportNameCol.AppearanceHeader.Options.UseFont = true;
            this.reportNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.reportNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.reportNameCol.Caption = "Найменування документу";
            this.reportNameCol.FieldName = "ReportName";
            this.reportNameCol.Name = "reportNameCol";
            this.reportNameCol.OptionsColumn.AllowEdit = false;
            this.reportNameCol.OptionsColumn.AllowFocus = false;
            this.reportNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.reportNameCol.Visible = true;
            this.reportNameCol.VisibleIndex = 2;
            this.reportNameCol.Width = 318;
            // 
            // commentCol
            // 
            this.commentCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.commentCol.AppearanceHeader.Options.UseFont = true;
            this.commentCol.AppearanceHeader.Options.UseTextOptions = true;
            this.commentCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.commentCol.Caption = "Примітка";
            this.commentCol.FieldName = "Comment";
            this.commentCol.Name = "commentCol";
            this.commentCol.OptionsColumn.AllowEdit = false;
            this.commentCol.OptionsColumn.AllowFocus = false;
            this.commentCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.commentCol.Visible = true;
            this.commentCol.VisibleIndex = 3;
            this.commentCol.Width = 113;
            // 
            // startReportDateCol
            // 
            this.startReportDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.startReportDateCol.AppearanceHeader.Options.UseFont = true;
            this.startReportDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.startReportDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.startReportDateCol.Caption = "Дата початку";
            this.startReportDateCol.FieldName = "StartReportDate";
            this.startReportDateCol.Name = "startReportDateCol";
            this.startReportDateCol.OptionsColumn.AllowEdit = false;
            this.startReportDateCol.OptionsColumn.AllowFocus = false;
            this.startReportDateCol.Visible = true;
            this.startReportDateCol.VisibleIndex = 4;
            this.startReportDateCol.Width = 102;
            // 
            // endReportDateCol
            // 
            this.endReportDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.endReportDateCol.AppearanceHeader.Options.UseFont = true;
            this.endReportDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.endReportDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.endReportDateCol.Caption = "Дата закінчення";
            this.endReportDateCol.FieldName = "EndReportDate";
            this.endReportDateCol.Name = "endReportDateCol";
            this.endReportDateCol.OptionsColumn.AllowEdit = false;
            this.endReportDateCol.OptionsColumn.AllowFocus = false;
            this.endReportDateCol.Visible = true;
            this.endReportDateCol.VisibleIndex = 5;
            this.endReportDateCol.Width = 109;
            // 
            // vatAccountNum
            // 
            this.vatAccountNum.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.vatAccountNum.AppearanceHeader.Options.UseFont = true;
            this.vatAccountNum.AppearanceHeader.Options.UseTextOptions = true;
            this.vatAccountNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vatAccountNum.Caption = "Рахунок ПДВ";
            this.vatAccountNum.FieldName = "VatAccountNum";
            this.vatAccountNum.Name = "vatAccountNum";
            this.vatAccountNum.OptionsColumn.AllowEdit = false;
            this.vatAccountNum.OptionsColumn.AllowFocus = false;
            this.vatAccountNum.OptionsFilter.AllowAutoFilter = false;
            this.vatAccountNum.OptionsFilter.AllowFilter = false;
            this.vatAccountNum.Visible = true;
            this.vatAccountNum.VisibleIndex = 6;
            this.vatAccountNum.Width = 84;
            // 
            // vatPaymentCol
            // 
            this.vatPaymentCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.vatPaymentCol.AppearanceHeader.Options.UseFont = true;
            this.vatPaymentCol.AppearanceHeader.Options.UseTextOptions = true;
            this.vatPaymentCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vatPaymentCol.Caption = "Сума ПДВ";
            this.vatPaymentCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.vatPaymentCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.vatPaymentCol.FieldName = "VatPayment";
            this.vatPaymentCol.Name = "vatPaymentCol";
            this.vatPaymentCol.OptionsColumn.AllowEdit = false;
            this.vatPaymentCol.OptionsColumn.AllowFocus = false;
            this.vatPaymentCol.OptionsFilter.AllowAutoFilter = false;
            this.vatPaymentCol.OptionsFilter.AllowFilter = false;
            this.vatPaymentCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VatPayment", "{0:### ### ##0.00}")});
            this.vatPaymentCol.Visible = true;
            this.vatPaymentCol.VisibleIndex = 7;
            this.vatPaymentCol.Width = 76;
            // 
            // currencyNameCol
            // 
            this.currencyNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.currencyNameCol.AppearanceHeader.Options.UseFont = true;
            this.currencyNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.currencyNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.currencyNameCol.Caption = "Валюта";
            this.currencyNameCol.FieldName = "CurrencyName";
            this.currencyNameCol.Name = "currencyNameCol";
            this.currencyNameCol.OptionsColumn.AllowEdit = false;
            this.currencyNameCol.OptionsColumn.AllowFocus = false;
            this.currencyNameCol.OptionsFilter.AllowAutoFilter = false;
            this.currencyNameCol.OptionsFilter.AllowFilter = false;
            this.currencyNameCol.Visible = true;
            this.currencyNameCol.VisibleIndex = 8;
            this.currencyNameCol.Width = 98;
            // 
            // currencyPaymentCol
            // 
            this.currencyPaymentCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.currencyPaymentCol.AppearanceHeader.Options.UseFont = true;
            this.currencyPaymentCol.AppearanceHeader.Options.UseTextOptions = true;
            this.currencyPaymentCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.currencyPaymentCol.Caption = "Сума у валюті";
            this.currencyPaymentCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.currencyPaymentCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.currencyPaymentCol.FieldName = "CurrencyPayment";
            this.currencyPaymentCol.Name = "currencyPaymentCol";
            this.currencyPaymentCol.OptionsColumn.AllowEdit = false;
            this.currencyPaymentCol.OptionsColumn.AllowFocus = false;
            this.currencyPaymentCol.OptionsFilter.AllowAutoFilter = false;
            this.currencyPaymentCol.OptionsFilter.AllowFilter = false;
            this.currencyPaymentCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CurrencyPayment", "{0:### ### ##0.00}")});
            this.currencyPaymentCol.Visible = true;
            this.currencyPaymentCol.VisibleIndex = 9;
            this.currencyPaymentCol.Width = 125;
            // 
            // accountNumCol
            // 
            this.accountNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.accountNumCol.AppearanceHeader.Options.UseFont = true;
            this.accountNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.accountNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.accountNumCol.Caption = "Рахунок";
            this.accountNumCol.FieldName = "AccountNum";
            this.accountNumCol.Name = "accountNumCol";
            this.accountNumCol.OptionsColumn.AllowEdit = false;
            this.accountNumCol.OptionsColumn.AllowFocus = false;
            this.accountNumCol.OptionsFilter.AllowAutoFilter = false;
            this.accountNumCol.OptionsFilter.AllowFilter = false;
            this.accountNumCol.Visible = true;
            this.accountNumCol.VisibleIndex = 10;
            this.accountNumCol.Width = 72;
            // 
            // paymentSumCol
            // 
            this.paymentSumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.paymentSumCol.AppearanceHeader.Options.UseFont = true;
            this.paymentSumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentSumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentSumCol.Caption = "Сума";
            this.paymentSumCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.paymentSumCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.paymentSumCol.FieldName = "Payment";
            this.paymentSumCol.Name = "paymentSumCol";
            this.paymentSumCol.OptionsColumn.AllowEdit = false;
            this.paymentSumCol.OptionsColumn.AllowFocus = false;
            this.paymentSumCol.OptionsFilter.AllowAutoFilter = false;
            this.paymentSumCol.OptionsFilter.AllowFilter = false;
            this.paymentSumCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Payment", "{0:### ### ##0.00}")});
            this.paymentSumCol.Visible = true;
            this.paymentSumCol.VisibleIndex = 11;
            this.paymentSumCol.Width = 129;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(1291, 597);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 54;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1210, 597);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 53;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // BusinessTripsPaymentTemplateFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 632);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusinessTripsPaymentTemplateFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Копіювання звіту за шаблоном";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPaymentRepository)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit businessTripsEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn docNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn docDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn startDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn endDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn accountNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn fullNameCol;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl paymentsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView paymentsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn selectedPaymentCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit selectPaymentRepository;
        private DevExpress.XtraGrid.Columns.GridColumn docDatePaymentCol;
        private DevExpress.XtraGrid.Columns.GridColumn reportNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn commentCol;
        private DevExpress.XtraGrid.Columns.GridColumn startReportDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn endReportDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn vatAccountNum;
        private DevExpress.XtraGrid.Columns.GridColumn vatPaymentCol;
        private DevExpress.XtraGrid.Columns.GridColumn currencyNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn currencyPaymentCol;
        private DevExpress.XtraGrid.Columns.GridColumn accountNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn paymentSumCol;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}