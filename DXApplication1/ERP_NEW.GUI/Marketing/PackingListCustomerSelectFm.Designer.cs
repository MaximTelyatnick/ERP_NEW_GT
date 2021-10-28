namespace ERP_NEW.GUI.Marketing
{
    partial class PackingListCustomerSelectFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackingListCustomerSelectFm));
            this.customerOrdersGrid = new DevExpress.XtraGrid.GridControl();
            this.customerOrdersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.orderNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contractorCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selectedCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerOrdersGrid
            // 
            this.customerOrdersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerOrdersGrid.Location = new System.Drawing.Point(2, 20);
            this.customerOrdersGrid.MainView = this.customerOrdersGridView;
            this.customerOrdersGrid.Name = "customerOrdersGrid";
            this.customerOrdersGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit});
            this.customerOrdersGrid.Size = new System.Drawing.Size(732, 439);
            this.customerOrdersGrid.TabIndex = 0;
            this.customerOrdersGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customerOrdersGridView});
            // 
            // customerOrdersGridView
            // 
            this.customerOrdersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.orderNumberCol,
            this.contractorCol,
            this.orderDateCol,
            this.selectedCol});
            this.customerOrdersGridView.GridControl = this.customerOrdersGrid;
            this.customerOrdersGridView.Name = "customerOrdersGridView";
            this.customerOrdersGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.customerOrdersGridView.OptionsView.ShowAutoFilterRow = true;
            this.customerOrdersGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.customerOrdersGridView.OptionsView.ShowGroupPanel = false;
            this.customerOrdersGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.customerOrdersGridView_FocusedRowChanged);
            // 
            // orderNumberCol
            // 
            this.orderNumberCol.AppearanceCell.Options.UseTextOptions = true;
            this.orderNumberCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderNumberCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.orderNumberCol.AppearanceHeader.Options.UseFont = true;
            this.orderNumberCol.AppearanceHeader.Options.UseForeColor = true;
            this.orderNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderNumberCol.Caption = "Номер заказа";
            this.orderNumberCol.FieldName = "OrderNumber";
            this.orderNumberCol.Name = "orderNumberCol";
            this.orderNumberCol.OptionsColumn.AllowEdit = false;
            this.orderNumberCol.OptionsColumn.AllowFocus = false;
            this.orderNumberCol.Visible = true;
            this.orderNumberCol.VisibleIndex = 0;
            this.orderNumberCol.Width = 271;
            // 
            // contractorCol
            // 
            this.contractorCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractorCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.contractorCol.AppearanceHeader.Options.UseFont = true;
            this.contractorCol.AppearanceHeader.Options.UseForeColor = true;
            this.contractorCol.AppearanceHeader.Options.UseTextOptions = true;
            this.contractorCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.contractorCol.Caption = "Контрагент";
            this.contractorCol.FieldName = "ContractorName";
            this.contractorCol.Name = "contractorCol";
            this.contractorCol.OptionsColumn.AllowEdit = false;
            this.contractorCol.OptionsColumn.AllowFocus = false;
            this.contractorCol.Visible = true;
            this.contractorCol.VisibleIndex = 1;
            this.contractorCol.Width = 759;
            // 
            // orderDateCol
            // 
            this.orderDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderDateCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.orderDateCol.AppearanceHeader.Options.UseFont = true;
            this.orderDateCol.AppearanceHeader.Options.UseForeColor = true;
            this.orderDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderDateCol.Caption = "Дата заказа";
            this.orderDateCol.FieldName = "OrderDate";
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.OptionsColumn.AllowEdit = false;
            this.orderDateCol.OptionsColumn.AllowFocus = false;
            this.orderDateCol.Visible = true;
            this.orderDateCol.VisibleIndex = 2;
            this.orderDateCol.Width = 233;
            // 
            // selectedCol
            // 
            this.selectedCol.AppearanceCell.Options.UseTextOptions = true;
            this.selectedCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selectedCol.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("selectedCol.AppearanceHeader.Image")));
            this.selectedCol.AppearanceHeader.Options.UseImage = true;
            this.selectedCol.ColumnEdit = this.repositoryItemCheckEdit;
            this.selectedCol.FieldName = "Selected";
            this.selectedCol.Image = ((System.Drawing.Image)(resources.GetObject("selectedCol.Image")));
            this.selectedCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.selectedCol.Name = "selectedCol";
            this.selectedCol.Visible = true;
            this.selectedCol.VisibleIndex = 3;
            this.selectedCol.Width = 54;
            // 
            // repositoryItemCheckEdit
            // 
            this.repositoryItemCheckEdit.AutoHeight = false;
            this.repositoryItemCheckEdit.Name = "repositoryItemCheckEdit";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(582, 479);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(663, 479);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Відміна";
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.customerOrdersGrid);
            this.groupControl1.Location = new System.Drawing.Point(4, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(736, 461);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Проекти";
            // 
            // PackingListCustomerSelectFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 509);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PackingListCustomerSelectFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Закази";
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl customerOrdersGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView customerOrdersGridView;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraGrid.Columns.GridColumn orderNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn selectedCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn contractorCol;
        private DevExpress.XtraGrid.Columns.GridColumn orderDateCol;
    }
}