namespace ERP_NEW.GUI.OTK
{
    partial class WeldAttestationPersonsFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeldAttestationPersonsFm));
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            this.personsGrid = new DevExpress.XtraGrid.GridControl();
            this.personsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.checkedCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.empNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fioCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.professionCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departmentCol = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.personsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(838, 714);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(87, 28);
            this.cancelBtn.TabIndex = 15;
            this.cancelBtn.Text = "Відмінити";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(743, 714);
            this.okBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(87, 28);
            this.okBtn.TabIndex = 14;
            this.okBtn.Text = "Вибрати";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // personsGrid
            // 
            this.personsGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.personsGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.personsGrid.Location = new System.Drawing.Point(0, 0);
            this.personsGrid.MainView = this.personsGridView;
            this.personsGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.personsGrid.Name = "personsGrid";
            this.personsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.personsGrid.Size = new System.Drawing.Size(939, 698);
            this.personsGrid.TabIndex = 16;
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
            this.departmentCol});
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
            this.checkedCol.Caption = "*";
            this.checkedCol.ColumnEdit = this.repositoryItemCheckEdit1;
            this.checkedCol.FieldName = "CheckForDelete";
            this.checkedCol.Image = ((System.Drawing.Image)(resources.GetObject("checkedCol.Image")));
            this.checkedCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.checkedCol.Name = "checkedCol";
            this.checkedCol.OptionsColumn.ShowCaption = false;
            this.checkedCol.Visible = true;
            this.checkedCol.VisibleIndex = 0;
            this.checkedCol.Width = 34;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // empNumberCol
            // 
            this.empNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.empNumberCol.AppearanceHeader.Options.UseFont = true;
            this.empNumberCol.AppearanceHeader.Options.UseTextOptions = true;
            this.empNumberCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.empNumberCol.Caption = "Таб. номер";
            this.empNumberCol.FieldName = "AccountNumber";
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
            this.fioCol.FieldName = "EmployeesFio";
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
            // WeldAttestationPersonsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 757);
            this.Controls.Add(this.personsGrid);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeldAttestationPersonsFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Працівники";
            ((System.ComponentModel.ISupportInitialize)(this.personsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton okBtn;
        private DevExpress.XtraGrid.GridControl personsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView personsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn checkedCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn empNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn fioCol;
        private DevExpress.XtraGrid.Columns.GridColumn professionCol;
        private DevExpress.XtraGrid.Columns.GridColumn departmentCol;
    }
}