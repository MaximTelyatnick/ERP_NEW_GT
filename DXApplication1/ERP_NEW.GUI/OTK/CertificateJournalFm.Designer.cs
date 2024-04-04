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
            this.selectCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.сertificateNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.certificateDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.certificateDateEndCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.manufacturerInfoCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.descriptionCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fileCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.fioCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.showCertificateExpirationCheck = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.beginDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.endDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.showCertBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.certGrid)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
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
            this.certGrid.Size = new System.Drawing.Size(1244, 448);
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
            this.deleteCertToolStripMenuItem,
            this.selectCertificateToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(208, 98);
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
            this.deleteCertToolStripMenuItem.Click += new System.EventHandler(this.deleteCertToolStripMenuItem_Click);
            // 
            // selectCertificateToolStripMenuItem
            // 
            this.selectCertificateToolStripMenuItem.Image = global::ERP_NEW.GUI.PrintRibbonControllerResources.RibbonPrintPreview_ZoomLarge;
            this.selectCertificateToolStripMenuItem.Name = "selectCertificateToolStripMenuItem";
            this.selectCertificateToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.selectCertificateToolStripMenuItem.Text = "Обрати сертифікат";
            this.selectCertificateToolStripMenuItem.Click += new System.EventHandler(this.selectCertificateToolStripMenuItem_Click);
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
            this.certificateDateEndCol,
            this.manufacturerInfoCol,
            this.descriptionCol,
            this.fileCol,
            this.fioCol});
            this.certGridView.GridControl = this.certGrid;
            this.certGridView.Name = "certGridView";
            this.certGridView.OptionsView.AllowGlyphSkinning = true;
            this.certGridView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.certGridView.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.certGridView.OptionsView.RowAutoHeight = true;
            this.certGridView.OptionsView.ShowAutoFilterRow = true;
            this.certGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.certGridView.RowSeparatorHeight = 1;
            this.certGridView.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.certGridView_RowStyle);
            this.certGridView.ColumnFilterChanged += new System.EventHandler(this.certGridView_ColumnFilterChanged);
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
            this.сertificateNumberCol.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.сertificateNumberCol.Name = "сertificateNumberCol";
            this.сertificateNumberCol.OptionsColumn.AllowEdit = false;
            this.сertificateNumberCol.OptionsColumn.AllowFocus = false;
            this.сertificateNumberCol.OptionsColumn.AllowMove = false;
            this.сertificateNumberCol.OptionsColumn.FixedWidth = true;
            this.сertificateNumberCol.OptionsColumn.ReadOnly = true;
            this.сertificateNumberCol.OptionsEditForm.Caption = "ссс";
            this.сertificateNumberCol.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
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
            // certificateDateEndCol
            // 
            this.certificateDateEndCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.certificateDateEndCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.certificateDateEndCol.AppearanceHeader.Options.UseFont = true;
            this.certificateDateEndCol.AppearanceHeader.Options.UseForeColor = true;
            this.certificateDateEndCol.Caption = "Дата завершення дії";
            this.certificateDateEndCol.FieldName = "CertificateDateEnd";
            this.certificateDateEndCol.Name = "certificateDateEndCol";
            this.certificateDateEndCol.OptionsColumn.AllowEdit = false;
            this.certificateDateEndCol.OptionsColumn.AllowFocus = false;
            this.certificateDateEndCol.OptionsColumn.AllowMove = false;
            this.certificateDateEndCol.OptionsColumn.FixedWidth = true;
            this.certificateDateEndCol.OptionsColumn.ReadOnly = true;
            this.certificateDateEndCol.Visible = true;
            this.certificateDateEndCol.VisibleIndex = 2;
            this.certificateDateEndCol.Width = 159;
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
            // fileCol
            // 
            this.fileCol.AppearanceCell.Options.UseTextOptions = true;
            this.fileCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fileCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.fileCol.AppearanceHeader.Options.UseFont = true;
            this.fileCol.AppearanceHeader.Options.UseForeColor = true;
            this.fileCol.AppearanceHeader.Options.UseTextOptions = true;
            this.fileCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fileCol.Caption = "Файл";
            this.fileCol.ColumnEdit = this.repositoryItemPictureEdit1;
            this.fileCol.FieldName = "gridColumn1";
            this.fileCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.fileCol.Name = "fileCol";
            this.fileCol.OptionsColumn.AllowEdit = false;
            this.fileCol.OptionsColumn.AllowFocus = false;
            this.fileCol.OptionsColumn.AllowMove = false;
            this.fileCol.OptionsColumn.FixedWidth = true;
            this.fileCol.OptionsColumn.ReadOnly = true;
            this.fileCol.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.fileCol.Visible = true;
            this.fileCol.VisibleIndex = 5;
            this.fileCol.Width = 85;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            // 
            // fioCol
            // 
            this.fioCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioCol.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.fioCol.AppearanceHeader.Options.UseFont = true;
            this.fioCol.AppearanceHeader.Options.UseForeColor = true;
            this.fioCol.AppearanceHeader.Options.UseTextOptions = true;
            this.fioCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.fioCol.Caption = "Додав сертифікат ";
            this.fioCol.FieldName = "UserFio";
            this.fioCol.Name = "fioCol";
            this.fioCol.OptionsColumn.AllowEdit = false;
            this.fioCol.OptionsColumn.AllowFocus = false;
            this.fioCol.OptionsColumn.AllowMove = false;
            this.fioCol.Visible = true;
            this.fioCol.VisibleIndex = 6;
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
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.showCertificateExpirationCheck,
            this.beginDateEdit,
            this.endDateEdit,
            this.showCertBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1244, 31);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // showCertificateExpirationCheck
            // 
            this.showCertificateExpirationCheck.Caption = "Відображати сертифікати у яких сплив термін дії";
            this.showCertificateExpirationCheck.Edit = this.repositoryItemCheckEdit1;
            this.showCertificateExpirationCheck.Id = 2;
            this.showCertificateExpirationCheck.Name = "showCertificateExpirationCheck";
            this.showCertificateExpirationCheck.EditValueChanged += new System.EventHandler(this.showCertificateExpirationCheck_EditValueChanged);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // beginDateEdit
            // 
            this.beginDateEdit.Caption = "З";
            this.beginDateEdit.Edit = this.repositoryItemDateEdit1;
            this.beginDateEdit.EditWidth = 100;
            this.beginDateEdit.Id = 3;
            this.beginDateEdit.Name = "beginDateEdit";
            this.beginDateEdit.EditValueChanged += new System.EventHandler(this.beginDateEdit_EditValueChanged);
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // endDateEdit
            // 
            this.endDateEdit.Caption = "до   ";
            this.endDateEdit.Edit = this.repositoryItemDateEdit2;
            this.endDateEdit.EditWidth = 100;
            this.endDateEdit.Id = 4;
            this.endDateEdit.Name = "endDateEdit";
            this.endDateEdit.EditValueChanged += new System.EventHandler(this.endDateEdit_EditValueChanged);
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // showCertBtn
            // 
            this.showCertBtn.Caption = "Відобразити";
            this.showCertBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("showCertBtn.Glyph")));
            this.showCertBtn.Id = 5;
            this.showCertBtn.Name = "showCertBtn";
            this.showCertBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showCertBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.beginDateEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.endDateEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.showCertBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.showCertificateExpirationCheck);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // CertificateJournalFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 448);
            this.Controls.Add(this.ribbonControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl certGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView certGridView;
        private DevExpress.XtraGrid.Columns.GridColumn сertificateNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn certificateDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn certificateDateEndCol;
        private DevExpress.XtraGrid.Columns.GridColumn manufacturerInfoCol;
        private DevExpress.XtraGrid.Columns.GridColumn descriptionCol;
        private DevExpress.XtraGrid.Columns.GridColumn fileCol;
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
        private System.Windows.Forms.ToolStripMenuItem selectCertificateToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn fioCol;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarEditItem showCertificateExpirationCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarEditItem beginDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem endDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarButtonItem showCertBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}