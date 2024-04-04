using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.DAL.Entities.Models;
using ERP_NEW.DAL.Entities.QueryModels;
using ERP_NEW.DAL.Interfaces;
using FirebirdSql.Data.FirebirdClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ERP_NEW.BLL.Services
{
    public class ContractorsService : IContractorsService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<Contractors> contractors;
        private IRepository<ProductCategories> productCategories;
        private IRepository<ContractorTypes> contractorTypes;
        private IRepository<ContactKinds> contactKinds;
        private IRepository<City> city;
        private IRepository<ContactTypes> contactTypes;
        private IRepository<ContractorContactAddress> contractorContactAddress;
        private IRepository<ContractorContactPersons> contractorContactPersons;
        private IRepository<ContactPersons> contactPersons;
        private IRepository<ContactPersonAddress> contactPersonAddress;
        private IRepository<AgreementJournal> agreementJournal;
        private IRepository<AgreementDocuments> agreementDocuments;
        private IRepository<EmployeesDetails> employeesDetails;
        private IRepository<AgreementsType> agreementType;
        private IRepository<Agreements> agreements;
        private IRepository<AgreementTypeDocuments> agreementTypeDocuments;
        private IRepository<AgreementOrder> agreementOrder;
        private IRepository<AgreementOrderJournal> agreementOrderJournal;
        private IRepository<AgreementOrderPurpose> agreementOrderPurpose;
        private IRepository<AgreementOrderScan> agreementOrderScan;
        private IRepository<Currency> agreementCurrency;
        private IRepository<Users> users;

        private IMapper mapper;

        public ContractorsService(IUnitOfWork uow)
        {
            Database = uow;

            agreements = Database.GetRepository<Agreements>();
            agreementJournal = Database.GetRepository<AgreementJournal>();
            agreementType = Database.GetRepository<AgreementsType>();
            agreementDocuments = Database.GetRepository<AgreementDocuments>();
            agreementTypeDocuments = Database.GetRepository<AgreementTypeDocuments>();
            agreementOrder = Database.GetRepository<AgreementOrder>();
            agreementOrderJournal = Database.GetRepository<AgreementOrderJournal>();
            agreementOrderPurpose = Database.GetRepository<AgreementOrderPurpose>();
            agreementOrderScan = Database.GetRepository<AgreementOrderScan>();
            agreementCurrency = Database.GetRepository<Currency>();
            contractors = Database.GetRepository<Contractors>();
            employeesDetails = Database.GetRepository<EmployeesDetails>();
            productCategories = Database.GetRepository<ProductCategories>();
            contractorTypes = Database.GetRepository<ContractorTypes>();
            contactKinds = Database.GetRepository<ContactKinds>();
            contactTypes = Database.GetRepository<ContactTypes>();
            city = Database.GetRepository<City>();
            contractorContactAddress = Database.GetRepository<ContractorContactAddress>();
            contractorContactPersons = Database.GetRepository<ContractorContactPersons>();
            contactPersons = Database.GetRepository<ContactPersons>();
            contactPersonAddress = Database.GetRepository<ContactPersonAddress>();
            users = Database.GetRepository<Users>();

            var config = new MapperConfiguration(cfg =>
             {
                 cfg.CreateMap<AgreementDocuments, AgreementDocumentsDTO>();
                 cfg.CreateMap<AgreementDocumentsDTO, AgreementDocuments>();
                 cfg.CreateMap<AgreementTypeDocuments, AgreementTypeDocumentsDTO>();
                 cfg.CreateMap<AgreementTypeDocumentsDTO, AgreementTypeDocuments>();
                 cfg.CreateMap<Agreements, AgreementsDTO>();
                 cfg.CreateMap<AgreementsDTO, Agreements>();
                 cfg.CreateMap<AgreementsType, AgreementsTypeDTO>();
                 cfg.CreateMap<AgreementsTypeDTO, AgreementsType>();
                 cfg.CreateMap<AgreementJournal, AgreementJournalDTO>();
                 cfg.CreateMap<AgreementJournalDTO, AgreementJournal>();
                 cfg.CreateMap<AgreementOrder, AgreementOrderDTO>();
                 cfg.CreateMap<AgreementOrderDTO, AgreementOrder>();
                 cfg.CreateMap<AgreementOrderJournal, AgreementOrderJournalDTO>();
                 cfg.CreateMap<AgreementOrderJournalDTO, AgreementOrderJournal>();
                 cfg.CreateMap<AgreementOrderScan, AgreementOrderScanDTO>();
                 cfg.CreateMap<AgreementOrderScanDTO, AgreementOrderScan>();
                 cfg.CreateMap<AgreementOrderPurpose, AgreementOrderPurposeDTO>();
                 cfg.CreateMap<AgreementOrderPurposeDTO, AgreementOrderPurpose>();
                 cfg.CreateMap<Contractors, ContractorsDTO>();
                 cfg.CreateMap<ContractorsDTO, Contractors>();
                 cfg.CreateMap<ContractorContactAddress, ContractorContactAddressDTO>();
                 cfg.CreateMap<ContractorContactAddressDTO, ContractorContactAddress>();
                 cfg.CreateMap<ProductCategories, ProductCategoriesDTO>();
                 cfg.CreateMap<ProductCategoriesDTO, ProductCategories>();
                 cfg.CreateMap<ContractorTypes, ContractorTypesDTO>();
                 cfg.CreateMap<ContactTypes, ContactTypesDTO>();
                 cfg.CreateMap<ContactKinds, ContactKindsDTO>();
                 cfg.CreateMap<ContactPersonsDTO, ContactPersons>();
                 cfg.CreateMap<ContactPersons, ContactPersonsDTO>();
                 cfg.CreateMap<ContractorContactPersonsDTO, ContractorContactPersons>();
                 cfg.CreateMap<ContactPersonAddressDTO, ContactPersonAddress>();
                 cfg.CreateMap<EmployeesDetails, EmployeesDetailsDTO>();
                 cfg.CreateMap<EmployeesDetailsDTO, EmployeesDetails>();
                 cfg.CreateMap<CurrencyDTO, Currency>();
                 cfg.CreateMap<Currency, CurrencyDTO>();
                 cfg.CreateMap<UsersDTO, Users>();
             });

            mapper = config.CreateMapper();
        }

        /// <summary>
        /// allData - 1 все данные (договора и контрагенты), 2- только контрагенты, 3 - только договора
        /// </summary>
        /// <param name="allData">allData - 1 все данные (договора и контрагенты), 2- только контрагенты, 3 - только договора</param>
        /// <returns></returns>
        public IEnumerable<ContractorsDTO> GetContractors(int allData)
        {
            var result = (from u in contractors.GetAll()
                          join t in productCategories.GetAll() on u.ProductCategoryId equals t.Id into pc
                          from t in pc.DefaultIfEmpty()
                          join c in contractorTypes.GetAll() on u.ContractorTypeId equals c.TypeId into ct
                          from c in ct.DefaultIfEmpty()
                          where (allData == 1
                                    ? (u.Name != null && u.Active == true)
                                    : allData == 2
                                        ? (!(u.Name.StartsWith("Дог")) && u.Active == true)
                                        : allData == 3
                                            ? u.Name != null
                                            : allData == 4
                                                ? !(u.Name.StartsWith("Дог"))
                                                : (u.Name.StartsWith("Дог")))
                          orderby u.Name
                          select new ContractorsDTO
                          {
                              Id = u.Id,
                              Name = u.Name,
                              Srn = u.Srn,
                              Tin = u.Tin,
                              CategoryName = t.CategoryName,
                              OwnName = (u.OwnType == 1 ? "Вітчизняні" : (u.OwnType != null ? "Зарубіжні" : "Інші")),
                              OwnType = u.OwnType,
                              ContractorTypeId = u.ContractorTypeId,
                              ProductCategoryId = u.ProductCategoryId,
                              TypeName = c.TypeName,
                               Active = u.Active
                          });

            return result.ToList();
        }

        public IEnumerable<ContractorContactAddressDTO> GetContractorContactAddress(int contractorId)
        {
            var result = (from u in contractorContactAddress.GetAll()
                          join k in contactKinds.GetAll() on u.ContractorContactKindId equals k.Id into pc
                          from k in pc.DefaultIfEmpty()
                          join t in contactTypes.GetAll() on k.ContactTypeId equals t.Id into tp
                          from t in tp.DefaultIfEmpty()
                          where u.ContractorId == contractorId
                          select new ContractorContactAddressDTO
                          {
                              Id = u.Id,
                              ContractorId = u.ContractorId,
                              TypeId = t.Id,
                              ContractorContactKindId = k.Id,
                              Name = t.TypeName + " (" + k.KindName + ")",
                              Details = u.Details,
                          });

            return result.ToList();
        }

        public IEnumerable<ContactPersonAddressDTO> GetContactPersonAddress(int contractorId)
        {
            var result = (from u in contactPersonAddress.GetAll()
                          join p in contactPersons.GetAll() on u.ContactPersonId equals p.Id into cp
                          from p in cp.DefaultIfEmpty()
                          join a in contractorContactPersons.GetAll() on p.Id equals a.ContactPersonId into cpa
                          from a in cpa.DefaultIfEmpty()
                          join k in contactKinds.GetAll() on u.ContactKindId equals k.Id into pc
                          from k in pc.DefaultIfEmpty()
                          join t in contactTypes.GetAll() on k.ContactTypeId equals t.Id into tp
                          from t in tp.DefaultIfEmpty()
                          where a.ContractorId == contractorId
                          select new ContactPersonAddressDTO
                          {
                              Id = u.Id,
                              ContractorId = a.ContractorId,
                              ContactPersonId = p.Id,
                              //Fio = p.LastName + " " + p.FirstName.Substring(0,1) + ". " + p.MiddleName.Substring(0,1) + ".",
                              Fio = p.LastName + " " + p.FirstName + " " + p.MiddleName,
                              LastName = p.LastName,
                              FirstName = p.FirstName,
                              MiddleName = p.MiddleName,
                              Profession = p.Profession,
                              AdditionInfo = p.AdditionInfo,
                              TypeId = t.Id,
                              TypeName = t.TypeName,
                              ContactKindId = k.Id,
                              KindName = k.KindName,
                              Details = u.Details
                          });

            return result.ToList();
        }

        public IEnumerable<ProductCategoriesDTO> GetProductCategories()
        {
            return mapper.Map<IEnumerable<ProductCategories>, List<ProductCategoriesDTO>>(productCategories.GetAll());
        }

        public IEnumerable<ContractorTypesDTO> GetContractorTypes()
        {
            return mapper.Map<IEnumerable<ContractorTypes>, List<ContractorTypesDTO>>(contractorTypes.GetAll());
        }

        public IEnumerable<ContactTypesDTO> GetContactTypes()
        {
            return mapper.Map<IEnumerable<ContactTypes>, List<ContactTypesDTO>>(contactTypes.GetAll());
        }

        public IEnumerable<ContactKindsDTO> GetContactKinds()
        {
            return mapper.Map<IEnumerable<ContactKinds>, List<ContactKindsDTO>>(contactKinds.GetAll());
        }

        public IEnumerable<ContractorsDTO> GetAgreement()
        {
            return mapper.Map<IEnumerable<Contractors>, List<ContractorsDTO>>(contractors.GetAll().Where(c => c.Id == -1));
        }

        public ContractorsDTO GetContractorSrn(int contractorId)
        {
            return mapper.Map<Contractors, ContractorsDTO>(contractors.GetAll().SingleOrDefault(c => c.Id == contractorId));
        }

        public bool CheckContractor(ContractorsDTO contractor)
        {

            return mapper.Map<IEnumerable<Contractors>, List<ContractorsDTO>>(contractors.GetAll()).Any(bdsm => bdsm.Name == contractor.Name && bdsm.Id != contractor.Id);
        }

        public IEnumerable<ContractorsDTO> GetOwnContractor()
        {
            return mapper.Map<IEnumerable<Contractors>, List<ContractorsDTO>>(contractors.GetAll().Where(c => c.Id == -1));
        }

        public IEnumerable<ContactPersonsDTO> GetContactPersons(int contractorId)
        {
            var result = (from u in contactPersons.GetAll()
                          join t in contractorContactPersons.GetAll() on u.Id equals t.ContactPersonId into pc
                          from t in pc.DefaultIfEmpty()
                          where t.ContractorId == contractorId
                          select new ContactPersonsDTO
                          {
                              Id = u.Id,
                              Fio = u.LastName + " " + u.FirstName + " " + u.MiddleName,
                              LastName = u.LastName,
                              FirstName = u.FirstName,
                              MiddleName = u.MiddleName,
                              Profession = u.Profession,
                              AdditionInfo = u.AdditionInfo
                          });

            return result.ToList();
        }

        public IEnumerable<AgreementOrderDTO> GetAgreementOrder()
        {
            return mapper.Map<IEnumerable<AgreementOrder>, List<AgreementOrderDTO>>(agreementOrder.GetAll());
        }

        public IEnumerable<AgreementJournalDTO> GetAgreementJournal(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("BeginDate", beginDate),
                    new FbParameter("EndDate", endDate)
                };

            string procName = @"select * from ""GetAgreementJournalProc""(@BeginDate, @EndDate)";

            //return mapper.Map<IEnumerable<AgreementJournal>, List<AgreementJournalDTO>>(agreementJournal.GetAll());
            //string procName = @"select * from ""GetAgreementJournalProc""";

            return mapper.Map<IEnumerable<AgreementJournal>, List<AgreementJournalDTO>>(agreementJournal.SQLExecuteProc(procName,  Parameters));
        }

        public IEnumerable<AgreementDocumentsDTO> GetAgreementDocumentsByAgreementId(int agrementId)
        {

            var result = (from ad in agreementDocuments.GetAll()
                          join atd in agreementTypeDocuments.GetAll() on ad.AgreementTypeDocumentsId equals atd.Id into atdd
                          from atd in atdd.DefaultIfEmpty()
                          join usr in users.GetAll() on ad.ResponsiblePersonId equals usr.UserId into usrr
                          from usr in usrr.DefaultIfEmpty()
                          join emd in employeesDetails.GetAll() on usr.EmployeeId equals emd.EmployeeID into emdd
                          from emd in emdd.DefaultIfEmpty()
                          where ad.AgreementId == agrementId
                          
                          select new AgreementDocumentsDTO
                          {
                              Id = ad.Id,
                              AgreementId = ad.AgreementId,
                              AgreementTypeDocumentsId = ad.AgreementTypeDocumentsId,
                              URL = ad.URL,
                              NameDocument = ad.NameDocument,
                              AgreementTypeDocumentsName = atd.TypeDocuments,
                              DateCreateFile =ad.DateCreateFile,
                              ResponsiblePersonId = ad.ResponsiblePersonId,
                              ResponsiblePerson = emd.LastName +" "+ emd.FirstName + " "+ emd.MiddleName                             
                          });

            return result.ToList();


            //string procName = @"select * from ""GetAgreementJournalProc""";
            //return mapper.Map<IEnumerable<AgreementJournal>, List<AgreementJournalDTO>>(agreementJournal.SQLExecuteProc(procName).Where(bdsm => bdsm.AgreementId == agrementDocumentId));
        }


        public IEnumerable<AgreementDocumentsDTO> GetAgreementsDocuments()
        {
            return mapper.Map<IEnumerable<AgreementDocuments>, List<AgreementDocumentsDTO>>(agreementDocuments.GetAll());
        }

        public IEnumerable<AgreementTypeDocumentsDTO> GetAgreementsTypeDocuments()
        {
            return mapper.Map<IEnumerable<AgreementTypeDocuments>, List<AgreementTypeDocumentsDTO>>(agreementTypeDocuments.GetAll());
        }
        public IEnumerable<AgreementsTypeDTO> GetAgreementsType()
        {
            return mapper.Map<IEnumerable<AgreementsType>, List<AgreementsTypeDTO>>(agreementType.GetAll());
        }

        public IEnumerable<CurrencyDTO> GetAgreementsCurrency()
        {
            return mapper.Map<IEnumerable<Currency>, List<CurrencyDTO>>(agreementCurrency.GetAll());
        }

        public IEnumerable<AgreementsDTO> GetAgreements()
        {
            return mapper.Map<IEnumerable<Agreements>, List<AgreementsDTO>>(agreements.GetAll());
        }

        public IEnumerable<AgreementOrderPurposeDTO> GetAgreementOrderPurpose()
        {
            return mapper.Map<IEnumerable<AgreementOrderPurpose>, List<AgreementOrderPurposeDTO>>(agreementOrderPurpose.GetAll());
        }

        public string GetAgreementOrderLastNumber(DateTime date)
        {

            //var agreementOrderCurrentyear = mapper.Map<IEnumerable<AgreementOrder>, List<AgreementOrderDTO>>(agreementOrder.GetAll()).OrderByDescending(x => Decimal.
            //     Parse(x.AgreementOrderNumber.Replace('/', ','))).FirstOrDefault(x => x.AgreementOrderDate.Value.Year == date.Year);
          
            var agreementOrderCurrentyear = mapper.Map<IEnumerable<AgreementOrder>, List<AgreementOrderDTO>>(agreementOrder.GetAll()).OrderByDescending(x => Decimal.
                 Parse(x.AgreementOrderNumber.Replace('/', ','))).FirstOrDefault(x => x.AgreementOrderDate.Value.Year == date.Year && x.Id != 196 && x.Id !=195);

            if (agreementOrderCurrentyear != null)
            {
                decimal lastAgreementOrderNumber = Decimal.Parse(agreementOrderCurrentyear.AgreementOrderNumber.Replace('/', ','));
                agreementOrderCurrentyear.AgreementOrderNumber = (Math.Truncate(lastAgreementOrderNumber) + 1).ToString();
                return agreementOrderCurrentyear.AgreementOrderNumber;
            }
            else
            {
                return "1";
            }
        }

        

        public bool CheckAgreementOrderNumber(DateTime date, string orderNumber)
        {
            
            return mapper.Map<IEnumerable<AgreementOrder>, List<AgreementOrderDTO>>(agreementOrder.GetAll()).Any(bdsm => bdsm.AgreementOrderDate.Value.Year == date.Year && bdsm.AgreementOrderNumber == orderNumber);
        }

        public AgreementOrderScanDTO GetAgreementOrderScanById(int? agreementOrderId)
        {
            return mapper.Map<AgreementOrderScan, AgreementOrderScanDTO>(agreementOrderScan.GetAll().FirstOrDefault(s => s.Id == agreementOrderId));
        }

        public IEnumerable<AgreementOrderJournalDTO> GetAgreementOrderJournal(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("BeginDateIn", beginDate),
                    new FbParameter("EndDateIn", endDate)
                };

            string procName = @"select * from ""GetAgreementOrderJournalProc""(@BeginDateIn, @EndDateIn)";

            return mapper.Map<IEnumerable<AgreementOrderJournal>, List<AgreementOrderJournalDTO>>(agreementOrderJournal.SQLExecuteProc(procName, Parameters));
        }


        #region Contractor CRUD method's

        public int ContractorCreate(ContractorsDTO contractor)
        {
            var createrecord = contractors.Create(mapper.Map<Contractors>(contractor));
            return (int)createrecord.Id;
        }

        public void ContractorUpdate(ContractorsDTO contractor)
        {

            var eGroup = contractors.GetAll().SingleOrDefault(c => c.Id == contractor.Id);
            contractors.Update((mapper.Map<ContractorsDTO, Contractors>(contractor, eGroup)));
        }

        public bool ContractorDelete(int id)
        {
            try
            {
                contractors.Delete(contractors.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region ProductCategory CRUD method's

        public int ProductCategotyCreate(ProductCategoriesDTO productCategoty)
        {
            var createrecord = productCategories.Create(mapper.Map<ProductCategories>(productCategoty));
            return (int)createrecord.Id;
        }

        public void ProductCategoryUpdate(ProductCategoriesDTO productCategoty)
        {

            var eGroup = productCategories.GetAll().SingleOrDefault(c => c.Id == productCategoty.Id);
            productCategories.Update((mapper.Map<ProductCategoriesDTO, ProductCategories>(productCategoty, eGroup)));
        }

        public bool ProductCategotyDelete(int id)
        {
            try
            {
                productCategories.Delete(productCategories.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region ContractorContactAddresCreate CRUD method's

        public int ContractorContactAddresCreate(ContractorContactAddressDTO contractorContactAddres)
        {
            var createrecord = contractorContactAddress.Create(mapper.Map<ContractorContactAddress>(contractorContactAddres));
            return (int)createrecord.Id;
        }

        public void ContractorContactAddresUpdate(ContractorContactAddressDTO contractorContactAddres)
        {

            var eGroup = contractorContactAddress.GetAll().SingleOrDefault(c => c.Id == contractorContactAddres.Id);
            contractorContactAddress.Update((mapper.Map<ContractorContactAddressDTO, ContractorContactAddress>(contractorContactAddres, eGroup)));
        }

        public bool ContractorContactAddresDelete(ContractorContactAddressDTO contactAddres)
        {
            try
            {
                contractorContactAddress.Delete(contractorContactAddress.GetAll().FirstOrDefault(c => c.Id == contactAddres.Id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ContractorContactAddresDelete(int id)
        {
            try
            {
                contractorContactAddress.Delete(contractorContactAddress.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region ContactPerson CRUD method's

        public int ContactPersonCreate(ContactPersonsDTO contactPerson)
        {
            try
            {
                var createrecord = contactPersons.Create(mapper.Map<ContactPersons>(contactPerson));
                return (int)createrecord.Id;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public void ContactPersonUpdate(ContactPersonsDTO contactPerson)
        {
            var eGroup = contactPersons.GetAll().SingleOrDefault(c => c.Id == contactPerson.Id);
            contactPersons.Update((mapper.Map<ContactPersonsDTO, ContactPersons>(contactPerson, eGroup)));
        }

        public bool ContactPersonDelete(int contactPersonId)
        {
            try
            {
                contactPersonAddress.DeleteAll(contactPersonAddress.GetAll().Where(c => c.ContactPersonId == contactPersonId));
                contractorContactPersons.Delete(contractorContactPersons.GetAll().FirstOrDefault(c => c.ContactPersonId == contactPersonId));
                contactPersons.Delete(contactPersons.GetAll().FirstOrDefault(c => c.Id == contactPersonId));

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region ContactPersonAddres CRUD method's

        public int ContactPersonAddresCreate(ContactPersonAddressDTO contactPersonAddres)
        {
            var createrecord = contactPersonAddress.Create(mapper.Map<ContactPersonAddress>(contactPersonAddres));
            return (int)createrecord.Id;
        }

        public void ContactPersonAddresUpdate(ContactPersonAddressDTO contactPersonAddres)
        {
            var eGroup = contactPersonAddress.GetAll().SingleOrDefault(c => c.Id == contactPersonAddres.Id);
            contactPersonAddress.Update((mapper.Map<ContactPersonAddressDTO, ContactPersonAddress>(contactPersonAddres, eGroup)));
        }

        public bool ContactPersonAddresDelete(int id)
        {
            try
            {
                contactPersonAddress.Delete(contactPersonAddress.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int ContractorContactPersonCreate(ContractorContactPersonsDTO contractorContactPerson)
        {
            var createrecord = contractorContactPersons.Create(mapper.Map<ContractorContactPersons>(contractorContactPerson));
            return (int)createrecord.Id;
        }

        public bool ContractorContacts(int contractorId)
        {
            try
            {
                contractorContactAddress.DeleteAll(contractorContactAddress.GetAll().Where(c => c.ContractorId == contractorId));

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region AgreementsDocuments CRUD method's

        public int AgreementsDocumentsCreate(AgreementDocumentsDTO agreementDocumentsDTO)
        {
            var createAgr = agreementDocuments.Create(mapper.Map<AgreementDocuments>(agreementDocumentsDTO));
            return (int)createAgr.Id;
        }

        public void AgreementsDocumentsUpdate(AgreementDocumentsDTO agreementDocumentsDTO)
        {
            var upDateAgr = agreementDocuments.GetAll().SingleOrDefault(c => c.Id == agreementDocumentsDTO.Id);
            agreementDocuments.Update((mapper.Map<AgreementDocumentsDTO, AgreementDocuments>(agreementDocumentsDTO, upDateAgr)));
        }

        public bool AgreementsDocumentsDelete(int id)
        {
            try
            {
                agreementDocuments.Delete(agreementDocuments.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region AgreementTypeDocument CRUD method's

        public int AgreementsTypeDocumentsCreate(AgreementTypeDocumentsDTO agreementTypeDocumentsDTO)
        {
            var createAgr = agreementTypeDocuments.Create(mapper.Map<AgreementTypeDocuments>(agreementTypeDocumentsDTO));
            return (int)createAgr.Id;
        }

        public void AgreementsTypeDocumentsUpdate(AgreementTypeDocumentsDTO agreementTypeDocumentsDTO)
        {
            var upDateAgr = agreementTypeDocuments.GetAll().SingleOrDefault(c => c.Id == agreementTypeDocumentsDTO.Id);
            agreementTypeDocuments.Update((mapper.Map<AgreementTypeDocumentsDTO, AgreementTypeDocuments>(agreementTypeDocumentsDTO, upDateAgr)));
        }

        public bool AgreementsTypeDocumentsDelete(int id)
        {
            try
            {
                agreementTypeDocuments.Delete(agreementTypeDocuments.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region AgreementType CRUD method's

        public int AgreementsTypeCreate(AgreementsTypeDTO agreementsTypeDTO)
        {
            var createAgr = agreementType.Create(mapper.Map<AgreementsType>(agreementsTypeDTO));
            return (int)createAgr.Id;
        }

        public void AgreementsTypeUpdate(AgreementsTypeDTO agreementsTypeDTO)
        {
            var upDateAgr = agreementType.GetAll().SingleOrDefault(c => c.Id == agreementsTypeDTO.Id);
            agreementType.Update((mapper.Map<AgreementsTypeDTO, AgreementsType>(agreementsTypeDTO, upDateAgr)));
        }

        public bool AgreementsTypeDelete(int id)
        {
            try
            {
                agreementType.Delete(agreementType.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Agreements CRUD method's

        public int AgreementsCreate(AgreementsDTO agreementsDTO)
        {
            var createAgr = agreements.Create(mapper.Map<Agreements>(agreementsDTO));
            return (int)createAgr.Id;
        }

        public void AgreementsUpdate(AgreementsDTO agreementsDTO)
        {
            var upDateAgr = agreements.GetAll().SingleOrDefault(c => c.Id == agreementsDTO.Id);
            agreements.Update((mapper.Map<AgreementsDTO, Agreements>(agreementsDTO, upDateAgr)));
        }

        public bool AgreementsDelete(int id)
        {
            try
            {
                agreements.Delete(agreements.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        #endregion

        #region AgreementOrder CRUD method's

        public int AgreementOrderCreate(AgreementOrderDTO agreementOrderDTO)
        {
            var createAgr = agreementOrder.Create(mapper.Map<AgreementOrder>(agreementOrderDTO));
            return (int)createAgr.Id;
        }

        public void AgreementsOrderUpdate(AgreementOrderDTO agreementOrderDTO)
        {
            var upDateAgr = agreementOrder.GetAll().SingleOrDefault(c => c.Id == agreementOrderDTO.Id);
            agreementOrder.Update((mapper.Map<AgreementOrderDTO, AgreementOrder>(agreementOrderDTO, upDateAgr)));
        }

        public bool AgreementOrderDelete(int id)
        {
            try
            {
                agreementOrder.Delete(agreementOrder.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region AgreementOrderPurpose CRUD method's

        public int AgreementOrderPurposeCreate(AgreementOrderPurposeDTO agreementOrderPurposeDTO)
        {
            var createAgr = agreementOrderPurpose.Create(mapper.Map<AgreementOrderPurpose>(agreementOrderPurposeDTO));
            return (int)createAgr.Id;
        }

        public void AgreementsOrderPurposeUpdate(AgreementOrderPurposeDTO agreementOrderPurposeDTO)
        {
            var upDateAgr = agreementOrderPurpose.GetAll().SingleOrDefault(c => c.Id == agreementOrderPurposeDTO.Id);
            agreementOrderPurpose.Update((mapper.Map<AgreementOrderPurposeDTO, AgreementOrderPurpose>(agreementOrderPurposeDTO, upDateAgr)));
        }

        public bool AgreementOrderPurposeDelete(int id)
        {
            try
            {
                agreementOrderPurpose.Delete(agreementOrderPurpose.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region AgreementOrderScan CRUD method's

        public int AgreementOrderScanCreate(AgreementOrderScanDTO agreementOrderScanDTO)
        {
            var createAgr = agreementOrderScan.Create(mapper.Map<AgreementOrderScan>(agreementOrderScanDTO));
            return (int)createAgr.Id;
        }

        public void AgreementsOrderScanUpdate(AgreementOrderScanDTO agreementOrderScanDTO)
        {
            var upDateAgr = agreementOrderScan.GetAll().SingleOrDefault(c => c.Id == agreementOrderScanDTO.Id);
            agreementOrderScan.Update((mapper.Map<AgreementOrderScanDTO, AgreementOrderScan>(agreementOrderScanDTO, upDateAgr)));
        }

        public bool AgreementOrderScanDelete(int id)
        {
            try
            {
                agreementOrderScan.Delete(agreementOrderScan.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
