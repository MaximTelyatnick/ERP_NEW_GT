namespace ERP_NEW.GUI.BusinessTrips
{
    partial class BusinessTripsPrepaymentEditFm
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
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.userInfoVGrid = new DevExpress.XtraVerticalGrid.VGridControl();
            this.category = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.row5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.row1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.row2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.row3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.row = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.row4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.userFotoEdit = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.prepaymentCreditEdit = new DevExpress.XtraEditors.TextEdit();
            this.balanceAccountEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.prepaymentDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.businessTripsPrepaymentValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoVGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFotoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prepaymentCreditEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceAccountEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepaymentDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepaymentDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsPrepaymentValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.userFotoEdit);
            this.groupControl1.Location = new System.Drawing.Point(10, 10);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(711, 166);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Відряджений";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.userInfoVGrid);
            this.panelControl1.Location = new System.Drawing.Point(134, 24);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(573, 138);
            this.panelControl1.TabIndex = 58;
            // 
            // userInfoVGrid
            // 
            this.userInfoVGrid.Appearance.Category.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.userInfoVGrid.Appearance.Category.ForeColor = System.Drawing.Color.Navy;
            this.userInfoVGrid.Appearance.Category.Options.UseFont = true;
            this.userInfoVGrid.Appearance.Category.Options.UseForeColor = true;
            this.userInfoVGrid.Appearance.RowHeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.userInfoVGrid.Appearance.RowHeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userInfoVGrid.Appearance.RowHeaderPanel.Options.UseFont = true;
            this.userInfoVGrid.Appearance.RowHeaderPanel.Options.UseForeColor = true;
            this.userInfoVGrid.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.userInfoVGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInfoVGrid.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.userInfoVGrid.Location = new System.Drawing.Point(2, 2);
            this.userInfoVGrid.Name = "userInfoVGrid";
            this.userInfoVGrid.RecordWidth = 145;
            this.userInfoVGrid.RowHeaderWidth = 55;
            this.userInfoVGrid.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.category});
            this.userInfoVGrid.Size = new System.Drawing.Size(569, 134);
            this.userInfoVGrid.TabIndex = 3;
            // 
            // category
            // 
            this.category.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.row5,
            this.row1,
            this.row2,
            this.row3,
            this.row,
            this.row4});
            this.category.Height = 18;
            this.category.Name = "category";
            this.category.Properties.Caption = "Додаткова інформація";
            this.category.Properties.ImageIndex = 5;
            this.category.Properties.Padding = new System.Windows.Forms.Padding(0);
            // 
            // row5
            // 
            this.row5.Name = "row5";
            this.row5.OptionsRow.AllowFocus = false;
            this.row5.Properties.Caption = "Ф.І.О.";
            this.row5.Properties.FieldName = "FullName";
            this.row5.Properties.ImageIndex = 11;
            this.row5.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.row5.Properties.ReadOnly = false;
            // 
            // row1
            // 
            this.row1.Name = "row1";
            this.row1.OptionsRow.AllowFocus = false;
            this.row1.Properties.Caption = "Професія";
            this.row1.Properties.FieldName = "ProfessionName";
            this.row1.Properties.ImageIndex = 7;
            this.row1.Properties.Padding = new System.Windows.Forms.Padding(0);
            // 
            // row2
            // 
            this.row2.Name = "row2";
            this.row2.OptionsRow.AllowFocus = false;
            this.row2.Properties.Caption = "Відділ";
            this.row2.Properties.FieldName = "DepartmentName";
            this.row2.Properties.ImageIndex = 8;
            this.row2.Properties.Padding = new System.Windows.Forms.Padding(0);
            // 
            // row3
            // 
            this.row3.Name = "row3";
            this.row3.OptionsRow.AllowFocus = false;
            this.row3.Properties.Caption = "Номер заявки";
            this.row3.Properties.FieldName = "Doc_Number";
            this.row3.Properties.ImageIndex = 9;
            this.row3.Properties.Padding = new System.Windows.Forms.Padding(0);
            // 
            // row
            // 
            this.row.Name = "row";
            this.row.OptionsRow.AllowFocus = false;
            this.row.Properties.Caption = "Дата";
            this.row.Properties.FieldName = "Doc_Date";
            this.row.Properties.ImageIndex = 12;
            this.row.Properties.Padding = new System.Windows.Forms.Padding(0);
            // 
            // row4
            // 
            this.row4.Appearance.Options.UseTextOptions = true;
            this.row4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.row4.Name = "row4";
            this.row4.OptionsRow.AllowFocus = false;
            this.row4.Properties.Caption = "Табельний номер";
            this.row4.Properties.FieldName = "AccountNumber";
            this.row4.Properties.Padding = new System.Windows.Forms.Padding(0);
            // 
            // userFotoEdit
            // 
            this.userFotoEdit.Location = new System.Drawing.Point(4, 24);
            this.userFotoEdit.Name = "userFotoEdit";
            this.userFotoEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.userFotoEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.userFotoEdit.Properties.ZoomAccelerationFactor = 1D;
            this.userFotoEdit.Size = new System.Drawing.Size(114, 136);
            this.userFotoEdit.TabIndex = 57;
            this.userFotoEdit.ToolTip = "Портрет ";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.prepaymentCreditEdit);
            this.groupControl2.Controls.Add(this.balanceAccountEdit);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.prepaymentDateEdit);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Location = new System.Drawing.Point(10, 180);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(711, 80);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Аванс";
            // 
            // prepaymentCreditEdit
            // 
            this.prepaymentCreditEdit.EditValue = "0,00";
            this.prepaymentCreditEdit.Location = new System.Drawing.Point(365, 32);
            this.prepaymentCreditEdit.Name = "prepaymentCreditEdit";
            this.prepaymentCreditEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.prepaymentCreditEdit.Properties.Appearance.Options.UseFont = true;
            this.prepaymentCreditEdit.Properties.Mask.EditMask = "n2";
            this.prepaymentCreditEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.prepaymentCreditEdit.Size = new System.Drawing.Size(342, 20);
            this.prepaymentCreditEdit.TabIndex = 1;
            this.prepaymentCreditEdit.ToolTip = "Сума авансу";
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "Введіть суму";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule1.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.businessTripsPrepaymentValidationProvider.SetValidationRule(this.prepaymentCreditEdit, conditionValidationRule1);
            this.prepaymentCreditEdit.EditValueChanged += new System.EventHandler(this.prepaymentCreditEdit_EditValueChanged);
            // 
            // balanceAccountEdit
            // 
            this.balanceAccountEdit.Location = new System.Drawing.Point(93, 58);
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
            this.balanceAccountEdit.Size = new System.Drawing.Size(615, 20);
            this.balanceAccountEdit.TabIndex = 2;
            this.balanceAccountEdit.ToolTip = "Рахунок ";
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Виберіть рахунок";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule2.Value1 = ((short)(0));
            this.businessTripsPrepaymentValidationProvider.SetValidationRule(this.balanceAccountEdit, conditionValidationRule2);
            this.balanceAccountEdit.EditValueChanged += new System.EventHandler(this.balanceAccountEdit_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(14, 63);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(46, 13);
            this.labelControl7.TabIndex = 55;
            this.labelControl7.Text = "Рахунок:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(322, 35);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(29, 13);
            this.labelControl6.TabIndex = 54;
            this.labelControl6.Text = "Сума:";
            // 
            // prepaymentDateEdit
            // 
            this.prepaymentDateEdit.EditValue = null;
            this.prepaymentDateEdit.Location = new System.Drawing.Point(93, 32);
            this.prepaymentDateEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prepaymentDateEdit.MaximumSize = new System.Drawing.Size(206, 0);
            this.prepaymentDateEdit.MinimumSize = new System.Drawing.Size(197, 0);
            this.prepaymentDateEdit.Name = "prepaymentDateEdit";
            this.prepaymentDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.prepaymentDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.prepaymentDateEdit.Size = new System.Drawing.Size(206, 20);
            this.prepaymentDateEdit.TabIndex = 0;
            this.prepaymentDateEdit.ToolTip = "Дата створення заявки";
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Введіть дату авансу";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.businessTripsPrepaymentValidationProvider.SetValidationRule(this.prepaymentDateEdit, conditionValidationRule3);
            this.prepaymentDateEdit.EditValueChanged += new System.EventHandler(this.prepaymentDateEdit_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 13);
            this.labelControl5.TabIndex = 52;
            this.labelControl5.Text = "Дата:";
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(10, 267);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 48;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(647, 266);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(567, 266);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // businessTripsPrepaymentValidationProvider
            // 
            this.businessTripsPrepaymentValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            this.businessTripsPrepaymentValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.businessTripsPrepaymentValidationProvider_ValidationFailed);
            this.businessTripsPrepaymentValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.businessTripsPrepaymentValidationProvider_ValidationSucceeded);
            // 
            // BusinessTripsPrepaymentEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(729, 294);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BusinessTripsPrepaymentEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагувати аванс";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userInfoVGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFotoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prepaymentCreditEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceAccountEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepaymentDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepaymentDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessTripsPrepaymentValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit prepaymentDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit prepaymentCreditEdit;
        private DevExpress.XtraEditors.LookUpEdit balanceAccountEdit;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider businessTripsPrepaymentValidationProvider;
        private DevExpress.XtraEditors.PictureEdit userFotoEdit;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraVerticalGrid.VGridControl userInfoVGrid;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row5;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row4;
    }
}