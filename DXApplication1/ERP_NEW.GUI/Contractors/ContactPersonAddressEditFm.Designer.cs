namespace ERP_NEW.GUI.Contractors
{
    partial class ContactPersonAddressEditFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactPersonAddressEditFm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.detailsTBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.contactKindsEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.contactTypesEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.fioEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.additionInfoTBox = new DevExpress.XtraEditors.TextEdit();
            this.professionTBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactKindsEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTypesEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fioEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionInfoTBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionTBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(590, 331);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(87, 28);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(490, 331);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 28);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.detailsTBox);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.contactKindsEdit);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.contactTypesEdit);
            this.groupControl1.Location = new System.Drawing.Point(8, 178);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(673, 137);
            this.groupControl1.TabIndex = 30;
            this.groupControl1.Text = "Інформація";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(370, 47);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(21, 16);
            this.labelControl3.TabIndex = 35;
            this.labelControl3.Text = "Вид";
            // 
            // detailsTBox
            // 
            this.detailsTBox.Location = new System.Drawing.Point(92, 91);
            this.detailsTBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.detailsTBox.Name = "detailsTBox";
            this.detailsTBox.Size = new System.Drawing.Size(570, 22);
            this.detailsTBox.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 95);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 16);
            this.labelControl2.TabIndex = 34;
            this.labelControl2.Text = "Інформація";
            // 
            // contactKindsEdit
            // 
            this.contactKindsEdit.Location = new System.Drawing.Point(401, 43);
            this.contactKindsEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contactKindsEdit.Name = "contactKindsEdit";
            this.contactKindsEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.contactKindsEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KindName", "Вид інформації")});
            this.contactKindsEdit.Properties.ShowHeader = false;
            this.contactKindsEdit.Size = new System.Drawing.Size(261, 22);
            this.contactKindsEdit.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(7, 47);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(89, 16);
            this.labelControl6.TabIndex = 33;
            this.labelControl6.Text = "Тип інформації";
            // 
            // contactTypesEdit
            // 
            this.contactTypesEdit.Location = new System.Drawing.Point(92, 43);
            this.contactTypesEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contactTypesEdit.Name = "contactTypesEdit";
            this.contactTypesEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.contactTypesEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeName", "Тип інформації")});
            this.contactTypesEdit.Properties.ShowHeader = false;
            this.contactTypesEdit.Size = new System.Drawing.Size(250, 22);
            this.contactTypesEdit.TabIndex = 4;
            this.contactTypesEdit.EditValueChanged += new System.EventHandler(this.contactTypesEdit_EditValueChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.fioEdit);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.additionInfoTBox);
            this.groupControl2.Controls.Add(this.professionTBox);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(9, 6);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(672, 165);
            this.groupControl2.TabIndex = 31;
            this.groupControl2.Text = "Контактна особа";
            // 
            // fioEdit
            // 
            this.fioEdit.Location = new System.Drawing.Point(86, 33);
            this.fioEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fioEdit.Name = "fioEdit";
            this.fioEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("fioEdit.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("fioEdit.Properties.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("fioEdit.Properties.Buttons2"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("fioEdit.Properties.Buttons3"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.fioEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fio", "ПІБ")});
            this.fioEdit.Properties.ShowHeader = false;
            this.fioEdit.Size = new System.Drawing.Size(575, 24);
            this.fioEdit.TabIndex = 0;
            this.fioEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.fioEdit_ButtonClick);
            this.fioEdit.EditValueChanged += new System.EventHandler(this.fioEdit_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.AllowHtmlString = true;
            this.labelControl8.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl8.Location = new System.Drawing.Point(7, 117);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(70, 32);
            this.labelControl8.TabIndex = 44;
            this.labelControl8.Text = "Додаткова <br> інформація";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(10, 82);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 16);
            this.labelControl7.TabIndex = 43;
            this.labelControl7.Text = "Професія";
            // 
            // additionInfoTBox
            // 
            this.additionInfoTBox.AllowDrop = true;
            this.additionInfoTBox.Enabled = false;
            this.additionInfoTBox.Location = new System.Drawing.Point(86, 124);
            this.additionInfoTBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.additionInfoTBox.Name = "additionInfoTBox";
            this.additionInfoTBox.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.additionInfoTBox.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.additionInfoTBox.Size = new System.Drawing.Size(575, 22);
            this.additionInfoTBox.TabIndex = 3;
            // 
            // professionTBox
            // 
            this.professionTBox.AllowDrop = true;
            this.professionTBox.Enabled = false;
            this.professionTBox.Location = new System.Drawing.Point(86, 79);
            this.professionTBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.professionTBox.Name = "professionTBox";
            this.professionTBox.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.professionTBox.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.professionTBox.Size = new System.Drawing.Size(575, 22);
            this.professionTBox.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 38);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 16);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "ПІБ";
            // 
            // ContactPersonAddressEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 373);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactPersonAddressEditFm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Інформація по контактній особі";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactKindsEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTypesEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fioEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionInfoTBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionTBox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit detailsTBox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit contactKindsEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit contactTypesEdit;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit additionInfoTBox;
        private DevExpress.XtraEditors.TextEdit professionTBox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit fioEdit;
    }
}