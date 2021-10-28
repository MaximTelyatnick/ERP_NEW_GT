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
using ERP_NEW.BLL.DTO.SelectedDTO;
using Ninject;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class InvoiceRequirementSelectedEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;

        private BindingSource invoiceRequirementExpenditureInfoBS = new BindingSource();

        private List<InvoiceRequirementExpenditureInfoDTO> returnInvoiceRequirementExpenditureList = new List<InvoiceRequirementExpenditureInfoDTO>();

        public InvoiceRequirementSelectedEditFm()
        {
            InitializeComponent();

            firstDateEdit.EditValue = new DateTime(DateTime.Now.AddMonths(-1).Year, DateTime.Now.AddMonths(-1).Month, 1);
            lastDateEdit.EditValue = DateTime.Now;

            LoadData((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
        }

        private void LoadData(DateTime firstDateEdit, DateTime lastDateEdit)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            invoiceRequirementExpenditureInfoBS.DataSource = storeHouseService.GetInvoiceRequirementExpenditureInfo(firstDateEdit, lastDateEdit);
            invoiceRequirementExpenditureInfoGrid.DataSource = invoiceRequirementExpenditureInfoBS;
        }

        public List<InvoiceRequirementExpenditureInfoDTO> Return()
        {
            return returnInvoiceRequirementExpenditureList;
        }

        private void viewBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            invoiceRequirementExpenditureInfoGridView.PostEditor();

            returnInvoiceRequirementExpenditureList = ((List<InvoiceRequirementExpenditureInfoDTO>)invoiceRequirementExpenditureInfoBS.DataSource).Where(s => s.Selected).ToList();

            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}