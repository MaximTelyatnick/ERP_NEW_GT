namespace ERP_NEW.GUI.Delivery
{
    partial class DeliveryOrdersCustomerOrderSelectFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryOrdersCustomerOrderSelectFm));
            this.deliveryOrderCustomerGrid = new DevExpress.XtraGrid.GridControl();
            this.deliveryOrderCustomerGridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.orderNumberCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.contractorNameCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.orderDateCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.customerOrderPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.currencyPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.drawingCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.receiptNumCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.nomenclatureNameCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.nomenclatureNumberCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.quantityCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.totalPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.unitLocalNameCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.selectedCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.addBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrderCustomerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrderCustomerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // deliveryOrderCustomerGrid
            // 
            this.deliveryOrderCustomerGrid.Location = new System.Drawing.Point(-2, 2);
            this.deliveryOrderCustomerGrid.MainView = this.deliveryOrderCustomerGridView;
            this.deliveryOrderCustomerGrid.Name = "deliveryOrderCustomerGrid";
            this.deliveryOrderCustomerGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoEdit2});
            this.deliveryOrderCustomerGrid.Size = new System.Drawing.Size(1484, 693);
            this.deliveryOrderCustomerGrid.TabIndex = 80;
            this.deliveryOrderCustomerGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.deliveryOrderCustomerGridView});
            // 
            // deliveryOrderCustomerGridView
            // 
            this.deliveryOrderCustomerGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.deliveryOrderCustomerGridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.orderNumberCol,
            this.contractorNameCol,
            this.orderDateCol,
            this.selectedCol,
            this.drawingCol,
            this.quantityCol,
            this.nomenclatureNameCol,
            this.nomenclatureNumberCol,
            this.receiptNumCol,
            this.totalPriceCol,
            this.unitLocalNameCol,
            this.customerOrderPriceCol,
            this.currencyPriceCol});
            this.deliveryOrderCustomerGridView.GridControl = this.deliveryOrderCustomerGrid;
            this.deliveryOrderCustomerGridView.GroupCount = 1;
            this.deliveryOrderCustomerGridView.Name = "deliveryOrderCustomerGridView";
            this.deliveryOrderCustomerGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.deliveryOrderCustomerGridView.OptionsView.AllowCellMerge = true;
            this.deliveryOrderCustomerGridView.OptionsView.RowAutoHeight = true;
            this.deliveryOrderCustomerGridView.OptionsView.ShowAutoFilterRow = true;
            this.deliveryOrderCustomerGridView.OptionsView.ShowFooter = true;
            this.deliveryOrderCustomerGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.orderNumberCol, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.deliveryOrderCustomerGridView.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.deliveryOrderCustomerGridView_CellMerge);
            this.deliveryOrderCustomerGridView.DoubleClick += new System.EventHandler(this.deliveryOrderCustomerGridView_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Заказ";
            this.gridBand1.Columns.Add(this.orderNumberCol);
            this.gridBand1.Columns.Add(this.contractorNameCol);
            this.gridBand1.Columns.Add(this.orderDateCol);
            this.gridBand1.Columns.Add(this.customerOrderPriceCol);
            this.gridBand1.Columns.Add(this.currencyPriceCol);
            this.gridBand1.Columns.Add(this.drawingCol);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 793;
            // 
            // orderNumberCol
            // 
            this.orderNumberCol.AppearanceCell.Options.UseTextOptions = true;
            this.orderNumberCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.orderNumberCol.AppearanceHeader.Options.UseFont = true;
            this.orderNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderNumberCol.Caption = "Номер заказа";
            this.orderNumberCol.FieldName = "OrderNumber";
            this.orderNumberCol.Name = "orderNumberCol";
            this.orderNumberCol.OptionsColumn.AllowEdit = false;
            this.orderNumberCol.OptionsColumn.AllowFocus = false;
            this.orderNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.orderNumberCol.Visible = true;
            this.orderNumberCol.Width = 106;
            // 
            // contractorNameCol
            // 
            this.contractorNameCol.AppearanceCell.Options.UseTextOptions = true;
            this.contractorNameCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.contractorNameCol.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.contractorNameCol.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.contractorNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.contractorNameCol.AppearanceHeader.Options.UseFont = true;
            this.contractorNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.contractorNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.contractorNameCol.Caption = "Контрагент";
            this.contractorNameCol.ColumnEdit = this.repositoryItemMemoEdit1;
            this.contractorNameCol.FieldName = "ContractorName";
            this.contractorNameCol.Name = "contractorNameCol";
            this.contractorNameCol.OptionsColumn.AllowEdit = false;
            this.contractorNameCol.OptionsColumn.AllowFocus = false;
            this.contractorNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.contractorNameCol.Visible = true;
            this.contractorNameCol.Width = 139;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // orderDateCol
            // 
            this.orderDateCol.AppearanceCell.Options.UseTextOptions = true;
            this.orderDateCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.orderDateCol.AppearanceHeader.Options.UseFont = true;
            this.orderDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderDateCol.Caption = "Дата";
            this.orderDateCol.FieldName = "OrderDate";
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.OptionsColumn.AllowEdit = false;
            this.orderDateCol.OptionsColumn.AllowFocus = false;
            this.orderDateCol.Visible = true;
            this.orderDateCol.Width = 78;
            // 
            // customerOrderPriceCol
            // 
            this.customerOrderPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerOrderPriceCol.AppearanceHeader.Options.UseFont = true;
            this.customerOrderPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.customerOrderPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customerOrderPriceCol.Caption = "Сума (грн)";
            this.customerOrderPriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.customerOrderPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.customerOrderPriceCol.FieldName = "OrderPrice";
            this.customerOrderPriceCol.Name = "customerOrderPriceCol";
            this.customerOrderPriceCol.OptionsColumn.AllowEdit = false;
            this.customerOrderPriceCol.OptionsColumn.AllowFocus = false;
            this.customerOrderPriceCol.Visible = true;
            this.customerOrderPriceCol.Width = 124;
            // 
            // currencyPriceCol
            // 
            this.currencyPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currencyPriceCol.AppearanceHeader.Options.UseFont = true;
            this.currencyPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.currencyPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.currencyPriceCol.Caption = "Сума (вал.)";
            this.currencyPriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.currencyPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.currencyPriceCol.FieldName = "CurrencyPrice";
            this.currencyPriceCol.Name = "currencyPriceCol";
            this.currencyPriceCol.OptionsColumn.AllowEdit = false;
            this.currencyPriceCol.OptionsColumn.AllowFocus = false;
            this.currencyPriceCol.Visible = true;
            this.currencyPriceCol.Width = 113;
            // 
            // drawingCol
            // 
            this.drawingCol.AppearanceCell.Options.UseTextOptions = true;
            this.drawingCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.drawingCol.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.drawingCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.drawingCol.AppearanceHeader.Options.UseFont = true;
            this.drawingCol.AppearanceHeader.Options.UseTextOptions = true;
            this.drawingCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.drawingCol.Caption = "Номер креслення";
            this.drawingCol.ColumnEdit = this.repositoryItemMemoEdit2;
            this.drawingCol.FieldName = "Drawing";
            this.drawingCol.MinWidth = 10;
            this.drawingCol.Name = "drawingCol";
            this.drawingCol.OptionsColumn.AllowEdit = false;
            this.drawingCol.OptionsColumn.AllowFocus = false;
            this.drawingCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.drawingCol.Visible = true;
            this.drawingCol.Width = 233;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemMemoEdit2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Матеріал";
            this.gridBand2.Columns.Add(this.receiptNumCol);
            this.gridBand2.Columns.Add(this.nomenclatureNameCol);
            this.gridBand2.Columns.Add(this.nomenclatureNumberCol);
            this.gridBand2.Columns.Add(this.quantityCol);
            this.gridBand2.Columns.Add(this.totalPriceCol);
            this.gridBand2.Columns.Add(this.unitLocalNameCol);
            this.gridBand2.Columns.Add(this.selectedCol);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 673;
            // 
            // receiptNumCol
            // 
            this.receiptNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receiptNumCol.AppearanceHeader.Options.UseFont = true;
            this.receiptNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.receiptNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.receiptNumCol.Caption = "Надходження";
            this.receiptNumCol.FieldName = "ReceiptNum";
            this.receiptNumCol.Name = "receiptNumCol";
            this.receiptNumCol.OptionsColumn.AllowEdit = false;
            this.receiptNumCol.OptionsColumn.AllowFocus = false;
            this.receiptNumCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.receiptNumCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.receiptNumCol.Visible = true;
            this.receiptNumCol.Width = 108;
            // 
            // nomenclatureNameCol
            // 
            this.nomenclatureNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomenclatureNameCol.AppearanceHeader.Options.UseFont = true;
            this.nomenclatureNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureNameCol.Caption = "Найменування";
            this.nomenclatureNameCol.FieldName = "NomenclatureName";
            this.nomenclatureNameCol.Name = "nomenclatureNameCol";
            this.nomenclatureNameCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureNameCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureNameCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.nomenclatureNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nomenclatureNameCol.Visible = true;
            this.nomenclatureNameCol.Width = 152;
            // 
            // nomenclatureNumberCol
            // 
            this.nomenclatureNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomenclatureNumberCol.AppearanceHeader.Options.UseFont = true;
            this.nomenclatureNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureNumberCol.Caption = "Номер";
            this.nomenclatureNumberCol.FieldName = "Nomenclature";
            this.nomenclatureNumberCol.Name = "nomenclatureNumberCol";
            this.nomenclatureNumberCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureNumberCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureNumberCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.nomenclatureNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nomenclatureNumberCol.Visible = true;
            this.nomenclatureNumberCol.Width = 82;
            // 
            // quantityCol
            // 
            this.quantityCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityCol.AppearanceHeader.Options.UseFont = true;
            this.quantityCol.AppearanceHeader.Options.UseTextOptions = true;
            this.quantityCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.quantityCol.Caption = "Кількість";
            this.quantityCol.FieldName = "Quantity";
            this.quantityCol.Name = "quantityCol";
            this.quantityCol.OptionsColumn.AllowEdit = false;
            this.quantityCol.OptionsColumn.AllowFocus = false;
            this.quantityCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.quantityCol.Visible = true;
            this.quantityCol.Width = 62;
            // 
            // totalPriceCol
            // 
            this.totalPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.totalPriceCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.totalPriceCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPrice", "{0:### ### ##0.00}")});
            this.totalPriceCol.Visible = true;
            this.totalPriceCol.Width = 127;
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
            this.unitLocalNameCol.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.unitLocalNameCol.Visible = true;
            this.unitLocalNameCol.Width = 102;
            // 
            // selectedCol
            // 
            this.selectedCol.AppearanceCell.Options.UseTextOptions = true;
            this.selectedCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selectedCol.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("selectedCol.AppearanceHeader.Image")));
            this.selectedCol.AppearanceHeader.Options.UseImage = true;
            this.selectedCol.AppearanceHeader.Options.UseTextOptions = true;
            this.selectedCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selectedCol.FieldName = "Selected";
            this.selectedCol.Image = ((System.Drawing.Image)(resources.GetObject("selectedCol.Image")));
            this.selectedCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.selectedCol.Name = "selectedCol";
            this.selectedCol.Visible = true;
            this.selectedCol.Width = 40;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(1394, 711);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 21);
            this.cancelBtn.TabIndex = 82;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(1313, 711);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 21);
            this.addBtn.TabIndex = 81;
            this.addBtn.Text = "Додати";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // DeliveryOrdersCustomerOrderSelectFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 744);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.deliveryOrderCustomerGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeliveryOrdersCustomerOrderSelectFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагування заказу";
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrderCustomerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOrderCustomerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl deliveryOrderCustomerGrid;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton addBtn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView deliveryOrderCustomerGridView;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn orderNumberCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn contractorNameCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn orderDateCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn customerOrderPriceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn drawingCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn receiptNumCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn nomenclatureNameCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn nomenclatureNumberCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn quantityCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn totalPriceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn unitLocalNameCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn selectedCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn currencyPriceCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
    }
}