namespace ERP_NEW.GUI.Production
{
    partial class StoreHouseProjectExpendituresEditSelectFm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreHouseProjectExpendituresEditSelectFm));
            this.expendituresGrid = new DevExpress.XtraGrid.GridControl();
            this.expendituresGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.expDateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receiptNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.balanceAccountNumCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nomenclatureNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nomenclatureCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerOrderCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitLocalNameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quantityCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.expCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.expAccCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerOrderrCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.recIdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.expAccountantCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.priceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.checkAllExpenditureBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.expendituresGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expendituresGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // expendituresGrid
            // 
            gridLevelNode1.RelationName = "Level1";
            this.expendituresGrid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.expendituresGrid.Location = new System.Drawing.Point(-4, -2);
            this.expendituresGrid.MainView = this.expendituresGridView;
            this.expendituresGrid.Name = "expendituresGrid";
            this.expendituresGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.expendituresGrid.Size = new System.Drawing.Size(1592, 630);
            this.expendituresGrid.TabIndex = 2;
            this.expendituresGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.expendituresGridView});
            // 
            // expendituresGridView
            // 
            this.expendituresGridView.ColumnPanelRowHeight = 50;
            this.expendituresGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.expDateCol,
            this.receiptNumCol,
            this.balanceAccountNumCol,
            this.nomenclatureNameCol,
            this.nomenclatureCol,
            this.customerOrderCol,
            this.unitLocalNameCol,
            this.quantityCol,
            this.expCol,
            this.expAccCol,
            this.customerOrderrCol,
            this.recIdCol,
            this.gridColumn1,
            this.gridColumn2,
            this.expAccountantCol,
            this.priceCol,
            this.checkCol});
            this.expendituresGridView.GridControl = this.expendituresGrid;
            this.expendituresGridView.GroupCount = 1;
            this.expendituresGridView.Name = "expendituresGridView";
            this.expendituresGridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.expendituresGridView.OptionsView.ShowAutoFilterRow = true;
            this.expendituresGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.customerOrderrCol, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.expendituresGridView.ViewCaptionHeight = 100;
            // 
            // expDateCol
            // 
            this.expDateCol.AppearanceCell.Options.UseTextOptions = true;
            this.expDateCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.expDateCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expDateCol.AppearanceHeader.Options.UseFont = true;
            this.expDateCol.AppearanceHeader.Options.UseTextOptions = true;
            this.expDateCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.expDateCol.Caption = "Дата списання";
            this.expDateCol.FieldName = "ExpDate";
            this.expDateCol.Name = "expDateCol";
            this.expDateCol.OptionsColumn.AllowEdit = false;
            this.expDateCol.OptionsColumn.AllowFocus = false;
            this.expDateCol.Visible = true;
            this.expDateCol.VisibleIndex = 6;
            this.expDateCol.Width = 108;
            // 
            // receiptNumCol
            // 
            this.receiptNumCol.AppearanceCell.Options.UseTextOptions = true;
            this.receiptNumCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.receiptNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receiptNumCol.AppearanceHeader.Options.UseFont = true;
            this.receiptNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.receiptNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.receiptNumCol.Caption = "№ надходження ";
            this.receiptNumCol.FieldName = "ReceiptNum";
            this.receiptNumCol.Name = "receiptNumCol";
            this.receiptNumCol.OptionsColumn.AllowEdit = false;
            this.receiptNumCol.OptionsColumn.AllowFocus = false;
            this.receiptNumCol.Visible = true;
            this.receiptNumCol.VisibleIndex = 7;
            this.receiptNumCol.Width = 132;
            // 
            // balanceAccountNumCol
            // 
            this.balanceAccountNumCol.AppearanceCell.Options.UseTextOptions = true;
            this.balanceAccountNumCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.balanceAccountNumCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceAccountNumCol.AppearanceHeader.Options.UseFont = true;
            this.balanceAccountNumCol.AppearanceHeader.Options.UseTextOptions = true;
            this.balanceAccountNumCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.balanceAccountNumCol.Caption = "Рахунок";
            this.balanceAccountNumCol.FieldName = "BalanceAccountNum";
            this.balanceAccountNumCol.Name = "balanceAccountNumCol";
            this.balanceAccountNumCol.OptionsColumn.AllowEdit = false;
            this.balanceAccountNumCol.OptionsColumn.AllowFocus = false;
            this.balanceAccountNumCol.Visible = true;
            this.balanceAccountNumCol.VisibleIndex = 2;
            this.balanceAccountNumCol.Width = 64;
            // 
            // nomenclatureNameCol
            // 
            this.nomenclatureNameCol.AppearanceCell.Options.UseTextOptions = true;
            this.nomenclatureNameCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.nomenclatureNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomenclatureNameCol.AppearanceHeader.Options.UseFont = true;
            this.nomenclatureNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureNameCol.Caption = "Номенклатурний номер";
            this.nomenclatureNameCol.FieldName = "Nomenclature";
            this.nomenclatureNameCol.Name = "nomenclatureNameCol";
            this.nomenclatureNameCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureNameCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureNameCol.Visible = true;
            this.nomenclatureNameCol.VisibleIndex = 0;
            this.nomenclatureNameCol.Width = 196;
            // 
            // nomenclatureCol
            // 
            this.nomenclatureCol.AppearanceCell.Options.UseTextOptions = true;
            this.nomenclatureCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.nomenclatureCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomenclatureCol.AppearanceHeader.Options.UseFont = true;
            this.nomenclatureCol.AppearanceHeader.Options.UseTextOptions = true;
            this.nomenclatureCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nomenclatureCol.Caption = "Найменування";
            this.nomenclatureCol.FieldName = "NomenclatureName";
            this.nomenclatureCol.Name = "nomenclatureCol";
            this.nomenclatureCol.OptionsColumn.AllowEdit = false;
            this.nomenclatureCol.OptionsColumn.AllowFocus = false;
            this.nomenclatureCol.Visible = true;
            this.nomenclatureCol.VisibleIndex = 1;
            this.nomenclatureCol.Width = 302;
            // 
            // customerOrderCol
            // 
            this.customerOrderCol.AppearanceCell.Options.UseTextOptions = true;
            this.customerOrderCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.customerOrderCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerOrderCol.AppearanceHeader.Options.UseFont = true;
            this.customerOrderCol.AppearanceHeader.Options.UseTextOptions = true;
            this.customerOrderCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customerOrderCol.Caption = "Заказ";
            this.customerOrderCol.FieldName = "CustomerOrderNumber";
            this.customerOrderCol.Name = "customerOrderCol";
            this.customerOrderCol.OptionsColumn.AllowEdit = false;
            this.customerOrderCol.OptionsColumn.AllowFocus = false;
            this.customerOrderCol.Visible = true;
            this.customerOrderCol.VisibleIndex = 8;
            this.customerOrderCol.Width = 108;
            // 
            // unitLocalNameCol
            // 
            this.unitLocalNameCol.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon;
            this.unitLocalNameCol.AppearanceCell.Options.UseBackColor = true;
            this.unitLocalNameCol.AppearanceCell.Options.UseTextOptions = true;
            this.unitLocalNameCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.unitLocalNameCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitLocalNameCol.AppearanceHeader.Options.UseFont = true;
            this.unitLocalNameCol.AppearanceHeader.Options.UseTextOptions = true;
            this.unitLocalNameCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unitLocalNameCol.Caption = "Од. вим.";
            this.unitLocalNameCol.FieldName = "UnitLocalName";
            this.unitLocalNameCol.Name = "unitLocalNameCol";
            this.unitLocalNameCol.OptionsColumn.AllowEdit = false;
            this.unitLocalNameCol.OptionsColumn.AllowFocus = false;
            this.unitLocalNameCol.Visible = true;
            this.unitLocalNameCol.VisibleIndex = 4;
            this.unitLocalNameCol.Width = 62;
            // 
            // quantityCol
            // 
            this.quantityCol.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon;
            this.quantityCol.AppearanceCell.BackColor2 = System.Drawing.Color.LemonChiffon;
            this.quantityCol.AppearanceCell.Options.UseBackColor = true;
            this.quantityCol.AppearanceCell.Options.UseTextOptions = true;
            this.quantityCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.quantityCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityCol.AppearanceHeader.Options.UseFont = true;
            this.quantityCol.AppearanceHeader.Options.UseTextOptions = true;
            this.quantityCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.quantityCol.Caption = "Кількість";
            this.quantityCol.FieldName = "Quantity";
            this.quantityCol.Name = "quantityCol";
            this.quantityCol.OptionsColumn.AllowEdit = false;
            this.quantityCol.OptionsColumn.AllowFocus = false;
            this.quantityCol.Visible = true;
            this.quantityCol.VisibleIndex = 3;
            this.quantityCol.Width = 108;
            // 
            // expCol
            // 
            this.expCol.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.expCol.AppearanceCell.Options.UseBackColor = true;
            this.expCol.AppearanceCell.Options.UseTextOptions = true;
            this.expCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.expCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expCol.AppearanceHeader.Options.UseFont = true;
            this.expCol.AppearanceHeader.Options.UseTextOptions = true;
            this.expCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.expCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.expCol.Caption = "Списання бух.(кількість)";
            this.expCol.FieldName = "ExpendituresQuantity";
            this.expCol.Name = "expCol";
            this.expCol.OptionsColumn.AllowEdit = false;
            this.expCol.OptionsColumn.AllowFocus = false;
            this.expCol.Visible = true;
            this.expCol.VisibleIndex = 9;
            this.expCol.Width = 141;
            // 
            // expAccCol
            // 
            this.expAccCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expAccCol.AppearanceHeader.Options.UseFont = true;
            this.expAccCol.AppearanceHeader.Options.UseTextOptions = true;
            this.expAccCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.expAccCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.expAccCol.Caption = "Списання бух. дата";
            this.expAccCol.FieldName = "ExpenditureAccountDate";
            this.expAccCol.Name = "expAccCol";
            this.expAccCol.OptionsColumn.AllowEdit = false;
            this.expAccCol.OptionsColumn.AllowFocus = false;
            this.expAccCol.Visible = true;
            this.expAccCol.VisibleIndex = 10;
            this.expAccCol.Width = 73;
            // 
            // customerOrderrCol
            // 
            this.customerOrderrCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerOrderrCol.AppearanceHeader.Options.UseFont = true;
            this.customerOrderrCol.AppearanceHeader.Options.UseTextOptions = true;
            this.customerOrderrCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customerOrderrCol.Caption = "Заказ";
            this.customerOrderrCol.FieldName = "CustomerOrderNumber";
            this.customerOrderrCol.Name = "customerOrderrCol";
            this.customerOrderrCol.OptionsColumn.AllowEdit = false;
            this.customerOrderrCol.OptionsColumn.AllowFocus = false;
            this.customerOrderrCol.Visible = true;
            this.customerOrderrCol.VisibleIndex = 10;
            // 
            // recIdCol
            // 
            this.recIdCol.Caption = "RecIdCol";
            this.recIdCol.FieldName = "ReceiptId";
            this.recIdCol.Name = "recIdCol";
            this.recIdCol.OptionsColumn.AllowEdit = false;
            this.recIdCol.OptionsColumn.AllowFocus = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ExpProdCol";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ExpId";
            this.gridColumn2.FieldName = "ExpenditureId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            // 
            // expAccountantCol
            // 
            this.expAccountantCol.AppearanceCell.Options.UseTextOptions = true;
            this.expAccountantCol.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.expAccountantCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expAccountantCol.AppearanceHeader.Options.UseFont = true;
            this.expAccountantCol.AppearanceHeader.Options.UseTextOptions = true;
            this.expAccountantCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.expAccountantCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.expAccountantCol.Caption = "Списано на заказ (бух.)";
            this.expAccountantCol.FieldName = "ExpenditureCustomerOrder";
            this.expAccountantCol.Name = "expAccountantCol";
            this.expAccountantCol.OptionsColumn.AllowEdit = false;
            this.expAccountantCol.OptionsColumn.AllowFocus = false;
            this.expAccountantCol.Visible = true;
            this.expAccountantCol.VisibleIndex = 11;
            this.expAccountantCol.Width = 138;
            // 
            // priceCol
            // 
            this.priceCol.AppearanceCell.BackColor = System.Drawing.Color.LemonChiffon;
            this.priceCol.AppearanceCell.Options.UseBackColor = true;
            this.priceCol.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceCol.AppearanceHeader.Options.UseFont = true;
            this.priceCol.AppearanceHeader.Options.UseTextOptions = true;
            this.priceCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.priceCol.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.priceCol.Caption = "Ціна (за одиницю)";
            this.priceCol.FieldName = "Price";
            this.priceCol.MinWidth = 40;
            this.priceCol.Name = "priceCol";
            this.priceCol.OptionsColumn.AllowEdit = false;
            this.priceCol.OptionsColumn.AllowFocus = false;
            this.priceCol.Visible = true;
            this.priceCol.VisibleIndex = 5;
            this.priceCol.Width = 109;
            // 
            // checkCol
            // 
            this.checkCol.AppearanceHeader.Options.UseTextOptions = true;
            this.checkCol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.checkCol.ColumnEdit = this.repositoryItemCheckEdit1;
            this.checkCol.FieldName = "Check";
            this.checkCol.Image = ((System.Drawing.Image)(resources.GetObject("checkCol.Image")));
            this.checkCol.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.checkCol.Name = "checkCol";
            this.checkCol.Visible = true;
            this.checkCol.VisibleIndex = 12;
            this.checkCol.Width = 33;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(1512, 645);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(64, 23);
            this.cancelBtn.TabIndex = 145;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1438, 645);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(68, 23);
            this.saveBtn.TabIndex = 144;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // checkAllExpenditureBtn
            // 
            this.checkAllExpenditureBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkAllExpenditureBtn.Appearance.Options.UseFont = true;
            this.checkAllExpenditureBtn.Image = ((System.Drawing.Image)(resources.GetObject("checkAllExpenditureBtn.Image")));
            this.checkAllExpenditureBtn.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.checkAllExpenditureBtn.Location = new System.Drawing.Point(1416, 12);
            this.checkAllExpenditureBtn.Name = "checkAllExpenditureBtn";
            this.checkAllExpenditureBtn.Size = new System.Drawing.Size(160, 33);
            this.checkAllExpenditureBtn.TabIndex = 146;
            this.checkAllExpenditureBtn.Text = "Виділити усі списання";
            this.checkAllExpenditureBtn.Click += new System.EventHandler(this.checkAllExpenditureBtn_Click);
            // 
            // StoreHouseProjectExpendituresEditSelectFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 680);
            this.Controls.Add(this.checkAllExpenditureBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.expendituresGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StoreHouseProjectExpendituresEditSelectFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редагування списання";
            ((System.ComponentModel.ISupportInitialize)(this.expendituresGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expendituresGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl expendituresGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView expendituresGridView;
        private DevExpress.XtraGrid.Columns.GridColumn expDateCol;
        private DevExpress.XtraGrid.Columns.GridColumn receiptNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn balanceAccountNumCol;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclatureNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn nomenclatureCol;
        private DevExpress.XtraGrid.Columns.GridColumn customerOrderCol;
        private DevExpress.XtraGrid.Columns.GridColumn unitLocalNameCol;
        private DevExpress.XtraGrid.Columns.GridColumn quantityCol;
        private DevExpress.XtraGrid.Columns.GridColumn expCol;
        private DevExpress.XtraGrid.Columns.GridColumn expAccCol;
        private DevExpress.XtraGrid.Columns.GridColumn customerOrderrCol;
        private DevExpress.XtraGrid.Columns.GridColumn recIdCol;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn expAccountantCol;
        private DevExpress.XtraGrid.Columns.GridColumn priceCol;
        private DevExpress.XtraGrid.Columns.GridColumn checkCol;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton checkAllExpenditureBtn;
    }
}