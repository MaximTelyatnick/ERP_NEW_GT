namespace ERP_NEW.GUI.Accounting
{
    partial class AccountingTransferEditFm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.purposeEdit = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.accountingOperationEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.contractorsEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contractorCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.purposeAccountEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.accountEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.paymentDocumentTBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.paymentDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.paymentPriceTBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.accountTransferValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purposeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingOperationEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeAccountEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDocumentTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPriceTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTransferValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.purposeEdit);
            this.groupControl2.Location = new System.Drawing.Point(4, 175);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(511, 80);
            this.groupControl2.TabIndex = 134;
            this.groupControl2.Text = "Призначення платежу";
            // 
            // purposeEdit
            // 
            this.purposeEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purposeEdit.Location = new System.Drawing.Point(2, 20);
            this.purposeEdit.Name = "purposeEdit";
            this.purposeEdit.Size = new System.Drawing.Size(507, 58);
            this.purposeEdit.TabIndex = 17;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(373, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 135;
            this.labelControl1.Text = "Операція";
            // 
            // accountingOperationEdit
            // 
            this.accountingOperationEdit.Location = new System.Drawing.Point(373, 30);
            this.accountingOperationEdit.Name = "accountingOperationEdit";
            this.accountingOperationEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accountingOperationEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Найменування")});
            this.accountingOperationEdit.Properties.ShowHeader = false;
            this.accountingOperationEdit.Properties.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.accountingOperationEdit_Properties_QueryPopUp);
            this.accountingOperationEdit.Size = new System.Drawing.Size(142, 20);
            this.accountingOperationEdit.TabIndex = 121;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Не вказано тип операції";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.accountTransferValidationProvider.SetValidationRule(this.accountingOperationEdit, conditionValidationRule1);
            this.accountingOperationEdit.EditValueChanged += new System.EventHandler(this.accountingOperationEdit_EditValueChanged);
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon;
            this.groupControl3.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl3.Controls.Add(this.contractorsEdit);
            this.groupControl3.Controls.Add(this.contractorCheckEdit);
            this.groupControl3.Location = new System.Drawing.Point(9, 117);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(506, 52);
            this.groupControl3.TabIndex = 131;
            this.groupControl3.Text = "Контрагент";
            // 
            // contractorsEdit
            // 
            this.contractorsEdit.Location = new System.Drawing.Point(29, 22);
            this.contractorsEdit.Name = "contractorsEdit";
            this.contractorsEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.contractorsEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinDown),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Додати", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Редагувати", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "Поновити", null, null, true)});
            this.contractorsEdit.Properties.ImmediatePopup = true;
            this.contractorsEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.contractorsEdit.Properties.PopupFormSize = new System.Drawing.Size(667, 0);
            this.contractorsEdit.Properties.PopupSizeable = false;
            this.contractorsEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.contractorsEdit.Properties.View = this.gridView3;
            this.contractorsEdit.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.contractorsEdit_Properties_ButtonClick);
            this.contractorsEdit.Size = new System.Drawing.Size(465, 20);
            this.contractorsEdit.TabIndex = 14;
            this.contractorsEdit.ToolTipTitle = "Назва організації";
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.TextAndVisual;
            this.gridView3.OptionsFind.AlwaysVisible = true;
            this.gridView3.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView3.OptionsFind.FindNullPrompt = "Введіть текст для пошуку...";
            this.gridView3.OptionsFind.SearchInPreview = true;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Назва";
            this.gridColumn5.FieldName = "Name";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 125;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Код";
            this.gridColumn6.FieldName = "Srn";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 50;
            // 
            // contractorCheckEdit
            // 
            this.contractorCheckEdit.Location = new System.Drawing.Point(5, 23);
            this.contractorCheckEdit.Name = "contractorCheckEdit";
            this.contractorCheckEdit.Properties.Caption = "";
            this.contractorCheckEdit.Size = new System.Drawing.Size(21, 19);
            this.contractorCheckEdit.TabIndex = 13;
            // 
            // purposeAccountEdit
            // 
            this.purposeAccountEdit.Location = new System.Drawing.Point(185, 72);
            this.purposeAccountEdit.Name = "purposeAccountEdit";
            this.purposeAccountEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.purposeAccountEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.purposeAccountEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Num", "Name3")});
            this.purposeAccountEdit.Properties.ImmediatePopup = true;
            this.purposeAccountEdit.Properties.PopupSizeable = false;
            this.purposeAccountEdit.Properties.PopupWidth = 553;
            this.purposeAccountEdit.Properties.ShowHeader = false;
            this.purposeAccountEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.purposeAccountEdit.Properties.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.purposeAccountEdit_Properties_QueryPopUp);
            this.purposeAccountEdit.Size = new System.Drawing.Size(182, 20);
            this.purposeAccountEdit.TabIndex = 114;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Не вказано рахунок призначення";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.accountTransferValidationProvider.SetValidationRule(this.purposeAccountEdit, conditionValidationRule2);
            this.purposeAccountEdit.EditValueChanged += new System.EventHandler(this.purposeAccountEdit_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(185, 55);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(110, 13);
            this.labelControl4.TabIndex = 128;
            this.labelControl4.Text = "Рахунок призначення";
            // 
            // accountEdit
            // 
            this.accountEdit.Location = new System.Drawing.Point(12, 72);
            this.accountEdit.Name = "accountEdit";
            this.accountEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.accountEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accountEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Num", "Name3")});
            this.accountEdit.Properties.ImmediatePopup = true;
            this.accountEdit.Properties.PopupSizeable = false;
            this.accountEdit.Properties.PopupWidth = 553;
            this.accountEdit.Properties.ShowHeader = false;
            this.accountEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.accountEdit.Properties.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.bankAccountEdit_Properties_QueryPopUp);
            this.accountEdit.Size = new System.Drawing.Size(167, 20);
            this.accountEdit.TabIndex = 113;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "не вказано рахунок";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule3.Value1 = ((short)(0));
            this.accountTransferValidationProvider.SetValidationRule(this.accountEdit, conditionValidationRule3);
            this.accountEdit.EditValueChanged += new System.EventHandler(this.accountEdit_EditValueChanged);
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(12, 55);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(45, 13);
            this.labelControl13.TabIndex = 127;
            this.labelControl13.Text = "Рахунок ";
            // 
            // paymentDocumentTBox
            // 
            this.paymentDocumentTBox.Location = new System.Drawing.Point(185, 30);
            this.paymentDocumentTBox.Name = "paymentDocumentTBox";
            this.paymentDocumentTBox.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.paymentDocumentTBox.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.paymentDocumentTBox.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White;
            this.paymentDocumentTBox.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.paymentDocumentTBox.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.paymentDocumentTBox.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.paymentDocumentTBox.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.paymentDocumentTBox.Size = new System.Drawing.Size(182, 20);
            this.paymentDocumentTBox.TabIndex = 112;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Не вказано номер платіжного документу";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.accountTransferValidationProvider.SetValidationRule(this.paymentDocumentTBox, conditionValidationRule4);
            this.paymentDocumentTBox.EditValueChanged += new System.EventHandler(this.paymentDocumentTBox_EditValueChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(185, 12);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(149, 13);
            this.labelControl11.TabIndex = 125;
            this.labelControl11.Text = "Номер платіжного документа";
            // 
            // paymentDateEdit
            // 
            this.paymentDateEdit.EditValue = null;
            this.paymentDateEdit.Location = new System.Drawing.Point(11, 30);
            this.paymentDateEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentDateEdit.Name = "paymentDateEdit";
            this.paymentDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.paymentDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.paymentDateEdit.Size = new System.Drawing.Size(168, 20);
            this.paymentDateEdit.TabIndex = 111;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Не вказано дату";
            conditionValidationRule5.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.accountTransferValidationProvider.SetValidationRule(this.paymentDateEdit, conditionValidationRule5);
            this.paymentDateEdit.EditValueChanged += new System.EventHandler(this.paymentDateEdit_EditValueChanged);
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(11, 12);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(26, 13);
            this.labelControl16.TabIndex = 122;
            this.labelControl16.Text = "Дата";
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(4, 269);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 137;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(440, 269);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 21);
            this.cancelBtn.TabIndex = 139;
            this.cancelBtn.Text = "Відміна";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(359, 269);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 21);
            this.saveBtn.TabIndex = 138;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // paymentPriceTBox
            // 
            this.paymentPriceTBox.EditValue = "";
            this.paymentPriceTBox.Location = new System.Drawing.Point(373, 72);
            this.paymentPriceTBox.Name = "paymentPriceTBox";
            this.paymentPriceTBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.paymentPriceTBox.Properties.Appearance.Options.UseFont = true;
            this.paymentPriceTBox.Properties.Appearance.Options.UseTextOptions = true;
            this.paymentPriceTBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.paymentPriceTBox.Properties.Mask.EditMask = "n2";
            this.paymentPriceTBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.paymentPriceTBox.Size = new System.Drawing.Size(140, 20);
            this.paymentPriceTBox.TabIndex = 140;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule6.ErrorText = "Не вказано суму";
            conditionValidationRule6.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule6.Value1 = ((short)(0));
            this.accountTransferValidationProvider.SetValidationRule(this.paymentPriceTBox, conditionValidationRule6);
            this.paymentPriceTBox.EditValueChanged += new System.EventHandler(this.paymentPriceTBox_EditValueChanged);
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(373, 53);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(68, 13);
            this.labelControl15.TabIndex = 141;
            this.labelControl15.Text = "Сума у гривні";
            // 
            // accountTransferValidationProvider
            // 
            this.accountTransferValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.accountTransferValidationProvider_ValidationFailed);
            this.accountTransferValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.accountTransferValidationProvider_ValidationSucceeded);
            // 
            // AccountingTransferEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 300);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.paymentPriceTBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.accountingOperationEdit);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.purposeAccountEdit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.accountEdit);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.paymentDocumentTBox);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.paymentDateEdit);
            this.Controls.Add(this.labelControl16);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountingTransferEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Операції міх рахунками";
            this.Load += new System.EventHandler(this.AccountingTransferEditFm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purposeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingOperationEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contractorsEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeAccountEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDocumentTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPriceTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTransferValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.MemoEdit purposeEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit accountingOperationEdit;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GridLookUpEdit contractorsEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.CheckEdit contractorCheckEdit;
        private DevExpress.XtraEditors.LookUpEdit purposeAccountEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit accountEdit;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit paymentDocumentTBox;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.DateEdit paymentDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraEditors.TextEdit paymentPriceTBox;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider accountTransferValidationProvider;
    }
}