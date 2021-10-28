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
    public class PackingListsService : IPackingListsService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<PackingLists> packingLists;
        private IRepository<PackingListMaterials> packingListMaterials;
        private IRepository<PackingListsJournal> packingListsJournal;
        private IRepository<CustomerOrders> customerOrders;
        private IRepository<City> cities;
        private IRepository<Country> countries;
        private IRepository<EmployeesDetails> employeesDetails;
        private IRepository<PackingListDetail> packingListDetail;
        private IRepository<Contractors> contractors;
        private IRepository<MtsAssemblies> mtsAssemblies;

        private IMapper mapper;

        public PackingListsService(IUnitOfWork uow)
        {
            Database = uow;
            packingLists = Database.GetRepository<PackingLists>();
            packingListMaterials = Database.GetRepository<PackingListMaterials>();
            customerOrders = Database.GetRepository<CustomerOrders>();
            cities = Database.GetRepository<City>();
            countries = Database.GetRepository<Country>();
            employeesDetails = Database.GetRepository<EmployeesDetails>();
            packingListsJournal = Database.GetRepository<PackingListsJournal>();
            packingListDetail = Database.GetRepository<PackingListDetail>();
            contractors = Database.GetRepository<Contractors>();
            mtsAssemblies = Database.GetRepository<MtsAssemblies>();

                        
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PackingLists, PackingListsDTO>();
                cfg.CreateMap<PackingListsDTO, PackingLists>();
                cfg.CreateMap<PackingListMaterials, PackingListMaterialsDTO>();
                cfg.CreateMap<PackingListMaterialsDTO, PackingListMaterials>();
                cfg.CreateMap<PackingListsJournal, PackingListsJournalDTO>();
                cfg.CreateMap<PackingListsJournalDTO, PackingListsJournal>();
                cfg.CreateMap<PackingListDetailDTO, PackingListDetail>();
                cfg.CreateMap<PackingListDetail, PackingListDetailDTO>();
                cfg.CreateMap<Contractors, ContractorsDTO>();
                cfg.CreateMap<CustomerOrders, CustomerOrdersDTO>();
                cfg.CreateMap<CustomerOrdersDTO, CustomerOrders>();
                cfg.CreateMap<MtsAssemblies, MtsAssembliesDTO>();
                cfg.CreateMap<MtsAssembliesDTO, MtsAssemblies>();

            });

            mapper = config.CreateMapper();
        }

        public IEnumerable<PackingListsJournalDTO> GetPackingJournal(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", beginDate),
                new FbParameter("EndDate", endDate)
            };
            //string procName = @"select * from ""GetPackingListJournalProc""(@BeginDate,@EndDate)";

            string procName = @"select * from ""GetPackingListProc""(@BeginDate,@EndDate)";
            


            return mapper.Map<IEnumerable<PackingListsJournal>, List<PackingListsJournalDTO>>(packingListsJournal.SQLExecuteProc(procName, Parameters));
        }

        public PackingListMaterialsDTO GetPackingListMaterialsById(int? packingListId)
        {
            return mapper.Map<PackingListMaterials, PackingListMaterialsDTO>(packingListMaterials.GetAll().FirstOrDefault(s => s.Id == packingListId));        
        }

        public IEnumerable<PackingListsDTO> GetPackingLists()
        {
            return mapper.Map<IEnumerable<PackingLists>, List<PackingListsDTO>>(packingLists.GetAll());
        }

        public IEnumerable<PackingListDetailDTO> GetPackingListDetailId(int id)
        {
            var result = (from pld in packingListDetail.GetAll()
                          join cos in customerOrders.GetAll() on pld.CustomerOrderId equals cos.Id into cosl
                          from cos in cosl.DefaultIfEmpty()
                          join pl in packingLists.GetAll() on pld.PackingListId equals pl.Id into pll
                          from pl in pll.DefaultIfEmpty()
                          join con in contractors.GetAll() on cos.ContractorId equals con.Id into cont
                          from con in cont.DefaultIfEmpty()
                          where pld.PackingListId == id
                          select new PackingListDetailDTO()
                          {
                              Id = pld.Id,
                              CustomerOrderId = cos.Id,
                              CustomerOrdersNumber = cos.OrderNumber,
                              PackingListId = pl.Id,
                              OrderDate = cos.OrderDate,
                              ContractorName = con.Name

                          }).ToList();
            return result;
        }


       


        #region PackingList CRUD                              

        public int PackingListCreate(PackingListsDTO pdto)
        {
            var newRec = packingLists.Create(mapper.Map<PackingLists>(pdto));
            return newRec.Id;
        }

        public void PackingListUpdate(PackingListsDTO pdto)
        {
            var ePList = packingLists.GetAll().SingleOrDefault(c => c.Id == pdto.Id);

            packingLists.Update(mapper.Map<PackingListsDTO, PackingLists>(pdto, ePList));
        }

        public bool PackingListDeleteById(int? id)
        {
            try
            {
                var delPList = packingLists.GetAll().SingleOrDefault(c => c.Id == id.Value);
                packingLists.Delete(delPList);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region PackingListsMaterials CRUD                    

        public void PackingListMaterialsCreateRange(List<PackingListMaterialsDTO> source)
        {
            packingListMaterials.CreateRange(mapper.Map<IEnumerable<PackingListMaterials>>(source));
        }

        public int PackingListMaterialsCreate(PackingListMaterialsDTO pmdto)
        {
            var newRec = packingListMaterials.Create(mapper.Map<PackingListMaterials>(pmdto));
            return newRec.Id;
        }

        public void PackingListMaterialsUpdate(PackingListMaterialsDTO pmdto)
        {
            var ePList = packingListMaterials.GetAll().SingleOrDefault(c => c.Id == pmdto.Id);

            packingListMaterials.Update(mapper.Map<PackingListMaterialsDTO, PackingListMaterials>(pmdto, ePList));
        }

        public bool PackingListMaterialsDeleteById(int? id)
        {
            try
            {
                var delPList = packingListMaterials.GetAll().SingleOrDefault(c => c.Id == id.Value);
                packingListMaterials.Delete(delPList);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        #endregion

        #region PackingListDetail CRUD                       

        public int PackingListDetailsCreate(PackingListDetailDTO plddto)
        {
            var newRec = packingListDetail.Create(mapper.Map<PackingListDetail>(plddto));
            return newRec.Id;
        }

        public void PackingListDetailsUpdate(PackingListDetailDTO plddto)
        {
            var ePList = packingListDetail.GetAll().SingleOrDefault(c => c.Id == plddto.Id);

            packingListDetail.Update(mapper.Map<PackingListDetailDTO, PackingListDetail>(plddto, ePList));
        }

        public bool PackingListDetailsDeleteById(int? id)
        {
            try
            {
                var delPList = packingListDetail.GetAll().SingleOrDefault(c => c.Id == id.Value);
                packingListDetail.Delete(delPList);
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
