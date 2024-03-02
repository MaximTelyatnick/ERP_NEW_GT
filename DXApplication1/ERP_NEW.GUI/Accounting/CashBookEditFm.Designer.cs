namespace ERP_NEW.GUI.Accounting
{
    partial class CashBookEditFm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashBookEditFm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cashBookPageDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cashBookPageNumberTBox = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cashBookRecordsGrid = new DevExpress.XtraGrid.GridControl();
            this.cashBookRecordsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cashBookContractorNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.documentNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.debitCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.creditCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.balanceAccountNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.basisTypeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameAdditionalTypeCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.selectionCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.barMenu = new DevExpress.XtraBars.BarManager();
            this.specificationBar = new DevExpress.XtraBars.Bar();
            this.addRecordBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editRecordsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteRecordBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.editRecordBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addAssBrn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteAssBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editAssBtn = new DevExpress.XtraBars.BarButtonItem();
            this.cashBookValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookPageDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookPageDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookPageNumberTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookRecordsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookRecordsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cashBookPageDateEdit);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cashBookPageNumberTBox);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1085, 88);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Інформація про сторінку";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(497, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 13);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Каса за дату:";
            // 
            // cashBookPageDateEdit
            // 
            this.cashBookPageDateEdit.EditValue = null;
            this.cashBookPageDateEdit.Location = new System.Drawing.Point(594, 43);
            this.cashBookPageDateEdit.Name = "cashBookPageDateEdit";
            this.cashBookPageDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cashBookPageDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cashBookPageDateEdit.Size = new System.Drawing.Size(486, 20);
            this.cashBookPageDateEdit.TabIndex = 19;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Не вказано номер сторінки";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.cashBookValidationProvider.SetValidationRule(this.cashBookPageDateEdit, conditionValidationRule1);
            this.cashBookPageDateEdit.EditValueChanged += new System.EventHandler(this.cashBookPageDateEdit_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(19, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Номер сторінки";
            // 
            // cashBookPageNumberTBox
            // 
            this.cashBookPageNumberTBox.Location = new System.Drawing.Point(131, 43);
            this.cashBookPageNumberTBox.Name = "cashBookPageNumberTBox";
            this.cashBookPageNumberTBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cashBookPageNumberTBox.Properties.Appearance.Options.UseFont = true;
            this.cashBookPageNumberTBox.Size = new System.Drawing.Size(293, 20);
            this.cashBookPageNumberTBox.TabIndex = 18;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Не вказано дату";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.cashBookValidationProvider.SetValidationRule(this.cashBookPageNumberTBox, conditionValidationRule2);
            this.cashBookPageNumberTBox.EditValueChanged += new System.EventHandler(this.cashBookPageNumberTBox_EditValueChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.cashBookRecordsGrid);
            this.groupControl2.Controls.Add(this.standaloneBarDockControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 106);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1087, 448);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Записи на сторінці";
            // 
            // cashBookRecordsGrid
            // 
            this.cashBookRecordsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashBookRecordsGrid.Location = new System.Drawing.Point(2, 48);
            this.cashBookRecordsGrid.MainView = this.cashBookRecordsGridView;
            this.cashBookRecordsGrid.Name = "cashBookRecordsGrid";
            this.cashBookRecordsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit});
            this.cashBookRecordsGrid.Size = new System.Drawing.Size(1083, 398);
            this.cashBookRecordsGrid.TabIndex = 11;
            this.cashBookRecordsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cashBookRecordsGridView});
            // 
            // cashBookRecordsGridView
            // 
            this.cashBookRecordsGridView.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cashBookRecordsGridView.Appearance.FooterPanel.Options.UseFont = true;
            this.cashBookRecordsGridView.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.cashBookRecordsGridView.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cashBookRecordsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cashBookContractorNameCol,
            this.documentNumberCol,
            this.debitCol,
            this.creditCol,
            this.balanceAccountNumberCol,
            this.basisTypeCol,
            this.nameAdditionalTypeCol,
            this.selectionCol});
            this.cashBookRecordsGridView.GridControl = this.cashBookRecordsGrid;
            this.cashBookRecordsGridView.Name = "cashBookRecordsGridView";
            this.cashBookRecordsGridView.OptionsView.ShowAutoFilterRow = true;
            this.cashBookRecordsGridView.OptionsView.ShowFooter = true;
            this.cashBookRecordsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // cashBookContractorNameCol
            // 
            this.cashBookContractorNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cashBookContractorNameCol.AppearanceHeader.Options.UseFont = true;
            this.cashBookContractorNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.cashBookContractorNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cashBookContractorNameCol.Caption = "Контрагент";
            this.cashBookContractorNameCol.FieldName = "CashBookContractorName";
            this.cashBookContractorNameCol.Name = "cashBookContractorNameCol";
            this.cashBookContractorNameCol.OptionsColumn.AllowEdit = false;
            this.cashBookContractorNameCol.OptionsColumn.AllowFocus = false;
            this.cashBookContractorNameCol.Visible = true;
            this.cashBookContractorNameCol.VisibleIndex = 0;
            this.cashBookContractorNameCol.Width = 161;
            // 
            // documentNumberCol
            // 
            this.documentNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.documentNumberCol.AppearanceHeader.Options.UseFont = true;
            this.documentNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.documentNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.documentNumberCol.Caption = "Номер документа";
            this.documentNumberCol.FieldName = "DocumentNumber";
            this.documentNumberCol.Name = "documentNumberCol";
            this.documentNumberCol.OptionsColumn.AllowEdit = false;
            this.documentNumberCol.OptionsColumn.AllowFocus = false;
            this.documentNumberCol.Visible = true;
            this.documentNumberCol.VisibleIndex = 1;
            this.documentNumberCol.Width = 117;
            // 
            // debitCol
            // 
            this.debitCol.AppearanceCell.Options.UseTextOptions = true;
            this.debitCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.debitCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.debitCol.AppearanceHeader.Options.UseFont = true;
            this.debitCol.AppearanceHeader.Options.UseTextOptions = true;
            this.debitCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.debitCol.Caption = "Надходження. (грн)";
            this.debitCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.debitCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.debitCol.FieldName = "Debit";
            this.debitCol.Name = "debitCol";
            this.debitCol.OptionsColumn.AllowEdit = false;
            this.debitCol.OptionsColumn.AllowFocus = false;
            this.debitCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit", "Всього={0:### ### ##0.00}")});
            this.debitCol.Visible = true;
            this.debitCol.VisibleIndex = 2;
            this.debitCol.Width = 151;
            // 
            // creditCol
            // 
            this.creditCol.AppearanceCell.Options.UseTextOptions = true;
            this.creditCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.creditCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.creditCol.AppearanceHeader.Options.UseFont = true;
            this.creditCol.AppearanceHeader.Options.UseTextOptions = true;
            this.creditCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.creditCol.Caption = "Видаток. (грн)";
            this.creditCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.creditCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.creditCol.FieldName = "Credit";
            this.creditCol.Name = "creditCol";
            this.creditCol.OptionsColumn.AllowEdit = false;
            this.creditCol.OptionsColumn.AllowFocus = false;
            this.creditCol.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit", "Всього={0:### ### ##0.00}")});
            this.creditCol.Visible = true;
            this.creditCol.VisibleIndex = 3;
            this.creditCol.Width = 172;
            // 
            // balanceAccountNumberCol
            // 
            this.balanceAccountNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.balanceAccountNumberCol.AppearanceHeader.Options.UseFont = true;
            this.balanceAccountNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.balanceAccountNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.balanceAccountNumberCol.Caption = "Номер рахунку";
            this.balanceAccountNumberCol.FieldName = "BalanceAccountNumber";
            this.balanceAccountNumberCol.Name = "balanceAccountNumberCol";
            this.balanceAccountNumberCol.OptionsColumn.AllowEdit = false;
            this.balanceAccountNumberCol.OptionsColumn.AllowFocus = false;
            this.balanceAccountNumberCol.Visible = true;
            this.balanceAccountNumberCol.VisibleIndex = 4;
            this.balanceAccountNumberCol.Width = 129;
            // 
            // basisTypeCol
            // 
            this.basisTypeCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.basisTypeCol.AppearanceHeader.Options.UseFont = true;
            this.basisTypeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.basisTypeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.basisTypeCol.Caption = "Підстава";
            this.basisTypeCol.FieldName = "BasisType";
            this.basisTypeCol.Name = "basisTypeCol";
            this.basisTypeCol.OptionsColumn.AllowEdit = false;
            this.basisTypeCol.OptionsColumn.AllowFocus = false;
            this.basisTypeCol.Visible = true;
            this.basisTypeCol.VisibleIndex = 5;
            this.basisTypeCol.Width = 240;
            // 
            // nameAdditionalTypeCol
            // 
            this.nameAdditionalTypeCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAdditionalTypeCol.AppearanceHeader.Options.UseFont = true;
            this.nameAdditionalTypeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nameAdditionalTypeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameAdditionalTypeCol.Caption = "Додаток";
            this.nameAdditionalTypeCol.FieldName = "NameAdditionalType";
            this.nameAdditionalTypeCol.Name = "nameAdditionalTypeCol";
            this.nameAdditionalTypeCol.OptionsColumn.AllowEdit = false;
            this.nameAdditionalTypeCol.OptionsColumn.AllowFocus = false;
            this.nameAdditionalTypeCol.Visible = true;
            this.nameAdditionalTypeCol.VisibleIndex = 6;
            // 
            // selectionCol
            // 
            this.selectionCol.AppearanceHeader.Image = ((System.Drawing.Image)(resources.GetObject("selectionCol.AppearanceHeader.Image")));
            this.selectionCol.AppearanceHeader.Options.UseImage = true;
            this.selectionCol.ColumnEdit = this.repositoryItemCheckEdit;
            this.selectionCol.FieldName = "Selection";
            this.selectionCol.Image = ((System.Drawing.Image)(resources.GetObject("selectionCol.Image")));
            this.selectionCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.selectionCol.Name = "selectionCol";
            this.selectionCol.Visible = true;
            this.selectionCol.VisibleIndex = 7;
            this.selectionCol.Width = 95;
            // 
            // repositoryItemCheckEdit
            // 
            this.repositoryItemCheckEdit.AutoHeight = false;
            this.repositoryItemCheckEdit.Name = "repositoryItemCheckEdit";
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(2, 22);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(1083, 26);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(12, 571);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 28;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(1024, 563);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 30;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(943, 563);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 29;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // barMenu
            // 
            this.barMenu.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.specificationBar});
            this.barMenu.DockControls.Add(this.barDockControlTop);
            this.barMenu.DockControls.Add(this.barDockControlBottom);
            this.barMenu.DockControls.Add(this.barDockControlLeft);
            this.barMenu.DockControls.Add(this.barDockControlRight);
            this.barMenu.DockControls.Add(this.standaloneBarDockControl1);
            this.barMenu.Form = this;
            this.barMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addRecordBtn,
            this.editRecordBtn,
            this.deleteRecordBtn,
            this.addAssBrn,
            this.deleteAssBtn,
            this.editAssBtn,
            this.editRecordsBtn});
            this.barMenu.MaxItemId = 10;
            // 
            // specificationBar
            // 
            this.specificationBar.BarName = "Tools";
            this.specificationBar.DockCol = 0;
            this.specificationBar.DockRow = 0;
            this.specificationBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.specificationBar.FloatLocation = new System.Drawing.Point(224, 468);
            this.specificationBar.FloatSize = new System.Drawing.Size(283, 29);
            this.specificationBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.addRecordBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.editRecordsBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.deleteRecordBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.specificationBar.OptionsBar.AllowQuickCustomization = false;
            this.specificationBar.OptionsBar.DrawBorder = false;
            this.specificationBar.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.specificationBar.Text = "Tools";
            // 
            // addRecordBtn
            // 
            this.addRecordBtn.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.addRecordBtn.Caption = "Додати";
            this.addRecordBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addRecordBtn.Glyph")));
            this.addRecordBtn.Id = 0;
            this.addRecordBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addRecordBtn.LargeGlyph")));
            this.addRecordBtn.Name = "addRecordBtn";
            this.addRecordBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addRecordBtn_ItemClick);
            // 
            // editRecordsBtn
            // 
            this.editRecordsBtn.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.editRecordsBtn.Caption = "Редагувати";
            this.editRecordsBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editRecordsBtn.Glyph")));
            this.editRecordsBtn.Id = 9;
            this.editRecordsBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editRecordsBtn.LargeGlyph")));
            this.editRecordsBtn.Name = "editRecordsBtn";
            this.editRecordsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editRecordsBtn_ItemClick);
            // 
            // deleteRecordBtn
            // 
            this.deleteRecordBtn.Caption = "Видалити";
            this.deleteRecordBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteRecordBtn.Glyph")));
            this.deleteRecordBtn.Id = 2;
            this.deleteRecordBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteRecordBtn.LargeGlyph")));
            this.deleteRecordBtn.Name = "deleteRecordBtn";
            this.deleteRecordBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteRecordBtn_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1111, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 598);
            this.barDockControlBottom.Size = new System.Drawing.Size(1111, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 598);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1111, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 598);
            // 
            // editRecordBtn
            // 
            this.editRecordBtn.Caption = "Редагувати";
            this.editRecordBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editRecordBtn.Glyph")));
            this.editRecordBtn.Id = 1;
            this.editRecordBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editRecordBtn.LargeGlyph")));
            this.editRecordBtn.Name = "editRecordBtn";
            // 
            // addAssBrn
            // 
            this.addAssBrn.Id = 6;
            this.addAssBrn.Name = "addAssBrn";
            // 
            // deleteAssBtn
            // 
            this.deleteAssBtn.Id = 7;
            this.deleteAssBtn.Name = "deleteAssBtn";
            // 
            // editAssBtn
            // 
            this.editAssBtn.Id = 8;
            this.editAssBtn.Name = "editAssBtn";
            // 
            // cashBookValidationProvider
            // 
            this.cashBookValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.cashBookValidationProvider_ValidationFailed);
            this.cashBookValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.cashBookValidationProvider_ValidationSucceeded);
            // 
            // CashBookEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1111, 598);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashBookEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Додати документ";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookPageDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookPageDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookPageNumberTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cashBookRecordsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookRecordsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarManager barMenu;
        private DevExpress.XtraBars.Bar specificationBar;
        private DevExpress.XtraBars.BarButtonItem addRecordBtn;
        private DevExpress.XtraBars.BarButtonItem editRecordBtn;
        private DevExpress.XtraBars.BarButtonItem deleteRecordBtn;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem addAssBrn;
        private DevExpress.XtraBars.BarButtonItem deleteAssBtn;
        private DevExpress.XtraBars.BarButtonItem editAssBtn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit cashBookPageDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit cashBookPageNumberTBox;
        private DevExpress.XtraGrid.GridControl cashBookRecordsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView cashBookRecordsGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn cashBookContractorNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn documentNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn debitCol;
        private DevExpress.XtraGrid.Columns.GridColumn creditCol;
        private DevExpress.XtraGrid.Columns.GridColumn balanceAccountNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn basisTypeCol;
        private DevExpress.XtraGrid.Columns.GridColumn selectionCol;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider cashBookValidationProvider;
        private DevExpress.XtraGrid.Columns.GridColumn nameAdditionalTypeCol;
        private DevExpress.XtraBars.BarButtonItem editRecordsBtn;

    }
}