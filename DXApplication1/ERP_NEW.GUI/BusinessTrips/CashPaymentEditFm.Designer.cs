namespace ERP_NEW.GUI.BusinessTrips
{
    partial class CashPaymentEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashPaymentEditFm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.customerOrdersEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.accountEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.customerOrderNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerOrderDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detailsCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contractorNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.assemblyDrawingCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.designerNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.customerOrdersEdit);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.accountEdit);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(633, 105);
            this.groupControl1.TabIndex = 78;
            this.groupControl1.Text = "Звіт";
            // 
            // customerOrdersEdit
            // 
            this.customerOrdersEdit.Location = new System.Drawing.Point(81, 29);
            this.customerOrdersEdit.Name = "customerOrdersEdit";
            this.customerOrdersEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.customerOrdersEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("customerOrdersEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.customerOrdersEdit.Properties.ImmediatePopup = true;
            this.customerOrdersEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.customerOrdersEdit.Properties.PopupFormSize = new System.Drawing.Size(553, 0);
            this.customerOrdersEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.customerOrdersEdit.Properties.View = this.gridLookUpEdit1View;
            this.customerOrdersEdit.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.customerOrdersEdit_Properties_ButtonClick);
            this.customerOrdersEdit.Size = new System.Drawing.Size(547, 22);
            this.customerOrdersEdit.TabIndex = 1;
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
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 51;
            this.labelControl3.Text = "Заказ:";
            // 
            // accountEdit
            // 
            this.accountEdit.Location = new System.Drawing.Point(81, 64);
            this.accountEdit.Name = "accountEdit";
            this.accountEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.accountEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accountEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Num", "Name3")});
            this.accountEdit.Properties.ImmediatePopup = true;
            this.accountEdit.Properties.PopupSizeable = false;
            this.accountEdit.Properties.PopupWidth = 553;
            this.accountEdit.Properties.ShowHeader = false;
            this.accountEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.accountEdit.Properties.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.accountEdit_Properties_QueryPopUp);
            this.accountEdit.Size = new System.Drawing.Size(130, 20);
            this.accountEdit.TabIndex = 2;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(5, 67);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(70, 13);
            this.labelControl13.TabIndex = 73;
            this.labelControl13.Text = "Рахунок ПДВ:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(569, 123);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(488, 123);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
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
            // CashPaymentEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(658, 159);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashPaymentEditFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагування";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit accountEdit;
        private DevExpress.XtraEditors.LabelControl labelControl13;
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
    }
}