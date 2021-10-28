namespace ERP_NEW.GUI.Accounting
{
    partial class CalcWithBuyersSpecEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcWithBuyersSpecEditFm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.customerOrdersSpecEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerOrderNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quantityCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.singlePriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sumPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.singleCurrencyPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sumCurrencyPriceCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderNumberLbl = new DevExpress.XtraEditors.LabelControl();
            this.quantityTBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.paymentPriceCurrencyTBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.paymentPriceTBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.vatPayment6412TBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.detailsEdit = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cpvCodeEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.uktvCodeEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dkppCodeEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.vatPayment643TBox = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersSpecEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPriceCurrencyTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPriceTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatPayment6412TBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpvCodeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uktvCodeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dkppCodeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vatPayment643TBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // customerOrdersSpecEdit
            // 
            this.customerOrdersSpecEdit.Location = new System.Drawing.Point(12, 31);
            this.customerOrdersSpecEdit.Name = "customerOrdersSpecEdit";
            this.customerOrdersSpecEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.customerOrdersSpecEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("customerOrdersSpecEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.customerOrdersSpecEdit.Properties.ImmediatePopup = true;
            this.customerOrdersSpecEdit.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.customerOrdersSpecEdit.Properties.PopupFormSize = new System.Drawing.Size(553, 0);
            this.customerOrdersSpecEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.customerOrdersSpecEdit.Properties.View = this.gridLookUpEdit1View;
            this.customerOrdersSpecEdit.Properties.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.customerOrdersSpecEdit_Properties_QueryPopUp);
            this.customerOrdersSpecEdit.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.customerOrdersSpecEdit_Properties_ButtonClick);
            this.customerOrdersSpecEdit.Size = new System.Drawing.Size(722, 22);
            this.customerOrdersSpecEdit.TabIndex = 1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameCol,
            this.customerOrderNumberCol,
            this.quantityCol,
            this.singlePriceCol,
            this.sumPriceCol,
            this.singleCurrencyPriceCol,
            this.sumCurrencyPriceCol});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridLookUpEdit1View.OptionsFind.AlwaysVisible = true;
            this.gridLookUpEdit1View.OptionsFind.SearchInPreview = true;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // nameCol
            // 
            this.nameCol.Caption = "Найменування обладнання";
            this.nameCol.FieldName = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.Visible = true;
            this.nameCol.VisibleIndex = 0;
            this.nameCol.Width = 429;
            // 
            // customerOrderNumberCol
            // 
            this.customerOrderNumberCol.Caption = "Заказ";
            this.customerOrderNumberCol.FieldName = "CustomerOrderNumber";
            this.customerOrderNumberCol.Name = "customerOrderNumberCol";
            this.customerOrderNumberCol.Visible = true;
            this.customerOrderNumberCol.VisibleIndex = 1;
            this.customerOrderNumberCol.Width = 119;
            // 
            // quantityCol
            // 
            this.quantityCol.Caption = "Кількість(шт.)";
            this.quantityCol.FieldName = "Quantity";
            this.quantityCol.Name = "quantityCol";
            this.quantityCol.Visible = true;
            this.quantityCol.VisibleIndex = 2;
            this.quantityCol.Width = 100;
            // 
            // singlePriceCol
            // 
            this.singlePriceCol.Caption = "Ціна за од.(грн.)";
            this.singlePriceCol.FieldName = "SinglePrice";
            this.singlePriceCol.Name = "singlePriceCol";
            this.singlePriceCol.Visible = true;
            this.singlePriceCol.VisibleIndex = 3;
            this.singlePriceCol.Width = 100;
            // 
            // sumPriceCol
            // 
            this.sumPriceCol.Caption = "Сума(грн.)";
            this.sumPriceCol.FieldName = "SumPrice";
            this.sumPriceCol.Name = "sumPriceCol";
            this.sumPriceCol.Visible = true;
            this.sumPriceCol.VisibleIndex = 4;
            this.sumPriceCol.Width = 100;
            // 
            // singleCurrencyPriceCol
            // 
            this.singleCurrencyPriceCol.Caption = "Ціна за од.(валюта)";
            this.singleCurrencyPriceCol.FieldName = "SingleCurrencyPrice";
            this.singleCurrencyPriceCol.Name = "singleCurrencyPriceCol";
            this.singleCurrencyPriceCol.Visible = true;
            this.singleCurrencyPriceCol.VisibleIndex = 5;
            this.singleCurrencyPriceCol.Width = 100;
            // 
            // sumCurrencyPriceCol
            // 
            this.sumCurrencyPriceCol.Caption = "Сума(валюта)";
            this.sumCurrencyPriceCol.FieldName = "SumCurrencyPrice";
            this.sumCurrencyPriceCol.Name = "sumCurrencyPriceCol";
            this.sumCurrencyPriceCol.Visible = true;
            this.sumCurrencyPriceCol.VisibleIndex = 6;
            this.sumCurrencyPriceCol.Width = 119;
            // 
            // orderNumberLbl
            // 
            this.orderNumberLbl.Location = new System.Drawing.Point(138, 12);
            this.orderNumberLbl.Name = "orderNumberLbl";
            this.orderNumberLbl.Size = new System.Drawing.Size(0, 13);
            this.orderNumberLbl.TabIndex = 74;
            // 
            // quantityTBox
            // 
            this.quantityTBox.EditValue = "0,000";
            this.quantityTBox.Location = new System.Drawing.Point(308, 78);
            this.quantityTBox.Name = "quantityTBox";
            this.quantityTBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.quantityTBox.Properties.Appearance.Options.UseFont = true;
            this.quantityTBox.Properties.Appearance.Options.UseTextOptions = true;
            this.quantityTBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.quantityTBox.Properties.Mask.EditMask = "n3";
            this.quantityTBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.quantityTBox.Size = new System.Drawing.Size(142, 20);
            this.quantityTBox.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(308, 60);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 13);
            this.labelControl5.TabIndex = 83;
            this.labelControl5.Text = "Кількість";
            // 
            // paymentPriceCurrencyTBox
            // 
            this.paymentPriceCurrencyTBox.EditValue = "0,00";
            this.paymentPriceCurrencyTBox.Location = new System.Drawing.Point(160, 78);
            this.paymentPriceCurrencyTBox.Name = "paymentPriceCurrencyTBox";
            this.paymentPriceCurrencyTBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.paymentPriceCurrencyTBox.Properties.Appearance.Options.UseFont = true;
            this.paymentPriceCurrencyTBox.Properties.Appearance.Options.UseTextOptions = true;
            this.paymentPriceCurrencyTBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.paymentPriceCurrencyTBox.Properties.Mask.EditMask = "n2";
            this.paymentPriceCurrencyTBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.paymentPriceCurrencyTBox.Size = new System.Drawing.Size(142, 20);
            this.paymentPriceCurrencyTBox.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(160, 59);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 13);
            this.labelControl6.TabIndex = 81;
            this.labelControl6.Text = "Сума у валюті";
            // 
            // paymentPriceTBox
            // 
            this.paymentPriceTBox.EditValue = "0,00";
            this.paymentPriceTBox.Location = new System.Drawing.Point(12, 78);
            this.paymentPriceTBox.Name = "paymentPriceTBox";
            this.paymentPriceTBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.paymentPriceTBox.Properties.Appearance.Options.UseFont = true;
            this.paymentPriceTBox.Properties.Appearance.Options.UseTextOptions = true;
            this.paymentPriceTBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.paymentPriceTBox.Properties.Mask.EditMask = "n2";
            this.paymentPriceTBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.paymentPriceTBox.Size = new System.Drawing.Size(142, 20);
            this.paymentPriceTBox.TabIndex = 2;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(12, 59);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(68, 13);
            this.labelControl15.TabIndex = 80;
            this.labelControl15.Text = "Сума у гривні";
            // 
            // vatPayment6412TBox
            // 
            this.vatPayment6412TBox.EditValue = "0,00";
            this.vatPayment6412TBox.Location = new System.Drawing.Point(5, 43);
            this.vatPayment6412TBox.Name = "vatPayment6412TBox";
            this.vatPayment6412TBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.vatPayment6412TBox.Properties.Appearance.Options.UseFont = true;
            this.vatPayment6412TBox.Properties.Appearance.Options.UseTextOptions = true;
            this.vatPayment6412TBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.vatPayment6412TBox.Properties.Mask.EditMask = "n2";
            this.vatPayment6412TBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.vatPayment6412TBox.Size = new System.Drawing.Size(130, 20);
            this.vatPayment6412TBox.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 87;
            this.labelControl1.Text = "641/2";
            // 
            // detailsEdit
            // 
            this.detailsEdit.Location = new System.Drawing.Point(12, 168);
            this.detailsEdit.Name = "detailsEdit";
            this.detailsEdit.Size = new System.Drawing.Size(722, 162);
            this.detailsEdit.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 149);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 89;
            this.labelControl2.Text = "Примітки";
            // 
            // cpvCodeEdit
            // 
            this.cpvCodeEdit.Location = new System.Drawing.Point(308, 123);
            this.cpvCodeEdit.Name = "cpvCodeEdit";
            this.cpvCodeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("cpvCodeEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.cpvCodeEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cpvCodeEdit.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cpvCodeEdit_Properties_ButtonClick);
            this.cpvCodeEdit.Size = new System.Drawing.Size(142, 22);
            this.cpvCodeEdit.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl3.Location = new System.Drawing.Point(12, 104);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 13);
            this.labelControl3.TabIndex = 91;
            this.labelControl3.Text = "ДК 016:2010";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl4.Location = new System.Drawing.Point(160, 104);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 13);
            this.labelControl4.TabIndex = 93;
            this.labelControl4.Text = "УКТЗЄД 2016";
            // 
            // uktvCodeEdit
            // 
            this.uktvCodeEdit.Location = new System.Drawing.Point(160, 123);
            this.uktvCodeEdit.Name = "uktvCodeEdit";
            this.uktvCodeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("uktvCodeEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.uktvCodeEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.uktvCodeEdit.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.uktvCodeEdit_Properties_ButtonClick);
            this.uktvCodeEdit.Size = new System.Drawing.Size(142, 22);
            this.uktvCodeEdit.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl7.Location = new System.Drawing.Point(308, 104);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(72, 13);
            this.labelControl7.TabIndex = 95;
            this.labelControl7.Text = "ДК 021:2015";
            // 
            // dkppCodeEdit
            // 
            this.dkppCodeEdit.Location = new System.Drawing.Point(12, 121);
            this.dkppCodeEdit.Name = "dkppCodeEdit";
            this.dkppCodeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("dkppCodeEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.dkppCodeEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dkppCodeEdit.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.dkppCodeEdit_Properties_ButtonClick);
            this.dkppCodeEdit.Size = new System.Drawing.Size(142, 22);
            this.dkppCodeEdit.TabIndex = 9;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(659, 361);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 21);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(579, 361);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 21);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.vatPayment643TBox);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.vatPayment6412TBox);
            this.groupControl1.Location = new System.Drawing.Point(465, 60);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(269, 85);
            this.groupControl1.TabIndex = 98;
            this.groupControl1.Text = "ПДВ";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(141, 23);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(18, 13);
            this.labelControl8.TabIndex = 89;
            this.labelControl8.Text = "643";
            // 
            // vatPayment643TBox
            // 
            this.vatPayment643TBox.EditValue = "0,00";
            this.vatPayment643TBox.Location = new System.Drawing.Point(141, 43);
            this.vatPayment643TBox.Name = "vatPayment643TBox";
            this.vatPayment643TBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.vatPayment643TBox.Properties.Appearance.Options.UseFont = true;
            this.vatPayment643TBox.Properties.Appearance.Options.UseTextOptions = true;
            this.vatPayment643TBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.vatPayment643TBox.Properties.Mask.EditMask = "n2";
            this.vatPayment643TBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.vatPayment643TBox.Size = new System.Drawing.Size(123, 20);
            this.vatPayment643TBox.TabIndex = 6;
            // 
            // CalcWithBuyersSpecEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(746, 400);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.dkppCodeEdit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.uktvCodeEdit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cpvCodeEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.detailsEdit);
            this.Controls.Add(this.quantityTBox);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.paymentPriceCurrencyTBox);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.paymentPriceTBox);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.orderNumberLbl);
            this.Controls.Add(this.customerOrdersSpecEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcWithBuyersSpecEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагування специфікації";
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersSpecEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPriceCurrencyTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPriceTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatPayment6412TBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpvCodeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uktvCodeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dkppCodeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vatPayment643TBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit customerOrdersSpecEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl orderNumberLbl;
        private DevExpress.XtraEditors.TextEdit quantityTBox;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit paymentPriceCurrencyTBox;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit paymentPriceTBox;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit vatPayment6412TBox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit detailsEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit cpvCodeEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ButtonEdit uktvCodeEdit;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ButtonEdit dkppCodeEdit;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraGrid.Columns.GridColumn nameCol;
        private DevExpress.XtraGrid.Columns.GridColumn quantityCol;
        private DevExpress.XtraGrid.Columns.GridColumn singlePriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn sumPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn singleCurrencyPriceCol;
        private DevExpress.XtraGrid.Columns.GridColumn sumCurrencyPriceCol;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit vatPayment643TBox;
        private DevExpress.XtraGrid.Columns.GridColumn customerOrderNumberCol;
    }
}