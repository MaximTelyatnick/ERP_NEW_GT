namespace ERP_NEW.GUI.BusinessTrips
{
    partial class BusinessTripsDecreeEditFm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessTripsDecreeEditFm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.decreeDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.decreeNumberEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.businessTripsGrid = new DevExpress.XtraGrid.GridControl();
            this.businessTripsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.selectionCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selectionRepository = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.decreeStatusCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.decreeStatusRepository = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.paymentStatusCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paymentStatusRepository = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.numberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departmentCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.purposeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.employeeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.firstdateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lastDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.amountDaysCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.addBusinessTrips = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBusinessTrips = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.toolTipController = new DevExpress.Utils.ToolTipController(this.components);
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.decreeValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decreeDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decreeDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decreeNumberEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decreeStatusRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentStatusRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decreeValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.decreeDateEdit);
            this.groupControl1.Controls.Add(this.decreeNumberEdit);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(4, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1001, 65);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Наказ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(379, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(19, 13);
            this.labelControl4.TabIndex = 48;
            this.labelControl4.Text = "від:";
            // 
            // decreeDateEdit
            // 
            this.decreeDateEdit.EditValue = null;
            this.decreeDateEdit.Location = new System.Drawing.Point(404, 31);
            this.decreeDateEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decreeDateEdit.MaximumSize = new System.Drawing.Size(206, 0);
            this.decreeDateEdit.MinimumSize = new System.Drawing.Size(197, 0);
            this.decreeDateEdit.Name = "decreeDateEdit";
            this.decreeDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.decreeDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.decreeDateEdit.Size = new System.Drawing.Size(206, 20);
            this.decreeDateEdit.TabIndex = 2;
            this.decreeDateEdit.ToolTip = "Дата створення заявки";
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Введіть дату наказу";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.decreeValidationProvider.SetValidationRule(this.decreeDateEdit, conditionValidationRule1);
            this.decreeDateEdit.EditValueChanged += new System.EventHandler(this.decreeDateEdit_EditValueChanged);
            // 
            // decreeNumberEdit
            // 
            this.decreeNumberEdit.Location = new System.Drawing.Point(59, 31);
            this.decreeNumberEdit.Name = "decreeNumberEdit";
            this.decreeNumberEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.decreeNumberEdit.Properties.Appearance.Options.UseFont = true;
            this.decreeNumberEdit.Size = new System.Drawing.Size(314, 20);
            this.decreeNumberEdit.TabIndex = 1;
            this.decreeNumberEdit.ToolTip = "Номер заявки";
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Введіть номер наказу";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.decreeValidationProvider.SetValidationRule(this.decreeNumberEdit, conditionValidationRule2);
            this.decreeNumberEdit.TextChanged += new System.EventHandler(this.decreeNumberEdit_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "Номер:";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.businessTripsGrid);
            this.groupControl2.Controls.Add(this.standaloneBarDockControl1);
            this.groupControl2.Location = new System.Drawing.Point(4, 73);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1001, 348);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Відрядження";
            // 
            // businessTripsGrid
            // 
            this.businessTripsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.businessTripsGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.businessTripsGrid.Location = new System.Drawing.Point(2, 51);
            this.businessTripsGrid.MainView = this.businessTripsGridView;
            this.businessTripsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.businessTripsGrid.MenuManager = this.barManager;
            this.businessTripsGrid.Name = "businessTripsGrid";
            this.businessTripsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.decreeStatusRepository,
            this.paymentStatusRepository,
            this.selectionRepository});
            this.businessTripsGrid.Size = new System.Drawing.Size(997, 295);
            this.businessTripsGrid.TabIndex = 4;
            this.businessTripsGrid.ToolTipController = this.toolTipController;
            this.businessTripsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.businessTripsGridView});
            // 
            // businessTripsGridView
            // 
            this.businessTripsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.selectionCol,
            this.decreeStatusCol,
            this.paymentStatusCol,
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
            this.businessTripsGridView.OptionsView.ShowGroupPanel = false;
            this.businessTripsGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.businessTripsGridView_ShowingEditor);
            this.businessTripsGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.businessTripsGridView_CustomUnboundColumnData);
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
            this.selectionCol.Width = 35;
            // 
            // selectionRepository
            // 
            this.selectionRepository.AutoHeight = false;
            this.selectionRepository.Name = "selectionRepository";
            this.selectionRepository.CheckedChanged += new System.EventHandler(this.selectionRepository_CheckedChanged);
            // 
            // decreeStatusCol
            // 
            this.decreeStatusCol.ColumnEdit = this.decreeStatusRepository;
            this.decreeStatusCol.FieldName = "decreeStatusCol";
            this.decreeStatusCol.Image = ((System.Drawing.Image)(resources.GetObject("decreeStatusCol.Image")));
            this.decreeStatusCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.decreeStatusCol.Name = "decreeStatusCol";
            this.decreeStatusCol.OptionsColumn.AllowEdit = false;
            this.decreeStatusCol.OptionsColumn.AllowFocus = false;
            this.decreeStatusCol.OptionsColumn.ShowCaption = false;
            this.decreeStatusCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.decreeStatusCol.Visible = true;
            this.decreeStatusCol.VisibleIndex = 1;
            this.decreeStatusCol.Width = 31;
            // 
            // decreeStatusRepository
            // 
            this.decreeStatusRepository.Name = "decreeStatusRepository";
            this.decreeStatusRepository.NullText = " ";
            this.decreeStatusRepository.ZoomAccelerationFactor = 1D;
            // 
            // paymentStatusCol
            // 
            this.paymentStatusCol.ColumnEdit = this.paymentStatusRepository;
            this.paymentStatusCol.FieldName = "paymentStatusCol";
            this.paymentStatusCol.Image = ((System.Drawing.Image)(resources.GetObject("paymentStatusCol.Image")));
            this.paymentStatusCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.paymentStatusCol.Name = "paymentStatusCol";
            this.paymentStatusCol.OptionsColumn.AllowEdit = false;
            this.paymentStatusCol.OptionsColumn.AllowFocus = false;
            this.paymentStatusCol.OptionsColumn.ShowCaption = false;
            this.paymentStatusCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.paymentStatusCol.Visible = true;
            this.paymentStatusCol.VisibleIndex = 2;
            this.paymentStatusCol.Width = 31;
            // 
            // paymentStatusRepository
            // 
            this.paymentStatusRepository.Name = "paymentStatusRepository";
            this.paymentStatusRepository.NullText = " ";
            this.paymentStatusRepository.ZoomAccelerationFactor = 1D;
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
            this.numberCol.VisibleIndex = 3;
            this.numberCol.Width = 132;
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
            this.dateCol.VisibleIndex = 4;
            this.dateCol.Width = 98;
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
            this.departmentCol.Visible = true;
            this.departmentCol.VisibleIndex = 5;
            this.departmentCol.Width = 98;
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
            this.purposeCol.VisibleIndex = 6;
            this.purposeCol.Width = 98;
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
            this.employeeCol.Visible = true;
            this.employeeCol.VisibleIndex = 7;
            this.employeeCol.Width = 98;
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
            this.firstdateCol.VisibleIndex = 8;
            this.firstdateCol.Width = 98;
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
            this.lastDateCol.VisibleIndex = 9;
            this.lastDateCol.Width = 98;
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
            this.amountDaysCol.VisibleIndex = 10;
            this.amountDaysCol.Width = 162;
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addBusinessTrips,
            this.deleteBusinessTrips});
            this.barManager.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.addBusinessTrips, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.deleteBusinessTrips, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar1.Text = "Tools";
            // 
            // addBusinessTrips
            // 
            this.addBusinessTrips.Caption = "Додати";
            this.addBusinessTrips.Glyph = ((System.Drawing.Image)(resources.GetObject("addBusinessTrips.Glyph")));
            this.addBusinessTrips.Id = 0;
            this.addBusinessTrips.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addBusinessTrips.LargeGlyph")));
            this.addBusinessTrips.Name = "addBusinessTrips";
            this.addBusinessTrips.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBusinessTrips_ItemClick);
            // 
            // deleteBusinessTrips
            // 
            this.deleteBusinessTrips.Caption = "Видалити";
            this.deleteBusinessTrips.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteBusinessTrips.Glyph")));
            this.deleteBusinessTrips.Id = 1;
            this.deleteBusinessTrips.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteBusinessTrips.LargeGlyph")));
            this.deleteBusinessTrips.Name = "deleteBusinessTrips";
            this.deleteBusinessTrips.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBusinessTrips_ItemClick);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(2, 20);
            this.standaloneBarDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(997, 31);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1009, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 461);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1009, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 461);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1009, 0);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 461);
            // 
            // toolTipController
            // 
            this.toolTipController.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.toolTipController_GetActiveObjectInfo);
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(6, 431);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 36;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(922, 426);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 35;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(841, 426);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 34;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // decreeValidationProvider
            // 
            this.decreeValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            this.decreeValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.decreeValidationProvider_ValidationFailed);
            this.decreeValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.decreeValidationProvider_ValidationSucceeded);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "cancel_16x16.png");
            this.imageCollection.InsertGalleryImage("boresume_16x16.png", "images/business%20objects/boresume_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/business%20objects/boresume_16x16.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "boresume_16x16.png");
            this.imageCollection.InsertGalleryImage("switchtimescalesto_16x16.png", "office2013/scheduling/switchtimescalesto_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/scheduling/switchtimescalesto_16x16.png"), 2);
            this.imageCollection.Images.SetKeyName(2, "switchtimescalesto_16x16.png");
            this.imageCollection.InsertGalleryImage("deletegroupfooter_16x16.png", "images/reports/deletegroupfooter_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/reports/deletegroupfooter_16x16.png"), 3);
            this.imageCollection.Images.SetKeyName(3, "deletegroupfooter_16x16.png");
            this.imageCollection.InsertGalleryImage("financial_16x16.png", "images/function%20library/financial_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/function%20library/financial_16x16.png"), 4);
            this.imageCollection.Images.SetKeyName(4, "financial_16x16.png");
            // 
            // BusinessTripsDecreeEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1009, 461);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusinessTripsDecreeEditFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Наказ на відрядження";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decreeDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decreeDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decreeNumberEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decreeStatusRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentStatusRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decreeValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit decreeDateEdit;
        private DevExpress.XtraEditors.TextEdit decreeNumberEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem addBusinessTrips;
        private DevExpress.XtraBars.BarButtonItem deleteBusinessTrips;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
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
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider decreeValidationProvider;
        private DevExpress.XtraGrid.Columns.GridColumn decreeStatusCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit decreeStatusRepository;
        private DevExpress.XtraGrid.Columns.GridColumn paymentStatusCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit paymentStatusRepository;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraGrid.Columns.GridColumn selectionCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit selectionRepository;
        private DevExpress.Utils.ToolTipController toolTipController;
    }
}