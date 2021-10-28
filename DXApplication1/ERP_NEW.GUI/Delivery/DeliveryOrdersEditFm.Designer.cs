namespace ERP_NEW.GUI.Delivery
{
    partial class DeliveryOrdersEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryOrdersEditFm));
            this.customerOrdersGrid = new DevExpress.XtraGrid.GridControl();
            this.customerOrdersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.customerOrderNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selectedCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryOrderItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.closeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.deliveryOrderGrid = new DevExpress.XtraGrid.GridControl();
            this.deliveryOrderGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.receiptNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invoiceDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invoiceNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemReceiptCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.receiptPanel = new DevExpress.XtraEditors.GroupControl();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.customerOrdersPanel = new DevExpress.XtraEditors.GroupControl();
            this.standaloneBarDockControl2 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.receiptBarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.deleteReceiptBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.addReceiptBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.addCustomerOrderBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteCustomerOrderBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryOrderItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemReceiptCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptPanel)).BeginInit();
            this.receiptPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersPanel)).BeginInit();
            this.customerOrdersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerOrdersGrid
            // 
            this.customerOrdersGrid.Location = new System.Drawing.Point(0, 48);
            this.customerOrdersGrid.MainView = this.customerOrdersGridView;
            this.customerOrdersGrid.Name = "customerOrdersGrid";
            this.customerOrdersGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryOrderItemCheckEdit});
            this.customerOrdersGrid.Size = new System.Drawing.Size(599, 374);
            this.customerOrdersGrid.TabIndex = 1;
            this.customerOrdersGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customerOrdersGridView});
            // 
            // customerOrdersGridView
            // 
            this.customerOrdersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.customerOrderNumberCol,
            this.selectedCol});
            this.customerOrdersGridView.GridControl = this.customerOrdersGrid;
            this.customerOrdersGridView.Name = "customerOrdersGridView";
            this.customerOrdersGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // customerOrderNumberCol
            // 
            this.customerOrderNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerOrderNumberCol.AppearanceHeader.Options.UseFont = true;
            this.customerOrderNumberCol.Caption = "Номер заказа";
            this.customerOrderNumberCol.FieldName = "CustomerOrderNumber";
            this.customerOrderNumberCol.Name = "customerOrderNumberCol";
            this.customerOrderNumberCol.Visible = true;
            this.customerOrderNumberCol.VisibleIndex = 0;
            this.customerOrderNumberCol.Width = 530;
            // 
            // selectedCol
            // 
            this.selectedCol.ColumnEdit = this.repositoryOrderItemCheckEdit;
            this.selectedCol.FieldName = "Selected";
            this.selectedCol.Image = ((System.Drawing.Image)(resources.GetObject("selectedCol.Image")));
            this.selectedCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.selectedCol.Name = "selectedCol";
            this.selectedCol.Visible = true;
            this.selectedCol.VisibleIndex = 1;
            this.selectedCol.Width = 51;
            // 
            // repositoryOrderItemCheckEdit
            // 
            this.repositoryOrderItemCheckEdit.AutoHeight = false;
            this.repositoryOrderItemCheckEdit.Name = "repositoryOrderItemCheckEdit";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(1258, 440);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "Відміна";
            this.closeBtn.ToolTip = "Відиінити зміни";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1177, 440);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.ToolTip = "Зберегти зміни";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deliveryOrderGrid
            // 
            this.deliveryOrderGrid.Location = new System.Drawing.Point(0, 48);
            this.deliveryOrderGrid.MainView = this.deliveryOrderGridView;
            this.deliveryOrderGrid.Name = "deliveryOrderGrid";
            this.deliveryOrderGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemReceiptCheckEdit});
            this.deliveryOrderGrid.Size = new System.Drawing.Size(716, 374);
            this.deliveryOrderGrid.TabIndex = 12;
            this.deliveryOrderGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.deliveryOrderGridView});
            // 
            // deliveryOrderGridView
            // 
            this.deliveryOrderGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.receiptNumCol,
            this.orderDateCol,
            this.invoiceDateCol,
            this.invoiceNumCol,
            this.checkCol});
            this.deliveryOrderGridView.GridControl = this.deliveryOrderGrid;
            this.deliveryOrderGridView.Name = "deliveryOrderGridView";
            this.deliveryOrderGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // receiptNumCol
            // 
            this.receiptNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receiptNumCol.AppearanceHeader.Options.UseFont = true;
            this.receiptNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.receiptNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.receiptNumCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.receiptNumCol.Caption = "Номер надходження";
            this.receiptNumCol.FieldName = "ReceiptNum";
            this.receiptNumCol.Name = "receiptNumCol";
            this.receiptNumCol.OptionsColumn.AllowEdit = false;
            this.receiptNumCol.Visible = true;
            this.receiptNumCol.VisibleIndex = 0;
            this.receiptNumCol.Width = 155;
            // 
            // orderDateCol
            // 
            this.orderDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderDateCol.AppearanceHeader.Options.UseFont = true;
            this.orderDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderDateCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.orderDateCol.Caption = "Дата надходження";
            this.orderDateCol.FieldName = "OrderDate";
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.OptionsColumn.AllowEdit = false;
            this.orderDateCol.Visible = true;
            this.orderDateCol.VisibleIndex = 1;
            this.orderDateCol.Width = 173;
            // 
            // invoiceDateCol
            // 
            this.invoiceDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invoiceDateCol.AppearanceHeader.Options.UseFont = true;
            this.invoiceDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.invoiceDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.invoiceDateCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.invoiceDateCol.Caption = "Дата накладної";
            this.invoiceDateCol.FieldName = "InvoiceDate";
            this.invoiceDateCol.Name = "invoiceDateCol";
            this.invoiceDateCol.OptionsColumn.AllowEdit = false;
            this.invoiceDateCol.Visible = true;
            this.invoiceDateCol.VisibleIndex = 2;
            this.invoiceDateCol.Width = 136;
            // 
            // invoiceNumCol
            // 
            this.invoiceNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invoiceNumCol.AppearanceHeader.Options.UseFont = true;
            this.invoiceNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.invoiceNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.invoiceNumCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.invoiceNumCol.Caption = "Номер накладної";
            this.invoiceNumCol.FieldName = "InvoiceNum";
            this.invoiceNumCol.Name = "invoiceNumCol";
            this.invoiceNumCol.OptionsColumn.AllowEdit = false;
            this.invoiceNumCol.Visible = true;
            this.invoiceNumCol.VisibleIndex = 3;
            this.invoiceNumCol.Width = 187;
            // 
            // checkCol
            // 
            this.checkCol.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("checkCol.AppearanceHeader.Image")));
            this.checkCol.AppearanceHeader.Options.UseImage = true;
            this.checkCol.ColumnEdit = this.repositoryItemReceiptCheckEdit;
            this.checkCol.FieldName = "Selected";
            this.checkCol.Image = ((System.Drawing.Image)(resources.GetObject("checkCol.Image")));
            this.checkCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.checkCol.Name = "checkCol";
            this.checkCol.Visible = true;
            this.checkCol.VisibleIndex = 4;
            this.checkCol.Width = 47;
            // 
            // repositoryItemReceiptCheckEdit
            // 
            this.repositoryItemReceiptCheckEdit.AutoHeight = false;
            this.repositoryItemReceiptCheckEdit.Name = "repositoryItemReceiptCheckEdit";
            // 
            // receiptPanel
            // 
            this.receiptPanel.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receiptPanel.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.receiptPanel.AppearanceCaption.Options.UseFont = true;
            this.receiptPanel.AppearanceCaption.Options.UseForeColor = true;
            this.receiptPanel.Controls.Add(this.standaloneBarDockControl1);
            this.receiptPanel.Controls.Add(this.deliveryOrderGrid);
            this.receiptPanel.Location = new System.Drawing.Point(12, 12);
            this.receiptPanel.Name = "receiptPanel";
            this.receiptPanel.Size = new System.Drawing.Size(716, 422);
            this.receiptPanel.TabIndex = 13;
            this.receiptPanel.Text = "Надходження";
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(5, 18);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(521, 24);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // customerOrdersPanel
            // 
            this.customerOrdersPanel.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerOrdersPanel.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.customerOrdersPanel.AppearanceCaption.Options.UseFont = true;
            this.customerOrdersPanel.AppearanceCaption.Options.UseForeColor = true;
            this.customerOrdersPanel.Controls.Add(this.standaloneBarDockControl2);
            this.customerOrdersPanel.Controls.Add(this.customerOrdersGrid);
            this.customerOrdersPanel.Location = new System.Drawing.Point(734, 12);
            this.customerOrdersPanel.Name = "customerOrdersPanel";
            this.customerOrdersPanel.Size = new System.Drawing.Size(599, 422);
            this.customerOrdersPanel.TabIndex = 14;
            this.customerOrdersPanel.Text = "Закази";
            // 
            // standaloneBarDockControl2
            // 
            this.standaloneBarDockControl2.CausesValidation = false;
            this.standaloneBarDockControl2.Location = new System.Drawing.Point(5, 23);
            this.standaloneBarDockControl2.Name = "standaloneBarDockControl2";
            this.standaloneBarDockControl2.Size = new System.Drawing.Size(589, 24);
            this.standaloneBarDockControl2.Text = "standaloneBarDockControl2";
            // 
            // receiptBarManager
            // 
            this.receiptBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.receiptBarManager.DockControls.Add(this.barDockControlTop);
            this.receiptBarManager.DockControls.Add(this.barDockControlBottom);
            this.receiptBarManager.DockControls.Add(this.barDockControlLeft);
            this.receiptBarManager.DockControls.Add(this.barDockControlRight);
            this.receiptBarManager.DockControls.Add(this.standaloneBarDockControl1);
            this.receiptBarManager.DockControls.Add(this.standaloneBarDockControl2);
            this.receiptBarManager.Form = this;
            this.receiptBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addReceiptBtn,
            this.deleteReceiptBtn});
            this.receiptBarManager.MainMenu = this.bar2;
            this.receiptBarManager.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar2.FloatLocation = new System.Drawing.Point(407, 198);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.deleteReceiptBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar2.Text = "Main menu";
            // 
            // deleteReceiptBtn
            // 
            this.deleteReceiptBtn.Caption = "Видалити";
            this.deleteReceiptBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteReceiptBtn.Glyph")));
            this.deleteReceiptBtn.Id = 1;
            this.deleteReceiptBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteReceiptBtn.LargeGlyph")));
            this.deleteReceiptBtn.Name = "deleteReceiptBtn";
            this.deleteReceiptBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteReceiptBtn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1345, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 475);
            this.barDockControlBottom.Size = new System.Drawing.Size(1345, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 475);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1345, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 475);
            // 
            // addReceiptBtn
            // 
            this.addReceiptBtn.Caption = "Додати";
            this.addReceiptBtn.Enabled = false;
            this.addReceiptBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addReceiptBtn.Glyph")));
            this.addReceiptBtn.Id = 0;
            this.addReceiptBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addReceiptBtn.LargeGlyph")));
            this.addReceiptBtn.Name = "addReceiptBtn";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addCustomerOrderBtn,
            this.deleteCustomerOrderBtn});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 2;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar3.FloatLocation = new System.Drawing.Point(657, 186);
            this.bar3.FloatSize = new System.Drawing.Size(46, 29);
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.addCustomerOrderBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.deleteCustomerOrderBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.DrawBorder = false;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.StandaloneBarDockControl = this.standaloneBarDockControl2;
            this.bar3.Text = "Main menu";
            // 
            // addCustomerOrderBtn
            // 
            this.addCustomerOrderBtn.Caption = "Додати";
            this.addCustomerOrderBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addCustomerOrderBtn.Glyph")));
            this.addCustomerOrderBtn.Id = 0;
            this.addCustomerOrderBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addCustomerOrderBtn.LargeGlyph")));
            this.addCustomerOrderBtn.Name = "addCustomerOrderBtn";
            this.addCustomerOrderBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addCustomerOrderBtn_ItemClick);
            // 
            // deleteCustomerOrderBtn
            // 
            this.deleteCustomerOrderBtn.Caption = "Видалити";
            this.deleteCustomerOrderBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteCustomerOrderBtn.Glyph")));
            this.deleteCustomerOrderBtn.Id = 1;
            this.deleteCustomerOrderBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteCustomerOrderBtn.LargeGlyph")));
            this.deleteCustomerOrderBtn.Name = "deleteCustomerOrderBtn";
            this.deleteCustomerOrderBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteCustomerOrderBtn_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(1345, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 475);
            this.barDockControl2.Size = new System.Drawing.Size(1345, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Size = new System.Drawing.Size(0, 475);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1345, 0);
            this.barDockControl4.Size = new System.Drawing.Size(0, 475);
            // 
            // DeliveryOrdersEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 475);
            this.Controls.Add(this.customerOrdersPanel);
            this.Controls.Add(this.receiptPanel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeliveryOrdersEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагування заказу";
            this.Load += new System.EventHandler(this.DeliveryOrdersEditFm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryOrderItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemReceiptCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptPanel)).EndInit();
            this.receiptPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersPanel)).EndInit();
            this.customerOrdersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receiptBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl customerOrdersGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView customerOrdersGridView;
        private DevExpress.XtraEditors.SimpleButton closeBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraGrid.GridControl deliveryOrderGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView deliveryOrderGridView;
        private DevExpress.XtraGrid.Columns.GridColumn receiptNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn orderDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn invoiceDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn invoiceNumCol;
        private DevExpress.XtraEditors.GroupControl receiptPanel;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraEditors.GroupControl customerOrdersPanel;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl2;
        private DevExpress.XtraBars.BarManager receiptBarManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem addReceiptBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem deleteReceiptBtn;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem addCustomerOrderBtn;
        private DevExpress.XtraBars.BarButtonItem deleteCustomerOrderBtn;
        private DevExpress.XtraGrid.Columns.GridColumn customerOrderNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn selectedCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryOrderItemCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn checkCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemReceiptCheckEdit;

    }
}