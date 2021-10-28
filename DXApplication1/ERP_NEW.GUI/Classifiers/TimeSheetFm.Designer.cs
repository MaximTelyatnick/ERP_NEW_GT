namespace ERP_NEW.GUI.Classifiers
{
    partial class TimeSheetFm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeSheetFm));
            this.userPhotoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.excelExportAndPrintTimeSheetBtn = new DevExpress.XtraBars.BarButtonItem();
            this.yearEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.monthEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMonth1 = new DevExpress.XtraScheduler.UI.RepositoryItemMonth();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.timeSheetDepartmentsGrid = new DevExpress.XtraGrid.GridControl();
            this.timeSheetDepartmentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.departmentsNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.timeSheetProfessionsGrid = new DevExpress.XtraGrid.GridControl();
            this.timeSheetProfessionsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fioCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.profesionNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selectedCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.employeesInfoItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMonth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetDepartmentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetDepartmentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetProfessionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetProfessionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesInfoItemCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // userPhotoCol
            // 
            this.userPhotoCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPhotoCol.AppearanceCell.Options.UseFont = true;
            this.userPhotoCol.AppearanceHeader.BackColor = System.Drawing.Color.Black;
            this.userPhotoCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPhotoCol.AppearanceHeader.Options.UseBackColor = true;
            this.userPhotoCol.AppearanceHeader.Options.UseFont = true;
            this.userPhotoCol.AppearanceHeader.Options.UseTextOptions = true;
            this.userPhotoCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.userPhotoCol.Caption = "Фото користувача";
            this.userPhotoCol.FieldName = "UserPhoto";
            this.userPhotoCol.Name = "userPhotoCol";
            this.userPhotoCol.OptionsColumn.AllowEdit = false;
            this.userPhotoCol.OptionsColumn.AllowFocus = false;
            this.userPhotoCol.OptionsFilter.AllowAutoFilter = false;
            this.userPhotoCol.OptionsFilter.AllowFilter = false;
            this.userPhotoCol.Visible = true;
            this.userPhotoCol.VisibleIndex = 3;
            this.userPhotoCol.Width = 130;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.excelExportAndPrintTimeSheetBtn,
            this.yearEdit,
            this.monthEdit});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemDateEdit1,
            this.repositoryItemMonth1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1164, 95);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // excelExportAndPrintTimeSheetBtn
            // 
            this.excelExportAndPrintTimeSheetBtn.Caption = "Друк табелю";
            this.excelExportAndPrintTimeSheetBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("excelExportAndPrintTimeSheetBtn.Glyph")));
            this.excelExportAndPrintTimeSheetBtn.Id = 1;
            this.excelExportAndPrintTimeSheetBtn.Name = "excelExportAndPrintTimeSheetBtn";
            this.excelExportAndPrintTimeSheetBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.excelExportAndPrintTimeSheetBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.excelExportAndPrintTimeSheetBtn_ItemClick);
            // 
            // yearEdit
            // 
            this.yearEdit.Caption = "Рік      ";
            this.yearEdit.CaptionAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.yearEdit.Edit = this.repositoryItemDateEdit1;
            this.yearEdit.EditWidth = 100;
            this.yearEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("yearEdit.Glyph")));
            this.yearEdit.Id = 3;
            this.yearEdit.Name = "yearEdit";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemDateEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEdit1.AppearanceFocused.Options.UseTextOptions = true;
            this.repositoryItemDateEdit1.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "yyyy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "yyyy";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "yyyy";
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemDateEdit1.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.repositoryItemDateEdit1.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView;
            // 
            // monthEdit
            // 
            this.monthEdit.Caption = "Місяць";
            this.monthEdit.CaptionAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.monthEdit.Edit = this.repositoryItemMonth1;
            this.monthEdit.EditWidth = 100;
            this.monthEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("monthEdit.Glyph")));
            this.monthEdit.Id = 4;
            this.monthEdit.Name = "monthEdit";
            // 
            // repositoryItemMonth1
            // 
            this.repositoryItemMonth1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMonth1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemMonth1.AppearanceFocused.Options.UseTextOptions = true;
            this.repositoryItemMonth1.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemMonth1.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemMonth1.AutoHeight = false;
            this.repositoryItemMonth1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMonth1.DisplayFormat.FormatString = "d";
            this.repositoryItemMonth1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemMonth1.EditFormat.FormatString = "d";
            this.repositoryItemMonth1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemMonth1.Name = "repositoryItemMonth1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.monthEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.yearEdit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Дата";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.excelExportAndPrintTimeSheetBtn);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Функції";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.timeSheetDepartmentsGrid);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 95);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(466, 373);
            this.panelControl1.TabIndex = 1;
            // 
            // timeSheetDepartmentsGrid
            // 
            this.timeSheetDepartmentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeSheetDepartmentsGrid.Location = new System.Drawing.Point(2, 2);
            this.timeSheetDepartmentsGrid.MainView = this.timeSheetDepartmentsGridView;
            this.timeSheetDepartmentsGrid.MenuManager = this.ribbonControl1;
            this.timeSheetDepartmentsGrid.Name = "timeSheetDepartmentsGrid";
            this.timeSheetDepartmentsGrid.Size = new System.Drawing.Size(462, 369);
            this.timeSheetDepartmentsGrid.TabIndex = 0;
            this.timeSheetDepartmentsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.timeSheetDepartmentsGridView});
            // 
            // timeSheetDepartmentsGridView
            // 
            this.timeSheetDepartmentsGridView.Appearance.Row.BackColor = System.Drawing.Color.MintCream;
            this.timeSheetDepartmentsGridView.Appearance.Row.Options.UseBackColor = true;
            this.timeSheetDepartmentsGridView.ColumnPanelRowHeight = 30;
            this.timeSheetDepartmentsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.departmentsNameCol});
            this.timeSheetDepartmentsGridView.GridControl = this.timeSheetDepartmentsGrid;
            this.timeSheetDepartmentsGridView.GroupRowHeight = 50;
            this.timeSheetDepartmentsGridView.Name = "timeSheetDepartmentsGridView";
            this.timeSheetDepartmentsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.timeSheetDepartmentsGridView.OptionsView.RowAutoHeight = true;
            this.timeSheetDepartmentsGridView.OptionsView.ShowAutoFilterRow = true;
            this.timeSheetDepartmentsGridView.OptionsView.ShowGroupPanel = false;
            this.timeSheetDepartmentsGridView.RowHeight = 0;
            this.timeSheetDepartmentsGridView.RowSeparatorHeight = 2;
            this.timeSheetDepartmentsGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.departmentsNameCol, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.timeSheetDepartmentsGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.timeSheetDepartmentsGridView_FocusedRowChanged);
            // 
            // departmentsNameCol
            // 
            this.departmentsNameCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentsNameCol.AppearanceCell.Options.UseFont = true;
            this.departmentsNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentsNameCol.AppearanceHeader.Options.UseFont = true;
            this.departmentsNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.departmentsNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.departmentsNameCol.Caption = "Підрозділи";
            this.departmentsNameCol.FieldName = "Name";
            this.departmentsNameCol.Name = "departmentsNameCol";
            this.departmentsNameCol.OptionsColumn.AllowEdit = false;
            this.departmentsNameCol.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.True;
            this.departmentsNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.departmentsNameCol.Visible = true;
            this.departmentsNameCol.VisibleIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridSplitContainer1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(466, 95);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(698, 373);
            this.panelControl2.TabIndex = 2;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.timeSheetProfessionsGrid;
            this.gridSplitContainer1.Location = new System.Drawing.Point(2, 2);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.timeSheetProfessionsGrid);
            this.gridSplitContainer1.Size = new System.Drawing.Size(694, 369);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // timeSheetProfessionsGrid
            // 
            this.timeSheetProfessionsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeSheetProfessionsGrid.Location = new System.Drawing.Point(0, 0);
            this.timeSheetProfessionsGrid.MainView = this.timeSheetProfessionsGridView;
            this.timeSheetProfessionsGrid.MenuManager = this.ribbonControl1;
            this.timeSheetProfessionsGrid.Name = "timeSheetProfessionsGrid";
            this.timeSheetProfessionsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.employeesInfoItemCheckEdit});
            this.timeSheetProfessionsGrid.Size = new System.Drawing.Size(694, 369);
            this.timeSheetProfessionsGrid.TabIndex = 1;
            this.timeSheetProfessionsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.timeSheetProfessionsGridView});
            // 
            // timeSheetProfessionsGridView
            // 
            this.timeSheetProfessionsGridView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.White;
            this.timeSheetProfessionsGridView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.timeSheetProfessionsGridView.Appearance.Row.BackColor = System.Drawing.Color.MintCream;
            this.timeSheetProfessionsGridView.Appearance.Row.Options.UseBackColor = true;
            this.timeSheetProfessionsGridView.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.timeSheetProfessionsGridView.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
            this.timeSheetProfessionsGridView.ColumnPanelRowHeight = 30;
            this.timeSheetProfessionsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.fioCol,
            this.accountNumberCol,
            this.profesionNameCol,
            this.userPhotoCol,
            this.selectedCol});
            this.timeSheetProfessionsGridView.DetailHeight = 300;
            this.timeSheetProfessionsGridView.FixedLineWidth = 5;
            this.timeSheetProfessionsGridView.GridControl = this.timeSheetProfessionsGrid;
            this.timeSheetProfessionsGridView.GroupRowHeight = 50;
            this.timeSheetProfessionsGridView.Name = "timeSheetProfessionsGridView";
            this.timeSheetProfessionsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.timeSheetProfessionsGridView.OptionsView.RowAutoHeight = true;
            this.timeSheetProfessionsGridView.OptionsView.ShowGroupPanel = false;
            this.timeSheetProfessionsGridView.RowHeight = 30;
            this.timeSheetProfessionsGridView.RowSeparatorHeight = 2;
            this.timeSheetProfessionsGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.fioCol, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // fioCol
            // 
            this.fioCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioCol.AppearanceCell.Options.UseFont = true;
            this.fioCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioCol.AppearanceHeader.Options.UseFont = true;
            this.fioCol.AppearanceHeader.Options.UseTextOptions = true;
            this.fioCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fioCol.Caption = "Прізвище, І.,Б.";
            this.fioCol.FieldName = "Fio";
            this.fioCol.Name = "fioCol";
            this.fioCol.OptionsColumn.AllowEdit = false;
            this.fioCol.OptionsColumn.AllowFocus = false;
            this.fioCol.Visible = true;
            this.fioCol.VisibleIndex = 0;
            this.fioCol.Width = 150;
            // 
            // accountNumberCol
            // 
            this.accountNumberCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountNumberCol.AppearanceCell.Options.UseFont = true;
            this.accountNumberCol.AppearanceCell.Options.UseTextOptions = true;
            this.accountNumberCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.accountNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountNumberCol.AppearanceHeader.Options.UseFont = true;
            this.accountNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.accountNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.accountNumberCol.Caption = "Табельний номер";
            this.accountNumberCol.FieldName = "AccountNumber";
            this.accountNumberCol.Name = "accountNumberCol";
            this.accountNumberCol.OptionsColumn.AllowEdit = false;
            this.accountNumberCol.OptionsColumn.AllowFocus = false;
            this.accountNumberCol.OptionsColumn.FixedWidth = true;
            this.accountNumberCol.Visible = true;
            this.accountNumberCol.VisibleIndex = 1;
            this.accountNumberCol.Width = 120;
            // 
            // profesionNameCol
            // 
            this.profesionNameCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profesionNameCol.AppearanceCell.Options.UseFont = true;
            this.profesionNameCol.AppearanceCell.Options.UseTextOptions = true;
            this.profesionNameCol.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.profesionNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profesionNameCol.AppearanceHeader.Options.UseFont = true;
            this.profesionNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.profesionNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.profesionNameCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.profesionNameCol.Caption = "Професія";
            this.profesionNameCol.FieldName = "ProfessionName";
            this.profesionNameCol.Name = "profesionNameCol";
            this.profesionNameCol.OptionsColumn.AllowEdit = false;
            this.profesionNameCol.OptionsColumn.AllowFocus = false;
            this.profesionNameCol.Visible = true;
            this.profesionNameCol.VisibleIndex = 2;
            this.profesionNameCol.Width = 230;
            // 
            // selectedCol
            // 
            this.selectedCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedCol.AppearanceCell.Options.UseFont = true;
            this.selectedCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedCol.AppearanceHeader.Options.UseFont = true;
            this.selectedCol.Caption = "Selected";
            this.selectedCol.ColumnEdit = this.employeesInfoItemCheckEdit;
            this.selectedCol.FieldName = "Selected";
            this.selectedCol.Image = ((System.Drawing.Image)(resources.GetObject("selectedCol.Image")));
            this.selectedCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.selectedCol.Name = "selectedCol";
            this.selectedCol.OptionsColumn.ShowCaption = false;
            this.selectedCol.OptionsColumn.ShowInCustomizationForm = false;
            this.selectedCol.Visible = true;
            this.selectedCol.VisibleIndex = 4;
            this.selectedCol.Width = 46;
            // 
            // employeesInfoItemCheckEdit
            // 
            this.employeesInfoItemCheckEdit.Appearance.Options.UseTextOptions = true;
            this.employeesInfoItemCheckEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.employeesInfoItemCheckEdit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.employeesInfoItemCheckEdit.AppearanceDisabled.Options.UseTextOptions = true;
            this.employeesInfoItemCheckEdit.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.employeesInfoItemCheckEdit.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.employeesInfoItemCheckEdit.AppearanceFocused.Options.UseTextOptions = true;
            this.employeesInfoItemCheckEdit.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.employeesInfoItemCheckEdit.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.employeesInfoItemCheckEdit.Name = "employeesInfoItemCheckEdit";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.excelExportAndPrintTimeSheetBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.yearEdit);
            this.ribbonPageGroup2.ItemLinks.Add(this.monthEdit);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Функції";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.excelExportAndPrintTimeSheetBtn);
            this.ribbonPageGroup3.ItemLinks.Add(this.yearEdit);
            this.ribbonPageGroup3.ItemLinks.Add(this.monthEdit);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Функції";
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // TimeSheetFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 468);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeSheetFm";
            this.ShowIcon = false;
            this.Text = "Формування табелю обліку використання робочого часу";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMonth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetDepartmentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetDepartmentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetProfessionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetProfessionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesInfoItemCheckEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    
        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem excelExportAndPrintTimeSheetBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl timeSheetDepartmentsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView timeSheetDepartmentsGridView;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl timeSheetProfessionsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView timeSheetProfessionsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn departmentsNameCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarEditItem yearEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem monthEdit;
        private DevExpress.XtraScheduler.UI.RepositoryItemMonth repositoryItemMonth1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Columns.GridColumn fioCol;
        private DevExpress.XtraGrid.Columns.GridColumn accountNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn profesionNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn selectedCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit employeesInfoItemCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn userPhotoCol;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private System.Windows.Forms.Timer timer1;

    }
}