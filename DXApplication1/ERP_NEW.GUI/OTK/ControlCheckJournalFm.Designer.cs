namespace ERP_NEW.GUI.OTK
{
    partial class ControlCheckJournalFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlCheckJournalFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.actJournalGrid = new DevExpress.XtraGrid.GridControl();
            this.actJournalGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.customerOrderNumverCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contractorCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.responsiblePersonCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.numberDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actJournalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actJournalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addBtn,
            this.editBtn,
            this.deleteBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1292, 93);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Додати";
            this.addBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addBtn.Glyph")));
            this.addBtn.Id = 1;
            this.addBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addBtn.LargeGlyph")));
            this.addBtn.Name = "addBtn";
            this.addBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBtn_ItemClick);
            // 
            // editBtn
            // 
            this.editBtn.Caption = "Редагувати";
            this.editBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editBtn.Glyph")));
            this.editBtn.Id = 2;
            this.editBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editBtn.LargeGlyph")));
            this.editBtn.Name = "editBtn";
            this.editBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.editBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Видалити";
            this.deleteBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Glyph")));
            this.deleteBtn.Id = 3;
            this.deleteBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteBtn.LargeGlyph")));
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.addBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.editBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Акт";
            // 
            // actJournalGrid
            // 
            this.actJournalGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actJournalGrid.Location = new System.Drawing.Point(0, 93);
            this.actJournalGrid.MainView = this.actJournalGridView;
            this.actJournalGrid.Name = "actJournalGrid";
            this.actJournalGrid.Size = new System.Drawing.Size(1292, 447);
            this.actJournalGrid.TabIndex = 1;
            this.actJournalGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.actJournalGridView});
            // 
            // actJournalGridView
            // 
            this.actJournalGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.customerOrderNumverCol,
            this.contractorCol,
            this.checkDateCol,
            this.responsiblePersonCol,
            this.numberDateCol});
            this.actJournalGridView.GridControl = this.actJournalGrid;
            this.actJournalGridView.Name = "actJournalGridView";
            this.actJournalGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // customerOrderNumverCol
            // 
            this.customerOrderNumverCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerOrderNumverCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.customerOrderNumverCol.AppearanceHeader.Options.UseFont = true;
            this.customerOrderNumverCol.AppearanceHeader.Options.UseForeColor = true;
            this.customerOrderNumverCol.Caption = "Номер заказу";
            this.customerOrderNumverCol.FieldName = "CustomerOrderNumber";
            this.customerOrderNumverCol.Name = "customerOrderNumverCol";
            this.customerOrderNumverCol.OptionsColumn.AllowEdit = false;
            this.customerOrderNumverCol.OptionsColumn.AllowFocus = false;
            this.customerOrderNumverCol.Visible = true;
            this.customerOrderNumverCol.VisibleIndex = 0;
            // 
            // contractorCol
            // 
            this.contractorCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractorCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.contractorCol.AppearanceHeader.Options.UseFont = true;
            this.contractorCol.AppearanceHeader.Options.UseForeColor = true;
            this.contractorCol.Caption = "Контрагент";
            this.contractorCol.FieldName = "ContractorName";
            this.contractorCol.Name = "contractorCol";
            this.contractorCol.OptionsColumn.AllowEdit = false;
            this.contractorCol.OptionsColumn.AllowFocus = false;
            this.contractorCol.Visible = true;
            this.contractorCol.VisibleIndex = 1;
            // 
            // checkDateCol
            // 
            this.checkDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkDateCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.checkDateCol.AppearanceHeader.Options.UseFont = true;
            this.checkDateCol.AppearanceHeader.Options.UseForeColor = true;
            this.checkDateCol.Caption = "Дата відмітки";
            this.checkDateCol.FieldName = "ControlDate";
            this.checkDateCol.Name = "checkDateCol";
            this.checkDateCol.OptionsColumn.AllowEdit = false;
            this.checkDateCol.OptionsColumn.AllowFocus = false;
            this.checkDateCol.Visible = true;
            this.checkDateCol.VisibleIndex = 2;
            // 
            // responsiblePersonCol
            // 
            this.responsiblePersonCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.responsiblePersonCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.responsiblePersonCol.AppearanceHeader.Options.UseFont = true;
            this.responsiblePersonCol.AppearanceHeader.Options.UseForeColor = true;
            this.responsiblePersonCol.Caption = "Контролююча особа";
            this.responsiblePersonCol.FieldName = "ControlPersonName";
            this.responsiblePersonCol.Name = "responsiblePersonCol";
            this.responsiblePersonCol.OptionsColumn.AllowEdit = false;
            this.responsiblePersonCol.OptionsColumn.AllowFocus = false;
            this.responsiblePersonCol.Visible = true;
            this.responsiblePersonCol.VisibleIndex = 3;
            // 
            // numberDateCol
            // 
            this.numberDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberDateCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.numberDateCol.AppearanceHeader.Options.UseFont = true;
            this.numberDateCol.AppearanceHeader.Options.UseForeColor = true;
            this.numberDateCol.Caption = "Номер відмітки";
            this.numberDateCol.FieldName = "MarkDocumentNumber";
            this.numberDateCol.Name = "numberDateCol";
            this.numberDateCol.OptionsColumn.AllowEdit = false;
            this.numberDateCol.OptionsColumn.AllowFocus = false;
            this.numberDateCol.Visible = true;
            this.numberDateCol.VisibleIndex = 4;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // ControlCheckJournalFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 540);
            this.Controls.Add(this.actJournalGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ControlCheckJournalFm";
            this.ShowIcon = false;
            this.Text = "Журнал приймально-сдавальних накладних";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actJournalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actJournalGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem editBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl actJournalGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView actJournalGridView;
        private DevExpress.XtraGrid.Columns.GridColumn customerOrderNumverCol;
        private DevExpress.XtraGrid.Columns.GridColumn contractorCol;
        private DevExpress.XtraGrid.Columns.GridColumn checkDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn responsiblePersonCol;
        private DevExpress.XtraGrid.Columns.GridColumn numberDateCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}