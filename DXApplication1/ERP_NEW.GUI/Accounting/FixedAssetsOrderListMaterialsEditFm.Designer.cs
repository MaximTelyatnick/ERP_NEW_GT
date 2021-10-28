namespace ERP_NEW.GUI.Accounting
{
    partial class FixedAssetsOrderListMaterialsEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixedAssetsOrderListMaterialsEditFm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.showBtn = new DevExpress.XtraBars.BarButtonItem();
            this.beginDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.endDateEdit = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.expendituresForFixedAssetsGrid = new DevExpress.XtraGrid.GridControl();
            this.expendituresForFixedAssetsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nomenclatureCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameNomenclatureCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.measureCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receipt_NumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_DateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.debit_NumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.exp_DateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.priceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.setPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.credit_AccountCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expendituresForFixedAssetsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expendituresForFixedAssetsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.showBtn,
            this.beginDateEdit,
            this.endDateEdit});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(1287, 95);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // showBtn
            // 
            this.showBtn.Caption = "Показати";
            this.showBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("showBtn.Glyph")));
            this.showBtn.Id = 1;
            this.showBtn.Name = "showBtn";
            this.showBtn.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.showBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showBtn_ItemClick);
            // 
            // beginDateEdit
            // 
            this.beginDateEdit.Caption = "З  ";
            this.beginDateEdit.Edit = this.repositoryItemDateEdit1;
            this.beginDateEdit.EditWidth = 100;
            this.beginDateEdit.Id = 2;
            this.beginDateEdit.Name = "beginDateEdit";
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
            this.endDateEdit.Caption = "по";
            this.endDateEdit.Edit = this.repositoryItemDateEdit2;
            this.endDateEdit.EditWidth = 100;
            this.endDateEdit.Id = 3;
            this.endDateEdit.Name = "endDateEdit";
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
            this.ribbonPageGroup1.Text = "Списання за період";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cancelBtn);
            this.panelControl1.Controls.Add(this.saveBtn);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 481);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1287, 39);
            this.panelControl1.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(1200, 6);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1110, 6);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.expendituresForFixedAssetsGrid);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 95);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1287, 386);
            this.panelControl2.TabIndex = 2;
            // 
            // expendituresForFixedAssetsGrid
            // 
            this.expendituresForFixedAssetsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expendituresForFixedAssetsGrid.Location = new System.Drawing.Point(2, 2);
            this.expendituresForFixedAssetsGrid.MainView = this.expendituresForFixedAssetsGridView;
            this.expendituresForFixedAssetsGrid.MenuManager = this.ribbonControl1;
            this.expendituresForFixedAssetsGrid.Name = "expendituresForFixedAssetsGrid";
            this.expendituresForFixedAssetsGrid.Size = new System.Drawing.Size(1283, 382);
            this.expendituresForFixedAssetsGrid.TabIndex = 0;
            this.expendituresForFixedAssetsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.expendituresForFixedAssetsGridView});
            // 
            // expendituresForFixedAssetsGridView
            // 
            this.expendituresForFixedAssetsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nomenclatureCol,
            this.nameNomenclatureCol,
            this.measureCol,
            this.receipt_NumCol,
            this.Order_DateCol,
            this.debit_NumCol,
            this.exp_DateCol,
            this.priceCol,
            this.setPriceCol,
            this.credit_AccountCol});
            this.expendituresForFixedAssetsGridView.GridControl = this.expendituresForFixedAssetsGrid;
            this.expendituresForFixedAssetsGridView.Name = "expendituresForFixedAssetsGridView";
            this.expendituresForFixedAssetsGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.expendituresForFixedAssetsGridView.OptionsView.ShowAutoFilterRow = true;
            this.expendituresForFixedAssetsGridView.OptionsView.ShowGroupPanel = false;
            this.expendituresForFixedAssetsGridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.expendituresForFixedAssetsGridView_RowCellStyle);
            // 
            // nomenclatureCol
            // 
            this.nomenclatureCol.Caption = "Номенкл. номер";
            this.nomenclatureCol.FieldName = "Nomenclature";
            this.nomenclatureCol.Name = "nomenclatureCol";
            this.nomenclatureCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureCol.Visible = true;
            this.nomenclatureCol.VisibleIndex = 0;
            // 
            // nameNomenclatureCol
            // 
            this.nameNomenclatureCol.Caption = "Ім\'я";
            this.nameNomenclatureCol.FieldName = "NameNomenclature";
            this.nameNomenclatureCol.Name = "nameNomenclatureCol";
            this.nameNomenclatureCol.OptionsColumn.AllowEdit = false;
            this.nameNomenclatureCol.OptionsColumn.AllowFocus = false;
            this.nameNomenclatureCol.Visible = true;
            this.nameNomenclatureCol.VisibleIndex = 1;
            // 
            // measureCol
            // 
            this.measureCol.Caption = "Од.вим.";
            this.measureCol.FieldName = "Measure";
            this.measureCol.Name = "measureCol";
            this.measureCol.OptionsColumn.AllowEdit = false;
            this.measureCol.OptionsColumn.AllowFocus = false;
            this.measureCol.Visible = true;
            this.measureCol.VisibleIndex = 2;
            // 
            // receipt_NumCol
            // 
            this.receipt_NumCol.Caption = "Номер приходу";
            this.receipt_NumCol.FieldName = "Receipt_Num";
            this.receipt_NumCol.Name = "receipt_NumCol";
            this.receipt_NumCol.OptionsColumn.AllowEdit = false;
            this.receipt_NumCol.OptionsColumn.AllowFocus = false;
            this.receipt_NumCol.Visible = true;
            this.receipt_NumCol.VisibleIndex = 3;
            // 
            // Order_DateCol
            // 
            this.Order_DateCol.Caption = "Дата приходу";
            this.Order_DateCol.FieldName = "Order_Date";
            this.Order_DateCol.Name = "Order_DateCol";
            this.Order_DateCol.OptionsColumn.AllowEdit = false;
            this.Order_DateCol.OptionsColumn.AllowFocus = false;
            this.Order_DateCol.Visible = true;
            this.Order_DateCol.VisibleIndex = 4;
            // 
            // debit_NumCol
            // 
            this.debit_NumCol.Caption = "Дебет рахунок";
            this.debit_NumCol.FieldName = "Debit_Num";
            this.debit_NumCol.Name = "debit_NumCol";
            this.debit_NumCol.OptionsColumn.AllowEdit = false;
            this.debit_NumCol.OptionsColumn.AllowFocus = false;
            this.debit_NumCol.Visible = true;
            this.debit_NumCol.VisibleIndex = 5;
            // 
            // exp_DateCol
            // 
            this.exp_DateCol.Caption = "Дата списання";
            this.exp_DateCol.FieldName = "Exp_Date";
            this.exp_DateCol.Name = "exp_DateCol";
            this.exp_DateCol.OptionsColumn.AllowEdit = false;
            this.exp_DateCol.OptionsColumn.AllowFocus = false;
            this.exp_DateCol.Visible = true;
            this.exp_DateCol.VisibleIndex = 6;
            // 
            // priceCol
            // 
            this.priceCol.Caption = "Сума списання";
            this.priceCol.FieldName = "Price";
            this.priceCol.Name = "priceCol";
            this.priceCol.OptionsColumn.AllowEdit = false;
            this.priceCol.OptionsColumn.AllowFocus = false;
            this.priceCol.Visible = true;
            this.priceCol.VisibleIndex = 7;
            // 
            // setPriceCol
            // 
            this.setPriceCol.Caption = "Сума матеріалів";
            this.setPriceCol.FieldName = "SetPrice";
            this.setPriceCol.Name = "setPriceCol";
            this.setPriceCol.OptionsColumn.AllowEdit = false;
            this.setPriceCol.OptionsColumn.AllowFocus = false;
            this.setPriceCol.Visible = true;
            this.setPriceCol.VisibleIndex = 8;
            // 
            // credit_AccountCol
            // 
            this.credit_AccountCol.Caption = "Кредитний рахунок";
            this.credit_AccountCol.FieldName = "Credit_Account";
            this.credit_AccountCol.Name = "credit_AccountCol";
            this.credit_AccountCol.OptionsColumn.AllowEdit = false;
            this.credit_AccountCol.OptionsColumn.AllowFocus = false;
            this.credit_AccountCol.Visible = true;
            this.credit_AccountCol.VisibleIndex = 9;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // FixedAssetsOrderListMaterialsEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 520);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FixedAssetsOrderListMaterialsEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Перелік матеріалів";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expendituresForFixedAssetsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expendituresForFixedAssetsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraBars.BarButtonItem showBtn;
        private DevExpress.XtraBars.BarEditItem beginDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem endDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private DevExpress.XtraGrid.GridControl expendituresForFixedAssetsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView expendituresForFixedAssetsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclatureCol;
        private DevExpress.XtraGrid.Columns.GridColumn nameNomenclatureCol;
        private DevExpress.XtraGrid.Columns.GridColumn measureCol;
        private DevExpress.XtraGrid.Columns.GridColumn receipt_NumCol;
        private DevExpress.XtraGrid.Columns.GridColumn Order_DateCol;
        private DevExpress.XtraGrid.Columns.GridColumn debit_NumCol;
        private DevExpress.XtraGrid.Columns.GridColumn exp_DateCol;
        private DevExpress.XtraGrid.Columns.GridColumn priceCol;
        private DevExpress.XtraGrid.Columns.GridColumn setPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn credit_AccountCol;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}