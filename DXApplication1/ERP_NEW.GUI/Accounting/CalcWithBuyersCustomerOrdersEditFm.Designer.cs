namespace ERP_NEW.GUI.Accounting
{
    partial class CalcWithBuyersCustomerOrdersEditFm
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
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.customerOrdersEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.customerOrderNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerOrderDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detailsCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contractorNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.assemblyDrawingCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.designerNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.customerOrderValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(591, 60);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 21);
            this.cancelBtn.TabIndex = 78;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(510, 60);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 21);
            this.saveBtn.TabIndex = 77;
            this.saveBtn.Text = "Вибрати";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // customerOrdersEdit
            // 
            this.customerOrdersEdit.Location = new System.Drawing.Point(12, 12);
            this.customerOrdersEdit.Name = "customerOrdersEdit";
            this.customerOrdersEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.customerOrdersEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customerOrdersEdit.Properties.ImmediatePopup = true;
            this.customerOrdersEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.customerOrdersEdit.Properties.PopupFormSize = new System.Drawing.Size(553, 0);
            this.customerOrdersEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.customerOrdersEdit.Properties.View = this.gridLookUpEdit1View;
            this.customerOrdersEdit.Size = new System.Drawing.Size(654, 20);
            this.customerOrdersEdit.TabIndex = 76;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule1.ErrorText = "Виберіть заказ";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule1.Value1 = 0;
            this.customerOrderValidationProvider.SetValidationRule(this.customerOrdersEdit, conditionValidationRule1);
            this.customerOrdersEdit.EditValueChanged += new System.EventHandler(this.customerOrdersEdit_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.customerOrderNumberCol,
            this.customerOrderDateCol,
            this.detailsCol,
            this.contractorNameCol,
            this.assemblyDrawingCol,
            this.designerNameCol});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridLookUpEdit1View.OptionsFind.AlwaysVisible = true;
            this.gridLookUpEdit1View.OptionsFind.SearchInPreview = true;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // customerOrderNumberCol
            // 
            this.customerOrderNumberCol.Caption = "Номер заказу";
            this.customerOrderNumberCol.FieldName = "OrderNumber";
            this.customerOrderNumberCol.Name = "customerOrderNumberCol";
            this.customerOrderNumberCol.OptionsColumn.AllowEdit = false;
            this.customerOrderNumberCol.OptionsColumn.AllowFocus = false;
            this.customerOrderNumberCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.customerOrderNumberCol.Visible = true;
            this.customerOrderNumberCol.VisibleIndex = 0;
            // 
            // customerOrderDateCol
            // 
            this.customerOrderDateCol.Caption = "Дата заказу";
            this.customerOrderDateCol.FieldName = "OrderDate";
            this.customerOrderDateCol.Name = "customerOrderDateCol";
            this.customerOrderDateCol.OptionsColumn.AllowEdit = false;
            this.customerOrderDateCol.OptionsColumn.AllowFocus = false;
            this.customerOrderDateCol.Visible = true;
            this.customerOrderDateCol.VisibleIndex = 1;
            // 
            // detailsCol
            // 
            this.detailsCol.Caption = "Найменування";
            this.detailsCol.FieldName = "Details";
            this.detailsCol.Name = "detailsCol";
            this.detailsCol.OptionsColumn.AllowEdit = false;
            this.detailsCol.OptionsColumn.AllowFocus = false;
            this.detailsCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.detailsCol.Visible = true;
            this.detailsCol.VisibleIndex = 2;
            // 
            // contractorNameCol
            // 
            this.contractorNameCol.Caption = "Контрагент";
            this.contractorNameCol.FieldName = "ContractorName";
            this.contractorNameCol.Name = "contractorNameCol";
            this.contractorNameCol.OptionsColumn.AllowEdit = false;
            this.contractorNameCol.OptionsColumn.AllowFocus = false;
            this.contractorNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.contractorNameCol.Visible = true;
            this.contractorNameCol.VisibleIndex = 3;
            // 
            // assemblyDrawingCol
            // 
            this.assemblyDrawingCol.Caption = "Проект";
            this.assemblyDrawingCol.FieldName = "Drawing";
            this.assemblyDrawingCol.Name = "assemblyDrawingCol";
            this.assemblyDrawingCol.OptionsColumn.AllowEdit = false;
            this.assemblyDrawingCol.OptionsColumn.AllowFocus = false;
            this.assemblyDrawingCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.assemblyDrawingCol.Visible = true;
            this.assemblyDrawingCol.VisibleIndex = 4;
            // 
            // designerNameCol
            // 
            this.designerNameCol.Caption = "Розробник";
            this.designerNameCol.FieldName = "DesignerName";
            this.designerNameCol.Name = "designerNameCol";
            this.designerNameCol.OptionsColumn.AllowEdit = false;
            this.designerNameCol.OptionsColumn.AllowFocus = false;
            this.designerNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.designerNameCol.Visible = true;
            this.designerNameCol.VisibleIndex = 5;
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(12, 64);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(249, 13);
            this.validateLbl.TabIndex = 79;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // customerOrderValidationProvider
            // 
            this.customerOrderValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            this.customerOrderValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.customerOrderValidationProvider_ValidationFailed);
            this.customerOrderValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.customerOrderValidationProvider_ValidationSucceeded);
            // 
            // CalcWithBuyersCustomerOrdersEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(676, 95);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.customerOrdersEdit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcWithBuyersCustomerOrdersEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заказ";
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.GridLookUpEdit customerOrdersEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn customerOrderNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn customerOrderDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn detailsCol;
        private DevExpress.XtraGrid.Columns.GridColumn contractorNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn assemblyDrawingCol;
        private DevExpress.XtraGrid.Columns.GridColumn designerNameCol;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider customerOrderValidationProvider;
    }
}