namespace ERP_NEW.GUI.CustomerOrders
{
    partial class CustomerOrderSpecEditFm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.singleCurrencyPriceTBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.quantityTBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.sumPriceTBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.sumCurrencyPriceTBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.singlePriceTBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.nameTBox = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.specificationValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.singleCurrencyPriceTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumPriceTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumCurrencyPriceTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singlePriceTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specificationValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(248, 147);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(68, 13);
            this.labelControl11.TabIndex = 46;
            this.labelControl11.Text = "Ціна, валюта";
            // 
            // singleCurrencyPriceTBox
            // 
            this.singleCurrencyPriceTBox.EditValue = "0,0000";
            this.singleCurrencyPriceTBox.Location = new System.Drawing.Point(248, 166);
            this.singleCurrencyPriceTBox.Name = "singleCurrencyPriceTBox";
            this.singleCurrencyPriceTBox.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.singleCurrencyPriceTBox.Properties.Appearance.Options.UseTextOptions = true;
            this.singleCurrencyPriceTBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.singleCurrencyPriceTBox.Properties.Mask.EditMask = "n4";
            this.singleCurrencyPriceTBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.singleCurrencyPriceTBox.Properties.NullText = "0,00";
            this.singleCurrencyPriceTBox.Properties.NullValuePrompt = "0,00";
            this.singleCurrencyPriceTBox.Properties.NullValuePromptShowForEmptyValue = true;
            this.singleCurrencyPriceTBox.Size = new System.Drawing.Size(214, 20);
            this.singleCurrencyPriceTBox.TabIndex = 4;
            this.singleCurrencyPriceTBox.TextChanged += new System.EventHandler(this.singleCurrencyPriceTBox_TextChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(6, 102);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(46, 13);
            this.labelControl10.TabIndex = 44;
            this.labelControl10.Text = "Кількість";
            // 
            // quantityTBox
            // 
            this.quantityTBox.EditValue = "0";
            this.quantityTBox.Location = new System.Drawing.Point(6, 121);
            this.quantityTBox.Name = "quantityTBox";
            this.quantityTBox.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.quantityTBox.Properties.Appearance.Options.UseTextOptions = true;
            this.quantityTBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.quantityTBox.Properties.Mask.EditMask = "n0";
            this.quantityTBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.quantityTBox.Properties.NullText = "0,00";
            this.quantityTBox.Properties.NullValuePrompt = "0,00";
            this.quantityTBox.Properties.NullValuePromptShowForEmptyValue = true;
            this.quantityTBox.Size = new System.Drawing.Size(236, 20);
            this.quantityTBox.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Необхідно ввести кількість";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.specificationValidationProvider.SetValidationRule(this.quantityTBox, conditionValidationRule2);
            this.quantityTBox.TextChanged += new System.EventHandler(this.quantityTBox_TextChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(6, 192);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 13);
            this.labelControl9.TabIndex = 42;
            this.labelControl9.Text = "Сума, грн";
            // 
            // sumPriceTBox
            // 
            this.sumPriceTBox.EditValue = "0,0000";
            this.sumPriceTBox.Location = new System.Drawing.Point(6, 211);
            this.sumPriceTBox.Name = "sumPriceTBox";
            this.sumPriceTBox.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.sumPriceTBox.Properties.Appearance.Options.UseTextOptions = true;
            this.sumPriceTBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.sumPriceTBox.Properties.Mask.EditMask = "n4";
            this.sumPriceTBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.sumPriceTBox.Properties.NullText = "0,00";
            this.sumPriceTBox.Properties.NullValuePrompt = "0,00";
            this.sumPriceTBox.Properties.NullValuePromptShowForEmptyValue = true;
            this.sumPriceTBox.Properties.ReadOnly = true;
            this.sumPriceTBox.Size = new System.Drawing.Size(236, 20);
            this.sumPriceTBox.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(248, 192);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(71, 13);
            this.labelControl7.TabIndex = 40;
            this.labelControl7.Text = "Сума, валюта";
            // 
            // sumCurrencyPriceTBox
            // 
            this.sumCurrencyPriceTBox.EditValue = "0,0000";
            this.sumCurrencyPriceTBox.Location = new System.Drawing.Point(248, 211);
            this.sumCurrencyPriceTBox.Name = "sumCurrencyPriceTBox";
            this.sumCurrencyPriceTBox.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.sumCurrencyPriceTBox.Properties.Appearance.Options.UseTextOptions = true;
            this.sumCurrencyPriceTBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.sumCurrencyPriceTBox.Properties.Mask.EditMask = "n4";
            this.sumCurrencyPriceTBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.sumCurrencyPriceTBox.Properties.NullText = "0,00";
            this.sumCurrencyPriceTBox.Properties.NullValuePrompt = "0,00";
            this.sumCurrencyPriceTBox.Properties.NullValuePromptShowForEmptyValue = true;
            this.sumCurrencyPriceTBox.Properties.ReadOnly = true;
            this.sumCurrencyPriceTBox.Size = new System.Drawing.Size(214, 20);
            this.sumCurrencyPriceTBox.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "Ціна, грн";
            // 
            // singlePriceTBox
            // 
            this.singlePriceTBox.EditValue = "0,0000";
            this.singlePriceTBox.Location = new System.Drawing.Point(6, 166);
            this.singlePriceTBox.Name = "singlePriceTBox";
            this.singlePriceTBox.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.singlePriceTBox.Properties.Appearance.Options.UseTextOptions = true;
            this.singlePriceTBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.singlePriceTBox.Properties.Mask.EditMask = "n4";
            this.singlePriceTBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.singlePriceTBox.Properties.NullText = "0,00";
            this.singlePriceTBox.Properties.NullValuePrompt = "0,00";
            this.singlePriceTBox.Properties.NullValuePromptShowForEmptyValue = true;
            this.singlePriceTBox.Size = new System.Drawing.Size(236, 20);
            this.singlePriceTBox.TabIndex = 3;
            this.singlePriceTBox.TextChanged += new System.EventHandler(this.singlePriceTBox_TextChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.AllowHtmlString = true;
            this.labelControl6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl6.Location = new System.Drawing.Point(6, 23);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 13);
            this.labelControl6.TabIndex = 48;
            this.labelControl6.Text = "Найменування";
            // 
            // nameTBox
            // 
            this.nameTBox.Location = new System.Drawing.Point(6, 42);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.Size = new System.Drawing.Size(644, 54);
            this.nameTBox.TabIndex = 1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Необхідно заповнити найменування";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.specificationValidationProvider.SetValidationRule(this.nameTBox, conditionValidationRule3);
            this.nameTBox.TextChanged += new System.EventHandler(this.nameTBox_TextChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.sumCurrencyPriceTBox);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.singleCurrencyPriceTBox);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.nameTBox);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.sumPriceTBox);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.quantityTBox);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.singlePriceTBox);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(655, 246);
            this.groupControl1.TabIndex = 49;
            this.groupControl1.Text = "Специфікація обладнання";
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(12, 273);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 52;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(587, 268);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(506, 268);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // specificationValidationProvider
            // 
            this.specificationValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            this.specificationValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.specificationGroupValidationProvider_ValidationFailed);
            this.specificationValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.specificationGroupValidationProvider_ValidationSucceeded);
            // 
            // CustomerOrderSpecEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(677, 304);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerOrderSpecEditFm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагування";
            ((System.ComponentModel.ISupportInitialize)(this.singleCurrencyPriceTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumPriceTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumCurrencyPriceTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singlePriceTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specificationValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit singleCurrencyPriceTBox;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit quantityTBox;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit sumPriceTBox;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit sumCurrencyPriceTBox;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit singlePriceTBox;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.MemoEdit nameTBox;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider specificationValidationProvider;
    }
}