namespace ERP_NEW.GUI.Accounting
{
    partial class FixedAssetsOrderFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixedAssetsOrderFm));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.fixedAssessOrderTab = new DevExpress.XtraTab.XtraTabControl();
            this.fixedAssestsTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.yearEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.monthEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMonth1 = new DevExpress.XtraScheduler.UI.RepositoryItemMonth();
            this.fixedAssesOrderShowBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.soldFixeAssetsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.transferFixeAssetsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.printBtn = new DevExpress.XtraBars.BarButtonItem();
            this.actBtn = new DevExpress.XtraBars.BarButtonItem();
            this.materialsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.printInventoryCardBtn = new DevExpress.XtraBars.BarButtonItem();
            this.regJournalOrderBtn = new DevExpress.XtraBars.BarButtonItem();
            this.journalOrderBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.actWriteOffBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fixedAssetsOrderGrid = new DevExpress.XtraGrid.GridControl();
            this.fixedAssetsOrderGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.transferCardCboxCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inventoryNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inventoryNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.balanceAccountCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.suppliersCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.operatingPersonCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.beginDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.beginPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.increasePriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalAmortizationCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.currentPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.periodAmortizationCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.currentAmortizationCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.periodYearAmortizationCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.endDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.endRegisterDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fixedAssetsMaterialsGrid = new DevExpress.XtraGrid.GridControl();
            this.fixedAssetsMaterialsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nomenclatureCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fixedNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receiptNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quantityCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.untilPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.eExpDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.priceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fixedPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flagNoteCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.flagCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.arhivTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.fixedAssetsArchiveGrid = new DevExpress.XtraGrid.GridControl();
            this.fixedAssetsArchiveGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.inventoryArchiveCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameArchiveCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.balanceAcNumArchiveCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SupplierNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BeginDateArchiveCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usefulMonthArchiveCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.endRecordDateArchiveCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.transferPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soldPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.operationNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupArchiveCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.operationStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.showArchivBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteFromArchiveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.printArchiceBtn = new DevExpress.XtraBars.BarButtonItem();
            this.beginDateArchiveEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.endDateArchiveEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.regArchiveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.decreeItemMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssessOrderTab)).BeginInit();
            this.fixedAssessOrderTab.SuspendLayout();
            this.fixedAssestsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMonth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsOrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsOrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsMaterialsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsMaterialsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.arhivTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsArchiveGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsArchiveGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit5.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decreeItemMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // fixedAssessOrderTab
            // 
            this.fixedAssessOrderTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fixedAssessOrderTab.Location = new System.Drawing.Point(0, 0);
            this.fixedAssessOrderTab.Name = "fixedAssessOrderTab";
            this.fixedAssessOrderTab.SelectedTabPage = this.fixedAssestsTabPage;
            this.fixedAssessOrderTab.Size = new System.Drawing.Size(1378, 682);
            this.fixedAssessOrderTab.TabIndex = 0;
            this.fixedAssessOrderTab.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fixedAssestsTabPage,
            this.arhivTabPage});
            this.fixedAssessOrderTab.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.fixedAssessOrderTab_SelectedPageChanged);
            // 
            // fixedAssestsTabPage
            // 
            this.fixedAssestsTabPage.AlwaysScrollActiveControlIntoView = false;
            this.fixedAssestsTabPage.Controls.Add(this.splitContainerControl1);
            this.fixedAssestsTabPage.Name = "fixedAssestsTabPage";
            this.fixedAssestsTabPage.Size = new System.Drawing.Size(1372, 654);
            this.fixedAssestsTabPage.Tag = "0";
            this.fixedAssestsTabPage.Text = "Основні засоби";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.ribbonControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1372, 654);
            this.splitContainerControl1.SplitterPosition = 98;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.yearEdit,
            this.monthEdit,
            this.fixedAssesOrderShowBtn,
            this.addBtn,
            this.editBtn,
            this.deleteBtn,
            this.soldFixeAssetsBtn,
            this.transferFixeAssetsBtn,
            this.printBtn,
            this.actBtn,
            this.materialsBtn,
            this.printInventoryCardBtn,
            this.regJournalOrderBtn,
            this.journalOrderBtn,
            this.ribbonGalleryBarItem1,
            this.actWriteOffBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemMonth1,
            this.repositoryItemCheckEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1372, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // yearEdit
            // 
            this.yearEdit.Caption = "Рік      ";
            this.yearEdit.Edit = this.repositoryItemDateEdit1;
            this.yearEdit.EditWidth = 100;
            this.yearEdit.Id = 1;
            this.yearEdit.Name = "yearEdit";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "yyyy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "yyyy";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "yyyy";
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemDateEdit1.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.repositoryItemDateEdit1.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView;
            // 
            // monthEdit
            // 
            this.monthEdit.Caption = "Місяць";
            this.monthEdit.Edit = this.repositoryItemMonth1;
            this.monthEdit.EditWidth = 100;
            this.monthEdit.Id = 2;
            this.monthEdit.Name = "monthEdit";
            // 
            // repositoryItemMonth1
            // 
            this.repositoryItemMonth1.AutoHeight = false;
            this.repositoryItemMonth1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMonth1.Name = "repositoryItemMonth1";
            // 
            // fixedAssesOrderShowBtn
            // 
            this.fixedAssesOrderShowBtn.Caption = "Показати";
            this.fixedAssesOrderShowBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("fixedAssesOrderShowBtn.Glyph")));
            this.fixedAssesOrderShowBtn.Id = 3;
            this.fixedAssesOrderShowBtn.Name = "fixedAssesOrderShowBtn";
            this.fixedAssesOrderShowBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.fixedAssesOrderShowBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.fixedAssesOrderShowBtn_ItemClick);
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Додати";
            this.addBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addBtn.Glyph")));
            this.addBtn.Id = 4;
            this.addBtn.Name = "addBtn";
            this.addBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.addBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBtn_ItemClick);
            // 
            // editBtn
            // 
            this.editBtn.Caption = "Редагувати";
            this.editBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editBtn.Glyph")));
            this.editBtn.Id = 5;
            this.editBtn.Name = "editBtn";
            this.editBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.editBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Видалити";
            this.deleteBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Glyph")));
            this.deleteBtn.Id = 6;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // soldFixeAssetsBtn
            // 
            this.soldFixeAssetsBtn.Caption = "Продаж";
            this.soldFixeAssetsBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("soldFixeAssetsBtn.Glyph")));
            this.soldFixeAssetsBtn.Id = 7;
            this.soldFixeAssetsBtn.Name = "soldFixeAssetsBtn";
            this.soldFixeAssetsBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.soldFixeAssetsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.soldFixeAssetsBtn_ItemClick);
            // 
            // transferFixeAssetsBtn
            // 
            this.transferFixeAssetsBtn.Caption = "Переміщення";
            this.transferFixeAssetsBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("transferFixeAssetsBtn.Glyph")));
            this.transferFixeAssetsBtn.Id = 8;
            this.transferFixeAssetsBtn.Name = "transferFixeAssetsBtn";
            this.transferFixeAssetsBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.transferFixeAssetsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.transferFixeAssetsBtn_ItemClick);
            // 
            // printBtn
            // 
            this.printBtn.Caption = "Друк картки";
            this.printBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("printBtn.Glyph")));
            this.printBtn.Id = 10;
            this.printBtn.Name = "printBtn";
            this.printBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.printBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.printBtn_ItemClick);
            // 
            // actBtn
            // 
            this.actBtn.Caption = "Акт прийому- передачі";
            this.actBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("actBtn.Glyph")));
            this.actBtn.Id = 11;
            this.actBtn.Name = "actBtn";
            this.actBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.actBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.actBtn_ItemClick);
            // 
            // materialsBtn
            // 
            this.materialsBtn.Caption = "Матеріали";
            this.materialsBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("materialsBtn.Glyph")));
            this.materialsBtn.Id = 15;
            this.materialsBtn.Name = "materialsBtn";
            this.materialsBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.materialsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.materialsBtn_ItemClick);
            // 
            // printInventoryCardBtn
            // 
            this.printInventoryCardBtn.Caption = "Інвентарна картка обліку";
            this.printInventoryCardBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("printInventoryCardBtn.Glyph")));
            this.printInventoryCardBtn.Id = 21;
            this.printInventoryCardBtn.Name = "printInventoryCardBtn";
            this.printInventoryCardBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.printInventoryCardBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.printInventoryCardBtn_ItemClick);
            // 
            // regJournalOrderBtn
            // 
            this.regJournalOrderBtn.Caption = "Регістрація наказу";
            this.regJournalOrderBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("regJournalOrderBtn.Glyph")));
            this.regJournalOrderBtn.Id = 22;
            this.regJournalOrderBtn.Name = "regJournalOrderBtn";
            this.regJournalOrderBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.regJournalOrderBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.regJournalOrderBtn_ItemClick);
            // 
            // journalOrderBtn
            // 
            this.journalOrderBtn.Caption = "Журнал наказів";
            this.journalOrderBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("journalOrderBtn.Glyph")));
            this.journalOrderBtn.Id = 23;
            this.journalOrderBtn.Name = "journalOrderBtn";
            this.journalOrderBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.journalOrderBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.journalOrderBtn_ItemClick);
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "InplaceGallery1";
            this.ribbonGalleryBarItem1.Id = 1;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // actWriteOffBtn
            // 
            this.actWriteOffBtn.Caption = "Акт відремонтованих об\'єктів";
            this.actWriteOffBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("actWriteOffBtn.Glyph")));
            this.actWriteOffBtn.Id = 2;
            this.actWriteOffBtn.Name = "actWriteOffBtn";
            this.actWriteOffBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.actWriteOffBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.actWriteOffBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.monthEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.yearEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.fixedAssesOrderShowBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Період";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.addBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.editBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.deleteBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Керування засобами";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.soldFixeAssetsBtn);
            this.ribbonPageGroup3.ItemLinks.Add(this.transferFixeAssetsBtn);
            this.ribbonPageGroup3.ItemLinks.Add(this.regJournalOrderBtn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Операції із засобами";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.printBtn);
            this.ribbonPageGroup4.ItemLinks.Add(this.printInventoryCardBtn);
            this.ribbonPageGroup4.ItemLinks.Add(this.actBtn);
            this.ribbonPageGroup4.ItemLinks.Add(this.actWriteOffBtn);
            this.ribbonPageGroup4.ItemLinks.Add(this.materialsBtn, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.journalOrderBtn);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Звіти по основним засобам";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fixedAssetsOrderGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fixedAssetsMaterialsGrid, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.96124F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.03876F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1372, 551);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.pictureBox4);
            this.panelControl1.Controls.Add(this.pictureBox3);
            this.panelControl1.Controls.Add(this.pictureBox2);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 519);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1366, 29);
            this.panelControl1.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(459, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(199, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "- корегування первинної вартості";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(341, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "- корегування";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(180, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(129, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "- збільшення вартості";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(32, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "- первинна вартість";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(152, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(313, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(430, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fixedAssetsOrderGrid
            // 
            this.fixedAssetsOrderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fixedAssetsOrderGrid.Location = new System.Drawing.Point(3, 3);
            this.fixedAssetsOrderGrid.MainView = this.fixedAssetsOrderGridView;
            this.fixedAssetsOrderGrid.Name = "fixedAssetsOrderGrid";
            this.fixedAssetsOrderGrid.Size = new System.Drawing.Size(1366, 355);
            this.fixedAssetsOrderGrid.TabIndex = 0;
            this.fixedAssetsOrderGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fixedAssetsOrderGridView});
            // 
            // fixedAssetsOrderGridView
            // 
            this.fixedAssetsOrderGridView.ColumnPanelRowHeight = 40;
            this.fixedAssetsOrderGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.transferCardCboxCol,
            this.inventoryNumberCol,
            this.inventoryNameCol,
            this.balanceAccountCol,
            this.suppliersCol,
            this.operatingPersonCol,
            this.beginDateCol,
            this.beginPriceCol,
            this.increasePriceCol,
            this.totalAmortizationCol,
            this.currentPriceCol,
            this.periodAmortizationCol,
            this.currentAmortizationCol,
            this.periodYearAmortizationCol,
            this.endDateCol,
            this.endRegisterDateCol,
            this.groupCol});
            this.fixedAssetsOrderGridView.GridControl = this.fixedAssetsOrderGrid;
            this.fixedAssetsOrderGridView.GroupCount = 1;
            this.fixedAssetsOrderGridView.Name = "fixedAssetsOrderGridView";
            this.fixedAssetsOrderGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.fixedAssetsOrderGridView.OptionsView.ShowAutoFilterRow = true;
            this.fixedAssetsOrderGridView.OptionsView.ShowFooter = true;
            this.fixedAssetsOrderGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.groupCol, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.fixedAssetsOrderGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.fixedAssetsOrderGridView_FocusedRowChanged);
            // 
            // transferCardCboxCol
            // 
            this.transferCardCboxCol.Caption = "selectedCard";
            this.transferCardCboxCol.FieldName = "SelectedCard";
            this.transferCardCboxCol.Name = "transferCardCboxCol";
            // 
            // inventoryNumberCol
            // 
            this.inventoryNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.inventoryNumberCol.AppearanceHeader.Options.UseFont = true;
            this.inventoryNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.inventoryNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.inventoryNumberCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.inventoryNumberCol.Caption = "Інвентарний номер";
            this.inventoryNumberCol.FieldName = "InventoryNumber";
            this.inventoryNumberCol.Name = "inventoryNumberCol";
            this.inventoryNumberCol.OptionsColumn.AllowEdit = false;
            this.inventoryNumberCol.OptionsColumn.AllowFocus = false;
            this.inventoryNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.inventoryNumberCol.Visible = true;
            this.inventoryNumberCol.VisibleIndex = 0;
            this.inventoryNumberCol.Width = 88;
            // 
            // inventoryNameCol
            // 
            this.inventoryNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.inventoryNameCol.AppearanceHeader.Options.UseFont = true;
            this.inventoryNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.inventoryNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.inventoryNameCol.Caption = "Найменування";
            this.inventoryNameCol.FieldName = "InventoryName";
            this.inventoryNameCol.Name = "inventoryNameCol";
            this.inventoryNameCol.OptionsColumn.AllowEdit = false;
            this.inventoryNameCol.OptionsColumn.AllowFocus = false;
            this.inventoryNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.inventoryNameCol.Visible = true;
            this.inventoryNameCol.VisibleIndex = 1;
            this.inventoryNameCol.Width = 88;
            // 
            // balanceAccountCol
            // 
            this.balanceAccountCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.balanceAccountCol.AppearanceHeader.Options.UseFont = true;
            this.balanceAccountCol.AppearanceHeader.Options.UseTextOptions = true;
            this.balanceAccountCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.balanceAccountCol.Caption = "Бал./рах.";
            this.balanceAccountCol.FieldName = "BalanceAccountNum";
            this.balanceAccountCol.Name = "balanceAccountCol";
            this.balanceAccountCol.OptionsColumn.AllowEdit = false;
            this.balanceAccountCol.OptionsColumn.AllowFocus = false;
            this.balanceAccountCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.balanceAccountCol.Visible = true;
            this.balanceAccountCol.VisibleIndex = 2;
            this.balanceAccountCol.Width = 57;
            // 
            // suppliersCol
            // 
            this.suppliersCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.suppliersCol.AppearanceHeader.Options.UseFont = true;
            this.suppliersCol.AppearanceHeader.Options.UseTextOptions = true;
            this.suppliersCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.suppliersCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.suppliersCol.Caption = "Відповідальна особа";
            this.suppliersCol.FieldName = "SupplierName";
            this.suppliersCol.Name = "suppliersCol";
            this.suppliersCol.OptionsColumn.AllowEdit = false;
            this.suppliersCol.OptionsColumn.AllowFocus = false;
            this.suppliersCol.Visible = true;
            this.suppliersCol.VisibleIndex = 3;
            this.suppliersCol.Width = 89;
            // 
            // operatingPersonCol
            // 
            this.operatingPersonCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.operatingPersonCol.AppearanceHeader.Options.UseFont = true;
            this.operatingPersonCol.AppearanceHeader.Options.UseTextOptions = true;
            this.operatingPersonCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.operatingPersonCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.operatingPersonCol.Caption = "Експлуатуюча особа";
            this.operatingPersonCol.FieldName = "OperatingPersonName";
            this.operatingPersonCol.Name = "operatingPersonCol";
            this.operatingPersonCol.OptionsColumn.AllowEdit = false;
            this.operatingPersonCol.OptionsColumn.AllowFocus = false;
            this.operatingPersonCol.Visible = true;
            this.operatingPersonCol.VisibleIndex = 4;
            this.operatingPersonCol.Width = 89;
            // 
            // beginDateCol
            // 
            this.beginDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.beginDateCol.AppearanceHeader.Options.UseFont = true;
            this.beginDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.beginDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.beginDateCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.beginDateCol.Caption = "Дата прийняття до обліку";
            this.beginDateCol.FieldName = "BeginDate";
            this.beginDateCol.Name = "beginDateCol";
            this.beginDateCol.OptionsColumn.AllowEdit = false;
            this.beginDateCol.OptionsColumn.AllowFocus = false;
            this.beginDateCol.OptionsFilter.AllowAutoFilter = false;
            this.beginDateCol.OptionsFilter.AllowFilter = false;
            this.beginDateCol.Visible = true;
            this.beginDateCol.VisibleIndex = 5;
            this.beginDateCol.Width = 98;
            // 
            // beginPriceCol
            // 
            this.beginPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.beginPriceCol.AppearanceHeader.Options.UseFont = true;
            this.beginPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.beginPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.beginPriceCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.beginPriceCol.Caption = "Первинна вартість";
            this.beginPriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.beginPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.beginPriceCol.FieldName = "BeginPrice";
            this.beginPriceCol.Name = "beginPriceCol";
            this.beginPriceCol.OptionsColumn.AllowEdit = false;
            this.beginPriceCol.OptionsColumn.AllowFocus = false;
            this.beginPriceCol.OptionsFilter.AllowAutoFilter = false;
            this.beginPriceCol.OptionsFilter.AllowFilter = false;
            this.beginPriceCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BeginPrice", "{0:### ### ##0.00}")});
            this.beginPriceCol.Visible = true;
            this.beginPriceCol.VisibleIndex = 6;
            this.beginPriceCol.Width = 89;
            // 
            // increasePriceCol
            // 
            this.increasePriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.increasePriceCol.AppearanceHeader.Options.UseFont = true;
            this.increasePriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.increasePriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.increasePriceCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.increasePriceCol.Caption = "Збільшення вартості";
            this.increasePriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.increasePriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.increasePriceCol.FieldName = "IncreasePrice";
            this.increasePriceCol.Name = "increasePriceCol";
            this.increasePriceCol.OptionsColumn.AllowEdit = false;
            this.increasePriceCol.OptionsColumn.AllowFocus = false;
            this.increasePriceCol.OptionsFilter.AllowAutoFilter = false;
            this.increasePriceCol.OptionsFilter.AllowFilter = false;
            this.increasePriceCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IncreasePrice", "{0:### ### ##0.00}")});
            this.increasePriceCol.Visible = true;
            this.increasePriceCol.VisibleIndex = 7;
            this.increasePriceCol.Width = 82;
            // 
            // totalAmortizationCol
            // 
            this.totalAmortizationCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.totalAmortizationCol.AppearanceHeader.Options.UseFont = true;
            this.totalAmortizationCol.AppearanceHeader.Options.UseTextOptions = true;
            this.totalAmortizationCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.totalAmortizationCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.totalAmortizationCol.Caption = "Поточна вартість";
            this.totalAmortizationCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.totalAmortizationCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.totalAmortizationCol.FieldName = "TotalPrice";
            this.totalAmortizationCol.Name = "totalAmortizationCol";
            this.totalAmortizationCol.OptionsColumn.AllowEdit = false;
            this.totalAmortizationCol.OptionsColumn.AllowFocus = false;
            this.totalAmortizationCol.OptionsFilter.AllowAutoFilter = false;
            this.totalAmortizationCol.OptionsFilter.AllowFilter = false;
            this.totalAmortizationCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "{0:### ### ##0.00}")});
            this.totalAmortizationCol.Visible = true;
            this.totalAmortizationCol.VisibleIndex = 8;
            this.totalAmortizationCol.Width = 89;
            // 
            // currentPriceCol
            // 
            this.currentPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.currentPriceCol.AppearanceHeader.Options.UseFont = true;
            this.currentPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.currentPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.currentPriceCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.currentPriceCol.Caption = "Залишкова вартість";
            this.currentPriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.currentPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.currentPriceCol.FieldName = "CurrentPrice";
            this.currentPriceCol.Name = "currentPriceCol";
            this.currentPriceCol.OptionsColumn.AllowEdit = false;
            this.currentPriceCol.OptionsColumn.AllowFocus = false;
            this.currentPriceCol.OptionsFilter.AllowAutoFilter = false;
            this.currentPriceCol.OptionsFilter.AllowFilter = false;
            this.currentPriceCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CurrentPrice", "{0:### ### ##0.00}")});
            this.currentPriceCol.Visible = true;
            this.currentPriceCol.VisibleIndex = 9;
            this.currentPriceCol.Width = 81;
            // 
            // periodAmortizationCol
            // 
            this.periodAmortizationCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.periodAmortizationCol.AppearanceHeader.Options.UseFont = true;
            this.periodAmortizationCol.AppearanceHeader.Options.UseTextOptions = true;
            this.periodAmortizationCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.periodAmortizationCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.periodAmortizationCol.Caption = "Сума амотизації";
            this.periodAmortizationCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.periodAmortizationCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.periodAmortizationCol.FieldName = "PeriodAmortization";
            this.periodAmortizationCol.Name = "periodAmortizationCol";
            this.periodAmortizationCol.OptionsColumn.AllowEdit = false;
            this.periodAmortizationCol.OptionsColumn.AllowFocus = false;
            this.periodAmortizationCol.OptionsFilter.AllowAutoFilter = false;
            this.periodAmortizationCol.OptionsFilter.AllowFilter = false;
            this.periodAmortizationCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PeriodAmortization", "{0:### ### ##0.00}")});
            this.periodAmortizationCol.Visible = true;
            this.periodAmortizationCol.VisibleIndex = 10;
            this.periodAmortizationCol.Width = 89;
            // 
            // currentAmortizationCol
            // 
            this.currentAmortizationCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.currentAmortizationCol.AppearanceHeader.Options.UseFont = true;
            this.currentAmortizationCol.AppearanceHeader.Options.UseTextOptions = true;
            this.currentAmortizationCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.currentAmortizationCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.currentAmortizationCol.Caption = "Амортизація за поточний місяць";
            this.currentAmortizationCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.currentAmortizationCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.currentAmortizationCol.FieldName = "CurrentAmortization";
            this.currentAmortizationCol.Name = "currentAmortizationCol";
            this.currentAmortizationCol.OptionsColumn.AllowEdit = false;
            this.currentAmortizationCol.OptionsColumn.AllowFocus = false;
            this.currentAmortizationCol.OptionsFilter.AllowAutoFilter = false;
            this.currentAmortizationCol.OptionsFilter.AllowFilter = false;
            this.currentAmortizationCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CurrentAmortization", "{0:### ### ##0.00}")});
            this.currentAmortizationCol.Visible = true;
            this.currentAmortizationCol.VisibleIndex = 12;
            this.currentAmortizationCol.Width = 104;
            // 
            // periodYearAmortizationCol
            // 
            this.periodYearAmortizationCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.periodYearAmortizationCol.AppearanceHeader.Options.UseFont = true;
            this.periodYearAmortizationCol.AppearanceHeader.Options.UseTextOptions = true;
            this.periodYearAmortizationCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.periodYearAmortizationCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.periodYearAmortizationCol.Caption = "Амортизація з початку року";
            this.periodYearAmortizationCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.periodYearAmortizationCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.periodYearAmortizationCol.FieldName = "PeriodYearAmortization";
            this.periodYearAmortizationCol.Name = "periodYearAmortizationCol";
            this.periodYearAmortizationCol.OptionsColumn.AllowEdit = false;
            this.periodYearAmortizationCol.OptionsColumn.AllowFocus = false;
            this.periodYearAmortizationCol.OptionsFilter.AllowAutoFilter = false;
            this.periodYearAmortizationCol.OptionsFilter.AllowFilter = false;
            this.periodYearAmortizationCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PeriodYearAmortization", "{0:### ### ##0.00}")});
            this.periodYearAmortizationCol.Visible = true;
            this.periodYearAmortizationCol.VisibleIndex = 11;
            this.periodYearAmortizationCol.Width = 89;
            // 
            // endDateCol
            // 
            this.endDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.endDateCol.AppearanceHeader.Options.UseFont = true;
            this.endDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.endDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.endDateCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.endDateCol.Caption = "Термін використання (міс.)";
            this.endDateCol.FieldName = "UsefulMonth";
            this.endDateCol.Name = "endDateCol";
            this.endDateCol.OptionsColumn.AllowEdit = false;
            this.endDateCol.OptionsColumn.AllowFocus = false;
            this.endDateCol.OptionsFilter.AllowAutoFilter = false;
            this.endDateCol.OptionsFilter.AllowFilter = false;
            this.endDateCol.Visible = true;
            this.endDateCol.VisibleIndex = 13;
            this.endDateCol.Width = 105;
            // 
            // endRegisterDateCol
            // 
            this.endRegisterDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.endRegisterDateCol.AppearanceHeader.Options.UseFont = true;
            this.endRegisterDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.endRegisterDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.endRegisterDateCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.endRegisterDateCol.Caption = "Дата зняття з обліку, продажу, переміщення";
            this.endRegisterDateCol.FieldName = "EndRecordDate";
            this.endRegisterDateCol.Name = "endRegisterDateCol";
            this.endRegisterDateCol.OptionsColumn.AllowEdit = false;
            this.endRegisterDateCol.OptionsColumn.AllowFocus = false;
            this.endRegisterDateCol.Visible = true;
            this.endRegisterDateCol.VisibleIndex = 14;
            this.endRegisterDateCol.Width = 111;
            // 
            // groupCol
            // 
            this.groupCol.Caption = "Група";
            this.groupCol.FieldName = "GroupName";
            this.groupCol.Name = "groupCol";
            this.groupCol.OptionsColumn.AllowEdit = false;
            this.groupCol.OptionsColumn.AllowFocus = false;
            this.groupCol.Visible = true;
            this.groupCol.VisibleIndex = 15;
            // 
            // fixedAssetsMaterialsGrid
            // 
            this.fixedAssetsMaterialsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fixedAssetsMaterialsGrid.Location = new System.Drawing.Point(3, 364);
            this.fixedAssetsMaterialsGrid.MainView = this.fixedAssetsMaterialsGridView;
            this.fixedAssetsMaterialsGrid.Name = "fixedAssetsMaterialsGrid";
            this.fixedAssetsMaterialsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.fixedAssetsMaterialsGrid.Size = new System.Drawing.Size(1366, 149);
            this.fixedAssetsMaterialsGrid.TabIndex = 0;
            this.fixedAssetsMaterialsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fixedAssetsMaterialsGridView});
            // 
            // fixedAssetsMaterialsGridView
            // 
            this.fixedAssetsMaterialsGridView.ColumnPanelRowHeight = 40;
            this.fixedAssetsMaterialsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nomenclatureCol,
            this.nameCol,
            this.fixedNumCol,
            this.receiptNumCol,
            this.orderDateCol,
            this.orderNumCol,
            this.quantityCol,
            this.untilPriceCol,
            this.totalPriceCol,
            this.eExpDateCol,
            this.priceCol,
            this.fixedPriceCol,
            this.flagNoteCol,
            this.flagCol});
            this.fixedAssetsMaterialsGridView.GridControl = this.fixedAssetsMaterialsGrid;
            this.fixedAssetsMaterialsGridView.Name = "fixedAssetsMaterialsGridView";
            this.fixedAssetsMaterialsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.fixedAssetsMaterialsGridView.OptionsView.ShowGroupPanel = false;
            this.fixedAssetsMaterialsGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.fixedAssetsMaterialsGridView_CustomUnboundColumnData);
            // 
            // nomenclatureCol
            // 
            this.nomenclatureCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nomenclatureCol.AppearanceHeader.Options.UseFont = true;
            this.nomenclatureCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureCol.Caption = "Ном. номер";
            this.nomenclatureCol.FieldName = "Nomenclature";
            this.nomenclatureCol.Name = "nomenclatureCol";
            this.nomenclatureCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureCol.OptionsFilter.AllowAutoFilter = false;
            this.nomenclatureCol.OptionsFilter.AllowFilter = false;
            this.nomenclatureCol.Visible = true;
            this.nomenclatureCol.VisibleIndex = 0;
            this.nomenclatureCol.Width = 103;
            // 
            // nameCol
            // 
            this.nameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nameCol.AppearanceHeader.Options.UseFont = true;
            this.nameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameCol.Caption = "Найменування";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.AllowEdit = false;
            this.nameCol.OptionsColumn.AllowFocus = false;
            this.nameCol.OptionsFilter.AllowAutoFilter = false;
            this.nameCol.OptionsFilter.AllowFilter = false;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 1;
            this.nameCol.Width = 103;
            // 
            // fixedNumCol
            // 
            this.fixedNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fixedNumCol.AppearanceHeader.Options.UseFont = true;
            this.fixedNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.fixedNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fixedNumCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.fixedNumCol.Caption = "Рах. нарахування амортизації";
            this.fixedNumCol.FieldName = "FixedNum";
            this.fixedNumCol.Name = "fixedNumCol";
            this.fixedNumCol.OptionsColumn.AllowEdit = false;
            this.fixedNumCol.OptionsColumn.AllowFocus = false;
            this.fixedNumCol.OptionsFilter.AllowAutoFilter = false;
            this.fixedNumCol.OptionsFilter.AllowFilter = false;
            this.fixedNumCol.Visible = true;
            this.fixedNumCol.VisibleIndex = 2;
            this.fixedNumCol.Width = 142;
            // 
            // receiptNumCol
            // 
            this.receiptNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.receiptNumCol.AppearanceHeader.Options.UseFont = true;
            this.receiptNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.receiptNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.receiptNumCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.receiptNumCol.Caption = "Номер надходження";
            this.receiptNumCol.FieldName = "ReceiptNum";
            this.receiptNumCol.Name = "receiptNumCol";
            this.receiptNumCol.OptionsColumn.AllowEdit = false;
            this.receiptNumCol.OptionsColumn.AllowFocus = false;
            this.receiptNumCol.OptionsFilter.AllowAutoFilter = false;
            this.receiptNumCol.OptionsFilter.AllowFilter = false;
            this.receiptNumCol.Visible = true;
            this.receiptNumCol.VisibleIndex = 3;
            this.receiptNumCol.Width = 99;
            // 
            // orderDateCol
            // 
            this.orderDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.orderDateCol.AppearanceHeader.Options.UseFont = true;
            this.orderDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderDateCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.orderDateCol.Caption = "Дата надходження";
            this.orderDateCol.FieldName = "OrderDate";
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.OptionsColumn.AllowEdit = false;
            this.orderDateCol.OptionsColumn.AllowFocus = false;
            this.orderDateCol.OptionsFilter.AllowAutoFilter = false;
            this.orderDateCol.OptionsFilter.AllowFilter = false;
            this.orderDateCol.Visible = true;
            this.orderDateCol.VisibleIndex = 4;
            this.orderDateCol.Width = 99;
            // 
            // orderNumCol
            // 
            this.orderNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.orderNumCol.AppearanceHeader.Options.UseFont = true;
            this.orderNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderNumCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.orderNumCol.Caption = "Балансовий рахунок";
            this.orderNumCol.FieldName = "OrderNum";
            this.orderNumCol.Name = "orderNumCol";
            this.orderNumCol.OptionsColumn.AllowEdit = false;
            this.orderNumCol.OptionsColumn.AllowFocus = false;
            this.orderNumCol.OptionsFilter.AllowAutoFilter = false;
            this.orderNumCol.OptionsFilter.AllowFilter = false;
            this.orderNumCol.Visible = true;
            this.orderNumCol.VisibleIndex = 5;
            this.orderNumCol.Width = 99;
            // 
            // quantityCol
            // 
            this.quantityCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.quantityCol.AppearanceHeader.Options.UseFont = true;
            this.quantityCol.AppearanceHeader.Options.UseTextOptions = true;
            this.quantityCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.quantityCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.quantityCol.Caption = "К-сть";
            this.quantityCol.FieldName = "Quantity";
            this.quantityCol.Name = "quantityCol";
            this.quantityCol.OptionsColumn.AllowEdit = false;
            this.quantityCol.OptionsColumn.AllowFocus = false;
            this.quantityCol.OptionsFilter.AllowAutoFilter = false;
            this.quantityCol.OptionsFilter.AllowFilter = false;
            this.quantityCol.Visible = true;
            this.quantityCol.VisibleIndex = 6;
            this.quantityCol.Width = 99;
            // 
            // untilPriceCol
            // 
            this.untilPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.untilPriceCol.AppearanceHeader.Options.UseFont = true;
            this.untilPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.untilPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.untilPriceCol.Caption = "Ціна";
            this.untilPriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.untilPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.untilPriceCol.FieldName = "UnitPrice";
            this.untilPriceCol.Name = "untilPriceCol";
            this.untilPriceCol.OptionsColumn.AllowEdit = false;
            this.untilPriceCol.OptionsColumn.AllowFocus = false;
            this.untilPriceCol.OptionsFilter.AllowAutoFilter = false;
            this.untilPriceCol.OptionsFilter.AllowFilter = false;
            this.untilPriceCol.Visible = true;
            this.untilPriceCol.VisibleIndex = 7;
            this.untilPriceCol.Width = 99;
            // 
            // totalPriceCol
            // 
            this.totalPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.totalPriceCol.AppearanceHeader.Options.UseFont = true;
            this.totalPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.totalPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.totalPriceCol.Caption = "Сума";
            this.totalPriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.totalPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.totalPriceCol.FieldName = "TotalPrice";
            this.totalPriceCol.Name = "totalPriceCol";
            this.totalPriceCol.OptionsColumn.AllowEdit = false;
            this.totalPriceCol.OptionsColumn.AllowFocus = false;
            this.totalPriceCol.OptionsFilter.AllowAutoFilter = false;
            this.totalPriceCol.OptionsFilter.AllowFilter = false;
            this.totalPriceCol.Visible = true;
            this.totalPriceCol.VisibleIndex = 8;
            this.totalPriceCol.Width = 99;
            // 
            // eExpDateCol
            // 
            this.eExpDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.eExpDateCol.AppearanceHeader.Options.UseFont = true;
            this.eExpDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.eExpDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.eExpDateCol.Caption = "Дата списання";
            this.eExpDateCol.FieldName = "ExpDate";
            this.eExpDateCol.Name = "eExpDateCol";
            this.eExpDateCol.OptionsColumn.AllowEdit = false;
            this.eExpDateCol.OptionsColumn.AllowFocus = false;
            this.eExpDateCol.OptionsFilter.AllowAutoFilter = false;
            this.eExpDateCol.OptionsFilter.AllowFilter = false;
            this.eExpDateCol.Visible = true;
            this.eExpDateCol.VisibleIndex = 9;
            this.eExpDateCol.Width = 99;
            // 
            // priceCol
            // 
            this.priceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.priceCol.AppearanceHeader.Options.UseFont = true;
            this.priceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.priceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.priceCol.Caption = "Сума списання";
            this.priceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.priceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.priceCol.FieldName = "Price";
            this.priceCol.Name = "priceCol";
            this.priceCol.OptionsColumn.AllowEdit = false;
            this.priceCol.OptionsColumn.AllowFocus = false;
            this.priceCol.OptionsFilter.AllowAutoFilter = false;
            this.priceCol.OptionsFilter.AllowFilter = false;
            this.priceCol.Visible = true;
            this.priceCol.VisibleIndex = 10;
            this.priceCol.Width = 99;
            // 
            // fixedPriceCol
            // 
            this.fixedPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fixedPriceCol.AppearanceHeader.Options.UseFont = true;
            this.fixedPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.fixedPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fixedPriceCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.fixedPriceCol.Caption = "Сума до обліку";
            this.fixedPriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.fixedPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fixedPriceCol.FieldName = "FixedPrice";
            this.fixedPriceCol.Name = "fixedPriceCol";
            this.fixedPriceCol.OptionsColumn.AllowEdit = false;
            this.fixedPriceCol.OptionsColumn.AllowFocus = false;
            this.fixedPriceCol.OptionsFilter.AllowAutoFilter = false;
            this.fixedPriceCol.OptionsFilter.AllowFilter = false;
            this.fixedPriceCol.Visible = true;
            this.fixedPriceCol.VisibleIndex = 11;
            this.fixedPriceCol.Width = 99;
            // 
            // flagNoteCol
            // 
            this.flagNoteCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.flagNoteCol.AppearanceHeader.Options.UseFont = true;
            this.flagNoteCol.AppearanceHeader.Options.UseTextOptions = true;
            this.flagNoteCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.flagNoteCol.Caption = "...";
            this.flagNoteCol.ColumnEdit = this.repositoryItemPictureEdit1;
            this.flagNoteCol.FieldName = "flagNoteCol";
            this.flagNoteCol.Name = "flagNoteCol";
            this.flagNoteCol.OptionsColumn.AllowEdit = false;
            this.flagNoteCol.OptionsColumn.AllowFocus = false;
            this.flagNoteCol.OptionsFilter.AllowAutoFilter = false;
            this.flagNoteCol.OptionsFilter.AllowFilter = false;
            this.flagNoteCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.flagNoteCol.Visible = true;
            this.flagNoteCol.VisibleIndex = 12;
            this.flagNoteCol.Width = 109;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("repositoryItemPictureEdit1.ErrorImage")));
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image;
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            // 
            // flagCol
            // 
            this.flagCol.Caption = "flag";
            this.flagCol.Name = "flagCol";
            // 
            // arhivTabPage
            // 
            this.arhivTabPage.Controls.Add(this.fixedAssetsArchiveGrid);
            this.arhivTabPage.Controls.Add(this.ribbonControl2);
            this.arhivTabPage.Name = "arhivTabPage";
            this.arhivTabPage.Size = new System.Drawing.Size(1372, 654);
            this.arhivTabPage.Tag = "1";
            this.arhivTabPage.Text = "Архів";
            // 
            // fixedAssetsArchiveGrid
            // 
            this.fixedAssetsArchiveGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fixedAssetsArchiveGrid.Location = new System.Drawing.Point(0, 95);
            this.fixedAssetsArchiveGrid.MainView = this.fixedAssetsArchiveGridView;
            this.fixedAssetsArchiveGrid.MenuManager = this.ribbonControl1;
            this.fixedAssetsArchiveGrid.Name = "fixedAssetsArchiveGrid";
            this.fixedAssetsArchiveGrid.Size = new System.Drawing.Size(1372, 559);
            this.fixedAssetsArchiveGrid.TabIndex = 1;
            this.fixedAssetsArchiveGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fixedAssetsArchiveGridView});
            // 
            // fixedAssetsArchiveGridView
            // 
            this.fixedAssetsArchiveGridView.ColumnPanelRowHeight = 40;
            this.fixedAssetsArchiveGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.inventoryArchiveCol,
            this.nameArchiveCol,
            this.balanceAcNumArchiveCol,
            this.SupplierNameCol,
            this.BeginDateArchiveCol,
            this.usefulMonthArchiveCol,
            this.endRecordDateArchiveCol,
            this.transferPriceCol,
            this.soldPriceCol,
            this.operationNameCol,
            this.groupArchiveCol,
            this.operationStatus});
            this.fixedAssetsArchiveGridView.GridControl = this.fixedAssetsArchiveGrid;
            this.fixedAssetsArchiveGridView.GroupCount = 1;
            this.fixedAssetsArchiveGridView.Name = "fixedAssetsArchiveGridView";
            this.fixedAssetsArchiveGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.fixedAssetsArchiveGridView.OptionsPrint.AutoWidth = false;
            this.fixedAssetsArchiveGridView.OptionsPrint.PrintFilterInfo = true;
            this.fixedAssetsArchiveGridView.OptionsView.ShowAutoFilterRow = true;
            this.fixedAssetsArchiveGridView.OptionsView.ShowFooter = true;
            this.fixedAssetsArchiveGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.groupArchiveCol, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.fixedAssetsArchiveGridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.fixedAssetsArchiveGridView_RowCellStyle);
            // 
            // inventoryArchiveCol
            // 
            this.inventoryArchiveCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.inventoryArchiveCol.AppearanceHeader.Options.UseFont = true;
            this.inventoryArchiveCol.AppearanceHeader.Options.UseTextOptions = true;
            this.inventoryArchiveCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.inventoryArchiveCol.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.inventoryArchiveCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.inventoryArchiveCol.Caption = "Інвентарний номер";
            this.inventoryArchiveCol.FieldName = "InventoryNumber";
            this.inventoryArchiveCol.Name = "inventoryArchiveCol";
            this.inventoryArchiveCol.OptionsColumn.AllowEdit = false;
            this.inventoryArchiveCol.OptionsColumn.AllowFocus = false;
            this.inventoryArchiveCol.Visible = true;
            this.inventoryArchiveCol.VisibleIndex = 0;
            this.inventoryArchiveCol.Width = 98;
            // 
            // nameArchiveCol
            // 
            this.nameArchiveCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nameArchiveCol.AppearanceHeader.Options.UseFont = true;
            this.nameArchiveCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nameArchiveCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameArchiveCol.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.nameArchiveCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.nameArchiveCol.Caption = "Найменування";
            this.nameArchiveCol.FieldName = "InventoryName";
            this.nameArchiveCol.Name = "nameArchiveCol";
            this.nameArchiveCol.OptionsColumn.AllowEdit = false;
            this.nameArchiveCol.OptionsColumn.AllowFocus = false;
            this.nameArchiveCol.Visible = true;
            this.nameArchiveCol.VisibleIndex = 1;
            this.nameArchiveCol.Width = 99;
            // 
            // balanceAcNumArchiveCol
            // 
            this.balanceAcNumArchiveCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.balanceAcNumArchiveCol.AppearanceHeader.Options.UseFont = true;
            this.balanceAcNumArchiveCol.AppearanceHeader.Options.UseTextOptions = true;
            this.balanceAcNumArchiveCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.balanceAcNumArchiveCol.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.balanceAcNumArchiveCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.balanceAcNumArchiveCol.Caption = "Бал./рах.";
            this.balanceAcNumArchiveCol.FieldName = "BalanceAccountNum";
            this.balanceAcNumArchiveCol.Name = "balanceAcNumArchiveCol";
            this.balanceAcNumArchiveCol.OptionsColumn.AllowEdit = false;
            this.balanceAcNumArchiveCol.OptionsColumn.AllowFocus = false;
            this.balanceAcNumArchiveCol.Visible = true;
            this.balanceAcNumArchiveCol.VisibleIndex = 2;
            this.balanceAcNumArchiveCol.Width = 121;
            // 
            // SupplierNameCol
            // 
            this.SupplierNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.SupplierNameCol.AppearanceHeader.Options.UseFont = true;
            this.SupplierNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.SupplierNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SupplierNameCol.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.SupplierNameCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.SupplierNameCol.Caption = "Відповідальна особа";
            this.SupplierNameCol.FieldName = "SupplierName";
            this.SupplierNameCol.Name = "SupplierNameCol";
            this.SupplierNameCol.OptionsColumn.AllowEdit = false;
            this.SupplierNameCol.OptionsColumn.AllowFocus = false;
            this.SupplierNameCol.Visible = true;
            this.SupplierNameCol.VisibleIndex = 3;
            this.SupplierNameCol.Width = 174;
            // 
            // BeginDateArchiveCol
            // 
            this.BeginDateArchiveCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.BeginDateArchiveCol.AppearanceHeader.Options.UseFont = true;
            this.BeginDateArchiveCol.AppearanceHeader.Options.UseTextOptions = true;
            this.BeginDateArchiveCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BeginDateArchiveCol.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.BeginDateArchiveCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.BeginDateArchiveCol.Caption = "Дата прийняття до обліку";
            this.BeginDateArchiveCol.FieldName = "BeginDate";
            this.BeginDateArchiveCol.Name = "BeginDateArchiveCol";
            this.BeginDateArchiveCol.OptionsColumn.AllowEdit = false;
            this.BeginDateArchiveCol.OptionsColumn.AllowFocus = false;
            this.BeginDateArchiveCol.Visible = true;
            this.BeginDateArchiveCol.VisibleIndex = 4;
            this.BeginDateArchiveCol.Width = 128;
            // 
            // usefulMonthArchiveCol
            // 
            this.usefulMonthArchiveCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.usefulMonthArchiveCol.AppearanceHeader.Options.UseFont = true;
            this.usefulMonthArchiveCol.AppearanceHeader.Options.UseTextOptions = true;
            this.usefulMonthArchiveCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.usefulMonthArchiveCol.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.usefulMonthArchiveCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.usefulMonthArchiveCol.Caption = "Термін використання (міс.)";
            this.usefulMonthArchiveCol.FieldName = "UsefulMonth";
            this.usefulMonthArchiveCol.Name = "usefulMonthArchiveCol";
            this.usefulMonthArchiveCol.OptionsColumn.AllowEdit = false;
            this.usefulMonthArchiveCol.OptionsColumn.AllowFocus = false;
            this.usefulMonthArchiveCol.Visible = true;
            this.usefulMonthArchiveCol.VisibleIndex = 5;
            this.usefulMonthArchiveCol.Width = 103;
            // 
            // endRecordDateArchiveCol
            // 
            this.endRecordDateArchiveCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.endRecordDateArchiveCol.AppearanceHeader.Options.UseFont = true;
            this.endRecordDateArchiveCol.AppearanceHeader.Options.UseTextOptions = true;
            this.endRecordDateArchiveCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.endRecordDateArchiveCol.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.endRecordDateArchiveCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.endRecordDateArchiveCol.Caption = "Дата зняття з обліку, продаж, переміщення";
            this.endRecordDateArchiveCol.FieldName = "EndRecordDate";
            this.endRecordDateArchiveCol.Name = "endRecordDateArchiveCol";
            this.endRecordDateArchiveCol.OptionsColumn.AllowEdit = false;
            this.endRecordDateArchiveCol.OptionsColumn.AllowFocus = false;
            this.endRecordDateArchiveCol.Visible = true;
            this.endRecordDateArchiveCol.VisibleIndex = 6;
            this.endRecordDateArchiveCol.Width = 86;
            // 
            // transferPriceCol
            // 
            this.transferPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.transferPriceCol.AppearanceHeader.Options.UseFont = true;
            this.transferPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.transferPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.transferPriceCol.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.transferPriceCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.transferPriceCol.Caption = "Сума переводу";
            this.transferPriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.transferPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.transferPriceCol.FieldName = "TransferPrice";
            this.transferPriceCol.Name = "transferPriceCol";
            this.transferPriceCol.OptionsColumn.AllowEdit = false;
            this.transferPriceCol.OptionsColumn.AllowFocus = false;
            this.transferPriceCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TransferPrice", "{0:### ### ##0.00}")});
            this.transferPriceCol.Visible = true;
            this.transferPriceCol.VisibleIndex = 7;
            this.transferPriceCol.Width = 115;
            // 
            // soldPriceCol
            // 
            this.soldPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.soldPriceCol.AppearanceHeader.Options.UseFont = true;
            this.soldPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.soldPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.soldPriceCol.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.soldPriceCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.soldPriceCol.Caption = "Сума продажу";
            this.soldPriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.soldPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.soldPriceCol.FieldName = "SoldPrice";
            this.soldPriceCol.Name = "soldPriceCol";
            this.soldPriceCol.OptionsColumn.AllowEdit = false;
            this.soldPriceCol.OptionsColumn.AllowFocus = false;
            this.soldPriceCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoldPrice", "{0:### ### ##0.00}")});
            this.soldPriceCol.Visible = true;
            this.soldPriceCol.VisibleIndex = 8;
            this.soldPriceCol.Width = 115;
            // 
            // operationNameCol
            // 
            this.operationNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.operationNameCol.AppearanceHeader.Options.UseFont = true;
            this.operationNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.operationNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.operationNameCol.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.operationNameCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.operationNameCol.Caption = "Вид операції";
            this.operationNameCol.FieldName = "OperationName";
            this.operationNameCol.Name = "operationNameCol";
            this.operationNameCol.OptionsColumn.AllowEdit = false;
            this.operationNameCol.OptionsColumn.AllowFocus = false;
            this.operationNameCol.Visible = true;
            this.operationNameCol.VisibleIndex = 9;
            this.operationNameCol.Width = 92;
            // 
            // groupArchiveCol
            // 
            this.groupArchiveCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupArchiveCol.AppearanceHeader.Options.UseFont = true;
            this.groupArchiveCol.AppearanceHeader.Options.UseTextOptions = true;
            this.groupArchiveCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupArchiveCol.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.groupArchiveCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.groupArchiveCol.Caption = "Група";
            this.groupArchiveCol.FieldName = "GroupName";
            this.groupArchiveCol.Name = "groupArchiveCol";
            this.groupArchiveCol.OptionsColumn.AllowEdit = false;
            this.groupArchiveCol.OptionsColumn.AllowFocus = false;
            this.groupArchiveCol.Visible = true;
            this.groupArchiveCol.VisibleIndex = 10;
            this.groupArchiveCol.Width = 90;
            // 
            // operationStatus
            // 
            this.operationStatus.Caption = "status";
            this.operationStatus.FieldName = "OperationStatus";
            this.operationStatus.Name = "operationStatus";
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.showArchivBtn,
            this.deleteFromArchiveBtn,
            this.printArchiceBtn,
            this.beginDateArchiveEdit,
            this.endDateArchiveEdit,
            this.regArchiveBtn});
            this.ribbonControl2.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl2.MaxItemId = 12;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit2,
            this.repositoryItemDateEdit3,
            this.repositoryItemDateEdit4,
            this.repositoryItemDateEdit5});
            this.ribbonControl2.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl2.Size = new System.Drawing.Size(1372, 95);
            this.ribbonControl2.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // showArchivBtn
            // 
            this.showArchivBtn.Caption = "Показати";
            this.showArchivBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("showArchivBtn.Glyph")));
            this.showArchivBtn.Id = 3;
            this.showArchivBtn.Name = "showArchivBtn";
            this.showArchivBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.showArchivBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showArchivBtn_ItemClick);
            // 
            // deleteFromArchiveBtn
            // 
            this.deleteFromArchiveBtn.Caption = "Видалити із архіву";
            this.deleteFromArchiveBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteFromArchiveBtn.Glyph")));
            this.deleteFromArchiveBtn.Id = 4;
            this.deleteFromArchiveBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteFromArchiveBtn.LargeGlyph")));
            this.deleteFromArchiveBtn.Name = "deleteFromArchiveBtn";
            this.deleteFromArchiveBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
            toolTipTitleItem1.Text = "Для того щоб видалити з архіву необхідно у вкладці ОЗ обрати такий період, в яком" +
    "у поле \"Дата продажу..\" буде порожнє!";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.deleteFromArchiveBtn.SuperTip = superToolTip1;
            this.deleteFromArchiveBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteFromArchiveBtn_ItemClick);
            // 
            // printArchiceBtn
            // 
            this.printArchiceBtn.Caption = "Друк картки";
            this.printArchiceBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("printArchiceBtn.Glyph")));
            this.printArchiceBtn.Id = 5;
            this.printArchiceBtn.Name = "printArchiceBtn";
            this.printArchiceBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.printArchiceBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.printArchiceBtn_ItemClick);
            // 
            // beginDateArchiveEdit
            // 
            this.beginDateArchiveEdit.Caption = "З  ";
            this.beginDateArchiveEdit.Edit = this.repositoryItemDateEdit4;
            this.beginDateArchiveEdit.EditWidth = 100;
            this.beginDateArchiveEdit.Id = 9;
            this.beginDateArchiveEdit.Name = "beginDateArchiveEdit";
            // 
            // repositoryItemDateEdit4
            // 
            this.repositoryItemDateEdit4.AutoHeight = false;
            this.repositoryItemDateEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit4.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit4.Name = "repositoryItemDateEdit4";
            // 
            // endDateArchiveEdit
            // 
            this.endDateArchiveEdit.Caption = "по";
            this.endDateArchiveEdit.Edit = this.repositoryItemDateEdit5;
            this.endDateArchiveEdit.EditWidth = 100;
            this.endDateArchiveEdit.Id = 10;
            this.endDateArchiveEdit.Name = "endDateArchiveEdit";
            // 
            // repositoryItemDateEdit5
            // 
            this.repositoryItemDateEdit5.AutoHeight = false;
            this.repositoryItemDateEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit5.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit5.Name = "repositoryItemDateEdit5";
            // 
            // regArchiveBtn
            // 
            this.regArchiveBtn.Caption = "Регістрація наказу";
            this.regArchiveBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("regArchiveBtn.Glyph")));
            this.regArchiveBtn.Id = 11;
            this.regArchiveBtn.Name = "regArchiveBtn";
            this.regArchiveBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.regArchiveBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.regArchiveBtn_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup7});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.beginDateArchiveEdit);
            this.ribbonPageGroup5.ItemLinks.Add(this.endDateArchiveEdit);
            this.ribbonPageGroup5.ItemLinks.Add(this.showArchivBtn);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Період архіву";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.deleteFromArchiveBtn);
            this.ribbonPageGroup7.ItemLinks.Add(this.printArchiceBtn);
            this.ribbonPageGroup7.ItemLinks.Add(this.regArchiveBtn);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Керування архівом";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // repositoryItemDateEdit3
            // 
            this.repositoryItemDateEdit3.AutoHeight = false;
            this.repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
            // 
            // decreeItemMenu
            // 
            this.decreeItemMenu.Name = "decreeItemMenu";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.monthEdit);
            this.ribbonPageGroup6.ItemLinks.Add(this.yearEdit);
            this.ribbonPageGroup6.ItemLinks.Add(this.fixedAssesOrderShowBtn);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Період";
            // 
            // imageCollection
            // 
            this.imageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "32_bullet-green.png");
            this.imageCollection.Images.SetKeyName(1, "32_bullet-yellow.png");
            this.imageCollection.Images.SetKeyName(2, "32_bullet-red.png");
            this.imageCollection.Images.SetKeyName(3, "32_bullet-blue.png");
            // 
            // FixedAssetsOrderFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 682);
            this.Controls.Add(this.fixedAssessOrderTab);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Name = "FixedAssetsOrderFm";
            this.ShowIcon = false;
            this.Text = "Основні засоби";
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssessOrderTab)).EndInit();
            this.fixedAssessOrderTab.ResumeLayout(false);
            this.fixedAssestsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMonth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsOrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsOrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsMaterialsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsMaterialsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.arhivTabPage.ResumeLayout(false);
            this.arhivTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsArchiveGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsArchiveGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit5.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decreeItemMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl fixedAssessOrderTab;
        private DevExpress.XtraTab.XtraTabPage arhivTabPage;
        private DevExpress.XtraTab.XtraTabPage fixedAssestsTabPage;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl fixedAssetsOrderGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView fixedAssetsOrderGridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl fixedAssetsMaterialsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView fixedAssetsMaterialsGridView;
        private DevExpress.XtraBars.BarEditItem yearEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem monthEdit;
        private DevExpress.XtraScheduler.UI.RepositoryItemMonth repositoryItemMonth1;
        private DevExpress.XtraBars.BarButtonItem fixedAssesOrderShowBtn;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem editBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.BarButtonItem soldFixeAssetsBtn;
        private DevExpress.XtraBars.BarButtonItem transferFixeAssetsBtn;
        private DevExpress.XtraBars.PopupMenu decreeItemMenu;
        private DevExpress.XtraBars.BarButtonItem printBtn;
        private DevExpress.XtraBars.BarButtonItem actBtn;
        private DevExpress.XtraBars.BarButtonItem materialsBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraGrid.Columns.GridColumn transferCardCboxCol;
        private DevExpress.XtraGrid.Columns.GridColumn inventoryNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn inventoryNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn balanceAccountCol;
        private DevExpress.XtraGrid.Columns.GridColumn suppliersCol;
        private DevExpress.XtraGrid.Columns.GridColumn operatingPersonCol;
        private DevExpress.XtraGrid.Columns.GridColumn beginDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn beginPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn increasePriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn totalAmortizationCol;
        private DevExpress.XtraGrid.Columns.GridColumn currentPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn periodAmortizationCol;
        private DevExpress.XtraGrid.Columns.GridColumn periodYearAmortizationCol;
        private DevExpress.XtraGrid.Columns.GridColumn currentAmortizationCol;
        private DevExpress.XtraGrid.Columns.GridColumn endDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn endRegisterDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclatureCol;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn fixedNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn receiptNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn orderDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn orderNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn quantityCol;
        private DevExpress.XtraGrid.Columns.GridColumn untilPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn totalPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn eExpDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn priceCol;
        private DevExpress.XtraGrid.Columns.GridColumn fixedPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn flagNoteCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn flagCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem printInventoryCardBtn;
      //  private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Columns.GridColumn groupCol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraGrid.GridControl fixedAssetsArchiveGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView fixedAssetsArchiveGridView;
        private DevExpress.XtraGrid.Columns.GridColumn inventoryArchiveCol;
        private DevExpress.XtraGrid.Columns.GridColumn nameArchiveCol;
        private DevExpress.XtraGrid.Columns.GridColumn balanceAcNumArchiveCol;
        private DevExpress.XtraGrid.Columns.GridColumn SupplierNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn BeginDateArchiveCol;
        private DevExpress.XtraGrid.Columns.GridColumn usefulMonthArchiveCol;
        private DevExpress.XtraGrid.Columns.GridColumn transferPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn soldPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn operationNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn endRecordDateArchiveCol;
        private DevExpress.XtraGrid.Columns.GridColumn groupArchiveCol;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
        private DevExpress.XtraBars.BarButtonItem showArchivBtn;
        private DevExpress.XtraBars.BarButtonItem deleteFromArchiveBtn;
        private DevExpress.XtraBars.BarButtonItem printArchiceBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarEditItem beginDateArchiveEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit4;
        private DevExpress.XtraBars.BarEditItem endDateArchiveEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit5;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Columns.GridColumn operationStatus;
        private DevExpress.XtraBars.BarButtonItem regJournalOrderBtn;
        private DevExpress.XtraBars.BarButtonItem journalOrderBtn;
        private DevExpress.XtraBars.BarButtonItem regArchiveBtn;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem actWriteOffBtn;

    }
}