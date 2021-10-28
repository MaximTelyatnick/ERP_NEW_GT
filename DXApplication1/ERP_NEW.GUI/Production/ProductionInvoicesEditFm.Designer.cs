namespace ERP_NEW.GUI.Production
{
    partial class ProductionInvoicesEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionInvoicesEditFm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.responsiblePersonEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.numberEdit = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.invoiceRequirementMaterialsGrid = new DevExpress.XtraGrid.GridControl();
            this.invoiceRequirementMaterialGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nomenclatureCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.balanceAccountNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receiptNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nomenclatureNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.requiredQuantityCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitLocalNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selectionCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selectionRepository = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.costumerOrderCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerOrderExpCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerOrderRepository = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.standaloneBarDockControl2 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editOrderBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.productionInvoicesValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responsiblePersonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceRequirementMaterialsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceRequirementMaterialGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionInvoicesValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.responsiblePersonEdit);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.dateEdit);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.numberEdit);
            this.groupControl2.Location = new System.Drawing.Point(12, 11);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1390, 102);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Вимоги";
            // 
            // responsiblePersonEdit
            // 
            this.responsiblePersonEdit.Location = new System.Drawing.Point(473, 36);
            this.responsiblePersonEdit.Name = "responsiblePersonEdit";
            this.responsiblePersonEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.responsiblePersonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.responsiblePersonEdit.Properties.ImmediatePopup = true;
            this.responsiblePersonEdit.Properties.PopupFormSize = new System.Drawing.Size(667, 0);
            this.responsiblePersonEdit.Properties.PopupSizeable = false;
            this.responsiblePersonEdit.Properties.View = this.gridView1;
            this.responsiblePersonEdit.Size = new System.Drawing.Size(912, 20);
            this.responsiblePersonEdit.TabIndex = 1;
            this.responsiblePersonEdit.ToolTip = "П.І.Б працівника";
            this.responsiblePersonEdit.EditValueChanged += new System.EventHandler(this.responsiblePersonEdit_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.SearchInPreview = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "ПІБ працівника";
            this.gridColumn13.FieldName = "Fio";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.OptionsColumn.AllowFocus = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            this.gridColumn13.Width = 140;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Таб. номер";
            this.gridColumn14.FieldName = "AccountNumber";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.OptionsColumn.AllowFocus = false;
            this.gridColumn14.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 1;
            this.gridColumn14.Width = 68;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Професія";
            this.gridColumn15.FieldName = "ProfessionName";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.OptionsColumn.AllowFocus = false;
            this.gridColumn15.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 2;
            this.gridColumn15.Width = 137;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Підрозділ";
            this.gridColumn16.FieldName = "DepartmentName";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 3;
            this.gridColumn16.Width = 80;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(349, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 13);
            this.labelControl2.TabIndex = 57;
            this.labelControl2.Text = "Відповідальна особа:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 70);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 54;
            this.labelControl4.Text = "Дата:";
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(108, 67);
            this.dateEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateEdit.MaximumSize = new System.Drawing.Size(206, 0);
            this.dateEdit.MinimumSize = new System.Drawing.Size(197, 0);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEdit.Size = new System.Drawing.Size(206, 20);
            this.dateEdit.TabIndex = 2;
            this.dateEdit.ToolTip = "Дата створення заявки";
            this.dateEdit.EditValueChanged += new System.EventHandler(this.dateEdit_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 52;
            this.labelControl1.Text = "Номер вимоги:";
            // 
            // numberEdit
            // 
            this.numberEdit.Location = new System.Drawing.Point(108, 32);
            this.numberEdit.Name = "numberEdit";
            this.numberEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.numberEdit.Properties.Appearance.Options.UseFont = true;
            this.numberEdit.Size = new System.Drawing.Size(206, 20);
            this.numberEdit.TabIndex = 0;
            this.numberEdit.ToolTip = "Номер заявки";
            this.numberEdit.EditValueChanged += new System.EventHandler(this.numberEdit_EditValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.invoiceRequirementMaterialsGrid);
            this.groupControl1.Controls.Add(this.standaloneBarDockControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 117);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1390, 382);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Матеріали";
            // 
            // invoiceRequirementMaterialsGrid
            // 
            this.invoiceRequirementMaterialsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceRequirementMaterialsGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invoiceRequirementMaterialsGrid.Location = new System.Drawing.Point(2, 45);
            this.invoiceRequirementMaterialsGrid.MainView = this.invoiceRequirementMaterialGridView;
            this.invoiceRequirementMaterialsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invoiceRequirementMaterialsGrid.Name = "invoiceRequirementMaterialsGrid";
            this.invoiceRequirementMaterialsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.selectionRepository,
            this.customerOrderRepository});
            this.invoiceRequirementMaterialsGrid.Size = new System.Drawing.Size(1386, 335);
            this.invoiceRequirementMaterialsGrid.TabIndex = 6;
            this.invoiceRequirementMaterialsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.invoiceRequirementMaterialGridView});
            // 
            // invoiceRequirementMaterialGridView
            // 
            this.invoiceRequirementMaterialGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nomenclatureCol,
            this.balanceAccountNumCol,
            this.receiptNumCol,
            this.nomenclatureNameCol,
            this.requiredQuantityCol,
            this.unitLocalNameCol,
            this.unitPriceCol,
            this.totalPriceCol,
            this.selectionCol,
            this.costumerOrderCol,
            this.customerOrderExpCol});
            this.invoiceRequirementMaterialGridView.GridControl = this.invoiceRequirementMaterialsGrid;
            this.invoiceRequirementMaterialGridView.Name = "invoiceRequirementMaterialGridView";
            this.invoiceRequirementMaterialGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.invoiceRequirementMaterialGridView.OptionsView.ShowAutoFilterRow = true;
            this.invoiceRequirementMaterialGridView.OptionsView.ShowFooter = true;
            this.invoiceRequirementMaterialGridView.OptionsView.ShowGroupPanel = false;
            // 
            // nomenclatureCol
            // 
            this.nomenclatureCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.nomenclatureCol.Caption = "Номенклатурний номер";
            this.nomenclatureCol.FieldName = "Nomenclature";
            this.nomenclatureCol.Name = "nomenclatureCol";
            this.nomenclatureCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureCol.Visible = true;
            this.nomenclatureCol.VisibleIndex = 1;
            this.nomenclatureCol.Width = 121;
            // 
            // balanceAccountNumCol
            // 
            this.balanceAccountNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.balanceAccountNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.balanceAccountNumCol.Caption = "Балансовий рахунок";
            this.balanceAccountNumCol.FieldName = "BalanceAccountNum";
            this.balanceAccountNumCol.Name = "balanceAccountNumCol";
            this.balanceAccountNumCol.OptionsColumn.AllowEdit = false;
            this.balanceAccountNumCol.OptionsColumn.AllowFocus = false;
            this.balanceAccountNumCol.Visible = true;
            this.balanceAccountNumCol.VisibleIndex = 2;
            this.balanceAccountNumCol.Width = 123;
            // 
            // receiptNumCol
            // 
            this.receiptNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.receiptNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.receiptNumCol.Caption = "№ надходження";
            this.receiptNumCol.FieldName = "ReceiptNum";
            this.receiptNumCol.Name = "receiptNumCol";
            this.receiptNumCol.OptionsColumn.AllowEdit = false;
            this.receiptNumCol.OptionsColumn.AllowFocus = false;
            this.receiptNumCol.Visible = true;
            this.receiptNumCol.VisibleIndex = 3;
            this.receiptNumCol.Width = 107;
            // 
            // nomenclatureNameCol
            // 
            this.nomenclatureNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureNameCol.Caption = "Найменування";
            this.nomenclatureNameCol.FieldName = "NomenclatureName";
            this.nomenclatureNameCol.Name = "nomenclatureNameCol";
            this.nomenclatureNameCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureNameCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureNameCol.Visible = true;
            this.nomenclatureNameCol.VisibleIndex = 4;
            this.nomenclatureNameCol.Width = 138;
            // 
            // requiredQuantityCol
            // 
            this.requiredQuantityCol.AppearanceHeader.Options.UseTextOptions = true;
            this.requiredQuantityCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.requiredQuantityCol.Caption = "Затребувано";
            this.requiredQuantityCol.FieldName = "RequiredQuantity";
            this.requiredQuantityCol.Name = "requiredQuantityCol";
            this.requiredQuantityCol.OptionsColumn.AllowEdit = false;
            this.requiredQuantityCol.OptionsColumn.AllowFocus = false;
            this.requiredQuantityCol.Visible = true;
            this.requiredQuantityCol.VisibleIndex = 5;
            this.requiredQuantityCol.Width = 138;
            // 
            // unitLocalNameCol
            // 
            this.unitLocalNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.unitLocalNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unitLocalNameCol.Caption = "Од. вим. ";
            this.unitLocalNameCol.FieldName = "UnitLocalName";
            this.unitLocalNameCol.Name = "unitLocalNameCol";
            this.unitLocalNameCol.OptionsColumn.AllowEdit = false;
            this.unitLocalNameCol.OptionsColumn.AllowFocus = false;
            this.unitLocalNameCol.Visible = true;
            this.unitLocalNameCol.VisibleIndex = 6;
            this.unitLocalNameCol.Width = 138;
            // 
            // unitPriceCol
            // 
            this.unitPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.unitPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unitPriceCol.Caption = "Ціна";
            this.unitPriceCol.FieldName = "UnitPrice";
            this.unitPriceCol.Name = "unitPriceCol";
            this.unitPriceCol.OptionsColumn.AllowEdit = false;
            this.unitPriceCol.OptionsColumn.AllowFocus = false;
            this.unitPriceCol.Width = 138;
            // 
            // totalPriceCol
            // 
            this.totalPriceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.totalPriceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.totalPriceCol.Caption = "Сума";
            this.totalPriceCol.FieldName = "TotalPrice";
            this.totalPriceCol.Name = "totalPriceCol";
            this.totalPriceCol.OptionsColumn.AllowEdit = false;
            this.totalPriceCol.OptionsColumn.AllowFocus = false;
            this.totalPriceCol.Width = 106;
            // 
            // selectionCol
            // 
            this.selectionCol.AppearanceHeader.Options.UseTextOptions = true;
            this.selectionCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.selectionCol.ColumnEdit = this.selectionRepository;
            this.selectionCol.FieldName = "Selection";
            this.selectionCol.Image = ((System.Drawing.Image)(resources.GetObject("selectionCol.Image")));
            this.selectionCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.selectionCol.Name = "selectionCol";
            this.selectionCol.OptionsColumn.ShowCaption = false;
            this.selectionCol.Visible = true;
            this.selectionCol.VisibleIndex = 0;
            this.selectionCol.Width = 60;
            // 
            // selectionRepository
            // 
            this.selectionRepository.AutoHeight = false;
            this.selectionRepository.Name = "selectionRepository";
            // 
            // costumerOrderCol
            // 
            this.costumerOrderCol.Caption = "Заказ (надходження)";
            this.costumerOrderCol.FieldName = "CustomerOrder";
            this.costumerOrderCol.Name = "costumerOrderCol";
            this.costumerOrderCol.OptionsColumn.AllowEdit = false;
            this.costumerOrderCol.OptionsColumn.AllowFocus = false;
            this.costumerOrderCol.Visible = true;
            this.costumerOrderCol.VisibleIndex = 7;
            this.costumerOrderCol.Width = 164;
            // 
            // customerOrderExpCol
            // 
            this.customerOrderExpCol.Caption = "Заказ (списання)";
            this.customerOrderExpCol.ColumnEdit = this.customerOrderRepository;
            this.customerOrderExpCol.FieldName = "CustomerOrderExp";
            this.customerOrderExpCol.Name = "customerOrderExpCol";
            this.customerOrderExpCol.Visible = true;
            this.customerOrderExpCol.VisibleIndex = 8;
            this.customerOrderExpCol.Width = 135;
            // 
            // customerOrderRepository
            // 
            this.customerOrderRepository.AutoHeight = false;
            this.customerOrderRepository.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("customerOrderRepository.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.customerOrderRepository.Name = "customerOrderRepository";
            this.customerOrderRepository.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.customerOrderRepository.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.customerOrderRepository_ButtonClick);
            // 
            // standaloneBarDockControl2
            // 
            this.standaloneBarDockControl2.CausesValidation = false;
            this.standaloneBarDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl2.Location = new System.Drawing.Point(2, 20);
            this.standaloneBarDockControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.standaloneBarDockControl2.Name = "standaloneBarDockControl2";
            this.standaloneBarDockControl2.Size = new System.Drawing.Size(1386, 25);
            this.standaloneBarDockControl2.Text = "standaloneBarDockControl2";
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(14, 509);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 39;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1246, 505);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 41;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(1327, 505);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 42;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.DockControls.Add(this.standaloneBarDockControl2);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addBtn,
            this.deleteBtn,
            this.editOrderBtn});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.addBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteBtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.editOrderBtn)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.StandaloneBarDockControl = this.standaloneBarDockControl2;
            this.bar2.Text = "Main menu";
            // 
            // addBtn
            // 
            this.addBtn.Caption = "Додати";
            this.addBtn.Glyph = global::ERP_NEW.GUI.Accounting.Resources.Add_16x16;
            this.addBtn.Id = 0;
            this.addBtn.Name = "addBtn";
            this.addBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.addBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBtn_ItemClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Видалити";
            this.deleteBtn.Glyph = global::ERP_NEW.GUI.Accounting.Resources.Cancel_16x16;
            this.deleteBtn.Id = 1;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.deleteBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBtn_ItemClick);
            // 
            // editOrderBtn
            // 
            this.editOrderBtn.Caption = "Змінити номер заказу на відмічених";
            this.editOrderBtn.Glyph = global::ERP_NEW.GUI.Accounting.Resources.checkbox2_16x16;
            this.editOrderBtn.Id = 2;
            this.editOrderBtn.LargeGlyph = global::ERP_NEW.GUI.Properties.Resources.checkbox2_16x161;
            this.editOrderBtn.Name = "editOrderBtn";
            this.editOrderBtn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.editOrderBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editOrderBtn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1414, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 540);
            this.barDockControlBottom.Size = new System.Drawing.Size(1414, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 540);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1414, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 540);
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // productionInvoicesValidationProvider
            // 
            this.productionInvoicesValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.productionInvoicesValidationProvider_ValidationFailed);
            this.productionInvoicesValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.productionInvoicesValidationProvider_ValidationSucceeded);
            // 
            // ProductionInvoicesEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 540);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductionInvoicesEditFm";
            this.ShowIcon = false;
            this.Text = "Редагування";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responsiblePersonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceRequirementMaterialsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceRequirementMaterialGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionInvoicesValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GridLookUpEdit responsiblePersonEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit numberEdit;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl invoiceRequirementMaterialsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView invoiceRequirementMaterialGridView;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclatureCol;
        private DevExpress.XtraGrid.Columns.GridColumn balanceAccountNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn receiptNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclatureNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn requiredQuantityCol;
        private DevExpress.XtraGrid.Columns.GridColumn unitLocalNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn unitPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn totalPriceCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit customerOrderRepository;
        private DevExpress.XtraGrid.Columns.GridColumn selectionCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit selectionRepository;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl2;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem addBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBtn;
        private DevExpress.XtraBars.BarButtonItem editOrderBtn;
        private DevExpress.XtraGrid.Columns.GridColumn costumerOrderCol;
        private DevExpress.XtraGrid.Columns.GridColumn customerOrderExpCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider productionInvoicesValidationProvider;
    }
}