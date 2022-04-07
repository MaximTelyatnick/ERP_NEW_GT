namespace ERP_NEW.GUI.Accounting
{
    partial class FixedAssetsOrderCancelAmortizationFm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dateGrid = new DevExpress.XtraGrid.GridControl();
            this.dateGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsOrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsOrderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cancelBtn);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 530);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1062, 52);
            this.panelControl1.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.fixedAssetsOrderGrid);
            this.splitContainerControl1.Panel2.Controls.Add(this.dateGrid);
            this.splitContainerControl1.Size = new System.Drawing.Size(1062, 530);
            this.splitContainerControl1.SplitterPosition = 778;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // dateGrid
            // 
            this.dateGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateGrid.Location = new System.Drawing.Point(0, 0);
            this.dateGrid.MainView = this.dateGridView;
            this.dateGrid.Name = "dateGrid";
            this.dateGrid.Size = new System.Drawing.Size(279, 530);
            this.dateGrid.TabIndex = 0;
            this.dateGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dateGridView});
            // 
            // dateGridView
            // 
            this.dateGridView.GridControl = this.dateGrid;
            this.dateGridView.Name = "dateGridView";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(961, 17);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 19;
            this.cancelBtn.Text = "Відмінити";
            // 
            // fixedAssetsOrderGrid
            // 
            this.fixedAssetsOrderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fixedAssetsOrderGrid.Location = new System.Drawing.Point(0, 0);
            this.fixedAssetsOrderGrid.MainView = this.fixedAssetsOrderGridView;
            this.fixedAssetsOrderGrid.Name = "fixedAssetsOrderGrid";
            this.fixedAssetsOrderGrid.Size = new System.Drawing.Size(778, 530);
            this.fixedAssetsOrderGrid.TabIndex = 1;
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
            this.fixedAssetsOrderGridView.OptionsView.ShowAutoFilterRow = true;
            this.fixedAssetsOrderGridView.OptionsView.ShowFooter = true;
            this.fixedAssetsOrderGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.groupCol, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            // FixedAssetsOrderCancelAmortizationFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 582);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FixedAssetsOrderCancelAmortizationFm";
            this.Text = "FixedAssetsOrderCancelAmortizationFm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsOrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsOrderGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl dateGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView dateGridView;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraGrid.GridControl fixedAssetsOrderGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView fixedAssetsOrderGridView;
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
        private DevExpress.XtraGrid.Columns.GridColumn currentAmortizationCol;
        private DevExpress.XtraGrid.Columns.GridColumn periodYearAmortizationCol;
        private DevExpress.XtraGrid.Columns.GridColumn endDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn endRegisterDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn groupCol;
    }
}