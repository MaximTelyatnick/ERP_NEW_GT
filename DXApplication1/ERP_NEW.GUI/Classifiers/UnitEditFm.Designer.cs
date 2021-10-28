namespace ERP_NEW.GUI.Classifiers
{
    partial class UnitEditFm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.unitFullNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.unitLocalNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.unitValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.unitFullNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitLocalNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.AllowHtmlString = true;
            this.labelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.Location = new System.Drawing.Point(10, 21);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 32);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "Повне<br>наіменування";
            // 
            // unitFullNameEdit
            // 
            this.unitFullNameEdit.Location = new System.Drawing.Point(152, 26);
            this.unitFullNameEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.unitFullNameEdit.Name = "unitFullNameEdit";
            this.unitFullNameEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.unitFullNameEdit.Properties.Appearance.Options.UseFont = true;
            this.unitFullNameEdit.Size = new System.Drawing.Size(409, 24);
            this.unitFullNameEdit.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Введіть наіменування";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.unitValidationProvider.SetValidationRule(this.unitFullNameEdit, conditionValidationRule1);
            this.unitFullNameEdit.EditValueChanged += new System.EventHandler(this.unitFullNameEdit_EditValueChanged);
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(10, 133);
            this.validateLbl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(295, 16);
            this.validateLbl.TabIndex = 41;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(470, 129);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(87, 28);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(376, 129);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 28);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.AllowHtmlString = true;
            this.labelControl2.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.Location = new System.Drawing.Point(10, 61);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 32);
            this.labelControl2.TabIndex = 44;
            this.labelControl2.Text = "Скорочене<br>наіменування";
            this.labelControl2.UseMnemonic = false;
            // 
            // unitLocalNameEdit
            // 
            this.unitLocalNameEdit.Location = new System.Drawing.Point(152, 67);
            this.unitLocalNameEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.unitLocalNameEdit.Name = "unitLocalNameEdit";
            this.unitLocalNameEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.unitLocalNameEdit.Properties.Appearance.Options.UseFont = true;
            this.unitLocalNameEdit.Size = new System.Drawing.Size(405, 24);
            this.unitLocalNameEdit.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Введіть скорочене наіменування";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.unitValidationProvider.SetValidationRule(this.unitLocalNameEdit, conditionValidationRule2);
            this.unitLocalNameEdit.EditValueChanged += new System.EventHandler(this.unitLocalNameEdit_EditValueChanged);
            // 
            // unitValidationProvider
            // 
            this.unitValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            this.unitValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.unitValidationProvider_ValidationFailed);
            this.unitValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.unitValidationProvider_ValidationSucceeded);
            // 
            // UnitEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(590, 183);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.unitLocalNameEdit);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.unitFullNameEdit);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitEditFm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Одиниця вимірювання";
            ((System.ComponentModel.ISupportInitialize)(this.unitFullNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitLocalNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit unitFullNameEdit;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit unitLocalNameEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider unitValidationProvider;

    }
}