namespace ERP_NEW.GUI.CustomerOrders
{
    partial class AgreementOrderPurposeEditFm
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
            this.cancelAddNewPurposeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveAddNewPurposeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.nameAgreementOrderPurposeEdit = new DevExpress.XtraEditors.TextEdit();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nameAgreementOrderPurposeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelAddNewPurposeBtn
            // 
            this.cancelAddNewPurposeBtn.Location = new System.Drawing.Point(442, 86);
            this.cancelAddNewPurposeBtn.Name = "cancelAddNewPurposeBtn";
            this.cancelAddNewPurposeBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelAddNewPurposeBtn.TabIndex = 64;
            this.cancelAddNewPurposeBtn.Text = "Відміна";
            this.cancelAddNewPurposeBtn.Click += new System.EventHandler(this.cancelAddNewPurposeBtn_Click);
            // 
            // saveAddNewPurposeBtn
            // 
            this.saveAddNewPurposeBtn.Location = new System.Drawing.Point(361, 86);
            this.saveAddNewPurposeBtn.Name = "saveAddNewPurposeBtn";
            this.saveAddNewPurposeBtn.Size = new System.Drawing.Size(75, 23);
            this.saveAddNewPurposeBtn.TabIndex = 63;
            this.saveAddNewPurposeBtn.Text = "Зберегти";
            this.saveAddNewPurposeBtn.Click += new System.EventHandler(this.saveAddNewPurposeBtn_Click);
            // 
            // nameAgreementOrderPurposeEdit
            // 
            this.nameAgreementOrderPurposeEdit.Location = new System.Drawing.Point(12, 40);
            this.nameAgreementOrderPurposeEdit.Name = "nameAgreementOrderPurposeEdit";
            this.nameAgreementOrderPurposeEdit.Size = new System.Drawing.Size(505, 20);
            this.nameAgreementOrderPurposeEdit.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Не вказано підставу";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.nameAgreementOrderPurposeEdit, conditionValidationRule1);
            this.nameAgreementOrderPurposeEdit.EditValueChanged += new System.EventHandler(this.nameAgreementOrderPurposeEdit_EditValueChanged);
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(17, 90);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 61;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // dxValidationProvider
            // 
            this.dxValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.dxValidationProvider_ValidationFailed);
            this.dxValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.dxValidationProvider_ValidationSucceeded);
            // 
            // AgreementOrderPurposeEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 117);
            this.Controls.Add(this.nameAgreementOrderPurposeEdit);
            this.Controls.Add(this.cancelAddNewPurposeBtn);
            this.Controls.Add(this.saveAddNewPurposeBtn);
            this.Controls.Add(this.validateLbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgreementOrderPurposeEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редагування підстави";
            ((System.ComponentModel.ISupportInitialize)(this.nameAgreementOrderPurposeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cancelAddNewPurposeBtn;
        private DevExpress.XtraEditors.SimpleButton saveAddNewPurposeBtn;
        private DevExpress.XtraEditors.TextEdit nameAgreementOrderPurposeEdit;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
    }
}