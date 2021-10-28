namespace ERP_NEW.GUI.Classifiers
{
    partial class InfoFormFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoFormFm));
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.imageSlider2 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.printBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageSlider1
            // 
            this.imageSlider1.CurrentImageIndex = -1;
            this.imageSlider1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
            this.imageSlider1.Location = new System.Drawing.Point(0, 0);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(1135, 419);
            this.imageSlider1.TabIndex = 0;
            this.imageSlider1.UseDisabledStatePainter = true;
            // 
            // imageSlider2
            // 
            this.imageSlider2.CurrentImageIndex = 0;
            this.imageSlider2.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider2.Images"))));
            this.imageSlider2.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
            this.imageSlider2.Location = new System.Drawing.Point(0, 43);
            this.imageSlider2.Name = "imageSlider2";
            this.imageSlider2.Size = new System.Drawing.Size(1135, 315);
            this.imageSlider2.TabIndex = 1;
            this.imageSlider2.Text = "imageSlider2";
            this.imageSlider2.UseDisabledStatePainter = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.LineColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(129, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(794, 23);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Перед друком табелю в файлі Excel необхідно натиснути кнопку  \"Включить содержимо" +
    "е\"";
            // 
            // printBtn
            // 
            this.printBtn.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.printBtn.Appearance.BackColor2 = System.Drawing.Color.Aquamarine;
            this.printBtn.Appearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.printBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.printBtn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.printBtn.Appearance.Options.UseBackColor = true;
            this.printBtn.Appearance.Options.UseBorderColor = true;
            this.printBtn.Appearance.Options.UseFont = true;
            this.printBtn.Appearance.Options.UseForeColor = true;
            this.printBtn.Location = new System.Drawing.Point(987, 361);
            this.printBtn.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(141, 54);
            this.printBtn.TabIndex = 3;
            this.printBtn.Text = "Перейти до друку";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // InfoFormFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 419);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.imageSlider2);
            this.Controls.Add(this.imageSlider1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoFormFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Інформаційне вікно";
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton printBtn;
    }
}