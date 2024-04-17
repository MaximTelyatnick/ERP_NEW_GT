namespace ERP_NEW.GUI.Classifiers
{
    partial class NomenclaturesFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NomenclaturesFm));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.receiptHistoryOrdersDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addMaterialsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editMaterialsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteMaterialsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addGroupBtn = new DevExpress.XtraBars.BarButtonItem();
            this.editGroupBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteGroupBtn = new DevExpress.XtraBars.BarButtonItem();
            this.addSubGroupBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.nomenclatureGroupTree = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.nomenclaturesMaterialGrid = new DevExpress.XtraGrid.GridControl();
            this.nomenclaturesMaterialGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nomenclatureCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitLocalNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.numCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.recieptArchiveGrid = new DevExpress.XtraGrid.GridControl();
            this.recieptArchibeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nomenclatureArchivCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nomenclatureNameArchivCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitLocalNameArchivCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quantityCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.storeHouseNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vendorNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.printNomenclatureBtn = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.receiptHistoryOrdersDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomenclatureGroupTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomenclaturesMaterialGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomenclaturesMaterialGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recieptArchiveGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recieptArchibeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // receiptHistoryOrdersDTOBindingSource
            // 
            this.receiptHistoryOrdersDTOBindingSource.DataSource = typeof(ERP_NEW.BLL.DTO.SelectedDTO.ReceiptHistoryOrdersDTO);
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
            this.addMaterialsBtn,
            this.editMaterialsBtn,
            this.deleteMaterialsBtn,
            this.refreshBtn,
            this.addGroupBtn,
            this.editGroupBtn,
            this.deleteGroupBtn,
            this.addSubGroupBtn,
            this.printNomenclatureBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1339, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // addMaterialsBtn
            // 
            this.addMaterialsBtn.Caption = "Додати";
            this.addMaterialsBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addMaterialsBtn.Glyph")));
            this.addMaterialsBtn.Id = 1;
            this.addMaterialsBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addMaterialsBtn.LargeGlyph")));
            this.addMaterialsBtn.Name = "addMaterialsBtn";
            this.addMaterialsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addMaterialsBtn_ItemClick);
            // 
            // editMaterialsBtn
            // 
            this.editMaterialsBtn.Caption = "Редагувати";
            this.editMaterialsBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editMaterialsBtn.Glyph")));
            this.editMaterialsBtn.Id = 2;
            this.editMaterialsBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editMaterialsBtn.LargeGlyph")));
            this.editMaterialsBtn.Name = "editMaterialsBtn";
            this.editMaterialsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editMaterialsBtn_ItemClick);
            // 
            // deleteMaterialsBtn
            // 
            this.deleteMaterialsBtn.Caption = "Видалити";
            this.deleteMaterialsBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteMaterialsBtn.Glyph")));
            this.deleteMaterialsBtn.Id = 3;
            this.deleteMaterialsBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteMaterialsBtn.LargeGlyph")));
            this.deleteMaterialsBtn.Name = "deleteMaterialsBtn";
            this.deleteMaterialsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteMaterialsBtn_ItemClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Caption = "Оновити";
            this.refreshBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Glyph")));
            this.refreshBtn.Id = 4;
            this.refreshBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("refreshBtn.LargeGlyph")));
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBtn_ItemClick);
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.Caption = "Додати ";
            this.addGroupBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addGroupBtn.Glyph")));
            this.addGroupBtn.Id = 6;
            this.addGroupBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addGroupBtn.LargeGlyph")));
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addGroupBtn_ItemClick);
            // 
            // editGroupBtn
            // 
            this.editGroupBtn.Caption = "Редагувати";
            this.editGroupBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("editGroupBtn.Glyph")));
            this.editGroupBtn.Id = 7;
            this.editGroupBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editGroupBtn.LargeGlyph")));
            this.editGroupBtn.Name = "editGroupBtn";
            this.editGroupBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editGroupBtn_ItemClick);
            // 
            // deleteGroupBtn
            // 
            this.deleteGroupBtn.Caption = "Видалити";
            this.deleteGroupBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("deleteGroupBtn.Glyph")));
            this.deleteGroupBtn.Id = 8;
            this.deleteGroupBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("deleteGroupBtn.LargeGlyph")));
            this.deleteGroupBtn.Name = "deleteGroupBtn";
            this.deleteGroupBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteGroupBtn_ItemClick);
            // 
            // addSubGroupBtn
            // 
            this.addSubGroupBtn.Caption = "Додати (підгрупу)";
            this.addSubGroupBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("addSubGroupBtn.Glyph")));
            this.addSubGroupBtn.Id = 9;
            this.addSubGroupBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("addSubGroupBtn.LargeGlyph")));
            this.addSubGroupBtn.Name = "addSubGroupBtn";
            this.addSubGroupBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addSubGroupBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.addGroupBtn);
            this.ribbonPageGroup4.ItemLinks.Add(this.addSubGroupBtn);
            this.ribbonPageGroup4.ItemLinks.Add(this.editGroupBtn);
            this.ribbonPageGroup4.ItemLinks.Add(this.deleteGroupBtn);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Групи";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.addMaterialsBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.editMaterialsBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteMaterialsBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Матеріали";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.printNomenclatureBtn);
            this.ribbonPageGroup2.ItemLinks.Add(this.refreshBtn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Функції";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 95);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.nomenclatureGroupTree);
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Size = new System.Drawing.Size(1339, 473);
            this.splitContainerControl1.SplitterPosition = 480;
            this.splitContainerControl1.TabIndex = 3;
            // 
            // nomenclatureGroupTree
            // 
            this.nomenclatureGroupTree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.nomenclatureGroupTree.Cursor = System.Windows.Forms.Cursors.Default;
            this.nomenclatureGroupTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nomenclatureGroupTree.Location = new System.Drawing.Point(0, 0);
            this.nomenclatureGroupTree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomenclatureGroupTree.Name = "nomenclatureGroupTree";
            this.nomenclatureGroupTree.Size = new System.Drawing.Size(480, 473);
            this.nomenclatureGroupTree.TabIndex = 0;
            this.nomenclatureGroupTree.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.nomenclatureGroupTree_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Номер групи";
            this.treeListColumn1.FieldName = "Id";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.OptionsColumn.AllowFocus = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Найменування групи";
            this.treeListColumn2.FieldName = "Name";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.AllowEdit = false;
            this.treeListColumn2.OptionsColumn.AllowFocus = false;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.nomenclaturesMaterialGrid);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(854, 473);
            this.splitContainerControl2.SplitterPosition = 264;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // nomenclaturesMaterialGrid
            // 
            this.nomenclaturesMaterialGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nomenclaturesMaterialGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomenclaturesMaterialGrid.Location = new System.Drawing.Point(0, 0);
            this.nomenclaturesMaterialGrid.MainView = this.nomenclaturesMaterialGridView;
            this.nomenclaturesMaterialGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomenclaturesMaterialGrid.MenuManager = this.ribbonControl1;
            this.nomenclaturesMaterialGrid.Name = "nomenclaturesMaterialGrid";
            this.nomenclaturesMaterialGrid.Size = new System.Drawing.Size(854, 264);
            this.nomenclaturesMaterialGrid.TabIndex = 0;
            this.nomenclaturesMaterialGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.nomenclaturesMaterialGridView});
            this.nomenclaturesMaterialGrid.DoubleClick += new System.EventHandler(this.nomenclaturesMaterialGrid_DoubleClick);
            // 
            // nomenclaturesMaterialGridView
            // 
            this.nomenclaturesMaterialGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nomenclatureCol,
            this.nameCol,
            this.unitLocalNameCol,
            this.numCol});
            this.nomenclaturesMaterialGridView.GridControl = this.nomenclaturesMaterialGrid;
            this.nomenclaturesMaterialGridView.Name = "nomenclaturesMaterialGridView";
            this.nomenclaturesMaterialGridView.OptionsView.ShowAutoFilterRow = true;
            this.nomenclaturesMaterialGridView.OptionsView.ShowGroupedColumns = true;
            this.nomenclaturesMaterialGridView.OptionsView.ShowGroupPanel = false;
            this.nomenclaturesMaterialGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.nomenclaturesMaterialGridView_FocusedRowChanged);
            // 
            // nomenclatureCol
            // 
            this.nomenclatureCol.Caption = "Ном. номер";
            this.nomenclatureCol.FieldName = "Nomenclature";
            this.nomenclatureCol.Name = "nomenclatureCol";
            this.nomenclatureCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureCol.Visible = true;
            this.nomenclatureCol.VisibleIndex = 0;
            // 
            // nameCol
            // 
            this.nameCol.Caption = "Найменування";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.OptionsColumn.AllowEdit = false;
            this.nameCol.OptionsColumn.AllowFocus = false;
            this.nameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 1;
            // 
            // unitLocalNameCol
            // 
            this.unitLocalNameCol.Caption = "Один. вимірювань";
            this.unitLocalNameCol.FieldName = "UnitLocalName";
            this.unitLocalNameCol.Name = "unitLocalNameCol";
            this.unitLocalNameCol.OptionsColumn.AllowEdit = false;
            this.unitLocalNameCol.OptionsColumn.AllowFocus = false;
            this.unitLocalNameCol.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.unitLocalNameCol.Visible = true;
            this.unitLocalNameCol.VisibleIndex = 2;
            // 
            // numCol
            // 
            this.numCol.Caption = "Балансовий рахунок";
            this.numCol.FieldName = "Num";
            this.numCol.Name = "numCol";
            this.numCol.OptionsColumn.AllowEdit = false;
            this.numCol.OptionsColumn.AllowFocus = false;
            this.numCol.Visible = true;
            this.numCol.VisibleIndex = 3;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.xtraTabControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xtraTabControl1.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.Appearance.Options.UseFont = true;
            this.xtraTabControl1.Appearance.Options.UseForeColor = true;
            this.xtraTabControl1.AppearancePage.Header.BackColor = System.Drawing.Color.Gainsboro;
            this.xtraTabControl1.AppearancePage.Header.Options.UseBackColor = true;
            this.xtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Size = new System.Drawing.Size(854, 204);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.chartControl);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.xtraTabPage1.Size = new System.Drawing.Size(848, 176);
            this.xtraTabPage1.Text = "Графік цін ";
            // 
            // chartControl
            // 
            this.chartControl.CrosshairOptions.ArgumentLineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dash;
            this.chartControl.CrosshairOptions.ArgumentLineStyle.LineJoin = System.Drawing.Drawing2D.LineJoin.MiterClipped;
            this.chartControl.CrosshairOptions.ArgumentLineStyle.Thickness = 4;
            this.chartControl.CrosshairOptions.ShowArgumentLabels = true;
            this.chartControl.CrosshairOptions.ShowValueLabels = true;
            this.chartControl.CrosshairOptions.ValueLineStyle.LineJoin = System.Drawing.Drawing2D.LineJoin.MiterClipped;
            this.chartControl.CrosshairOptions.ValueLineStyle.Thickness = 4;
            xyDiagram1.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram1.AxisX.AutoScaleBreaks.Enabled = true;
            xyDiagram1.AxisX.GridLines.MinorVisible = true;
            xyDiagram1.AxisX.Interlaced = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram1.AxisY.GridLines.LineStyle.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
            xyDiagram1.AxisY.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            xyDiagram1.AxisY.InterlacedFillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
            xyDiagram1.AxisY.Label.BackColor = System.Drawing.Color.White;
            xyDiagram1.AxisY.Label.Border.Thickness = 100;
            xyDiagram1.AxisY.Label.Font = new System.Drawing.Font("Tahoma", 10F);
            xyDiagram1.AxisY.NumericScaleOptions.AutoGrid = false;
            xyDiagram1.AxisY.Tickmarks.Length = 6;
            xyDiagram1.AxisY.Title.Text = "";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.DefaultPane.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
            xyDiagram1.DefaultPane.ScrollBarOptions.BarThickness = 4;
            xyDiagram1.DefaultPane.Weight = 4D;
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.EnableAxisXZooming = true;
            xyDiagram1.Margins.Bottom = 10;
            xyDiagram1.Margins.Left = 60;
            xyDiagram1.Margins.Right = 10;
            xyDiagram1.Margins.Top = 10;
            this.chartControl.Diagram = xyDiagram1;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl.Location = new System.Drawing.Point(4, 4);
            this.chartControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartControl.Name = "chartControl";
            this.chartControl.Padding.Bottom = 10;
            this.chartControl.Padding.Left = 10;
            this.chartControl.Padding.Right = 10;
            this.chartControl.Padding.Top = 10;
            this.chartControl.PaletteName = "Concourse";
            this.chartControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.ArgumentDataMember = "OrderDate";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.True;
            series1.CrosshairHighlightPoints = DevExpress.Utils.DefaultBoolean.True;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.LegendText = "епрап";
            series1.Name = "Series 1";
            series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            series1.ShowInLegend = false;
            series1.TopNOptions.Enabled = true;
            series1.TopNOptions.Mode = DevExpress.XtraCharts.TopNMode.ThresholdValue;
            series1.ValueDataMembersSerializable = "UnitPrice";
            lineSeriesView1.Color = System.Drawing.Color.Violet;
            lineSeriesView1.ColorEach = true;
            lineSeriesView1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            lineSeriesView1.LineMarkerOptions.Color = System.Drawing.Color.Red;
            lineSeriesView1.LineMarkerOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
            lineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.View = lineSeriesView1;
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl.SeriesTemplate.ArgumentDataMember = "OrderDate";
            this.chartControl.Size = new System.Drawing.Size(840, 168);
            this.chartControl.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.recieptArchiveGrid);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.xtraTabPage2.Size = new System.Drawing.Size(848, 176);
            this.xtraTabPage2.Text = "Надходження";
            // 
            // recieptArchiveGrid
            // 
            this.recieptArchiveGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recieptArchiveGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recieptArchiveGrid.Location = new System.Drawing.Point(4, 4);
            this.recieptArchiveGrid.MainView = this.recieptArchibeGridView;
            this.recieptArchiveGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recieptArchiveGrid.MenuManager = this.ribbonControl1;
            this.recieptArchiveGrid.Name = "recieptArchiveGrid";
            this.recieptArchiveGrid.Size = new System.Drawing.Size(840, 168);
            this.recieptArchiveGrid.TabIndex = 0;
            this.recieptArchiveGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.recieptArchibeGridView});
            // 
            // recieptArchibeGridView
            // 
            this.recieptArchibeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nomenclatureArchivCol,
            this.nomenclatureNameArchivCol,
            this.unitLocalNameArchivCol,
            this.quantityCol,
            this.totalPriceCol,
            this.unitPriceCol,
            this.storeHouseNameCol,
            this.vendorNameCol,
            this.dateCol});
            this.recieptArchibeGridView.GridControl = this.recieptArchiveGrid;
            this.recieptArchibeGridView.Name = "recieptArchibeGridView";
            this.recieptArchibeGridView.OptionsView.ShowGroupPanel = false;
            // 
            // nomenclatureArchivCol
            // 
            this.nomenclatureArchivCol.Caption = "Ном. номер";
            this.nomenclatureArchivCol.FieldName = "Nomenclature";
            this.nomenclatureArchivCol.Name = "nomenclatureArchivCol";
            this.nomenclatureArchivCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureArchivCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureArchivCol.Visible = true;
            this.nomenclatureArchivCol.VisibleIndex = 0;
            // 
            // nomenclatureNameArchivCol
            // 
            this.nomenclatureNameArchivCol.Caption = "Найменування";
            this.nomenclatureNameArchivCol.FieldName = "NomenclatureName";
            this.nomenclatureNameArchivCol.Name = "nomenclatureNameArchivCol";
            this.nomenclatureNameArchivCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureNameArchivCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureNameArchivCol.Visible = true;
            this.nomenclatureNameArchivCol.VisibleIndex = 1;
            // 
            // unitLocalNameArchivCol
            // 
            this.unitLocalNameArchivCol.Caption = "Одиниці вимірювань";
            this.unitLocalNameArchivCol.FieldName = "UnitLocalName";
            this.unitLocalNameArchivCol.Name = "unitLocalNameArchivCol";
            this.unitLocalNameArchivCol.OptionsColumn.AllowEdit = false;
            this.unitLocalNameArchivCol.OptionsColumn.AllowFocus = false;
            this.unitLocalNameArchivCol.Visible = true;
            this.unitLocalNameArchivCol.VisibleIndex = 2;
            // 
            // quantityCol
            // 
            this.quantityCol.Caption = "Кількість";
            this.quantityCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.quantityCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.quantityCol.FieldName = "Quantity";
            this.quantityCol.Name = "quantityCol";
            this.quantityCol.OptionsColumn.AllowEdit = false;
            this.quantityCol.OptionsColumn.AllowFocus = false;
            this.quantityCol.Visible = true;
            this.quantityCol.VisibleIndex = 8;
            // 
            // totalPriceCol
            // 
            this.totalPriceCol.Caption = "Сума(без ПДВ)";
            this.totalPriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.totalPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.totalPriceCol.FieldName = "TotalPrice";
            this.totalPriceCol.Name = "totalPriceCol";
            this.totalPriceCol.OptionsColumn.AllowEdit = false;
            this.totalPriceCol.OptionsColumn.AllowFocus = false;
            this.totalPriceCol.Visible = true;
            this.totalPriceCol.VisibleIndex = 3;
            // 
            // unitPriceCol
            // 
            this.unitPriceCol.Caption = "Ціна за од.(без ПДВ)";
            this.unitPriceCol.DisplayFormat.FormatString = "### ### ##0.00";
            this.unitPriceCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.unitPriceCol.FieldName = "UnitPrice";
            this.unitPriceCol.Name = "unitPriceCol";
            this.unitPriceCol.OptionsColumn.AllowEdit = false;
            this.unitPriceCol.OptionsColumn.AllowFocus = false;
            this.unitPriceCol.Visible = true;
            this.unitPriceCol.VisibleIndex = 4;
            // 
            // storeHouseNameCol
            // 
            this.storeHouseNameCol.Caption = "Склад";
            this.storeHouseNameCol.FieldName = "StoreHouseName";
            this.storeHouseNameCol.Name = "storeHouseNameCol";
            this.storeHouseNameCol.OptionsColumn.AllowEdit = false;
            this.storeHouseNameCol.OptionsColumn.AllowFocus = false;
            this.storeHouseNameCol.Visible = true;
            this.storeHouseNameCol.VisibleIndex = 5;
            // 
            // vendorNameCol
            // 
            this.vendorNameCol.Caption = "Постачальник";
            this.vendorNameCol.FieldName = "VendorName";
            this.vendorNameCol.Name = "vendorNameCol";
            this.vendorNameCol.OptionsColumn.AllowEdit = false;
            this.vendorNameCol.OptionsColumn.AllowFocus = false;
            this.vendorNameCol.Visible = true;
            this.vendorNameCol.VisibleIndex = 6;
            // 
            // dateCol
            // 
            this.dateCol.Caption = "Дата";
            this.dateCol.FieldName = "OrderDate";
            this.dateCol.Name = "dateCol";
            this.dateCol.OptionsColumn.AllowEdit = false;
            this.dateCol.OptionsColumn.AllowFocus = false;
            this.dateCol.Visible = true;
            this.dateCol.VisibleIndex = 7;
            // 
            // printNomenclatureBtn
            // 
            this.printNomenclatureBtn.Caption = "Друк номенклатури";
            this.printNomenclatureBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("printNomenclatureBtn.Glyph")));
            this.printNomenclatureBtn.Id = 10;
            this.printNomenclatureBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("printNomenclatureBtn.LargeGlyph")));
            this.printNomenclatureBtn.Name = "printNomenclatureBtn";
            this.printNomenclatureBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.printNomenclatureBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.printNomenclatureBtn_ItemClick);
            // 
            // NomenclaturesFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 568);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NomenclaturesFm";
            this.ShowIcon = false;
            this.Text = "Довідник складських матеріалів";
            ((System.ComponentModel.ISupportInitialize)(this.receiptHistoryOrdersDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nomenclatureGroupTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nomenclaturesMaterialGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomenclaturesMaterialGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recieptArchiveGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recieptArchibeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem addMaterialsBtn;
        private DevExpress.XtraBars.BarButtonItem editMaterialsBtn;
        private DevExpress.XtraBars.BarButtonItem deleteMaterialsBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem refreshBtn;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTreeList.TreeList nomenclatureGroupTree;
        private DevExpress.XtraGrid.GridControl nomenclaturesMaterialGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView nomenclaturesMaterialGridView;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclatureCol;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn unitLocalNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn numCol;
        private DevExpress.XtraBars.BarButtonItem addGroupBtn;
        private DevExpress.XtraBars.BarButtonItem editGroupBtn;
        private DevExpress.XtraBars.BarButtonItem deleteGroupBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem addSubGroupBtn;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.BindingSource receiptHistoryOrdersDTOBindingSource;
        private DevExpress.XtraGrid.GridControl recieptArchiveGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView recieptArchibeGridView;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclatureArchivCol;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclatureNameArchivCol;
        private DevExpress.XtraGrid.Columns.GridColumn unitLocalNameArchivCol;
        private DevExpress.XtraGrid.Columns.GridColumn totalPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn storeHouseNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn vendorNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn dateCol;
        private DevExpress.XtraGrid.Columns.GridColumn unitPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn quantityCol;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraBars.BarButtonItem printNomenclatureBtn;
    }
}