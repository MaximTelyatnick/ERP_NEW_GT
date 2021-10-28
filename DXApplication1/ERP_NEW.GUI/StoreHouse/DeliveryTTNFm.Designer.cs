namespace ERP_NEW.GUI.StoreHouse
{
    partial class DeliveryTTNFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryTTNFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.firstDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.lastDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.showBtn = new DevExpress.XtraBars.BarButtonItem();
            this.exportBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.deliveryTTNGrid = new DevExpress.XtraGrid.GridControl();
            this.deliveryTTNGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.numberTTNCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.carrierCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sumaCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typePaymentCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.numberCommingCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryTTNGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryTTNGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.editBtn,
            this.deleteBtn,
            this.addBtn,
            this.firstDateEdit,
            this.lastDateEdit,
            this.showBtn,
            this.exportBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1305, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // editBtn
            // 
            this.editBtn.Caption = "Редагувати";
            this.editBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editBtn.Glyph")));
            this.editBtn.Id = 2;
            this.editBtn.Name = "editBtn";
            this.editBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.editBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Видалити";
            this.deleteBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Glyph")));
            this.deleteBtn.Id = 3;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Додати";
            this.addBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addBtn.Glyph")));
            this.addBtn.Id = 5;
            this.addBtn.Name = "addBtn";
            this.addBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.addBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBtn_ItemClick);
            // 
            // firstDateEdit
            // 
            this.firstDateEdit.Caption = "З  ";
            this.firstDateEdit.Edit = this.repositoryItemDateEdit1;
            this.firstDateEdit.EditWidth = 100;
            this.firstDateEdit.Id = 6;
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
            this.lastDateEdit.Caption = "по";
            this.lastDateEdit.Edit = this.repositoryItemDateEdit2;
            this.lastDateEdit.EditWidth = 100;
            this.lastDateEdit.Id = 7;
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
            this.showBtn.Id = 8;
            this.showBtn.Name = "showBtn";
            this.showBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.showBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showBtn_ItemClick);
            // 
            // exportBtn
            // 
            this.exportBtn.Caption = "Експорт до Ексель";
            this.exportBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("exportBtn.Glyph")));
            this.exportBtn.Id = 9;
            this.exportBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("exportBtn.LargeGlyph")));
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.exportBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exportBtn_ItemClick);
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
            this.ribbonPageGroup1.Text = "Керування ТТН";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.exportBtn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Функції";
            // 
            // deliveryTTNGrid
            // 
            this.deliveryTTNGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deliveryTTNGrid.Location = new System.Drawing.Point(0, 95);
            this.deliveryTTNGrid.MainView = this.deliveryTTNGridView;
            this.deliveryTTNGrid.Name = "deliveryTTNGrid";
            this.deliveryTTNGrid.Size = new System.Drawing.Size(1305, 470);
            this.deliveryTTNGrid.TabIndex = 1;
            this.deliveryTTNGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.deliveryTTNGridView});
            // 
            // deliveryTTNGridView
            // 
            this.deliveryTTNGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.numberTTNCol,
            this.carrierCol,
            this.dateCol,
            this.sumaCol,
            this.typePaymentCol,
            this.numberCommingCol});
            this.deliveryTTNGridView.GridControl = this.deliveryTTNGrid;
            this.deliveryTTNGridView.Name = "deliveryTTNGridView";
            this.deliveryTTNGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.deliveryTTNGridView.OptionsView.ShowAutoFilterRow = true;
            this.deliveryTTNGridView.OptionsView.ShowGroupPanel = false;
            this.deliveryTTNGridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.deliveryTTNGridView_RowCellStyle);
            this.deliveryTTNGridView.DoubleClick += new System.EventHandler(this.deliveryTTNGridView_DoubleClick);
            // 
            // numberTTNCol
            // 
            this.numberTTNCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.numberTTNCol.AppearanceHeader.Options.UseFont = true;
            this.numberTTNCol.AppearanceHeader.Options.UseTextOptions = true;
            this.numberTTNCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.numberTTNCol.Caption = "Номер ТТН";
            this.numberTTNCol.FieldName = "TTN";
            this.numberTTNCol.Name = "numberTTNCol";
            this.numberTTNCol.OptionsColumn.AllowEdit = false;
            this.numberTTNCol.OptionsColumn.AllowFocus = false;
            this.numberTTNCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.numberTTNCol.Visible = true;
            this.numberTTNCol.VisibleIndex = 0;
            // 
            // carrierCol
            // 
            this.carrierCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.carrierCol.AppearanceHeader.Options.UseFont = true;
            this.carrierCol.AppearanceHeader.Options.UseTextOptions = true;
            this.carrierCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.carrierCol.Caption = "Перевізник";
            this.carrierCol.FieldName = "DeliveryName";
            this.carrierCol.Name = "carrierCol";
            this.carrierCol.OptionsColumn.AllowEdit = false;
            this.carrierCol.OptionsColumn.AllowFocus = false;
            this.carrierCol.Visible = true;
            this.carrierCol.VisibleIndex = 1;
            // 
            // dateCol
            // 
            this.dateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateCol.AppearanceHeader.Options.UseFont = true;
            this.dateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.dateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateCol.Caption = "Дата ТТН";
            this.dateCol.FieldName = "OrderDate";
            this.dateCol.Name = "dateCol";
            this.dateCol.OptionsColumn.AllowEdit = false;
            this.dateCol.OptionsColumn.AllowFocus = false;
            this.dateCol.Visible = true;
            this.dateCol.VisibleIndex = 2;
            // 
            // sumaCol
            // 
            this.sumaCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.sumaCol.AppearanceHeader.Options.UseFont = true;
            this.sumaCol.AppearanceHeader.Options.UseTextOptions = true;
            this.sumaCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sumaCol.Caption = "Сума";
            this.sumaCol.FieldName = "Price";
            this.sumaCol.Name = "sumaCol";
            this.sumaCol.OptionsColumn.AllowEdit = false;
            this.sumaCol.OptionsColumn.AllowFocus = false;
            this.sumaCol.Visible = true;
            this.sumaCol.VisibleIndex = 3;
            // 
            // typePaymentCol
            // 
            this.typePaymentCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.typePaymentCol.AppearanceHeader.Options.UseFont = true;
            this.typePaymentCol.AppearanceHeader.Options.UseTextOptions = true;
            this.typePaymentCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.typePaymentCol.Caption = "Тип платежу";
            this.typePaymentCol.FieldName = "DeliveryPaymentName";
            this.typePaymentCol.Name = "typePaymentCol";
            this.typePaymentCol.OptionsColumn.AllowEdit = false;
            this.typePaymentCol.OptionsColumn.AllowFocus = false;
            this.typePaymentCol.Visible = true;
            this.typePaymentCol.VisibleIndex = 4;
            // 
            // numberCommingCol
            // 
            this.numberCommingCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.numberCommingCol.AppearanceHeader.Options.UseFont = true;
            this.numberCommingCol.AppearanceHeader.Options.UseTextOptions = true;
            this.numberCommingCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.numberCommingCol.Caption = "Номер приходу";
            this.numberCommingCol.FieldName = "ReceiptNumber";
            this.numberCommingCol.Name = "numberCommingCol";
            this.numberCommingCol.OptionsColumn.AllowEdit = false;
            this.numberCommingCol.OptionsColumn.AllowFocus = false;
            this.numberCommingCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.numberCommingCol.Visible = true;
            this.numberCommingCol.VisibleIndex = 5;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Додати";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // DeliveryTTNFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 565);
            this.Controls.Add(this.deliveryTTNGrid);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeliveryTTNFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал ТТН";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryTTNGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryTTNGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem editBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl deliveryTTNGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView deliveryTTNGridView;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraGrid.Columns.GridColumn numberTTNCol;
        private DevExpress.XtraGrid.Columns.GridColumn carrierCol;
        private DevExpress.XtraGrid.Columns.GridColumn dateCol;
        private DevExpress.XtraGrid.Columns.GridColumn sumaCol;
        private DevExpress.XtraGrid.Columns.GridColumn typePaymentCol;
        private DevExpress.XtraGrid.Columns.GridColumn numberCommingCol;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarEditItem firstDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem lastDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem showBtn;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraBars.BarButtonItem exportBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}