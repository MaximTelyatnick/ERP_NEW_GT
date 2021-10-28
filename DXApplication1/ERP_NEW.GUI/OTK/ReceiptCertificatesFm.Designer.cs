namespace ERP_NEW.GUI.OTK
{
    partial class ReceiptCertificatesFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptCertificatesFm));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.showOrdersForDate = new DevExpress.XtraEditors.SimpleButton();
            this.endDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.beginDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.receiptsCertificateVGrid = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.receipt = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.invoiceNum = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.invoiceDate = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.receiptNum = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.orderDate = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.vendorName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.vendorSrn = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.supplierName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.storekeeperName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.otkName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.material = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.nomenclature = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.nomenclatureName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.quantity = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.measure = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.storehouseName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.certificate = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.certificateNumber = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.certificateDate = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.manufacturerInfo = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.description = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.informationRow = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.changesBtn = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.row = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.receiptHistoryOrdersDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsCertificateVGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptHistoryOrdersDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.showOrdersForDate);
            this.panelControl2.Controls.Add(this.endDateEdit);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.beginDateEdit);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1107, 44);
            this.panelControl2.TabIndex = 15;
            // 
            // showOrdersForDate
            // 
            this.showOrdersForDate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.showOrdersForDate.Image = ((System.Drawing.Image)(resources.GetObject("showOrdersForDate.Image")));
            this.showOrdersForDate.Location = new System.Drawing.Point(260, 5);
            this.showOrdersForDate.Name = "showOrdersForDate";
            this.showOrdersForDate.Size = new System.Drawing.Size(42, 38);
            this.showOrdersForDate.TabIndex = 11;
            this.showOrdersForDate.ToolTip = "Показати";
            this.showOrdersForDate.Click += new System.EventHandler(this.showOrdersForDate_Click);
            // 
            // endDateEdit
            // 
            this.endDateEdit.EditValue = null;
            this.endDateEdit.Location = new System.Drawing.Point(154, 12);
            this.endDateEdit.Name = "endDateEdit";
            this.endDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateEdit.Size = new System.Drawing.Size(100, 20);
            this.endDateEdit.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(131, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(13, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "По";
            // 
            // beginDateEdit
            // 
            this.beginDateEdit.EditValue = null;
            this.beginDateEdit.Location = new System.Drawing.Point(25, 12);
            this.beginDateEdit.Name = "beginDateEdit";
            this.beginDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.beginDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.beginDateEdit.Size = new System.Drawing.Size(100, 20);
            this.beginDateEdit.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(6, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "З";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("converttorange_16x16.png", "images/actions/converttorange_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/converttorange_16x16.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "converttorange_16x16.png");
            this.imageCollection1.InsertGalleryImage("properties_16x16.png", "images/setup/properties_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/setup/properties_16x16.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "properties_16x16.png");
            this.imageCollection1.InsertGalleryImage("sendbehindtext_16x16.png", "images/arrange/sendbehindtext_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrange/sendbehindtext_16x16.png"), 2);
            this.imageCollection1.Images.SetKeyName(2, "sendbehindtext_16x16.png");
            this.imageCollection1.InsertGalleryImage("attach_16x16.png", "images/mail/attach_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/attach_16x16.png"), 3);
            this.imageCollection1.Images.SetKeyName(3, "attach_16x16.png");
            this.imageCollection1.InsertGalleryImage("additem_16x16.png", "images/actions/additem_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/additem_16x16.png"), 4);
            this.imageCollection1.Images.SetKeyName(4, "additem_16x16.png");
            this.imageCollection1.InsertGalleryImage("edit_16x16.png", "images/edit/edit_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/edit/edit_16x16.png"), 5);
            this.imageCollection1.Images.SetKeyName(5, "edit_16x16.png");
            this.imageCollection1.InsertGalleryImage("removeitem_16x16.png", "images/actions/removeitem_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/removeitem_16x16.png"), 6);
            this.imageCollection1.Images.SetKeyName(6, "removeitem_16x16.png");
            // 
            // receiptsCertificateVGrid
            // 
            this.receiptsCertificateVGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.receiptsCertificateVGrid.BandsInterval = 5;
            this.receiptsCertificateVGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.receiptsCertificateVGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiptsCertificateVGrid.FindPanelVisible = true;
            this.receiptsCertificateVGrid.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.receiptsCertificateVGrid.ImageList = this.imageCollection1;
            this.receiptsCertificateVGrid.Location = new System.Drawing.Point(0, 48);
            this.receiptsCertificateVGrid.LookAndFeel.UseDefaultLookAndFeel = false;
            this.receiptsCertificateVGrid.LookAndFeel.UseWindowsXPTheme = true;
            this.receiptsCertificateVGrid.Name = "receiptsCertificateVGrid";
            this.receiptsCertificateVGrid.OptionsFind.FindMode = DevExpress.XtraVerticalGrid.FindMode.FindClick;
            this.receiptsCertificateVGrid.OptionsFind.FindNullPrompt = "Текст для пошуку";
            this.receiptsCertificateVGrid.OptionsFind.Visibility = DevExpress.XtraVerticalGrid.FindPanelVisibility.Always;
            this.receiptsCertificateVGrid.OptionsLayout.StoreAppearance = true;
            this.receiptsCertificateVGrid.OptionsMenu.EnableContextMenu = true;
            this.receiptsCertificateVGrid.OptionsView.FixRowHeaderPanelWidth = true;
            this.receiptsCertificateVGrid.OptionsView.MinRowAutoHeight = 20;
            this.receiptsCertificateVGrid.RecordsInterval = 10;
            this.receiptsCertificateVGrid.RecordWidth = 182;
            this.receiptsCertificateVGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoEdit2,
            this.repositoryItemMemoEdit3,
            this.repositoryItemMemoEdit4});
            this.receiptsCertificateVGrid.RowHeaderWidth = 188;
            this.receiptsCertificateVGrid.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.receipt,
            this.material,
            this.certificate});
            this.receiptsCertificateVGrid.ScrollsStyle.BackColor = System.Drawing.Color.White;
            this.receiptsCertificateVGrid.ScrollsStyle.ForeColor = System.Drawing.Color.White;
            this.receiptsCertificateVGrid.Size = new System.Drawing.Size(1111, 705);
            this.receiptsCertificateVGrid.TabIndex = 1;
            this.receiptsCertificateVGrid.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView;
            this.receiptsCertificateVGrid.UseDisabledStatePainter = false;
            this.receiptsCertificateVGrid.CustomUnboundData += new DevExpress.XtraVerticalGrid.Events.CustomDataEventHandler(this.receiptsCertificateVGrid_CustomUnboundData);
            this.receiptsCertificateVGrid.Layout += new System.Windows.Forms.LayoutEventHandler(this.receiptsCertificateVGrid_Layout);
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Додати", ((short)(0)), 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Редагувати", ((short)(1)), 5),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Видалити", ((short)(2)), 6)});
            this.repositoryItemImageComboBox1.LargeImages = this.imageCollection1;
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemImageComboBox1.SelectedValueChanged += new System.EventHandler(this.repositoryItemImageComboBox1_SelectedValueChanged);
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemPictureEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.NullText = "Відсутнє зображення";
            this.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image;
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            this.repositoryItemPictureEdit1.DoubleClick += new System.EventHandler(this.repositoryItemPictureEdit1_DoubleClick);
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.ForeColor = System.Drawing.Color.White;
            this.repositoryItemMemoEdit1.Appearance.Options.UseForeColor = true;
            this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            this.repositoryItemMemoEdit1.ReadOnly = true;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemMemoEdit2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            this.repositoryItemMemoEdit2.ReadOnly = true;
            // 
            // repositoryItemMemoEdit3
            // 
            this.repositoryItemMemoEdit3.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemMemoEdit3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.repositoryItemMemoEdit3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit3.Name = "repositoryItemMemoEdit3";
            this.repositoryItemMemoEdit3.ReadOnly = true;
            // 
            // repositoryItemMemoEdit4
            // 
            this.repositoryItemMemoEdit4.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemMemoEdit4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.repositoryItemMemoEdit4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit4.Name = "repositoryItemMemoEdit4";
            this.repositoryItemMemoEdit4.ReadOnly = true;
            // 
            // receipt
            // 
            this.receipt.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.invoiceNum,
            this.invoiceDate,
            this.receiptNum,
            this.orderDate,
            this.vendorName,
            this.vendorSrn,
            this.supplierName,
            this.storekeeperName,
            this.otkName});
            this.receipt.Name = "receipt";
            this.receipt.Properties.Caption = "Надходження";
            this.receipt.Properties.ImageIndex = 0;
            this.receipt.Properties.Padding = new System.Windows.Forms.Padding(3);
            // 
            // invoiceNum
            // 
            this.invoiceNum.Height = 20;
            this.invoiceNum.Name = "invoiceNum";
            this.invoiceNum.Properties.Caption = "№ накладної";
            this.invoiceNum.Properties.DrawEditorBorder = false;
            this.invoiceNum.Properties.FieldName = "InvoiceNum";
            this.invoiceNum.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.invoiceNum.Properties.ReadOnly = true;
            // 
            // invoiceDate
            // 
            this.invoiceDate.Height = 20;
            this.invoiceDate.Name = "invoiceDate";
            this.invoiceDate.Properties.Caption = "Дата накладної";
            this.invoiceDate.Properties.FieldName = "InvoiceDate";
            this.invoiceDate.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.invoiceDate.Properties.ReadOnly = true;
            // 
            // receiptNum
            // 
            this.receiptNum.Name = "receiptNum";
            this.receiptNum.Properties.Caption = "№ надходження";
            this.receiptNum.Properties.FieldName = "ReceiptNum";
            this.receiptNum.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.receiptNum.Properties.ReadOnly = true;
            // 
            // orderDate
            // 
            this.orderDate.Name = "orderDate";
            this.orderDate.Properties.Caption = "Дата надходження";
            this.orderDate.Properties.FieldName = "OrderDate";
            this.orderDate.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.orderDate.Properties.ReadOnly = true;
            // 
            // vendorName
            // 
            this.vendorName.Height = 55;
            this.vendorName.Name = "vendorName";
            this.vendorName.Properties.Caption = "Контрагент";
            this.vendorName.Properties.FieldName = "VendorName";
            this.vendorName.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.vendorName.Properties.ReadOnly = true;
            this.vendorName.Properties.RowEdit = this.repositoryItemMemoEdit1;
            // 
            // vendorSrn
            // 
            this.vendorSrn.Name = "vendorSrn";
            this.vendorSrn.Properties.Caption = "Код ЄДРПОУ";
            this.vendorSrn.Properties.FieldName = "VendorSrn";
            this.vendorSrn.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.vendorSrn.Properties.ReadOnly = true;
            // 
            // supplierName
            // 
            this.supplierName.Height = 22;
            this.supplierName.Name = "supplierName";
            this.supplierName.Properties.Caption = "Постачальник";
            this.supplierName.Properties.FieldName = "SupplierName";
            this.supplierName.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.supplierName.Properties.ReadOnly = true;
            // 
            // storekeeperName
            // 
            this.storekeeperName.Height = 23;
            this.storekeeperName.Name = "storekeeperName";
            this.storekeeperName.Properties.Caption = "Комірник";
            this.storekeeperName.Properties.FieldName = "StorekeeperName";
            this.storekeeperName.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.storekeeperName.Properties.ReadOnly = true;
            // 
            // otkName
            // 
            this.otkName.Height = 21;
            this.otkName.Name = "otkName";
            this.otkName.Properties.Caption = "ОТК";
            this.otkName.Properties.FieldName = "OtkName";
            this.otkName.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.otkName.Properties.ReadOnly = true;
            // 
            // material
            // 
            this.material.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.nomenclature,
            this.nomenclatureName,
            this.quantity,
            this.measure,
            this.storehouseName});
            this.material.Name = "material";
            this.material.Properties.Caption = "Матеріал";
            this.material.Properties.ImageIndex = 1;
            this.material.Properties.Padding = new System.Windows.Forms.Padding(0);
            // 
            // nomenclature
            // 
            this.nomenclature.Name = "nomenclature";
            this.nomenclature.Properties.Caption = "Номенкл. номер";
            this.nomenclature.Properties.FieldName = "Nomenclature";
            this.nomenclature.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.nomenclature.Properties.ReadOnly = true;
            // 
            // nomenclatureName
            // 
            this.nomenclatureName.Height = 46;
            this.nomenclatureName.Name = "nomenclatureName";
            this.nomenclatureName.Properties.Caption = "Наименування";
            this.nomenclatureName.Properties.FieldName = "NomenclatureName";
            this.nomenclatureName.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.nomenclatureName.Properties.ReadOnly = true;
            this.nomenclatureName.Properties.RowEdit = this.repositoryItemMemoEdit2;
            // 
            // quantity
            // 
            this.quantity.Name = "quantity";
            this.quantity.Properties.Caption = "Кількість";
            this.quantity.Properties.FieldName = "Quantity";
            this.quantity.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.quantity.Properties.ReadOnly = true;
            // 
            // measure
            // 
            this.measure.Name = "measure";
            this.measure.Properties.Caption = "Од.вим.";
            this.measure.Properties.FieldName = "Measure";
            this.measure.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.measure.Properties.ReadOnly = true;
            // 
            // storehouseName
            // 
            this.storehouseName.Name = "storehouseName";
            this.storehouseName.Properties.Caption = "Склад";
            this.storehouseName.Properties.FieldName = "StorehouseName";
            this.storehouseName.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.storehouseName.Properties.ReadOnly = true;
            // 
            // certificate
            // 
            this.certificate.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.certificateNumber,
            this.certificateDate,
            this.manufacturerInfo,
            this.description,
            this.informationRow,
            this.changesBtn,
            this.row});
            this.certificate.Name = "certificate";
            this.certificate.Properties.Caption = "Сертифікат";
            this.certificate.Properties.ImageIndex = 2;
            this.certificate.Properties.Padding = new System.Windows.Forms.Padding(0);
            // 
            // certificateNumber
            // 
            this.certificateNumber.Name = "certificateNumber";
            this.certificateNumber.Properties.Caption = "№ сертифікату/паспорту";
            this.certificateNumber.Properties.FieldName = "CertificateNumber";
            this.certificateNumber.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.certificateNumber.Properties.ReadOnly = true;
            // 
            // certificateDate
            // 
            this.certificateDate.Name = "certificateDate";
            this.certificateDate.Properties.Caption = "Дата";
            this.certificateDate.Properties.FieldName = "CertificateDate";
            this.certificateDate.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.certificateDate.Properties.ReadOnly = true;
            // 
            // manufacturerInfo
            // 
            this.manufacturerInfo.Height = 48;
            this.manufacturerInfo.Name = "manufacturerInfo";
            this.manufacturerInfo.Properties.Caption = "Виробник";
            this.manufacturerInfo.Properties.FieldName = "ManufacturerInfo";
            this.manufacturerInfo.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.manufacturerInfo.Properties.ReadOnly = true;
            this.manufacturerInfo.Properties.RowEdit = this.repositoryItemMemoEdit3;
            // 
            // description
            // 
            this.description.Height = 49;
            this.description.Name = "description";
            this.description.Properties.Caption = "Додаткова інформація";
            this.description.Properties.FieldName = "Description";
            this.description.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.description.Properties.ReadOnly = true;
            this.description.Properties.RowEdit = this.repositoryItemMemoEdit4;
            // 
            // informationRow
            // 
            this.informationRow.Height = 20;
            this.informationRow.Name = "informationRow";
            this.informationRow.Properties.Caption = "Файл";
            this.informationRow.Properties.FieldName = "fff";
            this.informationRow.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.informationRow.Properties.RowEdit = this.repositoryItemPictureEdit1;
            this.informationRow.Properties.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            // 
            // changesBtn
            // 
            this.changesBtn.Name = "changesBtn";
            this.changesBtn.Properties.FieldName = "kkk";
            this.changesBtn.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.changesBtn.Properties.RowEdit = this.repositoryItemImageComboBox1;
            this.changesBtn.Properties.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            // 
            // row
            // 
            this.row.Name = "row";
            this.row.Properties.Padding = new System.Windows.Forms.Padding(0);
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1111, 48);
            this.panelControl1.TabIndex = 0;
            // 
            // receiptHistoryOrdersDTOBindingSource
            // 
            this.receiptHistoryOrdersDTOBindingSource.DataSource = typeof(ERP_NEW.BLL.DTO.SelectedDTO.ReceiptHistoryOrdersDTO);
            // 
            // ReceiptCertificatesFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 753);
            this.Controls.Add(this.receiptsCertificateVGrid);
            this.Controls.Add(this.panelControl1);
            this.Name = "ReceiptCertificatesFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Надходження з сертифікатами";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptsCertificateVGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receiptHistoryOrdersDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraVerticalGrid.VGridControl receiptsCertificateVGrid;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DateEdit endDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit beginDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit4;
        private DevExpress.XtraEditors.SimpleButton showOrdersForDate;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource receiptHistoryOrdersDTOBindingSource;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow receipt;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow invoiceNum;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow invoiceDate;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow receiptNum;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow orderDate;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow vendorName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow vendorSrn;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow supplierName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow storekeeperName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow otkName;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow material;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow nomenclature;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow nomenclatureName;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow quantity;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow measure;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow storehouseName;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow certificate;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow certificateNumber;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow certificateDate;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow manufacturerInfo;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow description;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow informationRow;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow changesBtn;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row;
    }
}