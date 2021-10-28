namespace ERP_NEW.GUI.Classifiers
{
    partial class MtsNomenclaturesFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MtsNomenclaturesFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addMaterialBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editMaterialBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteMaterialBtn = new DevExpress.XtraBars.BarButtonItem();
            this.nomenclatureGroupsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mtsNomenclaturesGrid = new DevExpress.XtraGrid.GridControl();
            this.mtsNomenclaturesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gostNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitLocalNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gaugeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.weightCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.priceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.noteCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.additUnitLocalNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ratioOfWasteCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtsNomenclaturesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtsNomenclaturesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.refreshBtn,
            this.addMaterialBtn,
            this.editMaterialBtn,
            this.deleteMaterialBtn,
            this.nomenclatureGroupsBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1559, 118);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Caption = "Поновити";
            this.refreshBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Glyph")));
            this.refreshBtn.Id = 1;
            this.refreshBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("refreshBtn.LargeGlyph")));
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.refreshBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBtn_ItemClick);
            // 
            // addMaterialBtn
            // 
            this.addMaterialBtn.Caption = "Додати";
            this.addMaterialBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addMaterialBtn.Glyph")));
            this.addMaterialBtn.Id = 2;
            this.addMaterialBtn.Name = "addMaterialBtn";
            this.addMaterialBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addMaterialBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addMaterialBtn_ItemClick);
            // 
            // editMaterialBtn
            // 
            this.editMaterialBtn.Caption = "Редагувати";
            this.editMaterialBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editMaterialBtn.Glyph")));
            this.editMaterialBtn.Id = 3;
            this.editMaterialBtn.Name = "editMaterialBtn";
            this.editMaterialBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.editMaterialBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editMaterialBtn_ItemClick);
            // 
            // deleteMaterialBtn
            // 
            this.deleteMaterialBtn.Caption = "Видалити";
            this.deleteMaterialBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteMaterialBtn.Glyph")));
            this.deleteMaterialBtn.Id = 4;
            this.deleteMaterialBtn.Name = "deleteMaterialBtn";
            this.deleteMaterialBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deleteMaterialBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteMaterialBtn_ItemClick);
            // 
            // nomenclatureGroupsBtn
            // 
            this.nomenclatureGroupsBtn.Caption = "Довідник груп матеріалів";
            this.nomenclatureGroupsBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("nomenclatureGroupsBtn.Glyph")));
            this.nomenclatureGroupsBtn.Id = 5;
            this.nomenclatureGroupsBtn.Name = "nomenclatureGroupsBtn";
            this.nomenclatureGroupsBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.nomenclatureGroupsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.nomenclatureGroupsBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.addMaterialBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.editMaterialBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.deleteMaterialBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Матеріали";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.refreshBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Функції";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.nomenclatureGroupsBtn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Групи матеріалів";
            // 
            // mtsNomenclaturesGrid
            // 
            this.mtsNomenclaturesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtsNomenclaturesGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtsNomenclaturesGrid.Location = new System.Drawing.Point(0, 118);
            this.mtsNomenclaturesGrid.MainView = this.mtsNomenclaturesGridView;
            this.mtsNomenclaturesGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtsNomenclaturesGrid.Name = "mtsNomenclaturesGrid";
            this.mtsNomenclaturesGrid.Size = new System.Drawing.Size(1559, 686);
            this.mtsNomenclaturesGrid.TabIndex = 1;
            this.mtsNomenclaturesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mtsNomenclaturesGridView});
            // 
            // mtsNomenclaturesGridView
            // 
            this.mtsNomenclaturesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameCol,
            this.gostNameCol,
            this.unitLocalNameCol,
            this.gaugeCol,
            this.weightCol,
            this.priceCol,
            this.groupNameCol,
            this.noteCol,
            this.additUnitLocalNameCol,
            this.ratioOfWasteCol});
            this.mtsNomenclaturesGridView.GridControl = this.mtsNomenclaturesGrid;
            this.mtsNomenclaturesGridView.GroupCount = 1;
            this.mtsNomenclaturesGridView.Name = "mtsNomenclaturesGridView";
            this.mtsNomenclaturesGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.mtsNomenclaturesGridView.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.mtsNomenclaturesGridView.OptionsView.ShowAutoFilterRow = true;
            this.mtsNomenclaturesGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.groupNameCol, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.mtsNomenclaturesGridView.DoubleClick += new System.EventHandler(this.mtsNomenclaturesGridView_DoubleClick);
            // 
            // nameCol
            // 
            this.nameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameCol.Caption = "Наіменування";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.AllowEdit = false;
            this.nameCol.OptionsColumn.AllowFocus = false;
            this.nameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 0;
            this.nameCol.Width = 510;
            // 
            // gostNameCol
            // 
            this.gostNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.gostNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gostNameCol.Caption = "ГОСТ";
            this.gostNameCol.FieldName = "GostName";
            this.gostNameCol.Name = "gostNameCol";
            this.gostNameCol.OptionsColumn.AllowEdit = false;
            this.gostNameCol.OptionsColumn.AllowFocus = false;
            this.gostNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gostNameCol.Visible = true;
            this.gostNameCol.VisibleIndex = 2;
            this.gostNameCol.Width = 243;
            // 
            // unitLocalNameCol
            // 
            this.unitLocalNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.unitLocalNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unitLocalNameCol.Caption = "Од.Вим.";
            this.unitLocalNameCol.FieldName = "UnitLocalName";
            this.unitLocalNameCol.Name = "unitLocalNameCol";
            this.unitLocalNameCol.OptionsColumn.AllowEdit = false;
            this.unitLocalNameCol.OptionsColumn.AllowFocus = false;
            this.unitLocalNameCol.Visible = true;
            this.unitLocalNameCol.VisibleIndex = 6;
            this.unitLocalNameCol.Width = 56;
            // 
            // gaugeCol
            // 
            this.gaugeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.gaugeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gaugeCol.Caption = "Сортамент";
            this.gaugeCol.FieldName = "Gauge";
            this.gaugeCol.Name = "gaugeCol";
            this.gaugeCol.OptionsColumn.AllowEdit = false;
            this.gaugeCol.OptionsColumn.AllowFocus = false;
            this.gaugeCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gaugeCol.Visible = true;
            this.gaugeCol.VisibleIndex = 1;
            this.gaugeCol.Width = 136;
            // 
            // weightCol
            // 
            this.weightCol.AppearanceHeader.Options.UseTextOptions = true;
            this.weightCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.weightCol.Caption = "Вага";
            this.weightCol.FieldName = "Weight";
            this.weightCol.Name = "weightCol";
            this.weightCol.OptionsColumn.AllowEdit = false;
            this.weightCol.OptionsColumn.AllowFocus = false;
            this.weightCol.Visible = true;
            this.weightCol.VisibleIndex = 4;
            this.weightCol.Width = 87;
            // 
            // priceCol
            // 
            this.priceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.priceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.priceCol.Caption = "Ціна";
            this.priceCol.FieldName = "Price";
            this.priceCol.Name = "priceCol";
            this.priceCol.OptionsColumn.AllowEdit = false;
            this.priceCol.OptionsColumn.AllowFocus = false;
            this.priceCol.Visible = true;
            this.priceCol.VisibleIndex = 5;
            this.priceCol.Width = 80;
            // 
            // groupNameCol
            // 
            this.groupNameCol.Caption = "Група";
            this.groupNameCol.FieldName = "GroupName";
            this.groupNameCol.Name = "groupNameCol";
            this.groupNameCol.OptionsColumn.AllowEdit = false;
            this.groupNameCol.OptionsColumn.AllowFocus = false;
            this.groupNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.groupNameCol.Visible = true;
            this.groupNameCol.VisibleIndex = 0;
            // 
            // noteCol
            // 
            this.noteCol.AppearanceHeader.Options.UseTextOptions = true;
            this.noteCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.noteCol.Caption = "Додаткова інформація";
            this.noteCol.FieldName = "Note";
            this.noteCol.Name = "noteCol";
            this.noteCol.OptionsColumn.AllowEdit = false;
            this.noteCol.OptionsColumn.AllowFocus = false;
            this.noteCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.noteCol.Visible = true;
            this.noteCol.VisibleIndex = 3;
            this.noteCol.Width = 206;
            // 
            // additUnitLocalNameCol
            // 
            this.additUnitLocalNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.additUnitLocalNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.additUnitLocalNameCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.additUnitLocalNameCol.Caption = "Додаткова од.вим.";
            this.additUnitLocalNameCol.FieldName = "AdditUnitLocalName";
            this.additUnitLocalNameCol.Name = "additUnitLocalNameCol";
            this.additUnitLocalNameCol.OptionsColumn.AllowEdit = false;
            this.additUnitLocalNameCol.OptionsColumn.AllowFocus = false;
            this.additUnitLocalNameCol.Visible = true;
            this.additUnitLocalNameCol.VisibleIndex = 7;
            // 
            // ratioOfWasteCol
            // 
            this.ratioOfWasteCol.AppearanceHeader.Options.UseTextOptions = true;
            this.ratioOfWasteCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ratioOfWasteCol.Caption = "Коэф. відходів";
            this.ratioOfWasteCol.FieldName = "RatioOfWaste";
            this.ratioOfWasteCol.Name = "ratioOfWasteCol";
            this.ratioOfWasteCol.OptionsColumn.AllowEdit = false;
            this.ratioOfWasteCol.OptionsColumn.AllowFocus = false;
            this.ratioOfWasteCol.Visible = true;
            this.ratioOfWasteCol.VisibleIndex = 8;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // MtsNomenclaturesFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 804);
            this.Controls.Add(this.mtsNomenclaturesGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MtsNomenclaturesFm";
            this.ShowIcon = false;
            this.Text = "Довідник матеріалів";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtsNomenclaturesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtsNomenclaturesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraGrid.GridControl mtsNomenclaturesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView mtsNomenclaturesGridView;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
        private DevExpress.XtraBars.BarButtonItem addMaterialBtn;
        private DevExpress.XtraBars.BarButtonItem editMaterialBtn;
        private DevExpress.XtraBars.BarButtonItem deleteMaterialBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn gostNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn unitLocalNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn gaugeCol;
        private DevExpress.XtraGrid.Columns.GridColumn weightCol;
        private DevExpress.XtraGrid.Columns.GridColumn priceCol;
        private DevExpress.XtraGrid.Columns.GridColumn groupNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn noteCol;
        private DevExpress.XtraGrid.Columns.GridColumn additUnitLocalNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn ratioOfWasteCol;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem nomenclatureGroupsBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}