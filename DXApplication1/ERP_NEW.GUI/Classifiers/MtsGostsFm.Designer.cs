namespace ERP_NEW.GUI.Classifiers
{
    partial class MtsGostsFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MtsGostsFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addGostBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editGostBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteGostBtn = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mtsGostsGrid = new DevExpress.XtraGrid.GridControl();
            this.mtsGostsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtsGostsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtsGostsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addGostBtn,
            this.editGostBtn,
            this.deleteGostBtn,
            this.refreshBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(651, 119);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // addGostBtn
            // 
            this.addGostBtn.Caption = "Додати";
            this.addGostBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addGostBtn.Glyph")));
            this.addGostBtn.Id = 1;
            this.addGostBtn.Name = "addGostBtn";
            this.addGostBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addGostBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addGostBtn_ItemClick);
            // 
            // editGostBtn
            // 
            this.editGostBtn.Caption = "Редагувати";
            this.editGostBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editGostBtn.Glyph")));
            this.editGostBtn.Id = 2;
            this.editGostBtn.Name = "editGostBtn";
            this.editGostBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.editGostBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editGostBtn_ItemClick);
            // 
            // deleteGostBtn
            // 
            this.deleteGostBtn.Caption = "Видалити";
            this.deleteGostBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteGostBtn.Glyph")));
            this.deleteGostBtn.Id = 3;
            this.deleteGostBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteGostBtn.LargeGlyph")));
            this.deleteGostBtn.Name = "deleteGostBtn";
            this.deleteGostBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deleteGostBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteGostBtn_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.addGostBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.editGostBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteGostBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "ГОСТ, ТУ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.refreshBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Функції";
            // 
            // mtsGostsGrid
            // 
            this.mtsGostsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtsGostsGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtsGostsGrid.Location = new System.Drawing.Point(0, 119);
            this.mtsGostsGrid.MainView = this.mtsGostsGridView;
            this.mtsGostsGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtsGostsGrid.Name = "mtsGostsGrid";
            this.mtsGostsGrid.Size = new System.Drawing.Size(651, 670);
            this.mtsGostsGrid.TabIndex = 2;
            this.mtsGostsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mtsGostsGridView});
            this.mtsGostsGrid.DoubleClick += new System.EventHandler(this.mtsGostsGrid_DoubleClick);
            // 
            // mtsGostsGridView
            // 
            this.mtsGostsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameCol});
            this.mtsGostsGridView.GridControl = this.mtsGostsGrid;
            this.mtsGostsGridView.Name = "mtsGostsGridView";
            this.mtsGostsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.mtsGostsGridView.OptionsView.ShowAutoFilterRow = true;
            this.mtsGostsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // nameCol
            // 
            this.nameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameCol.Caption = "ГОСТ, ТУ";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.AllowEdit = false;
            this.nameCol.OptionsColumn.AllowFocus = false;
            this.nameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 0;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // MtsGostsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 789);
            this.Controls.Add(this.mtsGostsGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MtsGostsFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Довідник ГОСТ, ТУ";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtsGostsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtsGostsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl mtsGostsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView mtsGostsGridView;
        private DevExpress.XtraBars.BarButtonItem addGostBtn;
        private DevExpress.XtraBars.BarButtonItem editGostBtn;
        private DevExpress.XtraBars.BarButtonItem deleteGostBtn;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}