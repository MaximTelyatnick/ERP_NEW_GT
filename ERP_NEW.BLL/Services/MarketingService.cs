using AutoMapper;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.DAL.Entities.Models;
using ERP_NEW.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Services
{
    public class MarketingService : IMarketingService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<Calculation> calculation;
        private IRepository<CalculationMaterials> calculationMaterials;
        private IRepository<CustomerOrders> customerOrders;
        private IRepository<Contractors> contractors;
        private IRepository<EXPENDITURES_ACCOUNTANT> expenditureAccountant;
        private IRepository<RECEIPTS> receipt;
        private IRepository<ORDERS> orders;
        private IRepository<NOMENCLATURES> nomenclatures;
        private IRepository<Units> units;


        private IMapper mapper;

        public MarketingService(IUnitOfWork uow)
        {
            Database = uow;
            calculation = Database.GetRepository<Calculation>();
            calculationMaterials = Database.GetRepository<CalculationMaterials>();
            customerOrders = Database.GetRepository<CustomerOrders>();
            contractors = Database.GetRepository<Contractors>();
            expenditureAccountant = Database.GetRepository<EXPENDITURES_ACCOUNTANT>();
            units = Database.GetRepository<Units>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Calculation, CalculationDTO>();
                cfg.CreateMap<CalculationDTO, Calculation>();
                cfg.CreateMap<CalculationMaterials, CalculationMaterialsDTO>();
                cfg.CreateMap<CalculationMaterialsDTO, CalculationMaterials>();
                cfg.CreateMap<CustomerOrders, CustomerOrdersDTO>();
                cfg.CreateMap<Contractors, ContractorsDTO>();
                cfg.CreateMap<EXPENDITURES_ACCOUNTANT, ExpedinturesAccountantDTO>();
                cfg.CreateMap<NOMENCLATURES, NomenclaturesDTO>();
                cfg.CreateMap<RECEIPTS, ReceiptsDTO>();
                cfg.CreateMap<ORDERS, OrdersDTO>();

            });

            mapper = config.CreateMapper();
        }

        private string[] vsS =
            {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",

                "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK",
                "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV",
                "AW", "AX", "AY", "AZ",

                "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM",
                "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ",

                "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM",
                "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ"
            };

        public IEnumerable<CalculationDTO> GetCalculation()
        {
            var rezult = (from calc in calculation.GetAll()
                          join c in customerOrders.GetAll() on calc.CustomerOrderId equals c.Id into cus
                          from c in cus.DefaultIfEmpty()
                          join con in contractors.GetAll() on c.ContractorId equals con.Id into conn
                          from con in conn.DefaultIfEmpty()
                          select new CalculationDTO()
                          {
                              Id = calc.Id,
                               CalcDate = calc.CalcDate,
                                CalcNumber = calc.CalcNumber,
                                  CustomerOrderId = calc.CustomerOrderId,
                                   ContractorName = con.Name,
                                    CustonerOrderNumber = c.OrderNumber

                          });
            return rezult;
        }

        public IEnumerable<CalculationMaterialsDTO> GetCalculationMaterials(int calcId)
        {
            var rezult = (from calcMat in calculationMaterials.GetAll()
                          join exp in expenditureAccountant.GetAll() on calcMat.ExpAccId equals exp.ID into expp
                          from exp in expp.DefaultIfEmpty()
                          join rec in receipt.GetAll() on exp.RECEIPT_ID equals rec.ID into recc
                          from rec in recc.DefaultIfEmpty()
                          join n in nomenclatures.GetAll() on rec.NOMENCLATURE_ID equals n.ID into rn
                          from n in rn.DefaultIfEmpty()
                          join or in orders.GetAll() on rec.ORDER_ID equals or.ID into orr
                          from or in orr.DefaultIfEmpty()
                          join c in contractors.GetAll() on or.VENDOR_ID equals c.Id into co
                          from c in co.DefaultIfEmpty()
                          join u in units.GetAll() on n.UnitId equals u.UnitId into nu
                          from u in nu.DefaultIfEmpty()
                          where (calcMat.CalcId == calcId)
                          select new CalculationMaterialsDTO()
                          {
                               Id = calcMat.Id,
                                CalcId = calcMat.CalcId,
                                 ExpAccId = calcMat.ExpAccId,
                                  MaterialType = calcMat.MaterialType,
                                   ContractorOrderName = c.Name,
                                    ContractorOrderSrn= c.Srn,
                                     ExpenditureDate = exp.EXP_DATE,
                                      Price = exp.PRICE,
                                       Quantity = exp.QUANTITY,
                                        ReceiptNum = or.RECEIPT_NUM,
                                         UnitLocalName = u.UnitLocalName,
                                          Nomenclature = n.NOMENCLATURE,
                                           NomenclatureName = n.NAME,
                               ReceiptCountry = c.Srn!=""?"Україна":"Неопред"
                                        
                                  

                          });
            return rezult;
        }

        #region Calculation CRUD method's

        public int CalculationCreate(CalculationDTO calculationDTO)
        {
            var createCalculation = calculation.Create(mapper.Map<Calculation>(calculationDTO));
            return (int)createCalculation.Id;
        }
        public void CalculationUpdate(CalculationDTO calculationDTO)
        {
            var updateCalculation = calculation.GetAll().SingleOrDefault(c => c.Id == calculationDTO.Id);
            calculation.Update((mapper.Map<CalculationDTO, Calculation>(calculationDTO, updateCalculation)));
        }
        public bool CalculationDelete(int id)
        {
            try
            {
                calculation.Delete(calculation.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int CalculationMaterialsCreate(CalculationMaterialsDTO calculationMaterialsDTO)
        {
            var createCalculationMaterials = calculationMaterials.Create(mapper.Map<CalculationMaterials>(calculationMaterialsDTO));
            return (int)createCalculationMaterials.Id;
        }
        public void CalculationMaterialsUpdate(CalculationMaterialsDTO calculationMaterialsDTO)
        {
            var updateCalculationMaterials = calculationMaterials.GetAll().SingleOrDefault(c => c.Id == calculationMaterialsDTO.Id);
            calculationMaterials.Update((mapper.Map<CalculationMaterialsDTO, CalculationMaterials>(calculationMaterialsDTO, updateCalculationMaterials)));
        }
        public bool CalculationMaterialsDelete(int id)
        {
            try
            {
                calculationMaterials.Delete(calculationMaterials.GetAll().FirstOrDefault(c => c.Id == id));
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
