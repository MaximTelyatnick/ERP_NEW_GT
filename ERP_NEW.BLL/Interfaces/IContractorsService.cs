using System.Collections.Generic;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IContractorsService
    {
        IEnumerable<ContractorsDTO> GetContractors(int allData);
        IEnumerable<ContractorContactAddressDTO> GetContractorContactAddress(int contractorId);
        IEnumerable<ContactPersonAddressDTO> GetContactPersonAddress(int contractorId);
        IEnumerable<ProductCategoriesDTO> GetProductCategories();
        IEnumerable<ContractorTypesDTO> GetContractorTypes();
        IEnumerable<ContactTypesDTO> GetContactTypes();
        IEnumerable<ContactKindsDTO> GetContactKinds();
        IEnumerable<ContractorsDTO> GetOwnContractor();
        IEnumerable<ContactPersonsDTO> GetContactPersons(int contractorId);
        bool CheckContractor(ContractorsDTO contractor);
        IEnumerable<AgreementJournalDTO> GetAgreementJournal(DateTime beginDate, DateTime endDate);
        IEnumerable<AgreementDocumentsDTO> GetAgreementsDocuments();
        IEnumerable<AgreementsTypeDTO> GetAgreementsType();
        IEnumerable<AgreementsDTO> GetAgreements();
        IEnumerable<AgreementTypeDocumentsDTO> GetAgreementsTypeDocuments();
        IEnumerable<AgreementDocumentsDTO> GetAgreementDocumentsByAgreementId(int agrementId);
        IEnumerable<AgreementOrderPurposeDTO> GetAgreementOrderPurpose();
        string GetAgreementOrderLastNumber(DateTime date);
        AgreementOrderScanDTO GetAgreementOrderScanById(int? agreementOrderId);
        bool CheckAgreementOrderNumber(DateTime date, string orderNumber);
        IEnumerable<CurrencyDTO> GetAgreementsCurrency();
        IEnumerable<AgreementOrderJournalDTO> GetAgreementOrderJournal(DateTime beginDate, DateTime endDate);

        #region Agreements
        
       
        int AgreementsDocumentsCreate(AgreementDocumentsDTO agreementDocumentsDTO);
        void AgreementsDocumentsUpdate(AgreementDocumentsDTO agreementDocumentsDTO);
        bool AgreementsDocumentsDelete(int id);
        int AgreementsTypeDocumentsCreate(AgreementTypeDocumentsDTO agreementTypeDocuments);
        void AgreementsTypeDocumentsUpdate(AgreementTypeDocumentsDTO agreementTypeDocuments);
        bool AgreementsTypeDocumentsDelete(int id);

        int AgreementsTypeCreate(AgreementsTypeDTO agreementsTypeDTO);
        void AgreementsTypeUpdate(AgreementsTypeDTO agreementsTypeDTO);
        bool AgreementsTypeDelete(int id);

        int AgreementsCreate(AgreementsDTO agreementsDTO);
        void AgreementsUpdate(AgreementsDTO agreementsDTO);
        bool AgreementsDelete(int id);


        int AgreementOrderCreate(AgreementOrderDTO agreementOrderDTO);
        void AgreementsOrderUpdate(AgreementOrderDTO agreementOrderDTO);
        bool AgreementOrderDelete(int id);

        int AgreementOrderPurposeCreate(AgreementOrderPurposeDTO agreementOrderPurposeDTO);
        void AgreementsOrderPurposeUpdate(AgreementOrderPurposeDTO agreementOrderPurposeDTO);
        bool AgreementOrderPurposeDelete(int id);

        int AgreementOrderScanCreate(AgreementOrderScanDTO agreementOrderScanDTO);
        void AgreementsOrderScanUpdate(AgreementOrderScanDTO agreementOrderScanDTO);
        bool AgreementOrderScanDelete(int id);
        #endregion

        #region Contractor     
        
        int ContractorCreate(ContractorsDTO contractor);
        void ContractorUpdate(ContractorsDTO contractor);
        bool ContractorDelete(int id);
        bool ProductCategotyDelete(int id);
        int ProductCategotyCreate(ProductCategoriesDTO productCategoty);
        void ProductCategoryUpdate(ProductCategoriesDTO productCategoty);
        int ContactPersonCreate(ContactPersonsDTO contactPerson);
        void ContactPersonUpdate(ContactPersonsDTO contactPerson);
        bool ContactPersonDelete(int contactPersonId);
        bool ContactPersonAddresDelete(int id);
        bool ContractorContactAddresDelete(int id);
        bool ContractorContacts(int contractorId);
        int ContractorContactAddresCreate(ContractorContactAddressDTO contractorContactAddres);
        void ContractorContactAddresUpdate(ContractorContactAddressDTO contractorContactAddres);
        int ContractorContactPersonCreate(ContractorContactPersonsDTO contractorContactPerson);
        int ContactPersonAddresCreate(ContactPersonAddressDTO contactPersonAddres);
        void ContactPersonAddresUpdate(ContactPersonAddressDTO contactPersonAddres);
        void Dispose();
        #endregion


        ContractorsDTO GetContractorSrn(int p);
    }
}
