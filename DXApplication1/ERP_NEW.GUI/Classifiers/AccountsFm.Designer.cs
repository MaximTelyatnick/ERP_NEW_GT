namespace ERP_NEW.GUI.Classifiers
{
    partial class AccountsFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.addAccountBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editAccountBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteAccountBtn = new DevExpress.XtraBars.BarButtonItem();
            this.updateAccountBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.accountsGrid = new DevExpress.XtraGrid.GridControl();
            this.accountsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.accountNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountDescriptionCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountTypeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.addAccountBtn,
            this.editAccountBtn,
            this.deleteAccountBtn,
            this.updateAccountBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1045, 118);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // addAccountBtn
            // 
            this.addAccountBtn.Caption = "Додати";
            this.addAccountBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addAccountBtn.Glyph")));
            this.addAccountBtn.Id = 2;
            this.addAccountBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addAccountBtn.LargeGlyph")));
            this.addAccountBtn.Name = "addAccountBtn";
            this.addAccountBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addAccountBtn_ItemClick);
            // 
            // editAccountBtn
            // 
            this.editAccountBtn.Caption = "Редагувати";
            this.editAccountBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editAccountBtn.Glyph")));
            this.editAccountBtn.Id = 3;
            this.editAccountBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editAccountBtn.LargeGlyph")));
            this.editAccountBtn.Name = "editAccountBtn";
            this.editAccountBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editAccountBtn_ItemClick);
            // 
            // deleteAccountBtn
            // 
            this.deleteAccountBtn.Caption = "Видалити";
            this.deleteAccountBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteAccountBtn.Glyph")));
            this.deleteAccountBtn.Id = 4;
            this.deleteAccountBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteAccountBtn.LargeGlyph")));
            this.deleteAccountBtn.Name = "deleteAccountBtn";
            this.deleteAccountBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteAccountBtn_ItemClick);
            // 
            // updateAccountBtn
            // 
            this.updateAccountBtn.Caption = "Оновити";
            this.updateAccountBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("updateAccountBtn.Glyph")));
            this.updateAccountBtn.Id = 5;
            this.updateAccountBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("updateAccountBtn.LargeGlyph")));
            this.updateAccountBtn.Name = "updateAccountBtn";
            this.updateAccountBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.updateAccountBtn_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.addAccountBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.editAccountBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteAccountBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Рахунок";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.updateAccountBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Функції";
            // 
            // accountsGrid
            // 
            this.accountsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountsGrid.Location = new System.Drawing.Point(0, 118);
            this.accountsGrid.MainView = this.accountsGridView;
            this.accountsGrid.Name = "accountsGrid";
            this.accountsGrid.Size = new System.Drawing.Size(1045, 374);
            this.accountsGrid.TabIndex = 1;
            this.accountsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.accountsGridView});
            this.accountsGrid.DoubleClick += new System.EventHandler(this.accountsGrid_DoubleClick);
            // 
            // accountsGridView
            // 
            this.accountsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.accountNumberCol,
            this.accountDescriptionCol,
            this.accountTypeCol});
            this.accountsGridView.GridControl = this.accountsGrid;
            this.accountsGridView.Name = "accountsGridView";
            this.accountsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.accountsGridView.OptionsView.ShowAutoFilterRow = true;
            this.accountsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // accountNumberCol
            // 
            this.accountNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.accountNumberCol.AppearanceHeader.Options.UseFont = true;
            this.accountNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.accountNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.accountNumberCol.Caption = "Номер рахунку";
            this.accountNumberCol.FieldName = "Num";
            this.accountNumberCol.Name = "accountNumberCol";
            this.accountNumberCol.OptionsColumn.AllowEdit = false;
            this.accountNumberCol.OptionsColumn.AllowFocus = false;
            this.accountNumberCol.Visible = true;
            this.accountNumberCol.VisibleIndex = 0;
            // 
            // accountDescriptionCol
            // 
            this.accountDescriptionCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.accountDescriptionCol.AppearanceHeader.Options.UseFont = true;
            this.accountDescriptionCol.AppearanceHeader.Options.UseTextOptions = true;
            this.accountDescriptionCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.accountDescriptionCol.Caption = "Опис рахунку";
            this.accountDescriptionCol.FieldName = "Description";
            this.accountDescriptionCol.Name = "accountDescriptionCol";
            this.accountDescriptionCol.OptionsColumn.AllowEdit = false;
            this.accountDescriptionCol.OptionsColumn.AllowFocus = false;
            this.accountDescriptionCol.Visible = true;
            this.accountDescriptionCol.VisibleIndex = 1;
            // 
            // accountTypeCol
            // 
            this.accountTypeCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.accountTypeCol.AppearanceHeader.Options.UseFont = true;
            this.accountTypeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.accountTypeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.accountTypeCol.Caption = "Тип рахунку";
            this.accountTypeCol.FieldName = "TypeName";
            this.accountTypeCol.Name = "accountTypeCol";
            this.accountTypeCol.OptionsColumn.AllowEdit = false;
            this.accountTypeCol.OptionsColumn.AllowFocus = false;
            this.accountTypeCol.Visible = true;
            this.accountTypeCol.VisibleIndex = 2;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // AccountsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 492);
            this.Controls.Add(this.accountsGrid);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountsFm";
            this.ShowIcon = false;
            this.Text = "Рахунки";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl accountsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView accountsGridView;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem addAccountBtn;
        private DevExpress.XtraBars.BarButtonItem editAccountBtn;
        private DevExpress.XtraBars.BarButtonItem deleteAccountBtn;
        private DevExpress.XtraBars.BarButtonItem updateAccountBtn;
        private DevExpress.XtraGrid.Columns.GridColumn accountNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn accountDescriptionCol;
        private DevExpress.XtraGrid.Columns.GridColumn accountTypeCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}