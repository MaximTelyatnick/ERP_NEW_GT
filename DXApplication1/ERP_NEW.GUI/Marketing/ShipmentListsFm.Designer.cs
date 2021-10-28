namespace ERP_NEW.GUI.Marketing
{
    partial class ShipmentListsFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipmentListsFm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addActBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editActBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteActBtn = new DevExpress.XtraBars.BarButtonItem();
            this.showItem = new DevExpress.XtraBars.BarButtonItem();
            this.addDocumentItem = new DevExpress.XtraBars.BarButtonItem();
            this.editDocumentItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteDocumentItem = new DevExpress.XtraBars.BarButtonItem();
            this.beginDateEditItem = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.endDateEditItem = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.shipmentListsGrid = new DevExpress.XtraGrid.GridControl();
            this.shipmentListsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.actNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.actDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descriptionCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.informationCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.showBtnRepository = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.documentTypeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentListsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentListsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtnRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ribbonControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1408, 96);
            this.panelControl1.TabIndex = 0;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addActBtn,
            this.editActBtn,
            this.deleteActBtn,
            this.showItem,
            this.addDocumentItem,
            this.editDocumentItem,
            this.deleteDocumentItem,
            this.beginDateEditItem,
            this.endDateEditItem,
            this.refreshBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(2, 2);
            this.ribbonControl1.MaxItemId = 31;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1404, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // addActBtn
            // 
            this.addActBtn.Caption = "Додати";
            this.addActBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addActBtn.Glyph")));
            this.addActBtn.Id = 13;
            this.addActBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addActBtn.LargeGlyph")));
            this.addActBtn.Name = "addActBtn";
            this.addActBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addActBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addActBtn_ItemClick);
            // 
            // editActBtn
            // 
            this.editActBtn.Caption = "Редагувати";
            this.editActBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editActBtn.Glyph")));
            this.editActBtn.Id = 14;
            this.editActBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editActBtn.LargeGlyph")));
            this.editActBtn.Name = "editActBtn";
            this.editActBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.editActBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editActBtn_ItemClick);
            // 
            // deleteActBtn
            // 
            this.deleteActBtn.Caption = "Видалити";
            this.deleteActBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteActBtn.Glyph")));
            this.deleteActBtn.Id = 15;
            this.deleteActBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteActBtn.LargeGlyph")));
            this.deleteActBtn.Name = "deleteActBtn";
            this.deleteActBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deleteActBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteActBtn_ItemClick);
            // 
            // showItem
            // 
            this.showItem.Caption = "Показати";
            this.showItem.Glyph = ((System.Drawing.Image)(resources.GetObject("showItem.Glyph")));
            this.showItem.Id = 19;
            this.showItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showItem.LargeGlyph")));
            this.showItem.Name = "showItem";
            this.showItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.showItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showItem_ItemClick);
            // 
            // addDocumentItem
            // 
            this.addDocumentItem.Caption = "Прикріпити";
            this.addDocumentItem.Glyph = ((System.Drawing.Image)(resources.GetObject("addDocumentItem.Glyph")));
            this.addDocumentItem.Id = 23;
            this.addDocumentItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addDocumentItem.LargeGlyph")));
            this.addDocumentItem.Name = "addDocumentItem";
            this.addDocumentItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // editDocumentItem
            // 
            this.editDocumentItem.Caption = "Редагувати";
            this.editDocumentItem.Glyph = ((System.Drawing.Image)(resources.GetObject("editDocumentItem.Glyph")));
            this.editDocumentItem.Id = 24;
            this.editDocumentItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editDocumentItem.LargeGlyph")));
            this.editDocumentItem.Name = "editDocumentItem";
            this.editDocumentItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // deleteDocumentItem
            // 
            this.deleteDocumentItem.Caption = "Видалити";
            this.deleteDocumentItem.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteDocumentItem.Glyph")));
            this.deleteDocumentItem.Id = 25;
            this.deleteDocumentItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteDocumentItem.LargeGlyph")));
            this.deleteDocumentItem.Name = "deleteDocumentItem";
            this.deleteDocumentItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // beginDateEditItem
            // 
            this.beginDateEditItem.Caption = "Початкова дата";
            this.beginDateEditItem.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.beginDateEditItem.Edit = this.repositoryItemDateEdit1;
            this.beginDateEditItem.EditWidth = 100;
            this.beginDateEditItem.Id = 28;
            this.beginDateEditItem.Name = "beginDateEditItem";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // endDateEditItem
            // 
            this.endDateEditItem.Caption = "Кінцева дата";
            this.endDateEditItem.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.endDateEditItem.Edit = this.repositoryItemDateEdit2;
            this.endDateEditItem.EditWidth = 100;
            this.endDateEditItem.Id = 29;
            this.endDateEditItem.Name = "endDateEditItem";
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
            // refreshBtn
            // 
            this.refreshBtn.Caption = "Поновити";
            this.refreshBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Glyph")));
            this.refreshBtn.Id = 30;
            this.refreshBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("refreshBtn.LargeGlyph")));
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.refreshBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.beginDateEditItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.endDateEditItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.showItem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Фільтр";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.addActBtn);
            this.ribbonPageGroup3.ItemLinks.Add(this.editActBtn);
            this.ribbonPageGroup3.ItemLinks.Add(this.deleteActBtn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Документи на відвантаження";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.refreshBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Функції";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // shipmentListsGrid
            // 
            this.shipmentListsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipmentListsGrid.Location = new System.Drawing.Point(0, 96);
            this.shipmentListsGrid.MainView = this.shipmentListsGridView;
            this.shipmentListsGrid.Name = "shipmentListsGrid";
            this.shipmentListsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.showBtnRepository});
            this.shipmentListsGrid.Size = new System.Drawing.Size(1408, 546);
            this.shipmentListsGrid.TabIndex = 1;
            this.shipmentListsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.shipmentListsGridView});
            // 
            // shipmentListsGridView
            // 
            this.shipmentListsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.actNumberCol,
            this.actDateCol,
            this.orderNumberCol,
            this.orderDateCol,
            this.descriptionCol,
            this.informationCol,
            this.documentTypeCol});
            this.shipmentListsGridView.GridControl = this.shipmentListsGrid;
            this.shipmentListsGridView.Name = "shipmentListsGridView";
            this.shipmentListsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.shipmentListsGridView.OptionsView.ShowAutoFilterRow = true;
            this.shipmentListsGridView.OptionsView.ShowGroupPanel = false;
            this.shipmentListsGridView.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.shipmentListsGridView_CustomRowCellEdit);
            this.shipmentListsGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.shipmentListsGridView_CustomUnboundColumnData);
            // 
            // actNumberCol
            // 
            this.actNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.actNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.actNumberCol.Caption = "№ документу";
            this.actNumberCol.FieldName = "ShipmentNumber";
            this.actNumberCol.Name = "actNumberCol";
            this.actNumberCol.OptionsColumn.AllowEdit = false;
            this.actNumberCol.OptionsColumn.AllowFocus = false;
            this.actNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.actNumberCol.Visible = true;
            this.actNumberCol.VisibleIndex = 0;
            this.actNumberCol.Width = 161;
            // 
            // actDateCol
            // 
            this.actDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.actDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.actDateCol.Caption = "Дата документу";
            this.actDateCol.FieldName = "ShipmentDate";
            this.actDateCol.Name = "actDateCol";
            this.actDateCol.OptionsColumn.AllowEdit = false;
            this.actDateCol.OptionsColumn.AllowFocus = false;
            this.actDateCol.Visible = true;
            this.actDateCol.VisibleIndex = 1;
            this.actDateCol.Width = 103;
            // 
            // orderNumberCol
            // 
            this.orderNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderNumberCol.Caption = "Номер заказу";
            this.orderNumberCol.FieldName = "OrderNumber";
            this.orderNumberCol.Name = "orderNumberCol";
            this.orderNumberCol.OptionsColumn.AllowEdit = false;
            this.orderNumberCol.OptionsColumn.AllowFocus = false;
            this.orderNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.orderNumberCol.Visible = true;
            this.orderNumberCol.VisibleIndex = 2;
            this.orderNumberCol.Width = 161;
            // 
            // orderDateCol
            // 
            this.orderDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderDateCol.Caption = "Дата заказу";
            this.orderDateCol.FieldName = "OrderDate";
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.OptionsColumn.AllowEdit = false;
            this.orderDateCol.OptionsColumn.AllowFocus = false;
            this.orderDateCol.Visible = true;
            this.orderDateCol.VisibleIndex = 3;
            this.orderDateCol.Width = 102;
            // 
            // descriptionCol
            // 
            this.descriptionCol.AppearanceHeader.Options.UseTextOptions = true;
            this.descriptionCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.descriptionCol.Caption = "Додаткова інформація";
            this.descriptionCol.FieldName = "Description";
            this.descriptionCol.Name = "descriptionCol";
            this.descriptionCol.OptionsColumn.AllowEdit = false;
            this.descriptionCol.OptionsColumn.AllowFocus = false;
            this.descriptionCol.Visible = true;
            this.descriptionCol.VisibleIndex = 4;
            this.descriptionCol.Width = 632;
            // 
            // informationCol
            // 
            this.informationCol.AppearanceHeader.Options.UseTextOptions = true;
            this.informationCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.informationCol.Caption = "Файл";
            this.informationCol.ColumnEdit = this.showBtnRepository;
            this.informationCol.FieldName = "informationCol";
            this.informationCol.Name = "informationCol";
            this.informationCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.informationCol.Visible = true;
            this.informationCol.VisibleIndex = 6;
            this.informationCol.Width = 86;
            // 
            // showBtnRepository
            // 
            this.showBtnRepository.AutoHeight = false;
            this.showBtnRepository.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("showBtnRepository.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.showBtnRepository.Name = "showBtnRepository";
            this.showBtnRepository.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.showBtnRepository.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.showBtnRepository_ButtonClick);
            // 
            // documentTypeCol
            // 
            this.documentTypeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.documentTypeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.documentTypeCol.Caption = "Тип документу";
            this.documentTypeCol.FieldName = "DocumentTypeName";
            this.documentTypeCol.Name = "documentTypeCol";
            this.documentTypeCol.OptionsColumn.AllowEdit = false;
            this.documentTypeCol.OptionsColumn.AllowFocus = false;
            this.documentTypeCol.Visible = true;
            this.documentTypeCol.VisibleIndex = 5;
            this.documentTypeCol.Width = 145;
            // 
            // columnCollection
            // 
            this.columnCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("columnCollection.ImageStream")));
            this.columnCollection.InsertGalleryImage("attach_16x16.png", "images/mail/attach_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/attach_16x16.png"), 0);
            this.columnCollection.Images.SetKeyName(0, "attach_16x16.png");
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // ShipmentListsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 642);
            this.Controls.Add(this.shipmentListsGrid);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShipmentListsFm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Документи на відвантаження";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentListsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentListsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBtnRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem addActBtn;
        private DevExpress.XtraBars.BarButtonItem editActBtn;
        private DevExpress.XtraBars.BarButtonItem deleteActBtn;
        private DevExpress.XtraBars.BarButtonItem showItem;
        private DevExpress.XtraBars.BarButtonItem addDocumentItem;
        private DevExpress.XtraBars.BarButtonItem editDocumentItem;
        private DevExpress.XtraBars.BarButtonItem deleteDocumentItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraGrid.GridControl shipmentListsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView shipmentListsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn orderNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn orderDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn actNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn actDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn descriptionCol;
        private DevExpress.XtraGrid.Columns.GridColumn informationCol;
        private DevExpress.XtraGrid.Columns.GridColumn documentTypeCol;
        private DevExpress.Utils.ImageCollection columnCollection;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraBars.BarEditItem beginDateEditItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem endDateEditItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit showBtnRepository;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}