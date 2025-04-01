namespace ERP_NEW.GUI.Accounting
{
    partial class FixedAssetsOrderRegionEditFm
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
            this.typeEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.nameEdit = new DevExpress.XtraEditors.TextEdit();
            this.descriptionEdit = new DevExpress.XtraEditors.MemoEdit();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.typeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // typeEdit
            // 
            this.typeEdit.Location = new System.Drawing.Point(179, 44);
            this.typeEdit.Name = "typeEdit";
            this.typeEdit.Size = new System.Drawing.Size(339, 20);
            this.typeEdit.TabIndex = 60;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 13);
            this.labelControl3.TabIndex = 59;
            this.labelControl3.Text = "Опис";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(18, 13);
            this.labelControl2.TabIndex = 58;
            this.labelControl2.Text = "Тип";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(438, 164);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 23);
            this.cancelBtn.TabIndex = 57;
            this.cancelBtn.Text = "Відміна";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(352, 164);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(80, 23);
            this.saveBtn.TabIndex = 56;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(28, 169);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 55;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 54;
            this.labelControl1.Text = "Назва участку";
            // 
            // nameEdit
            // 
            this.nameEdit.Location = new System.Drawing.Point(179, 12);
            this.nameEdit.Name = "nameEdit";
            this.nameEdit.Size = new System.Drawing.Size(339, 20);
            this.nameEdit.TabIndex = 53;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Не вказано назву";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.nameEdit, conditionValidationRule1);
            this.nameEdit.EditValueChanged += new System.EventHandler(this.nameEdit_EditValueChanged);
            // 
            // descriptionEdit
            // 
            this.descriptionEdit.Location = new System.Drawing.Point(179, 77);
            this.descriptionEdit.Name = "descriptionEdit";
            this.descriptionEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionEdit.Size = new System.Drawing.Size(339, 70);
            this.descriptionEdit.TabIndex = 61;
            // 
            // dxValidationProvider
            // 
            this.dxValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.dxValidationProvider_ValidationFailed);
            this.dxValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.dxValidationProvider_ValidationSucceeded);
            // 
            // FixedAssetsOrderRegionEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 199);
            this.Controls.Add(this.typeEdit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.nameEdit);
            this.Controls.Add(this.descriptionEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FixedAssetsOrderRegionEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагування участку";
            ((System.ComponentModel.ISupportInitialize)(this.typeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit typeEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit nameEdit;
        private DevExpress.XtraEditors.MemoEdit descriptionEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
    }
}