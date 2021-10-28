namespace ERP_NEW.GUI.Classifiers
{
    partial class BasisJournalFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasisJournalFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addbasistypeBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editbasistypeBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deletebasistypeBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.basisJournalGrid = new DevExpress.XtraGrid.GridControl();
            this.basisJournalGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.basisTypeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            //this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basisJournalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basisJournalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addbasistypeBtn,
            this.editbasistypeBtn,
            this.deletebasistypeBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1177, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // addbasistypeBtn
            // 
            this.addbasistypeBtn.Caption = "Додати";
            this.addbasistypeBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addbasistypeBtn.Glyph")));
            this.addbasistypeBtn.Id = 1;
            this.addbasistypeBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addbasistypeBtn.LargeGlyph")));
            this.addbasistypeBtn.Name = "addbasistypeBtn";
            this.addbasistypeBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addbasistypeBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addbasistypeBtn_ItemClick);
            // 
            // editbasistypeBtn
            // 
            this.editbasistypeBtn.Caption = "Редагувати";
            this.editbasistypeBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editbasistypeBtn.Glyph")));
            this.editbasistypeBtn.Id = 2;
            this.editbasistypeBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editbasistypeBtn.LargeGlyph")));
            this.editbasistypeBtn.Name = "editbasistypeBtn";
            this.editbasistypeBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.editbasistypeBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editbasistypeBtn_ItemClick);
            // 
            // deletebasistypeBtn
            // 
            this.deletebasistypeBtn.Caption = "Видалити";
            this.deletebasistypeBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deletebasistypeBtn.Glyph")));
            this.deletebasistypeBtn.Id = 3;
            this.deletebasistypeBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deletebasistypeBtn.LargeGlyph")));
            this.deletebasistypeBtn.Name = "deletebasistypeBtn";
            this.deletebasistypeBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deletebasistypeBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deletebasistypeBtn_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.addbasistypeBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.editbasistypeBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deletebasistypeBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Редагування";
            // 
            // basisJournalGrid
            // 
            this.basisJournalGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basisJournalGrid.Location = new System.Drawing.Point(0, 95);
            this.basisJournalGrid.MainView = this.basisJournalGridView;
            this.basisJournalGrid.Name = "basisJournalGrid";
            this.basisJournalGrid.Size = new System.Drawing.Size(1177, 451);
            this.basisJournalGrid.TabIndex = 1;
            this.basisJournalGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.basisJournalGridView});
            // 
            // basisJournalGridView
            // 
            this.basisJournalGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idCol,
            this.basisTypeCol});
            this.basisJournalGridView.GridControl = this.basisJournalGrid;
            this.basisJournalGridView.Name = "basisJournalGridView";
            this.basisJournalGridView.OptionsCustomization.AllowFilter = false;
            this.basisJournalGridView.OptionsCustomization.AllowGroup = false;
            this.basisJournalGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.basisJournalGridView.OptionsView.ShowAutoFilterRow = true;
            this.basisJournalGridView.OptionsView.ShowGroupPanel = false;
            // 
            // idCol
            // 
            this.idCol.AppearanceCell.Options.UseTextOptions = true;
            this.idCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.idCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idCol.AppearanceHeader.Options.UseFont = true;
            this.idCol.AppearanceHeader.Options.UseTextOptions = true;
            this.idCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.idCol.Caption = "Номер п/п";
            this.idCol.FieldName = "Id";
            this.idCol.Name = "idCol";
            this.idCol.OptionsColumn.AllowEdit = false;
            this.idCol.OptionsColumn.AllowFocus = false;
            this.idCol.OptionsColumn.FixedWidth = true;
            this.idCol.Visible = true;
            this.idCol.VisibleIndex = 0;
            // 
            // basisTypeCol
            // 
            this.basisTypeCol.AppearanceCell.Options.UseTextOptions = true;
            this.basisTypeCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.basisTypeCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.basisTypeCol.AppearanceHeader.Options.UseFont = true;
            this.basisTypeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.basisTypeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.basisTypeCol.Caption = "Назва";
            this.basisTypeCol.FieldName = "BasisType";
            this.basisTypeCol.Name = "basisTypeCol";
            this.basisTypeCol.OptionsColumn.AllowEdit = false;
            this.basisTypeCol.OptionsColumn.AllowFocus = false;
            this.basisTypeCol.Visible = true;
            this.basisTypeCol.VisibleIndex = 1;
            // 
            // splashScreenManager
            // 
            //this.splashScreenManager.ClosingDelay = 500;
            // 
            // BasisJournalFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 546);
            this.Controls.Add(this.basisJournalGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "BasisJournalFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал підстав";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basisJournalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basisJournalGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl basisJournalGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView basisJournalGridView;
        private DevExpress.XtraBars.BarButtonItem addbasistypeBtn;
        private DevExpress.XtraBars.BarButtonItem editbasistypeBtn;
        private DevExpress.XtraBars.BarButtonItem deletebasistypeBtn;
        private DevExpress.XtraGrid.Columns.GridColumn idCol;
        private DevExpress.XtraGrid.Columns.GridColumn basisTypeCol;
        
    }
}