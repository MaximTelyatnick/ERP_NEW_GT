namespace ERP_NEW.GUI.Classifiers
{
    partial class UnitsFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitsFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addUnitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editUnitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteUnitBtn = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.unitsGrid = new DevExpress.XtraGrid.GridControl();
            this.unitsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.unitFullNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitLocalNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addUnitBtn,
            this.editUnitBtn,
            this.deleteUnitBtn,
            this.refreshBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(681, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // addUnitBtn
            // 
            this.addUnitBtn.Caption = "Додати";
            this.addUnitBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addUnitBtn.Glyph")));
            this.addUnitBtn.Id = 1;
            this.addUnitBtn.Name = "addUnitBtn";
            this.addUnitBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addUnitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addUnitBtn_ItemClick);
            // 
            // editUnitBtn
            // 
            this.editUnitBtn.Caption = "Редагувати";
            this.editUnitBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editUnitBtn.Glyph")));
            this.editUnitBtn.Id = 2;
            this.editUnitBtn.Name = "editUnitBtn";
            this.editUnitBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.editUnitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editUnitBtn_ItemClick);
            // 
            // deleteUnitBtn
            // 
            this.deleteUnitBtn.Caption = "Видалити";
            this.deleteUnitBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteUnitBtn.Glyph")));
            this.deleteUnitBtn.Id = 3;
            this.deleteUnitBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteUnitBtn.LargeGlyph")));
            this.deleteUnitBtn.Name = "deleteUnitBtn";
            this.deleteUnitBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deleteUnitBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteUnitBtn_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.addUnitBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.editUnitBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteUnitBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Одиниці вимірювання";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.refreshBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Функції";
            // 
            // unitsGrid
            // 
            this.unitsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitsGrid.Location = new System.Drawing.Point(0, 95);
            this.unitsGrid.MainView = this.unitsGridView;
            this.unitsGrid.Name = "unitsGrid";
            this.unitsGrid.Size = new System.Drawing.Size(681, 556);
            this.unitsGrid.TabIndex = 1;
            this.unitsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.unitsGridView});
            this.unitsGrid.DoubleClick += new System.EventHandler(this.unitsGrid_DoubleClick);
            // 
            // unitsGridView
            // 
            this.unitsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.unitFullNameCol,
            this.unitLocalNameCol});
            this.unitsGridView.GridControl = this.unitsGrid;
            this.unitsGridView.Name = "unitsGridView";
            this.unitsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.unitsGridView.OptionsView.ShowAutoFilterRow = true;
            this.unitsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // unitFullNameCol
            // 
            this.unitFullNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.unitFullNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unitFullNameCol.Caption = "Повне наіменування";
            this.unitFullNameCol.FieldName = "UnitFullName";
            this.unitFullNameCol.Name = "unitFullNameCol";
            this.unitFullNameCol.OptionsColumn.AllowEdit = false;
            this.unitFullNameCol.OptionsColumn.AllowFocus = false;
            this.unitFullNameCol.Visible = true;
            this.unitFullNameCol.VisibleIndex = 0;
            this.unitFullNameCol.Width = 400;
            // 
            // unitLocalNameCol
            // 
            this.unitLocalNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.unitLocalNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unitLocalNameCol.Caption = "Скорочене наіменування";
            this.unitLocalNameCol.FieldName = "UnitLocalName";
            this.unitLocalNameCol.Name = "unitLocalNameCol";
            this.unitLocalNameCol.OptionsColumn.AllowEdit = false;
            this.unitLocalNameCol.OptionsColumn.AllowFocus = false;
            this.unitLocalNameCol.Visible = true;
            this.unitLocalNameCol.VisibleIndex = 1;
            this.unitLocalNameCol.Width = 263;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // UnitsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 651);
            this.Controls.Add(this.unitsGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "UnitsFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Довідник одиниць вимірювання";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl unitsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView unitsGridView;
        private DevExpress.XtraBars.BarButtonItem addUnitBtn;
        private DevExpress.XtraBars.BarButtonItem editUnitBtn;
        private DevExpress.XtraBars.BarButtonItem deleteUnitBtn;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn unitFullNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn unitLocalNameCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}