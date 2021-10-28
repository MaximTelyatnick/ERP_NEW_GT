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
    public class ProjectDetailsService : IProjectDetailsService
    {
       private IUnitOfWork Database { get; set; }
       private IRepository<Professions> professions;
       private IRepository<ProjectDetails> projectDetails;
       private IRepository<ProjectDetailExecutors> projectDetailExecutors;
       private IRepository<CustomerOrders> customerOrders;
       private IRepository<CustomerOrderSpecifications> customerOrderSpecifications;
       private IRepository<CustomerOrderAssemblies> customerOrderAssemblies;
       private IRepository<EmployeesInfo> employeesInfo;
       private IRepository<ControlChecks> controlChecks;
       private IRepository<Employees> employees;
       private IRepository<EmployeesDetails> employeesDetails;
       private IRepository<MtsAssemblies> mtsAssemblies;
       private IRepository<WeldStampJournal> weldStampJournal;
       private IRepository<WeldStamps> weldStamps;
       private IRepository<Contractors> contractors;
       private IRepository<Contractors> contractorsCustomer;
       private IRepository<PaintingWorksJournal> paintingWorksJournal;
       private IRepository<PaintingWorks> paintingWorks;
       private IRepository<Users> users;


        private IMapper mapper;

        public ProjectDetailsService(IUnitOfWork uow)
        {
            Database = uow;

            professions = Database.GetRepository<Professions>();
            projectDetails = Database.GetRepository<ProjectDetails>();
            projectDetailExecutors = Database.GetRepository<ProjectDetailExecutors>();
            customerOrders = Database.GetRepository<CustomerOrders>();
            customerOrderSpecifications = Database.GetRepository<CustomerOrderSpecifications>();
            customerOrderAssemblies = Database.GetRepository<CustomerOrderAssemblies>();
            employees = Database.GetRepository<Employees>();
            employeesDetails = Database.GetRepository<EmployeesDetails>();
            controlChecks = Database.GetRepository<ControlChecks>();
            employees = Database.GetRepository<Employees>();
            employeesDetails = Database.GetRepository<EmployeesDetails>();
            mtsAssemblies = Database.GetRepository<MtsAssemblies>();
            weldStampJournal = Database.GetRepository<WeldStampJournal>();
            weldStamps = Database.GetRepository<WeldStamps>();
            contractors = Database.GetRepository<Contractors>();
            contractorsCustomer = Database.GetRepository<Contractors>();
            paintingWorks = Database.GetRepository<PaintingWorks>();
            paintingWorksJournal = Database.GetRepository<PaintingWorksJournal>();
            users = Database.GetRepository<Users>();

            


            var config = new MapperConfiguration(cfg =>
              {
                  cfg.CreateMap<Employees, EmployeesDTO>();
                  cfg.CreateMap<EmployeesInfo, EmployeesInfoDTO>();
                  cfg.CreateMap<Professions, ProfessionsDTO>();
                  cfg.CreateMap<ProjectDetails, ProjectDetailsDTO>();
                  cfg.CreateMap<ProjectDetailsDTO, ProjectDetails>();
                  cfg.CreateMap<ProjectDetailExecutors, ProjectDetailExecutorsDTO>();
                  cfg.CreateMap<ProjectDetailExecutorsDTO, ProjectDetailExecutors>();
                  cfg.CreateMap<CustomerOrders, CustomerOrdersDTO>();
                  cfg.CreateMap<CustomerOrderSpecifications, CustomerOrderSpecificationsDTO>();
                  cfg.CreateMap<CustomerOrderAssemblies, CustomerOrderAssembliesDTO>();
                  cfg.CreateMap<EmployeesInfo, EmployeesInfoDTO>();
                  cfg.CreateMap<ControlChecks, ControlChecksDTO>();
                  cfg.CreateMap<ControlChecksDTO, ControlChecks>();
                  cfg.CreateMap<MtsAssemblies, MtsAssembliesDTO>();
                  cfg.CreateMap<WeldStampJournal, WeldStampJournalDTO>();
                  cfg.CreateMap<WeldStamps, WeldStampsDTO>();
                  cfg.CreateMap<Contractors, ContractorsDTO>();
                  cfg.CreateMap<PaintingWorksJournal, PaintingWorksJournalDTO>();
                  cfg.CreateMap<PaintingWorksJournalDTO, PaintingWorksJournal>();
                  cfg.CreateMap<PaintingWorks, PaintingWorksDTO>();
                  cfg.CreateMap<PaintingWorksDTO, PaintingWorks>();
                  cfg.CreateMap<UsersDTO, Users>();
              });
            mapper = config.CreateMapper();
        }

        public IEnumerable<ProjectDetailsDTO> GetProjectDetails()
        {
            var result = (from pd in projectDetails.GetAll()
                          join mt in mtsAssemblies.GetAll() on pd.AssemblyId equals mt.Id into mts
                          from mt in mts.DefaultIfEmpty()
                          join con in contractors.GetAll() on mt.ContractorId equals con.Id into cont
                          from con in cont.DefaultIfEmpty()
                          join cc in controlChecks.GetAll() on pd.ProjectDetailId equals cc.ProjectDetailId into pdcc
                          from cc in pdcc.DefaultIfEmpty()
                          join e in employees.GetAll() on cc.ControlPersonId equals e.EmployeeID into cce
                          from e in cce.DefaultIfEmpty()
                          join ed in employeesDetails.GetAll() on e.EmployeeID equals ed.EmployeeID into eed
                          from ed in eed.DefaultIfEmpty()
                          join coso in customerOrders.GetAll() on pd.CustomerOrderId equals coso.Id into cosoo
                          from coso in cosoo.DefaultIfEmpty()
                          join cono in contractors.GetAll() on coso.ContractorId equals cono.Id into conoo
                          from cono in conoo.DefaultIfEmpty()

                   
                          //join coa in customerOrderAssemblies.GetAll() on mt.Id equals coa.AssemblyId into coaa
                          //from coa in coaa.DefaultIfEmpty()
                          //join cos in customerOrderSpecifications.GetAll() on coa.CustomerOrderSpecId equals cos.Id into cosa
                          //from cos in cosa.DefaultIfEmpty()
                          //join coso in customerOrders.GetAll() on cos.CustomerOrderId equals coso.Id into cosoo
                          //from coso in cosoo.DefaultIfEmpty()
                          //join cono in contractors.GetAll() on coso.ContractorId equals cono.Id into conoo
                          //from cono in conoo.DefaultIfEmpty()


                         select new ProjectDetailsDTO
                         {

                             ProjectDetailId = pd.ProjectDetailId,
                             Drawing = mt.Drawing != null ? mt.Drawing : pd.AssemblyDrawing,
                             AssemblyId = mt.Id,
                             AssemblyDate = mt.DateCreated,
                             ContractorName = cono.Name != null ? cono.Name : con.Name ,
                             AssemblyGeneralName = mt.Name,
                             AssemblyDrawing = pd.AssemblyDrawing,
                             AssemblyName = pd.AssemblyName,
                             ControlCheckId = cc.ControlCheckId,
                             ControlDate = cc.ControlDate,
                             Description = cc.Description,
                             ControlPersonId = cc.ControlPersonId,
                             ControlPersonName = ed.LastName + " " + ed.FirstName,
                             MarkDocumentNumber = cc.MarkDocumentNumber, 
                              OrderNumber = coso.OrderNumber,
                               CustomerOrderId = coso.Id
                         });

            //var groupByRezult = result.AsEnumerable()
            //    .GroupBy(l => new
            //    {
            //        l.ProjectDetailId,
            //                 l.Drawing,
            //                 l.AssemblyId,
            //                 l.AssemblyDate,
            //                 l.ContractorName,
            //                 l.AssemblyGeneralName,
            //                 l.AssemblyDrawing,
            //                 l.AssemblyName,
            //                 l.ControlCheckId,
            //                 l.ControlDate,
            //                 l.Description,
            //                 l.ControlPersonId,
            //                 l.ControlPersonName,
            //                 l.MarkDocumentNumber
            //    }).Select(g => new ProjectDetailsDTO
            //    {
            //        ProjectDetailId = g.Key.ProjectDetailId,
            //                 Drawing = g.Key.Drawing,
            //                 AssemblyId = g.Key.AssemblyId,
            //                 AssemblyDate = g.Key.AssemblyDate,
            //                 ContractorName = g.Key.ContractorName,
            //                 AssemblyGeneralName = g.Key.AssemblyGeneralName,
            //                 AssemblyDrawing = g.Key.AssemblyDrawing,
            //                 AssemblyName = g.Key.AssemblyName,
            //                 ControlCheckId = g.Key.ControlCheckId,
            //                 ControlDate = g.Key.ControlDate,
            //                 Description = g.Key.Description,
            //                 ControlPersonId = g.Key.ControlPersonId,
            //                 ControlPersonName = g.Key.ControlPersonName,
            //                  MarkDocumentNumber = g.Key.MarkDocumentNumber,
            //        OrderNumber = string.Join(", ", g.Select(md => md.OrderNumber).ToList())
            //    });


            //List<ProjectDetailsDTO> returnSortList = new List<ProjectDetailsDTO>();

            ////Убираем дубликаты
            //foreach (var item in groupByRezult.ToList())
            //{
            //    string[] splitDrawingString = item.OrderNumber.Split(',');
            //    item.OrderNumber = string.Join(",", (splitDrawingString.Distinct()).ToArray());
            //    returnSortList.Add(item);
            //}

            //OrderNumber = co.OrderNumber,


            return result.OrderByDescending(mt => mt.AssemblyDate).ToList();
        }

        public IEnumerable<ProjectDetailExecutorsDTO> GetProjectDetailExecutors(int id)
        {
            var result = (from pd in projectDetailExecutors.GetAll()
                          join emi in employeesDetails.GetAll() on pd.EmployeeId equals emi.EmployeeID into emii
                          from emi in emii.DefaultIfEmpty()
                          join em in employees.GetAll() on pd.EmployeeId equals em.EmployeeID into emm
                          from em in emm.DefaultIfEmpty()
                          join pro in professions.GetAll() on emi.ProfessionID equals pro.ProfessionID into prof
                          from pro in prof.DefaultIfEmpty()
                          join wsj in weldStampJournal.GetAll() on pd.EmployeeId equals wsj.EmployeeId into wsjj
                          from wsj in wsjj.DefaultIfEmpty()
                          join ws in weldStamps.GetAll() on wsj.WeldStampId equals ws.Id into wss
                          from ws in wss.DefaultIfEmpty()
                          where pd.ProjectDetailId == id
                          select new ProjectDetailExecutorsDTO
                         {
                             ProjectDetailId = pd.ProjectDetailId,
                             WeldStampId = ws.Id,
                             WeldStampJournalId = wsj.Id,
                             EmployeeId = em.EmployeeID,
                             BeginDate = ws.StampDate,
                             StampNumber = ws.StampNumber,
                             ProjectDetailExecutorId = pd.ProjectDetailExecutorId,
                             Fio = emi.LastName + " " + emi.FirstName + " " + emi.MiddleName,
                             ProfessionName = pro.Name,
                             AccountNumber = em.AccountNumber
                         });

            return result.ToList();

              ///////////////////////////////////////////////////////////////////////////////////////////////////
             ///                          Пример как усложнить код и сделать его медленее                     //
            /// ///////////////////////////////////////////////////////////////////////////////////////////////
            //string procName = @"select * from ""GetEmployeesWorking""";

            //var employees = mapper.Map<IEnumerable<EmployeesInfo>, List<EmployeesInfoDTO>>(employeesInfo.SQLExecuteProc(procName));

            //var executors = (from pe in projectDetailExecutors.GetAll()
            //                 join pd in projectDetails.GetAll() on pe.ProjectDetailId equals pd.ProjectDetailId into pc
            //                 from pd in pc.DefaultIfEmpty()
            //                 select new ProjectDetailExecutorsDTO
            //                 {
            //                     ProjectDetailId = pd.ProjectDetailId,
            //                     ProjectDetailExecutorId = pe.ProjectDetailExecutorId,
            //                     EmployeeId = pe.EmployeeId
            //                 }).ToList();

            //var result = (from pe in executors
            //              /*join em in employeesInfo.GetAll() on pe.EmployeeId equals em.EmployeeID*/ 

            //              join wsj in weldStampJournal.GetAll() on pe.EmployeeId equals wsj.EmployeeId  
            //              join ws in weldStamps.GetAll() on wsj.WeldStampId equals ws.Id into wss
            //              from ws in wss.DefaultIfEmpty()
            //              select new ProjectDetailExecutorsDTO
            //             {
            //                 ProjectDetailId = pe.ProjectDetailId,
            //                 ProjectDetailExecutorId = pe.ProjectDetailExecutorId,
            //                 EmployeeId = pe.EmployeeId,
            //                 WeldStampJournalId = wsj.Id,
            //                 WeldStampId = ws.Id,
            //                 BeginDate = ws.StampDate,
            //                 StampNumber = ws.StampNumber//,
            //                 /*Fio = em.Fio,
            //                 ProfessionName = em.ProfessionName,
            //                 AccountNumber = em.AccountNumber*/
            //             });
        }

        public IEnumerable<ControlChecksDTO> GetControlChecks()
        {
            return mapper.Map<IEnumerable<ControlChecks>, List<ControlChecksDTO>>(controlChecks.GetAll().OrderBy(s => s.MarkDocumentNumber));
        }

        public IEnumerable<ControlChecksDTO> GetControlChecksJournal()
        {
            var result = (from cc in controlChecks.GetAll()
                          join cus in customerOrders.GetAll() on cc.CustomerOrderId equals cus.Id into cuss
                          from cus in cuss.DefaultIfEmpty()
                          join con in contractors.GetAll() on cus.ContractorId equals con.Id into conn
                          from con in conn.DefaultIfEmpty()
                          join em in employeesDetails.GetAll() on cc.ControlPersonId equals em.EmployeeID into emm
                          from em in emm.DefaultIfEmpty()
                          select new ControlChecksDTO
                          {
                               ControlCheckId = cc.ControlCheckId,
                                ControlDate = cc.ControlDate,
                                 MarkDocumentNumber = cc.MarkDocumentNumber,
                                  Description = cc.Description,
                                   ControlPersonId = cc.ControlPersonId,
                                    CustomerOrderId = cc.CustomerOrderId,
                                     CustomerOrderNumber = cus.OrderNumber,
                                      ContractorName = con.Name,
                                       ControlPersonName = em.LastName + " " + em.FirstName + " " + em.MiddleName
                                 
                          });

            return result.ToList();
        }

        //---
        public IEnumerable<PaintingWorksJournalDTO> GetPaintingWorks(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", beginDate),
                new FbParameter("EndDate", endDate),
            };

            string procName = @"select * from ""GetPaintingWorks""(@BeginDate, @EndDate)";

            return mapper.Map<IEnumerable<PaintingWorksJournal>, List<PaintingWorksJournalDTO>>(paintingWorksJournal.SQLExecuteProc(procName, Parameters));
        }



        //public IEnumerable<PaintingWorksDTO> GetPaintingWorks(DateTime beginDate, DateTime endDate)
        //{
            //var result = (from pw in paintingWorks.GetAll()
            //              join mt in mtsAssemblies.GetAll() on pw.MtsAssembliesId equals mt.Id into mts
            //              from mt in mts.DefaultIfEmpty()
            //              join usr in users.GetAll() on pw.ResponsiblePersonId equals usr.UserId into usrr
            //              from usr in usrr.DefaultIfEmpty()
            //              join emd in employeesDetails.GetAll() on usr.EmployeeId equals emd.EmployeeID into emdd
            //              from emd in emdd.DefaultIfEmpty()

            //              where (pw.Date >= beginDate && pw.Date <= endDate )
            //              select new PaintingWorksDTO
            //              {
            //                  Id = pw.Id,
            //                  Date = pw.Date,
            //                  NumberDrawing = mt.Drawing,
            //                  NameProduct = mt.Name,
            //                  NameCheckProduct = pw.NameCheckProduct,
            //                  Result = pw.Result,
            //                  QuantityOfExecution = pw.QuantityOfExecution,
                              
            //                  CheckQuantityOfExecution = pw.CheckQuantityOfExecution,
            //                  ResponsiblePersonId = pw.ResponsiblePersonId,
            //                  ResponsiblePerson = emd.LastName + " " + emd.FirstName + " " + emd.MiddleName,                               
            //                  CauseReturn = pw.CauseReturn,
            //                  CorrectiveAction = pw.CorrectiveAction,
            //                  FinalResponsiblePersonId = pw.FinalResponsiblePersonId,
            //                  FinalResponsibePerson = pw.FinalResponsiblePersonId!=null?emd.LastName + " " + emd.FirstName + " " + emd.MiddleName:null,                              
            //                  Note = pw.Note,
            //                  MtsAssembliesId = mt.Id,
            //                  SeqNum = pw.SeqNum
                                                       
        //                  });//.OrderBy(p=>p.Id);

        //    return result.ToList();



       // }



        #region PaintingWorks CRUD Method's

        public int PaintingWorksCreate(PaintingWorksDTO pWorks)
        {
            var createrecord = paintingWorks.Create(mapper.Map<PaintingWorks>(pWorks));
            return (int)createrecord.Id;
        }

        public void PaintingWorksUpdate(PaintingWorksDTO pWorks)
        {

            var eGroup = paintingWorks.GetAll().SingleOrDefault(c => c.Id == pWorks.Id);
            paintingWorks.Update((mapper.Map<PaintingWorksDTO, PaintingWorks>(pWorks, eGroup)));
        }

        public bool PaintingWorksDelete(int id)
        {
            try
            {
                paintingWorks.Delete(paintingWorks.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion


        //----



        #region ProjectDetail CRUD Method's

        public int ProjectDetailCreate(ProjectDetailsDTO projectDetail)
        {
            var createrecord = projectDetails.Create(mapper.Map<ProjectDetails>(projectDetail));
            return (int)createrecord.ProjectDetailId;
        }

        public void ProjectDetailUpdate(ProjectDetailsDTO projectDetail)
        {

            var eGroup = projectDetails.GetAll().SingleOrDefault(c => c.ProjectDetailId == projectDetail.ProjectDetailId);
            projectDetails.Update((mapper.Map<ProjectDetailsDTO, ProjectDetails>(projectDetail, eGroup)));
        }

        public bool ProjectDetailDelete(int id)
        {
            try
            {
                projectDetails.Delete(projectDetails.GetAll().FirstOrDefault(c => c.ProjectDetailId == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region ControlCheck CRUD method's

        public int ControlCheckCreate(ControlChecksDTO ccdto)
        {
            var createrecord = controlChecks.Create(mapper.Map<ControlChecks>(ccdto));
            return (int)createrecord.ControlCheckId;
        }

        public void ControlCheckUpdate(ControlChecksDTO ccdto)
        {
            var eGroup = controlChecks.GetAll().SingleOrDefault(c => c.ControlCheckId == ccdto.ControlCheckId);
            controlChecks.Update((mapper.Map<ControlChecksDTO, ControlChecks>(ccdto, eGroup)));
        }

        public bool ControlCheckDelete(int id)
        {
            try
            {
                controlChecks.Delete(controlChecks.GetAll().FirstOrDefault(c => c.ControlCheckId == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region ProjectExecutors CRUD method's

        public void ProjectExecutorsUpdateRange(List<ProjectDetailExecutorsDTO> source)
        {
            projectDetailExecutors.CreateRange(mapper.Map<IEnumerable<ProjectDetailExecutors>>(source));
        }

        public bool ProjectExecutorsDelete(int id)
        {
            try
            {
                projectDetailExecutors.Delete(projectDetailExecutors.GetAll().FirstOrDefault(c => c.ProjectDetailExecutorId == id));
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
