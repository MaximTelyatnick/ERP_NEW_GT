namespace ERP_NEW.GUI.Tools
{
    partial class UsersByRolesEditFm
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
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.usersByRolesGrid = new DevExpress.XtraGrid.GridControl();
            this.usersByRolesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.checkedCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.empNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fioCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.professionCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departmentCol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersByRolesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersByRolesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(767, 573);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Відмінити";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(686, 573);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // usersByRolesGrid
            // 
            this.usersByRolesGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersByRolesGrid.Location = new System.Drawing.Point(0, 0);
            this.usersByRolesGrid.MainView = this.usersByRolesGridView;
            this.usersByRolesGrid.Name = "usersByRolesGrid";
            this.usersByRolesGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.usersByRolesGrid.Size = new System.Drawing.Size(854, 567);
            this.usersByRolesGrid.TabIndex = 11;
            this.usersByRolesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.usersByRolesGridView});
            // 
            // usersByRolesGridView
            // 
            this.usersByRolesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.checkedCol,
            this.empNumberCol,
            this.fioCol,
            this.professionCol,
            this.departmentCol});
            this.usersByRolesGridView.GridControl = this.usersByRolesGrid;
            this.usersByRolesGridView.Name = "usersByRolesGridView";
            this.usersByRolesGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.usersByRolesGridView.OptionsView.ShowAutoFilterRow = true;
            this.usersByRolesGridView.OptionsView.ShowGroupPanel = false;
            // 
            // checkedCol
            // 
            this.checkedCol.AppearanceHeader.Options.UseTextOptions = true;
            this.checkedCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.checkedCol.Caption = "*";
            this.checkedCol.ColumnEdit = this.repositoryItemCheckEdit1;
            this.checkedCol.FieldName = "Checked";
            this.checkedCol.Image = global::ERP_NEW.GUI.Properties.Resources.checkbox2_16x16;
            this.checkedCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.checkedCol.Name = "checkedCol";
            this.checkedCol.Visible = true;
            this.checkedCol.VisibleIndex = 0;
            this.checkedCol.Width = 34;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.DisplayValueChecked = "1";
            this.repositoryItemCheckEdit1.DisplayValueUnchecked = "0";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = "1";
            this.repositoryItemCheckEdit1.ValueUnchecked = "0";
            this.repositoryItemCheckEdit1.CheckStateChanged += new System.EventHandler(this.repositoryItemCheckEdit1_CheckStateChanged);
            // 
            // empNumberCol
            // 
            this.empNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.empNumberCol.AppearanceHeader.Options.UseFont = true;
            this.empNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.empNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.empNumberCol.Caption = "Таб. номер";
            this.empNumberCol.FieldName = "EmployeeNumber";
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
            // UsersByRolesEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 608);
            this.Controls.Add(this.usersByRolesGrid);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsersByRolesEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Користувачі";
            ((System.ComponentModel.ISupportInitialize)(this.usersByRolesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersByRolesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraGrid.GridControl usersByRolesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView usersByRolesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn checkedCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn empNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn fioCol;
        private DevExpress.XtraGrid.Columns.GridColumn professionCol;
        private DevExpress.XtraGrid.Columns.GridColumn departmentCol;
    }
}