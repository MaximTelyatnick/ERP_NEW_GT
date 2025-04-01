namespace ERP_NEW.GUI.Accounting
{
    partial class FixedAssetsOrderGroupEditFm
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
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fixedAssetsGroupNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.fixedAssetsGroupAmortEdit = new DevExpress.XtraEditors.TextEdit();
            this.fixedAssetsGroupPeriodEdit = new DevExpress.XtraEditors.TextEdit();
            this.fixedAssetsGroupValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsGroupNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsGroupAmortEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsGroupPeriodEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsGroupValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(434, 148);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 23);
            this.cancelBtn.TabIndex = 48;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(343, 148);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(80, 23);
            this.saveBtn.TabIndex = 47;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(77, 153);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 46;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(154, 13);
            this.labelControl1.TabIndex = 45;
            this.labelControl1.Text = "Назва групи основного засобу";
            // 
            // fixedAssetsGroupNameEdit
            // 
            this.fixedAssetsGroupNameEdit.Location = new System.Drawing.Point(175, 12);
            this.fixedAssetsGroupNameEdit.Name = "fixedAssetsGroupNameEdit";
            this.fixedAssetsGroupNameEdit.Size = new System.Drawing.Size(339, 20);
            this.fixedAssetsGroupNameEdit.TabIndex = 44;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Не вказано назву групи";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.fixedAssetsGroupValidationProvider.SetValidationRule(this.fixedAssetsGroupNameEdit, conditionValidationRule2);
            this.fixedAssetsGroupNameEdit.EditValueChanged += new System.EventHandler(this.fixedAssetsGroupNameEdit_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(98, 13);
            this.labelControl2.TabIndex = 49;
            this.labelControl2.Text = "Фактор амортизації";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(94, 13);
            this.labelControl3.TabIndex = 50;
            this.labelControl3.Text = "Період амортизації";
            // 
            // fixedAssetsGroupAmortEdit
            // 
            this.fixedAssetsGroupAmortEdit.Location = new System.Drawing.Point(175, 44);
            this.fixedAssetsGroupAmortEdit.Name = "fixedAssetsGroupAmortEdit";
            this.fixedAssetsGroupAmortEdit.Size = new System.Drawing.Size(339, 20);
            this.fixedAssetsGroupAmortEdit.TabIndex = 51;
            // 
            // fixedAssetsGroupPeriodEdit
            // 
            this.fixedAssetsGroupPeriodEdit.Location = new System.Drawing.Point(175, 77);
            this.fixedAssetsGroupPeriodEdit.Name = "fixedAssetsGroupPeriodEdit";
            this.fixedAssetsGroupPeriodEdit.Size = new System.Drawing.Size(339, 20);
            this.fixedAssetsGroupPeriodEdit.TabIndex = 52;
            // 
            // fixedAssetsGroupValidationProvider
            // 
            this.fixedAssetsGroupValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.fixedAssetsGroupValidationProvider_ValidationFailed);
            this.fixedAssetsGroupValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.fixedAssetsGroupValidationProvider_ValidationSucceeded);
            // 
            // FixedAssetsOrderGroupEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 181);
            this.Controls.Add(this.fixedAssetsGroupPeriodEdit);
            this.Controls.Add(this.fixedAssetsGroupAmortEdit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.fixedAssetsGroupNameEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FixedAssetsOrderGroupEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Група основного засобу";
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsGroupNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsGroupAmortEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsGroupPeriodEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedAssetsGroupValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit fixedAssetsGroupNameEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit fixedAssetsGroupAmortEdit;
        private DevExpress.XtraEditors.TextEdit fixedAssetsGroupPeriodEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider fixedAssetsGroupValidationProvider;
    }
}