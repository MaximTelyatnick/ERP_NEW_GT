namespace ERP_NEW.GUI.StoreHouse
{
    partial class StoreHouseListEditFm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.numberStoreHouseEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameStoreHouseEdit = new DevExpress.XtraEditors.TextEdit();
            this.descriptionStoreHouseEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.validateLbl = new DevExpress.XtraEditors.LabelControl();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ERP_NEW.GUI.WaitForm1), true, true);
            this.storeHousesValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numberStoreHouseEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameStoreHouseEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionStoreHouseEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeHousesValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 21);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 16);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "Номер складу:";
            // 
            // numberStoreHouseEdit
            // 
            this.numberStoreHouseEdit.Location = new System.Drawing.Point(177, 13);
            this.numberStoreHouseEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numberStoreHouseEdit.Name = "numberStoreHouseEdit";
            this.numberStoreHouseEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.numberStoreHouseEdit.Properties.Appearance.Options.UseFont = true;
            this.numberStoreHouseEdit.Size = new System.Drawing.Size(500, 24);
            this.numberStoreHouseEdit.TabIndex = 0;
            this.numberStoreHouseEdit.ToolTip = "Номер складу";
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Не введено номер складу";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.storeHousesValidationProvider.SetValidationRule(this.numberStoreHouseEdit, conditionValidationRule1);
            this.numberStoreHouseEdit.TextChanged += new System.EventHandler(this.numberStoreHouseEdit_TextChanged);
            // 
            // nameStoreHouseEdit
            // 
            this.nameStoreHouseEdit.Location = new System.Drawing.Point(177, 60);
            this.nameStoreHouseEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameStoreHouseEdit.Name = "nameStoreHouseEdit";
            this.nameStoreHouseEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.nameStoreHouseEdit.Properties.Appearance.Options.UseFont = true;
            this.nameStoreHouseEdit.Size = new System.Drawing.Size(500, 24);
            this.nameStoreHouseEdit.TabIndex = 1;
            this.nameStoreHouseEdit.ToolTip = "Назва складу";
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Не введено назву складу";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.storeHousesValidationProvider.SetValidationRule(this.nameStoreHouseEdit, conditionValidationRule2);
            this.nameStoreHouseEdit.TextChanged += new System.EventHandler(this.nameStoreHouseEdit_TextChanged);
            // 
            // descriptionStoreHouseEdit
            // 
            this.descriptionStoreHouseEdit.Location = new System.Drawing.Point(177, 107);
            this.descriptionStoreHouseEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descriptionStoreHouseEdit.Name = "descriptionStoreHouseEdit";
            this.descriptionStoreHouseEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.descriptionStoreHouseEdit.Properties.Appearance.Options.UseFont = true;
            this.descriptionStoreHouseEdit.Size = new System.Drawing.Size(500, 24);
            this.descriptionStoreHouseEdit.TabIndex = 2;
            this.descriptionStoreHouseEdit.ToolTip = "Опис складу";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 68);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 16);
            this.labelControl2.TabIndex = 55;
            this.labelControl2.Text = "Назва складу:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 111);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 16);
            this.labelControl3.TabIndex = 56;
            this.labelControl3.Text = "Опис";
            // 
            // validateLbl
            // 
            this.validateLbl.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.validateLbl.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.validateLbl.Location = new System.Drawing.Point(12, 154);
            this.validateLbl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.validateLbl.Name = "validateLbl";
            this.validateLbl.Size = new System.Drawing.Size(295, 16);
            this.validateLbl.TabIndex = 57;
            this.validateLbl.Text = "*Для збереження, заповніть всі обов\'язкові поля";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(590, 148);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(87, 28);
            this.cancelBtn.TabIndex = 59;
            this.cancelBtn.Text = "Відміна";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(494, 148);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 28);
            this.saveBtn.TabIndex = 58;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // storeHousesValidationProvider
            // 
            this.storeHousesValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            this.storeHousesValidationProvider.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.storeHousesValidationProvider_ValidationFailed);
            this.storeHousesValidationProvider.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.storeHousesValidationProvider_ValidationSucceeded);
            // 
            // StoreHouseListEditFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 183);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.validateLbl);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.descriptionStoreHouseEdit);
            this.Controls.Add(this.nameStoreHouseEdit);
            this.Controls.Add(this.numberStoreHouseEdit);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StoreHouseListEditFm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)(this.numberStoreHouseEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameStoreHouseEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionStoreHouseEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeHousesValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit numberStoreHouseEdit;
        private DevExpress.XtraEditors.TextEdit nameStoreHouseEdit;
        private DevExpress.XtraEditors.TextEdit descriptionStoreHouseEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl validateLbl;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider storeHousesValidationProvider;
    }
}