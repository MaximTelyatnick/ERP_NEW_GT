namespace ERP_NEW.GUI.Classifiers
{
    partial class CashBookAdditionalEditFm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cancelCashBookAdditionalBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveCashBookAdditionalBtn = new DevExpress.XtraEditors.SimpleButton();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.cashBookAdditionalEdit = new DevExpress.XtraEditors.TextEdit();
            this.cashBookAdditionalValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookAdditionalEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookAdditionalValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cancelCashBookAdditionalBtn);
            this.groupControl1.Controls.Add(this.saveCashBookAdditionalBtn);
            this.groupControl1.Controls.Add(this.validateLbl);
            this.groupControl1.Controls.Add(this.cashBookAdditionalEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(491, 127);
            this.groupControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 45;
            this.labelControl1.Text = "Додаток";
            // 
            // cancelCashBookAdditionalBtn
            // 
            this.cancelCashBookAdditionalBtn.Location = new System.Drawing.Point(388, 78);
            this.cancelCashBookAdditionalBtn.Name = "cancelCashBookAdditionalBtn";
            this.cancelCashBookAdditionalBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelCashBookAdditionalBtn.TabIndex = 44;
            this.cancelCashBookAdditionalBtn.Text = "Відміна";
            this.cancelCashBookAdditionalBtn.Click += new System.EventHandler(this.cancelCashBookAdditionalBtn_Click);
            // 
            // saveCashBookAdditionalBtn
            // 
            this.saveCashBookAdditionalBtn.Location = new System.Drawing.Point(297, 78);
            this.saveCashBookAdditionalBtn.Name = "saveCashBookAdditionalBtn";
            this.saveCashBookAdditionalBtn.Size = new System.Drawing.Size(75, 23);
            this.saveCashBookAdditionalBtn.TabIndex = 43;
            this.saveCashBookAdditionalBtn.Text = "Зберегти";
            this.saveCashBookAdditionalBtn.Click += new System.EventHandler(this.saveCashBookAdditionalBtn_Click);
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(26, 88);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 42;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // cashBookAdditionalEdit
            // 
            this.cashBookAdditionalEdit.Location = new System.Drawing.Point(85, 40);
            this.cashBookAdditionalEdit.Name = "cashBookAdditionalEdit";
            this.cashBookAdditionalEdit.Size = new System.Drawing.Size(378, 20);
            this.cashBookAdditionalEdit.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.cashBookAdditionalValidationProvider.SetValidationRule(this.cashBookAdditionalEdit, conditionValidationRule1);
            this.cashBookAdditionalEdit.EditValueChanged += new System.EventHandler(this.cashBookAdditionalEdit_EditValueChanged);
            // 
            // cashBookAdditionalValidationProvider
            // 
            this.cashBookAdditionalValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.cashBookAdditionalValidationProvider_ValidationFailed);
            this.cashBookAdditionalValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.cashBookAdditionalValidationProvider_ValidationSucceeded);
            // 
            // CashBookAdditionalEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 127);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashBookAdditionalEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал касових додатків";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookAdditionalEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookAdditionalValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit cashBookAdditionalEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider cashBookAdditionalValidationProvider;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.SimpleButton cancelCashBookAdditionalBtn;
        private DevExpress.XtraEditors.SimpleButton saveCashBookAdditionalBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}