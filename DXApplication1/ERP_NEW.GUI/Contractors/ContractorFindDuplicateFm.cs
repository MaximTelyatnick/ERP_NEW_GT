﻿using System;
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
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;

namespace ERP_NEW.GUI.Contractors
{
    public partial class ContractorFindDuplicateFm : DevExpress.XtraEditors.XtraForm
    {
        private ICustomerOrdersService customerOrdersService;
        private IContractorsService contractorsService;
        private ICurrencyService currencyService;
        private IMtsSpecificationsService mtsSpecificationService;

        private IBankPaymentsService bankPaymentsService;
        private IBusinessTripsService businessTripsService;


        private BindingSource contractorsMainBS = new BindingSource();
        private BindingSource contractorsReplaceBS = new BindingSource();
        private List<AgreementOrderDTO> agreementOrderByAgreementId = new List<AgreementOrderDTO>();
        private List<AgreementOrderDTO> agreementOrderByContractorId = new List<AgreementOrderDTO>();
        private List<AgreementsDTO> agreementByAgreementId = new List<AgreementsDTO>();
        private List<AgreementsDTO> agreementByContractorId = new List<AgreementsDTO>();
        private List<Bank_PaymentsDTO> bankPayments = new List<Bank_PaymentsDTO>();
        private List<BusinessTripsDTO> businessTripsByContractorId = new List<BusinessTripsDTO>();
        private List<BusinessTripsDTO> businessTripsByDepartureId = new List<BusinessTripsDTO>();


        private UserTasksDTO userTasksDTO;
        public ContractorFindDuplicateFm(UserTasksDTO userTaskDTO)
        {
            InitializeComponent();
            this.userTasksDTO = userTaskDTO;

            LoadData();

            contractorsMainEdit.DataBindings.Add("EditValue", contractorsMainBS, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            contractorsMainEdit.Properties.DataSource = contractorsMainBS;
            contractorsMainEdit.Properties.ValueMember = "Id";
            contractorsMainEdit.Properties.DisplayMember = "Name";
            contractorsMainEdit.Properties.NullText = "Немає данних";

            contractorsReplaceEdit.DataBindings.Add("EditValue", contractorsReplaceBS, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            contractorsReplaceEdit.Properties.DataSource = contractorsReplaceBS;
            contractorsReplaceEdit.Properties.ValueMember = "Id";
            contractorsReplaceEdit.Properties.DisplayMember = "Name";
            contractorsReplaceEdit.Properties.NullText = "Немає данних";

        }

        private void LoadData()
        {
            contractorsService = Program.kernel.Get<IContractorsService>();

            contractorsMainBS.DataSource = contractorsService.GetContractors(1); // 1 - все данные, 2 - только контрагенты без договоров, 3 - только договора
            contractorsReplaceBS.DataSource = contractorsService.GetContractors(1);
            
        }

        private void LoadFullDataByContractorId(int contractorId)
        {
            contractorsService = Program.kernel.Get<IContractorsService>();
            bankPaymentsService = Program.kernel.Get<IBankPaymentsService>();
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            //знаходимо усі договори по цьому контрагенту
            agreementOrderByAgreementId = contractorsService.GetAgreementOrder().Where(srch => srch.AgreementId == contractorId).ToList();
            agreementOrderByContractorId = contractorsService.GetAgreementOrder().Where(srch => srch.ContractorId == contractorId).ToList();
            agreementByAgreementId = contractorsService.GetAgreements().Where(srch => srch.AgreementsIdFromContractor == contractorId).ToList();
            agreementByContractorId = contractorsService.GetAgreements().Where(srch => srch.ContractorId == contractorId).ToList();
            bankPayments = bankPaymentsService.GetBankPayments().Where(srch => srch.Contractor_Id == contractorId).ToList();
            businessTripsByContractorId = businessTripsService.GetBusinessTrips().Where(srch => srch.ContractorsID == contractorId).ToList();
            businessTripsByDepartureId = businessTripsService.GetBusinessTrips().Where(srch => srch.DepartureID == contractorId).ToList();


            contractorsMainBS.DataSource = contractorsService.GetContractors(1); // 1 - все данные, 2 - только контрагенты без договоров, 3 - только договора
            contractorsReplaceBS.DataSource = contractorsService.GetContractors(1);

        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}