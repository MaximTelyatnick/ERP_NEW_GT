namespace ERP_NEW.GUI.StoreHouse
{
    partial class InvoiceRequirementFixedAssetsJournalFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceRequirementFixedAssetsJournalFm));
            this.invoiceFixedAssetsGrid = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.fixedAssetsNumberCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.fixedAssetsNameCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.fixedAssetsGroupCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.responsiblePersonCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.descriptionCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ReceiptNumberCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.nomenclatureCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.nomenclatureNameCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.balanceNumberCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.invoiceNumberCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.invoiceDateCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.responsiblePersonInvoiceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.quantityCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.unitPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.totalPriceCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.creditNumberCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.printBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceFixedAssetsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceFixedAssetsGrid
            // 
            this.invoiceFixedAssetsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceFixedAssetsGrid.Location = new System.Drawing.Point(0, 0);
            this.invoiceFixedAssetsGrid.MainView = this.bandedGridView1;
            this.invoiceFixedAssetsGrid.Name = "invoiceFixedAssetsGrid";
            this.invoiceFixedAssetsGrid.Size = new System.Drawing.Size(1678, 753);
            this.invoiceFixedAssetsGrid.TabIndex = 0;
            this.invoiceFixedAssetsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.fixedAssetsNumberCol,
            this.fixedAssetsNameCol,
            this.fixedAssetsGroupCol,
            this.responsiblePersonCol,
            this.descriptionCol,
            this.ReceiptNumberCol,
            this.nomenclatureCol,
            this.nomenclatureNameCol,
            this.balanceNumberCol,
            this.invoiceNumberCol,
            this.invoiceDateCol,
            this.responsiblePersonInvoiceCol,
            this.quantityCol,
            this.unitPriceCol,
            this.totalPriceCol,
            this.creditNumberCol});
            this.bandedGridView1.GridControl = this.invoiceFixedAssetsGrid;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.bandedGridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Основні засоби";
            this.gridBand1.Columns.Add(this.fixedAssetsNumberCol);
            this.gridBand1.Columns.Add(this.fixedAssetsNameCol);
            this.gridBand1.Columns.Add(this.fixedAssetsGroupCol);
            this.gridBand1.Columns.Add(this.responsiblePersonCol);
            this.gridBand1.Columns.Add(this.descriptionCol);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 375;
            // 
            // fixedAssetsNumberCol
            // 
            this.fixedAssetsNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fixedAssetsNumberCol.AppearanceHeader.Options.UseFont = true;
            this.fixedAssetsNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.fixedAssetsNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fixedAssetsNumberCol.Caption = "Инв. номер";
            this.fixedAssetsNumberCol.FieldName = "InventoryNumber";
            this.fixedAssetsNumberCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.fixedAssetsNumberCol.Name = "fixedAssetsNumberCol";
            this.fixedAssetsNumberCol.OptionsColumn.AllowEdit = false;
            this.fixedAssetsNumberCol.OptionsColumn.AllowFocus = false;
            this.fixedAssetsNumberCol.Visible = true;
            // 
            // fixedAssetsNameCol
            // 
            this.fixedAssetsNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fixedAssetsNameCol.AppearanceHeader.Options.UseFont = true;
            this.fixedAssetsNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.fixedAssetsNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fixedAssetsNameCol.Caption = "Найменування ОЗ";
            this.fixedAssetsNameCol.FieldName = "InventoryName";
            this.fixedAssetsNameCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.fixedAssetsNameCol.Name = "fixedAssetsNameCol";
            this.fixedAssetsNameCol.OptionsColumn.AllowEdit = false;
            this.fixedAssetsNameCol.OptionsColumn.AllowFocus = false;
            this.fixedAssetsNameCol.Visible = true;
            // 
            // fixedAssetsGroupCol
            // 
            this.fixedAssetsGroupCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fixedAssetsGroupCol.AppearanceHeader.Options.UseFont = true;
            this.fixedAssetsGroupCol.AppearanceHeader.Options.UseTextOptions = true;
            this.fixedAssetsGroupCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fixedAssetsGroupCol.Caption = "Група ОЗ";
            this.fixedAssetsGroupCol.FieldName = "GroupName";
            this.fixedAssetsGroupCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.fixedAssetsGroupCol.Name = "fixedAssetsGroupCol";
            this.fixedAssetsGroupCol.OptionsColumn.AllowEdit = false;
            this.fixedAssetsGroupCol.OptionsColumn.AllowFocus = false;
            this.fixedAssetsGroupCol.Visible = true;
            // 
            // responsiblePersonCol
            // 
            this.responsiblePersonCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.responsiblePersonCol.AppearanceHeader.Options.UseFont = true;
            this.responsiblePersonCol.AppearanceHeader.Options.UseTextOptions = true;
            this.responsiblePersonCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.responsiblePersonCol.Caption = "Відповідальна особа";
            this.responsiblePersonCol.FieldName = "FixedSupplierFullName";
            this.responsiblePersonCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.responsiblePersonCol.Name = "responsiblePersonCol";
            this.responsiblePersonCol.OptionsColumn.AllowEdit = false;
            this.responsiblePersonCol.OptionsColumn.AllowFocus = false;
            this.responsiblePersonCol.Visible = true;
            // 
            // descriptionCol
            // 
            this.descriptionCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.descriptionCol.AppearanceHeader.Options.UseFont = true;
            this.descriptionCol.AppearanceHeader.Options.UseTextOptions = true;
            this.descriptionCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.descriptionCol.Caption = "Опис";
            this.descriptionCol.FieldName = "Description";
            this.descriptionCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.descriptionCol.Name = "descriptionCol";
            this.descriptionCol.OptionsColumn.AllowEdit = false;
            this.descriptionCol.OptionsColumn.AllowFocus = false;
            this.descriptionCol.Visible = true;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Вимоги";
            this.gridBand2.Columns.Add(this.ReceiptNumberCol);
            this.gridBand2.Columns.Add(this.nomenclatureCol);
            this.gridBand2.Columns.Add(this.nomenclatureNameCol);
            this.gridBand2.Columns.Add(this.balanceNumberCol);
            this.gridBand2.Columns.Add(this.invoiceNumberCol);
            this.gridBand2.Columns.Add(this.invoiceDateCol);
            this.gridBand2.Columns.Add(this.responsiblePersonInvoiceCol);
            this.gridBand2.Columns.Add(this.quantityCol);
            this.gridBand2.Columns.Add(this.unitPriceCol);
            this.gridBand2.Columns.Add(this.totalPriceCol);
            this.gridBand2.Columns.Add(this.creditNumberCol);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 825;
            // 
            // ReceiptNumberCol
            // 
            this.ReceiptNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ReceiptNumberCol.AppearanceHeader.Options.UseFont = true;
            this.ReceiptNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.ReceiptNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ReceiptNumberCol.Caption = "Ном. надх.";
            this.ReceiptNumberCol.FieldName = "ReceiptNum";
            this.ReceiptNumberCol.Name = "ReceiptNumberCol";
            this.ReceiptNumberCol.OptionsColumn.AllowEdit = false;
            this.ReceiptNumberCol.OptionsColumn.AllowFocus = false;
            this.ReceiptNumberCol.Visible = true;
            // 
            // nomenclatureCol
            // 
            this.nomenclatureCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nomenclatureCol.AppearanceHeader.Options.UseFont = true;
            this.nomenclatureCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureCol.Caption = "Номенкл.";
            this.nomenclatureCol.FieldName = "Nomenclature";
            this.nomenclatureCol.Name = "nomenclatureCol";
            this.nomenclatureCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureCol.Visible = true;
            // 
            // nomenclatureNameCol
            // 
            this.nomenclatureNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nomenclatureNameCol.AppearanceHeader.Options.UseFont = true;
            this.nomenclatureNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureNameCol.Caption = "Найменування";
            this.nomenclatureNameCol.FieldName = "NomenclatureName";
            this.nomenclatureNameCol.Name = "nomenclatureNameCol";
            this.nomenclatureNameCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureNameCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureNameCol.Visible = true;
            // 
            // balanceNumberCol
            // 
            this.balanceNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.balanceNumberCol.AppearanceHeader.Options.UseFont = true;
            this.balanceNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.balanceNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.balanceNumberCol.Caption = "Бал. рах.";
            this.balanceNumberCol.FieldName = "BalanceAccountNum";
            this.balanceNumberCol.Name = "balanceNumberCol";
            this.balanceNumberCol.OptionsColumn.AllowEdit = false;
            this.balanceNumberCol.OptionsColumn.AllowFocus = false;
            this.balanceNumberCol.Visible = true;
            // 
            // invoiceNumberCol
            // 
            this.invoiceNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.invoiceNumberCol.AppearanceHeader.Options.UseFont = true;
            this.invoiceNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.invoiceNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.invoiceNumberCol.Caption = "Номер";
            this.invoiceNumberCol.FieldName = "Number";
            this.invoiceNumberCol.Name = "invoiceNumberCol";
            this.invoiceNumberCol.OptionsColumn.AllowEdit = false;
            this.invoiceNumberCol.OptionsColumn.AllowFocus = false;
            this.invoiceNumberCol.Visible = true;
            // 
            // invoiceDateCol
            // 
            this.invoiceDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.invoiceDateCol.AppearanceHeader.Options.UseFont = true;
            this.invoiceDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.invoiceDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.invoiceDateCol.Caption = "Дата";
            this.invoiceDateCol.FieldName = "Date";
            this.invoiceDateCol.Name = "invoiceDateCol";
            this.invoiceDateCol.OptionsColumn.AllowEdit = false;
            this.invoiceDateCol.OptionsColumn.AllowFocus = false;
            this.invoiceDateCol.Visible = true;
            // 
            // responsiblePersonInvoiceCol
            // 
            this.responsiblePersonInvoiceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.responsiblePersonInvoiceCol.AppearanceHeader.Options.UseFont = true;
            this.responsiblePersonInvoiceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.responsiblePersonInvoiceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.responsiblePersonInvoiceCol.Caption = "Відповідальна особа";
            this.responsiblePersonInvoiceCol.FieldName = "InvoiceSupplierFullName";
            this.responsiblePersonInvoiceCol.Name = "responsiblePersonInvoiceCol";
            this.responsiblePersonInvoiceCol.OptionsColumn.AllowEdit = false;
            this.responsiblePersonInvoiceCol.OptionsColumn.AllowFocus = false;
            this.responsiblePersonInvoiceCol.Visible = true;
            // 
            // quantityCol
            // 
            this.quantityCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.quantityCol.AppearanceHeader.Options.UseFont = true;
            this.quantityCol.Caption = "Кількість";
            this.quantityCol.FieldName = "Quantity";
            this.quantityCol.Name = "quantityCol";
            this.quantityCol.OptionsColumn.AllowEdit = false;
            this.quantityCol.OptionsColumn.AllowFocus = false;
            this.quantityCol.Visible = true;
            // 
            // unitPriceCol
            // 
            this.unitPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.unitPriceCol.AppearanceHeader.Options.UseFont = true;
            this.unitPriceCol.Caption = "Ціна";
            this.unitPriceCol.FieldName = "UnitPrice";
            this.unitPriceCol.Name = "unitPriceCol";
            this.unitPriceCol.OptionsColumn.AllowEdit = false;
            this.unitPriceCol.OptionsColumn.AllowFocus = false;
            this.unitPriceCol.Visible = true;
            // 
            // totalPriceCol
            // 
            this.totalPriceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.totalPriceCol.AppearanceHeader.Options.UseFont = true;
            this.totalPriceCol.Caption = "Сума";
            this.totalPriceCol.FieldName = "TotalPrice";
            this.totalPriceCol.Name = "totalPriceCol";
            this.totalPriceCol.OptionsColumn.AllowEdit = false;
            this.totalPriceCol.OptionsColumn.AllowFocus = false;
            this.totalPriceCol.Visible = true;
            // 
            // creditNumberCol
            // 
            this.creditNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.creditNumberCol.AppearanceHeader.Options.UseFont = true;
            this.creditNumberCol.Caption = "Кредит рах.";
            this.creditNumberCol.FieldName = "CreditAccountNum";
            this.creditNumberCol.Name = "creditNumberCol";
            this.creditNumberCol.OptionsColumn.AllowEdit = false;
            this.creditNumberCol.OptionsColumn.AllowFocus = false;
            this.creditNumberCol.Visible = true;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // printBtn
            // 
            this.printBtn.Image = ((System.Drawing.Image)(resources.GetObject("printBtn.Image")));
            this.printBtn.Location = new System.Drawing.Point(1595, 4);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 23);
            this.printBtn.TabIndex = 1;
            this.printBtn.Text = "Печать";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // InvoiceRequirementFixedAssetsJournalFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 753);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.invoiceFixedAssetsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceRequirementFixedAssetsJournalFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вимоги на основні засоби";
            ((System.ComponentModel.ISupportInitialize)(this.invoiceFixedAssetsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl invoiceFixedAssetsGrid;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn fixedAssetsNumberCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn fixedAssetsNameCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn fixedAssetsGroupCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn responsiblePersonCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn descriptionCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ReceiptNumberCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn nomenclatureCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn nomenclatureNameCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn balanceNumberCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn invoiceNumberCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn invoiceDateCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn responsiblePersonInvoiceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn quantityCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn unitPriceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn totalPriceCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn creditNumberCol;
        private DevExpress.XtraEditors.SimpleButton printBtn;
    }
}