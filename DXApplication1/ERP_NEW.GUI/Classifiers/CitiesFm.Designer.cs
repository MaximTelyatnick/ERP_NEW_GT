namespace ERP_NEW.GUI.Classifiers
{
    partial class CitiesFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitiesFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addCityBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editCityBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteCityBtn = new DevExpress.XtraBars.BarButtonItem();
            this.updateCityBtn = new DevExpress.XtraBars.BarButtonItem();
            this.renameCityBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.citiesGrid = new DevExpress.XtraGrid.GridControl();
            this.citiesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.infoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.infoCityRepository = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.cityNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.сountryNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.settlementType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolTipController = new DevExpress.Utils.ToolTipController();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.imageCollection = new DevExpress.Utils.ImageCollection();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoCityRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addCityBtn,
            this.editCityBtn,
            this.deleteCityBtn,
            this.updateCityBtn,
            this.renameCityBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(849, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // addCityBtn
            // 
            this.addCityBtn.Caption = "Додати";
            this.addCityBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addCityBtn.Glyph")));
            this.addCityBtn.Id = 1;
            this.addCityBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addCityBtn.LargeGlyph")));
            this.addCityBtn.Name = "addCityBtn";
            this.addCityBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addCityBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addCityBtn_ItemClick);
            // 
            // editCityBtn
            // 
            this.editCityBtn.Caption = "Редагувати";
            this.editCityBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editCityBtn.Glyph")));
            this.editCityBtn.Id = 2;
            this.editCityBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editCityBtn.LargeGlyph")));
            this.editCityBtn.Name = "editCityBtn";
            this.editCityBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.editCityBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editCityBtn_ItemClick);
            // 
            // deleteCityBtn
            // 
            this.deleteCityBtn.Caption = "Видалити";
            this.deleteCityBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteCityBtn.Glyph")));
            this.deleteCityBtn.Id = 3;
            this.deleteCityBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteCityBtn.LargeGlyph")));
            this.deleteCityBtn.Name = "deleteCityBtn";
            this.deleteCityBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deleteCityBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteCityBtn_ItemClick);
            // 
            // updateCityBtn
            // 
            this.updateCityBtn.Caption = "Оновити";
            this.updateCityBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("updateCityBtn.Glyph")));
            this.updateCityBtn.Id = 4;
            this.updateCityBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("updateCityBtn.LargeGlyph")));
            this.updateCityBtn.Name = "updateCityBtn";
            this.updateCityBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.updateCityBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.updateCityBtn_ItemClick);
            // 
            // renameCityBtn
            // 
            this.renameCityBtn.Caption = "Декомунізувати";
            this.renameCityBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("renameCityBtn.Glyph")));
            this.renameCityBtn.Id = 5;
            this.renameCityBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("renameCityBtn.LargeGlyph")));
            this.renameCityBtn.Name = "renameCityBtn";
            this.renameCityBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.renameCityBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.renameCityBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.addCityBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.editCityBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteCityBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Місто";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.updateCityBtn);
            this.ribbonPageGroup4.ItemLinks.Add(this.renameCityBtn);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Функції";
            // 
            // citiesGrid
            // 
            this.citiesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.citiesGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.citiesGrid.Location = new System.Drawing.Point(0, 95);
            this.citiesGrid.MainView = this.citiesGridView;
            this.citiesGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.citiesGrid.Name = "citiesGrid";
            this.citiesGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.infoCityRepository});
            this.citiesGrid.Size = new System.Drawing.Size(849, 334);
            this.citiesGrid.TabIndex = 2;
            this.citiesGrid.ToolTipController = this.toolTipController;
            this.citiesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.citiesGridView});
            this.citiesGrid.DoubleClick += new System.EventHandler(this.citiesGrid_DoubleClick);
            // 
            // citiesGridView
            // 
            this.citiesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.infoCol,
            this.cityNameCol,
            this.сountryNameCol,
            this.settlementType});
            this.citiesGridView.GridControl = this.citiesGrid;
            this.citiesGridView.Name = "citiesGridView";
            this.citiesGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.citiesGridView.OptionsView.ShowAutoFilterRow = true;
            this.citiesGridView.OptionsView.ShowGroupPanel = false;
            this.citiesGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.citiesGridView_CustomUnboundColumnData);
            // 
            // infoCol
            // 
            this.infoCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.infoCol.AppearanceHeader.Options.UseFont = true;
            this.infoCol.AppearanceHeader.Options.UseTextOptions = true;
            this.infoCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.infoCol.ColumnEdit = this.infoCityRepository;
            this.infoCol.FieldName = "infoCol";
            this.infoCol.Image = ((System.Drawing.Image)(resources.GetObject("infoCol.Image")));
            this.infoCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.infoCol.Name = "infoCol";
            this.infoCol.OptionsColumn.AllowEdit = false;
            this.infoCol.OptionsColumn.AllowFocus = false;
            this.infoCol.OptionsFilter.AllowAutoFilter = false;
            this.infoCol.OptionsFilter.AllowFilter = false;
            this.infoCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.infoCol.Visible = true;
            this.infoCol.VisibleIndex = 0;
            this.infoCol.Width = 43;
            // 
            // infoCityRepository
            // 
            this.infoCityRepository.Name = "infoCityRepository";
            this.infoCityRepository.NullText = " ";
            this.infoCityRepository.ZoomAccelerationFactor = 1D;
            // 
            // cityNameCol
            // 
            this.cityNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cityNameCol.AppearanceHeader.Options.UseFont = true;
            this.cityNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.cityNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cityNameCol.Caption = "Місто";
            this.cityNameCol.FieldName = "CityName_UA";
            this.cityNameCol.Name = "cityNameCol";
            this.cityNameCol.OptionsColumn.AllowEdit = false;
            this.cityNameCol.OptionsColumn.AllowFocus = false;
            this.cityNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.cityNameCol.Visible = true;
            this.cityNameCol.VisibleIndex = 1;
            this.cityNameCol.Width = 259;
            // 
            // сountryNameCol
            // 
            this.сountryNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.сountryNameCol.AppearanceHeader.Options.UseFont = true;
            this.сountryNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.сountryNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.сountryNameCol.Caption = "Країна";
            this.сountryNameCol.FieldName = "CountryName_UA";
            this.сountryNameCol.Name = "сountryNameCol";
            this.сountryNameCol.OptionsColumn.AllowEdit = false;
            this.сountryNameCol.OptionsColumn.AllowFocus = false;
            this.сountryNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.сountryNameCol.Visible = true;
            this.сountryNameCol.VisibleIndex = 2;
            this.сountryNameCol.Width = 320;
            // 
            // settlementType
            // 
            this.settlementType.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.settlementType.AppearanceHeader.Options.UseFont = true;
            this.settlementType.AppearanceHeader.Options.UseTextOptions = true;
            this.settlementType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.settlementType.Caption = "Тип населеного пункту";
            this.settlementType.FieldName = "FullName";
            this.settlementType.Name = "settlementType";
            this.settlementType.OptionsColumn.AllowEdit = false;
            this.settlementType.OptionsColumn.AllowFocus = false;
            this.settlementType.Visible = true;
            this.settlementType.VisibleIndex = 3;
            this.settlementType.Width = 209;
            // 
            // toolTipController
            // 
            this.toolTipController.AllowHtmlText = true;
            this.toolTipController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            this.toolTipController.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.toolTipController_GetActiveObjectInfo);
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("about_16x16.png", "devav/actions/about_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/about_16x16.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "about_16x16.png");
            // 
            // CitiesFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 429);
            this.Controls.Add(this.citiesGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CitiesFm";
            this.ShowIcon = false;
            this.Text = "Довідник міст";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoCityRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl citiesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView citiesGridView;
        private DevExpress.XtraBars.BarButtonItem addCityBtn;
        private DevExpress.XtraBars.BarButtonItem editCityBtn;
        private DevExpress.XtraBars.BarButtonItem deleteCityBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem updateCityBtn;
        private DevExpress.XtraGrid.Columns.GridColumn cityNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn сountryNameCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Columns.GridColumn settlementType;
        private DevExpress.XtraBars.BarButtonItem renameCityBtn;
        private DevExpress.XtraGrid.Columns.GridColumn infoCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit infoCityRepository;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.Utils.ToolTipController toolTipController;
    }
}