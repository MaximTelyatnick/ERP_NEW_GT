namespace ERP_NEW.GUI.StoreHouse
{
    partial class InvoiceRequirementSelectedEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceRequirementSelectedEditFm));
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.beginDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.endDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.showBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.firstDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.lastDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.viewBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.invoiceRequirementExpenditureInfoGrid = new DevExpress.XtraGrid.GridControl();
            this.invoiceRequirementExpenditureInfoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.selectedCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selectedRepository = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.nomenclatureCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitLocalNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receiptNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.debitNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.expDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.priceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.creditAccountCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.setkolCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.costumerOrderNumbersCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceRequirementExpenditureInfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceRequirementExpenditureInfoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedRepository)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemDateEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
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
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "MainMenu";
            // 
            // beginDateEdit
            // 
            this.beginDateEdit.Caption = "З";
            this.beginDateEdit.Edit = this.repositoryItemDateEdit1;
            this.beginDateEdit.EditWidth = 100;
            this.beginDateEdit.Id = 0;
            this.beginDateEdit.Name = "beginDateEdit";
            // 
            // endDateEdit
            // 
            this.endDateEdit.Caption = "По";
            this.endDateEdit.Edit = this.repositoryItemDateEdit2;
            this.endDateEdit.EditWidth = 100;
            this.endDateEdit.Id = 1;
            this.endDateEdit.Name = "endDateEdit";
            // 
            // showBtn
            // 
            this.showBtn.Caption = "Показати";
            this.showBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("showBtn.Glyph")));
            this.showBtn.Id = 2;
            this.showBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showBtn.LargeGlyph")));
            this.showBtn.Name = "showBtn";
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1443, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 560);
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControl1);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.firstDateEdit,
            this.lastDateEdit,
            this.viewBtn,
            this.barStaticItem2});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 6;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            // 
            // bar2
            // 
            this.bar2.BarName = "MainMenu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width))), this.firstDateEdit, "", true, true, true, 92, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.lastDateEdit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.viewBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "MainMenu";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = " Списання за період:";
            this.barStaticItem2.Id = 5;
            this.barStaticItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barStaticItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // firstDateEdit
            // 
            this.firstDateEdit.Caption = "з";
            this.firstDateEdit.Edit = this.repositoryItemDateEdit1;
            this.firstDateEdit.EditWidth = 180;
            this.firstDateEdit.Id = 0;
            this.firstDateEdit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstDateEdit.ItemAppearance.Hovered.Options.UseFont = true;
            this.firstDateEdit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstDateEdit.ItemAppearance.Normal.Options.UseFont = true;
            this.firstDateEdit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstDateEdit.ItemAppearance.Pressed.Options.UseFont = true;
            this.firstDateEdit.Name = "firstDateEdit";
            // 
            // lastDateEdit
            // 
            this.lastDateEdit.Caption = "по";
            this.lastDateEdit.Edit = this.repositoryItemDateEdit2;
            this.lastDateEdit.EditWidth = 100;
            this.lastDateEdit.Id = 1;
            this.lastDateEdit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastDateEdit.ItemAppearance.Hovered.Options.UseFont = true;
            this.lastDateEdit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastDateEdit.ItemAppearance.Normal.Options.UseFont = true;
            this.lastDateEdit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastDateEdit.ItemAppearance.Pressed.Options.UseFont = true;
            this.lastDateEdit.Name = "lastDateEdit";
            // 
            // viewBtn
            // 
            this.viewBtn.Caption = "Показати";
            this.viewBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("viewBtn.Glyph")));
            this.viewBtn.Id = 2;
            this.viewBtn.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewBtn.ItemAppearance.Hovered.Options.UseFont = true;
            this.viewBtn.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewBtn.ItemAppearance.Normal.Options.UseFont = true;
            this.viewBtn.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewBtn.ItemAppearance.Pressed.Options.UseFont = true;
            this.viewBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("viewBtn.LargeGlyph")));
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.viewBtn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1443, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 584);
            this.barDockControlBottom.Size = new System.Drawing.Size(1443, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 560);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1443, 24);
            this.barDockControl1.Size = new System.Drawing.Size(0, 560);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "За період ";
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // invoiceRequirementExpenditureInfoGrid
            // 
            this.invoiceRequirementExpenditureInfoGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invoiceRequirementExpenditureInfoGrid.Location = new System.Drawing.Point(0, 29);
            this.invoiceRequirementExpenditureInfoGrid.MainView = this.invoiceRequirementExpenditureInfoGridView;
            this.invoiceRequirementExpenditureInfoGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invoiceRequirementExpenditureInfoGrid.MenuManager = this.barManager;
            this.invoiceRequirementExpenditureInfoGrid.Name = "invoiceRequirementExpenditureInfoGrid";
            this.invoiceRequirementExpenditureInfoGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.selectedRepository});
            this.invoiceRequirementExpenditureInfoGrid.Size = new System.Drawing.Size(1431, 521);
            this.invoiceRequirementExpenditureInfoGrid.TabIndex = 15;
            this.invoiceRequirementExpenditureInfoGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.invoiceRequirementExpenditureInfoGridView});
            // 
            // invoiceRequirementExpenditureInfoGridView
            // 
            this.invoiceRequirementExpenditureInfoGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.selectedCol,
            this.nomenclatureCol,
            this.nameCol,
            this.unitLocalNameCol,
            this.receiptNumCol,
            this.orderDateCol,
            this.debitNumCol,
            this.expDateCol,
            this.priceCol,
            this.creditAccountCol,
            this.setkolCol,
            this.costumerOrderNumbersCol});
            this.invoiceRequirementExpenditureInfoGridView.GridControl = this.invoiceRequirementExpenditureInfoGrid;
            this.invoiceRequirementExpenditureInfoGridView.Name = "invoiceRequirementExpenditureInfoGridView";
            this.invoiceRequirementExpenditureInfoGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.invoiceRequirementExpenditureInfoGridView.OptionsView.ShowAutoFilterRow = true;
            this.invoiceRequirementExpenditureInfoGridView.OptionsView.ShowGroupPanel = false;
            // 
            // selectedCol
            // 
            this.selectedCol.AppearanceHeader.Options.UseTextOptions = true;
            this.selectedCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selectedCol.ColumnEdit = this.selectedRepository;
            this.selectedCol.FieldName = "Selected";
            this.selectedCol.Image = ((System.Drawing.Image)(resources.GetObject("selectedCol.Image")));
            this.selectedCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.selectedCol.Name = "selectedCol";
            this.selectedCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.selectedCol.Visible = true;
            this.selectedCol.VisibleIndex = 11;
            this.selectedCol.Width = 24;
            // 
            // selectedRepository
            // 
            this.selectedRepository.AutoHeight = false;
            this.selectedRepository.Name = "selectedRepository";
            // 
            // nomenclatureCol
            // 
            this.nomenclatureCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomenclatureCol.AppearanceHeader.Options.UseFont = true;
            this.nomenclatureCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureCol.Caption = "Номенкл. номер";
            this.nomenclatureCol.FieldName = "Nomenclature";
            this.nomenclatureCol.Name = "nomenclatureCol";
            this.nomenclatureCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureCol.OptionsColumn.AllowShowHide = false;
            this.nomenclatureCol.Visible = true;
            this.nomenclatureCol.VisibleIndex = 0;
            this.nomenclatureCol.Width = 152;
            // 
            // nameCol
            // 
            this.nameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCol.AppearanceHeader.Options.UseFont = true;
            this.nameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameCol.Caption = "Найменування";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.AllowEdit = false;
            this.nameCol.OptionsColumn.AllowFocus = false;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 1;
            this.nameCol.Width = 373;
            // 
            // unitLocalNameCol
            // 
            this.unitLocalNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitLocalNameCol.AppearanceHeader.Options.UseFont = true;
            this.unitLocalNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.unitLocalNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unitLocalNameCol.Caption = "Од. вим.";
            this.unitLocalNameCol.FieldName = "UnitLocalName";
            this.unitLocalNameCol.Name = "unitLocalNameCol";
            this.unitLocalNameCol.OptionsColumn.AllowEdit = false;
            this.unitLocalNameCol.OptionsColumn.AllowFocus = false;
            this.unitLocalNameCol.Visible = true;
            this.unitLocalNameCol.VisibleIndex = 2;
            this.unitLocalNameCol.Width = 83;
            // 
            // receiptNumCol
            // 
            this.receiptNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receiptNumCol.AppearanceHeader.Options.UseFont = true;
            this.receiptNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.receiptNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.receiptNumCol.Caption = "Номер надх.";
            this.receiptNumCol.FieldName = "ReceiptNum";
            this.receiptNumCol.Name = "receiptNumCol";
            this.receiptNumCol.OptionsColumn.AllowEdit = false;
            this.receiptNumCol.OptionsColumn.AllowFocus = false;
            this.receiptNumCol.Visible = true;
            this.receiptNumCol.VisibleIndex = 3;
            this.receiptNumCol.Width = 105;
            // 
            // orderDateCol
            // 
            this.orderDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderDateCol.AppearanceHeader.Options.UseFont = true;
            this.orderDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderDateCol.Caption = "Дата надх.";
            this.orderDateCol.FieldName = "OrderDate";
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.OptionsColumn.AllowEdit = false;
            this.orderDateCol.OptionsColumn.AllowFocus = false;
            this.orderDateCol.Visible = true;
            this.orderDateCol.VisibleIndex = 4;
            this.orderDateCol.Width = 114;
            // 
            // debitNumCol
            // 
            this.debitNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debitNumCol.AppearanceHeader.Options.UseFont = true;
            this.debitNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.debitNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.debitNumCol.Caption = "Дебет. рах.";
            this.debitNumCol.FieldName = "DebitNum";
            this.debitNumCol.Name = "debitNumCol";
            this.debitNumCol.OptionsColumn.AllowEdit = false;
            this.debitNumCol.OptionsColumn.AllowFocus = false;
            this.debitNumCol.Visible = true;
            this.debitNumCol.VisibleIndex = 5;
            this.debitNumCol.Width = 93;
            // 
            // expDateCol
            // 
            this.expDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expDateCol.AppearanceHeader.Options.UseFont = true;
            this.expDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.expDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.expDateCol.Caption = "Дата надх.";
            this.expDateCol.FieldName = "ExpDate";
            this.expDateCol.Name = "expDateCol";
            this.expDateCol.OptionsColumn.AllowEdit = false;
            this.expDateCol.OptionsColumn.AllowFocus = false;
            this.expDateCol.Visible = true;
            this.expDateCol.VisibleIndex = 6;
            this.expDateCol.Width = 93;
            // 
            // priceCol
            // 
            this.priceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceCol.AppearanceHeader.Options.UseFont = true;
            this.priceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.priceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.priceCol.Caption = "Сума надх.";
            this.priceCol.FieldName = "Price";
            this.priceCol.Name = "priceCol";
            this.priceCol.OptionsColumn.AllowEdit = false;
            this.priceCol.OptionsColumn.AllowFocus = false;
            this.priceCol.Visible = true;
            this.priceCol.VisibleIndex = 7;
            this.priceCol.Width = 86;
            // 
            // creditAccountCol
            // 
            this.creditAccountCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creditAccountCol.AppearanceHeader.Options.UseFont = true;
            this.creditAccountCol.AppearanceHeader.Options.UseTextOptions = true;
            this.creditAccountCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.creditAccountCol.Caption = "Кредит. рах.";
            this.creditAccountCol.FieldName = "CreditAccount";
            this.creditAccountCol.Name = "creditAccountCol";
            this.creditAccountCol.OptionsColumn.AllowEdit = false;
            this.creditAccountCol.OptionsColumn.AllowFocus = false;
            this.creditAccountCol.Visible = true;
            this.creditAccountCol.VisibleIndex = 8;
            this.creditAccountCol.Width = 88;
            // 
            // setkolCol
            // 
            this.setkolCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setkolCol.AppearanceHeader.Options.UseFont = true;
            this.setkolCol.AppearanceHeader.Options.UseTextOptions = true;
            this.setkolCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.setkolCol.Caption = "Кількість";
            this.setkolCol.FieldName = "Setkol";
            this.setkolCol.Name = "setkolCol";
            this.setkolCol.OptionsColumn.AllowEdit = false;
            this.setkolCol.OptionsColumn.AllowFocus = false;
            this.setkolCol.Visible = true;
            this.setkolCol.VisibleIndex = 9;
            this.setkolCol.Width = 80;
            // 
            // costumerOrderNumbersCol
            // 
            this.costumerOrderNumbersCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costumerOrderNumbersCol.AppearanceHeader.Options.UseFont = true;
            this.costumerOrderNumbersCol.AppearanceHeader.Options.UseTextOptions = true;
            this.costumerOrderNumbersCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.costumerOrderNumbersCol.Caption = "Закази";
            this.costumerOrderNumbersCol.FieldName = "CustomerOrderNumbers";
            this.costumerOrderNumbersCol.Name = "costumerOrderNumbersCol";
            this.costumerOrderNumbersCol.Visible = true;
            this.costumerOrderNumbersCol.VisibleIndex = 10;
            this.costumerOrderNumbersCol.Width = 122;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(1356, 555);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 19;
            this.cancelBtn.Text = "Відмінити";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(1275, 555);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 18;
            this.okBtn.Text = "Вибрати";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // InvoiceRequirementSelectedEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 584);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.invoiceRequirementExpenditureInfoGrid);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceRequirementSelectedEditFm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Матеріали";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceRequirementExpenditureInfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceRequirementExpenditureInfoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedRepository)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarEditItem beginDateEdit;
        private DevExpress.XtraBars.BarEditItem endDateEdit;
        private DevExpress.XtraBars.BarButtonItem showBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarEditItem firstDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem lastDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem viewBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraGrid.GridControl invoiceRequirementExpenditureInfoGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView invoiceRequirementExpenditureInfoGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit selectedRepository;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclatureCol;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn unitLocalNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn receiptNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn orderDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn debitNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn expDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn priceCol;
        private DevExpress.XtraGrid.Columns.GridColumn creditAccountCol;
        private DevExpress.XtraGrid.Columns.GridColumn setkolCol;
        private DevExpress.XtraGrid.Columns.GridColumn selectedCol;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton okBtn;
        private DevExpress.XtraGrid.Columns.GridColumn costumerOrderNumbersCol;
    }
}