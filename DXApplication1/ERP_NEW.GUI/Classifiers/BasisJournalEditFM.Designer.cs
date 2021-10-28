namespace ERP_NEW.GUI.Classifiers
{
    partial class BasisJournalEditFM
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.cancelBasisJournalBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBasisJournalBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.basisJournalEdit = new DevExpress.XtraEditors.TextEdit();
            this.cashBookBasisValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basisJournalEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookBasisValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(805, 388);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.validateLbl);
            this.panelControl2.Controls.Add(this.cancelBasisJournalBtn);
            this.panelControl2.Controls.Add(this.saveBasisJournalBtn);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.basisJournalEdit);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(451, 117);
            this.panelControl2.TabIndex = 0;
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(12, 87);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 40;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // cancelBasisJournalBtn
            // 
            this.cancelBasisJournalBtn.Location = new System.Drawing.Point(364, 87);
            this.cancelBasisJournalBtn.Name = "cancelBasisJournalBtn";
            this.cancelBasisJournalBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBasisJournalBtn.TabIndex = 3;
            this.cancelBasisJournalBtn.Text = "Відмінити";
            this.cancelBasisJournalBtn.Click += new System.EventHandler(this.cancelBasisJournalBtn_Click);
            // 
            // saveBasisJournalBtn
            // 
            this.saveBasisJournalBtn.Location = new System.Drawing.Point(283, 87);
            this.saveBasisJournalBtn.Name = "saveBasisJournalBtn";
            this.saveBasisJournalBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBasisJournalBtn.TabIndex = 2;
            this.saveBasisJournalBtn.Text = "Зберегти";
            this.saveBasisJournalBtn.Click += new System.EventHandler(this.saveBasisJournalBtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Підстава";
            // 
            // basisJournalEdit
            // 
            this.basisJournalEdit.Location = new System.Drawing.Point(74, 29);
            this.basisJournalEdit.Name = "basisJournalEdit";
            this.basisJournalEdit.Size = new System.Drawing.Size(365, 20);
            this.basisJournalEdit.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Введіть підставу";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule1.Value1 = "<Null>";
            this.cashBookBasisValidationProvider.SetValidationRule(this.basisJournalEdit, conditionValidationRule1);
            this.basisJournalEdit.EditValueChanged += new System.EventHandler(this.basisJournalEdit_EditValueChanged);
            // 
            // cashBookBasisValidationProvider
            // 
            this.cashBookBasisValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.cashBookBasisValidationProvider_ValidationFailed);
            this.cashBookBasisValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.cashBookBasisValidationProvider_ValidationSucceeded);
            // 
            // BasisJournalEditFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 117);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Name = "BasisJournalEditFM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати підставу";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basisJournalEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookBasisValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton saveBasisJournalBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit basisJournalEdit;
        private DevExpress.XtraEditors.SimpleButton cancelBasisJournalBtn;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider cashBookBasisValidationProvider;
        private DevExpress.XtraEditors.LabelControl validateLbl;
    }
}