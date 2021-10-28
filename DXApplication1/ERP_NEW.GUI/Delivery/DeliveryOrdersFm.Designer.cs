namespace ERP_NEW.GUI.Delivery
{
    partial class DeliveryOrdersFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryOrdersFm));
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.firstDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.beginDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.endDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.searchBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.printBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addCustomerOrdersBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editСustomerOrdersBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.receiptNumberEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.deleteOrdersFromReceiptBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.deliveryOrdersGrid = new DevExpress.XtraGrid.GridControl();
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
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.selectedCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.selectedCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // firstDateEdit
            // 
            this.firstDateEdit.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.firstDateEdit.Caption = "  Початкова дата";
            this.firstDateEdit.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.firstDateEdit.Edit = null;
            this.firstDateEdit.EditWidth = 100;
            this.firstDateEdit.Id = 8;
            this.firstDateEdit.Name = "firstDateEdit";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 141);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1394, 533);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.beginDateEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.endDateEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.searchBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Період";
            // 
            // beginDateEdit
            // 
            this.beginDateEdit.Caption = "  Початкова дата";
            this.beginDateEdit.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.beginDateEdit.Edit = this.repositoryItemDateEdit1;
            this.beginDateEdit.EditWidth = 100;
            this.beginDateEdit.Id = 1;
            this.beginDateEdit.Name = "beginDateEdit";
            this.beginDateEdit.EditValueChanged += new System.EventHandler(this.beginDateEdit_EditValueChanged);
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
            this.endDateEdit.Caption = " Кінцева дата";
            this.endDateEdit.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.endDateEdit.Edit = this.repositoryItemDateEdit2;
            this.endDateEdit.EditWidth = 100;
            this.endDateEdit.Id = 2;
            this.endDateEdit.Name = "endDateEdit";
            this.endDateEdit.EditValueChanged += new System.EventHandler(this.endDateEdit_EditValueChanged);
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
            // searchBtn
            // 
            this.searchBtn.Caption = "Показати";
            this.searchBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("searchBtn.Glyph")));
            this.searchBtn.Id = 3;
            this.searchBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("searchBtn.LargeGlyph")));
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.searchBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.searchBtn_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.printBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.addCustomerOrdersBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.editСustomerOrdersBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Функції";
            // 
            // printBtn
            // 
            this.printBtn.Caption = "Друк";
            this.printBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("printBtn.Glyph")));
            this.printBtn.Id = 4;
            this.printBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("printBtn.LargeGlyph")));
            this.printBtn.Name = "printBtn";
            this.printBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.printBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.printBtn_ItemClick);
            // 
            // addCustomerOrdersBtn
            // 
            this.addCustomerOrdersBtn.Caption = "Прикріпити заказ";
            this.addCustomerOrdersBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addCustomerOrdersBtn.Glyph")));
            this.addCustomerOrdersBtn.Id = 4;
            this.addCustomerOrdersBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addCustomerOrdersBtn.LargeGlyph")));
            this.addCustomerOrdersBtn.Name = "addCustomerOrdersBtn";
            this.addCustomerOrdersBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addCustomerOrdersBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addCustomerOrdersBtn_ItemClick);
            // 
            // editСustomerOrdersBtn
            // 
            this.editСustomerOrdersBtn.Caption = "Редагувати";
            this.editСustomerOrdersBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editСustomerOrdersBtn.Glyph")));
            this.editСustomerOrdersBtn.Id = 5;
            this.editСustomerOrdersBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editСustomerOrdersBtn.LargeGlyph")));
            this.editСustomerOrdersBtn.Name = "editСustomerOrdersBtn";
            this.editСustomerOrdersBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editСustomerOrdersBtn_ItemClick);
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.receiptNumberEdit);
            this.ribbonPageGroup3.ItemLinks.Add(this.deleteOrdersFromReceiptBtn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Надходження";
            // 
            // receiptNumberEdit
            // 
            this.receiptNumberEdit.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.receiptNumberEdit.CanOpenEdit = false;
            this.receiptNumberEdit.Edit = this.repositoryItemLookUpEdit;
            this.receiptNumberEdit.EditWidth = 140;
            this.receiptNumberEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("receiptNumberEdit.Glyph")));
            this.receiptNumberEdit.Id = 6;
            this.receiptNumberEdit.Name = "receiptNumberEdit";
            this.receiptNumberEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // repositoryItemLookUpEdit
            // 
            this.repositoryItemLookUpEdit.AutoHeight = false;
            this.repositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ReceiptNum", "Номер надходження", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.repositoryItemLookUpEdit.Name = "repositoryItemLookUpEdit";
            this.repositoryItemLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            // 
            // deleteOrdersFromReceiptBtn
            // 
            this.deleteOrdersFromReceiptBtn.Caption = "Видалити закази з надходження";
            this.deleteOrdersFromReceiptBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteOrdersFromReceiptBtn.Glyph")));
            this.deleteOrdersFromReceiptBtn.Id = 7;
            this.deleteOrdersFromReceiptBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteOrdersFromReceiptBtn.LargeGlyph")));
            this.deleteOrdersFromReceiptBtn.Name = "deleteOrdersFromReceiptBtn";
            this.deleteOrdersFromReceiptBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deleteOrdersFromReceiptBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteOrdersFromReceiptBtn_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(1394, 22);
            // 
            // ribbonControl
            // 
            this.ribbonControl.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.beginDateEdit,
            this.endDateEdit,
            this.searchBtn,
            this.printBtn,
            this.addCustomerOrdersBtn,
            this.editСustomerOrdersBtn,
            this.receiptNumberEdit,
            this.deleteOrdersFromReceiptBtn});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 8;
            this.ribbonControl.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemLookUpEdit});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.Size = new System.Drawing.Size(1394, 95);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.deliveryOrdersGrid);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 95);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1394, 579);
            this.panelControl1.TabIndex = 1;
            // 
            // deliveryOrdersGrid
            // 
            this.deliveryOrdersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deliveryOrdersGrid.Location = new System.Drawing.Point(2, 2);
            this.deliveryOrdersGrid.MainView = this.deliveryOrdersGridView;
            this.deliveryOrdersGrid.Name = "deliveryOrdersGrid";
            this.deliveryOrdersGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.selectedCheckEdit,
            this.repositoryItemMemoEdit1});
            this.deliveryOrdersGrid.Size = new System.Drawing.Size(1390, 575);
            this.deliveryOrdersGrid.TabIndex = 4;
            this.deliveryOrdersGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.deliveryOrdersGridView});
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
            this.projectNumberCol,
            this.selectedCol});
            this.deliveryOrdersGridView.GridControl = this.deliveryOrdersGrid;
            this.deliveryOrdersGridView.GroupCount = 1;
            this.deliveryOrdersGridView.Name = "deliveryOrdersGridView";
            this.deliveryOrdersGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.deliveryOrdersGridView.OptionsPrint.AutoWidth = false;
            this.deliveryOrdersGridView.OptionsView.AllowCellMerge = true;
            this.deliveryOrdersGridView.OptionsView.ShowAutoFilterRow = true;
            this.deliveryOrdersGridView.OptionsView.ShowFooter = true;
            this.deliveryOrdersGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.storehouseNameCol, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.deliveryOrdersGridView.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.deliveryOrdersGridView_CellMerge);
            this.deliveryOrdersGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.deliveryOrdersGridView_ShowingEditor);
            this.deliveryOrdersGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.deliveryOrdersGridView_FocusedRowChanged);
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
            this.gridBand5.Width = 207;
            // 
            // vendorSrnCol
            // 
            this.vendorSrnCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.vendorSrnCol.AppearanceHeader.Options.UseFont = true;
            this.vendorSrnCol.AppearanceHeader.Options.UseTextOptions = true;
            this.vendorSrnCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vendorSrnCol.Caption = "Код ЄДРПОУ";
            this.vendorSrnCol.CustomizationCaption = "Код ЄДРПОУ";
            this.vendorSrnCol.FieldName = "VendorSrn";
            this.vendorSrnCol.Name = "vendorSrnCol";
            this.vendorSrnCol.OptionsColumn.AllowEdit = false;
            this.vendorSrnCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.vendorSrnCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.vendorSrnCol.Visible = true;
            this.vendorSrnCol.Width = 55;
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
            this.vendorNameCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.vendorNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.vendorNameCol.Visible = true;
            this.vendorNameCol.Width = 152;
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
            this.gridBand3.Width = 261;
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
            this.receiptNumCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.receiptNumCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.receiptNumCol.Visible = true;
            this.receiptNumCol.Width = 67;
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
            this.orderDateCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.orderDateCol.Visible = true;
            this.orderDateCol.Width = 55;
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
            this.invoiceDateCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.invoiceDateCol.Visible = true;
            this.invoiceDateCol.Width = 52;
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
            this.invoiceNumCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.invoiceNumCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.invoiceNumCol.Visible = true;
            this.invoiceNumCol.Width = 87;
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
            this.gridBand4.Width = 315;
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
            this.nomenclatureCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.nomenclatureCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nomenclatureCol.Visible = true;
            this.nomenclatureCol.Width = 57;
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
            this.nomenclatureNameCol.Width = 170;
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
            this.quantityCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.quantityCol.Visible = true;
            this.quantityCol.Width = 43;
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
            this.measureCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.measureCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.measureCol.Visible = true;
            this.measureCol.Width = 45;
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
            this.gridBand6.Width = 188;
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
            this.currencyCodeCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.currencyCodeCol.Visible = true;
            this.currencyCodeCol.Width = 37;
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
            this.unitPriceCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.unitPriceCol.Visible = true;
            this.unitPriceCol.Width = 67;
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
            this.totalPriceCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.totalPriceCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "{0:### ### ##0.00}")});
            this.totalPriceCol.Visible = true;
            this.totalPriceCol.Width = 84;
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
            this.gridBand7.Width = 195;
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
            this.supplierNameCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.supplierNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.supplierNameCol.Visible = true;
            this.supplierNameCol.Width = 84;
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
            this.supplierProxyCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.supplierProxyCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.supplierProxyCol.Visible = true;
            this.supplierProxyCol.Width = 111;
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
            this.gridBand8.Width = 82;
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
            this.taxInvoiceCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.taxInvoiceCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.taxInvoiceCol.Visible = true;
            this.taxInvoiceCol.Width = 39;
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
            this.transportInvoiceCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.transportInvoiceCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.transportInvoiceCol.Visible = true;
            this.transportInvoiceCol.Width = 43;
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
            this.storehouseNameCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.storehouseNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
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
            this.gridBand9.Columns.Add(this.selectedCol);
            this.gridBand9.Name = "gridBand9";
            this.gridBand9.VisibleIndex = 6;
            this.gridBand9.Width = 199;
            // 
            // accountNumberCol
            // 
            this.accountNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountNumberCol.AppearanceHeader.Options.UseFont = true;
            this.accountNumberCol.Caption = "Номер заказу";
            this.accountNumberCol.FieldName = "OrderNumber";
            this.accountNumberCol.Name = "accountNumberCol";
            this.accountNumberCol.OptionsColumn.AllowEdit = false;
            this.accountNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.accountNumberCol.Visible = true;
            this.accountNumberCol.Width = 61;
            // 
            // projectNumberCol
            // 
            this.projectNumberCol.AppearanceCell.Options.UseTextOptions = true;
            this.projectNumberCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.projectNumberCol.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.projectNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectNumberCol.AppearanceHeader.Options.UseFont = true;
            this.projectNumberCol.Caption = "Номер проекту";
            this.projectNumberCol.ColumnEdit = this.repositoryItemMemoEdit1;
            this.projectNumberCol.FieldName = "Drawing";
            this.projectNumberCol.Name = "projectNumberCol";
            this.projectNumberCol.OptionsColumn.AllowEdit = false;
            this.projectNumberCol.OptionsColumn.AllowMove = false;
            this.projectNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.projectNumberCol.Visible = true;
            this.projectNumberCol.Width = 63;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // selectedCol
            // 
            this.selectedCol.ColumnEdit = this.selectedCheckEdit;
            this.selectedCol.FieldName = "Selected";
            this.selectedCol.Image = ((System.Drawing.Image)(resources.GetObject("selectedCol.Image")));
            this.selectedCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.selectedCol.Name = "selectedCol";
            this.selectedCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.selectedCol.Visible = true;
            // 
            // selectedCheckEdit
            // 
            this.selectedCheckEdit.AutoHeight = false;
            this.selectedCheckEdit.Caption = "";
            this.selectedCheckEdit.Name = "selectedCheckEdit";
            this.selectedCheckEdit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // DeliveryOrdersFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 674);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "DeliveryOrdersFm";
            this.ShowIcon = false;
            this.Text = "Надходження";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedCheckEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraBars.BarEditItem firstDateEdit;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarEditItem beginDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem endDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem searchBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem printBtn;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
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
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl deliveryOrdersGrid;
        private DevExpress.XtraBars.BarButtonItem addCustomerOrdersBtn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn accountNumberCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn projectNumberCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand9;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn selectedCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit selectedCheckEdit;
        private DevExpress.XtraBars.BarButtonItem editСustomerOrdersBtn;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarEditItem receiptNumberEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit;
        private DevExpress.XtraBars.BarButtonItem deleteOrdersFromReceiptBtn;
    }
}