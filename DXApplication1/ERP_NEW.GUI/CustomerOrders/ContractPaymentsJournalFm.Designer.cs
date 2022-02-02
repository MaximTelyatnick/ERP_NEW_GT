namespace ERP_NEW.GUI.CustomerOrders
{
    partial class ContractPaymentsJournalFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractPaymentsJournalFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.beginDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.endDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.showBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.paymentsGrid = new DevExpress.XtraGrid.GridControl();
            this.paymentsGridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.vendorSrnCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.vendorNameCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.orderNumberCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.orderDateCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.prepaymentCustomerOrderCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.prepaymentCustomerOrderCurrencyCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.paymentCustomerOrderCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.paymentCustomerOrderCurrencyCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.directionCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.statusPaymentRepository = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.paymentDocumentCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.paymentDateCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.purposeCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.paymentPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.paymentPriceCurrencyCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.currencyCodeCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.exportToXlsBtn = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPaymentRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.beginDateEdit,
            this.endDateEdit,
            this.showBtn,
            this.exportToXlsBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1379, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // beginDateEdit
            // 
            this.beginDateEdit.Caption = "З  ";
            this.beginDateEdit.Edit = this.repositoryItemDateEdit1;
            this.beginDateEdit.EditWidth = 100;
            this.beginDateEdit.Id = 1;
            this.beginDateEdit.Name = "beginDateEdit";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // endDateEdit
            // 
            this.endDateEdit.Caption = "По";
            this.endDateEdit.Edit = this.repositoryItemDateEdit2;
            this.endDateEdit.EditWidth = 100;
            this.endDateEdit.Id = 2;
            this.endDateEdit.Name = "endDateEdit";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // showBtn
            // 
            this.showBtn.Caption = "Показати";
            this.showBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("showBtn.Glyph")));
            this.showBtn.Id = 3;
            this.showBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showBtn.LargeGlyph")));
            this.showBtn.Name = "showBtn";
            this.showBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.showBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.beginDateEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.endDateEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.showBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Формування даних";
            // 
            // paymentsGrid
            // 
            this.paymentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentsGrid.Location = new System.Drawing.Point(0, 95);
            this.paymentsGrid.MainView = this.paymentsGridView;
            this.paymentsGrid.Name = "paymentsGrid";
            this.paymentsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.statusPaymentRepository});
            this.paymentsGrid.Size = new System.Drawing.Size(1379, 559);
            this.paymentsGrid.TabIndex = 1;
            this.paymentsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.paymentsGridView});
            // 
            // paymentsGridView
            // 
            this.paymentsGridView.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.paymentsGridView.Appearance.FooterPanel.Options.UseFont = true;
            this.paymentsGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand4,
            this.gridBand5,
            this.gridBand3});
            this.paymentsGridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.vendorSrnCol,
            this.vendorNameCol,
            this.orderNumberCol,
            this.orderDateCol,
            this.paymentDocumentCol,
            this.paymentDateCol,
            this.purposeCol,
            this.directionCol,
            this.paymentPriceCol,
            this.paymentPriceCurrencyCol,
            this.currencyCodeCol,
            this.paymentCustomerOrderCol,
            this.paymentCustomerOrderCurrencyCol,
            this.prepaymentCustomerOrderCol,
            this.prepaymentCustomerOrderCurrencyCol});
            this.paymentsGridView.GridControl = this.paymentsGrid;
            this.paymentsGridView.Name = "paymentsGridView";
            this.paymentsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.paymentsGridView.OptionsView.AllowCellMerge = true;
            this.paymentsGridView.OptionsView.ShowAutoFilterRow = true;
            this.paymentsGridView.OptionsView.ShowFooter = true;
            this.paymentsGridView.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.paymentsGridView_CellMerge);
            this.paymentsGridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.paymentsGridView_RowCellStyle);
            this.paymentsGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.paymentsGridView_CustomUnboundColumnData);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Контрагент/договір";
            this.gridBand1.Columns.Add(this.vendorSrnCol);
            this.gridBand1.Columns.Add(this.vendorNameCol);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 228;
            // 
            // vendorSrnCol
            // 
            this.vendorSrnCol.AppearanceHeader.Options.UseTextOptions = true;
            this.vendorSrnCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vendorSrnCol.Caption = "Код";
            this.vendorSrnCol.FieldName = "VendorSrn";
            this.vendorSrnCol.Name = "vendorSrnCol";
            this.vendorSrnCol.OptionsColumn.AllowEdit = false;
            this.vendorSrnCol.OptionsColumn.AllowFocus = false;
            this.vendorSrnCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.vendorSrnCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.vendorSrnCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "VendorSrn", "Всього: {0}")});
            this.vendorSrnCol.Visible = true;
            this.vendorSrnCol.Width = 59;
            // 
            // vendorNameCol
            // 
            this.vendorNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.vendorNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vendorNameCol.Caption = "Найменування";
            this.vendorNameCol.FieldName = "VendorName";
            this.vendorNameCol.Name = "vendorNameCol";
            this.vendorNameCol.OptionsColumn.AllowEdit = false;
            this.vendorNameCol.OptionsColumn.AllowFocus = false;
            this.vendorNameCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.vendorNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.vendorNameCol.Visible = true;
            this.vendorNameCol.Width = 169;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Заказ";
            this.gridBand2.Columns.Add(this.orderNumberCol);
            this.gridBand2.Columns.Add(this.orderDateCol);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 116;
            // 
            // orderNumberCol
            // 
            this.orderNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderNumberCol.Caption = "Номер";
            this.orderNumberCol.FieldName = "OrderNumber";
            this.orderNumberCol.Name = "orderNumberCol";
            this.orderNumberCol.OptionsColumn.AllowEdit = false;
            this.orderNumberCol.OptionsColumn.AllowFocus = false;
            this.orderNumberCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.orderNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.orderNumberCol.Visible = true;
            this.orderNumberCol.Width = 53;
            // 
            // orderDateCol
            // 
            this.orderDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderDateCol.Caption = "Дата";
            this.orderDateCol.FieldName = "OrderDate";
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.OptionsColumn.AllowEdit = false;
            this.orderDateCol.OptionsColumn.AllowFocus = false;
            this.orderDateCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.orderDateCol.Visible = true;
            this.orderDateCol.Width = 63;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridBand4.AppearanceHeader.Options.UseFont = true;
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Надходження";
            this.gridBand4.Columns.Add(this.prepaymentCustomerOrderCol);
            this.gridBand4.Columns.Add(this.prepaymentCustomerOrderCurrencyCol);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 2;
            this.gridBand4.Width = 187;
            // 
            // prepaymentCustomerOrderCol
            // 
            this.prepaymentCustomerOrderCol.Caption = "Сума у грн ";
            this.prepaymentCustomerOrderCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.prepaymentCustomerOrderCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.prepaymentCustomerOrderCol.FieldName = "Prepayment";
            this.prepaymentCustomerOrderCol.Name = "prepaymentCustomerOrderCol";
            this.prepaymentCustomerOrderCol.OptionsColumn.AllowEdit = false;
            this.prepaymentCustomerOrderCol.OptionsColumn.AllowFocus = false;
            this.prepaymentCustomerOrderCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.prepaymentCustomerOrderCol.Visible = true;
            this.prepaymentCustomerOrderCol.Width = 97;
            // 
            // prepaymentCustomerOrderCurrencyCol
            // 
            this.prepaymentCustomerOrderCurrencyCol.Caption = "Сума у валюті";
            this.prepaymentCustomerOrderCurrencyCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.prepaymentCustomerOrderCurrencyCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.prepaymentCustomerOrderCurrencyCol.FieldName = "PrepaymentCurrency";
            this.prepaymentCustomerOrderCurrencyCol.Name = "prepaymentCustomerOrderCurrencyCol";
            this.prepaymentCustomerOrderCurrencyCol.OptionsColumn.AllowEdit = false;
            this.prepaymentCustomerOrderCurrencyCol.OptionsColumn.AllowFocus = false;
            this.prepaymentCustomerOrderCurrencyCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.prepaymentCustomerOrderCurrencyCol.Visible = true;
            this.prepaymentCustomerOrderCurrencyCol.Width = 90;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridBand5.AppearanceHeader.Options.UseFont = true;
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.Caption = "Витрати";
            this.gridBand5.Columns.Add(this.paymentCustomerOrderCol);
            this.gridBand5.Columns.Add(this.paymentCustomerOrderCurrencyCol);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 3;
            this.gridBand5.Width = 183;
            // 
            // paymentCustomerOrderCol
            // 
            this.paymentCustomerOrderCol.Caption = "Сума у грн.";
            this.paymentCustomerOrderCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.paymentCustomerOrderCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.paymentCustomerOrderCol.FieldName = "Payment";
            this.paymentCustomerOrderCol.Name = "paymentCustomerOrderCol";
            this.paymentCustomerOrderCol.OptionsColumn.AllowEdit = false;
            this.paymentCustomerOrderCol.OptionsColumn.AllowFocus = false;
            this.paymentCustomerOrderCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.paymentCustomerOrderCol.Visible = true;
            this.paymentCustomerOrderCol.Width = 84;
            // 
            // paymentCustomerOrderCurrencyCol
            // 
            this.paymentCustomerOrderCurrencyCol.Caption = "Сума у валюті";
            this.paymentCustomerOrderCurrencyCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.paymentCustomerOrderCurrencyCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.paymentCustomerOrderCurrencyCol.FieldName = "PaymentCurrency";
            this.paymentCustomerOrderCurrencyCol.Name = "paymentCustomerOrderCurrencyCol";
            this.paymentCustomerOrderCurrencyCol.OptionsColumn.AllowEdit = false;
            this.paymentCustomerOrderCurrencyCol.OptionsColumn.AllowFocus = false;
            this.paymentCustomerOrderCurrencyCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.paymentCustomerOrderCurrencyCol.Visible = true;
            this.paymentCustomerOrderCurrencyCol.Width = 99;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Документ";
            this.gridBand3.Columns.Add(this.directionCol);
            this.gridBand3.Columns.Add(this.paymentDocumentCol);
            this.gridBand3.Columns.Add(this.paymentDateCol);
            this.gridBand3.Columns.Add(this.purposeCol);
            this.gridBand3.Columns.Add(this.paymentPriceCol);
            this.gridBand3.Columns.Add(this.paymentPriceCurrencyCol);
            this.gridBand3.Columns.Add(this.currencyCodeCol);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 4;
            this.gridBand3.Width = 647;
            // 
            // directionCol
            // 
            this.directionCol.AppearanceHeader.Options.UseTextOptions = true;
            this.directionCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.directionCol.Caption = "bandedGridColumn8";
            this.directionCol.ColumnEdit = this.statusPaymentRepository;
            this.directionCol.FieldName = "directionCol";
            this.directionCol.Image = ((System.Drawing.Image)(resources.GetObject("directionCol.Image")));
            this.directionCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.directionCol.Name = "directionCol";
            this.directionCol.OptionsColumn.AllowEdit = false;
            this.directionCol.OptionsColumn.AllowFocus = false;
            this.directionCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.directionCol.OptionsColumn.ShowCaption = false;
            this.directionCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.directionCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.directionCol.Visible = true;
            this.directionCol.Width = 20;
            // 
            // statusPaymentRepository
            // 
            this.statusPaymentRepository.Name = "statusPaymentRepository";
            this.statusPaymentRepository.NullText = " ";
            this.statusPaymentRepository.ZoomAccelerationFactor = 1D;
            // 
            // paymentDocumentCol
            // 
            this.paymentDocumentCol.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentDocumentCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentDocumentCol.Caption = "№ документу";
            this.paymentDocumentCol.FieldName = "PaymentDocument";
            this.paymentDocumentCol.Name = "paymentDocumentCol";
            this.paymentDocumentCol.OptionsColumn.AllowEdit = false;
            this.paymentDocumentCol.OptionsColumn.AllowFocus = false;
            this.paymentDocumentCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.paymentDocumentCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.paymentDocumentCol.Visible = true;
            this.paymentDocumentCol.Width = 39;
            // 
            // paymentDateCol
            // 
            this.paymentDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentDateCol.Caption = "Дата платежу";
            this.paymentDateCol.FieldName = "PaymentDate";
            this.paymentDateCol.Name = "paymentDateCol";
            this.paymentDateCol.OptionsColumn.AllowEdit = false;
            this.paymentDateCol.OptionsColumn.AllowFocus = false;
            this.paymentDateCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.paymentDateCol.Visible = true;
            this.paymentDateCol.Width = 50;
            // 
            // purposeCol
            // 
            this.purposeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.purposeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.purposeCol.Caption = "Призначення платежу";
            this.purposeCol.FieldName = "Purpose";
            this.purposeCol.Name = "purposeCol";
            this.purposeCol.OptionsColumn.AllowEdit = false;
            this.purposeCol.OptionsColumn.AllowFocus = false;
            this.purposeCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.purposeCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.purposeCol.Visible = true;
            this.purposeCol.Width = 276;
            // 
            // paymentPriceCol
            // 
            this.paymentPriceCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.paymentPriceCol.AppearanceCell.Options.UseFont = true;
            this.paymentPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentPriceCol.Caption = "Сума у грн.";
            this.paymentPriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.paymentPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.paymentPriceCol.FieldName = "PaymentPrice";
            this.paymentPriceCol.Name = "paymentPriceCol";
            this.paymentPriceCol.OptionsColumn.AllowEdit = false;
            this.paymentPriceCol.OptionsColumn.AllowFocus = false;
            this.paymentPriceCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.paymentPriceCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.paymentPriceCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PaymentPrice", "{0:### ### ##0.00}")});
            this.paymentPriceCol.Visible = true;
            this.paymentPriceCol.Width = 103;
            // 
            // paymentPriceCurrencyCol
            // 
            this.paymentPriceCurrencyCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.paymentPriceCurrencyCol.AppearanceCell.Options.UseFont = true;
            this.paymentPriceCurrencyCol.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentPriceCurrencyCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentPriceCurrencyCol.Caption = "Сума у валюті";
            this.paymentPriceCurrencyCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.paymentPriceCurrencyCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.paymentPriceCurrencyCol.FieldName = "PaymentPriceCurrency";
            this.paymentPriceCurrencyCol.Name = "paymentPriceCurrencyCol";
            this.paymentPriceCurrencyCol.OptionsColumn.AllowEdit = false;
            this.paymentPriceCurrencyCol.OptionsColumn.AllowFocus = false;
            this.paymentPriceCurrencyCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.paymentPriceCurrencyCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.paymentPriceCurrencyCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PaymentPriceCurrency", "{0:### ### ##0.00}")});
            this.paymentPriceCurrencyCol.Visible = true;
            this.paymentPriceCurrencyCol.Width = 90;
            // 
            // currencyCodeCol
            // 
            this.currencyCodeCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.currencyCodeCol.AppearanceCell.Options.UseFont = true;
            this.currencyCodeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.currencyCodeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.currencyCodeCol.Caption = "Валюта";
            this.currencyCodeCol.FieldName = "CurrencyCode";
            this.currencyCodeCol.Name = "currencyCodeCol";
            this.currencyCodeCol.OptionsColumn.AllowEdit = false;
            this.currencyCodeCol.OptionsColumn.AllowFocus = false;
            this.currencyCodeCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.currencyCodeCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.currencyCodeCol.Visible = true;
            this.currencyCodeCol.Width = 69;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("addfile_16x16.png", "images/actions/addfile_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/addfile_16x16.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "addfile_16x16.png");
            this.imageCollection.InsertGalleryImage("removeitem_16x16.png", "office2013/actions/removeitem_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/removeitem_16x16.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "removeitem_16x16.png");
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.exportToXlsBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Звіти";
            // 
            // exportToXlsBtn
            // 
            this.exportToXlsBtn.Caption = "Экспорт в Xls";
            this.exportToXlsBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("exportToXlsBtn.Glyph")));
            this.exportToXlsBtn.Id = 4;
            this.exportToXlsBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("exportToXlsBtn.LargeGlyph")));
            this.exportToXlsBtn.Name = "exportToXlsBtn";
            this.exportToXlsBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.exportToXlsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exportToXlsBtn_ItemClick);
            // 
            // ContractPaymentsJournalFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 654);
            this.Controls.Add(this.paymentsGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ContractPaymentsJournalFm";
            this.Text = "Журнал надходжень і витрат";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPaymentRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarEditItem beginDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem endDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem showBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl paymentsGrid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView paymentsGridView;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn vendorSrnCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn vendorNameCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn orderNumberCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn orderDateCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentDocumentCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentDateCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn purposeCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn directionCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentPriceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentPriceCurrencyCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn currencyCodeCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit statusPaymentRepository;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn prepaymentCustomerOrderCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentCustomerOrderCurrencyCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentCustomerOrderCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn prepaymentCustomerOrderCurrencyCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraBars.BarButtonItem exportToXlsBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}