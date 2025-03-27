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
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;

namespace ERP_NEW.GUI.Accounting
{
    public partial class FixedAssetsOrderGroupEditFm : DevExpress.XtraEditors.XtraForm
    {

        private IFixedAssetsOrderService fixedassetsOrderService;
        private BindingSource groupBS = new BindingSource();
        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return groupBS.Current as ObjectBase; }
            set
            {
                groupBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public FixedAssetsOrderGroupEditFm(Utils.Operation operation, FixedAssetsGroupDTO model)
        {
            InitializeComponent();

            this.operation = operation;
            groupBS.DataSource = Item = model;

            fixedAssetsGroupNameEdit.DataBindings.Add("EditValue", groupBS, "Name");
            //fixedAssetsGroupNameEdit.DataBindings.Add("EditValue", groupBS, "AmortizationFactor");
            //fixedAssetsGroupNameEdit.DataBindings.Add("EditValue", groupBS, "UsefulPeriod");

            fixedAssetsGroupValidationProvider.Validate();
        }



        #region Method's

        private void LoadData()
        {
            fixedassetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            //contractorBS.DataSource = contractorService.GetContractors();
        }

        public long Return()
        {
            return ((FixedAssetsGroupDTO)Item).Id;
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();

            fixedassetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();

            if (operation == Utils.Operation.Add)
            {
                ((FixedAssetsGroupDTO)Item).Id = fixedassetsOrderService.FixedAssetsOrderGroupCreate((FixedAssetsGroupDTO)Item);
            }
            else
            {
                fixedassetsOrderService.FixedAssetsOrderGroupUpdate((FixedAssetsGroupDTO)Item);
            }
            return true;
        }
        #endregion

        private void fixedAssetsGroupValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {

        }

        private void fixedAssetsGroupValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {

        }
    }
}