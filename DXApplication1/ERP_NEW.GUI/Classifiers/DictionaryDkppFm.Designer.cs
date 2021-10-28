namespace ERP_NEW.GUI.Classifiers
{
    partial class DictionaryDkppFm
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
            this.сodeUKTVCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.descriptionUACol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.codeUKTVCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryTree)).BeginInit();
            this.SuspendLayout();
            // 
            // dictionaryTree
            // 
            this.dictionaryTree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.сodeUKTVCol,
            this.descriptionUACol,
            this.codeUKTVCol});
            this.dictionaryTree.Cursor = System.Windows.Forms.Cursors.Default;
            this.dictionaryTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dictionaryTree.KeyFieldName = "Id";
            this.dictionaryTree.Location = new System.Drawing.Point(0, 0);
            this.dictionaryTree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dictionaryTree.Name = "dictionaryTree";
            this.dictionaryTree.OptionsBehavior.EnableFiltering = true;
            this.dictionaryTree.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart;
            this.dictionaryTree.OptionsView.ShowAutoFilterRow = true;
            this.dictionaryTree.ParentFieldName = "ParentId";
            this.dictionaryTree.Size = new System.Drawing.Size(1157, 330);
            this.dictionaryTree.TabIndex = 1;
            // 
            // сodeUKTVCol
            // 
            this.сodeUKTVCol.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.сodeUKTVCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.сodeUKTVCol.AppearanceHeader.Options.UseFont = true;
            this.сodeUKTVCol.AppearanceHeader.Options.UseForeColor = true;
            this.сodeUKTVCol.AppearanceHeader.Options.UseTextOptions = true;
            this.сodeUKTVCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.сodeUKTVCol.Caption = "Код товару";
            this.сodeUKTVCol.FieldName = "CodeDKPP";
            this.сodeUKTVCol.Name = "сodeUKTVCol";
            this.сodeUKTVCol.OptionsColumn.AllowEdit = false;
            this.сodeUKTVCol.OptionsColumn.AllowFocus = false;
            this.сodeUKTVCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraTreeList.Columns.AutoFilterCondition.Contains;
            this.сodeUKTVCol.OptionsFilter.ShowEmptyDateFilter = true;
            this.сodeUKTVCol.Visible = true;
            this.сodeUKTVCol.VisibleIndex = 0;
            this.сodeUKTVCol.Width = 382;
            // 
            // descriptionUACol
            // 
            this.descriptionUACol.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.descriptionUACol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.descriptionUACol.AppearanceHeader.Options.UseFont = true;
            this.descriptionUACol.AppearanceHeader.Options.UseForeColor = true;
            this.descriptionUACol.AppearanceHeader.Options.UseTextOptions = true;
            this.descriptionUACol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.descriptionUACol.Caption = "Опис";
            this.descriptionUACol.FieldName = "DescriptionUA";
            this.descriptionUACol.Name = "descriptionUACol";
            this.descriptionUACol.OptionsColumn.AllowEdit = false;
            this.descriptionUACol.OptionsColumn.AllowFocus = false;
            this.descriptionUACol.OptionsFilter.AutoFilterCondition = DevExpress.XtraTreeList.Columns.AutoFilterCondition.Contains;
            this.descriptionUACol.Visible = true;
            this.descriptionUACol.VisibleIndex = 1;
            this.descriptionUACol.Width = 652;
            // 
            // codeUKTVCol
            // 
            this.codeUKTVCol.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.codeUKTVCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.codeUKTVCol.AppearanceHeader.Options.UseFont = true;
            this.codeUKTVCol.AppearanceHeader.Options.UseForeColor = true;
            this.codeUKTVCol.AppearanceHeader.Options.UseTextOptions = true;
            this.codeUKTVCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.codeUKTVCol.Caption = "Код товару УКТ";
            this.codeUKTVCol.FieldName = "CodeUKTV";
            this.codeUKTVCol.Name = "codeUKTVCol";
            this.codeUKTVCol.OptionsColumn.AllowEdit = false;
            this.codeUKTVCol.OptionsColumn.AllowFocus = false;
            this.codeUKTVCol.Visible = true;
            this.codeUKTVCol.VisibleIndex = 2;
            this.codeUKTVCol.Width = 296;
            // 
            // DictionaryDkppFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 330);
            this.Controls.Add(this.dictionaryTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DictionaryDkppFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Довідник ДКПП";
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList dictionaryTree;
        private DevExpress.XtraTreeList.Columns.TreeListColumn сodeUKTVCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn descriptionUACol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn codeUKTVCol;
    }
}