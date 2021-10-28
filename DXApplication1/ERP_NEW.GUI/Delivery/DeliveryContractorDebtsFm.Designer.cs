namespace ERP_NEW.GUI.Delivery
{
    partial class DeliveryContractorDebtsFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryContractorDebtsFm));
            this.deliveryContractorDebtsGrid = new DevExpress.XtraGrid.GridControl();
            this.deliveryContractorDebtsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.vendorSrnCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vendorNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.priceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.debtStatusCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.showForDate = new DevExpress.XtraEditors.SimpleButton();
            this.endDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.xlsBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryContractorDebtsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryContractorDebtsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deliveryContractorDebtsGrid
            // 
            this.deliveryContractorDebtsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryContractorDebtsGrid.Location = new System.Drawing.Point(0, 42);
            this.deliveryContractorDebtsGrid.MainView = this.deliveryContractorDebtsGridView;
            this.deliveryContractorDebtsGrid.Name = "deliveryContractorDebtsGrid";
            this.deliveryContractorDebtsGrid.Size = new System.Drawing.Size(1425, 603);
            this.deliveryContractorDebtsGrid.TabIndex = 0;
            this.deliveryContractorDebtsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.deliveryContractorDebtsGridView});
            // 
            // deliveryContractorDebtsGridView
            // 
            this.deliveryContractorDebtsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.vendorSrnCol,
            this.vendorNameCol,
            this.priceCol,
            this.debtStatusCol});
            this.deliveryContractorDebtsGridView.GridControl = this.deliveryContractorDebtsGrid;
            this.deliveryContractorDebtsGridView.GroupCount = 1;
            this.deliveryContractorDebtsGridView.Name = "deliveryContractorDebtsGridView";
            this.deliveryContractorDebtsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.deliveryContractorDebtsGridView.OptionsView.ShowAutoFilterRow = true;
            this.deliveryContractorDebtsGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.debtStatusCol, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            this.vendorSrnCol.VisibleIndex = 0;
            this.vendorSrnCol.Width = 101;
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
            this.vendorNameCol.VisibleIndex = 1;
            this.vendorNameCol.Width = 1190;
            // 
            // priceCol
            // 
            this.priceCol.AppearanceCell.Options.UseTextOptions = true;
            this.priceCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.priceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.priceCol.AppearanceHeader.Options.UseFont = true;
            this.priceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.priceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.priceCol.Caption = "Сума";
            this.priceCol.DisplayFormat.FormatString = "{0:### ### ##0.00}";
            this.priceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.priceCol.FieldName = "Price";
            this.priceCol.Name = "priceCol";
            this.priceCol.OptionsColumn.AllowEdit = false;
            this.priceCol.Visible = true;
            this.priceCol.VisibleIndex = 2;
            this.priceCol.Width = 116;
            // 
            // debtStatusCol
            // 
            this.debtStatusCol.Caption = "Тип";
            this.debtStatusCol.FieldName = "DebtStatus";
            this.debtStatusCol.Name = "debtStatusCol";
            // 
            // showForDate
            // 
            this.showForDate.Image = ((System.Drawing.Image)(resources.GetObject("showForDate.Image")));
            this.showForDate.Location = new System.Drawing.Point(222, 1);
            this.showForDate.Name = "showForDate";
            this.showForDate.Size = new System.Drawing.Size(42, 36);
            this.showForDate.TabIndex = 10;
            this.showForDate.ToolTip = "Показати";
            this.showForDate.Click += new System.EventHandler(this.showContractorDebtsForDate_Click);
            // 
            // endDateEdit
            // 
            this.endDateEdit.EditValue = null;
            this.endDateEdit.Location = new System.Drawing.Point(112, 8);
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
            this.labelControl2.Location = new System.Drawing.Point(8, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Заборгованість на";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.showForDate);
            this.panelControl2.Controls.Add(this.endDateEdit);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(4, 3);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(268, 38);
            this.panelControl2.TabIndex = 19;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // xlsBtn
            // 
            this.xlsBtn.Image = ((System.Drawing.Image)(resources.GetObject("xlsBtn.Image")));
            this.xlsBtn.Location = new System.Drawing.Point(281, 4);
            this.xlsBtn.Name = "xlsBtn";
            this.xlsBtn.Size = new System.Drawing.Size(42, 36);
            this.xlsBtn.TabIndex = 20;
            this.xlsBtn.ToolTip = "Відобразити в Excel";
            this.xlsBtn.Click += new System.EventHandler(this.xlsBtn_Click);
            // 
            // DeliveryContractorDebtsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 645);
            this.Controls.Add(this.xlsBtn);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.deliveryContractorDebtsGrid);
            this.Name = "DeliveryContractorDebtsFm";
            this.ShowIcon = false;
            this.Text = "Заборгованість по контрагентам";
            ((System.ComponentModel.ISupportInitialize)(this.deliveryContractorDebtsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryContractorDebtsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl deliveryContractorDebtsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView deliveryContractorDebtsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn vendorSrnCol;
        private DevExpress.XtraGrid.Columns.GridColumn vendorNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn priceCol;
        private DevExpress.XtraGrid.Columns.GridColumn debtStatusCol;
        private DevExpress.XtraEditors.SimpleButton showForDate;
        private DevExpress.XtraEditors.DateEdit endDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraEditors.SimpleButton xlsBtn;
    }
}