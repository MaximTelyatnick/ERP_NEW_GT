namespace ERP_NEW.GUI.CustomerOrders
{
    partial class BankPaymentsSelectFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankPaymentsSelectFm));
            this.barManager = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.firstDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.lastDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.viewBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            this.bankPaymentsGrid = new DevExpress.XtraGrid.GridControl();
            this.bankPaymentsGridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.statusCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.statusRepository = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.selectedCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.selectedCheckRepository = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.contractorSrnCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.contractorNameCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bankPaymentDateCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bankPaymentNumberCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bankAccountNumCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.purposeAccountNumCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.purposeCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.currencyCodeCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.paymentPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.paymentPriceCurrency = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.paymentPriceRemainsCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.paymentPriceCurrencyRemainsCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.paymentPriceAddedCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.paymentPriceCurrencyAddedCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.imageCollection = new DevExpress.Utils.ImageCollection();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankPaymentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankPaymentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedCheckRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.firstDateEdit,
            this.lastDateEdit,
            this.viewBtn});
            this.barManager.MainMenu = this.bar1;
            this.barManager.MaxItemId = 4;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.firstDateEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.lastDateEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.viewBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "MainMenu";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "За період";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // firstDateEdit
            // 
            this.firstDateEdit.Caption = "з";
            this.firstDateEdit.Edit = this.repositoryItemDateEdit1;
            this.firstDateEdit.EditWidth = 100;
            this.firstDateEdit.Id = 1;
            this.firstDateEdit.Name = "firstDateEdit";
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
            // lastDateEdit
            // 
            this.lastDateEdit.Caption = "по";
            this.lastDateEdit.Edit = this.repositoryItemDateEdit2;
            this.lastDateEdit.EditWidth = 100;
            this.lastDateEdit.Id = 2;
            this.lastDateEdit.Name = "lastDateEdit";
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
            // viewBtn
            // 
            this.viewBtn.Caption = "Показати";
            this.viewBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("viewBtn.Glyph")));
            this.viewBtn.Id = 3;
            this.viewBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewBtn.LargeGlyph")));
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.viewBtn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1365, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 636);
            this.barDockControlBottom.Size = new System.Drawing.Size(1365, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 612);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1365, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 612);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cancelBtn);
            this.panelControl1.Controls.Add(this.okBtn);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 566);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1365, 70);
            this.panelControl1.TabIndex = 4;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(1277, 25);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 23;
            this.cancelBtn.Text = "Відмінити";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(1197, 25);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 22;
            this.okBtn.Text = "Додати";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // bankPaymentsGrid
            // 
            this.bankPaymentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bankPaymentsGrid.Location = new System.Drawing.Point(0, 24);
            this.bankPaymentsGrid.MainView = this.bankPaymentsGridView;
            this.bankPaymentsGrid.Name = "bankPaymentsGrid";
            this.bankPaymentsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.selectedCheckRepository,
            this.statusRepository});
            this.bankPaymentsGrid.Size = new System.Drawing.Size(1365, 542);
            this.bankPaymentsGrid.TabIndex = 5;
            this.bankPaymentsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bankPaymentsGridView});
            // 
            // bankPaymentsGridView
            // 
            this.bankPaymentsGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5});
            this.bankPaymentsGridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.statusCol,
            this.selectedCol,
            this.contractorSrnCol,
            this.contractorNameCol,
            this.bankPaymentDateCol,
            this.bankPaymentNumberCol,
            this.bankAccountNumCol,
            this.purposeAccountNumCol,
            this.purposeCol,
            this.currencyCodeCol,
            this.paymentPriceCol,
            this.paymentPriceCurrency,
            this.paymentPriceRemainsCol,
            this.paymentPriceCurrencyRemainsCol,
            this.paymentPriceAddedCol,
            this.paymentPriceCurrencyAddedCol});
            this.bankPaymentsGridView.GridControl = this.bankPaymentsGrid;
            this.bankPaymentsGridView.Name = "bankPaymentsGridView";
            this.bankPaymentsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.bankPaymentsGridView.OptionsView.ShowAutoFilterRow = true;
            this.bankPaymentsGridView.OptionsView.ShowGroupPanel = false;
            this.bankPaymentsGridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.bankPaymentsGridView_RowCellStyle);
            this.bankPaymentsGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.bankPaymentsGridView_CustomUnboundColumnData);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Контрагент";
            this.gridBand1.Columns.Add(this.statusCol);
            this.gridBand1.Columns.Add(this.selectedCol);
            this.gridBand1.Columns.Add(this.contractorSrnCol);
            this.gridBand1.Columns.Add(this.contractorNameCol);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 315;
            // 
            // statusCol
            // 
            this.statusCol.AppearanceHeader.Options.UseTextOptions = true;
            this.statusCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.statusCol.Caption = "gridColumn1";
            this.statusCol.ColumnEdit = this.statusRepository;
            this.statusCol.FieldName = "statusCol";
            this.statusCol.Image = ((System.Drawing.Image)(resources.GetObject("statusCol.Image")));
            this.statusCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.statusCol.MinWidth = 25;
            this.statusCol.Name = "statusCol";
            this.statusCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.statusCol.Visible = true;
            this.statusCol.Width = 25;
            // 
            // statusRepository
            // 
            this.statusRepository.Name = "statusRepository";
            this.statusRepository.NullText = " ";
            this.statusRepository.ZoomAccelerationFactor = 1D;
            // 
            // selectedCol
            // 
            this.selectedCol.AppearanceHeader.Options.UseTextOptions = true;
            this.selectedCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selectedCol.ColumnEdit = this.selectedCheckRepository;
            this.selectedCol.FieldName = "Selected";
            this.selectedCol.Image = ((System.Drawing.Image)(resources.GetObject("selectedCol.Image")));
            this.selectedCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.selectedCol.MinWidth = 25;
            this.selectedCol.Name = "selectedCol";
            this.selectedCol.Visible = true;
            this.selectedCol.Width = 25;
            // 
            // selectedCheckRepository
            // 
            this.selectedCheckRepository.AutoHeight = false;
            this.selectedCheckRepository.Name = "selectedCheckRepository";
            // 
            // contractorSrnCol
            // 
            this.contractorSrnCol.AppearanceHeader.Options.UseTextOptions = true;
            this.contractorSrnCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.contractorSrnCol.Caption = "Код ЭДРПОУ";
            this.contractorSrnCol.FieldName = "ContractorSrn";
            this.contractorSrnCol.MinWidth = 75;
            this.contractorSrnCol.Name = "contractorSrnCol";
            this.contractorSrnCol.OptionsColumn.AllowEdit = false;
            this.contractorSrnCol.OptionsColumn.AllowFocus = false;
            this.contractorSrnCol.Visible = true;
            // 
            // contractorNameCol
            // 
            this.contractorNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.contractorNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.contractorNameCol.Caption = "Найменування";
            this.contractorNameCol.FieldName = "ContractorName";
            this.contractorNameCol.Name = "contractorNameCol";
            this.contractorNameCol.OptionsColumn.AllowEdit = false;
            this.contractorNameCol.OptionsColumn.AllowFocus = false;
            this.contractorNameCol.Visible = true;
            this.contractorNameCol.Width = 190;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Платіжний документ";
            this.gridBand2.Columns.Add(this.bankPaymentDateCol);
            this.gridBand2.Columns.Add(this.bankPaymentNumberCol);
            this.gridBand2.Columns.Add(this.bankAccountNumCol);
            this.gridBand2.Columns.Add(this.purposeAccountNumCol);
            this.gridBand2.Columns.Add(this.purposeCol);
            this.gridBand2.Columns.Add(this.currencyCodeCol);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 514;
            // 
            // bankPaymentDateCol
            // 
            this.bankPaymentDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.bankPaymentDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bankPaymentDateCol.Caption = "Дата";
            this.bankPaymentDateCol.FieldName = "BankPaymentDate";
            this.bankPaymentDateCol.MinWidth = 50;
            this.bankPaymentDateCol.Name = "bankPaymentDateCol";
            this.bankPaymentDateCol.OptionsColumn.AllowEdit = false;
            this.bankPaymentDateCol.OptionsColumn.AllowFocus = false;
            this.bankPaymentDateCol.Visible = true;
            this.bankPaymentDateCol.Width = 50;
            // 
            // bankPaymentNumberCol
            // 
            this.bankPaymentNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.bankPaymentNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bankPaymentNumberCol.Caption = "Номер";
            this.bankPaymentNumberCol.FieldName = "BankPaymentNumber";
            this.bankPaymentNumberCol.MinWidth = 70;
            this.bankPaymentNumberCol.Name = "bankPaymentNumberCol";
            this.bankPaymentNumberCol.OptionsColumn.AllowEdit = false;
            this.bankPaymentNumberCol.OptionsColumn.AllowFocus = false;
            this.bankPaymentNumberCol.Visible = true;
            this.bankPaymentNumberCol.Width = 70;
            // 
            // bankAccountNumCol
            // 
            this.bankAccountNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.bankAccountNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bankAccountNumCol.Caption = "Рахунок банку";
            this.bankAccountNumCol.FieldName = "BankAccountNum";
            this.bankAccountNumCol.MinWidth = 40;
            this.bankAccountNumCol.Name = "bankAccountNumCol";
            this.bankAccountNumCol.OptionsColumn.AllowEdit = false;
            this.bankAccountNumCol.OptionsColumn.AllowFocus = false;
            this.bankAccountNumCol.Visible = true;
            this.bankAccountNumCol.Width = 40;
            // 
            // purposeAccountNumCol
            // 
            this.purposeAccountNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.purposeAccountNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.purposeAccountNumCol.Caption = "Рахунок призначення";
            this.purposeAccountNumCol.FieldName = "PurposeAccountNum";
            this.purposeAccountNumCol.MinWidth = 40;
            this.purposeAccountNumCol.Name = "purposeAccountNumCol";
            this.purposeAccountNumCol.OptionsColumn.AllowEdit = false;
            this.purposeAccountNumCol.OptionsColumn.AllowFocus = false;
            this.purposeAccountNumCol.Visible = true;
            this.purposeAccountNumCol.Width = 40;
            // 
            // purposeCol
            // 
            this.purposeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.purposeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.purposeCol.Caption = "Призначення";
            this.purposeCol.FieldName = "Purpose";
            this.purposeCol.Name = "purposeCol";
            this.purposeCol.OptionsColumn.AllowEdit = false;
            this.purposeCol.OptionsColumn.AllowFocus = false;
            this.purposeCol.Visible = true;
            this.purposeCol.Width = 263;
            // 
            // currencyCodeCol
            // 
            this.currencyCodeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.currencyCodeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.currencyCodeCol.Caption = "Код валюти";
            this.currencyCodeCol.FieldName = "CurrencyCode";
            this.currencyCodeCol.MinWidth = 40;
            this.currencyCodeCol.Name = "currencyCodeCol";
            this.currencyCodeCol.OptionsColumn.AllowEdit = false;
            this.currencyCodeCol.OptionsColumn.AllowFocus = false;
            this.currencyCodeCol.Visible = true;
            this.currencyCodeCol.Width = 51;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Сума платежу";
            this.gridBand3.Columns.Add(this.paymentPriceCol);
            this.gridBand3.Columns.Add(this.paymentPriceCurrency);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 180;
            // 
            // paymentPriceCol
            // 
            this.paymentPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentPriceCol.Caption = "Гривня";
            this.paymentPriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.paymentPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.paymentPriceCol.FieldName = "PaymentPrice";
            this.paymentPriceCol.MinWidth = 90;
            this.paymentPriceCol.Name = "paymentPriceCol";
            this.paymentPriceCol.OptionsColumn.AllowEdit = false;
            this.paymentPriceCol.OptionsColumn.AllowFocus = false;
            this.paymentPriceCol.Visible = true;
            this.paymentPriceCol.Width = 90;
            // 
            // paymentPriceCurrency
            // 
            this.paymentPriceCurrency.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentPriceCurrency.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentPriceCurrency.Caption = "Валюта";
            this.paymentPriceCurrency.DisplayFormat.FormatString = "### ### ##0.00";
            this.paymentPriceCurrency.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.paymentPriceCurrency.FieldName = "PaymentPriceCurrency";
            this.paymentPriceCurrency.MinWidth = 90;
            this.paymentPriceCurrency.Name = "paymentPriceCurrency";
            this.paymentPriceCurrency.OptionsColumn.AllowEdit = false;
            this.paymentPriceCurrency.OptionsColumn.AllowFocus = false;
            this.paymentPriceCurrency.Visible = true;
            this.paymentPriceCurrency.Width = 90;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand4.AppearanceHeader.Options.UseFont = true;
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Сума залишку";
            this.gridBand4.Columns.Add(this.paymentPriceRemainsCol);
            this.gridBand4.Columns.Add(this.paymentPriceCurrencyRemainsCol);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 180;
            // 
            // paymentPriceRemainsCol
            // 
            this.paymentPriceRemainsCol.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.paymentPriceRemainsCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.paymentPriceRemainsCol.AppearanceCell.ForeColor = System.Drawing.Color.Navy;
            this.paymentPriceRemainsCol.AppearanceCell.Options.UseBackColor = true;
            this.paymentPriceRemainsCol.AppearanceCell.Options.UseFont = true;
            this.paymentPriceRemainsCol.AppearanceCell.Options.UseForeColor = true;
            this.paymentPriceRemainsCol.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentPriceRemainsCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentPriceRemainsCol.Caption = "Гривня";
            this.paymentPriceRemainsCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.paymentPriceRemainsCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.paymentPriceRemainsCol.FieldName = "PaymentPriceRemains";
            this.paymentPriceRemainsCol.MinWidth = 90;
            this.paymentPriceRemainsCol.Name = "paymentPriceRemainsCol";
            this.paymentPriceRemainsCol.OptionsColumn.AllowEdit = false;
            this.paymentPriceRemainsCol.OptionsColumn.AllowFocus = false;
            this.paymentPriceRemainsCol.Visible = true;
            this.paymentPriceRemainsCol.Width = 90;
            // 
            // paymentPriceCurrencyRemainsCol
            // 
            this.paymentPriceCurrencyRemainsCol.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.paymentPriceCurrencyRemainsCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.paymentPriceCurrencyRemainsCol.AppearanceCell.ForeColor = System.Drawing.Color.Navy;
            this.paymentPriceCurrencyRemainsCol.AppearanceCell.Options.UseBackColor = true;
            this.paymentPriceCurrencyRemainsCol.AppearanceCell.Options.UseFont = true;
            this.paymentPriceCurrencyRemainsCol.AppearanceCell.Options.UseForeColor = true;
            this.paymentPriceCurrencyRemainsCol.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentPriceCurrencyRemainsCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentPriceCurrencyRemainsCol.Caption = "Валюта";
            this.paymentPriceCurrencyRemainsCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.paymentPriceCurrencyRemainsCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.paymentPriceCurrencyRemainsCol.FieldName = "PaymentPriceCurrencyRemains";
            this.paymentPriceCurrencyRemainsCol.MinWidth = 90;
            this.paymentPriceCurrencyRemainsCol.Name = "paymentPriceCurrencyRemainsCol";
            this.paymentPriceCurrencyRemainsCol.OptionsColumn.AllowEdit = false;
            this.paymentPriceCurrencyRemainsCol.OptionsColumn.AllowFocus = false;
            this.paymentPriceCurrencyRemainsCol.Visible = true;
            this.paymentPriceCurrencyRemainsCol.Width = 90;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand5.AppearanceHeader.Options.UseFont = true;
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.Caption = "Сума по заказу";
            this.gridBand5.Columns.Add(this.paymentPriceAddedCol);
            this.gridBand5.Columns.Add(this.paymentPriceCurrencyAddedCol);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 180;
            // 
            // paymentPriceAddedCol
            // 
            this.paymentPriceAddedCol.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.paymentPriceAddedCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.paymentPriceAddedCol.AppearanceCell.Options.UseBackColor = true;
            this.paymentPriceAddedCol.AppearanceCell.Options.UseFont = true;
            this.paymentPriceAddedCol.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentPriceAddedCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentPriceAddedCol.Caption = "Гривня";
            this.paymentPriceAddedCol.DisplayFormat.FormatString = "n2";
            this.paymentPriceAddedCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.paymentPriceAddedCol.FieldName = "PaymentPriceAdded";
            this.paymentPriceAddedCol.MinWidth = 90;
            this.paymentPriceAddedCol.Name = "paymentPriceAddedCol";
            this.paymentPriceAddedCol.Visible = true;
            this.paymentPriceAddedCol.Width = 90;
            // 
            // paymentPriceCurrencyAddedCol
            // 
            this.paymentPriceCurrencyAddedCol.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.paymentPriceCurrencyAddedCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.paymentPriceCurrencyAddedCol.AppearanceCell.Options.UseBackColor = true;
            this.paymentPriceCurrencyAddedCol.AppearanceCell.Options.UseFont = true;
            this.paymentPriceCurrencyAddedCol.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentPriceCurrencyAddedCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentPriceCurrencyAddedCol.Caption = "Валюта";
            this.paymentPriceCurrencyAddedCol.DisplayFormat.FormatString = "n2";
            this.paymentPriceCurrencyAddedCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.paymentPriceCurrencyAddedCol.FieldName = "PaymentPriceCurrencyAdded";
            this.paymentPriceCurrencyAddedCol.MinWidth = 90;
            this.paymentPriceCurrencyAddedCol.Name = "paymentPriceCurrencyAddedCol";
            this.paymentPriceCurrencyAddedCol.Visible = true;
            this.paymentPriceCurrencyAddedCol.Width = 90;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("warning_16x16.png", "images/status/warning_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/status/warning_16x16.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "warning_16x16.png");
            this.imageCollection.InsertGalleryImage("error_16x16.png", "images/status/error_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/status/error_16x16.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "error_16x16.png");
            // 
            // BankPaymentsSelectFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 636);
            this.Controls.Add(this.bankPaymentsGrid);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BankPaymentsSelectFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Банківські платежі";
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bankPaymentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankPaymentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedCheckRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl bankPaymentsGrid;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem firstDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem lastDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem viewBtn;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton okBtn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit selectedCheckRepository;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit statusRepository;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bankPaymentsGridView;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn statusCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn selectedCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn contractorSrnCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn contractorNameCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bankPaymentDateCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bankPaymentNumberCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bankAccountNumCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn purposeAccountNumCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn purposeCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn currencyCodeCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentPriceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentPriceCurrency;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentPriceRemainsCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentPriceCurrencyRemainsCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentPriceAddedCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentPriceCurrencyAddedCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.Utils.ImageCollection imageCollection;
    }
}