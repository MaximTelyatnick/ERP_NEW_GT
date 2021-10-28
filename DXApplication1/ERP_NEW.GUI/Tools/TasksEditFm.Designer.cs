namespace ERP_NEW.GUI.Tools
{
    partial class TasksEditFm
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
            this.tasksTreeList = new DevExpress.XtraTreeList.TreeList();
            this.checkedCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.taskCaptionCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.TaskNameCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.accessRightCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.priceAttributeCol = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(628, 519);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(532, 519);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tasksTreeList
            // 
            this.tasksTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.checkedCol,
            this.taskCaptionCol,
            this.TaskNameCol,
            this.accessRightCol,
            this.priceAttributeCol});
            this.tasksTreeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.tasksTreeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.tasksTreeList.Location = new System.Drawing.Point(0, 0);
            this.tasksTreeList.Name = "tasksTreeList";
            this.tasksTreeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3});
            this.tasksTreeList.Size = new System.Drawing.Size(715, 513);
            this.tasksTreeList.TabIndex = 13;
            // 
            // checkedCol
            // 
            this.checkedCol.AppearanceHeader.Options.UseTextOptions = true;
            this.checkedCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.checkedCol.Caption = "*";
            this.checkedCol.ColumnEdit = this.repositoryItemCheckEdit1;
            this.checkedCol.FieldName = "Checked";
            this.checkedCol.Name = "checkedCol";
            this.checkedCol.Visible = true;
            this.checkedCol.VisibleIndex = 0;
            this.checkedCol.Width = 59;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.CheckStateChanged += new System.EventHandler(this.repositoryItemCheckEdit1_CheckStateChanged);
            // 
            // taskCaptionCol
            // 
            this.taskCaptionCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.taskCaptionCol.AppearanceHeader.Options.UseFont = true;
            this.taskCaptionCol.AppearanceHeader.Options.UseTextOptions = true;
            this.taskCaptionCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.taskCaptionCol.Caption = "Найменування";
            this.taskCaptionCol.FieldName = "TaskCaption";
            this.taskCaptionCol.Name = "taskCaptionCol";
            this.taskCaptionCol.OptionsColumn.AllowEdit = false;
            this.taskCaptionCol.Visible = true;
            this.taskCaptionCol.VisibleIndex = 1;
            this.taskCaptionCol.Width = 272;
            // 
            // TaskNameCol
            // 
            this.TaskNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TaskNameCol.AppearanceHeader.Options.UseFont = true;
            this.TaskNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.TaskNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TaskNameCol.Caption = "Код";
            this.TaskNameCol.FieldName = "TaskName";
            this.TaskNameCol.Name = "TaskNameCol";
            this.TaskNameCol.OptionsColumn.AllowEdit = false;
            this.TaskNameCol.Visible = true;
            this.TaskNameCol.VisibleIndex = 2;
            this.TaskNameCol.Width = 169;
            // 
            // accessRightCol
            // 
            this.accessRightCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.accessRightCol.AppearanceHeader.Options.UseFont = true;
            this.accessRightCol.AppearanceHeader.Options.UseTextOptions = true;
            this.accessRightCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.accessRightCol.Caption = "Читання";
            this.accessRightCol.ColumnEdit = this.repositoryItemCheckEdit2;
            this.accessRightCol.FieldName = "AccessRight";
            this.accessRightCol.Name = "accessRightCol";
            this.accessRightCol.Visible = true;
            this.accessRightCol.VisibleIndex = 3;
            this.accessRightCol.Width = 87;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // priceAttributeCol
            // 
            this.priceAttributeCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.priceAttributeCol.AppearanceHeader.Options.UseFont = true;
            this.priceAttributeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.priceAttributeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.priceAttributeCol.Caption = "Ціна";
            this.priceAttributeCol.ColumnEdit = this.repositoryItemCheckEdit3;
            this.priceAttributeCol.FieldName = "PriceAttribute";
            this.priceAttributeCol.Name = "priceAttributeCol";
            this.priceAttributeCol.Visible = true;
            this.priceAttributeCol.VisibleIndex = 4;
            this.priceAttributeCol.Width = 87;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            this.repositoryItemCheckEdit3.ValueChecked = 1;
            this.repositoryItemCheckEdit3.ValueUnchecked = 0;
            // 
            // TasksEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 554);
            this.Controls.Add(this.tasksTreeList);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TasksEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Головне меню";
            ((System.ComponentModel.ISupportInitialize)(this.tasksTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraTreeList.TreeList tasksTreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn checkedCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn taskCaptionCol;
        private DevExpress.XtraTreeList.Columns.TreeListColumn TaskNameCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn accessRightCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn priceAttributeCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
    }
}