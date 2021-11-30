namespace ERP_NEW.GUI.OTK
{
    partial class WeldStampJournalEditFm
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
            this.journalValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.beginDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.responsiblePersonEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.weldStampEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.endDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.journalValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsiblePersonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldStampEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // journalValidationProvider
            // 
            this.journalValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            this.journalValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.journalValidationProvider_ValidationFailed);
            this.journalValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.journalValidationProvider_ValidationSucceeded);
            // 
            // beginDateEdit
            // 
            this.beginDateEdit.EditValue = null;
            this.beginDateEdit.Location = new System.Drawing.Point(12, 121);
            this.beginDateEdit.Name = "beginDateEdit";
            this.beginDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.beginDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.beginDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.beginDateEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.beginDateEdit.Size = new System.Drawing.Size(141, 20);
            this.beginDateEdit.TabIndex = 35;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Виберіть дату видачі";
            this.journalValidationProvider.SetValidationRule(this.beginDateEdit, conditionValidationRule1);
            this.beginDateEdit.EditValueChanged += new System.EventHandler(this.beginDateEdit_EditValueChanged);
            // 
            // responsiblePersonEdit
            // 
            this.responsiblePersonEdit.Location = new System.Drawing.Point(12, 31);
            this.responsiblePersonEdit.Name = "responsiblePersonEdit";
            this.responsiblePersonEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.responsiblePersonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.responsiblePersonEdit.Properties.ImmediatePopup = true;
            this.responsiblePersonEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.responsiblePersonEdit.Properties.PopupFormSize = new System.Drawing.Size(553, 0);
            this.responsiblePersonEdit.Properties.View = this.gridView2;
            this.responsiblePersonEdit.Size = new System.Drawing.Size(380, 20);
            this.responsiblePersonEdit.TabIndex = 59;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule2.ErrorText = "Виберіть працівника";
            conditionValidationRule2.Value1 = 0;
            this.journalValidationProvider.SetValidationRule(this.responsiblePersonEdit, conditionValidationRule2);
            this.responsiblePersonEdit.EditValueChanged += new System.EventHandler(this.responsiblePersonEdit_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn12});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsFind.SearchInPreview = true;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // weldStampEdit
            // 
            this.weldStampEdit.Location = new System.Drawing.Point(12, 76);
            this.weldStampEdit.Name = "weldStampEdit";
            this.weldStampEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.weldStampEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldStampEdit.Properties.ImmediatePopup = true;
            this.weldStampEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.weldStampEdit.Properties.PopupFormSize = new System.Drawing.Size(553, 0);
            this.weldStampEdit.Properties.View = this.gridView1;
            this.weldStampEdit.Size = new System.Drawing.Size(380, 20);
            this.weldStampEdit.TabIndex = 61;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "Виберіть клеймо";
            conditionValidationRule3.Value1 = 0;
            this.journalValidationProvider.SetValidationRule(this.weldStampEdit, conditionValidationRule3);
            this.weldStampEdit.EditValueChanged += new System.EventHandler(this.weldStampEdit_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.SearchInPreview = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Дата видачі";
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(12, 202);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 38;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(315, 233);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 37;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(234, 233);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 36;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(51, 13);
            this.labelControl8.TabIndex = 58;
            this.labelControl8.Text = "Працівник";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 60;
            this.labelControl1.Text = "Клеймо";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 147);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 13);
            this.labelControl3.TabIndex = 63;
            this.labelControl3.Text = "Дата повернення";
            // 
            // endDateEdit
            // 
            this.endDateEdit.EditValue = null;
            this.endDateEdit.EnterMoveNextControl = true;
            this.endDateEdit.Location = new System.Drawing.Point(12, 166);
            this.endDateEdit.Name = "endDateEdit";
            this.endDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.endDateEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.endDateEdit.Size = new System.Drawing.Size(141, 20);
            this.endDateEdit.TabIndex = 62;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Номер";
            this.gridColumn1.FieldName = "StampNumber";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 150;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Дата";
            this.gridColumn2.FieldName = "StampDate";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 155;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Таб. номер";
            this.gridColumn4.FieldName = "AccountNumber";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 150;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "ПІБ працівника";
            this.gridColumn7.FieldName = "Fio";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 155;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Професія";
            this.gridColumn8.FieldName = "ProfessionName";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.AllowFocus = false;
            this.gridColumn8.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 300;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Підрозділ";
            this.gridColumn12.FieldName = "DepartmentName";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 3;
            // 
            // WeldStampJournalEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(402, 263);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.endDateEdit);
            this.Controls.Add(this.weldStampEdit);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.responsiblePersonEdit);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.beginDateEdit);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeldStampJournalEditFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагування";
            ((System.ComponentModel.ISupportInitialize)(this.journalValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsiblePersonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldStampEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider journalValidationProvider;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit beginDateEdit;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.GridLookUpEdit responsiblePersonEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.GridLookUpEdit weldStampEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit endDateEdit;
    }
}