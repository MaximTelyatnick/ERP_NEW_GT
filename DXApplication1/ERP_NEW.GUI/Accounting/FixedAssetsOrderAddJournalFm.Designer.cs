namespace ERP_NEW.GUI.Accounting
{
    partial class FixedAssetsOrderAddJournalFm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dateLabel = new DevExpress.XtraEditors.LabelControl();
            this.nameFixedAssetsOrder = new DevExpress.XtraEditors.LabelControl();
            this.orderRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.numberOrderEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOrderEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dateLabel);
            this.panelControl1.Controls.Add(this.nameFixedAssetsOrder);
            this.panelControl1.Controls.Add(this.orderRadioGroup);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.cancelBtn);
            this.panelControl1.Controls.Add(this.saveBtn);
            this.panelControl1.Controls.Add(this.numberOrderEdit);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(369, 235);
            this.panelControl1.TabIndex = 0;
            // 
            // dateLabel
            // 
            this.dateLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dateLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dateLabel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Location = new System.Drawing.Point(99, 38);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(70, 14);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "labelControl3";
            // 
            // nameFixedAssetsOrder
            // 
            this.nameFixedAssetsOrder.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nameFixedAssetsOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.nameFixedAssetsOrder.Appearance.ForeColor = System.Drawing.Color.Black;
            this.nameFixedAssetsOrder.Location = new System.Drawing.Point(12, 12);
            this.nameFixedAssetsOrder.Name = "nameFixedAssetsOrder";
            this.nameFixedAssetsOrder.Size = new System.Drawing.Size(70, 14);
            this.nameFixedAssetsOrder.TabIndex = 7;
            this.nameFixedAssetsOrder.Text = "labelControl3";
            // 
            // orderRadioGroup
            // 
            this.orderRadioGroup.Location = new System.Drawing.Point(12, 69);
            this.orderRadioGroup.Name = "orderRadioGroup";
            this.orderRadioGroup.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.orderRadioGroup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.orderRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.orderRadioGroup.Properties.Appearance.Options.UseFont = true;
            this.orderRadioGroup.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.orderRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Наказ на введення", true, ((short)(1))),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("2", "Наказ на збільшення вартості", true, ((short)(2))),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("3", "Наказ на продаж/списання", true, ((short)(3)))});
            this.orderRadioGroup.Size = new System.Drawing.Size(345, 96);
            this.orderRadioGroup.TabIndex = 6;
            this.orderRadioGroup.SelectedIndexChanged += new System.EventHandler(this.orderRadioGroup_SelectedIndexChanged);
            this.orderRadioGroup.FormatEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(this.orderRadioGroup_FormatEditValue);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(12, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Дата наказу";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(282, 200);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(201, 200);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // numberOrderEdit
            // 
            this.numberOrderEdit.Location = new System.Drawing.Point(99, 171);
            this.numberOrderEdit.Name = "numberOrderEdit";
            this.numberOrderEdit.Properties.Mask.EditMask = "d";
            this.numberOrderEdit.Size = new System.Drawing.Size(258, 20);
            this.numberOrderEdit.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(12, 174);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Номер наказу";
            // 
            // FixedAssetsOrderAddJournalFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 235);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FixedAssetsOrderAddJournalFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Створення наказу";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOrderEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.TextEdit numberOrderEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.RadioGroup orderRadioGroup;
        private DevExpress.XtraEditors.LabelControl nameFixedAssetsOrder;
        private DevExpress.XtraEditors.LabelControl dateLabel;
    }
}