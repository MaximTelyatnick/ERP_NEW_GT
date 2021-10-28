namespace ERP_NEW.GUI.Classifiers
{
    partial class CashBookContractorFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashBookContractorFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addCashBookContractorBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editCashBookContractorBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteCashBookContractorBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cashBookContractorGrid = new DevExpress.XtraGrid.GridControl();
            this.cashBookContractorGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cashBookContractorNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tabFormDefaultManager2 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookContractorGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookContractorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addCashBookContractorBtn,
            this.editCashBookContractorBtn,
            this.deleteCashBookContractorBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(999, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // addCashBookContractorBtn
            // 
            this.addCashBookContractorBtn.Caption = "Додати";
            this.addCashBookContractorBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addCashBookContractorBtn.Glyph")));
            this.addCashBookContractorBtn.Id = 4;
            this.addCashBookContractorBtn.Name = "addCashBookContractorBtn";
            this.addCashBookContractorBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addCashBookContractorBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddCashBookContractorBtn_ItemClick);
            // 
            // editCashBookContractorBtn
            // 
            this.editCashBookContractorBtn.Caption = "Редагувати";
            this.editCashBookContractorBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editCashBookContractorBtn.Glyph")));
            this.editCashBookContractorBtn.Id = 5;
            this.editCashBookContractorBtn.Name = "editCashBookContractorBtn";
            this.editCashBookContractorBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.editCashBookContractorBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditCashBookContractorBtn_ItemClick);
            // 
            // deleteCashBookContractorBtn
            // 
            this.deleteCashBookContractorBtn.Caption = "Видалити";
            this.deleteCashBookContractorBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteCashBookContractorBtn.Glyph")));
            this.deleteCashBookContractorBtn.Id = 6;
            this.deleteCashBookContractorBtn.Name = "deleteCashBookContractorBtn";
            this.deleteCashBookContractorBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deleteCashBookContractorBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteCashBookContractorBtn_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.addCashBookContractorBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.editCashBookContractorBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteCashBookContractorBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Контрагенти";
            // 
            // cashBookContractorGrid
            // 
            this.cashBookContractorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashBookContractorGrid.Location = new System.Drawing.Point(0, 95);
            this.cashBookContractorGrid.MainView = this.cashBookContractorGridView;
            this.cashBookContractorGrid.Name = "cashBookContractorGrid";
            this.cashBookContractorGrid.Size = new System.Drawing.Size(999, 365);
            this.cashBookContractorGrid.TabIndex = 1;
            this.cashBookContractorGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cashBookContractorGridView});
            // 
            // cashBookContractorGridView
            // 
            this.cashBookContractorGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idCol,
            this.cashBookContractorNameCol});
            this.cashBookContractorGridView.GridControl = this.cashBookContractorGrid;
            this.cashBookContractorGridView.Name = "cashBookContractorGridView";
            this.cashBookContractorGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.cashBookContractorGridView.OptionsView.ShowAutoFilterRow = true;
            this.cashBookContractorGridView.OptionsView.ShowFooter = true;
            this.cashBookContractorGridView.OptionsView.ShowGroupPanel = false;
            // 
            // idCol
            // 
            this.idCol.AppearanceCell.Options.UseTextOptions = true;
            this.idCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.idCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.idCol.AppearanceHeader.Options.UseFont = true;
            this.idCol.AppearanceHeader.Options.UseTextOptions = true;
            this.idCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.idCol.Caption = "№ п/п";
            this.idCol.FieldName = "Id";
            this.idCol.Name = "idCol";
            this.idCol.OptionsColumn.AllowEdit = false;
            this.idCol.OptionsColumn.AllowFocus = false;
            this.idCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.idCol.OptionsColumn.FixedWidth = true;
            this.idCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Id", "Кількість контрагентів: {0}")});
            this.idCol.Visible = true;
            this.idCol.VisibleIndex = 0;
            // 
            // cashBookContractorNameCol
            // 
            this.cashBookContractorNameCol.AppearanceCell.Options.UseTextOptions = true;
            this.cashBookContractorNameCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cashBookContractorNameCol.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cashBookContractorNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cashBookContractorNameCol.AppearanceHeader.Options.UseFont = true;
            this.cashBookContractorNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.cashBookContractorNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cashBookContractorNameCol.Caption = "Контрагенты";
            this.cashBookContractorNameCol.FieldName = "CashBookContractorName";
            this.cashBookContractorNameCol.Name = "cashBookContractorNameCol";
            this.cashBookContractorNameCol.OptionsColumn.AllowEdit = false;
            this.cashBookContractorNameCol.OptionsColumn.AllowFocus = false;
            this.cashBookContractorNameCol.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None;
            this.cashBookContractorNameCol.Visible = true;
            this.cashBookContractorNameCol.VisibleIndex = 1;
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.Form = this;
            this.tabFormDefaultManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(999, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 460);
            this.barDockControlBottom.Size = new System.Drawing.Size(999, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 460);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(999, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 460);
            // 
            // tabFormDefaultManager2
            // 
            this.tabFormDefaultManager2.DockControls.Add(this.barDockControl1);
            this.tabFormDefaultManager2.DockControls.Add(this.barDockControl2);
            this.tabFormDefaultManager2.DockControls.Add(this.barDockControl3);
            this.tabFormDefaultManager2.DockControls.Add(this.barDockControl4);
            this.tabFormDefaultManager2.Form = this;
            this.tabFormDefaultManager2.MaxItemId = 0;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(999, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 460);
            this.barDockControl2.Size = new System.Drawing.Size(999, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Size = new System.Drawing.Size(0, 460);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(999, 0);
            this.barDockControl4.Size = new System.Drawing.Size(0, 460);
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // CashBookContractorFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 460);
            this.Controls.Add(this.cashBookContractorGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashBookContractorFm";
            this.ShowIcon = false;
            this.Text = "Контрагенты";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookContractorGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookContractorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraGrid.GridControl cashBookContractorGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView cashBookContractorGridView;
        private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn idCol;
        private DevExpress.XtraGrid.Columns.GridColumn cashBookContractorNameCol;
        private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem addCashBookContractorBtn;
        private DevExpress.XtraBars.BarButtonItem editCashBookContractorBtn;
        private DevExpress.XtraBars.BarButtonItem deleteCashBookContractorBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}