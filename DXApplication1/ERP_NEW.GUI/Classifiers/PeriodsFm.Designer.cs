namespace ERP_NEW.GUI.Classifiers
{
    partial class PeriodsFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriodsFm));
            this.periodGrid = new DevExpress.XtraGrid.GridControl();
            this.periodGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.monthCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.yearCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stateRepository = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.stateBankCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stateBankRepository = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.stateBusinestripCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stateBusinesTripRepository = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.stateTaxInvoicesCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stateTaxInvoicesRepository = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.periodGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBankRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBusinesTripRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTaxInvoicesRepository)).BeginInit();
            this.SuspendLayout();
            // 
            // periodGrid
            // 
            this.periodGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.periodGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.periodGrid.Location = new System.Drawing.Point(0, 0);
            this.periodGrid.MainView = this.periodGridView;
            this.periodGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.periodGrid.Name = "periodGrid";
            this.periodGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.stateRepository,
            this.stateBankRepository,
            this.stateBusinesTripRepository,
            this.stateTaxInvoicesRepository});
            this.periodGrid.Size = new System.Drawing.Size(1357, 423);
            this.periodGrid.TabIndex = 1;
            this.periodGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.periodGridView});
            // 
            // periodGridView
            // 
            this.periodGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.monthCol,
            this.yearCol,
            this.stateCol,
            this.stateBankCol,
            this.stateBusinestripCol,
            this.stateTaxInvoicesCol});
            this.periodGridView.GridControl = this.periodGrid;
            this.periodGridView.Name = "periodGridView";
            this.periodGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.periodGridView.OptionsMenu.ShowAutoFilterRowItem = false;
            this.periodGridView.OptionsView.ShowFooter = true;
            this.periodGridView.OptionsView.ShowGroupPanel = false;
            this.periodGridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.periodGridView_RowCellStyle);
            // 
            // monthCol
            // 
            this.monthCol.AppearanceCell.Options.UseTextOptions = true;
            this.monthCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.monthCol.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.monthCol.AppearanceHeader.Options.UseFont = true;
            this.monthCol.AppearanceHeader.Options.UseTextOptions = true;
            this.monthCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.monthCol.Caption = "Місяць";
            this.monthCol.FieldName = "Month";
            this.monthCol.Name = "monthCol";
            this.monthCol.OptionsColumn.AllowEdit = false;
            this.monthCol.OptionsColumn.AllowFocus = false;
            this.monthCol.Visible = true;
            this.monthCol.VisibleIndex = 0;
            // 
            // yearCol
            // 
            this.yearCol.AppearanceCell.Options.UseTextOptions = true;
            this.yearCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.yearCol.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.yearCol.AppearanceHeader.Options.UseFont = true;
            this.yearCol.AppearanceHeader.Options.UseTextOptions = true;
            this.yearCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.yearCol.Caption = "Рік";
            this.yearCol.FieldName = "Year";
            this.yearCol.Name = "yearCol";
            this.yearCol.OptionsColumn.AllowEdit = false;
            this.yearCol.OptionsColumn.AllowFocus = false;
            this.yearCol.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.yearCol.Visible = true;
            this.yearCol.VisibleIndex = 1;
            // 
            // stateCol
            // 
            this.stateCol.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.stateCol.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("stateCol.AppearanceHeader.Image")));
            this.stateCol.AppearanceHeader.Options.UseFont = true;
            this.stateCol.AppearanceHeader.Options.UseImage = true;
            this.stateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.stateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.stateCol.Caption = "Надходження";
            this.stateCol.ColumnEdit = this.stateRepository;
            this.stateCol.FieldName = "State";
            this.stateCol.Name = "stateCol";
            this.stateCol.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.stateCol.Visible = true;
            this.stateCol.VisibleIndex = 2;
            // 
            // stateRepository
            // 
            this.stateRepository.AppearanceFocused.Image = ((System.Drawing.Image)(resources.GetObject("stateRepository.AppearanceFocused.Image")));
            this.stateRepository.AppearanceFocused.Options.UseImage = true;
            this.stateRepository.AutoHeight = false;
            this.stateRepository.LookAndFeel.SkinName = "VS2010";
            this.stateRepository.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.stateRepository.Name = "stateRepository";
            this.stateRepository.PictureChecked = ((System.Drawing.Image)(resources.GetObject("stateRepository.PictureChecked")));
            this.stateRepository.PictureUnchecked = ((System.Drawing.Image)(resources.GetObject("stateRepository.PictureUnchecked")));
            this.stateRepository.CheckedChanged += new System.EventHandler(this.stateRepository_CheckedChanged);
            // 
            // stateBankCol
            // 
            this.stateBankCol.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.stateBankCol.AppearanceHeader.Options.UseFont = true;
            this.stateBankCol.AppearanceHeader.Options.UseTextOptions = true;
            this.stateBankCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.stateBankCol.Caption = "Банківські операції";
            this.stateBankCol.ColumnEdit = this.stateBankRepository;
            this.stateBankCol.FieldName = "StateBank";
            this.stateBankCol.Name = "stateBankCol";
            this.stateBankCol.Visible = true;
            this.stateBankCol.VisibleIndex = 3;
            // 
            // stateBankRepository
            // 
            this.stateBankRepository.AutoHeight = false;
            this.stateBankRepository.Name = "stateBankRepository";
            this.stateBankRepository.CheckedChanged += new System.EventHandler(this.stateBankRepository_CheckedChanged);
            // 
            // stateBusinestripCol
            // 
            this.stateBusinestripCol.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.stateBusinestripCol.AppearanceHeader.Options.UseFont = true;
            this.stateBusinestripCol.AppearanceHeader.Options.UseTextOptions = true;
            this.stateBusinestripCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.stateBusinestripCol.Caption = "Відрядження";
            this.stateBusinestripCol.ColumnEdit = this.stateBusinesTripRepository;
            this.stateBusinestripCol.FieldName = "StateBusinesTrip";
            this.stateBusinestripCol.Name = "stateBusinestripCol";
            this.stateBusinestripCol.Visible = true;
            this.stateBusinestripCol.VisibleIndex = 4;
            // 
            // stateBusinesTripRepository
            // 
            this.stateBusinesTripRepository.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("stateBusinesTripRepository.Appearance.Image")));
            this.stateBusinesTripRepository.Appearance.Options.UseImage = true;
            this.stateBusinesTripRepository.AutoHeight = false;
            this.stateBusinesTripRepository.Name = "stateBusinesTripRepository";
            this.stateBusinesTripRepository.CheckedChanged += new System.EventHandler(this.stateBusinesTripRepository_CheckedChanged);
            // 
            // stateTaxInvoicesCol
            // 
            this.stateTaxInvoicesCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateTaxInvoicesCol.AppearanceHeader.Options.UseFont = true;
            this.stateTaxInvoicesCol.AppearanceHeader.Options.UseTextOptions = true;
            this.stateTaxInvoicesCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.stateTaxInvoicesCol.Caption = "Налогові";
            this.stateTaxInvoicesCol.ColumnEdit = this.stateTaxInvoicesRepository;
            this.stateTaxInvoicesCol.FieldName = "StateTaxInvoices";
            this.stateTaxInvoicesCol.Name = "stateTaxInvoicesCol";
            this.stateTaxInvoicesCol.Visible = true;
            this.stateTaxInvoicesCol.VisibleIndex = 5;
            // 
            // stateTaxInvoicesRepository
            // 
            this.stateTaxInvoicesRepository.AutoHeight = false;
            this.stateTaxInvoicesRepository.Name = "stateTaxInvoicesRepository";
            this.stateTaxInvoicesRepository.CheckedChanged += new System.EventHandler(this.stateTaxInvoicesRepository_CheckedChanged);
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // PeriodsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 423);
            this.Controls.Add(this.periodGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PeriodsFm";
            this.ShowIcon = false;
            this.Text = "Класифікатор періодів";
            ((System.ComponentModel.ISupportInitialize)(this.periodGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBankRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBusinesTripRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTaxInvoicesRepository)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl periodGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView periodGridView;
        private DevExpress.XtraGrid.Columns.GridColumn monthCol;
        private DevExpress.XtraGrid.Columns.GridColumn yearCol;
        private DevExpress.XtraGrid.Columns.GridColumn stateCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit stateRepository;
        private DevExpress.XtraGrid.Columns.GridColumn stateBankCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit stateBankRepository;
        private DevExpress.XtraGrid.Columns.GridColumn stateBusinestripCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit stateBusinesTripRepository;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Columns.GridColumn stateTaxInvoicesCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit stateTaxInvoicesRepository;
    }
}