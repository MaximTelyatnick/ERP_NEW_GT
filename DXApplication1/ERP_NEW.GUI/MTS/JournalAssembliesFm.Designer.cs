namespace ERP_NEW.GUI.MTS
{
    partial class JournalAssembliesFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalAssembliesFm));
            this.journalAssembliesGrid = new DevExpress.XtraGrid.GridControl();
            this.journalAssembliesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.drawingCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descriptionCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateCreatedCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.designerNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contractorNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.countryNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cityNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.beginDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.endDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.showBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addOrderBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editOrderBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteOrderBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.journalAssembliesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalAssembliesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // journalAssembliesGrid
            // 
            this.journalAssembliesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journalAssembliesGrid.Location = new System.Drawing.Point(0, 95);
            this.journalAssembliesGrid.MainView = this.journalAssembliesGridView;
            this.journalAssembliesGrid.Name = "journalAssembliesGrid";
            this.journalAssembliesGrid.Size = new System.Drawing.Size(1351, 550);
            this.journalAssembliesGrid.TabIndex = 1;
            this.journalAssembliesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.journalAssembliesGridView});
            // 
            // journalAssembliesGridView
            // 
            this.journalAssembliesGridView.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.journalAssembliesGridView.Appearance.FooterPanel.Options.UseFont = true;
            this.journalAssembliesGridView.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.journalAssembliesGridView.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.journalAssembliesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.drawingCol,
            this.nameCol,
            this.descriptionCol,
            this.dateCreatedCol,
            this.designerNameCol,
            this.userNameCol,
            this.contractorNameCol,
            this.countryNameCol,
            this.cityNameCol});
            this.journalAssembliesGridView.GridControl = this.journalAssembliesGrid;
            this.journalAssembliesGridView.Name = "journalAssembliesGridView";
            this.journalAssembliesGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.journalAssembliesGridView.OptionsView.ShowAutoFilterRow = true;
            this.journalAssembliesGridView.OptionsView.ShowFooter = true;
            this.journalAssembliesGridView.OptionsView.ShowGroupPanel = false;
            this.journalAssembliesGridView.DoubleClick += new System.EventHandler(this.journalAssembliesGridView_DoubleClick);
            // 
            // drawingCol
            // 
            this.drawingCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.drawingCol.AppearanceHeader.Options.UseFont = true;
            this.drawingCol.AppearanceHeader.Options.UseTextOptions = true;
            this.drawingCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.drawingCol.Caption = "Номер креслення виробу";
            this.drawingCol.FieldName = "Drawing";
            this.drawingCol.Name = "drawingCol";
            this.drawingCol.OptionsColumn.AllowEdit = false;
            this.drawingCol.OptionsColumn.AllowFocus = false;
            this.drawingCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Drawing", "Всього: {0}")});
            this.drawingCol.Visible = true;
            this.drawingCol.VisibleIndex = 0;
            this.drawingCol.Width = 170;
            // 
            // nameCol
            // 
            this.nameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nameCol.AppearanceHeader.Options.UseFont = true;
            this.nameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameCol.Caption = "Наіменування виробу";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.AllowEdit = false;
            this.nameCol.OptionsColumn.AllowFocus = false;
            this.nameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 1;
            this.nameCol.Width = 360;
            // 
            // descriptionCol
            // 
            this.descriptionCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.descriptionCol.AppearanceHeader.Options.UseFont = true;
            this.descriptionCol.AppearanceHeader.Options.UseTextOptions = true;
            this.descriptionCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.descriptionCol.Caption = "Додаткова інформація";
            this.descriptionCol.FieldName = "Description";
            this.descriptionCol.Name = "descriptionCol";
            this.descriptionCol.OptionsColumn.AllowEdit = false;
            this.descriptionCol.OptionsColumn.AllowFocus = false;
            this.descriptionCol.Visible = true;
            this.descriptionCol.VisibleIndex = 6;
            this.descriptionCol.Width = 172;
            // 
            // dateCreatedCol
            // 
            this.dateCreatedCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateCreatedCol.AppearanceHeader.Options.UseFont = true;
            this.dateCreatedCol.AppearanceHeader.Options.UseTextOptions = true;
            this.dateCreatedCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateCreatedCol.Caption = "Дата реєстрації";
            this.dateCreatedCol.FieldName = "DateCreated";
            this.dateCreatedCol.Name = "dateCreatedCol";
            this.dateCreatedCol.OptionsColumn.AllowEdit = false;
            this.dateCreatedCol.OptionsColumn.AllowFocus = false;
            this.dateCreatedCol.Visible = true;
            this.dateCreatedCol.VisibleIndex = 5;
            this.dateCreatedCol.Width = 98;
            // 
            // designerNameCol
            // 
            this.designerNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.designerNameCol.AppearanceHeader.Options.UseFont = true;
            this.designerNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.designerNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.designerNameCol.Caption = "Відповідальна особа";
            this.designerNameCol.FieldName = "DesignerName";
            this.designerNameCol.Name = "designerNameCol";
            this.designerNameCol.OptionsColumn.AllowEdit = false;
            this.designerNameCol.OptionsColumn.AllowFocus = false;
            this.designerNameCol.Visible = true;
            this.designerNameCol.VisibleIndex = 7;
            this.designerNameCol.Width = 116;
            // 
            // userNameCol
            // 
            this.userNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.userNameCol.AppearanceHeader.Options.UseFont = true;
            this.userNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.userNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.userNameCol.Caption = "Зареєстрував виріб";
            this.userNameCol.FieldName = "UserName";
            this.userNameCol.Name = "userNameCol";
            this.userNameCol.OptionsColumn.AllowEdit = false;
            this.userNameCol.OptionsColumn.AllowFocus = false;
            this.userNameCol.Visible = true;
            this.userNameCol.VisibleIndex = 8;
            this.userNameCol.Width = 148;
            // 
            // contractorNameCol
            // 
            this.contractorNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.contractorNameCol.AppearanceHeader.Options.UseFont = true;
            this.contractorNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.contractorNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.contractorNameCol.Caption = "Замовник";
            this.contractorNameCol.FieldName = "ContractorName";
            this.contractorNameCol.Name = "contractorNameCol";
            this.contractorNameCol.OptionsColumn.AllowEdit = false;
            this.contractorNameCol.OptionsColumn.AllowFocus = false;
            this.contractorNameCol.Visible = true;
            this.contractorNameCol.VisibleIndex = 2;
            this.contractorNameCol.Width = 269;
            // 
            // countryNameCol
            // 
            this.countryNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.countryNameCol.AppearanceHeader.Options.UseFont = true;
            this.countryNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.countryNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.countryNameCol.Caption = "Країна";
            this.countryNameCol.FieldName = "CountryName_UA";
            this.countryNameCol.Name = "countryNameCol";
            this.countryNameCol.OptionsColumn.AllowEdit = false;
            this.countryNameCol.OptionsColumn.AllowFocus = false;
            this.countryNameCol.Visible = true;
            this.countryNameCol.VisibleIndex = 3;
            // 
            // cityNameCol
            // 
            this.cityNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cityNameCol.AppearanceHeader.Options.UseFont = true;
            this.cityNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.cityNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cityNameCol.Caption = "Місто";
            this.cityNameCol.FieldName = "CityName_UA";
            this.cityNameCol.Name = "cityNameCol";
            this.cityNameCol.OptionsColumn.AllowEdit = false;
            this.cityNameCol.OptionsColumn.AllowFocus = false;
            this.cityNameCol.Visible = true;
            this.cityNameCol.VisibleIndex = 4;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.beginDateEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.endDateEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.showBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Формування даних";
            // 
            // beginDateEdit
            // 
            this.beginDateEdit.Caption = "Початкова дата";
            this.beginDateEdit.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.beginDateEdit.Edit = this.repositoryItemDateEdit1;
            this.beginDateEdit.EditWidth = 100;
            this.beginDateEdit.Id = 1;
            this.beginDateEdit.Name = "beginDateEdit";
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
            // endDateEdit
            // 
            this.endDateEdit.Caption = "Кінцева дата";
            this.endDateEdit.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.endDateEdit.Edit = this.repositoryItemDateEdit2;
            this.endDateEdit.EditWidth = 100;
            this.endDateEdit.Id = 2;
            this.endDateEdit.Name = "endDateEdit";
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
            this.showBtn.Id = 3;
            this.showBtn.Name = "showBtn";
            this.showBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.showBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showBtn_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.addBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.editBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.deleteBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Вироби";
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Додати";
            this.addBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addBtn.Glyph")));
            this.addBtn.Id = 4;
            this.addBtn.Name = "addBtn";
            this.addBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBtn_ItemClick);
            // 
            // editBtn
            // 
            this.editBtn.Caption = "Редагувати";
            this.editBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editBtn.Glyph")));
            this.editBtn.Id = 5;
            this.editBtn.Name = "editBtn";
            this.editBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.editBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Видалити";
            this.deleteBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Glyph")));
            this.deleteBtn.Id = 6;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.Caption = "Додати";
            this.addOrderBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addOrderBtn.Glyph")));
            this.addOrderBtn.Id = 8;
            this.addOrderBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addOrderBtn.LargeGlyph")));
            this.addOrderBtn.Name = "addOrderBtn";
            // 
            // editOrderBtn
            // 
            this.editOrderBtn.Caption = "Редагувати";
            this.editOrderBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editOrderBtn.Glyph")));
            this.editOrderBtn.Id = 9;
            this.editOrderBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editOrderBtn.LargeGlyph")));
            this.editOrderBtn.Name = "editOrderBtn";
            // 
            // deleteOrderBtn
            // 
            this.deleteOrderBtn.Caption = "Видалити";
            this.deleteOrderBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteOrderBtn.Glyph")));
            this.deleteOrderBtn.Id = 10;
            this.deleteOrderBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteOrderBtn.LargeGlyph")));
            this.deleteOrderBtn.Name = "deleteOrderBtn";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.refreshBtn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Функції";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Caption = "Поновити";
            this.refreshBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Glyph")));
            this.refreshBtn.Id = 7;
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.refreshBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBtn_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.beginDateEdit,
            this.endDateEdit,
            this.showBtn,
            this.addBtn,
            this.editBtn,
            this.deleteBtn,
            this.refreshBtn,
            this.addOrderBtn,
            this.editOrderBtn,
            this.deleteOrderBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1351, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // JournalAssembliesFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 645);
            this.Controls.Add(this.journalAssembliesGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "JournalAssembliesFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Журнал реєстрації виробів ";
            ((System.ComponentModel.ISupportInitialize)(this.journalAssembliesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalAssembliesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl journalAssembliesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView journalAssembliesGridView;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarEditItem beginDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem endDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem showBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem editBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
        private DevExpress.XtraGrid.Columns.GridColumn drawingCol;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn descriptionCol;
        private DevExpress.XtraGrid.Columns.GridColumn dateCreatedCol;
        private DevExpress.XtraGrid.Columns.GridColumn designerNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn userNameCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Columns.GridColumn contractorNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn countryNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn cityNameCol;
        private DevExpress.XtraBars.BarButtonItem addOrderBtn;
        private DevExpress.XtraBars.BarButtonItem editOrderBtn;
        private DevExpress.XtraBars.BarButtonItem deleteOrderBtn;
    }
}