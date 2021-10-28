namespace ERP_NEW.GUI.StoreHouse
{
    partial class InvoiceRequirementSelectFixedAssetsFm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.invoiceRequirementSelectFixedAssetsGrid = new DevExpress.XtraGrid.GridControl();
            this.invoiceRequirementSelectFixedAssetsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.inventoryNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inventoryNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.beginDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fullNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceRequirementSelectFixedAssetsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceRequirementSelectFixedAssetsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.invoiceRequirementSelectFixedAssetsGrid);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1085, 526);
            this.groupControl1.TabIndex = 0;
            // 
            // invoiceRequirementSelectFixedAssetsGrid
            // 
            this.invoiceRequirementSelectFixedAssetsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceRequirementSelectFixedAssetsGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invoiceRequirementSelectFixedAssetsGrid.Location = new System.Drawing.Point(2, 25);
            this.invoiceRequirementSelectFixedAssetsGrid.MainView = this.invoiceRequirementSelectFixedAssetsGridView;
            this.invoiceRequirementSelectFixedAssetsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invoiceRequirementSelectFixedAssetsGrid.Name = "invoiceRequirementSelectFixedAssetsGrid";
            this.invoiceRequirementSelectFixedAssetsGrid.Size = new System.Drawing.Size(1081, 499);
            this.invoiceRequirementSelectFixedAssetsGrid.TabIndex = 0;
            this.invoiceRequirementSelectFixedAssetsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.invoiceRequirementSelectFixedAssetsGridView});
            // 
            // invoiceRequirementSelectFixedAssetsGridView
            // 
            this.invoiceRequirementSelectFixedAssetsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.inventoryNumberCol,
            this.inventoryNameCol,
            this.beginDateCol,
            this.fullNameCol,
            this.groupNameCol});
            this.invoiceRequirementSelectFixedAssetsGridView.GridControl = this.invoiceRequirementSelectFixedAssetsGrid;
            this.invoiceRequirementSelectFixedAssetsGridView.Name = "invoiceRequirementSelectFixedAssetsGridView";
            this.invoiceRequirementSelectFixedAssetsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.invoiceRequirementSelectFixedAssetsGridView.OptionsView.ShowAutoFilterRow = true;
            this.invoiceRequirementSelectFixedAssetsGridView.OptionsView.ShowFooter = true;
            this.invoiceRequirementSelectFixedAssetsGridView.OptionsView.ShowGroupPanel = false;
            this.invoiceRequirementSelectFixedAssetsGridView.DoubleClick += new System.EventHandler(this.invoiceRequirementSelectFixedAssetsGridView_DoubleClick);
            // 
            // inventoryNumberCol
            // 
            this.inventoryNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.inventoryNumberCol.AppearanceHeader.Options.UseFont = true;
            this.inventoryNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.inventoryNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.inventoryNumberCol.Caption = "Інвентарний номер";
            this.inventoryNumberCol.FieldName = "InventoryNumber";
            this.inventoryNumberCol.Name = "inventoryNumberCol";
            this.inventoryNumberCol.OptionsColumn.AllowEdit = false;
            this.inventoryNumberCol.OptionsColumn.AllowFocus = false;
            this.inventoryNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.inventoryNumberCol.Visible = true;
            this.inventoryNumberCol.VisibleIndex = 0;
            this.inventoryNumberCol.Width = 129;
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
            this.inventoryNameCol.Width = 268;
            // 
            // beginDateCol
            // 
            this.beginDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.beginDateCol.AppearanceHeader.Options.UseFont = true;
            this.beginDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.beginDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.beginDateCol.Caption = "Дата прийняття до обліку";
            this.beginDateCol.FieldName = "BeginDate";
            this.beginDateCol.Name = "beginDateCol";
            this.beginDateCol.OptionsColumn.AllowEdit = false;
            this.beginDateCol.OptionsColumn.AllowFocus = false;
            this.beginDateCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.beginDateCol.Visible = true;
            this.beginDateCol.VisibleIndex = 2;
            this.beginDateCol.Width = 163;
            // 
            // fullNameCol
            // 
            this.fullNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fullNameCol.AppearanceHeader.Options.UseFont = true;
            this.fullNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.fullNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fullNameCol.Caption = "Відповідальна особа";
            this.fullNameCol.FieldName = "FullName";
            this.fullNameCol.Name = "fullNameCol";
            this.fullNameCol.OptionsColumn.AllowEdit = false;
            this.fullNameCol.OptionsColumn.AllowFocus = false;
            this.fullNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.fullNameCol.Visible = true;
            this.fullNameCol.VisibleIndex = 3;
            this.fullNameCol.Width = 170;
            // 
            // groupNameCol
            // 
            this.groupNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupNameCol.AppearanceHeader.Options.UseFont = true;
            this.groupNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.groupNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupNameCol.Caption = "Група";
            this.groupNameCol.FieldName = "GroupName";
            this.groupNameCol.Name = "groupNameCol";
            this.groupNameCol.OptionsColumn.AllowEdit = false;
            this.groupNameCol.OptionsColumn.AllowFocus = false;
            this.groupNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.groupNameCol.Visible = true;
            this.groupNameCol.VisibleIndex = 4;
            this.groupNameCol.Width = 178;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(983, 544);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(87, 28);
            this.cancelBtn.TabIndex = 21;
            this.cancelBtn.Text = "Відмінити";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(890, 544);
            this.okBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(87, 28);
            this.okBtn.TabIndex = 20;
            this.okBtn.Text = "Вибрати";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // InvoiceRequirementSelectFixedAssetsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 587);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.okBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceRequirementSelectFixedAssetsFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Основні засоби";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceRequirementSelectFixedAssetsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceRequirementSelectFixedAssetsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl invoiceRequirementSelectFixedAssetsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView invoiceRequirementSelectFixedAssetsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn inventoryNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn inventoryNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn beginDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn fullNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn groupNameCol;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton okBtn;
    }
}