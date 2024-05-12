namespace ERP_NEW.GUI.Accounting
{
    partial class ExpendituresJournalFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpendituresJournalFm));
            this.beginDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.endDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.showExpenditureBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.expendituresGrid = new DevExpress.XtraGrid.GridControl();
            this.expenditureBandedGridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.orderDateCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.receiptNumCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.debitAccountNum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.nomenclatureCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.nameCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.measureCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.balanceAccountNumCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.quantityReceiptnCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.totalPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.uniPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.expDateCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.unitPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.expPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.creditAccountNumCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.remainsCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.projectCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expendituresGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenditureBandedGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // beginDateEdit
            // 
            this.beginDateEdit.EditValue = null;
            this.beginDateEdit.Location = new System.Drawing.Point(24, 11);
            this.beginDateEdit.Name = "beginDateEdit";
            this.beginDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.beginDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.beginDateEdit.Size = new System.Drawing.Size(131, 20);
            this.beginDateEdit.TabIndex = 0;
            // 
            // endDateEdit
            // 
            this.endDateEdit.EditValue = null;
            this.endDateEdit.Location = new System.Drawing.Point(184, 11);
            this.endDateEdit.Name = "endDateEdit";
            this.endDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateEdit.Size = new System.Drawing.Size(115, 20);
            this.endDateEdit.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.showExpenditureBtn);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.beginDateEdit);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.endDateEdit);
            this.panelControl2.Location = new System.Drawing.Point(3, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1366, 44);
            this.panelControl2.TabIndex = 18;
            // 
            // showExpenditureBtn
            // 
            this.showExpenditureBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.showExpenditureBtn.Image = ((System.Drawing.Image)(resources.GetObject("showExpenditureBtn.Image")));
            this.showExpenditureBtn.Location = new System.Drawing.Point(305, 2);
            this.showExpenditureBtn.Name = "showExpenditureBtn";
            this.showExpenditureBtn.Size = new System.Drawing.Size(42, 37);
            this.showExpenditureBtn.TabIndex = 10;
            this.showExpenditureBtn.ToolTip = "Показати";
            this.showExpenditureBtn.Click += new System.EventHandler(this.showExpenditureBtn_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(161, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "По:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(8, 14);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(10, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "З:";
            // 
            // expendituresGrid
            // 
            this.expendituresGrid.Location = new System.Drawing.Point(3, 48);
            this.expendituresGrid.MainView = this.expenditureBandedGridView;
            this.expendituresGrid.Name = "expendituresGrid";
            this.expendituresGrid.Size = new System.Drawing.Size(1366, 513);
            this.expendituresGrid.TabIndex = 19;
            this.expendituresGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.expenditureBandedGridView});
            // 
            // expenditureBandedGridView
            // 
            this.expenditureBandedGridView.BandPanelRowHeight = 30;
            this.expenditureBandedGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.expenditureBandedGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.expenditureBandedGridView.ColumnPanelRowHeight = 50;
            this.expenditureBandedGridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.orderDateCol,
            this.receiptNumCol,
            this.debitAccountNum,
            this.nomenclatureCol,
            this.nameCol,
            this.measureCol,
            this.balanceAccountNumCol,
            this.quantityReceiptnCol,
            this.totalPriceCol,
            this.uniPriceCol,
            this.expDateCol,
            this.unitPriceCol,
            this.expPriceCol,
            this.projectCol,
            this.creditAccountNumCol,
            this.remainsCol});
            this.expenditureBandedGridView.GridControl = this.expendituresGrid;
            this.expenditureBandedGridView.Name = "expenditureBandedGridView";
            this.expenditureBandedGridView.OptionsView.ShowAutoFilterRow = true;
            this.expenditureBandedGridView.OptionsView.ShowFooter = true;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Надходження";
            this.gridBand1.Columns.Add(this.orderDateCol);
            this.gridBand1.Columns.Add(this.receiptNumCol);
            this.gridBand1.Columns.Add(this.debitAccountNum);
            this.gridBand1.Columns.Add(this.nomenclatureCol);
            this.gridBand1.Columns.Add(this.nameCol);
            this.gridBand1.Columns.Add(this.measureCol);
            this.gridBand1.Columns.Add(this.balanceAccountNumCol);
            this.gridBand1.Columns.Add(this.quantityReceiptnCol);
            this.gridBand1.Columns.Add(this.totalPriceCol);
            this.gridBand1.Columns.Add(this.uniPriceCol);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.AllowMove = false;
            this.gridBand1.OptionsBand.AllowPress = false;
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 790;
            // 
            // orderDateCol
            // 
            this.orderDateCol.AppearanceCell.BackColor = System.Drawing.Color.Snow;
            this.orderDateCol.AppearanceCell.Options.UseBackColor = true;
            this.orderDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderDateCol.AppearanceHeader.Options.UseFont = true;
            this.orderDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderDateCol.Caption = "Дата";
            this.orderDateCol.FieldName = "OrderDate";
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.OptionsColumn.AllowEdit = false;
            this.orderDateCol.OptionsColumn.AllowFocus = false;
            this.orderDateCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrderDate", "Всього:   {0}")});
            this.orderDateCol.Visible = true;
            this.orderDateCol.Width = 53;
            // 
            // receiptNumCol
            // 
            this.receiptNumCol.AppearanceCell.BackColor = System.Drawing.Color.Snow;
            this.receiptNumCol.AppearanceCell.Options.UseBackColor = true;
            this.receiptNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receiptNumCol.AppearanceHeader.Options.UseFont = true;
            this.receiptNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.receiptNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.receiptNumCol.Caption = "Номер";
            this.receiptNumCol.FieldName = "ReceiptNum";
            this.receiptNumCol.Name = "receiptNumCol";
            this.receiptNumCol.OptionsColumn.AllowEdit = false;
            this.receiptNumCol.OptionsColumn.AllowFocus = false;
            this.receiptNumCol.Visible = true;
            this.receiptNumCol.Width = 58;
            // 
            // debitAccountNum
            // 
            this.debitAccountNum.AppearanceCell.BackColor = System.Drawing.Color.Snow;
            this.debitAccountNum.AppearanceCell.Options.UseBackColor = true;
            this.debitAccountNum.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debitAccountNum.AppearanceHeader.Options.UseFont = true;
            this.debitAccountNum.AppearanceHeader.Options.UseTextOptions = true;
            this.debitAccountNum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.debitAccountNum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.debitAccountNum.Caption = "Дебет рахунку";
            this.debitAccountNum.FieldName = "DebitAccountNum";
            this.debitAccountNum.Name = "debitAccountNum";
            this.debitAccountNum.OptionsColumn.AllowEdit = false;
            this.debitAccountNum.OptionsColumn.AllowFocus = false;
            this.debitAccountNum.Visible = true;
            this.debitAccountNum.Width = 67;
            // 
            // nomenclatureCol
            // 
            this.nomenclatureCol.AppearanceCell.BackColor = System.Drawing.Color.Snow;
            this.nomenclatureCol.AppearanceCell.Options.UseBackColor = true;
            this.nomenclatureCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomenclatureCol.AppearanceHeader.Options.UseFont = true;
            this.nomenclatureCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.nomenclatureCol.Caption = "Номенклатурний номер";
            this.nomenclatureCol.FieldName = "Nomenclature";
            this.nomenclatureCol.Name = "nomenclatureCol";
            this.nomenclatureCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureCol.Visible = true;
            this.nomenclatureCol.Width = 114;
            // 
            // nameCol
            // 
            this.nameCol.AppearanceCell.BackColor = System.Drawing.Color.Snow;
            this.nameCol.AppearanceCell.Options.UseBackColor = true;
            this.nameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCol.AppearanceHeader.Options.UseFont = true;
            this.nameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameCol.Caption = "Найменування";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.AllowEdit = false;
            this.nameCol.OptionsColumn.AllowFocus = false;
            this.nameCol.Visible = true;
            this.nameCol.Width = 160;
            // 
            // measureCol
            // 
            this.measureCol.AppearanceCell.BackColor = System.Drawing.Color.Snow;
            this.measureCol.AppearanceCell.Options.UseBackColor = true;
            this.measureCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.measureCol.AppearanceHeader.Options.UseFont = true;
            this.measureCol.AppearanceHeader.Options.UseTextOptions = true;
            this.measureCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.measureCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.measureCol.Caption = "Од. вим.";
            this.measureCol.FieldName = "Measure";
            this.measureCol.Name = "measureCol";
            this.measureCol.OptionsColumn.AllowEdit = false;
            this.measureCol.OptionsColumn.AllowFocus = false;
            this.measureCol.Visible = true;
            this.measureCol.Width = 52;
            // 
            // balanceAccountNumCol
            // 
            this.balanceAccountNumCol.AppearanceCell.BackColor = System.Drawing.Color.Snow;
            this.balanceAccountNumCol.AppearanceCell.Options.UseBackColor = true;
            this.balanceAccountNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceAccountNumCol.AppearanceHeader.Options.UseFont = true;
            this.balanceAccountNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.balanceAccountNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.balanceAccountNumCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.balanceAccountNumCol.Caption = "Бал. рах.";
            this.balanceAccountNumCol.FieldName = "BalanceAccountNum";
            this.balanceAccountNumCol.Name = "balanceAccountNumCol";
            this.balanceAccountNumCol.OptionsColumn.AllowEdit = false;
            this.balanceAccountNumCol.OptionsColumn.AllowFocus = false;
            this.balanceAccountNumCol.Visible = true;
            this.balanceAccountNumCol.Width = 56;
            // 
            // quantityReceiptnCol
            // 
            this.quantityReceiptnCol.AppearanceCell.BackColor = System.Drawing.Color.Snow;
            this.quantityReceiptnCol.AppearanceCell.Options.UseBackColor = true;
            this.quantityReceiptnCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityReceiptnCol.AppearanceHeader.Options.UseFont = true;
            this.quantityReceiptnCol.AppearanceHeader.Options.UseTextOptions = true;
            this.quantityReceiptnCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.quantityReceiptnCol.Caption = "Кількість";
            this.quantityReceiptnCol.DisplayFormat.FormatString = "### ### ##0.#####";
            this.quantityReceiptnCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.quantityReceiptnCol.FieldName = "ReceiptQuantity";
            this.quantityReceiptnCol.Name = "quantityReceiptnCol";
            this.quantityReceiptnCol.OptionsColumn.AllowEdit = false;
            this.quantityReceiptnCol.OptionsColumn.AllowFocus = false;
            this.quantityReceiptnCol.Visible = true;
            this.quantityReceiptnCol.Width = 62;
            // 
            // totalPriceCol
            // 
            this.totalPriceCol.AppearanceCell.BackColor = System.Drawing.Color.Snow;
            this.totalPriceCol.AppearanceCell.Options.UseBackColor = true;
            this.totalPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalPriceCol.AppearanceHeader.Options.UseFont = true;
            this.totalPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.totalPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.totalPriceCol.Caption = "Сума";
            this.totalPriceCol.DisplayFormat.FormatString = "## ### ##0.00";
            this.totalPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.totalPriceCol.FieldName = "TotalPrice";
            this.totalPriceCol.Name = "totalPriceCol";
            this.totalPriceCol.OptionsColumn.AllowEdit = false;
            this.totalPriceCol.OptionsColumn.AllowFocus = false;
            this.totalPriceCol.Visible = true;
            this.totalPriceCol.Width = 62;
            // 
            // uniPriceCol
            // 
            this.uniPriceCol.AppearanceCell.BackColor = System.Drawing.Color.Snow;
            this.uniPriceCol.AppearanceCell.Options.UseBackColor = true;
            this.uniPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uniPriceCol.AppearanceHeader.Options.UseFont = true;
            this.uniPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.uniPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.uniPriceCol.Caption = "Ціна за од.";
            this.uniPriceCol.DisplayFormat.FormatString = "## ### ##0.00";
            this.uniPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.uniPriceCol.FieldName = "UnitPrice";
            this.uniPriceCol.Name = "uniPriceCol";
            this.uniPriceCol.OptionsColumn.AllowEdit = false;
            this.uniPriceCol.OptionsColumn.AllowFocus = false;
            this.uniPriceCol.Visible = true;
            this.uniPriceCol.Width = 106;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Списання";
            this.gridBand2.Columns.Add(this.expDateCol);
            this.gridBand2.Columns.Add(this.unitPriceCol);
            this.gridBand2.Columns.Add(this.expPriceCol);
            this.gridBand2.Columns.Add(this.creditAccountNumCol);
            this.gridBand2.Columns.Add(this.remainsCol);
            this.gridBand2.Columns.Add(this.projectCol);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 560;
            // 
            // expDateCol
            // 
            this.expDateCol.AppearanceCell.BackColor = System.Drawing.Color.Ivory;
            this.expDateCol.AppearanceCell.Options.UseBackColor = true;
            this.expDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expDateCol.AppearanceHeader.Options.UseFont = true;
            this.expDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.expDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.expDateCol.Caption = "Дата";
            this.expDateCol.FieldName = "ExpDate";
            this.expDateCol.Name = "expDateCol";
            this.expDateCol.OptionsColumn.AllowEdit = false;
            this.expDateCol.OptionsColumn.AllowFocus = false;
            this.expDateCol.Visible = true;
            this.expDateCol.Width = 48;
            // 
            // unitPriceCol
            // 
            this.unitPriceCol.AppearanceCell.BackColor = System.Drawing.Color.Ivory;
            this.unitPriceCol.AppearanceCell.Options.UseBackColor = true;
            this.unitPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitPriceCol.AppearanceHeader.Options.UseFont = true;
            this.unitPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.unitPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unitPriceCol.Caption = "Кількість";
            this.unitPriceCol.FieldName = "Quantity";
            this.unitPriceCol.Name = "unitPriceCol";
            this.unitPriceCol.OptionsColumn.AllowEdit = false;
            this.unitPriceCol.OptionsColumn.AllowFocus = false;
            this.unitPriceCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:### ### ##0.#####}")});
            this.unitPriceCol.Visible = true;
            this.unitPriceCol.Width = 63;
            // 
            // expPriceCol
            // 
            this.expPriceCol.AppearanceCell.BackColor = System.Drawing.Color.Ivory;
            this.expPriceCol.AppearanceCell.Options.UseBackColor = true;
            this.expPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expPriceCol.AppearanceHeader.Options.UseFont = true;
            this.expPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.expPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.expPriceCol.Caption = "Сума";
            this.expPriceCol.DisplayFormat.FormatString = "## ### ##0.00";
            this.expPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.expPriceCol.FieldName = "ExpPrice";
            this.expPriceCol.Name = "expPriceCol";
            this.expPriceCol.OptionsColumn.AllowEdit = false;
            this.expPriceCol.OptionsColumn.AllowFocus = false;
            this.expPriceCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ExpPrice", "{0:### ### ##0.00}")});
            this.expPriceCol.Visible = true;
            this.expPriceCol.Width = 62;
            // 
            // creditAccountNumCol
            // 
            this.creditAccountNumCol.AppearanceCell.BackColor = System.Drawing.Color.Ivory;
            this.creditAccountNumCol.AppearanceCell.Options.UseBackColor = true;
            this.creditAccountNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creditAccountNumCol.AppearanceHeader.Options.UseFont = true;
            this.creditAccountNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.creditAccountNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.creditAccountNumCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.creditAccountNumCol.Caption = "Кредит. рах";
            this.creditAccountNumCol.FieldName = "CreditAccountNum";
            this.creditAccountNumCol.Name = "creditAccountNumCol";
            this.creditAccountNumCol.OptionsColumn.AllowEdit = false;
            this.creditAccountNumCol.OptionsColumn.AllowFocus = false;
            this.creditAccountNumCol.Visible = true;
            this.creditAccountNumCol.Width = 61;
            // 
            // remainsCol
            // 
            this.remainsCol.AppearanceCell.BackColor = System.Drawing.Color.Ivory;
            this.remainsCol.AppearanceCell.Options.UseBackColor = true;
            this.remainsCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remainsCol.AppearanceHeader.Options.UseFont = true;
            this.remainsCol.AppearanceHeader.Options.UseTextOptions = true;
            this.remainsCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.remainsCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.remainsCol.Caption = "Кількість залишку";
            this.remainsCol.DisplayFormat.FormatString = "### ### ##0.#####";
            this.remainsCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.remainsCol.FieldName = "Remains";
            this.remainsCol.Name = "remainsCol";
            this.remainsCol.OptionsColumn.AllowEdit = false;
            this.remainsCol.OptionsColumn.AllowFocus = false;
            this.remainsCol.Visible = true;
            this.remainsCol.Width = 92;
            // 
            // projectCol
            // 
            this.projectCol.AppearanceCell.BackColor = System.Drawing.Color.Ivory;
            this.projectCol.AppearanceCell.Options.UseBackColor = true;
            this.projectCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectCol.AppearanceHeader.Options.UseFont = true;
            this.projectCol.AppearanceHeader.Options.UseTextOptions = true;
            this.projectCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.projectCol.Caption = "Проект";
            this.projectCol.FieldName = "ProjectNum";
            this.projectCol.Name = "projectCol";
            this.projectCol.OptionsColumn.AllowEdit = false;
            this.projectCol.OptionsColumn.AllowFocus = false;
            this.projectCol.Visible = true;
            this.projectCol.Width = 234;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // ExpendituresJournalFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 561);
            this.Controls.Add(this.expendituresGrid);
            this.Controls.Add(this.panelControl2);
            this.Name = "ExpendituresJournalFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Журнал списань";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExpendituresJournalFm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expendituresGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenditureBandedGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit beginDateEdit;
        private DevExpress.XtraEditors.DateEdit endDateEdit;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton showExpenditureBtn;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl expendituresGrid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView expenditureBandedGridView;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn orderDateCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn receiptNumCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn debitAccountNum;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn nomenclatureCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn nameCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn measureCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn balanceAccountNumCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn quantityReceiptnCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn totalPriceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn uniPriceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn expDateCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn unitPriceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn expPriceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn creditAccountNumCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn remainsCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn projectCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}