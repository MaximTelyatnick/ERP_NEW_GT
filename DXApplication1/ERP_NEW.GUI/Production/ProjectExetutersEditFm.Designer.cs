namespace ERP_NEW.GUI.Production
{
    partial class ProjectExetutersEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectExetutersEditFm));
            this.personsGrid = new DevExpress.XtraGrid.GridControl();
            this.personsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.checkedCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.empNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fioCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.professionCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departmentCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.stampNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.beginDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.personsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // personsGrid
            // 
            this.personsGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.personsGrid.Location = new System.Drawing.Point(0, 0);
            this.personsGrid.MainView = this.personsGridView;
            this.personsGrid.Name = "personsGrid";
            this.personsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.personsGrid.Size = new System.Drawing.Size(1171, 567);
            this.personsGrid.TabIndex = 14;
            this.personsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.personsGridView});
            // 
            // personsGridView
            // 
            this.personsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.checkedCol,
            this.empNumberCol,
            this.fioCol,
            this.professionCol,
            this.departmentCol,
            this.stampNumberCol,
            this.beginDateCol});
            this.personsGridView.GridControl = this.personsGrid;
            this.personsGridView.Name = "personsGridView";
            this.personsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.personsGridView.OptionsView.ShowAutoFilterRow = true;
            this.personsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // checkedCol
            // 
            this.checkedCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.checkedCol.AppearanceHeader.Options.UseFont = true;
            this.checkedCol.AppearanceHeader.Options.UseTextOptions = true;
            this.checkedCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.checkedCol.ColumnEdit = this.repositoryItemCheckEdit1;
            this.checkedCol.FieldName = "Checked";
            this.checkedCol.Image = ((System.Drawing.Image)(resources.GetObject("checkedCol.Image")));
            this.checkedCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.checkedCol.Name = "checkedCol";
            this.checkedCol.OptionsColumn.ShowCaption = false;
            this.checkedCol.Visible = true;
            this.checkedCol.VisibleIndex = 0;
            this.checkedCol.Width = 39;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.DisplayValueChecked = "1";
            this.repositoryItemCheckEdit1.DisplayValueUnchecked = "0";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = "1";
            this.repositoryItemCheckEdit1.ValueUnchecked = "0";
            // 
            // empNumberCol
            // 
            this.empNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.empNumberCol.AppearanceHeader.Options.UseFont = true;
            this.empNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.empNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.empNumberCol.Caption = "Таб. номер";
            this.empNumberCol.FieldName = "AccountNumber";
            this.empNumberCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.empNumberCol.Name = "empNumberCol";
            this.empNumberCol.OptionsColumn.AllowEdit = false;
            this.empNumberCol.OptionsColumn.AllowFocus = false;
            this.empNumberCol.Visible = true;
            this.empNumberCol.VisibleIndex = 1;
            this.empNumberCol.Width = 95;
            // 
            // fioCol
            // 
            this.fioCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.fioCol.AppearanceHeader.Options.UseFont = true;
            this.fioCol.AppearanceHeader.Options.UseTextOptions = true;
            this.fioCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fioCol.Caption = "ПІБ";
            this.fioCol.FieldName = "Fio";
            this.fioCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.fioCol.Name = "fioCol";
            this.fioCol.OptionsColumn.AllowEdit = false;
            this.fioCol.OptionsColumn.AllowFocus = false;
            this.fioCol.Visible = true;
            this.fioCol.VisibleIndex = 2;
            this.fioCol.Width = 253;
            // 
            // professionCol
            // 
            this.professionCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.professionCol.AppearanceHeader.Options.UseFont = true;
            this.professionCol.AppearanceHeader.Options.UseTextOptions = true;
            this.professionCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.professionCol.Caption = "Професія";
            this.professionCol.FieldName = "ProfessionName";
            this.professionCol.Name = "professionCol";
            this.professionCol.OptionsColumn.AllowEdit = false;
            this.professionCol.OptionsColumn.AllowFocus = false;
            this.professionCol.Visible = true;
            this.professionCol.VisibleIndex = 3;
            this.professionCol.Width = 232;
            // 
            // departmentCol
            // 
            this.departmentCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.departmentCol.AppearanceHeader.Options.UseFont = true;
            this.departmentCol.AppearanceHeader.Options.UseTextOptions = true;
            this.departmentCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.departmentCol.Caption = "Підрозділ";
            this.departmentCol.FieldName = "DepartmentName";
            this.departmentCol.Name = "departmentCol";
            this.departmentCol.Visible = true;
            this.departmentCol.VisibleIndex = 4;
            this.departmentCol.Width = 222;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(1084, 577);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Відмінити";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1003, 577);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // stampNumberCol
            // 
            this.stampNumberCol.AppearanceCell.Options.UseTextOptions = true;
            this.stampNumberCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.stampNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stampNumberCol.AppearanceHeader.Options.UseFont = true;
            this.stampNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.stampNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.stampNumberCol.Caption = "Номер клейма";
            this.stampNumberCol.FieldName = "StampNumber";
            this.stampNumberCol.Name = "stampNumberCol";
            this.stampNumberCol.Visible = true;
            this.stampNumberCol.VisibleIndex = 5;
            this.stampNumberCol.Width = 116;
            // 
            // beginDateCol
            // 
            this.beginDateCol.AppearanceCell.Options.UseTextOptions = true;
            this.beginDateCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.beginDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginDateCol.AppearanceHeader.Options.UseFont = true;
            this.beginDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.beginDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.beginDateCol.Caption = "Дата видачі";
            this.beginDateCol.FieldName = "BeginDate";
            this.beginDateCol.Name = "beginDateCol";
            this.beginDateCol.Visible = true;
            this.beginDateCol.VisibleIndex = 6;
            this.beginDateCol.Width = 125;
            // 
            // ProjectExetutersEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 611);
            this.Controls.Add(this.personsGrid);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectExetutersEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Відповідальні особи";
            ((System.ComponentModel.ISupportInitialize)(this.personsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl personsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView personsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn checkedCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn empNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn fioCol;
        private DevExpress.XtraGrid.Columns.GridColumn professionCol;
        private DevExpress.XtraGrid.Columns.GridColumn departmentCol;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraGrid.Columns.GridColumn stampNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn beginDateCol;
    }
}