namespace ERP_NEW.GUI.CustomerOrders
{
    partial class AgreementOrderJournalFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgreementOrderJournalFm));
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.firstDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.lastDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.showBtn = new DevExpress.XtraBars.BarButtonItem();
            this.exportToExcelBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.firstDateBusinessTripEdit = new DevExpress.XtraBars.BarEditItem();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.agreementOrderGrid = new DevExpress.XtraGrid.GridControl();
            this.agreementOrderGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.agreementOrderNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.agreementOrderDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.сontractorNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.agreementNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.purposeNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.priceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.currencyNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.responsibleNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.scanCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreementOrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreementOrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit)).BeginInit();
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
            this.addBtn,
            this.editBtn,
            this.deleteBtn,
            this.firstDateEdit,
            this.lastDateEdit,
            this.showBtn,
            this.exportToExcelBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1257, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Додати";
            this.addBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addBtn.Glyph")));
            this.addBtn.Id = 1;
            this.addBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addBtn.LargeGlyph")));
            this.addBtn.Name = "addBtn";
            this.addBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBtn_ItemClick);
            // 
            // editBtn
            // 
            this.editBtn.Caption = "Редагувати";
            this.editBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editBtn.Glyph")));
            this.editBtn.Id = 2;
            this.editBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editBtn.LargeGlyph")));
            this.editBtn.Name = "editBtn";
            this.editBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Видалити";
            this.deleteBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Glyph")));
            this.deleteBtn.Id = 3;
            this.deleteBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteBtn.LargeGlyph")));
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // firstDateEdit
            // 
            this.firstDateEdit.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.firstDateEdit.Caption = "  Початкова дата";
            this.firstDateEdit.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.firstDateEdit.Edit = this.repositoryItemDateEdit1;
            this.firstDateEdit.EditWidth = 100;
            this.firstDateEdit.Id = 4;
            this.firstDateEdit.Name = "firstDateEdit";
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
            // lastDateEdit
            // 
            this.lastDateEdit.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.lastDateEdit.Caption = "  Кінцева дата";
            this.lastDateEdit.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lastDateEdit.Edit = this.repositoryItemDateEdit2;
            this.lastDateEdit.EditWidth = 100;
            this.lastDateEdit.Id = 5;
            this.lastDateEdit.Name = "lastDateEdit";
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
            // showBtn
            // 
            this.showBtn.Caption = "Показати";
            this.showBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("showBtn.Glyph")));
            this.showBtn.Id = 6;
            this.showBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showBtn.LargeGlyph")));
            this.showBtn.Name = "showBtn";
            this.showBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.showBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showBtn_ItemClick);
            // 
            // exportToExcelBtn
            // 
            this.exportToExcelBtn.Caption = "Експортувати в Excel";
            this.exportToExcelBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("exportToExcelBtn.Glyph")));
            this.exportToExcelBtn.Id = 7;
            this.exportToExcelBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("exportToExcelBtn.LargeGlyph")));
            this.exportToExcelBtn.Name = "exportToExcelBtn";
            this.exportToExcelBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exportToExcelBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.firstDateEdit);
            this.ribbonPageGroup2.ItemLinks.Add(this.lastDateEdit);
            this.ribbonPageGroup2.ItemLinks.Add(this.showBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Період";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.addBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.editBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Рахунок";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.exportToExcelBtn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Функції";
            // 
            // firstDateBusinessTripEdit
            // 
            this.firstDateBusinessTripEdit.Caption = "Початкова дата ";
            this.firstDateBusinessTripEdit.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.firstDateBusinessTripEdit.Edit = null;
            this.firstDateBusinessTripEdit.EditWidth = 100;
            this.firstDateBusinessTripEdit.Id = 4;
            this.firstDateBusinessTripEdit.Name = "firstDateBusinessTripEdit";
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("picturebox_16x16.png", "images/toolbox%20items/picturebox_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/toolbox%20items/picturebox_16x16.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "picturebox_16x16.png");
            this.imageCollection.InsertGalleryImage("new_16x16.png", "office2013/actions/new_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/new_16x16.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "new_16x16.png");
            // 
            // agreementOrderGrid
            // 
            this.agreementOrderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agreementOrderGrid.Location = new System.Drawing.Point(0, 95);
            this.agreementOrderGrid.MainView = this.agreementOrderGridView;
            this.agreementOrderGrid.MenuManager = this.ribbonControl1;
            this.agreementOrderGrid.Name = "agreementOrderGrid";
            this.agreementOrderGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit});
            this.agreementOrderGrid.Size = new System.Drawing.Size(1257, 469);
            this.agreementOrderGrid.TabIndex = 3;
            this.agreementOrderGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.agreementOrderGridView});
            // 
            // agreementOrderGridView
            // 
            this.agreementOrderGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.agreementOrderNumberCol,
            this.agreementOrderDateCol,
            this.сontractorNameCol,
            this.agreementNameCol,
            this.purposeNameCol,
            this.priceCol,
            this.currencyNameCol,
            this.responsibleNameCol,
            this.scanCol});
            this.agreementOrderGridView.GridControl = this.agreementOrderGrid;
            this.agreementOrderGridView.Name = "agreementOrderGridView";
            this.agreementOrderGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.agreementOrderGridView.OptionsView.ShowAutoFilterRow = true;
            this.agreementOrderGridView.OptionsView.ShowFooter = true;
            this.agreementOrderGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.agreementOrderGridView_CustomUnboundColumnData);
            this.agreementOrderGridView.DoubleClick += new System.EventHandler(this.agreementOrderGridView_DoubleClick);
            // 
            // agreementOrderNumberCol
            // 
            this.agreementOrderNumberCol.AppearanceCell.Options.UseTextOptions = true;
            this.agreementOrderNumberCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.agreementOrderNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agreementOrderNumberCol.AppearanceHeader.Options.UseFont = true;
            this.agreementOrderNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.agreementOrderNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.agreementOrderNumberCol.Caption = "Номер рахунку";
            this.agreementOrderNumberCol.FieldName = "AgreementOrderNumber";
            this.agreementOrderNumberCol.Name = "agreementOrderNumberCol";
            this.agreementOrderNumberCol.OptionsColumn.AllowEdit = false;
            this.agreementOrderNumberCol.OptionsColumn.AllowFocus = false;
            this.agreementOrderNumberCol.Visible = true;
            this.agreementOrderNumberCol.VisibleIndex = 0;
            this.agreementOrderNumberCol.Width = 114;
            // 
            // agreementOrderDateCol
            // 
            this.agreementOrderDateCol.AppearanceCell.Options.UseTextOptions = true;
            this.agreementOrderDateCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.agreementOrderDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agreementOrderDateCol.AppearanceHeader.Options.UseFont = true;
            this.agreementOrderDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.agreementOrderDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.agreementOrderDateCol.Caption = "Дата ";
            this.agreementOrderDateCol.FieldName = "AgreementOrderDate";
            this.agreementOrderDateCol.Name = "agreementOrderDateCol";
            this.agreementOrderDateCol.OptionsColumn.AllowEdit = false;
            this.agreementOrderDateCol.OptionsColumn.AllowFocus = false;
            this.agreementOrderDateCol.Visible = true;
            this.agreementOrderDateCol.VisibleIndex = 1;
            this.agreementOrderDateCol.Width = 63;
            // 
            // сontractorNameCol
            // 
            this.сontractorNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сontractorNameCol.AppearanceHeader.Options.UseFont = true;
            this.сontractorNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.сontractorNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.сontractorNameCol.Caption = "Контрагент";
            this.сontractorNameCol.FieldName = "ContractorName";
            this.сontractorNameCol.Name = "сontractorNameCol";
            this.сontractorNameCol.OptionsColumn.AllowEdit = false;
            this.сontractorNameCol.OptionsColumn.AllowFocus = false;
            this.сontractorNameCol.Visible = true;
            this.сontractorNameCol.VisibleIndex = 2;
            this.сontractorNameCol.Width = 281;
            // 
            // agreementNameCol
            // 
            this.agreementNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agreementNameCol.AppearanceHeader.Options.UseFont = true;
            this.agreementNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.agreementNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.agreementNameCol.Caption = "Договір";
            this.agreementNameCol.FieldName = "AgreementName";
            this.agreementNameCol.Name = "agreementNameCol";
            this.agreementNameCol.OptionsColumn.AllowEdit = false;
            this.agreementNameCol.OptionsColumn.AllowFocus = false;
            this.agreementNameCol.Visible = true;
            this.agreementNameCol.VisibleIndex = 3;
            this.agreementNameCol.Width = 257;
            // 
            // purposeNameCol
            // 
            this.purposeNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purposeNameCol.AppearanceHeader.Options.UseFont = true;
            this.purposeNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.purposeNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.purposeNameCol.Caption = "Підстава";
            this.purposeNameCol.FieldName = "PurposeName";
            this.purposeNameCol.Name = "purposeNameCol";
            this.purposeNameCol.OptionsColumn.AllowEdit = false;
            this.purposeNameCol.OptionsColumn.AllowFocus = false;
            this.purposeNameCol.Visible = true;
            this.purposeNameCol.VisibleIndex = 4;
            this.purposeNameCol.Width = 156;
            // 
            // priceCol
            // 
            this.priceCol.AppearanceCell.Options.UseTextOptions = true;
            this.priceCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.priceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceCol.AppearanceHeader.Options.UseFont = true;
            this.priceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.priceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.priceCol.Caption = "Сума";
            this.priceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.priceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.priceCol.FieldName = "Price";
            this.priceCol.Name = "priceCol";
            this.priceCol.OptionsColumn.AllowEdit = false;
            this.priceCol.OptionsColumn.AllowFocus = false;
            this.priceCol.Visible = true;
            this.priceCol.VisibleIndex = 5;
            this.priceCol.Width = 81;
            // 
            // currencyNameCol
            // 
            this.currencyNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currencyNameCol.AppearanceHeader.Options.UseFont = true;
            this.currencyNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.currencyNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.currencyNameCol.Caption = "Валюта";
            this.currencyNameCol.FieldName = "CurrencyName";
            this.currencyNameCol.Name = "currencyNameCol";
            this.currencyNameCol.OptionsColumn.AllowEdit = false;
            this.currencyNameCol.OptionsColumn.AllowFocus = false;
            this.currencyNameCol.Visible = true;
            this.currencyNameCol.VisibleIndex = 6;
            this.currencyNameCol.Width = 66;
            // 
            // responsibleNameCol
            // 
            this.responsibleNameCol.AppearanceCell.Options.UseTextOptions = true;
            this.responsibleNameCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.responsibleNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.responsibleNameCol.AppearanceHeader.Options.UseFont = true;
            this.responsibleNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.responsibleNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.responsibleNameCol.Caption = "Відповідальна особа";
            this.responsibleNameCol.FieldName = "ResponsibleName";
            this.responsibleNameCol.Name = "responsibleNameCol";
            this.responsibleNameCol.OptionsColumn.AllowEdit = false;
            this.responsibleNameCol.OptionsColumn.AllowFocus = false;
            this.responsibleNameCol.Visible = true;
            this.responsibleNameCol.VisibleIndex = 7;
            this.responsibleNameCol.Width = 185;
            // 
            // scanCol
            // 
            this.scanCol.AppearanceHeader.Options.UseTextOptions = true;
            this.scanCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.scanCol.ColumnEdit = this.repositoryItemPictureEdit;
            this.scanCol.FieldName = "AgreementOrderScanStatus";
            this.scanCol.Image = ((System.Drawing.Image)(resources.GetObject("scanCol.Image")));
            this.scanCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.scanCol.Name = "scanCol";
            this.scanCol.OptionsColumn.ReadOnly = true;
            this.scanCol.OptionsColumn.ShowCaption = false;
            this.scanCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.scanCol.Visible = true;
            this.scanCol.VisibleIndex = 8;
            this.scanCol.Width = 36;
            // 
            // repositoryItemPictureEdit
            // 
            this.repositoryItemPictureEdit.Name = "repositoryItemPictureEdit";
            this.repositoryItemPictureEdit.NullText = " ";
            this.repositoryItemPictureEdit.ZoomAccelerationFactor = 1D;
            this.repositoryItemPictureEdit.DoubleClick += new System.EventHandler(this.repositoryItemPictureEdit_DoubleClick);
            // 
            // AgreementOrderJournalFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 564);
            this.Controls.Add(this.agreementOrderGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "AgreementOrderJournalFm";
            this.ShowIcon = false;
            this.Text = "Рахунки";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreementOrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreementOrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit)).EndInit();
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
        private DevExpress.XtraBars.BarEditItem firstDateBusinessTripEdit;
        private DevExpress.XtraBars.BarEditItem firstDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem lastDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem showBtn;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraGrid.GridControl agreementOrderGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView agreementOrderGridView;
        private DevExpress.XtraGrid.Columns.GridColumn scanCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit;
        private DevExpress.XtraGrid.Columns.GridColumn agreementOrderNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn agreementOrderDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn сontractorNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn agreementNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn purposeNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn priceCol;
        private DevExpress.XtraGrid.Columns.GridColumn currencyNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn responsibleNameCol;
        private DevExpress.XtraBars.BarButtonItem exportToExcelBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}