namespace ERP_NEW.GUI.MTS
{
    partial class MtsMaterialEditOldFm
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
            this.directoryBuyDetailsBtn = new System.Windows.Forms.Button();
            this.quantityEdit = new DevExpress.XtraEditors.TextEdit();
            this.guageEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameBuyDetailEdit = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.mtsMaterialValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quantityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guageEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameBuyDetailEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtsMaterialValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // directoryBuyDetailsBtn
            // 
            this.directoryBuyDetailsBtn.Location = new System.Drawing.Point(428, 21);
            this.directoryBuyDetailsBtn.Name = "directoryBuyDetailsBtn";
            this.directoryBuyDetailsBtn.Size = new System.Drawing.Size(31, 27);
            this.directoryBuyDetailsBtn.TabIndex = 17;
            this.directoryBuyDetailsBtn.Text = "...";
            this.directoryBuyDetailsBtn.UseVisualStyleBackColor = true;
            this.directoryBuyDetailsBtn.Click += new System.EventHandler(this.directoryBuyDetailsBtn_Click);
            // 
            // quantityEdit
            // 
            this.quantityEdit.Location = new System.Drawing.Point(107, 96);
            this.quantityEdit.Name = "quantityEdit";
            this.quantityEdit.Properties.Mask.EditMask = "f";
            this.quantityEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.quantityEdit.Size = new System.Drawing.Size(352, 20);
            this.quantityEdit.TabIndex = 16;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "Не вказано кількість ";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule1.Value1 = 0;
            this.mtsMaterialValidationProvider.SetValidationRule(this.quantityEdit, conditionValidationRule1);
            this.quantityEdit.EditValueChanged += new System.EventHandler(this.quantityEdit_EditValueChanged);
            // 
            // guageEdit
            // 
            this.guageEdit.Location = new System.Drawing.Point(107, 61);
            this.guageEdit.Name = "guageEdit";
            this.guageEdit.Properties.ReadOnly = true;
            this.guageEdit.Size = new System.Drawing.Size(352, 20);
            this.guageEdit.TabIndex = 15;
            // 
            // nameBuyDetailEdit
            // 
            this.nameBuyDetailEdit.Location = new System.Drawing.Point(107, 25);
            this.nameBuyDetailEdit.Name = "nameBuyDetailEdit";
            this.nameBuyDetailEdit.Properties.ReadOnly = true;
            this.nameBuyDetailEdit.Size = new System.Drawing.Size(315, 20);
            this.nameBuyDetailEdit.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "Кількість";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Сортамент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Найменування";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(384, 122);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Відмінити";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(303, 122);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(15, 127);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 49;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // mtsMaterialValidationProvider
            // 
            this.mtsMaterialValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.mtsMaterialValidationProvider_ValidationFailed);
            this.mtsMaterialValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.mtsMaterialValidationProvider_ValidationSucceeded);
            // 
            // MtsMaterialEditOldFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 159);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.directoryBuyDetailsBtn);
            this.Controls.Add(this.quantityEdit);
            this.Controls.Add(this.guageEdit);
            this.Controls.Add(this.nameBuyDetailEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MtsMaterialEditOldFm";
            this.ShowIcon = false;
            this.Text = "Редагування матеріалів";
            ((System.ComponentModel.ISupportInitialize)(this.quantityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guageEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameBuyDetailEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtsMaterialValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button directoryBuyDetailsBtn;
        private DevExpress.XtraEditors.TextEdit quantityEdit;
        private DevExpress.XtraEditors.TextEdit guageEdit;
        private DevExpress.XtraEditors.TextEdit nameBuyDetailEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider mtsMaterialValidationProvider;
    }
}