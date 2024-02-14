namespace ERP_NEW.GUI.OTK
{
    partial class CertificateJournalFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CertificateJournalFm));
            this.certGrid = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addCertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.сertificateNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.certificateDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.manufacturerInfoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.descriptionCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true, DevExpress.XtraSplashScreen.SplashFormStartPosition.Manual, new System.Drawing.Point(0, 0));
            ((System.ComponentModel.ISupportInitialize)(this.certGrid)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // certGrid
            // 
            this.certGrid.ContextMenuStrip = this.contextMenuStrip;
            this.certGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.certGrid.Location = new System.Drawing.Point(0, 0);
            this.certGrid.MainView = this.certGridView;
            this.certGrid.Name = "certGrid";
            this.certGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemMemoEdit1});
            this.certGrid.Size = new System.Drawing.Size(1138, 448);
            this.certGrid.TabIndex = 1;
            this.certGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.certGridView,
            this.gridView1});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.addCertToolStripMenuItem,
            this.editCertToolStripMenuItem,
            this.deleteCertToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(208, 76);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // addCertToolStripMenuItem
            // 
            this.addCertToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCertToolStripMenuItem.Image = global::ERP_NEW.GUI.Accounting.Resources.Add_16x16;
            this.addCertToolStripMenuItem.Name = "addCertToolStripMenuItem";
            this.addCertToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.addCertToolStripMenuItem.Text = "Додати сертифікат ";
            this.addCertToolStripMenuItem.Click += new System.EventHandler(this.addCertToolStripMenuItem_Click);
            // 
            // editCertToolStripMenuItem
            // 
            this.editCertToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editCertToolStripMenuItem.Image = global::ERP_NEW.GUI.XRDesignRibbonControllerResources.RibbonUserDesigner_Edit;
            this.editCertToolStripMenuItem.Name = "editCertToolStripMenuItem";
            this.editCertToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.editCertToolStripMenuItem.Text = "Редагувати сертифікат";
            this.editCertToolStripMenuItem.Click += new System.EventHandler(this.editCertToolStripMenuItem_Click);
            // 
            // deleteCertToolStripMenuItem
            // 
            this.deleteCertToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteCertToolStripMenuItem.Image = global::ERP_NEW.GUI.PrintRibbonControllerResources.RibbonPrintPreview_ClosePreview;
            this.deleteCertToolStripMenuItem.Name = "deleteCertToolStripMenuItem";
            this.deleteCertToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.deleteCertToolStripMenuItem.Text = "Видалити сертифікат";
            // 
            // certGridView
            // 
            this.certGridView.Appearance.Row.Options.UseTextOptions = true;
            this.certGridView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.certGridView.AppearancePrint.Row.Options.UseTextOptions = true;
            this.certGridView.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.certGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.сertificateNumberCol,
            this.certificateDateCol,
            this.gridColumn3,
            this.manufacturerInfoCol,
            this.descriptionCol,
            this.gridColumn1});
            this.certGridView.GridControl = this.certGrid;
            this.certGridView.Name = "certGridView";
            this.certGridView.OptionsView.AllowCellMerge = true;
            this.certGridView.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.certGridView.OptionsView.RowAutoHeight = true;
            this.certGridView.OptionsView.ShowAutoFilterRow = true;
            this.certGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.certGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.certGridView_CustomUnboundColumnData);
            this.certGridView.DoubleClick += new System.EventHandler(this.certGridView_DoubleClick);
            // 
            // сertificateNumberCol
            // 
            this.сertificateNumberCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сertificateNumberCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.сertificateNumberCol.AppearanceHeader.Options.UseFont = true;
            this.сertificateNumberCol.AppearanceHeader.Options.UseForeColor = true;
            this.сertificateNumberCol.Caption = "Номер сертифіката";
            this.сertificateNumberCol.FieldName = "CertificateNumber";
            this.сertificateNumberCol.Name = "сertificateNumberCol";
            this.сertificateNumberCol.OptionsColumn.AllowEdit = false;
            this.сertificateNumberCol.OptionsColumn.AllowFocus = false;
            this.сertificateNumberCol.OptionsColumn.AllowMove = false;
            this.сertificateNumberCol.OptionsColumn.FixedWidth = true;
            this.сertificateNumberCol.OptionsColumn.ReadOnly = true;
            this.сertificateNumberCol.Visible = true;
            this.сertificateNumberCol.VisibleIndex = 0;
            this.сertificateNumberCol.Width = 144;
            // 
            // certificateDateCol
            // 
            this.certificateDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.certificateDateCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.certificateDateCol.AppearanceHeader.Options.UseFont = true;
            this.certificateDateCol.AppearanceHeader.Options.UseForeColor = true;
            this.certificateDateCol.Caption = "Дата реєстрації";
            this.certificateDateCol.FieldName = "CertificateDate";
            this.certificateDateCol.Name = "certificateDateCol";
            this.certificateDateCol.OptionsColumn.AllowEdit = false;
            this.certificateDateCol.OptionsColumn.AllowFocus = false;
            this.certificateDateCol.OptionsColumn.AllowMove = false;
            this.certificateDateCol.OptionsColumn.FixedWidth = true;
            this.certificateDateCol.OptionsColumn.ReadOnly = true;
            this.certificateDateCol.Visible = true;
            this.certificateDateCol.VisibleIndex = 1;
            this.certificateDateCol.Width = 125;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn3.Caption = "Дата завершення дії";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.AllowMove = false;
            this.gridColumn3.OptionsColumn.FixedWidth = true;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 159;
            // 
            // manufacturerInfoCol
            // 
            this.manufacturerInfoCol.AppearanceCell.Options.UseTextOptions = true;
            this.manufacturerInfoCol.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.manufacturerInfoCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturerInfoCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.manufacturerInfoCol.AppearanceHeader.Options.UseFont = true;
            this.manufacturerInfoCol.AppearanceHeader.Options.UseForeColor = true;
            this.manufacturerInfoCol.Caption = "Виробник";
            this.manufacturerInfoCol.ColumnEdit = this.repositoryItemMemoEdit1;
            this.manufacturerInfoCol.FieldName = "ManufacturerInfo";
            this.manufacturerInfoCol.Name = "manufacturerInfoCol";
            this.manufacturerInfoCol.OptionsColumn.AllowEdit = false;
            this.manufacturerInfoCol.OptionsColumn.AllowFocus = false;
            this.manufacturerInfoCol.OptionsColumn.AllowMove = false;
            this.manufacturerInfoCol.OptionsColumn.FixedWidth = true;
            this.manufacturerInfoCol.OptionsColumn.ReadOnly = true;
            this.manufacturerInfoCol.Visible = true;
            this.manufacturerInfoCol.VisibleIndex = 3;
            this.manufacturerInfoCol.Width = 286;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // descriptionCol
            // 
            this.descriptionCol.AppearanceCell.Options.UseTextOptions = true;
            this.descriptionCol.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.descriptionCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.descriptionCol.AppearanceHeader.Options.UseFont = true;
            this.descriptionCol.AppearanceHeader.Options.UseForeColor = true;
            this.descriptionCol.Caption = "Додаткова інформація";
            this.descriptionCol.ColumnEdit = this.repositoryItemMemoEdit1;
            this.descriptionCol.FieldName = "Description";
            this.descriptionCol.Name = "descriptionCol";
            this.descriptionCol.OptionsColumn.AllowEdit = false;
            this.descriptionCol.OptionsColumn.AllowFocus = false;
            this.descriptionCol.OptionsColumn.AllowMove = false;
            this.descriptionCol.OptionsColumn.FixedWidth = true;
            this.descriptionCol.OptionsColumn.ReadOnly = true;
            this.descriptionCol.Visible = true;
            this.descriptionCol.VisibleIndex = 4;
            this.descriptionCol.Width = 321;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Файл";
            this.gridColumn1.ColumnEdit = this.repositoryItemPictureEdit1;
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 85;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTextEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTextEdit2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.certGrid;
            this.gridView1.Name = "gridView1";
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("new_16x16.png", "office2013/actions/new_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/new_16x16.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "new_16x16.png");
            this.imageCollection.InsertGalleryImage("article_32x32.png", "images/support/article_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/article_32x32.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "article_32x32.png");
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // CertificateJournalFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 448);
            this.Controls.Add(this.certGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CertificateJournalFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал сертифікатів";
            ((System.ComponentModel.ISupportInitialize)(this.certGrid)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.certGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl certGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView certGridView;
        private DevExpress.XtraGrid.Columns.GridColumn сertificateNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn certificateDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn manufacturerInfoCol;
        private DevExpress.XtraGrid.Columns.GridColumn descriptionCol;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addCertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCertToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}