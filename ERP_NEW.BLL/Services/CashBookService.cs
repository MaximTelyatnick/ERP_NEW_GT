using AutoMapper;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.DAL.Entities.Models;
using ERP_NEW.DAL.Entities.QueryModels;
using ERP_NEW.DAL.Interfaces;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Services
{
    public class CashBookService : ICashBookService
    {

        private IUnitOfWork Database { get; set; }

        private IRepository<CashBookPage> cashBookPage;
        private IRepository<CashBookRecord> cashBookRecord;
        private IRepository<CashBookRecordType> cashBookRecordType;
        private IRepository<CashBookBasisType> cashBookBasisType;
        private IRepository<CashBookRecordJournal> cashBookRecordJournal;
        private IRepository<CashBookBalance> cashBookBalance;
        private IRepository<CashBookContractor> cashBookContractor;
        private IRepository<CashBookAdditionalType> cashBookAdditionalType;


        private IMapper mapper;

        public CashBookService(IUnitOfWork uow)
        {
            Database = uow;

            cashBookPage = Database.GetRepository<CashBookPage>();
            cashBookRecord = Database.GetRepository<CashBookRecord>();
            cashBookRecordType = Database.GetRepository<CashBookRecordType>();
            cashBookBasisType = Database.GetRepository<CashBookBasisType>();
            cashBookRecordJournal = Database.GetRepository<CashBookRecordJournal>();
            cashBookBalance = Database.GetRepository<CashBookBalance>();
            cashBookContractor = Database.GetRepository<CashBookContractor>();
            cashBookAdditionalType = Database.GetRepository<CashBookAdditionalType>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CashBookPage, CashBookPageDTO>();
                cfg.CreateMap<CashBookPageDTO, CashBookPage>();

                cfg.CreateMap<CashBookBasisType, CashBookBasisTypeDTO>();
                cfg.CreateMap<CashBookBasisTypeDTO, CashBookBasisType>();

                cfg.CreateMap<CashBookRecord, CashBookRecordDTO>();
                cfg.CreateMap<CashBookRecordDTO, CashBookRecord>();

                cfg.CreateMap<CashBookRecordType, CashBookRecordTypeDTO>();
                cfg.CreateMap<CashBookRecordTypeDTO, CashBookRecordType>();

                cfg.CreateMap<CashBookRecordJournal, CashBookRecordJournalDTO>();
                cfg.CreateMap<CashBookRecordJournalDTO, CashBookRecordJournal>();

                cfg.CreateMap<CashBookBalance, CashBookBalanceDTO>();
                cfg.CreateMap<CashBookBalanceDTO, CashBookBalance>();

                cfg.CreateMap<CashBookContractor, CashBookContractorDTO>();
                cfg.CreateMap<CashBookContractorDTO, CashBookContractor>();

                cfg.CreateMap<CashBookAdditionalType, CashBookAdditionalTypeDTO>();
                cfg.CreateMap<CashBookAdditionalTypeDTO, CashBookAdditionalType>();


            });

            mapper = config.CreateMapper();
        }


        #region Method's

        public IEnumerable<CashBookPageDTO> GetPageByPeriod(DateTime beginDate, DateTime endDate, int cashBooksId)
        {
            return mapper.Map<IEnumerable<CashBookPage>, List<CashBookPageDTO>>(cashBookPage.GetAll().Where(w => w.PageDate >= beginDate && w.PageDate <= endDate && w.CashBookId == cashBooksId));
        }

        public IEnumerable<CashBookBasisTypeDTO> GetBasis()
        {
            return mapper.Map<IEnumerable<CashBookBasisType>, List<CashBookBasisTypeDTO>>(cashBookBasisType.GetAll());
        }

        public IEnumerable<CashBookContractorDTO> GetContractors()
        {
            return mapper.Map<IEnumerable<CashBookContractor>, List<CashBookContractorDTO>>(cashBookContractor.GetAll());
        }

        public IEnumerable<CashBookRecordTypeDTO> GetCashBookRecordType()
        {
            return mapper.Map<IEnumerable<CashBookRecordType>, List<CashBookRecordTypeDTO>>(cashBookRecordType.GetAll());
        }

        public IEnumerable<CashBookAdditionalTypeDTO> GetCashBookAdditional()
        {
            return mapper.Map<IEnumerable<CashBookAdditionalType>, List<CashBookAdditionalTypeDTO>>(cashBookAdditionalType.GetAll());
        }


        public IEnumerable<CashBookRecordJournalDTO> GetCashBookRecords(int cashBookPageId)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("CashBookPageIdIn", cashBookPageId)
                };

            string procName = @"select * from ""GetCashBookRecordJournal""(@CashBookPageIdIn)";

            return mapper.Map<IEnumerable<CashBookRecordJournal>, List<CashBookRecordJournalDTO>>(cashBookRecordJournal.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<CashBookBalanceDTO> GetCashBookBalanceByPeriod(DateTime beginDate, DateTime endDate, int cashBookId)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("BeginDateIn", beginDate),
                    new FbParameter("EndDateIn", endDate),
                    new FbParameter("CashBookId", cashBookId)
                };

            string procName = @"select * from ""GetCashBookBalance""(@BeginDateIn, @EndDateIn, @CashBookId)";

            var test = cashBookBalance.SQLExecuteProc(procName, Parameters);

            return mapper.Map<IEnumerable<CashBookBalance>, List<CashBookBalanceDTO>>(cashBookBalance.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<CashBookPageDTO> GetCashBookPages(int cashBookId)
        {
            return mapper.Map<IEnumerable<CashBookPage>, List<CashBookPageDTO>>(cashBookPage.GetAll()).Where(srch => srch.CashBookId == cashBookId);
        }


        public IEnumerable<CashBookRecordDTO> GetCashBookRecords()
        {
            return mapper.Map<IEnumerable<CashBookRecord>, List<CashBookRecordDTO>>(cashBookRecord.GetAll());
        }

        public IEnumerable<CashBookRecordDTO> GetCashBookRecords(DateTime date, int cashBookId)
        {
            var result = (from cbr in cashBookRecord.GetAll()
                          join cb in cashBookPage.GetAll() on cbr.CashBookPageId equals cb.Id into cbb
                          from cb in cbb.DefaultIfEmpty()
                          where cb.CashBookId == cashBookId
                          select new CashBookRecordDTO()
                          {
                            Id = cbr.Id,
                             AccountId = cbr.AccountId,
                              AdditionalId = cbr.AdditionalId,
                               BasisId = cbr.BasisId,
                                CashBookPageId = cbr.CashBookPageId,
                                 ContractorId = cbr.ContractorId,
                                  CurrencyTypeId = cbr.CurrencyTypeId,
                                   DocumentNumber = cbr.DocumentNumber,
                                    Payment = cbr.Payment,
                                     PageDate = cb.PageDate
                          }).ToList();

            result = result.Where(bds => bds.PageDate.Value.Year == date.Year).ToList();

            return result;
        }

        

        public string GetLatestPageNumber(DateTime pageDate, int cashBookId)
        {
            var cashBookDto = GetCashBookPages(cashBookId).OrderByDescending(x => Decimal.Parse(x.PageNumber.Replace('/', ','))).FirstOrDefault(x => x.PageDate.Month == pageDate.Month && x.PageDate.Year == pageDate.Year); //DateTime.Today.Year);

            if (cashBookDto != null)
            {
                decimal last = Decimal.Parse(cashBookDto.PageNumber.Replace('/', ','));
                return ((Math.Truncate(last) + 1).ToString());
            }
            else
            {
                return "1";
            }
        }

        public string GetLatestRecordDocumentNumber(DateTime pageDate, Utils.CurencyOperationType recordCurencyOperation, List<CashBookRecordJournalDTO> models, int cashBookId)
        {
            if (recordCurencyOperation == Utils.CurencyOperationType.Debit)
            {
                if (models.Count == 0)
                {
                    var cashBookDto = GetCashBookRecords(pageDate, cashBookId).OrderByDescending(x => Decimal.Parse(x.DocumentNumber.Replace('/', ','))).FirstOrDefault(x => x.CurrencyTypeId == 0 && pageDate.Year == DateTime.Today.Year);

                    if (cashBookDto != null)
                    {
                        decimal last = Decimal.Parse(cashBookDto.DocumentNumber.Replace('/', ','));
                        return ((Math.Truncate(last) + 1).ToString());
                    }
                    else
                    {
                        return "1";
                    }
                }
                else
                {
                    var cashBookDto = models.OrderByDescending(m => m.DocumentNumber).FirstOrDefault(x => x.CurrencyTypeId == 0 && pageDate.Year == DateTime.Today.Year);
                    if (cashBookDto != null)
                    {
                        decimal last = Decimal.Parse(cashBookDto.DocumentNumber.Replace('/', ','));
                        return ((Math.Truncate(last) + 1).ToString());
                    }
                    else
                    {
                        return "1";
                    }
                }
            }
            else
            {

                if (models.Count == 0)
                {
                    var cashBookDto = GetCashBookRecords(pageDate, cashBookId).OrderByDescending(x => Decimal.Parse(x.DocumentNumber.Replace('/', ','))).FirstOrDefault(x => x.CurrencyTypeId == 1 && pageDate.Year == DateTime.Today.Year);

                    if (cashBookDto != null)
                    {
                        decimal last = Decimal.Parse(cashBookDto.DocumentNumber.Replace('/', ','));
                        return ((Math.Truncate(last) + 1).ToString());
                    }
                    else
                    {
                        return "1";
                    }
                }
                else
                {
                    var cashBookDto = models.OrderByDescending(m => m.DocumentNumber).FirstOrDefault(x => x.CurrencyTypeId == 1 && pageDate.Year == DateTime.Today.Year);
                    if (cashBookDto != null)
                    {
                        decimal last = Decimal.Parse(cashBookDto.DocumentNumber.Replace('/', ','));
                        return ((Math.Truncate(last) + 1).ToString());
                    }
                    else
                    {
                        return "1";
                    }
                }
            }
        }

        public string GetLatestRecordDocumentNumber(DateTime pageDate, Utils.CurencyOperationType recordCurencyOperation)
        {
            if (recordCurencyOperation == Utils.CurencyOperationType.Debit)
            {
                    var cashBookDto = GetCashBookRecords().OrderByDescending(x => Decimal.Parse(x.DocumentNumber.Replace('/', ','))).FirstOrDefault(x => x.CurrencyTypeId == 0 && pageDate.Year == DateTime.Today.Year);

                    if (cashBookDto != null)
                    {
                        decimal last = Decimal.Parse(cashBookDto.DocumentNumber.Replace('/', ','));
                        return ((Math.Truncate(last) + 1).ToString());
                    }
                    else
                    {
                        return "1";
                    }
                
            }
            else
            {


                    var cashBookDto = GetCashBookRecords().OrderByDescending(x => Decimal.Parse(x.DocumentNumber.Replace('/', ','))).FirstOrDefault(x => x.CurrencyTypeId == 1 && pageDate.Year == DateTime.Today.Year);

                    if (cashBookDto != null)
                    {
                        decimal last = Decimal.Parse(cashBookDto.DocumentNumber.Replace('/', ','));
                        return ((Math.Truncate(last) + 1).ToString());
                    }
                    else
                    {
                        return "1";
                    }
               
            }
        }
        #endregion

        #region CashBookPages CRUD method's

        public int CashBookPageCreate(CashBookPageDTO cashBookPageDTO)
        {
            var createCashBookPages = cashBookPage.Create(mapper.Map<CashBookPage>(cashBookPageDTO));
            return (int)createCashBookPages.Id;
        }

        public void CashBookPageUpdate(CashBookPageDTO cashBookPageDTO)
        {
            var updateCashBookPage = cashBookPage.GetAll().SingleOrDefault(c => c.Id == cashBookPageDTO.Id);
            cashBookPage.Update((mapper.Map<CashBookPageDTO, CashBookPage>(cashBookPageDTO, updateCashBookPage)));
        }

        public bool CashBookPageDelete(int id)
        {
            try
            {
                cashBookPage.Delete(cashBookPage.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region CashBookRecords CRUD method's

        public int CashBookRecordCreate(CashBookRecordDTO cashBookRecordDTO)
        {
            var createCashBookRecord = cashBookRecord.Create(mapper.Map<CashBookRecord>(cashBookRecordDTO));
            return (int)createCashBookRecord.Id;
        }

        public void CashBookRecordCreateRange(List<CashBookRecordDTO> source)
        {
            cashBookRecord.CreateRange(mapper.Map<List<CashBookRecordDTO>, IEnumerable<CashBookRecord>>(source));
        }

        public void CashBookRecordUpdate(CashBookRecordDTO cashBookRecordDTO)
        {
            var updateCashBookRecord = cashBookRecord.GetAll().SingleOrDefault(c => c.Id == cashBookRecordDTO.Id);
            cashBookRecord.Update((mapper.Map<CashBookRecordDTO, CashBookRecord>(cashBookRecordDTO, updateCashBookRecord)));
        }

        public bool CashBookRecordDelete(int id)
        {
            try
            {
                cashBookRecord.Delete(cashBookRecord.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CashBookRecordRemoveRange(List<CashBookRecordDTO> source)
        {
            try
            {
                foreach (var item in source)
                {
                    var deleteModel = cashBookRecord.GetAll().SingleOrDefault(p => p.Id == item.Id);
                    cashBookRecord.Delete(deleteModel);
                }


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Basis CRUD method's

        public int CashBookBasisCreate(CashBookBasisTypeDTO cashBookBasisTypeDTO)
        {
            var createCashBookBasis = cashBookBasisType.Create(mapper.Map<CashBookBasisType>(cashBookBasisTypeDTO));
            return (int)createCashBookBasis.Id;
        }

        public void CashBookBasisUpdate(CashBookBasisTypeDTO cashBookBasisTypeDTO)
        {
            var updateCashBookBasisType = cashBookBasisType.GetAll().SingleOrDefault(c => c.Id == cashBookBasisTypeDTO.Id);
            cashBookBasisType.Update((mapper.Map<CashBookBasisTypeDTO, CashBookBasisType>(cashBookBasisTypeDTO, updateCashBookBasisType)));
        }

        public bool CashBookBasisDelete(int id)
        {
            try
            {
                cashBookBasisType.Delete(cashBookBasisType.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Contractor Cash Book CRUD method's

        public int CashBookContractorCreate(CashBookContractorDTO cashBookContractorDTO)
        {
            var createCashBookContractor = cashBookContractor.Create(mapper.Map<CashBookContractor>(cashBookContractorDTO));
            return (int)createCashBookContractor.Id;
        }

        public void CashBookContractorUpdate(CashBookContractorDTO cashBookContractorDTO)
        {
            var updateCashBookContractor = cashBookContractor.GetAll().SingleOrDefault(c => c.Id == cashBookContractorDTO.Id);
            cashBookContractor.Update((mapper.Map<CashBookContractorDTO, CashBookContractor>(cashBookContractorDTO, updateCashBookContractor)));
        }

        public bool CashBookContractorDelete(int id)
        {
            try
            {
                cashBookContractor.Delete(cashBookContractor.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region CashBookAdditionType CRUD method's

        public int CashBookAdditionalTypeCreate(CashBookAdditionalTypeDTO cashBookAdditionalTypeDTO)
        {
            var createCashBookAdditionalType = cashBookAdditionalType.Create(mapper.Map<CashBookAdditionalType>(cashBookAdditionalTypeDTO));
            return (int)createCashBookAdditionalType.Id;
                
        }

        public void CashBookAdditionalTypeUpdate(CashBookAdditionalTypeDTO cashBookAdditionalTypeDTO)
        {
            var updateCashBookAdditionalType = cashBookAdditionalType.GetAll().SingleOrDefault(c => c.Id == cashBookAdditionalTypeDTO.Id);
            cashBookAdditionalType.Update((mapper.Map<CashBookAdditionalTypeDTO, CashBookAdditionalType>(cashBookAdditionalTypeDTO, updateCashBookAdditionalType)));
        }

        public bool CashBookAdditionalTypeDelete(int id)
        {
            try
            {
                cashBookAdditionalType.Delete(cashBookAdditionalType.GetAll().FirstOrDefault(c => c.Id == id));
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
