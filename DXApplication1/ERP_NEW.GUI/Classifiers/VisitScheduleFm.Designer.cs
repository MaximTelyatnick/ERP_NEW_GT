namespace ERP_NEW.GUI.Classifiers
{
    partial class VisitScheduleFm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.visitSheduleDepartmentsGrid = new DevExpress.XtraGrid.GridControl();
            this.visitSheduleDepartmentsgridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.departmentCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.employeesCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.photoPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nameProfessionLabel = new DevExpress.XtraEditors.LabelControl();
            this.accountNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.historyEmployeesGrid = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.dateBeginCol = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_dateBeginCol = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.dateEndCol = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_dateEndCol = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.calendarEditor = new Calendar.NET.Calendar();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitSheduleDepartmentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitSheduleDepartmentsgridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureEdit.Properties)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyEmployeesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_dateBeginCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_dateEndCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = this.gridControl1;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 2);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Size = new System.Drawing.Size(400, 200);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.visitSheduleDepartmentsGrid);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(442, 829);
            this.groupControl1.TabIndex = 0;
            // 
            // visitSheduleDepartmentsGrid
            // 
            this.visitSheduleDepartmentsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.visitSheduleDepartmentsGrid.Location = new System.Drawing.Point(2, 20);
            this.visitSheduleDepartmentsGrid.MainView = this.visitSheduleDepartmentsgridView;
            this.visitSheduleDepartmentsGrid.Name = "visitSheduleDepartmentsGrid";
            this.visitSheduleDepartmentsGrid.Size = new System.Drawing.Size(438, 807);
            this.visitSheduleDepartmentsGrid.TabIndex = 0;
            this.visitSheduleDepartmentsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.visitSheduleDepartmentsgridView});
            // 
            // visitSheduleDepartmentsgridView
            // 
            this.visitSheduleDepartmentsgridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visitSheduleDepartmentsgridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.visitSheduleDepartmentsgridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.visitSheduleDepartmentsgridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.visitSheduleDepartmentsgridView.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visitSheduleDepartmentsgridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.visitSheduleDepartmentsgridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.departmentCol,
            this.employeesCol,
            this.gridColumn1});
            this.visitSheduleDepartmentsgridView.GridControl = this.visitSheduleDepartmentsGrid;
            this.visitSheduleDepartmentsgridView.GroupCount = 1;
            this.visitSheduleDepartmentsgridView.Name = "visitSheduleDepartmentsgridView";
            this.visitSheduleDepartmentsgridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.visitSheduleDepartmentsgridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.departmentCol, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.employeesCol, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.visitSheduleDepartmentsgridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.visitSheduleDepartmentsgridView_FocusedRowChanged);
            // 
            // departmentCol
            // 
            this.departmentCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentCol.AppearanceHeader.Options.UseFont = true;
            this.departmentCol.AppearanceHeader.Options.UseTextOptions = true;
            this.departmentCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.departmentCol.Caption = "Підрозділ";
            this.departmentCol.FieldName = "DepartmentName";
            this.departmentCol.Name = "departmentCol";
            this.departmentCol.Visible = true;
            this.departmentCol.VisibleIndex = 0;
            // 
            // employeesCol
            // 
            this.employeesCol.Caption = "Співвробітники";
            this.employeesCol.FieldName = "Fio";
            this.employeesCol.Name = "employeesCol";
            this.employeesCol.OptionsColumn.AllowEdit = false;
            this.employeesCol.OptionsColumn.AllowFocus = false;
            this.employeesCol.Visible = true;
            this.employeesCol.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Професія";
            this.gridColumn1.FieldName = "ProfessionName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(442, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainerControl1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerControl1.Size = new System.Drawing.Size(1437, 829);
            this.splitContainerControl1.SplitterPosition = 234;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.photoPictureEdit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1426, 225);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // photoPictureEdit
            // 
            this.photoPictureEdit.Location = new System.Drawing.Point(3, 3);
            this.photoPictureEdit.MaximumSize = new System.Drawing.Size(165, 216);
            this.photoPictureEdit.MinimumSize = new System.Drawing.Size(156, 200);
            this.photoPictureEdit.Name = "photoPictureEdit";
            this.photoPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.photoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.photoPictureEdit.Properties.ZoomAccelerationFactor = 1D;
            this.photoPictureEdit.Size = new System.Drawing.Size(165, 216);
            this.photoPictureEdit.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(174, 3);
            this.tabControl1.MinimumSize = new System.Drawing.Size(500, 200);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1249, 219);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nameProfessionLabel);
            this.tabPage1.Controls.Add(this.accountNumberLabel);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1241, 190);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Інформація про працівника";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nameProfessionLabel
            // 
            this.nameProfessionLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProfessionLabel.AutoEllipsis = true;
            this.nameProfessionLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.nameProfessionLabel.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.nameProfessionLabel.LineVisible = true;
            this.nameProfessionLabel.Location = new System.Drawing.Point(16, 25);
            this.nameProfessionLabel.Name = "nameProfessionLabel";
            this.nameProfessionLabel.Size = new System.Drawing.Size(161, 18);
            this.nameProfessionLabel.TabIndex = 1;
            this.nameProfessionLabel.Text = "nameProfessionLabel";
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountNumberLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.accountNumberLabel.Location = new System.Drawing.Point(16, 63);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(158, 18);
            this.accountNumberLabel.TabIndex = 0;
            this.accountNumberLabel.Text = "accountNumberLabel";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.historyEmployeesGrid);
            this.tabPage2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1241, 190);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Період роботи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // historyEmployeesGrid
            // 
            this.historyEmployeesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyEmployeesGrid.Location = new System.Drawing.Point(3, 3);
            this.historyEmployeesGrid.MainView = this.layoutView1;
            this.historyEmployeesGrid.Margin = new System.Windows.Forms.Padding(5);
            this.historyEmployeesGrid.Name = "historyEmployeesGrid";
            this.historyEmployeesGrid.Size = new System.Drawing.Size(1235, 184);
            this.historyEmployeesGrid.TabIndex = 0;
            this.historyEmployeesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.CardMinSize = new System.Drawing.Size(187, 86);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.dateBeginCol,
            this.dateEndCol});
            this.layoutView1.GridControl = this.historyEmployeesGrid;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsView.ShowCardCaption = false;
            this.layoutView1.OptionsView.ShowHeaderPanel = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Row;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // dateBeginCol
            // 
            this.dateBeginCol.Caption = "З";
            this.dateBeginCol.FieldName = "DateBegin";
            this.dateBeginCol.LayoutViewField = this.layoutViewField_dateBeginCol;
            this.dateBeginCol.Name = "dateBeginCol";
            // 
            // layoutViewField_dateBeginCol
            // 
            this.layoutViewField_dateBeginCol.EditorPreferredWidth = 134;
            this.layoutViewField_dateBeginCol.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_dateBeginCol.Name = "layoutViewField_dateBeginCol";
            this.layoutViewField_dateBeginCol.Size = new System.Drawing.Size(167, 24);
            this.layoutViewField_dateBeginCol.TextSize = new System.Drawing.Size(17, 13);
            // 
            // dateEndCol
            // 
            this.dateEndCol.Caption = "По";
            this.dateEndCol.FieldName = "DateEnd";
            this.dateEndCol.LayoutViewField = this.layoutViewField_dateEndCol;
            this.dateEndCol.Name = "dateEndCol";
            // 
            // layoutViewField_dateEndCol
            // 
            this.layoutViewField_dateEndCol.EditorPreferredWidth = 134;
            this.layoutViewField_dateEndCol.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_dateEndCol.Name = "layoutViewField_dateEndCol";
            this.layoutViewField_dateEndCol.Size = new System.Drawing.Size(167, 42);
            this.layoutViewField_dateEndCol.TextSize = new System.Drawing.Size(17, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.GroupBordersVisible = false;
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_dateBeginCol,
            this.layoutViewField_dateEndCol});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.calendarEditor, 0, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, -3);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(600, 400);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1422, 581);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // calendarEditor
            // 
            this.calendarEditor.AllowEditingEvents = true;
            this.calendarEditor.AutoSize = true;
            this.calendarEditor.BackColor = System.Drawing.Color.AliceBlue;
            this.calendarEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calendarEditor.CalendarDate = new System.DateTime(((long)(0)));
            this.calendarEditor.CalendarView = Calendar.NET.CalendarViews.Month;
            this.calendarEditor.CausesValidation = false;
            this.calendarEditor.DateHeaderFont = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.calendarEditor.DayOfWeekFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.calendarEditor.DaysFont = new System.Drawing.Font("Times New Roman", 11F);
            this.calendarEditor.DayViewTimeFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.calendarEditor.DimDisabledEvents = true;
            this.calendarEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarEditor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calendarEditor.ForeColor = System.Drawing.Color.White;
            this.calendarEditor.HighlightCurrentDay = true;
            this.calendarEditor.LoadPresetHolidays = false;
            this.calendarEditor.Location = new System.Drawing.Point(3, 3);
            this.calendarEditor.MinimumSize = new System.Drawing.Size(600, 400);
            this.calendarEditor.Name = "calendarEditor";
            this.calendarEditor.ShowArrowControls = true;
            this.calendarEditor.ShowDashedBorderOnDisabledEvents = true;
            this.calendarEditor.ShowDateInHeader = true;
            this.calendarEditor.ShowDisabledEvents = true;
            this.calendarEditor.ShowEventTooltips = false;
            this.calendarEditor.ShowTodayButton = false;
            this.calendarEditor.Size = new System.Drawing.Size(1416, 575);
            this.calendarEditor.TabIndex = 0;
            this.calendarEditor.TodayFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // VisitScheduleFm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1879, 829);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "VisitScheduleFm";
            this.Text = "VisitScheduleFm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visitSheduleDepartmentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitSheduleDepartmentsgridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureEdit.Properties)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyEmployeesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_dateBeginCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_dateEndCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl visitSheduleDepartmentsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView visitSheduleDepartmentsgridView;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.Columns.GridColumn departmentCol;
        private DevExpress.XtraGrid.Columns.GridColumn employeesCol;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private Calendar.NET.Calendar calendarEditor;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraEditors.PictureEdit photoPictureEdit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl historyEmployeesGrid;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn dateBeginCol;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_dateBeginCol;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn dateEndCol;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_dateEndCol;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraEditors.LabelControl nameProfessionLabel;
        private DevExpress.XtraEditors.LabelControl accountNumberLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    }
}