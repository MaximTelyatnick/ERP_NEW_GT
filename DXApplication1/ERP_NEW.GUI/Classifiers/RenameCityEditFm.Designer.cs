namespace ERP_NEW.GUI.Classifiers
{
    partial class RenameCityEditFm
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
            this.oldNameCityEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.newNameCityEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.renameDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cityDescriptionEdit = new DevExpress.XtraEditors.MemoEdit();
            this.renameCityEditValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            ((System.ComponentModel.ISupportInitialize)(this.oldNameCityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newNameCityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renameDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renameDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDescriptionEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renameCityEditValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // oldNameCityEdit
            // 
            this.oldNameCityEdit.Location = new System.Drawing.Point(181, 23);
            this.oldNameCityEdit.Name = "oldNameCityEdit";
            this.oldNameCityEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.oldNameCityEdit.Properties.Appearance.Options.UseFont = true;
            this.oldNameCityEdit.Properties.ReadOnly = true;
            this.oldNameCityEdit.Size = new System.Drawing.Size(241, 20);
            this.oldNameCityEdit.TabIndex = 35;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 13);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "Колишня назва міста";
            // 
            // newNameCityEdit
            // 
            this.newNameCityEdit.Location = new System.Drawing.Point(181, 62);
            this.newNameCityEdit.Name = "newNameCityEdit";
            this.newNameCityEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.newNameCityEdit.Properties.Appearance.Options.UseFont = true;
            this.newNameCityEdit.Size = new System.Drawing.Size(241, 20);
            this.newNameCityEdit.TabIndex = 44;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Введіть нову назву міста";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.renameCityEditValidationProvider.SetValidationRule(this.newNameCityEdit, conditionValidationRule1);
            this.newNameCityEdit.EditValueChanged += new System.EventHandler(this.newNameCityEdit_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "Нова назва міста";
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(0, 267);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 46;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(347, 262);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 48;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(267, 262);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 47;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // renameDateEdit
            // 
            this.renameDateEdit.EditValue = null;
            this.renameDateEdit.Location = new System.Drawing.Point(181, 100);
            this.renameDateEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.renameDateEdit.Name = "renameDateEdit";
            this.renameDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.renameDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.renameDateEdit.Size = new System.Drawing.Size(241, 20);
            this.renameDateEdit.TabIndex = 49;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 13);
            this.labelControl3.TabIndex = 50;
            this.labelControl3.Text = "Дата перейменування";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 143);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 51;
            this.labelControl4.Text = "Примітки";
            // 
            // cityDescriptionEdit
            // 
            this.cityDescriptionEdit.Location = new System.Drawing.Point(181, 141);
            this.cityDescriptionEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityDescriptionEdit.Name = "cityDescriptionEdit";
            this.cityDescriptionEdit.Size = new System.Drawing.Size(241, 115);
            this.cityDescriptionEdit.TabIndex = 52;
            // 
            // renameCityEditValidationProvider
            // 
            this.renameCityEditValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            this.renameCityEditValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.renameCityEditValidationProvider_ValidationFailed);
            this.renameCityEditValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.renameCityEditValidationProvider_ValidationSucceeded);
            // 
            // RenameCityEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 293);
            this.Controls.Add(this.cityDescriptionEdit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.renameDateEdit);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.newNameCityEdit);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.oldNameCityEdit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenameCityEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Перейменування міста";
            this.Load += new System.EventHandler(this.RenameCityEditFm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oldNameCityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newNameCityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renameDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renameDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDescriptionEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renameCityEditValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit oldNameCityEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit newNameCityEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.DateEdit renameDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit cityDescriptionEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider renameCityEditValidationProvider;
    }
}