namespace ERP_NEW.GUI.Classifiers
{
    partial class WeldWpsFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeldWpsFm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addItem = new DevExpress.XtraBars.BarButtonItem();
            this.editItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteItem = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.weldWpsGrid = new DevExpress.XtraGrid.GridControl();
            this.weldWpsGridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.wireDiameterCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.seamSizeZCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.seamSizeA = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.connectionTypeCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.wpqrCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.wpsCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.layerMarkCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.materialThicknessCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.weldPositionCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldWpsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldWpsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addItem,
            this.editItem,
            this.deleteItem});
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(69, 151);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.addItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.editItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.deleteItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.Text = "Tools";
            // 
            // addItem
            // 
            this.addItem.Caption = "Додати";
            this.addItem.Glyph = ((System.Drawing.Image)(resources.GetObject("addItem.Glyph")));
            this.addItem.Id = 0;
            this.addItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addItem.LargeGlyph")));
            this.addItem.Name = "addItem";
            this.addItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addItem_ItemClick);
            // 
            // editItem
            // 
            this.editItem.Caption = "Редагувати";
            this.editItem.Glyph = ((System.Drawing.Image)(resources.GetObject("editItem.Glyph")));
            this.editItem.Id = 1;
            this.editItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editItem.LargeGlyph")));
            this.editItem.Name = "editItem";
            this.editItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editItem_ItemClick);
            // 
            // deleteItem
            // 
            this.deleteItem.Caption = "Видалити";
            this.deleteItem.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteItem.Glyph")));
            this.deleteItem.Id = 2;
            this.deleteItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteItem.LargeGlyph")));
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteItem_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(979, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 582);
            this.barDockControlBottom.Size = new System.Drawing.Size(979, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 551);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(979, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 551);
            // 
            // weldWpsGrid
            // 
            this.weldWpsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weldWpsGrid.Location = new System.Drawing.Point(0, 31);
            this.weldWpsGrid.MainView = this.weldWpsGridView;
            this.weldWpsGrid.MenuManager = this.barManager1;
            this.weldWpsGrid.Name = "weldWpsGrid";
            this.weldWpsGrid.Size = new System.Drawing.Size(979, 551);
            this.weldWpsGrid.TabIndex = 4;
            this.weldWpsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.weldWpsGridView});
            // 
            // weldWpsGridView
            // 
            this.weldWpsGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6,
            this.gridBand7});
            this.weldWpsGridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.wireDiameterCol,
            this.seamSizeZCol,
            this.seamSizeA,
            this.connectionTypeCol,
            this.wpqrCol,
            this.wpsCol,
            this.layerMarkCol,
            this.materialThicknessCol,
            this.weldPositionCol});
            this.weldWpsGridView.GridControl = this.weldWpsGrid;
            this.weldWpsGridView.Name = "weldWpsGridView";
            this.weldWpsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.weldWpsGridView.OptionsView.ShowAutoFilterRow = true;
            this.weldWpsGridView.DoubleClick += new System.EventHandler(this.weldWpsGridView_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Ø дроту, мм";
            this.gridBand1.Columns.Add(this.wireDiameterCol);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 75;
            // 
            // wireDiameterCol
            // 
            this.wireDiameterCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.wireDiameterCol.AppearanceHeader.Options.UseFont = true;
            this.wireDiameterCol.AppearanceHeader.Options.UseTextOptions = true;
            this.wireDiameterCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.wireDiameterCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.wireDiameterCol.FieldName = "WireDiameter";
            this.wireDiameterCol.Name = "wireDiameterCol";
            this.wireDiameterCol.OptionsColumn.AllowEdit = false;
            this.wireDiameterCol.OptionsColumn.AllowFocus = false;
            this.wireDiameterCol.OptionsColumn.ShowCaption = false;
            this.wireDiameterCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.wireDiameterCol.Visible = true;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand2.AppearanceHeader.Options.UseFont = true;
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "Розмір шва, мм";
            this.gridBand2.Columns.Add(this.seamSizeZCol);
            this.gridBand2.Columns.Add(this.seamSizeA);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 150;
            // 
            // seamSizeZCol
            // 
            this.seamSizeZCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.seamSizeZCol.AppearanceHeader.Options.UseFont = true;
            this.seamSizeZCol.AppearanceHeader.Options.UseTextOptions = true;
            this.seamSizeZCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.seamSizeZCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.seamSizeZCol.Caption = "z";
            this.seamSizeZCol.FieldName = "SeamSizeZ";
            this.seamSizeZCol.Name = "seamSizeZCol";
            this.seamSizeZCol.OptionsColumn.AllowEdit = false;
            this.seamSizeZCol.OptionsColumn.AllowFocus = false;
            this.seamSizeZCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.seamSizeZCol.Visible = true;
            // 
            // seamSizeA
            // 
            this.seamSizeA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.seamSizeA.AppearanceHeader.Options.UseFont = true;
            this.seamSizeA.AppearanceHeader.Options.UseTextOptions = true;
            this.seamSizeA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.seamSizeA.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.seamSizeA.Caption = "a";
            this.seamSizeA.FieldName = "SeamSizeA";
            this.seamSizeA.Name = "seamSizeA";
            this.seamSizeA.OptionsColumn.AllowEdit = false;
            this.seamSizeA.OptionsColumn.AllowFocus = false;
            this.seamSizeA.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.seamSizeA.Visible = true;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand3.AppearanceHeader.Options.UseFont = true;
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "Тип з\'єднання";
            this.gridBand3.Columns.Add(this.connectionTypeCol);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 75;
            // 
            // connectionTypeCol
            // 
            this.connectionTypeCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.connectionTypeCol.AppearanceHeader.Options.UseFont = true;
            this.connectionTypeCol.AppearanceHeader.Options.UseTextOptions = true;
            this.connectionTypeCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.connectionTypeCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.connectionTypeCol.FieldName = "ConnectionType";
            this.connectionTypeCol.Name = "connectionTypeCol";
            this.connectionTypeCol.OptionsColumn.AllowEdit = false;
            this.connectionTypeCol.OptionsColumn.AllowFocus = false;
            this.connectionTypeCol.OptionsColumn.ShowCaption = false;
            this.connectionTypeCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.connectionTypeCol.Visible = true;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand4.AppearanceHeader.Options.UseFont = true;
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "Номер документу";
            this.gridBand4.Columns.Add(this.wpqrCol);
            this.gridBand4.Columns.Add(this.wpsCol);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 150;
            // 
            // wpqrCol
            // 
            this.wpqrCol.AppearanceCell.BackColor = System.Drawing.Color.Moccasin;
            this.wpqrCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.wpqrCol.AppearanceCell.Options.UseBackColor = true;
            this.wpqrCol.AppearanceCell.Options.UseFont = true;
            this.wpqrCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.wpqrCol.AppearanceHeader.Options.UseFont = true;
            this.wpqrCol.AppearanceHeader.Options.UseTextOptions = true;
            this.wpqrCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.wpqrCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.wpqrCol.Caption = "WPQR";
            this.wpqrCol.FieldName = "Wpqr";
            this.wpqrCol.Name = "wpqrCol";
            this.wpqrCol.OptionsColumn.AllowEdit = false;
            this.wpqrCol.OptionsColumn.AllowFocus = false;
            this.wpqrCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.wpqrCol.Visible = true;
            // 
            // wpsCol
            // 
            this.wpsCol.AppearanceCell.BackColor = System.Drawing.Color.Moccasin;
            this.wpsCol.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.wpsCol.AppearanceCell.Options.UseBackColor = true;
            this.wpsCol.AppearanceCell.Options.UseFont = true;
            this.wpsCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.wpsCol.AppearanceHeader.Options.UseFont = true;
            this.wpsCol.AppearanceHeader.Options.UseTextOptions = true;
            this.wpsCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.wpsCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.wpsCol.Caption = "WPS";
            this.wpsCol.FieldName = "Wps";
            this.wpsCol.Name = "wpsCol";
            this.wpsCol.OptionsColumn.AllowEdit = false;
            this.wpsCol.OptionsColumn.AllowFocus = false;
            this.wpsCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.wpsCol.Visible = true;
            // 
            // gridBand5
            // 
            this.gridBand5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand5.AppearanceHeader.Options.UseFont = true;
            this.gridBand5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand5.Caption = "Кількість шарів";
            this.gridBand5.Columns.Add(this.layerMarkCol);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 75;
            // 
            // layerMarkCol
            // 
            this.layerMarkCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layerMarkCol.AppearanceHeader.Options.UseFont = true;
            this.layerMarkCol.AppearanceHeader.Options.UseTextOptions = true;
            this.layerMarkCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layerMarkCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.layerMarkCol.FieldName = "LayerMark";
            this.layerMarkCol.Name = "layerMarkCol";
            this.layerMarkCol.OptionsColumn.AllowEdit = false;
            this.layerMarkCol.OptionsColumn.AllowFocus = false;
            this.layerMarkCol.OptionsColumn.ShowCaption = false;
            this.layerMarkCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.layerMarkCol.Visible = true;
            // 
            // gridBand6
            // 
            this.gridBand6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand6.AppearanceHeader.Options.UseFont = true;
            this.gridBand6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand6.Caption = "Товщина зварюваного матеріалу t, мм";
            this.gridBand6.Columns.Add(this.materialThicknessCol);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 5;
            this.gridBand6.Width = 75;
            // 
            // materialThicknessCol
            // 
            this.materialThicknessCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.materialThicknessCol.AppearanceHeader.Options.UseFont = true;
            this.materialThicknessCol.AppearanceHeader.Options.UseTextOptions = true;
            this.materialThicknessCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.materialThicknessCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.materialThicknessCol.FieldName = "MaterialThickness";
            this.materialThicknessCol.Name = "materialThicknessCol";
            this.materialThicknessCol.OptionsColumn.AllowEdit = false;
            this.materialThicknessCol.OptionsColumn.AllowFocus = false;
            this.materialThicknessCol.OptionsColumn.ShowCaption = false;
            this.materialThicknessCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.materialThicknessCol.Visible = true;
            // 
            // gridBand7
            // 
            this.gridBand7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridBand7.AppearanceHeader.Options.UseFont = true;
            this.gridBand7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand7.Caption = "Положення зварювання";
            this.gridBand7.Columns.Add(this.weldPositionCol);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.VisibleIndex = 6;
            this.gridBand7.Width = 75;
            // 
            // weldPositionCol
            // 
            this.weldPositionCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.weldPositionCol.AppearanceHeader.Options.UseFont = true;
            this.weldPositionCol.AppearanceHeader.Options.UseTextOptions = true;
            this.weldPositionCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.weldPositionCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.weldPositionCol.FieldName = "WeldPosition";
            this.weldPositionCol.Name = "weldPositionCol";
            this.weldPositionCol.OptionsColumn.AllowEdit = false;
            this.weldPositionCol.OptionsColumn.AllowFocus = false;
            this.weldPositionCol.OptionsColumn.ShowCaption = false;
            this.weldPositionCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.weldPositionCol.Visible = true;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // WeldWpsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 582);
            this.Controls.Add(this.weldWpsGrid);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "WeldWpsFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Довідник WPS";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldWpsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldWpsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem addItem;
        private DevExpress.XtraBars.BarButtonItem editItem;
        private DevExpress.XtraBars.BarButtonItem deleteItem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl weldWpsGrid;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView weldWpsGridView;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn wireDiameterCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn seamSizeZCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn seamSizeA;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn connectionTypeCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn wpqrCol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn wpsCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn layerMarkCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn materialThicknessCol;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn weldPositionCol;
    }
}