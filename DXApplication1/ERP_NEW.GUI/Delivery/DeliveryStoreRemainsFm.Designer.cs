namespace ERP_NEW.GUI.Delivery
{
    partial class DeliveryStoreRemainsFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryStoreRemainsFm));
            this.deliveryStoreRemainsGrid = new DevExpress.XtraGrid.GridControl();
            this.deliveryStoreRemainsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nomenclatureCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nomenclatureNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.remainsQuantityCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.remainsPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.measureCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.showForDate = new DevExpress.XtraEditors.SimpleButton();
            this.endDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.xlsBtn = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.deliveryStoreRemainsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryStoreRemainsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deliveryStoreRemainsGrid
            // 
            this.deliveryStoreRemainsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryStoreRemainsGrid.Location = new System.Drawing.Point(3, 50);
            this.deliveryStoreRemainsGrid.MainView = this.deliveryStoreRemainsGridView;
            this.deliveryStoreRemainsGrid.Name = "deliveryStoreRemainsGrid";
            this.deliveryStoreRemainsGrid.Size = new System.Drawing.Size(1725, 510);
            this.deliveryStoreRemainsGrid.TabIndex = 0;
            this.deliveryStoreRemainsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.deliveryStoreRemainsGridView});
            // 
            // deliveryStoreRemainsGridView
            // 
            this.deliveryStoreRemainsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nomenclatureCol,
            this.nomenclatureNameCol,
            this.remainsQuantityCol,
            this.remainsPriceCol,
            this.measureCol});
            this.deliveryStoreRemainsGridView.GridControl = this.deliveryStoreRemainsGrid;
            this.deliveryStoreRemainsGridView.Name = "deliveryStoreRemainsGridView";
            this.deliveryStoreRemainsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.deliveryStoreRemainsGridView.OptionsView.ShowAutoFilterRow = true;
            this.deliveryStoreRemainsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // nomenclatureCol
            // 
            this.nomenclatureCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureCol.Caption = "Номенкл. номер";
            this.nomenclatureCol.FieldName = "Nomenclature";
            this.nomenclatureCol.Name = "nomenclatureCol";
            this.nomenclatureCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nomenclatureCol.Visible = true;
            this.nomenclatureCol.VisibleIndex = 0;
            this.nomenclatureCol.Width = 145;
            // 
            // nomenclatureNameCol
            // 
            this.nomenclatureNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureNameCol.Caption = "Наименування";
            this.nomenclatureNameCol.FieldName = "NomenclatureName";
            this.nomenclatureNameCol.Name = "nomenclatureNameCol";
            this.nomenclatureNameCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureNameCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nomenclatureNameCol.Visible = true;
            this.nomenclatureNameCol.VisibleIndex = 1;
            this.nomenclatureNameCol.Width = 792;
            // 
            // remainsQuantityCol
            // 
            this.remainsQuantityCol.AppearanceHeader.Options.UseTextOptions = true;
            this.remainsQuantityCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.remainsQuantityCol.Caption = "Залишки,кількість";
            this.remainsQuantityCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.remainsQuantityCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.remainsQuantityCol.FieldName = "RemainsQuantity";
            this.remainsQuantityCol.Name = "remainsQuantityCol";
            this.remainsQuantityCol.OptionsColumn.AllowEdit = false;
            this.remainsQuantityCol.OptionsColumn.AllowFocus = false;
            this.remainsQuantityCol.Visible = true;
            this.remainsQuantityCol.VisibleIndex = 2;
            this.remainsQuantityCol.Width = 160;
            // 
            // remainsPriceCol
            // 
            this.remainsPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.remainsPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.remainsPriceCol.Caption = "Залишки, сума (грн.)";
            this.remainsPriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.remainsPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.remainsPriceCol.FieldName = "RemainsPrice";
            this.remainsPriceCol.Name = "remainsPriceCol";
            this.remainsPriceCol.OptionsColumn.AllowEdit = false;
            this.remainsPriceCol.OptionsColumn.AllowFocus = false;
            this.remainsPriceCol.Visible = true;
            this.remainsPriceCol.VisibleIndex = 3;
            this.remainsPriceCol.Width = 208;
            // 
            // measureCol
            // 
            this.measureCol.AppearanceHeader.Options.UseTextOptions = true;
            this.measureCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.measureCol.Caption = "Од.вим.";
            this.measureCol.FieldName = "Measure";
            this.measureCol.Name = "measureCol";
            this.measureCol.OptionsColumn.AllowEdit = false;
            this.measureCol.OptionsColumn.AllowFocus = false;
            this.measureCol.Visible = true;
            this.measureCol.VisibleIndex = 4;
            this.measureCol.Width = 101;
            // 
            // showForDate
            // 
            this.showForDate.Image = ((System.Drawing.Image)(resources.GetObject("showForDate.Image")));
            this.showForDate.Location = new System.Drawing.Point(188, 1);
            this.showForDate.Name = "showForDate";
            this.showForDate.Size = new System.Drawing.Size(42, 36);
            this.showForDate.TabIndex = 10;
            this.showForDate.ToolTip = "Показати";
            this.showForDate.Click += new System.EventHandler(this.showStoreRemainsForDate_Click);
            // 
            // endDateEdit
            // 
            this.endDateEdit.EditValue = null;
            this.endDateEdit.Location = new System.Drawing.Point(79, 8);
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
            this.labelControl2.Location = new System.Drawing.Point(11, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Залишки на";
            // 
            // xlsBtn
            // 
            this.xlsBtn.Image = ((System.Drawing.Image)(resources.GetObject("xlsBtn.Image")));
            this.xlsBtn.Location = new System.Drawing.Point(249, 6);
            this.xlsBtn.Name = "xlsBtn";
            this.xlsBtn.Size = new System.Drawing.Size(42, 36);
            this.xlsBtn.TabIndex = 22;
            this.xlsBtn.ToolTip = "Відобразити в Excel";
            this.xlsBtn.Click += new System.EventHandler(this.xlsBtn_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.showForDate);
            this.panelControl2.Controls.Add(this.endDateEdit);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(4, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(239, 38);
            this.panelControl2.TabIndex = 21;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // DeliveryStoreRemainsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 572);
            this.Controls.Add(this.xlsBtn);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.deliveryStoreRemainsGrid);
            this.Name = "DeliveryStoreRemainsFm";
            this.ShowIcon = false;
            this.Text = "Залишки на складі";
            ((System.ComponentModel.ISupportInitialize)(this.deliveryStoreRemainsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryStoreRemainsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl deliveryStoreRemainsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView deliveryStoreRemainsGridView;
        private DevExpress.XtraEditors.SimpleButton showForDate;
        private DevExpress.XtraEditors.DateEdit endDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton xlsBtn;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclatureCol;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclatureNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn remainsQuantityCol;
        private DevExpress.XtraGrid.Columns.GridColumn measureCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Columns.GridColumn remainsPriceCol;
    }
}