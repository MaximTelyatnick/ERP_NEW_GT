namespace ERP_NEW.GUI.Classifiers
{
    partial class AccountsEditFm
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
            this.accountNumberEdit = new DevExpress.XtraEditors.TextEdit();
            this.accountDescriptionEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.accountsValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.accountTypeEdit = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.accountNumberEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDescriptionEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // accountNumberEdit
            // 
            this.accountNumberEdit.Location = new System.Drawing.Point(237, 14);
            this.accountNumberEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accountNumberEdit.Name = "accountNumberEdit";
            this.accountNumberEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.accountNumberEdit.Properties.Appearance.Options.UseFont = true;
            this.accountNumberEdit.Size = new System.Drawing.Size(462, 24);
            this.accountNumberEdit.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Пусте поле номеру рахунку";
            this.accountsValidationProvider.SetValidationRule(this.accountNumberEdit, conditionValidationRule1);
            this.accountNumberEdit.EditValueChanged += new System.EventHandler(this.accountNumberEdit_EditValueChanged);
            // 
            // accountDescriptionEdit
            // 
            this.accountDescriptionEdit.Location = new System.Drawing.Point(237, 62);
            this.accountDescriptionEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accountDescriptionEdit.Name = "accountDescriptionEdit";
            this.accountDescriptionEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.accountDescriptionEdit.Properties.Appearance.Options.UseFont = true;
            this.accountDescriptionEdit.Size = new System.Drawing.Size(462, 24);
            this.accountDescriptionEdit.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 21);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 16);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "Номер рахунку";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 65);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 16);
            this.labelControl2.TabIndex = 44;
            this.labelControl2.Text = "Опис рахунку";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 108);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 16);
            this.labelControl3.TabIndex = 45;
            this.labelControl3.Text = "Тип рахунку";
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(14, 186);
            this.validateLbl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(295, 16);
            this.validateLbl.TabIndex = 46;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(614, 180);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(87, 28);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(510, 180);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 28);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // accountsValidationProvider
            // 
            this.accountsValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            this.accountsValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.accountsValidationProvider_ValidationFailed);
            this.accountsValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.accountsValidationProvider_ValidationSucceeded);
            // 
            // accountTypeEdit
            // 
            this.accountTypeEdit.Location = new System.Drawing.Point(237, 105);
            this.accountTypeEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accountTypeEdit.Name = "accountTypeEdit";
            this.accountTypeEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.accountTypeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accountTypeEdit.Properties.NullText = "[EditValue is null]";
            this.accountTypeEdit.Properties.PopupFormSize = new System.Drawing.Size(553, 0);
            this.accountTypeEdit.Size = new System.Drawing.Size(462, 22);
            this.accountTypeEdit.TabIndex = 3;
            // 
            // AccountsEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(721, 230);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.accountDescriptionEdit);
            this.Controls.Add(this.accountNumberEdit);
            this.Controls.Add(this.accountTypeEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountsEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагувати рахунок";
            ((System.ComponentModel.ISupportInitialize)(this.accountNumberEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDescriptionEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountTypeEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit accountNumberEdit;
        private DevExpress.XtraEditors.TextEdit accountDescriptionEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider accountsValidationProvider;
        private DevExpress.XtraEditors.CheckedComboBoxEdit accountTypeEdit;
    }
}