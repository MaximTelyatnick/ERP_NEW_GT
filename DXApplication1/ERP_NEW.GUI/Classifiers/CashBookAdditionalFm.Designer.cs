namespace ERP_NEW.GUI.Classifiers
{
    partial class CashBookAdditionalFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashBookAdditionalFm));
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addCashBookAdditionalBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editCashBookAdditionalBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteCashBookAdditionalBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cashBookAdditionalGrid = new DevExpress.XtraGrid.GridControl();
            this.cashBookAdditionalGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NameAdditionalType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookAdditionalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookAdditionalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addCashBookAdditionalBtn,
            this.editCashBookAdditionalBtn,
            this.deleteCashBookAdditionalBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(726, 95);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // addCashBookAdditionalBtn
            // 
            this.addCashBookAdditionalBtn.Caption = "Додати";
            this.addCashBookAdditionalBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addCashBookAdditionalBtn.Glyph")));
            this.addCashBookAdditionalBtn.Id = 1;
            this.addCashBookAdditionalBtn.Name = "addCashBookAdditionalBtn";
            this.addCashBookAdditionalBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addCashBookAdditionalBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addCashBookAdditionalBtn_ItemClick);
            // 
            // editCashBookAdditionalBtn
            // 
            this.editCashBookAdditionalBtn.Caption = "Редагувати";
            this.editCashBookAdditionalBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editCashBookAdditionalBtn.Glyph")));
            this.editCashBookAdditionalBtn.Id = 2;
            this.editCashBookAdditionalBtn.Name = "editCashBookAdditionalBtn";
            this.editCashBookAdditionalBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.editCashBookAdditionalBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editCashBookAdditionalBtn_ItemClick);
            // 
            // deleteCashBookAdditionalBtn
            // 
            this.deleteCashBookAdditionalBtn.Caption = "Видалити";
            this.deleteCashBookAdditionalBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteCashBookAdditionalBtn.Glyph")));
            this.deleteCashBookAdditionalBtn.Id = 3;
            this.deleteCashBookAdditionalBtn.Name = "deleteCashBookAdditionalBtn";
            this.deleteCashBookAdditionalBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deleteCashBookAdditionalBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteCashBookAdditionalBtn_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.addCashBookAdditionalBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.editCashBookAdditionalBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteCashBookAdditionalBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Додатки";
            // 
            // cashBookAdditionalGrid
            // 
            this.cashBookAdditionalGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashBookAdditionalGrid.Location = new System.Drawing.Point(0, 95);
            this.cashBookAdditionalGrid.MainView = this.cashBookAdditionalGridView;
            this.cashBookAdditionalGrid.Name = "cashBookAdditionalGrid";
            this.cashBookAdditionalGrid.Size = new System.Drawing.Size(726, 233);
            this.cashBookAdditionalGrid.TabIndex = 1;
            this.cashBookAdditionalGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cashBookAdditionalGridView});
            // 
            // cashBookAdditionalGridView
            // 
            this.cashBookAdditionalGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idCol,
            this.NameAdditionalType});
            this.cashBookAdditionalGridView.GridControl = this.cashBookAdditionalGrid;
            this.cashBookAdditionalGridView.Name = "cashBookAdditionalGridView";
            this.cashBookAdditionalGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.cashBookAdditionalGridView.OptionsView.ShowGroupPanel = false;
            // 
            // idCol
            // 
            this.idCol.AppearanceCell.Options.UseTextOptions = true;
            this.idCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.idCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.idCol.AppearanceHeader.Options.UseFont = true;
            this.idCol.Caption = "№п/п";
            this.idCol.FieldName = "Id";
            this.idCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.idCol.Name = "idCol";
            this.idCol.OptionsColumn.AllowEdit = false;
            this.idCol.OptionsColumn.AllowFocus = false;
            this.idCol.OptionsColumn.FixedWidth = true;
            this.idCol.Visible = true;
            this.idCol.VisibleIndex = 0;
            // 
            // NameAdditionalType
            // 
            this.NameAdditionalType.AppearanceCell.Options.UseTextOptions = true;
            this.NameAdditionalType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NameAdditionalType.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.NameAdditionalType.AppearanceHeader.Options.UseFont = true;
            this.NameAdditionalType.AppearanceHeader.Options.UseTextOptions = true;
            this.NameAdditionalType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NameAdditionalType.Caption = "Назва додатка";
            this.NameAdditionalType.FieldName = "NameAdditionalType";
            this.NameAdditionalType.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.NameAdditionalType.Name = "NameAdditionalType";
            this.NameAdditionalType.OptionsColumn.AllowEdit = false;
            this.NameAdditionalType.OptionsColumn.AllowFocus = false;
            this.NameAdditionalType.Visible = true;
            this.NameAdditionalType.VisibleIndex = 1;
            // 
            // CashBookAdditionalFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 328);
            this.Controls.Add(this.cashBookAdditionalGrid);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashBookAdditionalFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал касових додатків";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookAdditionalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookAdditionalGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem addCashBookAdditionalBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl cashBookAdditionalGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView cashBookAdditionalGridView;
        private DevExpress.XtraBars.BarButtonItem editCashBookAdditionalBtn;
        private DevExpress.XtraBars.BarButtonItem deleteCashBookAdditionalBtn;
        private DevExpress.XtraGrid.Columns.GridColumn idCol;
        private DevExpress.XtraGrid.Columns.GridColumn NameAdditionalType;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}