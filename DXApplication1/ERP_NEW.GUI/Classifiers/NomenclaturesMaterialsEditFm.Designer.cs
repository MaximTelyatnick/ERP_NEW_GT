namespace ERP_NEW.GUI.Classifiers
{
    partial class NomenclaturesMaterialsEditFm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NomenclaturesMaterialsEditFm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.balanceAccountEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.groupNameEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.nomenclatureNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.nomenclatureNumberEdit = new DevExpress.XtraEditors.TextEdit();
            this.unitNameEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.nomenclatureValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceAccountEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomenclatureNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomenclatureNumberEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomenclatureValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.balanceAccountEdit);
            this.groupControl2.Controls.Add(this.groupNameEdit);
            this.groupControl2.Controls.Add(this.nomenclatureNameEdit);
            this.groupControl2.Controls.Add(this.nomenclatureNumberEdit);
            this.groupControl2.Controls.Add(this.unitNameEdit);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Location = new System.Drawing.Point(10, 9);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(831, 162);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Номенклатура";
            // 
            // balanceAccountEdit
            // 
            this.balanceAccountEdit.Location = new System.Drawing.Point(167, 54);
            this.balanceAccountEdit.Name = "balanceAccountEdit";
            this.balanceAccountEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.balanceAccountEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.balanceAccountEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Num", "Name3")});
            this.balanceAccountEdit.Properties.ImmediatePopup = true;
            this.balanceAccountEdit.Properties.PopupSizeable = false;
            this.balanceAccountEdit.Properties.PopupWidth = 553;
            this.balanceAccountEdit.Properties.ShowHeader = false;
            this.balanceAccountEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.balanceAccountEdit.Size = new System.Drawing.Size(649, 20);
            this.balanceAccountEdit.TabIndex = 1;
            this.balanceAccountEdit.ToolTip = "Балансовий рахунок";
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Не вказано балансовий рахунок";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.nomenclatureValidationProvider.SetValidationRule(this.balanceAccountEdit, conditionValidationRule1);
            this.balanceAccountEdit.EditValueChanged += new System.EventHandler(this.balanceAccountEdit_EditValueChanged);
            this.balanceAccountEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.balanceAccountEdit_KeyPress);
            // 
            // groupNameEdit
            // 
            this.groupNameEdit.Location = new System.Drawing.Point(167, 28);
            this.groupNameEdit.Name = "groupNameEdit";
            this.groupNameEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.groupNameEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.groupNameEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name3")});
            this.groupNameEdit.Properties.ImmediatePopup = true;
            this.groupNameEdit.Properties.PopupSizeable = false;
            this.groupNameEdit.Properties.PopupWidth = 553;
            this.groupNameEdit.Properties.ShowHeader = false;
            this.groupNameEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.groupNameEdit.Size = new System.Drawing.Size(649, 20);
            this.groupNameEdit.TabIndex = 0;
            this.groupNameEdit.ToolTip = "Номенклатурна група ";
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Не вказана група";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.nomenclatureValidationProvider.SetValidationRule(this.groupNameEdit, conditionValidationRule2);
            this.groupNameEdit.EditValueChanged += new System.EventHandler(this.groupNameEdit_EditValueChanged);
            this.groupNameEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.groupNameEdit_KeyPress);
            // 
            // nomenclatureNameEdit
            // 
            this.nomenclatureNameEdit.Location = new System.Drawing.Point(167, 106);
            this.nomenclatureNameEdit.Name = "nomenclatureNameEdit";
            this.nomenclatureNameEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nomenclatureNameEdit.Properties.Appearance.Options.UseFont = true;
            this.nomenclatureNameEdit.Size = new System.Drawing.Size(649, 20);
            this.nomenclatureNameEdit.TabIndex = 4;
            this.nomenclatureNameEdit.ToolTip = "Назва номенклатури";
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Не вказане найменування номенклатури";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.nomenclatureValidationProvider.SetValidationRule(this.nomenclatureNameEdit, conditionValidationRule3);
            this.nomenclatureNameEdit.EditValueChanged += new System.EventHandler(this.nomenclatureNameEdit_EditValueChanged);
            this.nomenclatureNameEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomenclatureNameEdit_KeyPress);
            // 
            // nomenclatureNumberEdit
            // 
            this.nomenclatureNumberEdit.Location = new System.Drawing.Point(167, 80);
            this.nomenclatureNumberEdit.Name = "nomenclatureNumberEdit";
            this.nomenclatureNumberEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nomenclatureNumberEdit.Properties.Appearance.Options.UseFont = true;
            this.nomenclatureNumberEdit.Properties.MaxLength = 9;
            this.nomenclatureNumberEdit.Size = new System.Drawing.Size(649, 20);
            this.nomenclatureNumberEdit.TabIndex = 3;
            this.nomenclatureNumberEdit.ToolTip = "Номенклатурний номер";
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Не вказано номенклатурний номер";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.nomenclatureValidationProvider.SetValidationRule(this.nomenclatureNumberEdit, conditionValidationRule4);
            this.nomenclatureNumberEdit.EditValueChanged += new System.EventHandler(this.nomenclatureNumberEdit_EditValueChanged);
            this.nomenclatureNumberEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomenclatureNumberEdit_KeyPress);
            // 
            // unitNameEdit
            // 
            this.unitNameEdit.Location = new System.Drawing.Point(167, 132);
            this.unitNameEdit.Name = "unitNameEdit";
            this.unitNameEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.unitNameEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("unitNameEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Додати", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("unitNameEdit.Properties.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("unitNameEdit.Properties.Buttons2"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("unitNameEdit.Properties.Buttons3"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.unitNameEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitLocalName", "Name3")});
            this.unitNameEdit.Properties.ImmediatePopup = true;
            this.unitNameEdit.Properties.PopupSizeable = false;
            this.unitNameEdit.Properties.PopupWidth = 553;
            this.unitNameEdit.Properties.ShowHeader = false;
            this.unitNameEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.unitNameEdit.Size = new System.Drawing.Size(649, 22);
            this.unitNameEdit.TabIndex = 5;
            this.unitNameEdit.ToolTip = "Одиниці вимірювання";
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Не вказані одиниці вимірювання";
            conditionValidationRule5.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.nomenclatureValidationProvider.SetValidationRule(this.unitNameEdit, conditionValidationRule5);
            this.unitNameEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.unitNameEdit_ButtonClick);
            this.unitNameEdit.EditValueChanged += new System.EventHandler(this.unitNameEdit_EditValueChanged);
            this.unitNameEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unitNameEdit_KeyPress);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(18, 134);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(113, 13);
            this.labelControl9.TabIndex = 49;
            this.labelControl9.Text = "Одиниці вимірювання:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(18, 110);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(77, 13);
            this.labelControl8.TabIndex = 48;
            this.labelControl8.Text = "Найменування:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(18, 83);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(122, 13);
            this.labelControl7.TabIndex = 47;
            this.labelControl7.Text = "Номенклатурний номер:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(18, 57);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(108, 13);
            this.labelControl6.TabIndex = 46;
            this.labelControl6.Text = "Балансовий рахунок:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 32);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 13);
            this.labelControl5.TabIndex = 45;
            this.labelControl5.Text = "Група";
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(10, 184);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 48;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(766, 179);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 50;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(685, 179);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 49;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // nomenclatureValidationProvider
            // 
            this.nomenclatureValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.nomenclatureValidationProvider_ValidationFailed);
            this.nomenclatureValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.nomenclatureValidationProvider_ValidationSucceeded);
            // 
            // NomenclaturesMaterialsEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(851, 207);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NomenclaturesMaterialsEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагування";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceAccountEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomenclatureNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomenclatureNumberEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomenclatureValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.LookUpEdit unitNameEdit;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.LookUpEdit balanceAccountEdit;
        private DevExpress.XtraEditors.LookUpEdit groupNameEdit;
        private DevExpress.XtraEditors.TextEdit nomenclatureNameEdit;
        private DevExpress.XtraEditors.TextEdit nomenclatureNumberEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider nomenclatureValidationProvider;

    }
}