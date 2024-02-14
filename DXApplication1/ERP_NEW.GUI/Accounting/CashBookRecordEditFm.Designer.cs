namespace ERP_NEW.GUI.Accounting
{
    partial class CashBookRecordEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashBookRecordEditFm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.cashBookContractorEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.cashBookRecordCurrencyTBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.bankAccountEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.cashBookRecordDocumentTBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cashBookBasisEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.cashBookOperationEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.cashBookRecordValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cashBookAdditionalEdit = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookContractorEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookRecordCurrencyTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookRecordDocumentTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookBasisEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookOperationEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookRecordValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookAdditionalEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(438, 290);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 21);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(357, 290);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 21);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(12, 294);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 138;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 137;
            this.labelControl1.Text = "Операція";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon;
            this.groupControl3.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl3.Controls.Add(this.cashBookContractorEdit);
            this.groupControl3.Location = new System.Drawing.Point(28, 104);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(485, 52);
            this.groupControl3.TabIndex = 133;
            this.groupControl3.Text = "Контрагент";
            // 
            // cashBookContractorEdit
            // 
            this.cashBookContractorEdit.Location = new System.Drawing.Point(5, 23);
            this.cashBookContractorEdit.Name = "cashBookContractorEdit";
            this.cashBookContractorEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cashBookContractorEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("cashBookContractorEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Додати", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("cashBookContractorEdit.Properties.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("cashBookContractorEdit.Properties.Buttons2"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("cashBookContractorEdit.Properties.Buttons3"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.cashBookContractorEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CashBookContractorName", "Контактна персона")});
            this.cashBookContractorEdit.Properties.ImmediatePopup = true;
            this.cashBookContractorEdit.Properties.PopupSizeable = false;
            this.cashBookContractorEdit.Properties.PopupWidth = 553;
            this.cashBookContractorEdit.Properties.ShowHeader = false;
            this.cashBookContractorEdit.Size = new System.Drawing.Size(475, 22);
            this.cashBookContractorEdit.TabIndex = 4;
            this.cashBookContractorEdit.ToolTip = "Контактна персона або організація";
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Не вказано контрагента";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.cashBookRecordValidationProvider.SetValidationRule(this.cashBookContractorEdit, conditionValidationRule1);
            this.cashBookContractorEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cashBookContractorEdit_ButtonClick);
            this.cashBookContractorEdit.EditValueChanged += new System.EventHandler(this.cashBookContractorEdit_EditValueChanged);
            // 
            // cashBookRecordCurrencyTBox
            // 
            this.cashBookRecordCurrencyTBox.EditValue = "0,00";
            this.cashBookRecordCurrencyTBox.Location = new System.Drawing.Point(290, 74);
            this.cashBookRecordCurrencyTBox.Name = "cashBookRecordCurrencyTBox";
            this.cashBookRecordCurrencyTBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cashBookRecordCurrencyTBox.Properties.Appearance.Options.UseFont = true;
            this.cashBookRecordCurrencyTBox.Properties.Appearance.Options.UseTextOptions = true;
            this.cashBookRecordCurrencyTBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cashBookRecordCurrencyTBox.Properties.Mask.EditMask = "n2";
            this.cashBookRecordCurrencyTBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.cashBookRecordCurrencyTBox.Size = new System.Drawing.Size(223, 20);
            this.cashBookRecordCurrencyTBox.TabIndex = 3;
            this.cashBookRecordCurrencyTBox.ToolTip = "Сума у гривнях";
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Не вказано суму";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.cashBookRecordValidationProvider.SetValidationRule(this.cashBookRecordCurrencyTBox, conditionValidationRule2);
            this.cashBookRecordCurrencyTBox.EditValueChanged += new System.EventHandler(this.cashBookRecordCurrencyTBox_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(290, 55);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(25, 13);
            this.labelControl6.TabIndex = 131;
            this.labelControl6.Text = "Сума";
            // 
            // bankAccountEdit
            // 
            this.bankAccountEdit.Location = new System.Drawing.Point(290, 31);
            this.bankAccountEdit.Name = "bankAccountEdit";
            this.bankAccountEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.bankAccountEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bankAccountEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Num", "Номер рахвнку")});
            this.bankAccountEdit.Properties.ImmediatePopup = true;
            this.bankAccountEdit.Properties.PopupSizeable = false;
            this.bankAccountEdit.Properties.PopupWidth = 553;
            this.bankAccountEdit.Properties.ShowHeader = false;
            this.bankAccountEdit.Size = new System.Drawing.Size(223, 20);
            this.bankAccountEdit.TabIndex = 1;
            this.bankAccountEdit.ToolTip = "Номер рахунку";
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "Не вказано номер рахунка";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule3.Value1 = ((short)(0));
            this.cashBookRecordValidationProvider.SetValidationRule(this.bankAccountEdit, conditionValidationRule3);
            this.bankAccountEdit.EditValueChanged += new System.EventHandler(this.bankAccountEdit_EditValueChanged);
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(290, 12);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(104, 13);
            this.labelControl13.TabIndex = 129;
            this.labelControl13.Text = "Балансовий рахунок";
            // 
            // cashBookRecordDocumentTBox
            // 
            this.cashBookRecordDocumentTBox.Location = new System.Drawing.Point(28, 31);
            this.cashBookRecordDocumentTBox.Name = "cashBookRecordDocumentTBox";
            this.cashBookRecordDocumentTBox.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.cashBookRecordDocumentTBox.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.cashBookRecordDocumentTBox.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.White;
            this.cashBookRecordDocumentTBox.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.cashBookRecordDocumentTBox.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.cashBookRecordDocumentTBox.Properties.AppearanceReadOnly.Options.UseBorderColor = true;
            this.cashBookRecordDocumentTBox.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.cashBookRecordDocumentTBox.Size = new System.Drawing.Size(239, 20);
            this.cashBookRecordDocumentTBox.TabIndex = 12;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Не вказано номер документа";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.cashBookRecordValidationProvider.SetValidationRule(this.cashBookRecordDocumentTBox, conditionValidationRule4);
            this.cashBookRecordDocumentTBox.EditValueChanged += new System.EventHandler(this.cashBookRecordDocumentTBox_EditValueChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(28, 12);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(89, 13);
            this.labelControl11.TabIndex = 127;
            this.labelControl11.Text = "Номер документа";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.cashBookBasisEdit);
            this.groupControl1.Location = new System.Drawing.Point(28, 162);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(485, 52);
            this.groupControl1.TabIndex = 139;
            this.groupControl1.Text = "Підстава";
            // 
            // cashBookBasisEdit
            // 
            this.cashBookBasisEdit.Location = new System.Drawing.Point(9, 25);
            this.cashBookBasisEdit.Name = "cashBookBasisEdit";
            this.cashBookBasisEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cashBookBasisEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("cashBookBasisEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "Додати", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("cashBookBasisEdit.Properties.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("cashBookBasisEdit.Properties.Buttons2"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("cashBookBasisEdit.Properties.Buttons3"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "", null, null, true)});
            this.cashBookBasisEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BasisType", "Підстава")});
            this.cashBookBasisEdit.Properties.ImmediatePopup = true;
            this.cashBookBasisEdit.Properties.PopupSizeable = false;
            this.cashBookBasisEdit.Properties.PopupWidth = 553;
            this.cashBookBasisEdit.Properties.ShowHeader = false;
            this.cashBookBasisEdit.Size = new System.Drawing.Size(471, 22);
            this.cashBookBasisEdit.TabIndex = 5;
            this.cashBookBasisEdit.ToolTip = "Підстава для видачі коштів";
            this.cashBookBasisEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cashBookBasisEdit_ButtonClick);
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // cashBookOperationEdit
            // 
            this.cashBookOperationEdit.Location = new System.Drawing.Point(28, 74);
            this.cashBookOperationEdit.Name = "cashBookOperationEdit";
            this.cashBookOperationEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cashBookOperationEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cashBookOperationEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyTypeName", "Тип операції")});
            this.cashBookOperationEdit.Properties.ImmediatePopup = true;
            this.cashBookOperationEdit.Properties.PopupSizeable = false;
            this.cashBookOperationEdit.Properties.PopupWidth = 553;
            this.cashBookOperationEdit.Properties.ShowHeader = false;
            this.cashBookOperationEdit.Size = new System.Drawing.Size(239, 20);
            this.cashBookOperationEdit.TabIndex = 2;
            this.cashBookOperationEdit.ToolTip = "Тип операції";
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Не вказано вид операції";
            conditionValidationRule5.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.cashBookRecordValidationProvider.SetValidationRule(this.cashBookOperationEdit, conditionValidationRule5);
            this.cashBookOperationEdit.EditValueChanged += new System.EventHandler(this.cashBookOperationEdit_EditValueChanged);
            // 
            // cashBookRecordValidationProvider
            // 
            this.cashBookRecordValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.cashBookRecordValidationProvider_ValidationFailed);
            this.cashBookRecordValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.cashBookRecordValidationProvider_ValidationSucceeded);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.cashBookAdditionalEdit);
            this.groupControl2.Location = new System.Drawing.Point(28, 220);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(485, 52);
            this.groupControl2.TabIndex = 140;
            this.groupControl2.Text = "Додаток";
            // 
            // cashBookAdditionalEdit
            // 
            this.cashBookAdditionalEdit.Location = new System.Drawing.Point(9, 25);
            this.cashBookAdditionalEdit.Name = "cashBookAdditionalEdit";
            this.cashBookAdditionalEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cashBookAdditionalEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("cashBookAdditionalEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, "Додати", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("cashBookAdditionalEdit.Properties.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject10, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("cashBookAdditionalEdit.Properties.Buttons2"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject11, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("cashBookAdditionalEdit.Properties.Buttons3"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject12, "", null, null, true)});
            this.cashBookAdditionalEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameAdditionalType", "Додаток")});
            this.cashBookAdditionalEdit.Properties.ImmediatePopup = true;
            this.cashBookAdditionalEdit.Properties.PopupSizeable = false;
            this.cashBookAdditionalEdit.Properties.PopupWidth = 553;
            this.cashBookAdditionalEdit.Properties.ShowHeader = false;
            this.cashBookAdditionalEdit.Size = new System.Drawing.Size(471, 22);
            this.cashBookAdditionalEdit.TabIndex = 5;
            this.cashBookAdditionalEdit.ToolTip = "Додаткова інформація";
            this.cashBookAdditionalEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cashBookAdditionalEdit_ButtonClick);
            // 
            // CashBookRecordEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 317);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.cashBookOperationEdit);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.cashBookRecordCurrencyTBox);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.bankAccountEdit);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.cashBookRecordDocumentTBox);
            this.Controls.Add(this.labelControl11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashBookRecordEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагування запису";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cashBookContractorEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookRecordCurrencyTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookRecordDocumentTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cashBookBasisEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookOperationEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookRecordValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cashBookAdditionalEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit cashBookRecordCurrencyTBox;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit bankAccountEdit;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit cashBookRecordDocumentTBox;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraEditors.LookUpEdit cashBookContractorEdit;
        private DevExpress.XtraEditors.LookUpEdit cashBookBasisEdit;
        private DevExpress.XtraEditors.LookUpEdit cashBookOperationEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider cashBookRecordValidationProvider;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LookUpEdit cashBookAdditionalEdit;
    }
}