namespace ERP_NEW.GUI.OTK
{
    partial class CertificatePassFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CertificatePassFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.beginDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.endDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.showBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.certificatePassGrid = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bandedGridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.receipt = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.InvoiceNum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.InvoiceDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ReceiptNum = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.OrderDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.VendorName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.VendorSrn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.SupplierName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.StorekeeperName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.OtkName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.material = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.Nomenclature = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.NomenclatureName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Quantity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Measure = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.StorehouseName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.certificate = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.CertificateNumber = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CertificateDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ManufactureInfo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Description = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.InformationRow = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificatePassGrid)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.beginDateEdit,
            this.endDateEdit,
            this.showBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1345, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // beginDateEdit
            // 
            this.beginDateEdit.Caption = "З    ";
            this.beginDateEdit.Edit = this.repositoryItemDateEdit1;
            this.beginDateEdit.EditWidth = 100;
            this.beginDateEdit.Id = 1;
            this.beginDateEdit.Name = "beginDateEdit";
            this.beginDateEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // endDateEdit
            // 
            this.endDateEdit.Caption = "по  ";
            this.endDateEdit.Edit = this.repositoryItemDateEdit2;
            this.endDateEdit.EditWidth = 100;
            this.endDateEdit.Id = 2;
            this.endDateEdit.Name = "endDateEdit";
            this.endDateEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            // showBtn
            // 
            this.showBtn.Caption = "Пошук";
            this.showBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("showBtn.Glyph")));
            this.showBtn.Id = 3;
            this.showBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("showBtn.LargeGlyph")));
            this.showBtn.Name = "showBtn";
            this.showBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.showBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.beginDateEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.endDateEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.showBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // certificatePassGrid
            // 
            this.certificatePassGrid.ContextMenuStrip = this.contextMenuStrip;
            this.certificatePassGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.certificatePassGrid.Location = new System.Drawing.Point(0, 95);
            this.certificatePassGrid.MainView = this.bandedGridView;
            this.certificatePassGrid.MenuManager = this.ribbonControl1;
            this.certificatePassGrid.Name = "certificatePassGrid";
            this.certificatePassGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.certificatePassGrid.Size = new System.Drawing.Size(1345, 371);
            this.certificatePassGrid.TabIndex = 5;
            this.certificatePassGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStripMenuItem,
            this.editStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(135, 48);
            // 
            // addStripMenuItem
            // 
            this.addStripMenuItem.Image = global::ERP_NEW.GUI.Accounting.Resources.Add_16x16;
            this.addStripMenuItem.Name = "addStripMenuItem";
            this.addStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addStripMenuItem.Text = "Додати";
            this.addStripMenuItem.Click += new System.EventHandler(this.addStripMenuItem_Click);
            // 
            // editStripMenuItem
            // 
            this.editStripMenuItem.Image = global::ERP_NEW.GUI.XRDesignRibbonControllerResources.RibbonUserDesigner_Edit;
            this.editStripMenuItem.Name = "editStripMenuItem";
            this.editStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.editStripMenuItem.Text = "Редагувати";
            this.editStripMenuItem.Click += new System.EventHandler(this.editStripMenuItem_Click);
            // 
            // bandedGridView
            // 
            this.bandedGridView.Appearance.BandPanel.BackColor = System.Drawing.Color.Bisque;
            this.bandedGridView.Appearance.BandPanel.Options.UseBackColor = true;
            this.bandedGridView.Appearance.Row.Options.UseTextOptions = true;
            this.bandedGridView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.bandedGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.receipt,
            this.material,
            this.certificate});
            this.bandedGridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.InvoiceNum,
            this.InvoiceDate,
            this.ReceiptNum,
            this.OrderDate,
            this.VendorName,
            this.VendorSrn,
            this.SupplierName,
            this.StorekeeperName,
            this.OtkName,
            this.Nomenclature,
            this.NomenclatureName,
            this.Quantity,
            this.Measure,
            this.StorehouseName,
            this.CertificateNumber,
            this.CertificateDate,
            this.ManufactureInfo,
            this.Description,
            this.InformationRow});
            this.bandedGridView.GridControl = this.certificatePassGrid;
            this.bandedGridView.Name = "bandedGridView";
            this.bandedGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.bandedGridView.OptionsFind.AlwaysVisible = true;
            this.bandedGridView.OptionsView.ShowFooter = true;
            this.bandedGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.bandedGridView_CustomUnboundColumnData);
            this.bandedGridView.DoubleClick += new System.EventHandler(this.bandedGridView_DoubleClick);
            // 
            // receipt
            // 
            this.receipt.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.receipt.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.receipt.AppearanceHeader.Options.UseFont = true;
            this.receipt.AppearanceHeader.Options.UseForeColor = true;
            this.receipt.AppearanceHeader.Options.UseTextOptions = true;
            this.receipt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.receipt.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.receipt.Caption = "Надходження";
            this.receipt.Columns.Add(this.InvoiceNum);
            this.receipt.Columns.Add(this.InvoiceDate);
            this.receipt.Columns.Add(this.ReceiptNum);
            this.receipt.Columns.Add(this.OrderDate);
            this.receipt.Columns.Add(this.VendorName);
            this.receipt.Columns.Add(this.VendorSrn);
            this.receipt.Columns.Add(this.SupplierName);
            this.receipt.Columns.Add(this.StorekeeperName);
            this.receipt.Columns.Add(this.OtkName);
            this.receipt.Name = "receipt";
            this.receipt.VisibleIndex = 0;
            this.receipt.Width = 675;
            // 
            // InvoiceNum
            // 
            this.InvoiceNum.Caption = "№ накладної";
            this.InvoiceNum.FieldName = "InvoiceNum";
            this.InvoiceNum.Name = "InvoiceNum";
            this.InvoiceNum.OptionsColumn.AllowFocus = false;
            this.InvoiceNum.OptionsColumn.ReadOnly = true;
            this.InvoiceNum.Visible = true;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.Caption = "Дата накладної";
            this.InvoiceDate.FieldName = "InvoiceDate";
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.OptionsColumn.AllowFocus = false;
            this.InvoiceDate.OptionsColumn.ReadOnly = true;
            this.InvoiceDate.Visible = true;
            // 
            // ReceiptNum
            // 
            this.ReceiptNum.Caption = "№ надходження";
            this.ReceiptNum.FieldName = "ReceiptNum";
            this.ReceiptNum.Name = "ReceiptNum";
            this.ReceiptNum.OptionsColumn.AllowFocus = false;
            this.ReceiptNum.OptionsColumn.ReadOnly = true;
            this.ReceiptNum.Visible = true;
            // 
            // OrderDate
            // 
            this.OrderDate.AppearanceCell.Options.UseTextOptions = true;
            this.OrderDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.OrderDate.Caption = "Дата надходження";
            this.OrderDate.FieldName = "OrderDate";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.OptionsColumn.AllowFocus = false;
            this.OrderDate.OptionsColumn.ReadOnly = true;
            this.OrderDate.Visible = true;
            // 
            // VendorName
            // 
            this.VendorName.AppearanceCell.Options.UseTextOptions = true;
            this.VendorName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VendorName.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show;
            this.VendorName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.VendorName.AppearanceHeader.Options.UseTextOptions = true;
            this.VendorName.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show;
            this.VendorName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.VendorName.AutoFillDown = true;
            this.VendorName.Caption = "Контрагент";
            this.VendorName.FieldName = "VendorName";
            this.VendorName.Name = "VendorName";
            this.VendorName.OptionsColumn.AllowFocus = false;
            this.VendorName.OptionsColumn.ReadOnly = true;
            this.VendorName.Visible = true;
            // 
            // VendorSrn
            // 
            this.VendorSrn.Caption = "Код ЄД РПОУ";
            this.VendorSrn.FieldName = "VendorSrn";
            this.VendorSrn.Name = "VendorSrn";
            this.VendorSrn.OptionsColumn.AllowFocus = false;
            this.VendorSrn.OptionsColumn.ReadOnly = true;
            this.VendorSrn.Visible = true;
            // 
            // SupplierName
            // 
            this.SupplierName.Caption = "Постачальник";
            this.SupplierName.FieldName = "SupplierName";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.OptionsColumn.AllowFocus = false;
            this.SupplierName.OptionsColumn.ReadOnly = true;
            this.SupplierName.Visible = true;
            // 
            // StorekeeperName
            // 
            this.StorekeeperName.Caption = "Комірник";
            this.StorekeeperName.FieldName = "StorekeeperName";
            this.StorekeeperName.Name = "StorekeeperName";
            this.StorekeeperName.OptionsColumn.AllowFocus = false;
            this.StorekeeperName.OptionsColumn.ReadOnly = true;
            this.StorekeeperName.Visible = true;
            // 
            // OtkName
            // 
            this.OtkName.Caption = "ОТК";
            this.OtkName.FieldName = "OtkName";
            this.OtkName.Name = "OtkName";
            this.OtkName.OptionsColumn.AllowFocus = false;
            this.OtkName.OptionsColumn.ReadOnly = true;
            this.OtkName.Visible = true;
            // 
            // material
            // 
            this.material.AppearanceHeader.BackColor2 = System.Drawing.Color.Moccasin;
            this.material.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.material.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.material.AppearanceHeader.Options.UseFont = true;
            this.material.AppearanceHeader.Options.UseForeColor = true;
            this.material.AppearanceHeader.Options.UseTextOptions = true;
            this.material.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.material.Caption = "Матеріали";
            this.material.Columns.Add(this.Nomenclature);
            this.material.Columns.Add(this.NomenclatureName);
            this.material.Columns.Add(this.Quantity);
            this.material.Columns.Add(this.Measure);
            this.material.Columns.Add(this.StorehouseName);
            this.material.Name = "material";
            this.material.VisibleIndex = 1;
            this.material.Width = 375;
            // 
            // Nomenclature
            // 
            this.Nomenclature.AppearanceCell.Options.UseTextOptions = true;
            this.Nomenclature.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Nomenclature.AppearanceHeader.Options.UseTextOptions = true;
            this.Nomenclature.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Nomenclature.Caption = "Наменклатурний №";
            this.Nomenclature.FieldName = "Nomenclature";
            this.Nomenclature.Name = "Nomenclature";
            this.Nomenclature.OptionsColumn.AllowFocus = false;
            this.Nomenclature.OptionsColumn.ReadOnly = true;
            this.Nomenclature.Visible = true;
            // 
            // NomenclatureName
            // 
            this.NomenclatureName.Caption = "Найменування";
            this.NomenclatureName.FieldName = "NomenclatureName";
            this.NomenclatureName.Name = "NomenclatureName";
            this.NomenclatureName.OptionsColumn.AllowFocus = false;
            this.NomenclatureName.OptionsColumn.ReadOnly = true;
            this.NomenclatureName.Visible = true;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Кількість";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.OptionsColumn.AllowFocus = false;
            this.Quantity.OptionsColumn.ReadOnly = true;
            this.Quantity.Visible = true;
            // 
            // Measure
            // 
            this.Measure.Caption = "Од. вимір.";
            this.Measure.FieldName = "Measure";
            this.Measure.Name = "Measure";
            this.Measure.OptionsColumn.AllowFocus = false;
            this.Measure.OptionsColumn.ReadOnly = true;
            this.Measure.Visible = true;
            // 
            // StorehouseName
            // 
            this.StorehouseName.Caption = "Склад";
            this.StorehouseName.FieldName = "StorehouseName";
            this.StorehouseName.Name = "StorehouseName";
            this.StorehouseName.OptionsColumn.AllowFocus = false;
            this.StorehouseName.OptionsColumn.ReadOnly = true;
            this.StorehouseName.Visible = true;
            // 
            // certificate
            // 
            this.certificate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.certificate.AppearanceHeader.ForeColor = System.Drawing.Color.Navy;
            this.certificate.AppearanceHeader.Options.UseFont = true;
            this.certificate.AppearanceHeader.Options.UseForeColor = true;
            this.certificate.AppearanceHeader.Options.UseTextOptions = true;
            this.certificate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.certificate.Caption = "Сертифікати";
            this.certificate.Columns.Add(this.CertificateNumber);
            this.certificate.Columns.Add(this.CertificateDate);
            this.certificate.Columns.Add(this.ManufactureInfo);
            this.certificate.Columns.Add(this.Description);
            this.certificate.Columns.Add(this.InformationRow);
            this.certificate.MinWidth = 30;
            this.certificate.Name = "certificate";
            this.certificate.VisibleIndex = 2;
            this.certificate.Width = 375;
            // 
            // CertificateNumber
            // 
            this.CertificateNumber.Caption = "№ сертифіката";
            this.CertificateNumber.FieldName = "CertificateNumber";
            this.CertificateNumber.Name = "CertificateNumber";
            this.CertificateNumber.OptionsColumn.AllowFocus = false;
            this.CertificateNumber.OptionsColumn.ReadOnly = true;
            this.CertificateNumber.Visible = true;
            // 
            // CertificateDate
            // 
            this.CertificateDate.Caption = "Дата";
            this.CertificateDate.FieldName = "CertificateDate";
            this.CertificateDate.Name = "CertificateDate";
            this.CertificateDate.OptionsColumn.AllowFocus = false;
            this.CertificateDate.OptionsColumn.ReadOnly = true;
            this.CertificateDate.Visible = true;
            // 
            // ManufactureInfo
            // 
            this.ManufactureInfo.Caption = "Виробник";
            this.ManufactureInfo.FieldName = "ManufactureInfo";
            this.ManufactureInfo.Name = "ManufactureInfo";
            this.ManufactureInfo.OptionsColumn.AllowFocus = false;
            this.ManufactureInfo.OptionsColumn.ReadOnly = true;
            this.ManufactureInfo.Visible = true;
            // 
            // Description
            // 
            this.Description.Caption = "Додаткова інф.";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.OptionsColumn.AllowFocus = false;
            this.Description.OptionsColumn.ReadOnly = true;
            this.Description.Visible = true;
            // 
            // InformationRow
            // 
            this.InformationRow.Caption = "Файл";
            this.InformationRow.ColumnEdit = this.repositoryItemPictureEdit1;
            this.InformationRow.FieldName = "fff";
            this.InformationRow.Image = ((System.Drawing.Image)(resources.GetObject("InformationRow.Image")));
            this.InformationRow.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.InformationRow.Name = "InformationRow";
            this.InformationRow.OptionsColumn.AllowFocus = false;
            this.InformationRow.OptionsColumn.ReadOnly = true;
            this.InformationRow.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.InformationRow.Visible = true;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.NullText = "Зображення відсутнє";
            this.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image;
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            this.repositoryItemPictureEdit1.DoubleClick += new System.EventHandler(this.repositoryItemPictureEdit1_DoubleClick);
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.Form = this;
            this.tabFormDefaultManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1345, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 466);
            this.barDockControlBottom.Size = new System.Drawing.Size(1345, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 466);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1345, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 466);
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
            // CertificatePassFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 466);
            this.Controls.Add(this.certificatePassGrid);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CertificatePassFm";
            this.Text = "CertificatePassFm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificatePassGrid)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarEditItem beginDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarEditItem endDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem showBtn;
        private DevExpress.XtraGrid.GridControl certificatePassGrid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn InvoiceNum;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn InvoiceDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ReceiptNum;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn OrderDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn VendorName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn VendorSrn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn SupplierName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn StorekeeperName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn OtkName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Nomenclature;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn NomenclatureName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Quantity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Measure;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn StorehouseName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CertificateNumber;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CertificateDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ManufactureInfo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Description;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn InformationRow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStripMenuItem;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand receipt;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand material;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand certificate;
    }
}