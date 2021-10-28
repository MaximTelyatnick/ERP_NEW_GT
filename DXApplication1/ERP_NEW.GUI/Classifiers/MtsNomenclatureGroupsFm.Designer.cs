namespace ERP_NEW.GUI.Classifiers
{
    partial class MtsNomenclatureGroupsFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MtsNomenclatureGroupsFm));
            this.mtsNomenclatureGroupsGrid = new DevExpress.XtraGrid.GridControl();
            this.mtsNomenclatureGroupsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ratioOfWasteCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.additUnitLocalNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addGroupBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editGroupBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteGroupBtn = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.mtsNomenclatureGroupsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtsNomenclatureGroupsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtsNomenclatureGroupsGrid
            // 
            this.mtsNomenclatureGroupsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtsNomenclatureGroupsGrid.Location = new System.Drawing.Point(0, 95);
            this.mtsNomenclatureGroupsGrid.MainView = this.mtsNomenclatureGroupsGridView;
            this.mtsNomenclatureGroupsGrid.Name = "mtsNomenclatureGroupsGrid";
            this.mtsNomenclatureGroupsGrid.Size = new System.Drawing.Size(919, 565);
            this.mtsNomenclatureGroupsGrid.TabIndex = 4;
            this.mtsNomenclatureGroupsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mtsNomenclatureGroupsGridView});
            // 
            // mtsNomenclatureGroupsGridView
            // 
            this.mtsNomenclatureGroupsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameCol,
            this.ratioOfWasteCol,
            this.additUnitLocalNameCol});
            this.mtsNomenclatureGroupsGridView.GridControl = this.mtsNomenclatureGroupsGrid;
            this.mtsNomenclatureGroupsGridView.Name = "mtsNomenclatureGroupsGridView";
            this.mtsNomenclatureGroupsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.mtsNomenclatureGroupsGridView.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.mtsNomenclatureGroupsGridView.OptionsView.ShowAutoFilterRow = true;
            this.mtsNomenclatureGroupsGridView.OptionsView.ShowGroupPanel = false;
            this.mtsNomenclatureGroupsGridView.DoubleClick += new System.EventHandler(this.mtsNomenclatureGroupsGridView_DoubleClick);
            // 
            // nameCol
            // 
            this.nameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameCol.Caption = "Групи";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.AllowEdit = false;
            this.nameCol.OptionsColumn.AllowFocus = false;
            this.nameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 0;
            this.nameCol.Width = 693;
            // 
            // ratioOfWasteCol
            // 
            this.ratioOfWasteCol.AppearanceHeader.Options.UseTextOptions = true;
            this.ratioOfWasteCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ratioOfWasteCol.Caption = "Коеф. відходів";
            this.ratioOfWasteCol.FieldName = "RatioOfWaste";
            this.ratioOfWasteCol.Name = "ratioOfWasteCol";
            this.ratioOfWasteCol.OptionsColumn.AllowEdit = false;
            this.ratioOfWasteCol.OptionsColumn.AllowFocus = false;
            this.ratioOfWasteCol.Visible = true;
            this.ratioOfWasteCol.VisibleIndex = 1;
            this.ratioOfWasteCol.Width = 123;
            // 
            // additUnitLocalNameCol
            // 
            this.additUnitLocalNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.additUnitLocalNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.additUnitLocalNameCol.Caption = "Додаткова од. вимірювання";
            this.additUnitLocalNameCol.FieldName = "AdditUnitLocalName";
            this.additUnitLocalNameCol.Name = "additUnitLocalNameCol";
            this.additUnitLocalNameCol.OptionsColumn.AllowEdit = false;
            this.additUnitLocalNameCol.OptionsColumn.AllowFocus = false;
            this.additUnitLocalNameCol.Visible = true;
            this.additUnitLocalNameCol.VisibleIndex = 2;
            this.additUnitLocalNameCol.Width = 85;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addGroupBtn,
            this.editGroupBtn,
            this.deleteGroupBtn,
            this.refreshBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(919, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.Caption = "Додати";
            this.addGroupBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addGroupBtn.Glyph")));
            this.addGroupBtn.Id = 1;
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addGroupBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addGroupBtn_ItemClick);
            // 
            // editGroupBtn
            // 
            this.editGroupBtn.Caption = "Редагувати";
            this.editGroupBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editGroupBtn.Glyph")));
            this.editGroupBtn.Id = 2;
            this.editGroupBtn.Name = "editGroupBtn";
            this.editGroupBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.editGroupBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editGroupBtn_ItemClick);
            // 
            // deleteGroupBtn
            // 
            this.deleteGroupBtn.Caption = "Видалити";
            this.deleteGroupBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteGroupBtn.Glyph")));
            this.deleteGroupBtn.Id = 3;
            this.deleteGroupBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteGroupBtn.LargeGlyph")));
            this.deleteGroupBtn.Name = "deleteGroupBtn";
            this.deleteGroupBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deleteGroupBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteGroupBtn_ItemClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Caption = "Поновити";
            this.refreshBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Glyph")));
            this.refreshBtn.Id = 4;
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.refreshBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBtn_ItemClick);
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
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.addGroupBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.editGroupBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteGroupBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Група";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.refreshBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Функції";
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // MtsNomenclatureGroupsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 660);
            this.Controls.Add(this.mtsNomenclatureGroupsGrid);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MtsNomenclatureGroupsFm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Довідник груп матеріалів";
            ((System.ComponentModel.ISupportInitialize)(this.mtsNomenclatureGroupsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtsNomenclatureGroupsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl mtsNomenclatureGroupsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView mtsNomenclatureGroupsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn ratioOfWasteCol;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem addGroupBtn;
        private DevExpress.XtraBars.BarButtonItem editGroupBtn;
        private DevExpress.XtraBars.BarButtonItem deleteGroupBtn;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn additUnitLocalNameCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}