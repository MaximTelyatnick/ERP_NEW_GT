namespace ERP_NEW.GUI.Production
{
    partial class ProjectDetailEditFm
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
            this.assemblyEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.drawingCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.assemblyNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contractorCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.assemblyDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.assemblyGeneralNameTBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.assemblyNameTBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.closeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.projectValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            this.orderNumberEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.assemblyDrawingTBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.generalAssemblyAsAssemblyCheck = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyGeneralNameTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyNameTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyDrawingTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalAssemblyAsAssemblyCheck.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // assemblyEdit
            // 
            this.assemblyEdit.Location = new System.Drawing.Point(12, 76);
            this.assemblyEdit.Name = "assemblyEdit";
            this.assemblyEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.assemblyEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.assemblyEdit.Properties.ImmediatePopup = true;
            this.assemblyEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.assemblyEdit.Properties.PopupFormSize = new System.Drawing.Size(1450, 0);
            this.assemblyEdit.Properties.View = this.gridLookUpEdit1View;
            this.assemblyEdit.Size = new System.Drawing.Size(1008, 20);
            this.assemblyEdit.TabIndex = 2;
            this.assemblyEdit.EditValueChanged += new System.EventHandler(this.assemblyEdit_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.drawingCol,
            this.assemblyNameCol,
            this.orderDateCol,
            this.orderNumberCol,
            this.contractorCol});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsFind.AlwaysVisible = true;
            this.gridLookUpEdit1View.OptionsFind.SearchInPreview = true;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // drawingCol
            // 
            this.drawingCol.Caption = "Креслення";
            this.drawingCol.FieldName = "Drawing";
            this.drawingCol.Name = "drawingCol";
            this.drawingCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.drawingCol.Visible = true;
            this.drawingCol.VisibleIndex = 0;
            // 
            // assemblyNameCol
            // 
            this.assemblyNameCol.Caption = "Проект";
            this.assemblyNameCol.FieldName = "Name";
            this.assemblyNameCol.Name = "assemblyNameCol";
            this.assemblyNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.assemblyNameCol.Visible = true;
            this.assemblyNameCol.VisibleIndex = 1;
            this.assemblyNameCol.Width = 300;
            // 
            // orderDateCol
            // 
            this.orderDateCol.Caption = "Дата";
            this.orderDateCol.FieldName = "DateCreated";
            this.orderDateCol.Name = "orderDateCol";
            this.orderDateCol.OptionsColumn.AllowEdit = false;
            this.orderDateCol.OptionsColumn.AllowFocus = false;
            this.orderDateCol.Visible = true;
            this.orderDateCol.VisibleIndex = 2;
            this.orderDateCol.Width = 87;
            // 
            // orderNumberCol
            // 
            this.orderNumberCol.Caption = "№ заказу";
            this.orderNumberCol.FieldName = "OrderNumber";
            this.orderNumberCol.Name = "orderNumberCol";
            this.orderNumberCol.OptionsColumn.AllowEdit = false;
            this.orderNumberCol.OptionsColumn.AllowFocus = false;
            this.orderNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.orderNumberCol.Width = 84;
            // 
            // contractorCol
            // 
            this.contractorCol.Caption = "Контрагент";
            this.contractorCol.FieldName = "ContractorName";
            this.contractorCol.Name = "contractorCol";
            this.contractorCol.OptionsColumn.AllowEdit = false;
            this.contractorCol.OptionsColumn.AllowFocus = false;
            this.contractorCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.contractorCol.Visible = true;
            this.contractorCol.VisibleIndex = 3;
            this.contractorCol.Width = 169;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(814, 124);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(15, 13);
            this.labelControl3.TabIndex = 48;
            this.labelControl3.Text = "від";
            // 
            // assemblyDateEdit
            // 
            this.assemblyDateEdit.EditValue = null;
            this.assemblyDateEdit.Enabled = false;
            this.assemblyDateEdit.Location = new System.Drawing.Point(835, 121);
            this.assemblyDateEdit.Name = "assemblyDateEdit";
            this.assemblyDateEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.assemblyDateEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.assemblyDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.assemblyDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.assemblyDateEdit.Size = new System.Drawing.Size(185, 20);
            this.assemblyDateEdit.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 57);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 13);
            this.labelControl6.TabIndex = 46;
            this.labelControl6.Text = "Номер проекта";
            // 
            // assemblyGeneralNameTBox
            // 
            this.assemblyGeneralNameTBox.Location = new System.Drawing.Point(12, 121);
            this.assemblyGeneralNameTBox.Name = "assemblyGeneralNameTBox";
            this.assemblyGeneralNameTBox.Properties.MaxLength = 20;
            this.assemblyGeneralNameTBox.Size = new System.Drawing.Size(796, 20);
            this.assemblyGeneralNameTBox.TabIndex = 5;
            this.assemblyGeneralNameTBox.TextChanged += new System.EventHandler(this.assemblyGeneralNameTBox_TextChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(118, 13);
            this.labelControl4.TabIndex = 51;
            this.labelControl4.Text = "Найменування проекту";
            // 
            // assemblyNameTBox
            // 
            this.assemblyNameTBox.Location = new System.Drawing.Point(12, 211);
            this.assemblyNameTBox.Name = "assemblyNameTBox";
            this.assemblyNameTBox.Properties.MaxLength = 190;
            this.assemblyNameTBox.Size = new System.Drawing.Size(1008, 20);
            this.assemblyNameTBox.TabIndex = 7;
            this.assemblyNameTBox.TextChanged += new System.EventHandler(this.assemblyNameTBox_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 192);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 13);
            this.labelControl1.TabIndex = 53;
            this.labelControl1.Text = "Найменування вузла";
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(12, 251);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 54;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(945, 241);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 56;
            this.closeBtn.Text = "Відміна";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(864, 241);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 55;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // projectValidationProvider
            // 
            this.projectValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            this.projectValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.projectValidationProvider_ValidationFailed);
            this.projectValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.projectValidationProvider_ValidationSucceeded);
            // 
            // orderNumberEdit
            // 
            this.orderNumberEdit.Location = new System.Drawing.Point(12, 31);
            this.orderNumberEdit.Name = "orderNumberEdit";
            this.orderNumberEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.orderNumberEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderNumberEdit.Properties.ImmediatePopup = true;
            this.orderNumberEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.orderNumberEdit.Properties.PopupFormSize = new System.Drawing.Size(1000, 0);
            this.orderNumberEdit.Properties.View = this.gridView1;
            this.orderNumberEdit.Size = new System.Drawing.Size(1006, 20);
            this.orderNumberEdit.TabIndex = 75;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Не вказано заказ";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.projectValidationProvider.SetValidationRule(this.orderNumberEdit, conditionValidationRule1);
            this.orderNumberEdit.EditValueChanged += new System.EventHandler(this.orderNumberEdit_EditValueChanged_1);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.SearchInPreview = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "№ заказу";
            this.gridColumn1.FieldName = "OrderNumber";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 84;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Дата";
            this.gridColumn2.FieldName = "OrderDate";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 87;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Контрагент";
            this.gridColumn3.FieldName = "Name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 169;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Проект";
            this.gridColumn4.FieldName = "Drawing";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 150;
            // 
            // assemblyDrawingTBox
            // 
            this.assemblyDrawingTBox.Location = new System.Drawing.Point(12, 166);
            this.assemblyDrawingTBox.Name = "assemblyDrawingTBox";
            this.assemblyDrawingTBox.Properties.MaxLength = 20;
            this.assemblyDrawingTBox.Size = new System.Drawing.Size(883, 20);
            this.assemblyDrawingTBox.TabIndex = 6;
            this.assemblyDrawingTBox.TextChanged += new System.EventHandler(this.assemblyDrawingTBox_TextChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 147);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 13);
            this.labelControl5.TabIndex = 60;
            this.labelControl5.Text = "Номер вузла";
            // 
            // generalAssemblyAsAssemblyCheck
            // 
            this.generalAssemblyAsAssemblyCheck.Location = new System.Drawing.Point(926, 167);
            this.generalAssemblyAsAssemblyCheck.Name = "generalAssemblyAsAssemblyCheck";
            this.generalAssemblyAsAssemblyCheck.Properties.Caption = "відсутні вузли";
            this.generalAssemblyAsAssemblyCheck.Size = new System.Drawing.Size(94, 19);
            this.generalAssemblyAsAssemblyCheck.TabIndex = 61;
            this.generalAssemblyAsAssemblyCheck.CheckedChanged += new System.EventHandler(this.generalAssemblyAsAssemblyCheck_CheckedChanged);
            this.generalAssemblyAsAssemblyCheck.EditValueChanged += new System.EventHandler(this.generalAssemblyAsAssemblyCheck_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 63;
            this.labelControl2.Text = "Номер заказа";
            // 
            // ProjectDetailEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1030, 293);
            this.Controls.Add(this.orderNumberEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.generalAssemblyAsAssemblyCheck);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.assemblyDrawingTBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.assemblyNameTBox);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.assemblyGeneralNameTBox);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.assemblyEdit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.assemblyDateEdit);
            this.Controls.Add(this.labelControl6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectDetailEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вироби та вузли";
            ((System.ComponentModel.ISupportInitialize)(this.assemblyEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyGeneralNameTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyNameTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyDrawingTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalAssemblyAsAssemblyCheck.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit assemblyEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn orderNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn orderDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn contractorCol;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit assemblyDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit assemblyGeneralNameTBox;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit assemblyNameTBox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.SimpleButton closeBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider projectValidationProvider;
        private DevExpress.XtraGrid.Columns.GridColumn assemblyNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn drawingCol;
        private DevExpress.XtraEditors.TextEdit assemblyDrawingTBox;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckEdit generalAssemblyAsAssemblyCheck;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit orderNumberEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}