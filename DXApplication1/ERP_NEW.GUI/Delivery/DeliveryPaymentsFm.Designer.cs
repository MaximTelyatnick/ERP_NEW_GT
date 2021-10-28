namespace ERP_NEW.GUI.Delivery
{
    partial class DeliveryPaymentsFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryPaymentsFm));
            this.deliveryPaymentsGrid = new DevExpress.XtraGrid.GridControl();
            this.deliveryPaymentsGridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.vendorSrnCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.vendorNameCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.customerOrderDateCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.customerOrderNumberCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.customerOrderCurrencyPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.сustomerOrderPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.paymentDocumentCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.paymentDateCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.purposeCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.paymentPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.paymentPriceCurrencyCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.currencyCodeCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.showForDate = new DevExpress.XtraEditors.SimpleButton();
            this.endDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.beginDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.xlsBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryPaymentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryPaymentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // deliveryPaymentsGrid
            // 
            this.deliveryPaymentsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryPaymentsGrid.Location = new System.Drawing.Point(0, 46);
            this.deliveryPaymentsGrid.MainView = this.deliveryPaymentsGridView;
            this.deliveryPaymentsGrid.Name = "deliveryPaymentsGrid";
            this.deliveryPaymentsGrid.Size = new System.Drawing.Size(1438, 609);
            this.deliveryPaymentsGrid.TabIndex = 0;
            this.deliveryPaymentsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.deliveryPaymentsGridView});
            // 
            // deliveryPaymentsGridView
            // 
            this.deliveryPaymentsGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand4,
            this.gridBand2,
            this.gridBand3});
            this.deliveryPaymentsGridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.vendorSrnCol,
            this.vendorNameCol,
            this.paymentDateCol,
            this.paymentDocumentCol,
            this.purposeCol,
            this.paymentPriceCol,
            this.paymentPriceCurrencyCol,
            this.currencyCodeCol,
            this.customerOrderNumberCol,
            this.customerOrderDateCol,
            this.сustomerOrderPriceCol,
            this.customerOrderCurrencyPriceCol});
            this.deliveryPaymentsGridView.GridControl = this.deliveryPaymentsGrid;
            this.deliveryPaymentsGridView.Name = "deliveryPaymentsGridView";
            this.deliveryPaymentsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.deliveryPaymentsGridView.OptionsPrint.AllowMultilineHeaders = true;
            this.deliveryPaymentsGridView.OptionsPrint.AutoWidth = false;
            this.deliveryPaymentsGridView.OptionsPrint.PrintBandHeader = false;
            this.deliveryPaymentsGridView.OptionsView.AllowCellMerge = true;
            this.deliveryPaymentsGridView.OptionsView.ShowAutoFilterRow = true;
            this.deliveryPaymentsGridView.OptionsView.ShowFooter = true;
            this.deliveryPaymentsGridView.OptionsView.ShowGroupPanel = false;
            this.deliveryPaymentsGridView.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.deliveryPaymentsGridView_CellMerge);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Контрагенти";
            this.gridBand1.Columns.Add(this.vendorSrnCol);
            this.gridBand1.Columns.Add(this.vendorNameCol);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 414;
            // 
            // vendorSrnCol
            // 
            this.vendorSrnCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.vendorSrnCol.AppearanceHeader.Options.UseFont = true;
            this.vendorSrnCol.AppearanceHeader.Options.UseTextOptions = true;
            this.vendorSrnCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vendorSrnCol.Caption = "Код ЄДРПОУ";
            this.vendorSrnCol.FieldName = "VendorSrn";
            this.vendorSrnCol.Name = "vendorSrnCol";
            this.vendorSrnCol.OptionsColumn.AllowEdit = false;
            this.vendorSrnCol.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.vendorSrnCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.vendorSrnCol.Visible = true;
            this.vendorSrnCol.Width = 73;
            // 
            // vendorNameCol
            // 
            this.vendorNameCol.AppearanceCell.Options.UseTextOptions = true;
            this.vendorNameCol.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.vendorNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.vendorNameCol.AppearanceHeader.Options.UseFont = true;
            this.vendorNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.vendorNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vendorNameCol.Caption = "Контрагент";
            this.vendorNameCol.FieldName = "VendorName";
            this.vendorNameCol.Name = "vendorNameCol";
            this.vendorNameCol.OptionsColumn.AllowEdit = false;
            this.vendorNameCol.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.True;
            this.vendorNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.vendorNameCol.Visible = true;
            this.vendorNameCol.Width = 341;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand4.AppearanceHeader.Options.UseFont = true;
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Заказ";
            this.gridBand4.Columns.Add(this.customerOrderDateCol);
            this.gridBand4.Columns.Add(this.customerOrderNumberCol);
            this.gridBand4.Columns.Add(this.customerOrderCurrencyPriceCol);
            this.gridBand4.Columns.Add(this.сustomerOrderPriceCol);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 1;
            this.gridBand4.Width = 318;
            // 
            // customerOrderDateCol
            // 
            this.customerOrderDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.customerOrderDateCol.AppearanceHeader.Options.UseFont = true;
            this.customerOrderDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.customerOrderDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customerOrderDateCol.Caption = "Дата";
            this.customerOrderDateCol.FieldName = "CustomerOrderDate";
            this.customerOrderDateCol.Name = "customerOrderDateCol";
            this.customerOrderDateCol.OptionsColumn.AllowEdit = false;
            this.customerOrderDateCol.OptionsColumn.AllowFocus = false;
            this.customerOrderDateCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.customerOrderDateCol.Visible = true;
            this.customerOrderDateCol.Width = 68;
            // 
            // customerOrderNumberCol
            // 
            this.customerOrderNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.customerOrderNumberCol.AppearanceHeader.Options.UseFont = true;
            this.customerOrderNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.customerOrderNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customerOrderNumberCol.Caption = "Номер";
            this.customerOrderNumberCol.FieldName = "CustomerOrderNumber";
            this.customerOrderNumberCol.Name = "customerOrderNumberCol";
            this.customerOrderNumberCol.OptionsColumn.AllowEdit = false;
            this.customerOrderNumberCol.OptionsColumn.AllowFocus = false;
            this.customerOrderNumberCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.customerOrderNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.customerOrderNumberCol.Visible = true;
            this.customerOrderNumberCol.Width = 68;
            // 
            // customerOrderCurrencyPriceCol
            // 
            this.customerOrderCurrencyPriceCol.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.customerOrderCurrencyPriceCol.AppearanceHeader.Options.UseFont = true;
            this.customerOrderCurrencyPriceCol.Caption = "Сума у валюті";
            this.customerOrderCurrencyPriceCol.DisplayFormat.FormatString = "{0:### ### ##0.00}";
            this.customerOrderCurrencyPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.customerOrderCurrencyPriceCol.FieldName = "CustomerOrderCurrencyPrice";
            this.customerOrderCurrencyPriceCol.Name = "customerOrderCurrencyPriceCol";
            this.customerOrderCurrencyPriceCol.OptionsColumn.AllowEdit = false;
            this.customerOrderCurrencyPriceCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.customerOrderCurrencyPriceCol.Visible = true;
            this.customerOrderCurrencyPriceCol.Width = 109;
            // 
            // сustomerOrderPriceCol
            // 
            this.сustomerOrderPriceCol.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.сustomerOrderPriceCol.AppearanceHeader.Options.UseFont = true;
            this.сustomerOrderPriceCol.Caption = "Сума у грн";
            this.сustomerOrderPriceCol.DisplayFormat.FormatString = "{0:### ### ##0.00}";
            this.сustomerOrderPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.сustomerOrderPriceCol.FieldName = "CustomerOrderPrice";
            this.сustomerOrderPriceCol.Name = "сustomerOrderPriceCol";
            this.сustomerOrderPriceCol.OptionsColumn.AllowEdit = false;
            this.сustomerOrderPriceCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.сustomerOrderPriceCol.Visible = true;
            this.сustomerOrderPriceCol.Width = 73;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Платежі";
            this.gridBand2.Columns.Add(this.paymentDocumentCol);
            this.gridBand2.Columns.Add(this.paymentDateCol);
            this.gridBand2.Columns.Add(this.purposeCol);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 2;
            this.gridBand2.Width = 503;
            // 
            // paymentDocumentCol
            // 
            this.paymentDocumentCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.paymentDocumentCol.AppearanceHeader.Options.UseFont = true;
            this.paymentDocumentCol.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentDocumentCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentDocumentCol.Caption = "№ документу";
            this.paymentDocumentCol.FieldName = "PaymentDocument";
            this.paymentDocumentCol.Name = "paymentDocumentCol";
            this.paymentDocumentCol.OptionsColumn.AllowEdit = false;
            this.paymentDocumentCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.paymentDocumentCol.Visible = true;
            this.paymentDocumentCol.Width = 67;
            // 
            // paymentDateCol
            // 
            this.paymentDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.paymentDateCol.AppearanceHeader.Options.UseFont = true;
            this.paymentDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentDateCol.Caption = "Дата платежу";
            this.paymentDateCol.FieldName = "PaymentDate";
            this.paymentDateCol.Name = "paymentDateCol";
            this.paymentDateCol.OptionsColumn.AllowEdit = false;
            this.paymentDateCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.paymentDateCol.Visible = true;
            this.paymentDateCol.Width = 59;
            // 
            // purposeCol
            // 
            this.purposeCol.AppearanceCell.Options.UseTextOptions = true;
            this.purposeCol.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.purposeCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.purposeCol.AppearanceHeader.Options.UseFont = true;
            this.purposeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.purposeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.purposeCol.Caption = "Призначення платежу";
            this.purposeCol.FieldName = "Purpose";
            this.purposeCol.Name = "purposeCol";
            this.purposeCol.OptionsColumn.AllowEdit = false;
            this.purposeCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.purposeCol.Visible = true;
            this.purposeCol.Width = 377;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Суми";
            this.gridBand3.Columns.Add(this.paymentPriceCol);
            this.gridBand3.Columns.Add(this.paymentPriceCurrencyCol);
            this.gridBand3.Columns.Add(this.currencyCodeCol);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 3;
            this.gridBand3.Width = 185;
            // 
            // paymentPriceCol
            // 
            this.paymentPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.paymentPriceCol.AppearanceHeader.Options.UseFont = true;
            this.paymentPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentPriceCol.Caption = "Сума в грн.";
            this.paymentPriceCol.DisplayFormat.FormatString = "{0:### ### ##0.00}";
            this.paymentPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.paymentPriceCol.FieldName = "PaymentPrice";
            this.paymentPriceCol.Name = "paymentPriceCol";
            this.paymentPriceCol.OptionsColumn.AllowEdit = false;
            this.paymentPriceCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PaymentPrice", "{0:### ### ##0.00}")});
            this.paymentPriceCol.Visible = true;
            this.paymentPriceCol.Width = 61;
            // 
            // paymentPriceCurrencyCol
            // 
            this.paymentPriceCurrencyCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.paymentPriceCurrencyCol.AppearanceHeader.Options.UseFont = true;
            this.paymentPriceCurrencyCol.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentPriceCurrencyCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentPriceCurrencyCol.Caption = "Сума у валюті";
            this.paymentPriceCurrencyCol.DisplayFormat.FormatString = "{0:### ### ##0.00}";
            this.paymentPriceCurrencyCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.paymentPriceCurrencyCol.FieldName = "PaymentPriceCurrency";
            this.paymentPriceCurrencyCol.Name = "paymentPriceCurrencyCol";
            this.paymentPriceCurrencyCol.OptionsColumn.AllowEdit = false;
            this.paymentPriceCurrencyCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PaymentPriceCurrency", "{0:### ### ##0.00}")});
            this.paymentPriceCurrencyCol.Visible = true;
            this.paymentPriceCurrencyCol.Width = 65;
            // 
            // currencyCodeCol
            // 
            this.currencyCodeCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.currencyCodeCol.AppearanceHeader.Options.UseFont = true;
            this.currencyCodeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.currencyCodeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.currencyCodeCol.Caption = "Валюта";
            this.currencyCodeCol.FieldName = "CurrencyCode";
            this.currencyCodeCol.Name = "currencyCodeCol";
            this.currencyCodeCol.OptionsColumn.AllowEdit = false;
            this.currencyCodeCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.currencyCodeCol.Visible = true;
            this.currencyCodeCol.Width = 59;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.showForDate);
            this.panelControl2.Controls.Add(this.endDateEdit);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.beginDateEdit);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(2, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(304, 39);
            this.panelControl2.TabIndex = 18;
            // 
            // showForDate
            // 
            this.showForDate.Image = ((System.Drawing.Image)(resources.GetObject("showForDate.Image")));
            this.showForDate.Location = new System.Drawing.Point(259, 2);
            this.showForDate.Name = "showForDate";
            this.showForDate.Size = new System.Drawing.Size(42, 36);
            this.showForDate.TabIndex = 10;
            this.showForDate.ToolTip = "Показати";
            this.showForDate.Click += new System.EventHandler(this.showPaymentsForDate_Click);
            // 
            // endDateEdit
            // 
            this.endDateEdit.EditValue = null;
            this.endDateEdit.Location = new System.Drawing.Point(154, 8);
            this.endDateEdit.Name = "endDateEdit";
            this.endDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateEdit.Size = new System.Drawing.Size(100, 20);
            this.endDateEdit.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(131, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(13, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "По";
            // 
            // beginDateEdit
            // 
            this.beginDateEdit.EditValue = null;
            this.beginDateEdit.Location = new System.Drawing.Point(20, 9);
            this.beginDateEdit.Name = "beginDateEdit";
            this.beginDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.beginDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.beginDateEdit.Size = new System.Drawing.Size(100, 20);
            this.beginDateEdit.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(6, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "З";
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // xlsBtn
            // 
            this.xlsBtn.Image = ((System.Drawing.Image)(resources.GetObject("xlsBtn.Image")));
            this.xlsBtn.Location = new System.Drawing.Point(314, 4);
            this.xlsBtn.Name = "xlsBtn";
            this.xlsBtn.Size = new System.Drawing.Size(42, 36);
            this.xlsBtn.TabIndex = 19;
            this.xlsBtn.ToolTip = "Відобразити в Excel";
            this.xlsBtn.Click += new System.EventHandler(this.xlsBtn_Click);
            // 
            // DeliveryPaymentsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 654);
            this.Controls.Add(this.xlsBtn);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.deliveryPaymentsGrid);
            this.Name = "DeliveryPaymentsFm";
            this.ShowIcon = false;
            this.Text = "Платежі";
            ((System.ComponentModel.ISupportInitialize)(this.deliveryPaymentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryPaymentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl deliveryPaymentsGrid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView deliveryPaymentsGridView;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton showForDate;
        private DevExpress.XtraEditors.DateEdit endDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit beginDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn vendorSrnCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn vendorNameCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentDocumentCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentDateCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn purposeCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentPriceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentPriceCurrencyCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn currencyCodeCol;
        private DevExpress.XtraEditors.SimpleButton xlsBtn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn customerOrderDateCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn customerOrderNumberCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn сustomerOrderPriceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn customerOrderCurrencyPriceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
    }
}