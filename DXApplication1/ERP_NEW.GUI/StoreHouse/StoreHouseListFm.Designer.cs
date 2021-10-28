namespace ERP_NEW.GUI.StoreHouse
{
    partial class StoreHouseListFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreHouseListFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.showBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addStoreHouseBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editStoreHouseBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteStoreHouseBtn = new DevExpress.XtraBars.BarButtonItem();
            this.updateStoreHouseBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.storeHouseListGrid = new DevExpress.XtraGrid.GridControl();
            this.storeHouseListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.numCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.noteCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeHouseListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeHouseListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.showBtn,
            this.addStoreHouseBtn,
            this.editStoreHouseBtn,
            this.deleteStoreHouseBtn,
            this.updateStoreHouseBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(880, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // showBtn
            // 
            this.showBtn.Caption = "Показати";
            this.showBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("showBtn.Glyph")));
            this.showBtn.Id = 1;
            this.showBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showBtn.LargeGlyph")));
            this.showBtn.Name = "showBtn";
            // 
            // addStoreHouseBtn
            // 
            this.addStoreHouseBtn.Caption = "Додати";
            this.addStoreHouseBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addStoreHouseBtn.Glyph")));
            this.addStoreHouseBtn.Id = 2;
            this.addStoreHouseBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addStoreHouseBtn.LargeGlyph")));
            this.addStoreHouseBtn.Name = "addStoreHouseBtn";
            this.addStoreHouseBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addStoreHouseBtn_ItemClick);
            // 
            // editStoreHouseBtn
            // 
            this.editStoreHouseBtn.Caption = "Редагувати";
            this.editStoreHouseBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editStoreHouseBtn.Glyph")));
            this.editStoreHouseBtn.Id = 3;
            this.editStoreHouseBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editStoreHouseBtn.LargeGlyph")));
            this.editStoreHouseBtn.Name = "editStoreHouseBtn";
            this.editStoreHouseBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editStoreHouseBtn_ItemClick);
            // 
            // deleteStoreHouseBtn
            // 
            this.deleteStoreHouseBtn.Caption = "Видалити";
            this.deleteStoreHouseBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteStoreHouseBtn.Glyph")));
            this.deleteStoreHouseBtn.Id = 4;
            this.deleteStoreHouseBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteStoreHouseBtn.LargeGlyph")));
            this.deleteStoreHouseBtn.Name = "deleteStoreHouseBtn";
            this.deleteStoreHouseBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteStoreHouseBtn_ItemClick);
            // 
            // updateStoreHouseBtn
            // 
            this.updateStoreHouseBtn.Caption = "Оновити";
            this.updateStoreHouseBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("updateStoreHouseBtn.Glyph")));
            this.updateStoreHouseBtn.Id = 5;
            this.updateStoreHouseBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("updateStoreHouseBtn.LargeGlyph")));
            this.updateStoreHouseBtn.Name = "updateStoreHouseBtn";
            this.updateStoreHouseBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.updateStoreHouseBtn_ItemClick);
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
            this.ribbonPageGroup2.ItemLinks.Add(this.addStoreHouseBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.editStoreHouseBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.deleteStoreHouseBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Склади";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.showBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Формування даних";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.updateStoreHouseBtn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Функції";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.storeHouseListGrid);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 95);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(880, 317);
            this.groupControl1.TabIndex = 1;
            // 
            // storeHouseListGrid
            // 
            this.storeHouseListGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeHouseListGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.storeHouseListGrid.Location = new System.Drawing.Point(2, 20);
            this.storeHouseListGrid.MainView = this.storeHouseListGridView;
            this.storeHouseListGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.storeHouseListGrid.MenuManager = this.ribbonControl1;
            this.storeHouseListGrid.Name = "storeHouseListGrid";
            this.storeHouseListGrid.Size = new System.Drawing.Size(876, 295);
            this.storeHouseListGrid.TabIndex = 0;
            this.storeHouseListGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.storeHouseListGridView});
            // 
            // storeHouseListGridView
            // 
            this.storeHouseListGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.numCol,
            this.nameCol,
            this.noteCol});
            this.storeHouseListGridView.GridControl = this.storeHouseListGrid;
            this.storeHouseListGridView.Name = "storeHouseListGridView";
            this.storeHouseListGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.storeHouseListGridView.OptionsView.ShowAutoFilterRow = true;
            this.storeHouseListGridView.OptionsView.ShowFooter = true;
            this.storeHouseListGridView.OptionsView.ShowGroupPanel = false;
            this.storeHouseListGridView.DoubleClick += new System.EventHandler(this.storeHouseListGridView_DoubleClick);
            // 
            // numCol
            // 
            this.numCol.Caption = "Номер";
            this.numCol.FieldName = "Num";
            this.numCol.Name = "numCol";
            this.numCol.OptionsColumn.AllowEdit = false;
            this.numCol.OptionsColumn.AllowFocus = false;
            this.numCol.Visible = true;
            this.numCol.VisibleIndex = 0;
            // 
            // nameCol
            // 
            this.nameCol.Caption = "Найменування";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.AllowEdit = false;
            this.nameCol.OptionsColumn.AllowFocus = false;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 1;
            // 
            // noteCol
            // 
            this.noteCol.Caption = "Додаткова інформація";
            this.noteCol.FieldName = "Note";
            this.noteCol.Name = "noteCol";
            this.noteCol.OptionsColumn.AllowEdit = false;
            this.noteCol.OptionsColumn.AllowFocus = false;
            this.noteCol.Visible = true;
            this.noteCol.VisibleIndex = 2;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // StoreHouseListFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 412);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StoreHouseListFm";
            this.ShowIcon = false;
            this.Text = "Довідник - \"Склади\"";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storeHouseListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeHouseListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem showBtn;
        private DevExpress.XtraBars.BarButtonItem addStoreHouseBtn;
        private DevExpress.XtraBars.BarButtonItem editStoreHouseBtn;
        private DevExpress.XtraBars.BarButtonItem deleteStoreHouseBtn;
        private DevExpress.XtraBars.BarButtonItem updateStoreHouseBtn;
        private DevExpress.XtraGrid.GridControl storeHouseListGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView storeHouseListGridView;
        private DevExpress.XtraGrid.Columns.GridColumn numCol;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn noteCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}