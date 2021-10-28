namespace ERP_NEW.GUI.BusinessTrips
{
    partial class BusinessTripsSelectFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessTripsSelectFm));
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            this.businessTripsGrid = new DevExpress.XtraGrid.GridControl();
            this.businessTripsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.selectionCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selectionRepository = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.numberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departmentCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.purposeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.employeeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.firstdateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lastDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.amountDaysCol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionRepository)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(1250, 494);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Відмінити";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(1169, 494);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 16;
            this.okBtn.Text = "Вибрати";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // businessTripsGrid
            // 
            this.businessTripsGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.businessTripsGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.businessTripsGrid.Location = new System.Drawing.Point(0, 0);
            this.businessTripsGrid.MainView = this.businessTripsGridView;
            this.businessTripsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.businessTripsGrid.Name = "businessTripsGrid";
            this.businessTripsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.selectionRepository});
            this.businessTripsGrid.Size = new System.Drawing.Size(1337, 489);
            this.businessTripsGrid.TabIndex = 18;
            this.businessTripsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.businessTripsGridView});
            // 
            // businessTripsGridView
            // 
            this.businessTripsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.selectionCol,
            this.numberCol,
            this.dateCol,
            this.departmentCol,
            this.purposeCol,
            this.employeeCol,
            this.firstdateCol,
            this.lastDateCol,
            this.amountDaysCol});
            this.businessTripsGridView.GridControl = this.businessTripsGrid;
            this.businessTripsGridView.Name = "businessTripsGridView";
            this.businessTripsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.businessTripsGridView.OptionsView.ShowAutoFilterRow = true;
            this.businessTripsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // selectionCol
            // 
            this.selectionCol.ColumnEdit = this.selectionRepository;
            this.selectionCol.FieldName = "Selection";
            this.selectionCol.Image = ((System.Drawing.Image)(resources.GetObject("selectionCol.Image")));
            this.selectionCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.selectionCol.Name = "selectionCol";
            this.selectionCol.OptionsColumn.ShowCaption = false;
            this.selectionCol.Visible = true;
            this.selectionCol.VisibleIndex = 0;
            this.selectionCol.Width = 42;
            // 
            // selectionRepository
            // 
            this.selectionRepository.AutoHeight = false;
            this.selectionRepository.Name = "selectionRepository";
            // 
            // numberCol
            // 
            this.numberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.numberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.numberCol.Caption = "№ посвідчення";
            this.numberCol.FieldName = "Doc_Number";
            this.numberCol.Name = "numberCol";
            this.numberCol.OptionsColumn.AllowEdit = false;
            this.numberCol.OptionsColumn.AllowFocus = false;
            this.numberCol.Visible = true;
            this.numberCol.VisibleIndex = 1;
            this.numberCol.Width = 86;
            // 
            // dateCol
            // 
            this.dateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.dateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateCol.Caption = "Дата";
            this.dateCol.FieldName = "Doc_Date";
            this.dateCol.Name = "dateCol";
            this.dateCol.OptionsColumn.AllowEdit = false;
            this.dateCol.OptionsColumn.AllowFocus = false;
            this.dateCol.Visible = true;
            this.dateCol.VisibleIndex = 2;
            this.dateCol.Width = 67;
            // 
            // departmentCol
            // 
            this.departmentCol.AppearanceHeader.Options.UseTextOptions = true;
            this.departmentCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.departmentCol.Caption = "Організація";
            this.departmentCol.FieldName = "ContractorName";
            this.departmentCol.Name = "departmentCol";
            this.departmentCol.OptionsColumn.AllowEdit = false;
            this.departmentCol.OptionsColumn.AllowFocus = false;
            this.departmentCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.departmentCol.Visible = true;
            this.departmentCol.VisibleIndex = 3;
            this.departmentCol.Width = 241;
            // 
            // purposeCol
            // 
            this.purposeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.purposeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.purposeCol.Caption = "Мета відрядження";
            this.purposeCol.FieldName = "PurposeName";
            this.purposeCol.Name = "purposeCol";
            this.purposeCol.OptionsColumn.AllowEdit = false;
            this.purposeCol.OptionsColumn.AllowFocus = false;
            this.purposeCol.Visible = true;
            this.purposeCol.VisibleIndex = 4;
            this.purposeCol.Width = 163;
            // 
            // employeeCol
            // 
            this.employeeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.employeeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.employeeCol.Caption = "П.І.Б";
            this.employeeCol.FieldName = "FullName";
            this.employeeCol.Name = "employeeCol";
            this.employeeCol.OptionsColumn.AllowEdit = false;
            this.employeeCol.OptionsColumn.AllowFocus = false;
            this.employeeCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.employeeCol.Visible = true;
            this.employeeCol.VisibleIndex = 5;
            this.employeeCol.Width = 256;
            // 
            // firstdateCol
            // 
            this.firstdateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.firstdateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.firstdateCol.Caption = "Дата початку";
            this.firstdateCol.FieldName = "StartDate";
            this.firstdateCol.Name = "firstdateCol";
            this.firstdateCol.OptionsColumn.AllowEdit = false;
            this.firstdateCol.OptionsColumn.AllowFocus = false;
            this.firstdateCol.Visible = true;
            this.firstdateCol.VisibleIndex = 6;
            this.firstdateCol.Width = 174;
            // 
            // lastDateCol
            // 
            this.lastDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.lastDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lastDateCol.Caption = "Дата завершення";
            this.lastDateCol.FieldName = "EndDate";
            this.lastDateCol.Name = "lastDateCol";
            this.lastDateCol.OptionsColumn.AllowEdit = false;
            this.lastDateCol.OptionsColumn.AllowFocus = false;
            this.lastDateCol.Visible = true;
            this.lastDateCol.VisibleIndex = 7;
            this.lastDateCol.Width = 145;
            // 
            // amountDaysCol
            // 
            this.amountDaysCol.AppearanceHeader.Options.UseTextOptions = true;
            this.amountDaysCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.amountDaysCol.Caption = "Кількість днів";
            this.amountDaysCol.FieldName = "AmountDays";
            this.amountDaysCol.Name = "amountDaysCol";
            this.amountDaysCol.OptionsColumn.AllowEdit = false;
            this.amountDaysCol.OptionsColumn.AllowFocus = false;
            this.amountDaysCol.Visible = true;
            this.amountDaysCol.VisibleIndex = 8;
            this.amountDaysCol.Width = 150;
            // 
            // BusinessTripsSelectFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 529);
            this.Controls.Add(this.businessTripsGrid);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusinessTripsSelectFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Відрядження";
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionRepository)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton okBtn;
        private DevExpress.XtraGrid.GridControl businessTripsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView businessTripsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn numberCol;
        private DevExpress.XtraGrid.Columns.GridColumn dateCol;
        private DevExpress.XtraGrid.Columns.GridColumn departmentCol;
        private DevExpress.XtraGrid.Columns.GridColumn purposeCol;
        private DevExpress.XtraGrid.Columns.GridColumn employeeCol;
        private DevExpress.XtraGrid.Columns.GridColumn firstdateCol;
        private DevExpress.XtraGrid.Columns.GridColumn lastDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn amountDaysCol;
        private DevExpress.XtraGrid.Columns.GridColumn selectionCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit selectionRepository;

    }
}