namespace ERP_NEW.GUI.Accounting
{
    partial class CalcWithBuyersCpvSelectFm
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
            this.dictionaryTree = new DevExpress.XtraTreeList.TreeList();
            this.codeCPVCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.groupingCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.descriptionUA = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.selectBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryTree)).BeginInit();
            this.SuspendLayout();
            // 
            // dictionaryTree
            // 
            this.dictionaryTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dictionaryTree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.codeCPVCol,
            this.groupingCol,
            this.descriptionUA});
            this.dictionaryTree.Cursor = System.Windows.Forms.Cursors.Default;
            this.dictionaryTree.KeyFieldName = "Id";
            this.dictionaryTree.Location = new System.Drawing.Point(0, 0);
            this.dictionaryTree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dictionaryTree.Name = "dictionaryTree";
            this.dictionaryTree.OptionsBehavior.EnableFiltering = true;
            this.dictionaryTree.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.dictionaryTree.OptionsView.ShowAutoFilterRow = true;
            this.dictionaryTree.ParentFieldName = "ParentId";
            this.dictionaryTree.Size = new System.Drawing.Size(964, 446);
            this.dictionaryTree.TabIndex = 2;
            // 
            // codeCPVCol
            // 
            this.codeCPVCol.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.codeCPVCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.codeCPVCol.AppearanceHeader.Options.UseFont = true;
            this.codeCPVCol.AppearanceHeader.Options.UseForeColor = true;
            this.codeCPVCol.AppearanceHeader.Options.UseTextOptions = true;
            this.codeCPVCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.codeCPVCol.Caption = "Код товару";
            this.codeCPVCol.FieldName = "CodeCPV";
            this.codeCPVCol.Name = "codeCPVCol";
            this.codeCPVCol.OptionsColumn.AllowEdit = false;
            this.codeCPVCol.OptionsColumn.AllowFocus = false;
            this.codeCPVCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraTreeList.Columns.AutoFilterCondition.Contains;
            this.codeCPVCol.OptionsFilter.ShowEmptyDateFilter = true;
            this.codeCPVCol.Visible = true;
            this.codeCPVCol.VisibleIndex = 0;
            this.codeCPVCol.Width = 359;
            // 
            // groupingCol
            // 
            this.groupingCol.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupingCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.groupingCol.AppearanceHeader.Options.UseFont = true;
            this.groupingCol.AppearanceHeader.Options.UseForeColor = true;
            this.groupingCol.AppearanceHeader.Options.UseTextOptions = true;
            this.groupingCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupingCol.Caption = "Групування";
            this.groupingCol.FieldName = "Grouping";
            this.groupingCol.Name = "groupingCol";
            this.groupingCol.OptionsColumn.AllowEdit = false;
            this.groupingCol.OptionsColumn.AllowFocus = false;
            this.groupingCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraTreeList.Columns.AutoFilterCondition.Contains;
            this.groupingCol.Visible = true;
            this.groupingCol.VisibleIndex = 1;
            this.groupingCol.Width = 442;
            // 
            // descriptionUA
            // 
            this.descriptionUA.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.descriptionUA.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.descriptionUA.AppearanceHeader.Options.UseFont = true;
            this.descriptionUA.AppearanceHeader.Options.UseForeColor = true;
            this.descriptionUA.AppearanceHeader.Options.UseTextOptions = true;
            this.descriptionUA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.descriptionUA.Caption = "Детально";
            this.descriptionUA.FieldName = "DescriptionUA";
            this.descriptionUA.Name = "descriptionUA";
            this.descriptionUA.OptionsColumn.AllowEdit = false;
            this.descriptionUA.OptionsColumn.AllowFocus = false;
            this.descriptionUA.OptionsFilter.AutoFilterCondition = DevExpress.XtraTreeList.Columns.AutoFilterCondition.Contains;
            this.descriptionUA.Visible = true;
            this.descriptionUA.VisibleIndex = 2;
            this.descriptionUA.Width = 460;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(878, 455);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 15;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(797, 455);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 14;
            this.selectBtn.Text = "Вибрати";
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // CalcWithBuyersCpvSelectFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 491);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.dictionaryTree);
            this.Name = "CalcWithBuyersCpvSelectFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Єдиний закупівельний словник ДК 021:2015";
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList dictionaryTree;
        private DevExpress.XtraTreeList.Columns.TreeListColumn codeCPVCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn groupingCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn descriptionUA;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton selectBtn;
    }
}