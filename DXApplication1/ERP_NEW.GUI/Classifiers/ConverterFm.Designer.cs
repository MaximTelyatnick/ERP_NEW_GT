namespace ERP_NEW.GUI.Classifiers
{
    partial class ConverterFm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConverterFm));
            this.converterLbl = new System.Windows.Forms.Label();
            this.converterOFD = new System.Windows.Forms.OpenFileDialog();
            this.converterBtnBrow = new System.Windows.Forms.Button();
            this.converterBtnConver = new System.Windows.Forms.Button();
            this.converterChekName = new System.Windows.Forms.CheckBox();
            this.converterPrgsBar = new System.Windows.Forms.ProgressBar();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.converterTxtPath = new DevExpress.XtraEditors.TextEdit();
            this.converterTxtName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.converterTxtPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.converterTxtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // converterLbl
            // 
            this.converterLbl.AutoSize = true;
            this.converterLbl.Location = new System.Drawing.Point(12, 19);
            this.converterLbl.Name = "converterLbl";
            this.converterLbl.Size = new System.Drawing.Size(102, 13);
            this.converterLbl.TabIndex = 0;
            this.converterLbl.Text = "Вибиріть XML файл";
            // 
            // converterOFD
            // 
            this.converterOFD.FileName = "openFileDialog1";
            // 
            // converterBtnBrow
            // 
            this.converterBtnBrow.Location = new System.Drawing.Point(313, 34);
            this.converterBtnBrow.Name = "converterBtnBrow";
            this.converterBtnBrow.Size = new System.Drawing.Size(75, 23);
            this.converterBtnBrow.TabIndex = 1;
            this.converterBtnBrow.Text = "Вибрати";
            this.converterBtnBrow.UseVisualStyleBackColor = true;
            this.converterBtnBrow.Click += new System.EventHandler(this.converterBtnBrow_Click);
            // 
            // converterBtnConver
            // 
            this.converterBtnConver.Location = new System.Drawing.Point(15, 125);
            this.converterBtnConver.Name = "converterBtnConver";
            this.converterBtnConver.Size = new System.Drawing.Size(372, 23);
            this.converterBtnConver.TabIndex = 2;
            this.converterBtnConver.Text = "Конвертувати";
            this.converterBtnConver.UseVisualStyleBackColor = true;
            this.converterBtnConver.Click += new System.EventHandler(this.converterBtnConver_Click);
            // 
            // converterChekName
            // 
            this.converterChekName.AutoSize = true;
            this.converterChekName.Location = new System.Drawing.Point(22, 82);
            this.converterChekName.Name = "converterChekName";
            this.converterChekName.Size = new System.Drawing.Size(139, 17);
            this.converterChekName.TabIndex = 3;
            this.converterChekName.Text = "Найменування в Excel ";
            this.converterChekName.UseVisualStyleBackColor = true;
            // 
            // converterPrgsBar
            // 
            this.converterPrgsBar.Location = new System.Drawing.Point(18, 124);
            this.converterPrgsBar.Name = "converterPrgsBar";
            this.converterPrgsBar.Size = new System.Drawing.Size(282, 23);
            this.converterPrgsBar.TabIndex = 6;
            this.converterPrgsBar.Visible = false;
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(11, 105);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(266, 13);
            this.validateLbl.TabIndex = 40;
            this.validateLbl.Text = "*Для конвертування, заповніть всі обов\'язкові поля";
            // 
            // dxValidationProvider
            // 
            this.dxValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.dxValidationProvider_ValidationFailed);
            this.dxValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.dxValidationProvider_ValidationSucceeded);
            // 
            // converterTxtPath
            // 
            this.converterTxtPath.Location = new System.Drawing.Point(11, 37);
            this.converterTxtPath.Name = "converterTxtPath";
            this.converterTxtPath.Size = new System.Drawing.Size(289, 20);
            this.converterTxtPath.TabIndex = 41;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Не коректне имч";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.converterTxtPath, conditionValidationRule1);
            this.converterTxtPath.EditValueChanged += new System.EventHandler(this.nameEdit_EditValueChanged);
            // 
            // converterTxtName
            // 
            this.converterTxtName.Location = new System.Drawing.Point(167, 79);
            this.converterTxtName.Name = "converterTxtName";
            this.converterTxtName.Size = new System.Drawing.Size(220, 20);
            this.converterTxtName.TabIndex = 42;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Не коректне ім\'я";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider.SetValidationRule(this.converterTxtName, conditionValidationRule2);
            this.converterTxtName.EditValueChanged += new System.EventHandler(this.converterTxtName_EditValueChanged);
            // 
            // ConverterFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 168);
            this.Controls.Add(this.converterBtnConver);
            this.Controls.Add(this.converterTxtName);
            this.Controls.Add(this.converterTxtPath);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.converterPrgsBar);
            this.Controls.Add(this.converterChekName);
            this.Controls.Add(this.converterBtnBrow);
            this.Controls.Add(this.converterLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConverterFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертер";
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.converterTxtPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.converterTxtName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label converterLbl;
        private System.Windows.Forms.OpenFileDialog converterOFD;
        private System.Windows.Forms.Button converterBtnBrow;
        private System.Windows.Forms.Button converterBtnConver;
        private System.Windows.Forms.CheckBox converterChekName;
        private System.Windows.Forms.ProgressBar converterPrgsBar;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private DevExpress.XtraEditors.TextEdit converterTxtPath;
        private DevExpress.XtraEditors.TextEdit converterTxtName;
    }
}