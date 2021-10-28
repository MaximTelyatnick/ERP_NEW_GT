namespace ERP_NEW.GUI.Classifiers
{
    partial class WeldWpsEditFm
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
            this.closeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.wireDiameterEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.seamSizeZEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.seamSizeAEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.wpqrEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.wpsEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.layerMarkEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.materialThicknessEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.connectionTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.weldPositionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.wireDiameterEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seamSizeZEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seamSizeAEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wpqrEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wpsEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layerMarkEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialThicknessEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionTypeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldPositionLookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(328, 351);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 33;
            this.closeBtn.Text = "Відміна";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(247, 351);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 32;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // wireDiameterEdit
            // 
            this.wireDiameterEdit.Location = new System.Drawing.Point(12, 32);
            this.wireDiameterEdit.Name = "wireDiameterEdit";
            this.wireDiameterEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.wireDiameterEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.wireDiameterEdit.Size = new System.Drawing.Size(391, 20);
            this.wireDiameterEdit.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "Ø дроту, мм";
            // 
            // seamSizeZEdit
            // 
            this.seamSizeZEdit.Location = new System.Drawing.Point(24, 77);
            this.seamSizeZEdit.Name = "seamSizeZEdit";
            this.seamSizeZEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.seamSizeZEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.seamSizeZEdit.Size = new System.Drawing.Size(182, 20);
            this.seamSizeZEdit.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Розмір шва, мм";
            // 
            // seamSizeAEdit
            // 
            this.seamSizeAEdit.Location = new System.Drawing.Point(237, 77);
            this.seamSizeAEdit.Name = "seamSizeAEdit";
            this.seamSizeAEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.seamSizeAEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.seamSizeAEdit.Size = new System.Drawing.Size(166, 20);
            this.seamSizeAEdit.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(12, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(7, 13);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Z";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(226, 80);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(9, 13);
            this.labelControl4.TabIndex = 40;
            this.labelControl4.Text = "A";
            // 
            // wpqrEdit
            // 
            this.wpqrEdit.Location = new System.Drawing.Point(49, 169);
            this.wpqrEdit.Name = "wpqrEdit";
            this.wpqrEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.wpqrEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.wpqrEdit.Size = new System.Drawing.Size(157, 20);
            this.wpqrEdit.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 150);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 13);
            this.labelControl5.TabIndex = 41;
            this.labelControl5.Text = "Номер документу";
            // 
            // wpsEdit
            // 
            this.wpsEdit.Location = new System.Drawing.Point(237, 169);
            this.wpsEdit.Name = "wpsEdit";
            this.wpsEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.wpsEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.wpsEdit.Size = new System.Drawing.Size(166, 20);
            this.wpsEdit.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(12, 172);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 13);
            this.labelControl6.TabIndex = 43;
            this.labelControl6.Text = "WPQR";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Location = new System.Drawing.Point(211, 172);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(25, 13);
            this.labelControl7.TabIndex = 45;
            this.labelControl7.Text = "WPS";
            // 
            // layerMarkEdit
            // 
            this.layerMarkEdit.Location = new System.Drawing.Point(12, 214);
            this.layerMarkEdit.Name = "layerMarkEdit";
            this.layerMarkEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.layerMarkEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.layerMarkEdit.Size = new System.Drawing.Size(391, 20);
            this.layerMarkEdit.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 195);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(77, 13);
            this.labelControl8.TabIndex = 46;
            this.labelControl8.Text = "Кількість шарів";
            // 
            // materialThicknessEdit
            // 
            this.materialThicknessEdit.Location = new System.Drawing.Point(12, 259);
            this.materialThicknessEdit.Name = "materialThicknessEdit";
            this.materialThicknessEdit.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.materialThicknessEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.materialThicknessEdit.Size = new System.Drawing.Size(391, 20);
            this.materialThicknessEdit.TabIndex = 8;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 240);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(194, 13);
            this.labelControl9.TabIndex = 48;
            this.labelControl9.Text = "Товщина зварюваного матеріалу t, мм";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(12, 285);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(122, 13);
            this.labelControl10.TabIndex = 50;
            this.labelControl10.Text = "Положення зварювання";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(12, 105);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(70, 13);
            this.labelControl11.TabIndex = 52;
            this.labelControl11.Text = "Тип з\'єднання";
            // 
            // connectionTypeLookUpEdit
            // 
            this.connectionTypeLookUpEdit.Location = new System.Drawing.Point(12, 124);
            this.connectionTypeLookUpEdit.Name = "connectionTypeLookUpEdit";
            this.connectionTypeLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.connectionTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.connectionTypeLookUpEdit.Properties.ImmediatePopup = true;
            this.connectionTypeLookUpEdit.Properties.PopupSizeable = false;
            this.connectionTypeLookUpEdit.Properties.PopupWidth = 553;
            this.connectionTypeLookUpEdit.Properties.ShowHeader = false;
            this.connectionTypeLookUpEdit.Size = new System.Drawing.Size(391, 20);
            this.connectionTypeLookUpEdit.TabIndex = 4;
            // 
            // weldPositionLookUpEdit
            // 
            this.weldPositionLookUpEdit.Location = new System.Drawing.Point(12, 304);
            this.weldPositionLookUpEdit.Name = "weldPositionLookUpEdit";
            this.weldPositionLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.weldPositionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldPositionLookUpEdit.Properties.ImmediatePopup = true;
            this.weldPositionLookUpEdit.Properties.PopupWidth = 553;
            this.weldPositionLookUpEdit.Size = new System.Drawing.Size(391, 20);
            this.weldPositionLookUpEdit.TabIndex = 9;
            // 
            // WeldWpsEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 386);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.materialThicknessEdit);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.layerMarkEdit);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.wpsEdit);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.wpqrEdit);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.seamSizeAEdit);
            this.Controls.Add(this.seamSizeZEdit);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.wireDiameterEdit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.connectionTypeLookUpEdit);
            this.Controls.Add(this.weldPositionLookUpEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeldWpsEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Створення WPS";
            ((System.ComponentModel.ISupportInitialize)(this.wireDiameterEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seamSizeZEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seamSizeAEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wpqrEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wpsEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layerMarkEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialThicknessEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionTypeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldPositionLookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton closeBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.TextEdit wireDiameterEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit seamSizeZEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit seamSizeAEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit wpqrEdit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit wpsEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit layerMarkEdit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit materialThicknessEdit;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LookUpEdit connectionTypeLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit weldPositionLookUpEdit;
    }
}