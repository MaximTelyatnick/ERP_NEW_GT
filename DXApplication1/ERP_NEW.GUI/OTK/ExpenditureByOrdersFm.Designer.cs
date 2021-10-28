namespace ERP_NEW.GUI.OTK
{
    partial class ExpenditureByOrdersFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenditureByOrdersFm));
            this.expendituresGrid = new DevExpress.XtraGrid.GridControl();
            this.expendituresGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.invoiceNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invoiceDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receiptNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vendorNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vendorSrnCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nomenclatureCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nomenclatureNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.measureCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.certificfteNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.certificfteDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.сustomerOrderNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.showOrdersForDate = new DevExpress.XtraEditors.SimpleButton();
            this.endDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.beginDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.expendituresGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expendituresGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // expendituresGrid
            // 
            this.expendituresGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expendituresGrid.Location = new System.Drawing.Point(2, 45);
            this.expendituresGrid.MainView = this.expendituresGridView;
            this.expendituresGrid.Name = "expendituresGrid";
            this.expendituresGrid.Size = new System.Drawing.Size(1647, 601);
            this.expendituresGrid.TabIndex = 0;
            this.expendituresGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.expendituresGridView});
            // 
            // expendituresGridView
            // 
            this.expendituresGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.invoiceNumCol,
            this.invoiceDateCol,
            this.receiptNumCol,
            this.orderDateCol,
            this.vendorNameCol,
            this.vendorSrnCol,
            this.nomenclatureCol,
            this.nomenclatureNameCol,
            this.measureCol,
            this.certificfteNumberCol,
            this.certificfteDateCol,
            this.сustomerOrderNumberCol,
            this.groupCol});
            this.expendituresGridView.GridControl = this.expendituresGrid;
            this.expendituresGridView.GroupCount = 1;
            this.expendituresGridView.Name = "expendituresGridView";
            this.expendituresGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.expendituresGridView.OptionsView.RowAutoHeight = true;
            this.expendituresGridView.OptionsView.ShowAutoFilterRow = true;
            this.expendituresGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.groupCol, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // invoiceNumCol
            // 
            this.invoiceNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.invoiceNumCol.AppearanceHeader.Options.UseFont = true;
            this.invoiceNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.invoiceNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.invoiceNumCol.Caption = "№ накладної";
            this.invoiceNumCol.FieldName = "InvoiceNum";
            this.invoiceNumCol.Name = "invoiceNumCol";
            this.invoiceNumCol.OptionsColumn.AllowEdit = false;
            this.invoiceNumCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.invoiceNumCol.Visible = true;
            this.invoiceNumCol.VisibleIndex = 1;
            this.invoiceNumCol.Width = 104;
            // 
            // invoiceDateCol
            // 
            this.invoiceDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
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
            this.invoiceDateCol.Width = 98;
            // 
            // receiptNumCol
            // 
            this.receiptNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.receiptNumCol.AppearanceHeader.Options.UseFont = true;
            this.receiptNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.receiptNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.receiptNumCol.Caption = "№ приходу";
            this.receiptNumCol.FieldName = "ReceiptNum";
            this.receiptNumCol.Name = "receiptNumCol";
            this.receiptNumCol.OptionsColumn.AllowEdit = false;
            this.receiptNumCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.receiptNumCol.Visible = true;
            this.receiptNumCol.VisibleIndex = 3;
            this.receiptNumCol.Width = 103;
            // 
            // orderDateCol
            // 
            this.orderDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.orderDateCol.AppearanceHeader.Options.UseFont = true;
            this.orderDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderDateCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.orderDateCol.Caption = "Дата приходу";
            this.orderDateCol.FieldName = "OrderDate";
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.OptionsColumn.AllowEdit = false;
            this.orderDateCol.Visible = true;
            this.orderDateCol.VisibleIndex = 4;
            this.orderDateCol.Width = 99;
            // 
            // vendorNameCol
            // 
            this.vendorNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.vendorNameCol.AppearanceHeader.Options.UseFont = true;
            this.vendorNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.vendorNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vendorNameCol.Caption = "Контрагент";
            this.vendorNameCol.FieldName = "VendorName";
            this.vendorNameCol.Name = "vendorNameCol";
            this.vendorNameCol.OptionsColumn.AllowEdit = false;
            this.vendorNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.vendorNameCol.Visible = true;
            this.vendorNameCol.VisibleIndex = 8;
            this.vendorNameCol.Width = 328;
            // 
            // vendorSrnCol
            // 
            this.vendorSrnCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.vendorSrnCol.AppearanceHeader.Options.UseFont = true;
            this.vendorSrnCol.AppearanceHeader.Options.UseTextOptions = true;
            this.vendorSrnCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vendorSrnCol.Caption = "Код ЄДРПОУ";
            this.vendorSrnCol.FieldName = "VendorSrn";
            this.vendorSrnCol.Name = "vendorSrnCol";
            this.vendorSrnCol.OptionsColumn.AllowEdit = false;
            this.vendorSrnCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.vendorSrnCol.Visible = true;
            this.vendorSrnCol.VisibleIndex = 9;
            this.vendorSrnCol.Width = 77;
            // 
            // nomenclatureCol
            // 
            this.nomenclatureCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nomenclatureCol.AppearanceHeader.Options.UseFont = true;
            this.nomenclatureCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureCol.Caption = "Номенкл.номер";
            this.nomenclatureCol.FieldName = "Nomenclature";
            this.nomenclatureCol.Name = "nomenclatureCol";
            this.nomenclatureCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nomenclatureCol.Visible = true;
            this.nomenclatureCol.VisibleIndex = 5;
            this.nomenclatureCol.Width = 119;
            // 
            // nomenclatureNameCol
            // 
            this.nomenclatureNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nomenclatureNameCol.AppearanceHeader.Options.UseFont = true;
            this.nomenclatureNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureNameCol.Caption = "Наименування";
            this.nomenclatureNameCol.FieldName = "NomenclatureName";
            this.nomenclatureNameCol.Name = "nomenclatureNameCol";
            this.nomenclatureNameCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nomenclatureNameCol.Visible = true;
            this.nomenclatureNameCol.VisibleIndex = 6;
            this.nomenclatureNameCol.Width = 352;
            // 
            // measureCol
            // 
            this.measureCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.measureCol.AppearanceHeader.Options.UseFont = true;
            this.measureCol.AppearanceHeader.Options.UseTextOptions = true;
            this.measureCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.measureCol.Caption = "Од.вим.";
            this.measureCol.FieldName = "Measure";
            this.measureCol.Name = "measureCol";
            this.measureCol.OptionsColumn.AllowEdit = false;
            this.measureCol.Visible = true;
            this.measureCol.VisibleIndex = 7;
            this.measureCol.Width = 50;
            // 
            // certificfteNumberCol
            // 
            this.certificfteNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.certificfteNumberCol.AppearanceHeader.Options.UseFont = true;
            this.certificfteNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.certificfteNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.certificfteNumberCol.Caption = "№ сертифікату";
            this.certificfteNumberCol.FieldName = "CertificateNumber";
            this.certificfteNumberCol.Name = "certificfteNumberCol";
            this.certificfteNumberCol.OptionsColumn.AllowEdit = false;
            this.certificfteNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.certificfteNumberCol.Visible = true;
            this.certificfteNumberCol.VisibleIndex = 10;
            this.certificfteNumberCol.Width = 96;
            // 
            // certificfteDateCol
            // 
            this.certificfteDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.certificfteDateCol.AppearanceHeader.Options.UseFont = true;
            this.certificfteDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.certificfteDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.certificfteDateCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.certificfteDateCol.Caption = "Дата сертифікату";
            this.certificfteDateCol.FieldName = "CertificateDate";
            this.certificfteDateCol.Name = "certificfteDateCol";
            this.certificfteDateCol.OptionsColumn.AllowEdit = false;
            this.certificfteDateCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.certificfteDateCol.Visible = true;
            this.certificfteDateCol.VisibleIndex = 11;
            this.certificfteDateCol.Width = 105;
            // 
            // сustomerOrderNumberCol
            // 
            this.сustomerOrderNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.сustomerOrderNumberCol.AppearanceHeader.Options.UseFont = true;
            this.сustomerOrderNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.сustomerOrderNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.сustomerOrderNumberCol.Caption = "Заказ";
            this.сustomerOrderNumberCol.FieldName = "CustomerOrderNumber";
            this.сustomerOrderNumberCol.Name = "сustomerOrderNumberCol";
            this.сustomerOrderNumberCol.OptionsColumn.AllowEdit = false;
            this.сustomerOrderNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.сustomerOrderNumberCol.Visible = true;
            this.сustomerOrderNumberCol.VisibleIndex = 0;
            this.сustomerOrderNumberCol.Width = 98;
            // 
            // groupCol
            // 
            this.groupCol.Caption = "Заказ";
            this.groupCol.FieldName = "CustomerOrderNumberGroup";
            this.groupCol.Name = "groupCol";
            this.groupCol.OptionsColumn.AllowEdit = false;
            this.groupCol.Visible = true;
            this.groupCol.VisibleIndex = 12;
            // 
            // showOrdersForDate
            // 
            this.showOrdersForDate.Image = ((System.Drawing.Image)(resources.GetObject("showOrdersForDate.Image")));
            this.showOrdersForDate.Location = new System.Drawing.Point(260, 6);
            this.showOrdersForDate.Name = "showOrdersForDate";
            this.showOrdersForDate.Size = new System.Drawing.Size(27, 23);
            this.showOrdersForDate.TabIndex = 10;
            this.showOrdersForDate.ToolTip = "Показати";
            this.showOrdersForDate.Click += new System.EventHandler(this.showOrdersForDate_Click);
            // 
            // endDateEdit
            // 
            this.endDateEdit.EditValue = null;
            this.endDateEdit.Location = new System.Drawing.Point(154, 8);
            this.endDateEdit.Name = "endDateEdit";
            this.endDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateEdit.Size = new System.Drawing.Size(100, 20);
            this.endDateEdit.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(131, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(13, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "По";
            // 
            // beginDateEdit
            // 
            this.beginDateEdit.EditValue = null;
            this.beginDateEdit.Location = new System.Drawing.Point(20, 9);
            this.beginDateEdit.Name = "beginDateEdit";
            this.beginDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.beginDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.beginDateEdit.Size = new System.Drawing.Size(100, 20);
            this.beginDateEdit.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(6, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "З";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.showOrdersForDate);
            this.panelControl2.Controls.Add(this.endDateEdit);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.beginDateEdit);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Location = new System.Drawing.Point(2, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(298, 36);
            this.panelControl2.TabIndex = 16;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // ExpenditureByOrdersFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1652, 687);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.expendituresGrid);
            this.Name = "ExpenditureByOrdersFm";
            this.ShowIcon = false;
            this.Text = "Списання за проектами";
            ((System.ComponentModel.ISupportInitialize)(this.expendituresGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expendituresGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl expendituresGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView expendituresGridView;
        private DevExpress.XtraGrid.Columns.GridColumn invoiceNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn invoiceDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn receiptNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn orderDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn vendorNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn vendorSrnCol;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclatureCol;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclatureNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn measureCol;
        private DevExpress.XtraGrid.Columns.GridColumn certificfteNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn certificfteDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn сustomerOrderNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn groupCol;
        private DevExpress.XtraEditors.SimpleButton showOrdersForDate;
        private DevExpress.XtraEditors.DateEdit endDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit beginDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}