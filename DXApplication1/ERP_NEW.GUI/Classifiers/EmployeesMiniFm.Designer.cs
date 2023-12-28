namespace ERP_NEW.GUI.Classifiers
{
    partial class EmployeesMiniFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesMiniFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addEmployeBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editEmployeBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteEmployeBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.employeesGrid = new DevExpress.XtraGrid.GridControl();
            this.employeesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.accNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fioCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fotoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.profCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.departmentCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.dateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addEmployeBtn,
            this.editEmployeBtn,
            this.deleteEmployeBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1157, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // addEmployeBtn
            // 
            this.addEmployeBtn.Caption = "Додати";
            this.addEmployeBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addEmployeBtn.Glyph")));
            this.addEmployeBtn.Id = 1;
            this.addEmployeBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addEmployeBtn.LargeGlyph")));
            this.addEmployeBtn.Name = "addEmployeBtn";
            this.addEmployeBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addEmployeBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addEmployeBtn_ItemClick);
            // 
            // editEmployeBtn
            // 
            this.editEmployeBtn.Caption = "Редагувати";
            this.editEmployeBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editEmployeBtn.Glyph")));
            this.editEmployeBtn.Id = 2;
            this.editEmployeBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editEmployeBtn.LargeGlyph")));
            this.editEmployeBtn.Name = "editEmployeBtn";
            this.editEmployeBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.editEmployeBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editEmployeBtn_ItemClick);
            // 
            // deleteEmployeBtn
            // 
            this.deleteEmployeBtn.Caption = "Звільнити";
            this.deleteEmployeBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteEmployeBtn.Glyph")));
            this.deleteEmployeBtn.Id = 3;
            this.deleteEmployeBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteEmployeBtn.LargeGlyph")));
            this.deleteEmployeBtn.Name = "deleteEmployeBtn";
            this.deleteEmployeBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deleteEmployeBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteEmployeBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.addEmployeBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.editEmployeBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteEmployeBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Співробіник";
            // 
            // employeesGrid
            // 
            this.employeesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesGrid.Location = new System.Drawing.Point(0, 95);
            this.employeesGrid.MainView = this.employeesGridView;
            this.employeesGrid.Name = "employeesGrid";
            this.employeesGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoEdit2});
            this.employeesGrid.Size = new System.Drawing.Size(1157, 317);
            this.employeesGrid.TabIndex = 1;
            this.employeesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.employeesGridView});
            // 
            // employeesGridView
            // 
            this.employeesGridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.employeesGridView.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.employeesGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.employeesGridView.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.employeesGridView.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.employeesGridView.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeesGridView.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.employeesGridView.ColumnPanelRowHeight = 50;
            this.employeesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.accNumCol,
            this.fioCol,
            this.fotoCol,
            this.profCol,
            this.departmentCol,
            this.dateCol});
            this.employeesGridView.GridControl = this.employeesGrid;
            this.employeesGridView.Name = "employeesGridView";
            this.employeesGridView.OptionsView.RowAutoHeight = true;
            this.employeesGridView.OptionsView.ShowAutoFilterRow = true;
            this.employeesGridView.OptionsView.ShowGroupPanel = false;
            this.employeesGridView.RowHeight = 30;
            this.employeesGridView.ViewCaptionHeight = 30;
            // 
            // accNumCol
            // 
            this.accNumCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accNumCol.AppearanceCell.Options.UseFont = true;
            this.accNumCol.AppearanceCell.Options.UseTextOptions = true;
            this.accNumCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.accNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accNumCol.AppearanceHeader.Options.UseFont = true;
            this.accNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.accNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.accNumCol.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.accNumCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.accNumCol.Caption = "Табельний номер";
            this.accNumCol.FieldName = "AccountNumber";
            this.accNumCol.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.accNumCol.MaxWidth = 140;
            this.accNumCol.MinWidth = 60;
            this.accNumCol.Name = "accNumCol";
            this.accNumCol.OptionsColumn.AllowEdit = false;
            this.accNumCol.OptionsColumn.AllowFocus = false;
            this.accNumCol.Visible = true;
            this.accNumCol.VisibleIndex = 0;
            this.accNumCol.Width = 140;
            // 
            // fioCol
            // 
            this.fioCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioCol.AppearanceCell.Options.UseFont = true;
            this.fioCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioCol.AppearanceHeader.Options.UseFont = true;
            this.fioCol.AppearanceHeader.Options.UseTextOptions = true;
            this.fioCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fioCol.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fioCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.fioCol.Caption = "П.І.Б.";
            this.fioCol.FieldName = "Fio";
            this.fioCol.Name = "fioCol";
            this.fioCol.OptionsColumn.AllowEdit = false;
            this.fioCol.OptionsColumn.AllowFocus = false;
            this.fioCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.fioCol.Visible = true;
            this.fioCol.VisibleIndex = 1;
            this.fioCol.Width = 177;
            // 
            // fotoCol
            // 
            this.fotoCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fotoCol.AppearanceCell.Options.UseFont = true;
            this.fotoCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fotoCol.AppearanceHeader.Options.UseFont = true;
            this.fotoCol.AppearanceHeader.Options.UseTextOptions = true;
            this.fotoCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fotoCol.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fotoCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.fotoCol.ColumnEdit = this.repositoryItemPictureEdit1;
            this.fotoCol.FieldName = "UserPhoto";
            this.fotoCol.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.fotoCol.Image = ((System.Drawing.Image)(resources.GetObject("fotoCol.Image")));
            this.fotoCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.fotoCol.MaxWidth = 120;
            this.fotoCol.MinWidth = 120;
            this.fotoCol.Name = "fotoCol";
            this.fotoCol.OptionsColumn.AllowEdit = false;
            this.fotoCol.OptionsColumn.AllowFocus = false;
            this.fotoCol.OptionsFilter.AllowAutoFilter = false;
            this.fotoCol.OptionsFilter.AllowFilter = false;
            this.fotoCol.OptionsFilter.ShowBlanksFilterItems = DevExpress.Utils.DefaultBoolean.True;
            this.fotoCol.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.fotoCol.Tag = " ";
            this.fotoCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.fotoCol.Width = 120;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Caption.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.ShowScrollBars = true;
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            // 
            // profCol
            // 
            this.profCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profCol.AppearanceCell.Options.UseFont = true;
            this.profCol.AppearanceCell.Options.UseTextOptions = true;
            this.profCol.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.profCol.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.profCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profCol.AppearanceHeader.Options.UseFont = true;
            this.profCol.AppearanceHeader.Options.UseTextOptions = true;
            this.profCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.profCol.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.profCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.profCol.Caption = "Професія";
            this.profCol.ColumnEdit = this.repositoryItemMemoEdit1;
            this.profCol.FieldName = "ProfessionName";
            this.profCol.Name = "profCol";
            this.profCol.OptionsColumn.AllowEdit = false;
            this.profCol.OptionsColumn.AllowFocus = false;
            this.profCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.profCol.Visible = true;
            this.profCol.VisibleIndex = 2;
            this.profCol.Width = 177;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // departmentCol
            // 
            this.departmentCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentCol.AppearanceCell.Options.UseFont = true;
            this.departmentCol.AppearanceCell.Options.UseTextOptions = true;
            this.departmentCol.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.departmentCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentCol.AppearanceHeader.Options.UseFont = true;
            this.departmentCol.AppearanceHeader.Options.UseTextOptions = true;
            this.departmentCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.departmentCol.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.departmentCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.departmentCol.Caption = "Відділ";
            this.departmentCol.ColumnEdit = this.repositoryItemTextEdit2;
            this.departmentCol.FieldName = "DepartmentName";
            this.departmentCol.Name = "departmentCol";
            this.departmentCol.OptionsColumn.AllowEdit = false;
            this.departmentCol.OptionsColumn.AllowFocus = false;
            this.departmentCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.departmentCol.Visible = true;
            this.departmentCol.VisibleIndex = 3;
            this.departmentCol.Width = 355;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTextEdit2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // dateCol
            // 
            this.dateCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCol.AppearanceCell.Options.UseFont = true;
            this.dateCol.AppearanceCell.Options.UseTextOptions = true;
            this.dateCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCol.AppearanceHeader.Options.UseFont = true;
            this.dateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.dateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dateCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dateCol.Caption = "Дата працевлаштування";
            this.dateCol.FieldName = "DateBegin";
            this.dateCol.MaxWidth = 170;
            this.dateCol.MinWidth = 170;
            this.dateCol.Name = "dateCol";
            this.dateCol.OptionsColumn.AllowEdit = false;
            this.dateCol.OptionsColumn.AllowFocus = false;
            this.dateCol.Visible = true;
            this.dateCol.VisibleIndex = 4;
            this.dateCol.Width = 170;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTextEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // EmployeesMiniFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 412);
            this.Controls.Add(this.employeesGrid);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeesMiniFm";
            this.ShowIcon = false;
            this.Text = "EmployeesMiniFm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem addEmployeBtn;
        private DevExpress.XtraBars.BarButtonItem editEmployeBtn;
        private DevExpress.XtraBars.BarButtonItem deleteEmployeBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl employeesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView employeesGridView;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Columns.GridColumn accNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn fioCol;
        private DevExpress.XtraGrid.Columns.GridColumn fotoCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn profCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn departmentCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn dateCol;
    }
}