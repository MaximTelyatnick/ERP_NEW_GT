namespace ERP_NEW.GUI.OTK
{
    partial class WeldAttestationWpsFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeldAttestationWpsFm));
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.weldWpsGrid = new DevExpress.XtraGrid.GridControl();
            this.weldWpsGridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand12 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.checkedCol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.checkForDeleteRepository = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.weldWpsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldWpsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkForDeleteRepository)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(968, 554);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Відмінити";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(887, 554);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // weldWpsGrid
            // 
            this.weldWpsGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.weldWpsGrid.Location = new System.Drawing.Point(0, 0);
            this.weldWpsGrid.MainView = this.weldWpsGridView;
            this.weldWpsGrid.Name = "weldWpsGrid";
            this.weldWpsGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkForDeleteRepository});
            this.weldWpsGrid.Size = new System.Drawing.Size(1055, 548);
            this.weldWpsGrid.TabIndex = 18;
            this.weldWpsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.weldWpsGridView});
            // 
            // weldWpsGridView
            // 
            this.weldWpsGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand12,
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6,
            this.gridBand7});
            this.weldWpsGridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.checkedCol,
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
            // 
            // gridBand12
            // 
            this.gridBand12.Columns.Add(this.checkedCol);
            this.gridBand12.Image = ((System.Drawing.Image)(resources.GetObject("gridBand12.Image")));
            this.gridBand12.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridBand12.Name = "gridBand12";
            this.gridBand12.VisibleIndex = 0;
            this.gridBand12.Width = 33;
            // 
            // checkedCol
            // 
            this.checkedCol.ColumnEdit = this.checkForDeleteRepository;
            this.checkedCol.FieldName = "CheckForDelete";
            this.checkedCol.Name = "checkedCol";
            this.checkedCol.OptionsColumn.ShowCaption = false;
            this.checkedCol.Visible = true;
            this.checkedCol.Width = 33;
            // 
            // checkForDeleteRepository
            // 
            this.checkForDeleteRepository.AutoHeight = false;
            this.checkForDeleteRepository.Name = "checkForDeleteRepository";
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
            this.gridBand1.VisibleIndex = 1;
            this.gridBand1.Width = 144;
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
            this.wireDiameterCol.Width = 144;
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
            this.gridBand2.VisibleIndex = 2;
            this.gridBand2.Width = 207;
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
            this.seamSizeZCol.Width = 101;
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
            this.seamSizeA.Width = 106;
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
            this.gridBand3.VisibleIndex = 3;
            this.gridBand3.Width = 108;
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
            this.connectionTypeCol.Width = 108;
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
            this.gridBand4.VisibleIndex = 4;
            this.gridBand4.Width = 238;
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
            this.wpqrCol.Width = 113;
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
            this.wpsCol.Width = 125;
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
            this.gridBand5.VisibleIndex = 5;
            this.gridBand5.Width = 140;
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
            this.layerMarkCol.Width = 140;
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
            this.gridBand6.VisibleIndex = 6;
            this.gridBand6.Width = 305;
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
            this.materialThicknessCol.Width = 305;
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
            this.gridBand7.VisibleIndex = 7;
            this.gridBand7.Width = 180;
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
            this.weldPositionCol.Width = 180;
            // 
            // WeldAttestationWpsFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 589);
            this.Controls.Add(this.weldWpsGrid);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeldAttestationWpsFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WPS";
            ((System.ComponentModel.ISupportInitialize)(this.weldWpsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldWpsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkForDeleteRepository)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraGrid.GridControl weldWpsGrid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView weldWpsGridView;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand12;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn checkedCol;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkForDeleteRepository;
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