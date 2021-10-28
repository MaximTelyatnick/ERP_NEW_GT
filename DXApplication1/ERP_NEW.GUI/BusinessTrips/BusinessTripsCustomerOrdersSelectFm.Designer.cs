namespace ERP_NEW.GUI.BusinessTrips
{
    partial class BusinessTripsCustomerOrdersSelectFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessTripsCustomerOrdersSelectFm));
            this.businessTripsOrdersGrid = new DevExpress.XtraGrid.GridControl();
            this.businessTripsOrdersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.orderNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contractorNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selectedCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.addBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsOrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsOrdersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // businessTripsOrdersGrid
            // 
            this.businessTripsOrdersGrid.Location = new System.Drawing.Point(0, 0);
            this.businessTripsOrdersGrid.MainView = this.businessTripsOrdersGridView;
            this.businessTripsOrdersGrid.Name = "businessTripsOrdersGrid";
            this.businessTripsOrdersGrid.Size = new System.Drawing.Size(834, 306);
            this.businessTripsOrdersGrid.TabIndex = 79;
            this.businessTripsOrdersGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.businessTripsOrdersGridView});
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
            this.businessTripsOrdersGridView.OptionsView.ShowAutoFilterRow = true;
            this.businessTripsOrdersGridView.OptionsView.ShowGroupPanel = false;
            // 
            // orderNumberCol
            // 
            this.orderNumberCol.AppearanceCell.Options.UseTextOptions = true;
            this.orderNumberCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderNumberCol.Caption = "Номер заказ";
            this.orderNumberCol.FieldName = "OrderNumber";
            this.orderNumberCol.Name = "orderNumberCol";
            this.orderNumberCol.OptionsColumn.AllowEdit = false;
            this.orderNumberCol.OptionsColumn.AllowFocus = false;
            this.orderNumberCol.Visible = true;
            this.orderNumberCol.VisibleIndex = 0;
            this.orderNumberCol.Width = 156;
            // 
            // contractorNameCol
            // 
            this.contractorNameCol.AppearanceCell.Options.UseTextOptions = true;
            this.contractorNameCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.contractorNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.contractorNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.orderDateCol.AppearanceCell.Options.UseTextOptions = true;
            this.orderDateCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.orderDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.orderDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.selectedCol.AppearanceCell.Options.UseTextOptions = true;
            this.selectedCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selectedCol.AppearanceHeader.Options.UseTextOptions = true;
            this.selectedCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selectedCol.FieldName = "Selected";
            this.selectedCol.Image = ((System.Drawing.Image)(resources.GetObject("selectedCol.Image")));
            this.selectedCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.selectedCol.Name = "selectedCol";
            this.selectedCol.Visible = true;
            this.selectedCol.VisibleIndex = 3;
            this.selectedCol.Width = 42;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(748, 312);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 21);
            this.cancelBtn.TabIndex = 78;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(667, 312);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 21);
            this.addBtn.TabIndex = 77;
            this.addBtn.Text = "Додати";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // BusinessTripsCustomerOrdersSelectFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 345);
            this.Controls.Add(this.businessTripsOrdersGrid);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusinessTripsCustomerOrdersSelectFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контрагенти";
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsOrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsOrdersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl businessTripsOrdersGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView businessTripsOrdersGridView;
        private DevExpress.XtraGrid.Columns.GridColumn orderNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn contractorNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn orderDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn selectedCol;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton addBtn;
    }
}