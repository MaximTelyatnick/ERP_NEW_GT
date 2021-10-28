namespace ERP_NEW.GUI.CustomerOrders
{
    partial class AgreementJournalDocAssemblyEditFm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cancelAddNewDocBut = new DevExpress.XtraEditors.SimpleButton();
            this.saveAddNewDocBut = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.nameNewDocEdit = new DevExpress.XtraEditors.TextEdit();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.agreementJournalDocAssemblyValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameNewDocEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreementJournalDocAssemblyValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cancelAddNewDocBut);
            this.panelControl1.Controls.Add(this.saveAddNewDocBut);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.validateLbl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(553, 115);
            this.panelControl1.TabIndex = 0;
            // 
            // cancelAddNewDocBut
            // 
            this.cancelAddNewDocBut.Location = new System.Drawing.Point(449, 86);
            this.cancelAddNewDocBut.Name = "cancelAddNewDocBut";
            this.cancelAddNewDocBut.Size = new System.Drawing.Size(75, 23);
            this.cancelAddNewDocBut.TabIndex = 60;
            this.cancelAddNewDocBut.Text = "Відміна";
            this.cancelAddNewDocBut.Click += new System.EventHandler(this.cancelAddNewDocBut_Click);
            // 
            // saveAddNewDocBut
            // 
            this.saveAddNewDocBut.Location = new System.Drawing.Point(368, 87);
            this.saveAddNewDocBut.Name = "saveAddNewDocBut";
            this.saveAddNewDocBut.Size = new System.Drawing.Size(75, 23);
            this.saveAddNewDocBut.TabIndex = 59;
            this.saveAddNewDocBut.Text = "Зберегти";
            this.saveAddNewDocBut.Click += new System.EventHandler(this.saveAddNewDocBut_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.White;
            this.groupControl1.AppearanceCaption.BackColor2 = System.Drawing.Color.White;
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.White;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.nameNewDocEdit);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(534, 68);
            this.groupControl1.TabIndex = 58;
            this.groupControl1.Text = "Документ";
            // 
            // nameNewDocEdit
            // 
            this.nameNewDocEdit.Location = new System.Drawing.Point(5, 34);
            this.nameNewDocEdit.Name = "nameNewDocEdit";
            this.nameNewDocEdit.Size = new System.Drawing.Size(507, 20);
            this.nameNewDocEdit.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.agreementJournalDocAssemblyValidationProvider.SetValidationRule(this.nameNewDocEdit, conditionValidationRule1);
            this.nameNewDocEdit.EditValueChanged += new System.EventHandler(this.nameNewDocEdit_EditValueChanged);
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(17, 90);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 57;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // agreementJournalDocAssemblyValidationProvider
            // 
            this.agreementJournalDocAssemblyValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.agreementJournalDocAssemblyValidationProvider_ValidationFailed);
            this.agreementJournalDocAssemblyValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.agreementJournalDocAssemblyValidationProvider_ValidationSucceeded);
            // 
            // AgreementJournalDocAssemblyEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 115);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgreementJournalDocAssemblyEditFm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати документ";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nameNewDocEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agreementJournalDocAssemblyValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton cancelAddNewDocBut;
        private DevExpress.XtraEditors.SimpleButton saveAddNewDocBut;
        private DevExpress.XtraEditors.TextEdit nameNewDocEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider agreementJournalDocAssemblyValidationProvider;
    }
}