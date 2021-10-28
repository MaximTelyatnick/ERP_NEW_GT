namespace ERP_NEW.GUI.GodMode.Parser
{
    partial class ExpenditureParseFm
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
            this.expenditureGrid = new DevExpress.XtraGrid.GridControl();
            this.expenditureGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rojectCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.expenditureGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenditureGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // expenditureGrid
            // 
            this.expenditureGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expenditureGrid.Location = new System.Drawing.Point(0, 0);
            this.expenditureGrid.MainView = this.expenditureGridView;
            this.expenditureGrid.Name = "expenditureGrid";
            this.expenditureGrid.Size = new System.Drawing.Size(1327, 575);
            this.expenditureGrid.TabIndex = 0;
            this.expenditureGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.expenditureGridView});
            // 
            // expenditureGridView
            // 
            this.expenditureGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.rojectCol,
            this.gridColumn2});
            this.expenditureGridView.GridControl = this.expenditureGrid;
            this.expenditureGridView.Name = "expenditureGridView";
            this.expenditureGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // rojectCol
            // 
            this.rojectCol.Caption = "Проєкт";
            this.rojectCol.FieldName = "PROJECT_NUM";
            this.rojectCol.Name = "rojectCol";
            this.rojectCol.Visible = true;
            this.rojectCol.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Заказ";
            this.gridColumn2.FieldName = "CustomerOrderNumber";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Id заказа";
            this.gridColumn3.FieldName = "CustomerOrderId";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id списания";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // ExpenditureParseFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 575);
            this.Controls.Add(this.expenditureGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExpenditureParseFm";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.expenditureGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenditureGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl expenditureGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView expenditureGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn rojectCol;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}