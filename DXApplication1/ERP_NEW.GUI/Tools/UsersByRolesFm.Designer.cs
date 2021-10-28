namespace ERP_NEW.GUI.Tools
{
    partial class UsersByRolesFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersByRolesFm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.userRolesGrid = new DevExpress.XtraGrid.GridControl();
            this.userRolesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.roleNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.standaloneBarDockControl4 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.usersGrid = new DevExpress.XtraGrid.GridControl();
            this.usersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.employeeNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fioCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.professionCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departmentCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.userTasksGrid = new DevExpress.XtraGrid.GridControl();
            this.userTasksGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.taskCaptionCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taskNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rightNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.priceAttributeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.GroupCategory = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.userRoleAddItem = new DevExpress.XtraBars.BarButtonItem();
            this.userRoleEditItem = new DevExpress.XtraBars.BarButtonItem();
            this.userRoleDeleteItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.usersAddItem = new DevExpress.XtraBars.BarButtonItem();
            this.userDeleteItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tasksAddItem = new DevExpress.XtraBars.BarButtonItem();
            this.tasksEditItem = new DevExpress.XtraBars.BarButtonItem();
            this.taskDeleteItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTasksGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTasksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 95);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Size = new System.Drawing.Size(1423, 703);
            this.splitContainerControl1.SplitterPosition = 627;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.userRolesGrid);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(627, 703);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Групи користувачів";
            // 
            // userRolesGrid
            // 
            this.userRolesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userRolesGrid.Location = new System.Drawing.Point(2, 20);
            this.userRolesGrid.MainView = this.userRolesGridView;
            this.userRolesGrid.Name = "userRolesGrid";
            this.userRolesGrid.Size = new System.Drawing.Size(623, 681);
            this.userRolesGrid.TabIndex = 0;
            this.userRolesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userRolesGridView});
            // 
            // userRolesGridView
            // 
            this.userRolesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.roleNameCol});
            this.userRolesGridView.GridControl = this.userRolesGrid;
            this.userRolesGridView.Name = "userRolesGridView";
            this.userRolesGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.userRolesGridView.OptionsView.ShowAutoFilterRow = true;
            this.userRolesGridView.OptionsView.ShowGroupPanel = false;
            this.userRolesGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.userRolesGridView_FocusedRowChanged);
            // 
            // roleNameCol
            // 
            this.roleNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.roleNameCol.AppearanceHeader.Options.UseFont = true;
            this.roleNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.roleNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.roleNameCol.Caption = "Найменування групи";
            this.roleNameCol.FieldName = "RoleName";
            this.roleNameCol.Name = "roleNameCol";
            this.roleNameCol.OptionsColumn.AllowEdit = false;
            this.roleNameCol.OptionsColumn.AllowFocus = false;
            this.roleNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.roleNameCol.Visible = true;
            this.roleNameCol.VisibleIndex = 0;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl3);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(791, 703);
            this.splitContainerControl2.SplitterPosition = 350;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.standaloneBarDockControl4);
            this.groupControl2.Controls.Add(this.usersGrid);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(791, 350);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Користувачі";
            // 
            // standaloneBarDockControl4
            // 
            this.standaloneBarDockControl4.CausesValidation = false;
            this.standaloneBarDockControl4.Location = new System.Drawing.Point(22, 475);
            this.standaloneBarDockControl4.Name = "standaloneBarDockControl4";
            this.standaloneBarDockControl4.Size = new System.Drawing.Size(921, 41);
            this.standaloneBarDockControl4.Text = "standaloneBarDockControl4";
            // 
            // usersGrid
            // 
            this.usersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersGrid.Location = new System.Drawing.Point(2, 20);
            this.usersGrid.MainView = this.usersGridView;
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.Size = new System.Drawing.Size(787, 328);
            this.usersGrid.TabIndex = 1;
            this.usersGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.usersGridView});
            // 
            // usersGridView
            // 
            this.usersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.employeeNumberCol,
            this.fioCol,
            this.professionCol,
            this.departmentCol});
            this.usersGridView.GridControl = this.usersGrid;
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.usersGridView.OptionsView.ShowAutoFilterRow = true;
            this.usersGridView.OptionsView.ShowGroupPanel = false;
            // 
            // employeeNumberCol
            // 
            this.employeeNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.employeeNumberCol.AppearanceHeader.Options.UseFont = true;
            this.employeeNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.employeeNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.employeeNumberCol.Caption = "Таб. номер";
            this.employeeNumberCol.FieldName = "EmployeeNumber";
            this.employeeNumberCol.Name = "employeeNumberCol";
            this.employeeNumberCol.OptionsColumn.AllowEdit = false;
            this.employeeNumberCol.OptionsColumn.AllowFocus = false;
            this.employeeNumberCol.Visible = true;
            this.employeeNumberCol.VisibleIndex = 0;
            this.employeeNumberCol.Width = 73;
            // 
            // fioCol
            // 
            this.fioCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fioCol.AppearanceHeader.Options.UseFont = true;
            this.fioCol.AppearanceHeader.Options.UseTextOptions = true;
            this.fioCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fioCol.Caption = "ПІБ";
            this.fioCol.FieldName = "Fio";
            this.fioCol.Name = "fioCol";
            this.fioCol.OptionsColumn.AllowEdit = false;
            this.fioCol.OptionsColumn.AllowFocus = false;
            this.fioCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.fioCol.Visible = true;
            this.fioCol.VisibleIndex = 1;
            this.fioCol.Width = 305;
            // 
            // professionCol
            // 
            this.professionCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.professionCol.AppearanceHeader.Options.UseFont = true;
            this.professionCol.AppearanceHeader.Options.UseTextOptions = true;
            this.professionCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.professionCol.Caption = "Професія";
            this.professionCol.FieldName = "ProfessionName";
            this.professionCol.Name = "professionCol";
            this.professionCol.Visible = true;
            this.professionCol.VisibleIndex = 2;
            this.professionCol.Width = 189;
            // 
            // departmentCol
            // 
            this.departmentCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.departmentCol.AppearanceHeader.Options.UseFont = true;
            this.departmentCol.AppearanceHeader.Options.UseTextOptions = true;
            this.departmentCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.departmentCol.Caption = "Підрозділ";
            this.departmentCol.FieldName = "DepartmentName";
            this.departmentCol.Name = "departmentCol";
            this.departmentCol.Visible = true;
            this.departmentCol.VisibleIndex = 3;
            this.departmentCol.Width = 202;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.userTasksGrid);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(791, 348);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Пункти головного меню";
            // 
            // userTasksGrid
            // 
            this.userTasksGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTasksGrid.Location = new System.Drawing.Point(2, 20);
            this.userTasksGrid.MainView = this.userTasksGridView;
            this.userTasksGrid.Name = "userTasksGrid";
            this.userTasksGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.userTasksGrid.Size = new System.Drawing.Size(787, 326);
            this.userTasksGrid.TabIndex = 2;
            this.userTasksGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userTasksGridView});
            // 
            // userTasksGridView
            // 
            this.userTasksGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.taskCaptionCol,
            this.taskNameCol,
            this.rightNameCol,
            this.priceAttributeCol});
            this.userTasksGridView.GridControl = this.userTasksGrid;
            this.userTasksGridView.Name = "userTasksGridView";
            this.userTasksGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.userTasksGridView.OptionsView.ShowAutoFilterRow = true;
            this.userTasksGridView.OptionsView.ShowGroupPanel = false;
            // 
            // taskCaptionCol
            // 
            this.taskCaptionCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.taskCaptionCol.AppearanceHeader.Options.UseFont = true;
            this.taskCaptionCol.AppearanceHeader.Options.UseTextOptions = true;
            this.taskCaptionCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.taskCaptionCol.Caption = "Режим";
            this.taskCaptionCol.FieldName = "TaskCaption";
            this.taskCaptionCol.Name = "taskCaptionCol";
            this.taskCaptionCol.OptionsColumn.AllowEdit = false;
            this.taskCaptionCol.OptionsColumn.AllowFocus = false;
            this.taskCaptionCol.Visible = true;
            this.taskCaptionCol.VisibleIndex = 0;
            this.taskCaptionCol.Width = 608;
            // 
            // taskNameCol
            // 
            this.taskNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.taskNameCol.AppearanceHeader.Options.UseFont = true;
            this.taskNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.taskNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.taskNameCol.Caption = "Код";
            this.taskNameCol.FieldName = "TaskName";
            this.taskNameCol.Name = "taskNameCol";
            this.taskNameCol.OptionsColumn.AllowEdit = false;
            this.taskNameCol.OptionsColumn.AllowFocus = false;
            this.taskNameCol.Visible = true;
            this.taskNameCol.VisibleIndex = 1;
            this.taskNameCol.Width = 282;
            // 
            // rightNameCol
            // 
            this.rightNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.rightNameCol.AppearanceHeader.Options.UseFont = true;
            this.rightNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.rightNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rightNameCol.Caption = "Доступ";
            this.rightNameCol.FieldName = "RightName";
            this.rightNameCol.Name = "rightNameCol";
            this.rightNameCol.OptionsColumn.AllowEdit = false;
            this.rightNameCol.OptionsColumn.AllowFocus = false;
            this.rightNameCol.Visible = true;
            this.rightNameCol.VisibleIndex = 2;
            // 
            // priceAttributeCol
            // 
            this.priceAttributeCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.priceAttributeCol.AppearanceHeader.Options.UseFont = true;
            this.priceAttributeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.priceAttributeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.priceAttributeCol.Caption = "Ціни";
            this.priceAttributeCol.ColumnEdit = this.repositoryItemCheckEdit1;
            this.priceAttributeCol.FieldName = "PriceAttribute";
            this.priceAttributeCol.Name = "priceAttributeCol";
            this.priceAttributeCol.OptionsColumn.AllowEdit = false;
            this.priceAttributeCol.OptionsColumn.AllowFocus = false;
            this.priceAttributeCol.Visible = true;
            this.priceAttributeCol.VisibleIndex = 3;
            this.priceAttributeCol.Width = 48;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.GroupCategory,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // GroupCategory
            // 
            this.GroupCategory.ItemLinks.Add(this.userRoleAddItem);
            this.GroupCategory.ItemLinks.Add(this.userRoleEditItem);
            this.GroupCategory.ItemLinks.Add(this.userRoleDeleteItem);
            this.GroupCategory.Name = "GroupCategory";
            this.GroupCategory.Text = "Групи";
            // 
            // userRoleAddItem
            // 
            this.userRoleAddItem.Caption = "Додати";
            this.userRoleAddItem.Glyph = ((System.Drawing.Image)(resources.GetObject("userRoleAddItem.Glyph")));
            this.userRoleAddItem.Id = 1;
            this.userRoleAddItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("userRoleAddItem.LargeGlyph")));
            this.userRoleAddItem.Name = "userRoleAddItem";
            this.userRoleAddItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.userRoleAddItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.userRoleAddItem_ItemClick);
            // 
            // userRoleEditItem
            // 
            this.userRoleEditItem.Caption = "Редагувати";
            this.userRoleEditItem.Glyph = ((System.Drawing.Image)(resources.GetObject("userRoleEditItem.Glyph")));
            this.userRoleEditItem.Id = 2;
            this.userRoleEditItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("userRoleEditItem.LargeGlyph")));
            this.userRoleEditItem.Name = "userRoleEditItem";
            this.userRoleEditItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.userRoleEditItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.userRoleEditItem_ItemClick);
            // 
            // userRoleDeleteItem
            // 
            this.userRoleDeleteItem.Caption = "Видалити";
            this.userRoleDeleteItem.Glyph = ((System.Drawing.Image)(resources.GetObject("userRoleDeleteItem.Glyph")));
            this.userRoleDeleteItem.Id = 3;
            this.userRoleDeleteItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("userRoleDeleteItem.LargeGlyph")));
            this.userRoleDeleteItem.Name = "userRoleDeleteItem";
            this.userRoleDeleteItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.userRoleDeleteItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.userRoleDeleteItem_ItemClick);
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.usersAddItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.userDeleteItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Користувачі";
            // 
            // usersAddItem
            // 
            this.usersAddItem.Caption = "Додати";
            this.usersAddItem.Glyph = ((System.Drawing.Image)(resources.GetObject("usersAddItem.Glyph")));
            this.usersAddItem.Id = 4;
            this.usersAddItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("usersAddItem.LargeGlyph")));
            this.usersAddItem.Name = "usersAddItem";
            this.usersAddItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.usersAddItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.usersAddItem_ItemClick);
            // 
            // userDeleteItem
            // 
            this.userDeleteItem.Caption = "Видалити";
            this.userDeleteItem.Glyph = ((System.Drawing.Image)(resources.GetObject("userDeleteItem.Glyph")));
            this.userDeleteItem.Id = 5;
            this.userDeleteItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("userDeleteItem.LargeGlyph")));
            this.userDeleteItem.Name = "userDeleteItem";
            this.userDeleteItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.userDeleteItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.userDeleteItem_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.tasksAddItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.tasksEditItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.taskDeleteItem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Пункти меню";
            // 
            // tasksAddItem
            // 
            this.tasksAddItem.Caption = "Додати";
            this.tasksAddItem.Glyph = ((System.Drawing.Image)(resources.GetObject("tasksAddItem.Glyph")));
            this.tasksAddItem.Id = 6;
            this.tasksAddItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tasksAddItem.LargeGlyph")));
            this.tasksAddItem.Name = "tasksAddItem";
            this.tasksAddItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.tasksAddItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tasksAddItem_ItemClick);
            // 
            // tasksEditItem
            // 
            this.tasksEditItem.Caption = "Редагувати";
            this.tasksEditItem.Glyph = ((System.Drawing.Image)(resources.GetObject("tasksEditItem.Glyph")));
            this.tasksEditItem.Id = 8;
            this.tasksEditItem.Name = "tasksEditItem";
            this.tasksEditItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.tasksEditItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tasksEditItem_ItemClick);
            // 
            // taskDeleteItem
            // 
            this.taskDeleteItem.Caption = "Видалити";
            this.taskDeleteItem.Glyph = ((System.Drawing.Image)(resources.GetObject("taskDeleteItem.Glyph")));
            this.taskDeleteItem.Id = 7;
            this.taskDeleteItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("taskDeleteItem.LargeGlyph")));
            this.taskDeleteItem.Name = "taskDeleteItem";
            this.taskDeleteItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.taskDeleteItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.taskDeleteItem_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.userRoleAddItem,
            this.userRoleEditItem,
            this.userRoleDeleteItem,
            this.usersAddItem,
            this.userDeleteItem,
            this.tasksAddItem,
            this.taskDeleteItem,
            this.tasksEditItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1423, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // UsersByRolesFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 798);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "UsersByRolesFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Группы пользователей";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userRolesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userTasksGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTasksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl userRolesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView userRolesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn roleNameCol;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl4;
        private DevExpress.XtraGrid.GridControl usersGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView usersGridView;
        private DevExpress.XtraGrid.Columns.GridColumn fioCol;
        private DevExpress.XtraGrid.Columns.GridColumn employeeNumberCol;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl userTasksGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView userTasksGridView;
        private DevExpress.XtraGrid.Columns.GridColumn taskCaptionCol;
        private DevExpress.XtraGrid.Columns.GridColumn taskNameCol;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GroupCategory;
        private DevExpress.XtraBars.BarButtonItem userRoleAddItem;
        private DevExpress.XtraBars.BarButtonItem userRoleEditItem;
        private DevExpress.XtraBars.BarButtonItem userRoleDeleteItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem usersAddItem;
        private DevExpress.XtraBars.BarButtonItem userDeleteItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem tasksAddItem;
        private DevExpress.XtraBars.BarButtonItem taskDeleteItem;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraGrid.Columns.GridColumn professionCol;
        private DevExpress.XtraGrid.Columns.GridColumn departmentCol;
        private DevExpress.XtraGrid.Columns.GridColumn rightNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn priceAttributeCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarButtonItem tasksEditItem;
    }
}