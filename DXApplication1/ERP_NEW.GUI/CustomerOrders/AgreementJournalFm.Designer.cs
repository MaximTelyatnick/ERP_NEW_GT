namespace ERP_NEW.GUI.CustomerOrders
{
    partial class AgreementJournalFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgreementJournalFm));
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addAgreemBut = new DevExpress.XtraBars.BarButtonItem();
            this.editAgreemBut = new DevExpress.XtraBars.BarButtonItem();
            this.deleteAgreemBut = new DevExpress.XtraBars.BarButtonItem();
            this.addDocBut = new DevExpress.XtraBars.BarButtonItem();
            this.editDocBut = new DevExpress.XtraBars.BarButtonItem();
            this.deleteDocBut = new DevExpress.XtraBars.BarButtonItem();
            this.firstDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.lastDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.searchBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.documentGrid = new DevExpress.XtraGrid.GridControl();
            this.documentGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.typeDocCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameDirect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.urlDocCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateCreateFileCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.responsiblePersonCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contractorGrid = new DevExpress.XtraGrid.GridControl();
            this.contractorGridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.nameContractorCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.numberOrderCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.dateOrderCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.typeCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.sumOrderCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.currencyCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.deliveryOrdersGridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.vendorSrnCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.vendorNameCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.receiptNumCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.orderDateCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.invoiceDateCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.invoiceNumCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.nomenclatureCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.nomenclatureNameCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.quantityCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.measureCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.currencyCodeCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.unitPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.totalPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.supplierNameCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.supplierProxyCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.taxInvoiceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.transportInvoiceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.storehouseNameCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand9 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.accountNumberCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.projectNumberCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            this.SuspendLayout();
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
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addAgreemBut,
            this.editAgreemBut,
            this.deleteAgreemBut,
            this.addDocBut,
            this.editDocBut,
            this.deleteDocBut,
            this.firstDateEdit,
            this.lastDateEdit,
            this.searchBtn,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1168, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // addAgreemBut
            // 
            this.addAgreemBut.Caption = "Додати";
            this.addAgreemBut.Glyph = ((System.Drawing.Image)(resources.GetObject("addAgreemBut.Glyph")));
            this.addAgreemBut.Id = 1;
            this.addAgreemBut.Name = "addAgreemBut";
            this.addAgreemBut.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.addAgreemBut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addAgreemBut_ItemClick);
            // 
            // editAgreemBut
            // 
            this.editAgreemBut.Caption = "Редагувати";
            this.editAgreemBut.Glyph = ((System.Drawing.Image)(resources.GetObject("editAgreemBut.Glyph")));
            this.editAgreemBut.Id = 2;
            this.editAgreemBut.Name = "editAgreemBut";
            this.editAgreemBut.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.editAgreemBut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editAgreemBut_ItemClick);
            // 
            // deleteAgreemBut
            // 
            this.deleteAgreemBut.Caption = "Видалити";
            this.deleteAgreemBut.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteAgreemBut.Glyph")));
            this.deleteAgreemBut.Id = 3;
            this.deleteAgreemBut.Name = "deleteAgreemBut";
            this.deleteAgreemBut.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.deleteAgreemBut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteAgreemBut_ItemClick);
            // 
            // addDocBut
            // 
            this.addDocBut.Caption = "Додати";
            this.addDocBut.Glyph = ((System.Drawing.Image)(resources.GetObject("addDocBut.Glyph")));
            this.addDocBut.Id = 4;
            this.addDocBut.Name = "addDocBut";
            this.addDocBut.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.addDocBut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addDocBut_ItemClick);
            // 
            // editDocBut
            // 
            this.editDocBut.Caption = "Редагувати";
            this.editDocBut.Glyph = ((System.Drawing.Image)(resources.GetObject("editDocBut.Glyph")));
            this.editDocBut.Id = 5;
            this.editDocBut.Name = "editDocBut";
            this.editDocBut.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.editDocBut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editDocBut_ItemClick);
            // 
            // deleteDocBut
            // 
            this.deleteDocBut.Caption = "Видалити";
            this.deleteDocBut.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteDocBut.Glyph")));
            this.deleteDocBut.Id = 6;
            this.deleteDocBut.Name = "deleteDocBut";
            this.deleteDocBut.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.deleteDocBut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteDocBut_ItemClick);
            // 
            // firstDateEdit
            // 
            this.firstDateEdit.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.firstDateEdit.Caption = "  Початкова дата";
            this.firstDateEdit.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.firstDateEdit.Edit = this.repositoryItemDateEdit1;
            this.firstDateEdit.EditWidth = 100;
            this.firstDateEdit.Id = 8;
            this.firstDateEdit.Name = "firstDateEdit";
            // 
            // lastDateEdit
            // 
            this.lastDateEdit.Caption = "  Кінцева дата";
            this.lastDateEdit.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lastDateEdit.Edit = this.repositoryItemDateEdit2;
            this.lastDateEdit.EditWidth = 100;
            this.lastDateEdit.Id = 9;
            this.lastDateEdit.Name = "lastDateEdit";
            // 
            // searchBtn
            // 
            this.searchBtn.Caption = "Показати";
            this.searchBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("searchBtn.Glyph")));
            this.searchBtn.Id = 10;
            this.searchBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("searchBtn.LargeGlyph")));
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.searchBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.searchBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.firstDateEdit);
            this.ribbonPageGroup3.ItemLinks.Add(this.lastDateEdit);
            this.ribbonPageGroup3.ItemLinks.Add(this.searchBtn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Період";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.addAgreemBut);
            this.ribbonPageGroup1.ItemLinks.Add(this.editAgreemBut);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteAgreemBut);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Договір";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.addDocBut);
            this.ribbonPageGroup2.ItemLinks.Add(this.editDocBut);
            this.ribbonPageGroup2.ItemLinks.Add(this.deleteDocBut);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Документ";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.documentGrid);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 403);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1168, 159);
            this.panelControl1.TabIndex = 1;
            // 
            // documentGrid
            // 
            this.documentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentGrid.Location = new System.Drawing.Point(2, 2);
            this.documentGrid.MainView = this.documentGridView;
            this.documentGrid.MenuManager = this.ribbonControl1;
            this.documentGrid.Name = "documentGrid";
            this.documentGrid.Size = new System.Drawing.Size(1164, 155);
            this.documentGrid.TabIndex = 0;
            this.documentGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.documentGridView});
            // 
            // documentGridView
            // 
            this.documentGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.typeDocCol,
            this.nameDirect,
            this.urlDocCol,
            this.dateCreateFileCol,
            this.responsiblePersonCol});
            this.documentGridView.GridControl = this.documentGrid;
            this.documentGridView.Name = "documentGridView";
            this.documentGridView.OptionsView.ShowAutoFilterRow = true;
            this.documentGridView.OptionsView.ShowGroupPanel = false;
            this.documentGridView.DoubleClick += new System.EventHandler(this.documentGridView_DoubleClick);
            // 
            // typeDocCol
            // 
            this.typeDocCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.typeDocCol.AppearanceHeader.Options.UseFont = true;
            this.typeDocCol.AppearanceHeader.Options.UseTextOptions = true;
            this.typeDocCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.typeDocCol.Caption = "Тип файлу";
            this.typeDocCol.FieldName = "AgreementTypeDocumentsName";
            this.typeDocCol.Name = "typeDocCol";
            this.typeDocCol.OptionsColumn.AllowEdit = false;
            this.typeDocCol.OptionsColumn.AllowFocus = false;
            this.typeDocCol.OptionsFilter.AllowAutoFilter = false;
            this.typeDocCol.OptionsFilter.AllowFilter = false;
            this.typeDocCol.Visible = true;
            this.typeDocCol.VisibleIndex = 0;
            this.typeDocCol.Width = 181;
            // 
            // nameDirect
            // 
            this.nameDirect.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nameDirect.AppearanceHeader.Options.UseFont = true;
            this.nameDirect.AppearanceHeader.Options.UseTextOptions = true;
            this.nameDirect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameDirect.Caption = "Ім\'я документа";
            this.nameDirect.FieldName = "NameDocument";
            this.nameDirect.Name = "nameDirect";
            this.nameDirect.OptionsColumn.AllowEdit = false;
            this.nameDirect.OptionsColumn.AllowFocus = false;
            this.nameDirect.OptionsFilter.AllowAutoFilter = false;
            this.nameDirect.OptionsFilter.AllowFilter = false;
            this.nameDirect.Visible = true;
            this.nameDirect.VisibleIndex = 1;
            this.nameDirect.Width = 189;
            // 
            // urlDocCol
            // 
            this.urlDocCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.urlDocCol.AppearanceHeader.Options.UseFont = true;
            this.urlDocCol.AppearanceHeader.Options.UseTextOptions = true;
            this.urlDocCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.urlDocCol.Caption = "URL";
            this.urlDocCol.FieldName = "URL";
            this.urlDocCol.Name = "urlDocCol";
            this.urlDocCol.OptionsColumn.AllowEdit = false;
            this.urlDocCol.OptionsColumn.AllowFocus = false;
            this.urlDocCol.OptionsFilter.AllowAutoFilter = false;
            this.urlDocCol.OptionsFilter.AllowFilter = false;
            this.urlDocCol.Visible = true;
            this.urlDocCol.VisibleIndex = 2;
            this.urlDocCol.Width = 395;
            // 
            // dateCreateFileCol
            // 
            this.dateCreateFileCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateCreateFileCol.AppearanceHeader.Options.UseFont = true;
            this.dateCreateFileCol.AppearanceHeader.Options.UseTextOptions = true;
            this.dateCreateFileCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateCreateFileCol.Caption = "Дата створення";
            this.dateCreateFileCol.FieldName = "DateCreateFile";
            this.dateCreateFileCol.Name = "dateCreateFileCol";
            this.dateCreateFileCol.OptionsColumn.AllowEdit = false;
            this.dateCreateFileCol.OptionsColumn.AllowFocus = false;
            this.dateCreateFileCol.OptionsFilter.AllowAutoFilter = false;
            this.dateCreateFileCol.OptionsFilter.AllowFilter = false;
            this.dateCreateFileCol.Visible = true;
            this.dateCreateFileCol.VisibleIndex = 3;
            this.dateCreateFileCol.Width = 139;
            // 
            // responsiblePersonCol
            // 
            this.responsiblePersonCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.responsiblePersonCol.AppearanceHeader.Options.UseFont = true;
            this.responsiblePersonCol.AppearanceHeader.Options.UseTextOptions = true;
            this.responsiblePersonCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.responsiblePersonCol.Caption = "Відповідальна особа";
            this.responsiblePersonCol.FieldName = "ResponsiblePerson";
            this.responsiblePersonCol.Name = "responsiblePersonCol";
            this.responsiblePersonCol.OptionsColumn.AllowEdit = false;
            this.responsiblePersonCol.OptionsColumn.AllowFocus = false;
            this.responsiblePersonCol.OptionsFilter.AllowAutoFilter = false;
            this.responsiblePersonCol.OptionsFilter.AllowFilter = false;
            this.responsiblePersonCol.Visible = true;
            this.responsiblePersonCol.VisibleIndex = 4;
            this.responsiblePersonCol.Width = 242;
            // 
            // contractorGrid
            // 
            this.contractorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractorGrid.Location = new System.Drawing.Point(0, 95);
            this.contractorGrid.MainView = this.contractorGridView;
            this.contractorGrid.Name = "contractorGrid";
            this.contractorGrid.Size = new System.Drawing.Size(1168, 308);
            this.contractorGrid.TabIndex = 2;
            this.contractorGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.contractorGridView});
            // 
            // contractorGridView
            // 
            this.contractorGridView.Appearance.BandPanel.BackColor = System.Drawing.Color.White;
            this.contractorGridView.Appearance.BandPanel.Options.UseBackColor = true;
            this.contractorGridView.Appearance.HeaderPanelBackground.BackColor = System.Drawing.Color.White;
            this.contractorGridView.Appearance.HeaderPanelBackground.Options.UseBackColor = true;
            this.contractorGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.contractorGridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.nameContractorCol,
            this.numberOrderCol,
            this.dateOrderCol,
            this.sumOrderCol,
            this.bandedGridColumn5,
            this.typeCol,
            this.currencyCol});
            this.contractorGridView.GridControl = this.contractorGrid;
            this.contractorGridView.Name = "contractorGridView";
            this.contractorGridView.OptionsView.ShowAutoFilterRow = true;
            this.contractorGridView.OptionsView.ShowGroupPanel = false;
            this.contractorGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.contractorGridView_FocusedRowChanged);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.gridBand1.AppearanceHeader.BorderColor = System.Drawing.Color.White;
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridBand1.AppearanceHeader.Options.UseBackColor = true;
            this.gridBand1.AppearanceHeader.Options.UseBorderColor = true;
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Інформація по контрагенту";
            this.gridBand1.Columns.Add(this.nameContractorCol);
            this.gridBand1.Columns.Add(this.bandedGridColumn5);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 336;
            // 
            // nameContractorCol
            // 
            this.nameContractorCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nameContractorCol.AppearanceHeader.Options.UseFont = true;
            this.nameContractorCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nameContractorCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameContractorCol.Caption = "Назва контрагента";
            this.nameContractorCol.FieldName = "ContractorName";
            this.nameContractorCol.Name = "nameContractorCol";
            this.nameContractorCol.OptionsColumn.AllowEdit = false;
            this.nameContractorCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nameContractorCol.Visible = true;
            this.nameContractorCol.Width = 190;
            // 
            // bandedGridColumn5
            // 
            this.bandedGridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bandedGridColumn5.AppearanceHeader.Options.UseFont = true;
            this.bandedGridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.bandedGridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridColumn5.Caption = "ЄДРПО";
            this.bandedGridColumn5.FieldName = "Srn";
            this.bandedGridColumn5.Name = "bandedGridColumn5";
            this.bandedGridColumn5.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.bandedGridColumn5.Visible = true;
            this.bandedGridColumn5.Width = 146;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Договір";
            this.gridBand2.Columns.Add(this.numberOrderCol);
            this.gridBand2.Columns.Add(this.dateOrderCol);
            this.gridBand2.Columns.Add(this.typeCol);
            this.gridBand2.Columns.Add(this.sumOrderCol);
            this.gridBand2.Columns.Add(this.currencyCol);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 751;
            // 
            // numberOrderCol
            // 
            this.numberOrderCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.numberOrderCol.AppearanceHeader.Options.UseFont = true;
            this.numberOrderCol.AppearanceHeader.Options.UseTextOptions = true;
            this.numberOrderCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.numberOrderCol.Caption = "Номер";
            this.numberOrderCol.FieldName = "NumberOrder";
            this.numberOrderCol.Name = "numberOrderCol";
            this.numberOrderCol.OptionsColumn.AllowEdit = false;
            this.numberOrderCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.numberOrderCol.Visible = true;
            this.numberOrderCol.Width = 290;
            // 
            // dateOrderCol
            // 
            this.dateOrderCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateOrderCol.AppearanceHeader.Options.UseFont = true;
            this.dateOrderCol.AppearanceHeader.Options.UseTextOptions = true;
            this.dateOrderCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateOrderCol.Caption = "Дата";
            this.dateOrderCol.FieldName = "DateOrder";
            this.dateOrderCol.Name = "dateOrderCol";
            this.dateOrderCol.OptionsColumn.AllowEdit = false;
            this.dateOrderCol.OptionsColumn.AllowFocus = false;
            this.dateOrderCol.OptionsFilter.AllowAutoFilter = false;
            this.dateOrderCol.OptionsFilter.AllowFilter = false;
            this.dateOrderCol.Visible = true;
            this.dateOrderCol.Width = 95;
            // 
            // typeCol
            // 
            this.typeCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.typeCol.AppearanceHeader.Options.UseFont = true;
            this.typeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.typeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.typeCol.Caption = "Вид";
            this.typeCol.FieldName = "Type";
            this.typeCol.Name = "typeCol";
            this.typeCol.OptionsColumn.AllowEdit = false;
            this.typeCol.OptionsColumn.AllowFocus = false;
            this.typeCol.OptionsFilter.AllowAutoFilter = false;
            this.typeCol.OptionsFilter.AllowFilter = false;
            this.typeCol.Visible = true;
            this.typeCol.Width = 121;
            // 
            // sumOrderCol
            // 
            this.sumOrderCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.sumOrderCol.AppearanceHeader.Options.UseFont = true;
            this.sumOrderCol.AppearanceHeader.Options.UseTextOptions = true;
            this.sumOrderCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sumOrderCol.Caption = "Сума";
            this.sumOrderCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.sumOrderCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.sumOrderCol.FieldName = "Price";
            this.sumOrderCol.Name = "sumOrderCol";
            this.sumOrderCol.OptionsFilter.AllowAutoFilter = false;
            this.sumOrderCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Price", "{0:### ### ##0.00}")});
            this.sumOrderCol.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.sumOrderCol.Visible = true;
            this.sumOrderCol.Width = 170;
            // 
            // currencyCol
            // 
            this.currencyCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.currencyCol.AppearanceHeader.Options.UseFont = true;
            this.currencyCol.AppearanceHeader.Options.UseTextOptions = true;
            this.currencyCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.currencyCol.Caption = "Валюта";
            this.currencyCol.FieldName = "CurrencyName";
            this.currencyCol.Name = "currencyCol";
            this.currencyCol.OptionsColumn.AllowEdit = false;
            this.currencyCol.OptionsColumn.AllowFocus = false;
            this.currencyCol.OptionsFilter.AllowAutoFilter = false;
            this.currencyCol.OptionsFilter.AllowFilter = false;
            this.currencyCol.Visible = true;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // deliveryOrdersGridView
            // 
            this.deliveryOrdersGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand5,
            this.gridBand3,
            this.gridBand4,
            this.gridBand6,
            this.gridBand7,
            this.gridBand8,
            this.gridBand9});
            this.deliveryOrdersGridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.vendorSrnCol,
            this.vendorNameCol,
            this.receiptNumCol,
            this.orderDateCol,
            this.invoiceDateCol,
            this.invoiceNumCol,
            this.nomenclatureCol,
            this.nomenclatureNameCol,
            this.quantityCol,
            this.measureCol,
            this.unitPriceCol,
            this.totalPriceCol,
            this.currencyCodeCol,
            this.supplierNameCol,
            this.supplierProxyCol,
            this.taxInvoiceCol,
            this.transportInvoiceCol,
            this.storehouseNameCol,
            this.accountNumberCol,
            this.projectNumberCol});
            this.deliveryOrdersGridView.GridControl = this.gridControl2;
            this.deliveryOrdersGridView.GroupCount = 1;
            this.deliveryOrdersGridView.Name = "deliveryOrdersGridView";
            this.deliveryOrdersGridView.OptionsView.ShowAutoFilterRow = true;
            this.deliveryOrdersGridView.OptionsView.ShowFooter = true;
            this.deliveryOrdersGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.storehouseNameCol, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand5.AppearanceHeader.Options.UseFont = true;
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.Caption = "Контрагент";
            this.gridBand5.Columns.Add(this.vendorSrnCol);
            this.gridBand5.Columns.Add(this.vendorNameCol);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 0;
            this.gridBand5.Width = 263;
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
            this.vendorSrnCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.vendorSrnCol.Visible = true;
            this.vendorSrnCol.Width = 71;
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
            this.vendorNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.vendorNameCol.Visible = true;
            this.vendorNameCol.Width = 192;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Надходження";
            this.gridBand3.Columns.Add(this.receiptNumCol);
            this.gridBand3.Columns.Add(this.orderDateCol);
            this.gridBand3.Columns.Add(this.invoiceDateCol);
            this.gridBand3.Columns.Add(this.invoiceNumCol);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 1;
            this.gridBand3.Width = 312;
            // 
            // receiptNumCol
            // 
            this.receiptNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.receiptNumCol.AppearanceHeader.Options.UseFont = true;
            this.receiptNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.receiptNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.receiptNumCol.Caption = "№ прих.";
            this.receiptNumCol.FieldName = "ReceiptNum";
            this.receiptNumCol.Name = "receiptNumCol";
            this.receiptNumCol.OptionsColumn.AllowEdit = false;
            this.receiptNumCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.receiptNumCol.Visible = true;
            this.receiptNumCol.Width = 66;
            // 
            // orderDateCol
            // 
            this.orderDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.orderDateCol.AppearanceHeader.Options.UseFont = true;
            this.orderDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderDateCol.Caption = "Дата прих.";
            this.orderDateCol.DisplayFormat.FormatString = "d";
            this.orderDateCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.orderDateCol.FieldName = "OrderDate";
            this.orderDateCol.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.OptionsColumn.AllowEdit = false;
            this.orderDateCol.Visible = true;
            this.orderDateCol.Width = 71;
            // 
            // invoiceDateCol
            // 
            this.invoiceDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.invoiceDateCol.AppearanceHeader.Options.UseFont = true;
            this.invoiceDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.invoiceDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.invoiceDateCol.Caption = "Дата накл.";
            this.invoiceDateCol.DisplayFormat.FormatString = "d";
            this.invoiceDateCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.invoiceDateCol.FieldName = "InvoiceDate";
            this.invoiceDateCol.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.invoiceDateCol.Name = "invoiceDateCol";
            this.invoiceDateCol.OptionsColumn.AllowEdit = false;
            this.invoiceDateCol.Visible = true;
            this.invoiceDateCol.Width = 66;
            // 
            // invoiceNumCol
            // 
            this.invoiceNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.invoiceNumCol.AppearanceHeader.Options.UseFont = true;
            this.invoiceNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.invoiceNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.invoiceNumCol.Caption = "№ накл.";
            this.invoiceNumCol.FieldName = "InvoiceNum";
            this.invoiceNumCol.Name = "invoiceNumCol";
            this.invoiceNumCol.OptionsColumn.AllowEdit = false;
            this.invoiceNumCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.invoiceNumCol.Visible = true;
            this.invoiceNumCol.Width = 109;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand4.AppearanceHeader.Options.UseFont = true;
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Матеріали";
            this.gridBand4.Columns.Add(this.nomenclatureCol);
            this.gridBand4.Columns.Add(this.nomenclatureNameCol);
            this.gridBand4.Columns.Add(this.quantityCol);
            this.gridBand4.Columns.Add(this.measureCol);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 2;
            this.gridBand4.Width = 407;
            // 
            // nomenclatureCol
            // 
            this.nomenclatureCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nomenclatureCol.AppearanceHeader.Options.UseFont = true;
            this.nomenclatureCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureCol.Caption = "Ном. номер";
            this.nomenclatureCol.FieldName = "Nomenclature";
            this.nomenclatureCol.Name = "nomenclatureCol";
            this.nomenclatureCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nomenclatureCol.Visible = true;
            this.nomenclatureCol.Width = 76;
            // 
            // nomenclatureNameCol
            // 
            this.nomenclatureNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nomenclatureNameCol.AppearanceHeader.Options.UseFont = true;
            this.nomenclatureNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureNameCol.Caption = "Наіменування";
            this.nomenclatureNameCol.FieldName = "NomenclatureName";
            this.nomenclatureNameCol.Name = "nomenclatureNameCol";
            this.nomenclatureNameCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nomenclatureNameCol.Visible = true;
            this.nomenclatureNameCol.Width = 221;
            // 
            // quantityCol
            // 
            this.quantityCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.quantityCol.AppearanceHeader.Options.UseFont = true;
            this.quantityCol.AppearanceHeader.Options.UseTextOptions = true;
            this.quantityCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.quantityCol.Caption = "Кількість";
            this.quantityCol.FieldName = "Quantity";
            this.quantityCol.Name = "quantityCol";
            this.quantityCol.OptionsColumn.AllowEdit = false;
            this.quantityCol.Visible = true;
            this.quantityCol.Width = 56;
            // 
            // measureCol
            // 
            this.measureCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.measureCol.AppearanceHeader.Options.UseFont = true;
            this.measureCol.AppearanceHeader.Options.UseTextOptions = true;
            this.measureCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.measureCol.Caption = "Од.вим.";
            this.measureCol.FieldName = "Measure";
            this.measureCol.Name = "measureCol";
            this.measureCol.OptionsColumn.AllowEdit = false;
            this.measureCol.Visible = true;
            this.measureCol.Width = 54;
            // 
            // gridBand6
            // 
            this.gridBand6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand6.AppearanceHeader.Options.UseFont = true;
            this.gridBand6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand6.Caption = "Суми";
            this.gridBand6.Columns.Add(this.currencyCodeCol);
            this.gridBand6.Columns.Add(this.unitPriceCol);
            this.gridBand6.Columns.Add(this.totalPriceCol);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 3;
            this.gridBand6.Width = 244;
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
            this.currencyCodeCol.Visible = true;
            this.currencyCodeCol.Width = 49;
            // 
            // unitPriceCol
            // 
            this.unitPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.unitPriceCol.AppearanceHeader.Options.UseFont = true;
            this.unitPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.unitPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unitPriceCol.Caption = "Ціна за од.";
            this.unitPriceCol.DisplayFormat.FormatString = "{0:### ### ##0.00}";
            this.unitPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.unitPriceCol.FieldName = "UnitPrice";
            this.unitPriceCol.Name = "unitPriceCol";
            this.unitPriceCol.OptionsColumn.AllowEdit = false;
            this.unitPriceCol.Visible = true;
            this.unitPriceCol.Width = 88;
            // 
            // totalPriceCol
            // 
            this.totalPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.totalPriceCol.AppearanceHeader.Options.UseFont = true;
            this.totalPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.totalPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.totalPriceCol.Caption = "Сума без ПДВ";
            this.totalPriceCol.DisplayFormat.FormatString = "{0:### ### ##0.00}";
            this.totalPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.totalPriceCol.FieldName = "TotalPrice";
            this.totalPriceCol.Name = "totalPriceCol";
            this.totalPriceCol.OptionsColumn.AllowEdit = false;
            this.totalPriceCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "{0:### ### ##0.00}")});
            this.totalPriceCol.Visible = true;
            this.totalPriceCol.Width = 107;
            // 
            // gridBand7
            // 
            this.gridBand7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand7.AppearanceHeader.Options.UseFont = true;
            this.gridBand7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand7.Caption = "Постачальник";
            this.gridBand7.Columns.Add(this.supplierNameCol);
            this.gridBand7.Columns.Add(this.supplierProxyCol);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.VisibleIndex = 4;
            this.gridBand7.Width = 252;
            // 
            // supplierNameCol
            // 
            this.supplierNameCol.AppearanceCell.Options.UseTextOptions = true;
            this.supplierNameCol.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.supplierNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.supplierNameCol.AppearanceHeader.Options.UseFont = true;
            this.supplierNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.supplierNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.supplierNameCol.Caption = "Постачальник";
            this.supplierNameCol.FieldName = "SupplierName";
            this.supplierNameCol.Name = "supplierNameCol";
            this.supplierNameCol.OptionsColumn.AllowEdit = false;
            this.supplierNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.supplierNameCol.Visible = true;
            this.supplierNameCol.Width = 110;
            // 
            // supplierProxyCol
            // 
            this.supplierProxyCol.AppearanceCell.Options.UseTextOptions = true;
            this.supplierProxyCol.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.supplierProxyCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.supplierProxyCol.AppearanceHeader.Options.UseFont = true;
            this.supplierProxyCol.AppearanceHeader.Options.UseTextOptions = true;
            this.supplierProxyCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.supplierProxyCol.Caption = "Довіреність";
            this.supplierProxyCol.FieldName = "SupplierProxy";
            this.supplierProxyCol.Name = "supplierProxyCol";
            this.supplierProxyCol.OptionsColumn.AllowEdit = false;
            this.supplierProxyCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.supplierProxyCol.Visible = true;
            this.supplierProxyCol.Width = 142;
            // 
            // gridBand8
            // 
            this.gridBand8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand8.AppearanceHeader.Options.UseFont = true;
            this.gridBand8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand8.Caption = "Накладні";
            this.gridBand8.Columns.Add(this.taxInvoiceCol);
            this.gridBand8.Columns.Add(this.transportInvoiceCol);
            this.gridBand8.Columns.Add(this.storehouseNameCol);
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.VisibleIndex = 5;
            this.gridBand8.Width = 107;
            // 
            // taxInvoiceCol
            // 
            this.taxInvoiceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.taxInvoiceCol.AppearanceHeader.Options.UseFont = true;
            this.taxInvoiceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.taxInvoiceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.taxInvoiceCol.Caption = "Нал.накл.";
            this.taxInvoiceCol.ColumnEdit = this.repositoryItemCheckEdit1;
            this.taxInvoiceCol.FieldName = "TaxInvoice";
            this.taxInvoiceCol.Name = "taxInvoiceCol";
            this.taxInvoiceCol.OptionsColumn.AllowEdit = false;
            this.taxInvoiceCol.Visible = true;
            this.taxInvoiceCol.Width = 51;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.DisplayValueChecked = "1";
            this.repositoryItemCheckEdit1.DisplayValueUnchecked = "0";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = ((short)(1));
            this.repositoryItemCheckEdit1.ValueUnchecked = ((short)(0));
            // 
            // transportInvoiceCol
            // 
            this.transportInvoiceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.transportInvoiceCol.AppearanceHeader.Options.UseFont = true;
            this.transportInvoiceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.transportInvoiceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.transportInvoiceCol.Caption = "Тран.накл.";
            this.transportInvoiceCol.ColumnEdit = this.repositoryItemCheckEdit2;
            this.transportInvoiceCol.FieldName = "TransportInvoice";
            this.transportInvoiceCol.Name = "transportInvoiceCol";
            this.transportInvoiceCol.OptionsColumn.AllowEdit = false;
            this.transportInvoiceCol.Visible = true;
            this.transportInvoiceCol.Width = 56;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.DisplayValueChecked = "1";
            this.repositoryItemCheckEdit2.DisplayValueUnchecked = "0";
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.ValueChecked = ((short)(1));
            this.repositoryItemCheckEdit2.ValueUnchecked = ((short)(0));
            // 
            // storehouseNameCol
            // 
            this.storehouseNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.storehouseNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.storehouseNameCol.Caption = "Склад";
            this.storehouseNameCol.FieldName = "StorehouseName";
            this.storehouseNameCol.Name = "storehouseNameCol";
            this.storehouseNameCol.Width = 109;
            // 
            // gridBand9
            // 
            this.gridBand9.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridBand9.AppearanceHeader.Options.UseFont = true;
            this.gridBand9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand9.Caption = "Заказ";
            this.gridBand9.Columns.Add(this.accountNumberCol);
            this.gridBand9.Columns.Add(this.projectNumberCol);
            this.gridBand9.Name = "gridBand9";
            this.gridBand9.VisibleIndex = 6;
            this.gridBand9.Width = 150;
            // 
            // accountNumberCol
            // 
            this.accountNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountNumberCol.AppearanceHeader.Options.UseFont = true;
            this.accountNumberCol.Caption = "Номер заказу";
            this.accountNumberCol.FieldName = "AccountNumber";
            this.accountNumberCol.Name = "accountNumberCol";
            this.accountNumberCol.Visible = true;
            // 
            // projectNumberCol
            // 
            this.projectNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectNumberCol.AppearanceHeader.Options.UseFont = true;
            this.projectNumberCol.Caption = "Номер проекту";
            this.projectNumberCol.FieldName = "ProjectNumber";
            this.projectNumberCol.Name = "projectNumberCol";
            this.projectNumberCol.Visible = true;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 2);
            this.gridControl2.MainView = this.deliveryOrdersGridView;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.gridControl2.Size = new System.Drawing.Size(1390, 575);
            this.gridControl2.TabIndex = 4;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.deliveryOrdersGridView});
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // AgreementJournalFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 562);
            this.Controls.Add(this.contractorGrid);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "AgreementJournalFm";
            this.ShowIcon = false;
            this.Text = "Журнал договорів";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl contractorGrid;
        private DevExpress.XtraBars.BarButtonItem addAgreemBut;
        private DevExpress.XtraBars.BarButtonItem editAgreemBut;
        private DevExpress.XtraBars.BarButtonItem deleteAgreemBut;
        private DevExpress.XtraGrid.GridControl documentGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView documentGridView;
        private DevExpress.XtraGrid.Columns.GridColumn typeDocCol;
        private DevExpress.XtraGrid.Columns.GridColumn urlDocCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView contractorGridView;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn nameContractorCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn numberOrderCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn dateOrderCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn sumOrderCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn typeCol;
        private DevExpress.XtraBars.BarButtonItem addDocBut;
        private DevExpress.XtraBars.BarButtonItem editDocBut;
        private DevExpress.XtraBars.BarButtonItem deleteDocBut;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn nameDirect;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Columns.GridColumn dateCreateFileCol;
        private DevExpress.XtraGrid.Columns.GridColumn responsiblePersonCol;
        private DevExpress.XtraBars.BarEditItem firstDateEdit;
        private DevExpress.XtraBars.BarEditItem lastDateEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem searchBtn;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn currencyCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView deliveryOrdersGridView;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn vendorSrnCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn vendorNameCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn receiptNumCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn orderDateCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn invoiceDateCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn invoiceNumCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn nomenclatureCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn nomenclatureNameCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn quantityCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn measureCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn currencyCodeCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn unitPriceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn totalPriceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn supplierNameCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn supplierProxyCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn taxInvoiceCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn transportInvoiceCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn storehouseNameCol;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand9;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn accountNumberCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn projectNumberCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}