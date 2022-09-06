using ERP_NEW.BLL.Interfaces;
using ERP_NEW.DAL.Interfaces;
using ERP_NEW.DAL.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ERP_NEW.BLL.DTO.ModelsDTO;
using FirebirdSql.Data.FirebirdClient;

namespace ERP_NEW.BLL.Services
{
    public class AccountingInvoicesService : IAccountingInvoicesService
    {
        private IUnitOfWork Database { get; set; }

        private IRepository<Balance_Account> balanceAccount;
        private IRepository<Contractors> contractors;
        private IRepository<Colors> colors;
        private IRepository<Invoices> invoices;
        private IRepository<Invoices_Notes> invoicesNotes;
        private IRepository<Registries> registries;
        private DateTime minimalDate = new DateTime(2012,1,1);

        private IMapper mapper;

        public AccountingInvoicesService(IUnitOfWork uow)
        {
            Database = uow;
            balanceAccount = Database.GetRepository<Balance_Account>();
            invoices = Database.GetRepository<Invoices>();
            invoicesNotes = Database.GetRepository<Invoices_Notes>();
            contractors = Database.GetRepository<Contractors>();
            colors = Database.GetRepository<Colors>();
            registries = Database.GetRepository<Registries>(); 


            
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Balance_Account, Balance_AccountDTO>();
                cfg.CreateMap<Balance_AccountDTO, Balance_Account>();
                cfg.CreateMap<Contractors, ContractorsDTO>();
                cfg.CreateMap<ContractorsDTO, Contractors>();
                cfg.CreateMap<Colors, ColorsDTO>();
                cfg.CreateMap<ColorsDTO, Colors>();
                cfg.CreateMap<Invoices, InvoicesDTO>();
                cfg.CreateMap<InvoicesDTO, Invoices>();
                cfg.CreateMap<Registries, RegistriesDTO>();
                cfg.CreateMap<RegistriesDTO, Registries>();
                cfg.CreateMap<Invoices_NotesDTO, Invoices_Notes>();
                cfg.CreateMap<Invoices_Notes, Invoices_NotesDTO>();

            });

            mapper = config.CreateMapper();
        }



        public IEnumerable<InvoicesDTO> GetInvoicesInfo(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("BeginDateIn", beginDate),
                    new FbParameter("EndDateIn", endDate)
                };
            string procName = @"select * from ""GetAccountingInvoices""(@BeginDateIn, @EndDateIn)";
            return mapper.Map<IEnumerable<Invoices>, List<InvoicesDTO>>(invoices.SQLExecuteProc(procName, Parameters));  
        }

        public IEnumerable<InvoicesDTO> GetInvoices(DateTime startDate, DateTime endDate)
        {
            if (startDate < minimalDate)
                startDate = minimalDate;

            var rezult = (from i in invoices.GetAll()
                          join c in contractors.GetAll() on i.Contractor_Id equals c.Id into con
                          from c in con.DefaultIfEmpty()
                          join r in registries.GetAll() on i.Registry_Id equals r.Id into reg
                          from r in reg.DefaultIfEmpty()
                          join ins in invoicesNotes.GetAll() on i.Note_Id equals ins.Id into insnot
                          from ins in insnot.DefaultIfEmpty()
                          join col in colors.GetAll() on i.Color_Id equals col.Id into cols
                          from col in cols.DefaultIfEmpty()
                          join bl in balanceAccount.GetAll() on i.Balance_Account_Id equals bl.Id into blya
                          from bl in blya.DefaultIfEmpty()

                          where ((i.Month_Current >= startDate && i.Month_Current <= endDate) || (i.Month_Invoice >= startDate && i.Month_Invoice <= endDate))
                          select new InvoicesDTO()
                          { 
                              Id = i.Id,
                              Month_Current = i.Month_Current,
                              Month_Invoice = i.Month_Invoice,
                              Invoice_Number = i.Invoice_Number,
                              Contractor_Name = c.Name,
                              Tin = c.Tin != null ? c.Tin : "",
                              Price = i.Price,
                              Vat = i.Vat,
                              Non_Taxable = i.Non_Taxable,
                              Total_Price = i.Total_Price,
                              Bal_Name = bl.Name,
                              Vat_Check = i.Vat_Check,
                              Inv_Note_Name = ins.Name,
                              Region_Name = r.Name,
                              Date_Of_Correction = i.Date_Of_Correction,
                              Number_Of_Correction = i.Number_Of_Correction,
                              Balance_Account_Id = bl.Id,
                              Color_Id = col.Id,
                              Color_Name = col.Name,
                              Contractor_Id = c.Id,
                              Note_Id = ins.Id,
                              Registry_Id = r.Id,
                              Selected = i.Date_Of_Correction != null ? true : false

                          }).ToList();

            return rezult.OrderBy(o => o.Month_Current).ToList();
        }

     

        public IEnumerable<Balance_AccountDTO> GetBalaneAccount()
        {
            return mapper.Map<IEnumerable<Balance_Account>, List<Balance_AccountDTO>>(balanceAccount.GetAll());
        }

        public bool CheckInvoicesNum(InvoicesDTO invoicesDTO)
        {
            var allInvoices = mapper.Map<IEnumerable<Invoices>, List<InvoicesDTO>>(invoices.GetAll().Where(bdsm => bdsm.Month_Invoice.Year >= 2011 && bdsm.Month_Current.Year >= 2011));

            bool checkInvoicesNumber = allInvoices.Any(bdsm => bdsm.Contractor_Id == invoicesDTO.Contractor_Id && bdsm.Invoice_Number == invoicesDTO.Invoice_Number);

            return checkInvoicesNumber;
        }

        public IEnumerable<RegistriesDTO> GetRegistriesName()
        {
            return mapper.Map<IEnumerable<Registries>, List<RegistriesDTO>>(registries.GetAll());
        }

        public IEnumerable<Invoices_NotesDTO> GetInvNoteName()
        {
            return mapper.Map<IEnumerable<Invoices_Notes>, List<Invoices_NotesDTO>>(invoicesNotes.GetAll());
        }
        public IEnumerable<ContractorsDTO> GetContractorName()
        {
            return mapper.Map<IEnumerable<Contractors>, List<ContractorsDTO>>(contractors.GetAll());
        }
        public InvoicesDTO GetInvoicesById(int id)
        {
            return mapper.Map<Invoices,InvoicesDTO>(invoices.GetAll().SingleOrDefault(s => s.Id == id));
        }

        //public InvoicesDTO GetCurMonth()
        //{
        //    return mapper.Map<IEnumerable<Invoices>, List<InvoicesDTO>>(invoices.GetAll());
        //}

        #region AccountsInvoice CRUD method's

        public int AccountsInvoiceCreate(InvoicesDTO invoicesDTO)
        {
            var createAccountsInvoices = invoices.Create(mapper.Map<Invoices>(invoicesDTO));
            return (int)createAccountsInvoices.Id;
        }

        public void AccountsInvoiceUpdate(InvoicesDTO invoicesDTO)
        {
            var updateAccountsInvoices = invoices.GetAll().SingleOrDefault(c => c.Id == invoicesDTO.Id);
            invoices.Update((mapper.Map<InvoicesDTO, Invoices>(invoicesDTO, updateAccountsInvoices)));
        }

        public bool AccountsInvoiceDelete(int id)
        {
            try
            {
                invoices.Delete(invoices.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
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
