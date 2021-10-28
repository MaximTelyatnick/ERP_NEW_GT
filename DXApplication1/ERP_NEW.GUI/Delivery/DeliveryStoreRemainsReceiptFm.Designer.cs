namespace ERP_NEW.GUI.Delivery
{
    partial class DeliveryStoreRemainsReceiptFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryStoreRemainsReceiptFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.dateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.searchBtn = new DevExpress.XtraBars.BarButtonItem();
            this.reportBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.storeRemainGrid = new DevExpress.XtraGrid.GridControl();
            this.storeRemainGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nomenclatureCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receiptnumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.measureCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.remainsQuantityCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.remainsSumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.debitNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeRemainGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeRemainGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.dateEdit,
            this.searchBtn,
            this.reportBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1191, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // dateEdit
            // 
            this.dateEdit.Caption = "Залишки на ";
            this.dateEdit.Edit = this.repositoryItemDateEdit1;
            this.dateEdit.EditWidth = 100;
            this.dateEdit.Id = 1;
            this.dateEdit.Name = "dateEdit";
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
            // searchBtn
            // 
            this.searchBtn.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.searchBtn.Caption = "Шукати";
            this.searchBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("searchBtn.Glyph")));
            this.searchBtn.Id = 2;
            this.searchBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("searchBtn.LargeGlyph")));
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.searchBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.searchBtn_ItemClick);
            // 
            // reportBtn
            // 
            this.reportBtn.Caption = "Звіт";
            this.reportBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("reportBtn.Glyph")));
            this.reportBtn.Id = 3;
            this.reportBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("reportBtn.LargeGlyph")));
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.reportBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowMinimize = false;
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.Glyph = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.Glyph")));
            this.ribbonPageGroup1.ItemLinks.Add(this.dateEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.searchBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.reportBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // storeRemainGrid
            // 
            this.storeRemainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeRemainGrid.Location = new System.Drawing.Point(0, 95);
            this.storeRemainGrid.MainView = this.storeRemainGridView;
            this.storeRemainGrid.Name = "storeRemainGrid";
            this.storeRemainGrid.Size = new System.Drawing.Size(1191, 328);
            this.storeRemainGrid.TabIndex = 1;
            this.storeRemainGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.storeRemainGridView});
            // 
            // storeRemainGridView
            // 
            this.storeRemainGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nomenclatureCol,
            this.nameCol,
            this.receiptnumCol,
            this.orderDateCol,
            this.measureCol,
            this.remainsQuantityCol,
            this.unitPriceCol,
            this.remainsSumCol,
            this.totalPriceCol,
            this.debitNumCol,
            this.gridColumn1});
            this.storeRemainGridView.GridControl = this.storeRemainGrid;
            this.storeRemainGridView.GroupCount = 1;
            this.storeRemainGridView.Name = "storeRemainGridView";
            this.storeRemainGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.storeRemainGridView.OptionsView.ShowAutoFilterRow = true;
            this.storeRemainGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // nomenclatureCol
            // 
            this.nomenclatureCol.Caption = "Номенклатурний номер";
            this.nomenclatureCol.FieldName = "Nomenclature";
            this.nomenclatureCol.Name = "nomenclatureCol";
            this.nomenclatureCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureCol.Visible = true;
            this.nomenclatureCol.VisibleIndex = 0;
            // 
            // nameCol
            // 
            this.nameCol.Caption = "Найменування";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.AllowEdit = false;
            this.nameCol.OptionsColumn.AllowFocus = false;
            this.nameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 1;
            // 
            // receiptnumCol
            // 
            this.receiptnumCol.Caption = "Номер приходу";
            this.receiptnumCol.FieldName = "ReceiptNum";
            this.receiptnumCol.Name = "receiptnumCol";
            this.receiptnumCol.OptionsColumn.AllowEdit = false;
            this.receiptnumCol.OptionsColumn.AllowFocus = false;
            this.receiptnumCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.receiptnumCol.Visible = true;
            this.receiptnumCol.VisibleIndex = 2;
            // 
            // orderDateCol
            // 
            this.orderDateCol.Caption = "Дата";
            this.orderDateCol.FieldName = "OrderDate";
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.OptionsColumn.AllowEdit = false;
            this.orderDateCol.OptionsColumn.AllowFocus = false;
            this.orderDateCol.Visible = true;
            this.orderDateCol.VisibleIndex = 3;
            // 
            // measureCol
            // 
            this.measureCol.Caption = "Од.Вим.";
            this.measureCol.FieldName = "Measure";
            this.measureCol.Name = "measureCol";
            this.measureCol.OptionsColumn.AllowEdit = false;
            this.measureCol.OptionsColumn.AllowFocus = false;
            this.measureCol.Visible = true;
            this.measureCol.VisibleIndex = 4;
            // 
            // remainsQuantityCol
            // 
            this.remainsQuantityCol.Caption = "Залишок, кількість";
            this.remainsQuantityCol.FieldName = "Quantity";
            this.remainsQuantityCol.Name = "remainsQuantityCol";
            this.remainsQuantityCol.OptionsColumn.AllowEdit = false;
            this.remainsQuantityCol.OptionsColumn.AllowFocus = false;
            this.remainsQuantityCol.Visible = true;
            this.remainsQuantityCol.VisibleIndex = 5;
            // 
            // unitPriceCol
            // 
            this.unitPriceCol.Caption = "Ціна за од.";
            this.unitPriceCol.FieldName = "UnitPrice";
            this.unitPriceCol.Name = "unitPriceCol";
            this.unitPriceCol.OptionsColumn.AllowEdit = false;
            this.unitPriceCol.OptionsColumn.AllowFocus = false;
            this.unitPriceCol.Visible = true;
            this.unitPriceCol.VisibleIndex = 6;
            // 
            // remainsSumCol
            // 
            this.remainsSumCol.Caption = "Сума залишку";
            this.remainsSumCol.FieldName = "RemainsSum";
            this.remainsSumCol.Name = "remainsSumCol";
            this.remainsSumCol.OptionsColumn.AllowEdit = false;
            this.remainsSumCol.OptionsColumn.AllowFocus = false;
            this.remainsSumCol.Visible = true;
            this.remainsSumCol.VisibleIndex = 7;
            // 
            // totalPriceCol
            // 
            this.totalPriceCol.Caption = "Сума приходу";
            this.totalPriceCol.FieldName = "TotalPrice";
            this.totalPriceCol.Name = "totalPriceCol";
            this.totalPriceCol.OptionsColumn.AllowEdit = false;
            this.totalPriceCol.OptionsColumn.AllowFocus = false;
            this.totalPriceCol.Visible = true;
            this.totalPriceCol.VisibleIndex = 8;
            // 
            // debitNumCol
            // 
            this.debitNumCol.Caption = "Дебет";
            this.debitNumCol.FieldName = "DebitNum";
            this.debitNumCol.Name = "debitNumCol";
            this.debitNumCol.OptionsColumn.AllowEdit = false;
            this.debitNumCol.OptionsColumn.AllowFocus = false;
            this.debitNumCol.Visible = true;
            this.debitNumCol.VisibleIndex = 9;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "...";
            this.gridColumn1.FieldName = "N1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // DeliveryStoreRemainsReceiptFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 423);
            this.Controls.Add(this.storeRemainGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "DeliveryStoreRemainsReceiptFm";
            this.Text = "Залишки по надходженням";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeRemainGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeRemainGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarEditItem dateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarButtonItem searchBtn;
        private DevExpress.XtraBars.BarButtonItem reportBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl storeRemainGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView storeRemainGridView;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclatureCol;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn receiptnumCol;
        private DevExpress.XtraGrid.Columns.GridColumn orderDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn measureCol;
        private DevExpress.XtraGrid.Columns.GridColumn remainsQuantityCol;
        private DevExpress.XtraGrid.Columns.GridColumn unitPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn remainsSumCol;
        private DevExpress.XtraGrid.Columns.GridColumn totalPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn debitNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}