namespace ERP_NEW.GUI.Accounting
{
    partial class AccountingTransferFm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountingTransferFm));
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemMonth1 = new DevExpress.XtraScheduler.UI.RepositoryItemMonth();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.beginYearEdit = new DevExpress.XtraBars.BarEditItem();
            this.beginMonthEdit = new DevExpress.XtraBars.BarEditItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.endYearEdit = new DevExpress.XtraBars.BarEditItem();
            this.endMonthEdit = new DevExpress.XtraBars.BarEditItem();
            this.showBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.periodBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true, DevExpress.XtraSplashScreen.SplashFormStartPosition.Manual, new System.Drawing.Point(0, 0));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.transferGrid = new DevExpress.XtraGrid.GridControl();
            this.transferGridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.partnerSrnCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.partnerNameCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.paymentDateCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.paymentDocumentCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bankAccountNumCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.purposeAccountNum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.debitPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.creditPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.purposeCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMonth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repositoryItemDateEdit1.Appearance.Options.UseFont = true;
            this.repositoryItemDateEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemDateEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Mask.EditMask = "yyyy";
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.repositoryItemDateEdit1.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView;
            // 
            // repositoryItemMonth1
            // 
            this.repositoryItemMonth1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repositoryItemMonth1.Appearance.Options.UseFont = true;
            this.repositoryItemMonth1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMonth1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemMonth1.AutoHeight = false;
            this.repositoryItemMonth1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMonth1.Name = "repositoryItemMonth1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barHeaderItem1,
            this.barEditItem1,
            this.barStaticItem3,
            this.beginYearEdit,
            this.beginMonthEdit,
            this.barStaticItem4,
            this.endYearEdit,
            this.endMonthEdit,
            this.showBtn,
            this.addBtn,
            this.editBtn,
            this.deleteBtn,
            this.periodBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1294, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 1;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 2;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "Період з:";
            this.barStaticItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barStaticItem3.Glyph")));
            this.barStaticItem3.Id = 3;
            this.barStaticItem3.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Transparent;
            this.barStaticItem3.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barStaticItem3.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Maroon;
            this.barStaticItem3.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.barStaticItem3.ItemAppearance.Hovered.Options.UseFont = true;
            this.barStaticItem3.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.barStaticItem3.ItemAppearance.Normal.BackColor = System.Drawing.Color.Transparent;
            this.barStaticItem3.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barStaticItem3.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Maroon;
            this.barStaticItem3.ItemAppearance.Normal.Options.UseBackColor = true;
            this.barStaticItem3.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem3.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barStaticItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barStaticItem3.LargeGlyph")));
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // beginYearEdit
            // 
            this.beginYearEdit.Caption = "рік         ";
            this.beginYearEdit.Edit = this.repositoryItemDateEdit1;
            this.beginYearEdit.EditWidth = 100;
            this.beginYearEdit.Id = 4;
            this.beginYearEdit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginYearEdit.ItemAppearance.Hovered.Options.UseFont = true;
            this.beginYearEdit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginYearEdit.ItemAppearance.Normal.Options.UseFont = true;
            this.beginYearEdit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginYearEdit.ItemAppearance.Pressed.Options.UseFont = true;
            this.beginYearEdit.Name = "beginYearEdit";
            this.beginYearEdit.EditValueChanged += new System.EventHandler(this.beginYearEdit_EditValueChanged);
            // 
            // beginMonthEdit
            // 
            this.beginMonthEdit.Caption = "місяць  ";
            this.beginMonthEdit.Edit = this.repositoryItemMonth1;
            this.beginMonthEdit.EditWidth = 100;
            this.beginMonthEdit.Id = 5;
            this.beginMonthEdit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginMonthEdit.ItemAppearance.Hovered.Options.UseFont = true;
            this.beginMonthEdit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginMonthEdit.ItemAppearance.Normal.Options.UseFont = true;
            this.beginMonthEdit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginMonthEdit.ItemAppearance.Pressed.Options.UseFont = true;
            this.beginMonthEdit.Name = "beginMonthEdit";
            this.beginMonthEdit.EditValueChanged += new System.EventHandler(this.beginMonthEdit_EditValueChanged);
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = "Період по:";
            this.barStaticItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barStaticItem4.Glyph")));
            this.barStaticItem4.Id = 6;
            this.barStaticItem4.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barStaticItem4.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Maroon;
            this.barStaticItem4.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem4.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barStaticItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barStaticItem4.LargeGlyph")));
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // endYearEdit
            // 
            this.endYearEdit.Caption = "рік         ";
            this.endYearEdit.Edit = this.repositoryItemDateEdit1;
            this.endYearEdit.EditWidth = 100;
            this.endYearEdit.Id = 7;
            this.endYearEdit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endYearEdit.ItemAppearance.Hovered.Options.UseFont = true;
            this.endYearEdit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endYearEdit.ItemAppearance.Normal.Options.UseFont = true;
            this.endYearEdit.Name = "endYearEdit";
            this.endYearEdit.EditValueChanged += new System.EventHandler(this.endYearEdit_EditValueChanged);
            // 
            // endMonthEdit
            // 
            this.endMonthEdit.Caption = "місяць  ";
            this.endMonthEdit.Edit = this.repositoryItemMonth1;
            this.endMonthEdit.EditWidth = 100;
            this.endMonthEdit.Id = 8;
            this.endMonthEdit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endMonthEdit.ItemAppearance.Hovered.Options.UseFont = true;
            this.endMonthEdit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endMonthEdit.ItemAppearance.Normal.Options.UseFont = true;
            this.endMonthEdit.Name = "endMonthEdit";
            this.endMonthEdit.EditValueChanged += new System.EventHandler(this.endMonthEdit_EditValueChanged);
            this.endMonthEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEditItem4_ItemClick);
            // 
            // showBtn
            // 
            this.showBtn.Caption = "Показати";
            this.showBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("showBtn.Glyph")));
            this.showBtn.Id = 9;
            this.showBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showBtn.LargeGlyph")));
            this.showBtn.Name = "showBtn";
            this.showBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.showBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showBtn_ItemClick);
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Додати";
            this.addBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addBtn.Glyph")));
            this.addBtn.Id = 10;
            this.addBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addBtn.LargeGlyph")));
            this.addBtn.Name = "addBtn";
            this.addBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBtn_ItemClick);
            // 
            // editBtn
            // 
            this.editBtn.Caption = "Редагувати";
            this.editBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editBtn.Glyph")));
            this.editBtn.Id = 11;
            this.editBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editBtn.LargeGlyph")));
            this.editBtn.Name = "editBtn";
            this.editBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.editBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Видалити";
            this.deleteBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Glyph")));
            this.deleteBtn.Id = 12;
            this.deleteBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteBtn.LargeGlyph")));
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // periodBtn
            // 
            this.periodBtn.Caption = "Закрити період";
            this.periodBtn.Id = 13;
            this.periodBtn.Name = "periodBtn";
            this.periodBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.periodBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.periodBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barStaticItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.beginYearEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.beginMonthEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barStaticItem4);
            this.ribbonPageGroup1.ItemLinks.Add(this.endYearEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.endMonthEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.showBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Період";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.addBtn);
            this.ribbonPageGroup5.ItemLinks.Add(this.editBtn);
            this.ribbonPageGroup5.ItemLinks.Add(this.deleteBtn);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Документ";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.periodBtn);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Період";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Період з:";
            this.barStaticItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barStaticItem1.Glyph")));
            this.barStaticItem1.Id = 1;
            this.barStaticItem1.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.barStaticItem1.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Maroon;
            this.barStaticItem1.ItemAppearance.Hovered.Options.UseFont = true;
            this.barStaticItem1.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.barStaticItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.barStaticItem1.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Maroon;
            this.barStaticItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem1.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barStaticItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barStaticItem1.LargeGlyph")));
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barStaticItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Період";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.barStaticItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Період";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.barStaticItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Період";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Період з:";
            this.barStaticItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barStaticItem2.Glyph")));
            this.barStaticItem2.Id = 1;
            this.barStaticItem2.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.barStaticItem2.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Maroon;
            this.barStaticItem2.ItemAppearance.Hovered.Options.UseFont = true;
            this.barStaticItem2.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.barStaticItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.barStaticItem2.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Maroon;
            this.barStaticItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem2.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barStaticItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barStaticItem2.LargeGlyph")));
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "рік       ";
            this.barEditItem3.Edit = this.repositoryItemDateEdit1;
            this.barEditItem3.EditWidth = 100;
            this.barEditItem3.Id = 4;
            this.barEditItem3.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barEditItem3.ItemAppearance.Normal.Options.UseFont = true;
            this.barEditItem3.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barEditItem3.ItemAppearance.Pressed.Options.UseFont = true;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.addColorToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.ShowItemToolTips = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(200, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.copyToolStripMenuItem.Text = "Копировать";
            // 
            // addColorToolStripMenuItem
            // 
            this.addColorToolStripMenuItem.Image = global::ERP_NEW.GUI.Accounting.Resources.paint;
            this.addColorToolStripMenuItem.Name = "addColorToolStripMenuItem";
            this.addColorToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addColorToolStripMenuItem.Text = "Додати колір в палітру";
            // 
            // imageCollection
            // 
            this.imageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "if_lock.png");
            this.imageCollection.Images.SetKeyName(1, "if_lock_open.png");
            // 
            // transferGrid
            // 
            this.transferGrid.ContextMenuStrip = this.contextMenuStrip;
            this.transferGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transferGrid.Location = new System.Drawing.Point(0, 95);
            this.transferGrid.MainView = this.transferGridView;
            this.transferGrid.Name = "transferGrid";
            this.transferGrid.Size = new System.Drawing.Size(1294, 378);
            this.transferGrid.TabIndex = 4;
            this.transferGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.transferGridView});
            // 
            // transferGridView
            // 
            this.transferGridView.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.transferGridView.Appearance.FooterPanel.Options.UseFont = true;
            this.transferGridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent;
            this.transferGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.transferGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand7});
            this.transferGridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.partnerSrnCol,
            this.partnerNameCol,
            this.paymentDateCol,
            this.paymentDocumentCol,
            this.bankAccountNumCol,
            this.purposeAccountNum,
            this.debitPriceCol,
            this.creditPriceCol,
            this.purposeCol});
            this.transferGridView.GridControl = this.transferGrid;
            this.transferGridView.Name = "transferGridView";
            this.transferGridView.OptionsView.AllowCellMerge = true;
            this.transferGridView.OptionsView.ShowAutoFilterRow = true;
            this.transferGridView.OptionsView.ShowFooter = true;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Контрагент/працівник";
            this.gridBand1.Columns.Add(this.partnerSrnCol);
            this.gridBand1.Columns.Add(this.partnerNameCol);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 385;
            // 
            // partnerSrnCol
            // 
            this.partnerSrnCol.AppearanceHeader.Options.UseTextOptions = true;
            this.partnerSrnCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.partnerSrnCol.Caption = "ЄДРПОУ/Таб.номер";
            this.partnerSrnCol.FieldName = "ContractorSrn";
            this.partnerSrnCol.Name = "partnerSrnCol";
            this.partnerSrnCol.OptionsColumn.AllowEdit = false;
            this.partnerSrnCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.partnerSrnCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PartnerSrn", "Всього: {0}")});
            this.partnerSrnCol.Visible = true;
            this.partnerSrnCol.Width = 153;
            // 
            // partnerNameCol
            // 
            this.partnerNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.partnerNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.partnerNameCol.Caption = "Найменування";
            this.partnerNameCol.FieldName = "ContractorName";
            this.partnerNameCol.Name = "partnerNameCol";
            this.partnerNameCol.OptionsColumn.AllowEdit = false;
            this.partnerNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.partnerNameCol.Visible = true;
            this.partnerNameCol.Width = 232;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Платіжний документ";
            this.gridBand2.Columns.Add(this.paymentDateCol);
            this.gridBand2.Columns.Add(this.paymentDocumentCol);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 229;
            // 
            // paymentDateCol
            // 
            this.paymentDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentDateCol.Caption = "Дата";
            this.paymentDateCol.DisplayFormat.FormatString = "d";
            this.paymentDateCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.paymentDateCol.FieldName = "PaymentDate";
            this.paymentDateCol.Name = "paymentDateCol";
            this.paymentDateCol.OptionsColumn.AllowEdit = false;
            this.paymentDateCol.Visible = true;
            this.paymentDateCol.Width = 172;
            // 
            // paymentDocumentCol
            // 
            this.paymentDocumentCol.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentDocumentCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentDocumentCol.Caption = "Номер";
            this.paymentDocumentCol.FieldName = "OperateDocument";
            this.paymentDocumentCol.Name = "paymentDocumentCol";
            this.paymentDocumentCol.OptionsColumn.AllowEdit = false;
            this.paymentDocumentCol.Visible = true;
            this.paymentDocumentCol.Width = 57;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Рахунки";
            this.gridBand3.Columns.Add(this.bankAccountNumCol);
            this.gridBand3.Columns.Add(this.purposeAccountNum);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 193;
            // 
            // bankAccountNumCol
            // 
            this.bankAccountNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.bankAccountNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bankAccountNumCol.Caption = "Рахунок банку";
            this.bankAccountNumCol.FieldName = "OperationAccountNum";
            this.bankAccountNumCol.Name = "bankAccountNumCol";
            this.bankAccountNumCol.OptionsColumn.AllowEdit = false;
            this.bankAccountNumCol.Visible = true;
            this.bankAccountNumCol.Width = 95;
            // 
            // purposeAccountNum
            // 
            this.purposeAccountNum.AppearanceHeader.Options.UseTextOptions = true;
            this.purposeAccountNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.purposeAccountNum.Caption = "Рахунок призначення";
            this.purposeAccountNum.FieldName = "PurposeAccountNum";
            this.purposeAccountNum.Name = "purposeAccountNum";
            this.purposeAccountNum.OptionsColumn.AllowEdit = false;
            this.purposeAccountNum.Visible = true;
            this.purposeAccountNum.Width = 98;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand4.AppearanceHeader.Options.UseFont = true;
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Дебет";
            this.gridBand4.Columns.Add(this.debitPriceCol);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 106;
            // 
            // debitPriceCol
            // 
            this.debitPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.debitPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.debitPriceCol.Caption = "Сума у гривнях";
            this.debitPriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.debitPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.debitPriceCol.FieldName = "DebitPrice";
            this.debitPriceCol.Name = "debitPriceCol";
            this.debitPriceCol.OptionsColumn.AllowEdit = false;
            this.debitPriceCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "DebitPrice", "{0:### ### ##0.00}")});
            this.debitPriceCol.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.debitPriceCol.Visible = true;
            this.debitPriceCol.Width = 106;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand5.AppearanceHeader.Options.UseFont = true;
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.Caption = "Кредит";
            this.gridBand5.Columns.Add(this.creditPriceCol);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 115;
            // 
            // creditPriceCol
            // 
            this.creditPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.creditPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.creditPriceCol.Caption = "Сума у гривнях";
            this.creditPriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.creditPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.creditPriceCol.FieldName = "CreditPrice";
            this.creditPriceCol.Name = "creditPriceCol";
            this.creditPriceCol.OptionsColumn.AllowEdit = false;
            this.creditPriceCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "CreditPrice", "{0:### ### ##0.00}")});
            this.creditPriceCol.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.creditPriceCol.Visible = true;
            this.creditPriceCol.Width = 115;
            // 
            // gridBand7
            // 
            this.gridBand7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand7.AppearanceHeader.Options.UseFont = true;
            this.gridBand7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand7.Caption = "Додатково";
            this.gridBand7.Columns.Add(this.purposeCol);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.VisibleIndex = 5;
            this.gridBand7.Width = 248;
            // 
            // purposeCol
            // 
            this.purposeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.purposeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.purposeCol.Caption = "Призначення платежу";
            this.purposeCol.FieldName = "Purpose";
            this.purposeCol.Name = "purposeCol";
            this.purposeCol.OptionsColumn.AllowEdit = false;
            this.purposeCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.purposeCol.Visible = true;
            this.purposeCol.Width = 248;
            // 
            // AccountingTransferFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 473);
            this.Controls.Add(this.transferGrid);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountingTransferFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountingTransferFm";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMonth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarEditItem beginYearEdit;
        private DevExpress.XtraBars.BarEditItem beginMonthEdit;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraBars.BarEditItem endYearEdit;
        private DevExpress.XtraBars.BarEditItem endMonthEdit;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraBars.BarButtonItem showBtn;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem editBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addColorToolStripMenuItem;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraGrid.GridControl transferGrid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView transferGridView;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn partnerSrnCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn partnerNameCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentDateCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn paymentDocumentCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bankAccountNumCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn purposeAccountNum;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn debitPriceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn creditPriceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn purposeCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraScheduler.UI.RepositoryItemMonth repositoryItemMonth1;
        private DevExpress.XtraBars.BarButtonItem periodBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}