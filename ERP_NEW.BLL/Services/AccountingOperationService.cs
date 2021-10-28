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
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.Services
{
    public class AccountingOperationService : IAccountingOperationService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<AccountingOperation> accountingOperation;
        private IMapper mapper;

        public AccountingOperationService(IUnitOfWork uow)
        {
            Database = uow;
            accountingOperation = Database.GetRepository<AccountingOperation>();
            
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AccountingOperation, AccountingOperationDTO>();
            });

            mapper = config.CreateMapper();
        }
                
        public IEnumerable<AccountingOperationDTO> GetAccountingOperation()
        {
            return mapper.Map<IEnumerable<AccountingOperation>, List<AccountingOperationDTO>>(accountingOperation.GetAll());
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
