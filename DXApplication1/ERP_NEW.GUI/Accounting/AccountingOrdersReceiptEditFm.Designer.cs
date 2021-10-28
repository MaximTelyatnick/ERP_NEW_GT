namespace ERP_NEW.GUI.Accounting
{
    partial class AccountingOrdersReceiptEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountingOrdersReceiptEditFm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.measureEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nomenclatureEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.balanceNumEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.nomenclatureNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.quantityEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.totalCurrencyEdit = new DevExpress.XtraEditors.TextEdit();
            this.currencyRateEdit = new DevExpress.XtraEditors.TextEdit();
            this.unitCurrencyEdit = new DevExpress.XtraEditors.TextEdit();
            this.unitPriceEdit = new DevExpress.XtraEditors.TextEdit();
            this.totalPriceEdit = new DevExpress.XtraEditors.TextEdit();
            this.currencyEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.rateLbl = new DevExpress.XtraEditors.LabelControl();
            this.currencyLbl = new DevExpress.XtraEditors.LabelControl();
            this.totalCurrencyLbl = new DevExpress.XtraEditors.LabelControl();
            this.unitCurrencyLbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.materialValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.measureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomenclatureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceNumEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomenclatureNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalCurrencyEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyRateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitCurrencyEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitPriceEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.measureEdit);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.nomenclatureEdit);
            this.groupControl1.Controls.Add(this.balanceNumEdit);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.nomenclatureNameEdit);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.quantityEdit);
            this.groupControl1.Controls.Add(this.labelControl16);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(485, 125);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Матеріал";
            // 
            // measureEdit
            // 
            this.measureEdit.Location = new System.Drawing.Point(8, 96);
            this.measureEdit.Name = "measureEdit";
            this.measureEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.measureEdit.Properties.Appearance.Options.UseFont = true;
            this.measureEdit.Properties.ReadOnly = true;
            this.measureEdit.Size = new System.Drawing.Size(91, 20);
            this.measureEdit.TabIndex = 103;
            this.measureEdit.ToolTip = "Номер заявки";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Location = new System.Drawing.Point(105, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 115;
            this.labelControl2.Text = "Б. рахунок";
            // 
            // nomenclatureEdit
            // 
            this.nomenclatureEdit.Location = new System.Drawing.Point(5, 51);
            this.nomenclatureEdit.Name = "nomenclatureEdit";
            this.nomenclatureEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.nomenclatureEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomenclatureEdit.Properties.Appearance.Options.UseFont = true;
            this.nomenclatureEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("nomenclatureEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.nomenclatureEdit.Properties.MaxLength = 9;
            this.nomenclatureEdit.Size = new System.Drawing.Size(174, 22);
            this.nomenclatureEdit.TabIndex = 100;
            conditionValidationRule1.CaseSensitive = true;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Не вказано номенлатурний номер";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.materialValidationProvider.SetValidationRule(this.nomenclatureEdit, conditionValidationRule1);
            this.nomenclatureEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.measureEdit_ButtonClick);
            this.nomenclatureEdit.EditValueChanged += new System.EventHandler(this.nomenclatureEdit_EditValueChanged);
            this.nomenclatureEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomenclatureEdit_KeyPress);
            // 
            // balanceNumEdit
            // 
            this.balanceNumEdit.Location = new System.Drawing.Point(105, 96);
            this.balanceNumEdit.Name = "balanceNumEdit";
            this.balanceNumEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.balanceNumEdit.Properties.Appearance.Options.UseFont = true;
            this.balanceNumEdit.Properties.ReadOnly = true;
            this.balanceNumEdit.Size = new System.Drawing.Size(74, 20);
            this.balanceNumEdit.TabIndex = 104;
            this.balanceNumEdit.ToolTip = "Номер заявки";
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.materialValidationProvider.SetValidationRule(this.balanceNumEdit, conditionValidationRule2);
            this.balanceNumEdit.EditValueChanged += new System.EventHandler(this.balanceNumEdit_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl8.Location = new System.Drawing.Point(5, 32);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(94, 14);
            this.labelControl8.TabIndex = 98;
            this.labelControl8.Text = "Номенкл. номер";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl11.Location = new System.Drawing.Point(189, 32);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(82, 14);
            this.labelControl11.TabIndex = 99;
            this.labelControl11.Text = "Найменування";
            // 
            // nomenclatureNameEdit
            // 
            this.nomenclatureNameEdit.Location = new System.Drawing.Point(189, 53);
            this.nomenclatureNameEdit.Name = "nomenclatureNameEdit";
            this.nomenclatureNameEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nomenclatureNameEdit.Properties.Appearance.Options.UseFont = true;
            this.nomenclatureNameEdit.Properties.ReadOnly = true;
            this.nomenclatureNameEdit.Size = new System.Drawing.Size(288, 20);
            this.nomenclatureNameEdit.TabIndex = 101;
            this.nomenclatureNameEdit.ToolTip = "Номер заявки";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl15.Location = new System.Drawing.Point(8, 78);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(88, 14);
            this.labelControl15.TabIndex = 101;
            this.labelControl15.Text = "Од. вимірювань";
            // 
            // quantityEdit
            // 
            this.quantityEdit.EditValue = "0,000";
            this.quantityEdit.Location = new System.Drawing.Point(189, 96);
            this.quantityEdit.Name = "quantityEdit";
            this.quantityEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.quantityEdit.Properties.Appearance.Options.UseFont = true;
            this.quantityEdit.Properties.Mask.EditMask = "###,###,###,###0.000;";
            this.quantityEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.quantityEdit.Size = new System.Drawing.Size(119, 20);
            this.quantityEdit.TabIndex = 105;
            this.quantityEdit.ToolTip = "Номер заявки";
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Не вказано кількість";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.materialValidationProvider.SetValidationRule(this.quantityEdit, conditionValidationRule3);
            this.quantityEdit.EditValueChanged += new System.EventHandler(this.quantityEdit_EditValueChanged);
            this.quantityEdit.TextChanged += new System.EventHandler(this.quantityEdit_TextChanged);
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl16.Location = new System.Drawing.Point(189, 79);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(48, 14);
            this.labelControl16.TabIndex = 104;
            this.labelControl16.Text = "Кількість";
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(12, 318);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 43;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(403, 318);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 23);
            this.cancelBtn.TabIndex = 66;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(305, 318);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(92, 23);
            this.saveBtn.TabIndex = 105;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.totalCurrencyEdit);
            this.groupControl2.Controls.Add(this.currencyRateEdit);
            this.groupControl2.Controls.Add(this.unitCurrencyEdit);
            this.groupControl2.Controls.Add(this.unitPriceEdit);
            this.groupControl2.Controls.Add(this.totalPriceEdit);
            this.groupControl2.Controls.Add(this.currencyEdit);
            this.groupControl2.Controls.Add(this.rateLbl);
            this.groupControl2.Controls.Add(this.currencyLbl);
            this.groupControl2.Controls.Add(this.totalCurrencyLbl);
            this.groupControl2.Controls.Add(this.unitCurrencyLbl);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.labelControl17);
            this.groupControl2.Location = new System.Drawing.Point(12, 143);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(485, 164);
            this.groupControl2.TabIndex = 68;
            this.groupControl2.Text = "Суми";
            // 
            // totalCurrencyEdit
            // 
            this.totalCurrencyEdit.EditValue = "0,00";
            this.totalCurrencyEdit.Location = new System.Drawing.Point(256, 48);
            this.totalCurrencyEdit.Name = "totalCurrencyEdit";
            this.totalCurrencyEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.totalCurrencyEdit.Properties.Appearance.Options.UseFont = true;
            this.totalCurrencyEdit.Properties.Mask.BeepOnError = true;
            this.totalCurrencyEdit.Properties.Mask.EditMask = "###,###,###,###0.00;";
            this.totalCurrencyEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.totalCurrencyEdit.Size = new System.Drawing.Size(224, 20);
            this.totalCurrencyEdit.TabIndex = 107;
            this.totalCurrencyEdit.ToolTip = "Номер заявки";
            this.totalCurrencyEdit.TextChanged += new System.EventHandler(this.totalCurrencyEdit_TextChanged);
            this.totalCurrencyEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalCurrencyEdit_KeyPress);
            this.totalCurrencyEdit.Leave += new System.EventHandler(this.totalCurrencyEdit_Leave);
            // 
            // currencyRateEdit
            // 
            this.currencyRateEdit.EditValue = "0,00";
            this.currencyRateEdit.Location = new System.Drawing.Point(382, 138);
            this.currencyRateEdit.Name = "currencyRateEdit";
            this.currencyRateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.currencyRateEdit.Properties.Appearance.Options.UseFont = true;
            this.currencyRateEdit.Properties.Mask.EditMask = "###,###,###,###0.00;";
            this.currencyRateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.currencyRateEdit.Properties.ReadOnly = true;
            this.currencyRateEdit.Size = new System.Drawing.Size(98, 20);
            this.currencyRateEdit.TabIndex = 125;
            this.currencyRateEdit.ToolTip = "Номер заявки";
            // 
            // unitCurrencyEdit
            // 
            this.unitCurrencyEdit.EditValue = "0,00";
            this.unitCurrencyEdit.Location = new System.Drawing.Point(256, 92);
            this.unitCurrencyEdit.Name = "unitCurrencyEdit";
            this.unitCurrencyEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.unitCurrencyEdit.Properties.Appearance.Options.UseFont = true;
            this.unitCurrencyEdit.Properties.Mask.EditMask = "###,###,###,###0.00;";
            this.unitCurrencyEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.unitCurrencyEdit.Properties.ReadOnly = true;
            this.unitCurrencyEdit.Size = new System.Drawing.Size(224, 20);
            this.unitCurrencyEdit.TabIndex = 124;
            this.unitCurrencyEdit.ToolTip = "Номер заявки";
            // 
            // unitPriceEdit
            // 
            this.unitPriceEdit.EditValue = "0,00";
            this.unitPriceEdit.Location = new System.Drawing.Point(8, 91);
            this.unitPriceEdit.Name = "unitPriceEdit";
            this.unitPriceEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.unitPriceEdit.Properties.Appearance.Options.UseFont = true;
            this.unitPriceEdit.Properties.Mask.BeepOnError = true;
            this.unitPriceEdit.Properties.Mask.EditMask = "###,###,###,###0.00;";
            this.unitPriceEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.unitPriceEdit.Properties.ReadOnly = true;
            this.unitPriceEdit.Size = new System.Drawing.Size(238, 20);
            this.unitPriceEdit.TabIndex = 122;
            this.unitPriceEdit.ToolTip = "Номер заявки";
            // 
            // totalPriceEdit
            // 
            this.totalPriceEdit.EditValue = "0,00";
            this.totalPriceEdit.Location = new System.Drawing.Point(8, 48);
            this.totalPriceEdit.Name = "totalPriceEdit";
            this.totalPriceEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.totalPriceEdit.Properties.Appearance.Options.UseFont = true;
            this.totalPriceEdit.Properties.Mask.EditMask = "###,###,###,###0.00;";
            this.totalPriceEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.totalPriceEdit.Size = new System.Drawing.Size(238, 20);
            this.totalPriceEdit.TabIndex = 106;
            this.totalPriceEdit.ToolTip = "Номер заявки";
            this.totalPriceEdit.TextChanged += new System.EventHandler(this.totalPriceEdit_TextChanged);
            this.totalPriceEdit.Leave += new System.EventHandler(this.totalPriceEdit_Leave);
            // 
            // currencyEdit
            // 
            this.currencyEdit.Location = new System.Drawing.Point(256, 138);
            this.currencyEdit.Name = "currencyEdit";
            this.currencyEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.currencyEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Валюта")});
            this.currencyEdit.Properties.ImmediatePopup = true;
            this.currencyEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.currencyEdit.Properties.PopupSizeable = false;
            this.currencyEdit.Properties.PopupWidth = 60;
            this.currencyEdit.Properties.ReadOnly = true;
            this.currencyEdit.Size = new System.Drawing.Size(120, 20);
            this.currencyEdit.TabIndex = 120;
            // 
            // rateLbl
            // 
            this.rateLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rateLbl.Location = new System.Drawing.Point(382, 117);
            this.rateLbl.Name = "rateLbl";
            this.rateLbl.Size = new System.Drawing.Size(26, 14);
            this.rateLbl.TabIndex = 119;
            this.rateLbl.Text = "Курс";
            // 
            // currencyLbl
            // 
            this.currencyLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currencyLbl.Location = new System.Drawing.Point(256, 118);
            this.currencyLbl.Name = "currencyLbl";
            this.currencyLbl.Size = new System.Drawing.Size(41, 14);
            this.currencyLbl.TabIndex = 117;
            this.currencyLbl.Text = "Валюта";
            // 
            // totalCurrencyLbl
            // 
            this.totalCurrencyLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalCurrencyLbl.Location = new System.Drawing.Point(256, 30);
            this.totalCurrencyLbl.Name = "totalCurrencyLbl";
            this.totalCurrencyLbl.Size = new System.Drawing.Size(81, 14);
            this.totalCurrencyLbl.TabIndex = 115;
            this.totalCurrencyLbl.Text = "Сума (валюта)";
            // 
            // unitCurrencyLbl
            // 
            this.unitCurrencyLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitCurrencyLbl.Location = new System.Drawing.Point(256, 72);
            this.unitCurrencyLbl.Name = "unitCurrencyLbl";
            this.unitCurrencyLbl.Size = new System.Drawing.Size(110, 14);
            this.unitCurrencyLbl.TabIndex = 113;
            this.unitCurrencyLbl.Text = "Ціна за од (валюта)";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Location = new System.Drawing.Point(8, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(143, 14);
            this.labelControl1.TabIndex = 111;
            this.labelControl1.Text = "Ціна за од. без ПДВ (грн)";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl17.Location = new System.Drawing.Point(8, 29);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(110, 14);
            this.labelControl17.TabIndex = 105;
            this.labelControl17.Text = "Сума без ПДВ (грн)";
            // 
            // materialValidationProvider
            // 
            this.materialValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            this.materialValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.materialValidationProvider_ValidationFailed);
            this.materialValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.materialValidationProvider_ValidationSucceeded);
            // 
            // AccountingOrdersReceiptEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 345);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountingOrdersReceiptEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Надходження";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.measureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomenclatureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceNumEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomenclatureNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalCurrencyEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyRateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitCurrencyEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitPriceEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPriceEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit nomenclatureNameEdit;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit quantityEdit;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl totalCurrencyLbl;
        private DevExpress.XtraEditors.LabelControl unitCurrencyLbl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit balanceNumEdit;
        private DevExpress.XtraEditors.ButtonEdit nomenclatureEdit;
        private DevExpress.XtraEditors.LabelControl rateLbl;
        private DevExpress.XtraEditors.LabelControl currencyLbl;
        private DevExpress.XtraEditors.LookUpEdit currencyEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit unitCurrencyEdit;
        private DevExpress.XtraEditors.TextEdit unitPriceEdit;
        private DevExpress.XtraEditors.TextEdit totalPriceEdit;
        private DevExpress.XtraEditors.TextEdit measureEdit;
        private DevExpress.XtraEditors.TextEdit currencyRateEdit;
        private DevExpress.XtraEditors.TextEdit totalCurrencyEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider materialValidationProvider;
    }
}