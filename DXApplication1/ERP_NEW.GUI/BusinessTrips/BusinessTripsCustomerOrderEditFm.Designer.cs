namespace ERP_NEW.GUI.BusinessTrips
{
    partial class BusinessTripsCustomerOrderEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessTripsCustomerOrderEditFm));
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.businessTripsOrdersGrid = new DevExpress.XtraGrid.GridControl();
            this.businessTripsOrdersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.orderNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contractorNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selectedCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addOrderBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteOrderBtn = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl2 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsOrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsOrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(748, 316);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 21);
            this.cancelBtn.TabIndex = 75;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(667, 316);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 21);
            this.saveBtn.TabIndex = 74;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // businessTripsOrdersGrid
            // 
            this.businessTripsOrdersGrid.Location = new System.Drawing.Point(0, 27);
            this.businessTripsOrdersGrid.MainView = this.businessTripsOrdersGridView;
            this.businessTripsOrdersGrid.Name = "businessTripsOrdersGrid";
            this.businessTripsOrdersGrid.Size = new System.Drawing.Size(834, 283);
            this.businessTripsOrdersGrid.TabIndex = 76;
            this.businessTripsOrdersGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.businessTripsOrdersGridView});
            this.businessTripsOrdersGrid.Click += new System.EventHandler(this.businessTripsOrdersGrid_Click);
            // 
            // businessTripsOrdersGridView
            // 
            this.businessTripsOrdersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.orderNumberCol,
            this.contractorNameCol,
            this.orderDateCol,
            this.selectedCol});
            this.businessTripsOrdersGridView.GridControl = this.businessTripsOrdersGrid;
            this.businessTripsOrdersGridView.Name = "businessTripsOrdersGridView";
            this.businessTripsOrdersGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.businessTripsOrdersGridView.OptionsView.ShowGroupPanel = false;
            this.businessTripsOrdersGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.orderNumberCol, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // orderNumberCol
            // 
            this.orderNumberCol.Caption = "Номер заказ";
            this.orderNumberCol.FieldName = "OrderNumber";
            this.orderNumberCol.Name = "orderNumberCol";
            this.orderNumberCol.OptionsColumn.AllowEdit = false;
            this.orderNumberCol.OptionsColumn.AllowFocus = false;
            this.orderNumberCol.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.orderNumberCol.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.True;
            this.orderNumberCol.Visible = true;
            this.orderNumberCol.VisibleIndex = 0;
            this.orderNumberCol.Width = 156;
            // 
            // contractorNameCol
            // 
            this.contractorNameCol.Caption = "Контрагент";
            this.contractorNameCol.FieldName = "ContractorName";
            this.contractorNameCol.Name = "contractorNameCol";
            this.contractorNameCol.OptionsColumn.AllowEdit = false;
            this.contractorNameCol.OptionsColumn.AllowFocus = false;
            this.contractorNameCol.Visible = true;
            this.contractorNameCol.VisibleIndex = 1;
            this.contractorNameCol.Width = 418;
            // 
            // orderDateCol
            // 
            this.orderDateCol.Caption = "Дата заказа";
            this.orderDateCol.FieldName = "OrderDate";
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.OptionsColumn.AllowEdit = false;
            this.orderDateCol.OptionsColumn.AllowFocus = false;
            this.orderDateCol.Visible = true;
            this.orderDateCol.VisibleIndex = 2;
            this.orderDateCol.Width = 289;
            // 
            // selectedCol
            // 
            this.selectedCol.FieldName = "Selected";
            this.selectedCol.Image = ((System.Drawing.Image)(resources.GetObject("selectedCol.Image")));
            this.selectedCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.selectedCol.Name = "selectedCol";
            this.selectedCol.Visible = true;
            this.selectedCol.VisibleIndex = 3;
            this.selectedCol.Width = 42;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl2);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addBtn,
            this.editBtn,
            this.deleteBtn,
            this.addOrderBtn,
            this.deleteOrderBtn});
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "CustomerOrderTools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.addOrderBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.deleteOrderBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowRename = true;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.StandaloneBarDockControl = this.standaloneBarDockControl2;
            this.bar2.Text = "CustomerOrderTools";
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.Caption = "Додати";
            this.addOrderBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addOrderBtn.Glyph")));
            this.addOrderBtn.Id = 3;
            this.addOrderBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addOrderBtn.LargeGlyph")));
            this.addOrderBtn.Name = "addOrderBtn";
            this.addOrderBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addOrderBtn_ItemClick);
            // 
            // deleteOrderBtn
            // 
            this.deleteOrderBtn.Caption = "Видалити";
            this.deleteOrderBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteOrderBtn.Glyph")));
            this.deleteOrderBtn.Id = 4;
            this.deleteOrderBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteOrderBtn.LargeGlyph")));
            this.deleteOrderBtn.Name = "deleteOrderBtn";
            this.deleteOrderBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteOrderBtn_ItemClick);
            // 
            // standaloneBarDockControl2
            // 
            this.standaloneBarDockControl2.CausesValidation = false;
            this.standaloneBarDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl2.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl2.Name = "standaloneBarDockControl2";
            this.standaloneBarDockControl2.Size = new System.Drawing.Size(835, 27);
            this.standaloneBarDockControl2.Text = "standaloneBarDockControl2";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(835, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 345);
            this.barDockControlBottom.Size = new System.Drawing.Size(835, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 345);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(835, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 345);
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Додати";
            this.addBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addBtn.Glyph")));
            this.addBtn.Id = 0;
            this.addBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addBtn.LargeGlyph")));
            this.addBtn.Name = "addBtn";
            // 
            // editBtn
            // 
            this.editBtn.Caption = "Редагувати";
            this.editBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editBtn.Glyph")));
            this.editBtn.Id = 1;
            this.editBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editBtn.LargeGlyph")));
            this.editBtn.Name = "editBtn";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Видалити";
            this.deleteBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Glyph")));
            this.deleteBtn.Id = 2;
            this.deleteBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteBtn.LargeGlyph")));
            this.deleteBtn.Name = "deleteBtn";
            // 
            // BusinessTripsCustomerOrderEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 345);
            this.Controls.Add(this.standaloneBarDockControl2);
            this.Controls.Add(this.businessTripsOrdersGrid);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusinessTripsCustomerOrderEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагувати";
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsOrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsOrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraGrid.GridControl businessTripsOrdersGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView businessTripsOrdersGridView;
        private DevExpress.XtraGrid.Columns.GridColumn orderNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn contractorNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn orderDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn selectedCol;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem editBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem addOrderBtn;
        private DevExpress.XtraBars.BarButtonItem deleteOrderBtn;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}