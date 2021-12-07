namespace ERP_NEW.GUI.Tools
{
    partial class UserRoleEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRoleEditFm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.roleNameTBox = new DevExpress.XtraEditors.TextEdit();
            this.userRoleValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.departmentEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.roleNameTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelControl1.Location = new System.Drawing.Point(13, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(121, 13);
            this.labelControl1.TabIndex = 39;
            this.labelControl1.Text = "Найменування групи";
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(12, 123);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(216, 13);
            this.validateLbl.TabIndex = 38;
            this.validateLbl.Text = "*Для збереження заповніть необхідні дані";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(606, 118);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 37;
            this.cancelBtn.Text = "Відмінити";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(525, 118);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 36;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // roleNameTBox
            // 
            this.roleNameTBox.Location = new System.Drawing.Point(13, 79);
            this.roleNameTBox.Name = "roleNameTBox";
            this.roleNameTBox.Size = new System.Drawing.Size(670, 20);
            this.roleNameTBox.TabIndex = 35;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Введіть найменування групи";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.userRoleValidationProvider.SetValidationRule(this.roleNameTBox, conditionValidationRule1);
            this.roleNameTBox.EditValueChanged += new System.EventHandler(this.roleNameTBox_EditValueChanged);
            this.roleNameTBox.TextChanged += new System.EventHandler(this.roleNameTBox_TextChanged);
            // 
            // userRoleValidationProvider
            // 
            this.userRoleValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            this.userRoleValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.userRoleValidationProvider_ValidationFailed);
            this.userRoleValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.userRoleValidationProvider_ValidationSucceeded);
            // 
            // departmentEdit
            // 
            this.departmentEdit.Location = new System.Drawing.Point(13, 32);
            this.departmentEdit.Name = "departmentEdit";
            this.departmentEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.departmentEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("departmentEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("departmentEdit.Properties.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("departmentEdit.Properties.Buttons2"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.departmentEdit.Properties.ImmediatePopup = true;
            this.departmentEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.departmentEdit.Properties.PopupFormSize = new System.Drawing.Size(553, 0);
            this.departmentEdit.Properties.View = this.gridView1;
            this.departmentEdit.Size = new System.Drawing.Size(670, 22);
            this.departmentEdit.TabIndex = 74;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Не вказано відділ";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.userRoleValidationProvider.SetValidationRule(this.departmentEdit, conditionValidationRule2);
            this.departmentEdit.EditValueChanged += new System.EventHandler(this.departmentEdit_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.SearchInPreview = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelControl3.Location = new System.Drawing.Point(13, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 14);
            this.labelControl3.TabIndex = 73;
            this.labelControl3.Text = "Відділ";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Підрозділ";
            this.gridColumn5.FieldName = "Name";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Код";
            this.gridColumn1.FieldName = "Code";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // UserRoleEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(695, 148);
            this.Controls.Add(this.departmentEdit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.roleNameTBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserRoleEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Група користувачів";
            ((System.ComponentModel.ISupportInitialize)(this.roleNameTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.TextEdit roleNameTBox;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider userRoleValidationProvider;
        private DevExpress.XtraEditors.GridLookUpEdit departmentEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}