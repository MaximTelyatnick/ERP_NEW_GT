namespace ERP_NEW.GUI.Tools
{
    partial class UserAuthFm
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
            this.loginEdit = new DevExpress.XtraEditors.TextEdit();
            this.passEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.authBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loginEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // loginEdit
            // 
            this.loginEdit.Location = new System.Drawing.Point(92, 12);
            this.loginEdit.Name = "loginEdit";
            this.loginEdit.Properties.Mask.BeepOnError = true;
            this.loginEdit.Properties.Mask.IgnoreMaskBlank = false;
            this.loginEdit.Properties.Mask.SaveLiteral = false;
            this.loginEdit.Size = new System.Drawing.Size(128, 20);
            this.loginEdit.TabIndex = 0;
            this.loginEdit.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // passEdit
            // 
            this.passEdit.Location = new System.Drawing.Point(92, 38);
            this.passEdit.Name = "passEdit";
            this.passEdit.Properties.PasswordChar = '*';
            this.passEdit.Properties.UseSystemPasswordChar = true;
            this.passEdit.Size = new System.Drawing.Size(128, 20);
            this.passEdit.TabIndex = 1;
            this.passEdit.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Location = new System.Drawing.Point(6, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Логін:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Location = new System.Drawing.Point(6, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Пароль:";
            // 
            // authBtn
            // 
            this.authBtn.Location = new System.Drawing.Point(114, 78);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(106, 23);
            this.authBtn.TabIndex = 4;
            this.authBtn.Text = "Авторизуватися";
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(6, 78);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(102, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // dxValidationProvider
            // 
            this.dxValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.dxValidationProvider_ValidationFailed);
            this.dxValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.dxValidationProvider_ValidationSucceeded);
            // 
            // UserAuthFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 112);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.authBtn);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.passEdit);
            this.Controls.Add(this.loginEdit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAuthFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизація";
            ((System.ComponentModel.ISupportInitialize)(this.loginEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit loginEdit;
        private DevExpress.XtraEditors.TextEdit passEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton authBtn;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
    }
}