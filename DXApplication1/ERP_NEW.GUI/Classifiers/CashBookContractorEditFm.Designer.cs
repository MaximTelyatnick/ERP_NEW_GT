namespace ERP_NEW.GUI.Classifiers
{
    partial class CashBookContractorEditFm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.deleteCashBookContractorBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveCashBookContractorBtn = new DevExpress.XtraEditors.SimpleButton();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cashBookContractorEdit = new DevExpress.XtraEditors.TextEdit();
            this.cashBookContractorValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookContractorEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookContractorValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.deleteCashBookContractorBtn);
            this.panelControl1.Controls.Add(this.saveCashBookContractorBtn);
            this.panelControl1.Controls.Add(this.validateLbl);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cashBookContractorEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(466, 107);
            this.panelControl1.TabIndex = 0;
            // 
            // deleteCashBookContractorBtn
            // 
            this.deleteCashBookContractorBtn.Location = new System.Drawing.Point(369, 68);
            this.deleteCashBookContractorBtn.Name = "deleteCashBookContractorBtn";
            this.deleteCashBookContractorBtn.Size = new System.Drawing.Size(80, 23);
            this.deleteCashBookContractorBtn.TabIndex = 43;
            this.deleteCashBookContractorBtn.Text = "Відміна";
            this.deleteCashBookContractorBtn.Click += new System.EventHandler(this.cancelCashBookContractorBtn_Click);
            // 
            // saveCashBookContractorBtn
            // 
            this.saveCashBookContractorBtn.Location = new System.Drawing.Point(278, 68);
            this.saveCashBookContractorBtn.Name = "saveCashBookContractorBtn";
            this.saveCashBookContractorBtn.Size = new System.Drawing.Size(80, 23);
            this.saveCashBookContractorBtn.TabIndex = 42;
            this.saveCashBookContractorBtn.Text = "Зберегти";
            this.saveCashBookContractorBtn.Click += new System.EventHandler(this.saveCashBookContractorBtn_Click);
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(12, 73);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 41;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Контрагенти";
            // 
            // cashBookContractorEdit
            // 
            this.cashBookContractorEdit.Location = new System.Drawing.Point(110, 29);
            this.cashBookContractorEdit.Name = "cashBookContractorEdit";
            this.cashBookContractorEdit.Size = new System.Drawing.Size(339, 20);
            this.cashBookContractorEdit.TabIndex = 0;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.cashBookContractorValidationProvider.SetValidationRule(this.cashBookContractorEdit, conditionValidationRule2);
            this.cashBookContractorEdit.EditValueChanged += new System.EventHandler(this.cashBookContractorEdit_EditValueChanged);
            // 
            // cashBookContractorValidationProvider
            // 
            this.cashBookContractorValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.cashBookContractorValidationProvider_ValidationFailed);
            this.cashBookContractorValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.cashBookContractorValidationProvider_ValidationSucceeded);
            // 
            // CashBookContractorEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 107);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.Name = "CashBookContractorEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Додати контрагента";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookContractorEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookContractorValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit cashBookContractorEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider cashBookContractorValidationProvider;
        private DevExpress.XtraEditors.SimpleButton deleteCashBookContractorBtn;
        private DevExpress.XtraEditors.SimpleButton saveCashBookContractorBtn;
    }
}