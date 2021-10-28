namespace ERP_NEW.GUI.BusinessTrips
{
    partial class BusinessTripsStatementPaymentSelectFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessTripsStatementPaymentSelectFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.employeesEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.accountNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fioCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.innCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.printStatementReportBtn = new DevExpress.XtraBars.BarButtonItem();
            this.cashEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.moneyEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.businessTripeStatementGrid = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.відмітитиУсіхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прибратиВідміткуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.businessTripeStatementGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.numberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paymentCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.identNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripeStatementGrid)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripeStatementGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addBtn,
            this.deleteBtn,
            this.barButtonItem1,
            this.barEditItem1,
            this.employeesEdit,
            this.printStatementReportBtn,
            this.cashEdit,
            this.moneyEdit});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemSearchLookUpEdit,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1283, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Додати виплату";
            this.addBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addBtn.Glyph")));
            this.addBtn.Id = 1;
            this.addBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addBtn.LargeGlyph")));
            this.addBtn.Name = "addBtn";
            this.addBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Видалити виплату";
            this.deleteBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Glyph")));
            this.deleteBtn.Id = 2;
            this.deleteBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteBtn.LargeGlyph")));
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Edit = this.repositoryItemGridLookUpEdit1;
            this.barEditItem1.EditWidth = 300;
            this.barEditItem1.Id = 5;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // employeesEdit
            // 
            this.employeesEdit.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.employeesEdit.Caption = "barEditItem2";
            this.employeesEdit.Edit = this.repositoryItemSearchLookUpEdit;
            this.employeesEdit.EditWidth = 340;
            this.employeesEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("employeesEdit.Glyph")));
            this.employeesEdit.Id = 6;
            this.employeesEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("employeesEdit.LargeGlyph")));
            this.employeesEdit.Name = "employeesEdit";
            this.employeesEdit.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // repositoryItemSearchLookUpEdit
            // 
            this.repositoryItemSearchLookUpEdit.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit.Name = "repositoryItemSearchLookUpEdit";
            this.repositoryItemSearchLookUpEdit.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.accountNumberCol,
            this.fioCol,
            this.innCol});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // accountNumberCol
            // 
            this.accountNumberCol.AppearanceCell.Options.UseTextOptions = true;
            this.accountNumberCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.accountNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountNumberCol.AppearanceHeader.Options.UseFont = true;
            this.accountNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.accountNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.accountNumberCol.Caption = "Табельний номер";
            this.accountNumberCol.FieldName = "AccountNumber";
            this.accountNumberCol.Name = "accountNumberCol";
            this.accountNumberCol.Visible = true;
            this.accountNumberCol.VisibleIndex = 0;
            this.accountNumberCol.Width = 50;
            // 
            // fioCol
            // 
            this.fioCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioCol.AppearanceHeader.Options.UseFont = true;
            this.fioCol.AppearanceHeader.Options.UseTextOptions = true;
            this.fioCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fioCol.Caption = "П.І.Б";
            this.fioCol.FieldName = "Fio";
            this.fioCol.Name = "fioCol";
            this.fioCol.Visible = true;
            this.fioCol.VisibleIndex = 1;
            // 
            // innCol
            // 
            this.innCol.AppearanceCell.Options.UseTextOptions = true;
            this.innCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.innCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.innCol.AppearanceHeader.Options.UseFont = true;
            this.innCol.AppearanceHeader.Options.UseTextOptions = true;
            this.innCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.innCol.Caption = "ІНН";
            this.innCol.FieldName = "IdentNumber";
            this.innCol.Name = "innCol";
            this.innCol.Visible = true;
            this.innCol.VisibleIndex = 2;
            this.innCol.Width = 50;
            // 
            // printStatementReportBtn
            // 
            this.printStatementReportBtn.Caption = "Друк відомості";
            this.printStatementReportBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("printStatementReportBtn.Glyph")));
            this.printStatementReportBtn.Id = 7;
            this.printStatementReportBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("printStatementReportBtn.LargeGlyph")));
            this.printStatementReportBtn.Name = "printStatementReportBtn";
            this.printStatementReportBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.printStatementReportBtn_ItemClick);
            // 
            // cashEdit
            // 
            this.cashEdit.Edit = this.repositoryItemTextEdit3;
            this.cashEdit.EditValue = 0;
            this.cashEdit.EditWidth = 340;
            this.cashEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("cashEdit.Glyph")));
            this.cashEdit.Id = 8;
            this.cashEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("cashEdit.LargeGlyph")));
            this.cashEdit.Name = "cashEdit";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Mask.EditMask = "n2";
            this.repositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            this.repositoryItemTextEdit3.NullText = "0";
            this.repositoryItemTextEdit3.NullValuePrompt = "0";
            // 
            // moneyEdit
            // 
            this.moneyEdit.Edit = this.repositoryItemTextEdit;
            this.moneyEdit.EditWidth = 340;
            this.moneyEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("moneyEdit.Glyph")));
            this.moneyEdit.Id = 9;
            this.moneyEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("moneyEdit.LargeGlyph")));
            this.moneyEdit.Name = "moneyEdit";
            // 
            // repositoryItemTextEdit
            // 
            this.repositoryItemTextEdit.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemTextEdit.AutoHeight = false;
            this.repositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit.Mask.ShowPlaceHolders = false;
            this.repositoryItemTextEdit.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit.Name = "repositoryItemTextEdit";
            this.repositoryItemTextEdit.NullText = "0,00";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.addBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.employeesEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.moneyEdit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Операції з виплатами";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.printStatementReportBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Функції";
            // 
            // businessTripeStatementGrid
            // 
            this.businessTripeStatementGrid.ContextMenuStrip = this.contextMenuStrip;
            this.businessTripeStatementGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.businessTripeStatementGrid.Location = new System.Drawing.Point(0, 95);
            this.businessTripeStatementGrid.MainView = this.businessTripeStatementGridView;
            this.businessTripeStatementGrid.Name = "businessTripeStatementGrid";
            this.businessTripeStatementGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit});
            this.businessTripeStatementGrid.Size = new System.Drawing.Size(1283, 460);
            this.businessTripeStatementGrid.TabIndex = 1;
            this.businessTripeStatementGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.businessTripeStatementGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відмітитиУсіхToolStripMenuItem,
            this.прибратиВідміткуToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.ShowItemToolTips = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(178, 48);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_ItemClicked);
            // 
            // відмітитиУсіхToolStripMenuItem
            // 
            this.відмітитиУсіхToolStripMenuItem.Name = "відмітитиУсіхToolStripMenuItem";
            this.відмітитиУсіхToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.відмітитиУсіхToolStripMenuItem.Text = "Відмітити усіх";
            // 
            // прибратиВідміткуToolStripMenuItem
            // 
            this.прибратиВідміткуToolStripMenuItem.Name = "прибратиВідміткуToolStripMenuItem";
            this.прибратиВідміткуToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.прибратиВідміткуToolStripMenuItem.Text = "Прибрати відмітки";
            // 
            // businessTripeStatementGridView
            // 
            this.businessTripeStatementGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.numberCol,
            this.nameCol,
            this.paymentCol,
            this.identNumberCol,
            this.checkCol});
            this.businessTripeStatementGridView.GridControl = this.businessTripeStatementGrid;
            this.businessTripeStatementGridView.Name = "businessTripeStatementGridView";
            this.businessTripeStatementGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.businessTripeStatementGridView.OptionsView.ShowFooter = true;
            // 
            // numberCol
            // 
            this.numberCol.AppearanceCell.Options.UseTextOptions = true;
            this.numberCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.numberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberCol.AppearanceHeader.Options.UseFont = true;
            this.numberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.numberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.numberCol.Caption = "Табельний номер";
            this.numberCol.FieldName = "AccountNumber";
            this.numberCol.Name = "numberCol";
            this.numberCol.OptionsColumn.AllowEdit = false;
            this.numberCol.OptionsColumn.AllowFocus = false;
            this.numberCol.Visible = true;
            this.numberCol.VisibleIndex = 1;
            this.numberCol.Width = 342;
            // 
            // nameCol
            // 
            this.nameCol.AppearanceCell.Options.UseTextOptions = true;
            this.nameCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCol.AppearanceHeader.Options.UseFont = true;
            this.nameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameCol.Caption = "П.І.Б";
            this.nameCol.FieldName = "Fio";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.AllowEdit = false;
            this.nameCol.OptionsColumn.AllowFocus = false;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 0;
            this.nameCol.Width = 253;
            // 
            // paymentCol
            // 
            this.paymentCol.AppearanceCell.Options.UseTextOptions = true;
            this.paymentCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paymentCol.AppearanceHeader.Options.UseFont = true;
            this.paymentCol.AppearanceHeader.Options.UseTextOptions = true;
            this.paymentCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.paymentCol.Caption = "Сума";
            this.paymentCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.paymentCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.paymentCol.FieldName = "CreditEnd";
            this.paymentCol.Name = "paymentCol";
            this.paymentCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CreditEnd", "{0:### ### ##0.00}")});
            this.paymentCol.Visible = true;
            this.paymentCol.VisibleIndex = 2;
            this.paymentCol.Width = 203;
            // 
            // identNumberCol
            // 
            this.identNumberCol.AppearanceCell.Options.UseTextOptions = true;
            this.identNumberCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.identNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.identNumberCol.AppearanceHeader.Options.UseFont = true;
            this.identNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.identNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.identNumberCol.Caption = "ІНН";
            this.identNumberCol.FieldName = "IdentNumber";
            this.identNumberCol.Name = "identNumberCol";
            this.identNumberCol.OptionsColumn.AllowEdit = false;
            this.identNumberCol.OptionsColumn.AllowFocus = false;
            this.identNumberCol.Visible = true;
            this.identNumberCol.VisibleIndex = 3;
            this.identNumberCol.Width = 415;
            // 
            // checkCol
            // 
            this.checkCol.AppearanceCell.Options.UseImage = true;
            this.checkCol.AppearanceCell.Options.UseTextOptions = true;
            this.checkCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.checkCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkCol.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("checkCol.AppearanceHeader.Image")));
            this.checkCol.AppearanceHeader.Options.UseImage = true;
            this.checkCol.AppearanceHeader.Options.UseTextOptions = true;
            this.checkCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.checkCol.ColumnEdit = this.repositoryItemCheckEdit;
            this.checkCol.FieldName = "Selected";
            this.checkCol.Image = ((System.Drawing.Image)(resources.GetObject("checkCol.Image")));
            this.checkCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.checkCol.Name = "checkCol";
            this.checkCol.OptionsColumn.ShowCaption = false;
            this.checkCol.Visible = true;
            this.checkCol.VisibleIndex = 4;
            this.checkCol.Width = 52;
            // 
            // repositoryItemCheckEdit
            // 
            this.repositoryItemCheckEdit.AutoHeight = false;
            this.repositoryItemCheckEdit.Name = "repositoryItemCheckEdit";
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // BusinessTripsStatementPaymentSelectFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 555);
            this.Controls.Add(this.businessTripeStatementGrid);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusinessTripsStatementPaymentSelectFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Відомість на виплату добових";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripeStatementGrid)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.businessTripeStatementGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl businessTripeStatementGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView businessTripeStatementGridView;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarEditItem employeesEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn accountNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn fioCol;
        private DevExpress.XtraGrid.Columns.GridColumn numberCol;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn paymentCol;
        private DevExpress.XtraGrid.Columns.GridColumn identNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn checkCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit;
        private DevExpress.XtraBars.BarButtonItem printStatementReportBtn;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Columns.GridColumn innCol;
        private DevExpress.XtraBars.BarEditItem cashEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraBars.BarEditItem moneyEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem відмітитиУсіхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прибратиВідміткуToolStripMenuItem;


    }
}