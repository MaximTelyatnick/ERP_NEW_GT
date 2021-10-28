using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Services;
using ERP_NEW.BLL.DTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraBars;
using Ninject;
using System.IO;
using System.Diagnostics;
using ERP_NEW.BLL.Infrastructure;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ERP_NEW.BLL;
using DevExpress.Data.Filtering;
using System.Reflection;
using System.Collections;
using System.Security.AccessControl;

namespace ERP_NEW.GUI.CustomerOrders
{
    public partial class RequestLogContractorsEditFm : DevExpress.XtraEditors.XtraForm
    {
        private Utils.Operation operation;
        private BindingSource requestLogContractorsBS = new BindingSource();
        private IRequestLogService requestLogService;

        public RequestLogContractorsEditFm(Utils.Operation operation, RequestLogContractorsDTO model)
        {
            InitializeComponent();
            this.operation = operation;
            requestLogContractorsBS.DataSource = model;
            requestLogService = Program.kernel.Get<IRequestLogService>();
            contractorEdit.DataBindings.Add("EditValue", requestLogContractorsBS, "Name", true, DataSourceUpdateMode.OnPropertyChanged);

            if (operation == Utils.Operation.Update)
            {
                contractorEdit.EditValue = model.Name;
            }
            else
            {
                contractorEdit.EditValue = null;
            }
        }

        public int Return()
        {
            return ((RequestLogContractorsDTO)requestLogContractorsBS.Current).Id;
        }

        private bool SaveItem()
        {
            requestLogContractorsBS.EndEdit();
            requestLogService = Program.kernel.Get<IRequestLogService>();
            if (operation == Utils.Operation.Add)
            {
                if (((RequestLogContractorsDTO)requestLogContractorsBS.Current).Name != "")
                    ((RequestLogContractorsDTO)requestLogContractorsBS.Current).Id =
                        requestLogService.RequestLogConractorCreate((RequestLogContractorsDTO)requestLogContractorsBS.Current);
                else
                    return false;
            }
            else
                requestLogService.RequestLogContractorUpdate((RequestLogContractorsDTO)requestLogContractorsBS.Current);
            return true;
        }

        #region Event's
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveItem())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            requestLogContractorsBS.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        #region Validation's
        
        
        private void contractorEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }
        #endregion
    }
}