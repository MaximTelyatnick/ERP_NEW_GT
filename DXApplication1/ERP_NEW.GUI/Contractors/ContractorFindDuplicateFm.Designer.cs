namespace ERP_NEW.GUI.Contractors
{
    partial class ContractorFindDuplicateFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractorFindDuplicateFm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.contractorsMainEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.srnCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contractorsReplaceEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.checkBtn = new DevExpress.XtraEditors.SimpleButton();
            this.replaceBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsMainEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsReplaceEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // contractorsMainEdit
            // 
            this.contractorsMainEdit.Location = new System.Drawing.Point(12, 25);
            this.contractorsMainEdit.Name = "contractorsMainEdit";
            this.contractorsMainEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.contractorsMainEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("contractorsMainEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Очистити", null, null, true)});
            this.contractorsMainEdit.Properties.ImmediatePopup = true;
            this.contractorsMainEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.contractorsMainEdit.Properties.PopupFormSize = new System.Drawing.Size(553, 0);
            this.contractorsMainEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.contractorsMainEdit.Properties.View = this.gridLookUpEdit1View;
            this.contractorsMainEdit.Size = new System.Drawing.Size(439, 22);
            this.contractorsMainEdit.TabIndex = 4;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameCol,
            this.srnCol});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsFind.AlwaysVisible = true;
            this.gridLookUpEdit1View.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridLookUpEdit1View.OptionsFind.SearchInPreview = true;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // nameCol
            // 
            this.nameCol.Caption = "Наименування";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.AllowEdit = false;
            this.nameCol.OptionsColumn.AllowFocus = false;
            this.nameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 0;
            this.nameCol.Width = 760;
            // 
            // srnCol
            // 
            this.srnCol.Caption = "Код ЄРДПОУ";
            this.srnCol.FieldName = "Srn";
            this.srnCol.Name = "srnCol";
            this.srnCol.OptionsColumn.AllowEdit = false;
            this.srnCol.OptionsColumn.AllowFocus = false;
            this.srnCol.Visible = true;
            this.srnCol.VisibleIndex = 1;
            this.srnCol.Width = 152;
            // 
            // contractorsReplaceEdit
            // 
            this.contractorsReplaceEdit.Location = new System.Drawing.Point(12, 72);
            this.contractorsReplaceEdit.Name = "contractorsReplaceEdit";
            this.contractorsReplaceEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.contractorsReplaceEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("contractorsReplaceEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Очистити", null, null, true)});
            this.contractorsReplaceEdit.Properties.ImmediatePopup = true;
            this.contractorsReplaceEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.contractorsReplaceEdit.Properties.PopupFormSize = new System.Drawing.Size(553, 0);
            this.contractorsReplaceEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.contractorsReplaceEdit.Properties.View = this.gridView1;
            this.contractorsReplaceEdit.Size = new System.Drawing.Size(439, 22);
            this.contractorsReplaceEdit.TabIndex = 5;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsFind.SearchInPreview = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Наименування";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 760;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Код ЄРДПОУ";
            this.gridColumn2.FieldName = "Srn";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 152;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(12, 100);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(439, 283);
            this.memoEdit1.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(234, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Найменування контрагента  (на який міняємо)";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(224, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Найменування контрагента  (якого міняємо)";
            // 
            // checkBtn
            // 
            this.checkBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.checkBtn.Location = new System.Drawing.Point(12, 389);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(215, 35);
            this.checkBtn.TabIndex = 9;
            this.checkBtn.Text = "Перевірка";
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // replaceBtn
            // 
            this.replaceBtn.Location = new System.Drawing.Point(233, 389);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(218, 35);
            this.replaceBtn.TabIndex = 10;
            this.replaceBtn.Text = "Замінити";
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // ContractorFindDuplicateFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 436);
            this.Controls.Add(this.replaceBtn);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.contractorsReplaceEdit);
            this.Controls.Add(this.contractorsMainEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContractorFindDuplicateFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма пошуку дублікатів контрагентів";
            ((System.ComponentModel.ISupportInitialize)(this.contractorsMainEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorsReplaceEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit contractorsMainEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn srnCol;
        private DevExpress.XtraEditors.GridLookUpEdit contractorsReplaceEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton checkBtn;
        private DevExpress.XtraEditors.SimpleButton replaceBtn;
    }
}