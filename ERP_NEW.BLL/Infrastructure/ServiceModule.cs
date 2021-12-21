using ERP_NEW.DAL.Entities;
using ERP_NEW.DAL.Interfaces;
using ERP_NEW.DAL.Repositories;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Services;

using Ninject.Modules;

namespace ERP_NEW.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IDeliveryService>().To<DeliveryService>();
            Bind<IReceiptCertificateService>().To<ReceiptCertificateService>();
            Bind<IUserService>().To<UserService>();
            Bind<IEmployeesService>().To<EmployeesService>();
            Bind<IContractorsService>().To<ContractorsService>();
            Bind<ICustomerOrdersService>().To<CustomerOrdersService>();
            Bind<ICurrencyService>().To<CurrencyService>();
            Bind<IReportService>().To<ReportService>();
            Bind<IDefectActsService>().To<DefectActsService>();
            Bind<IDocumentTypesService>().To<DocumentTypesService>();
            Bind<IShipmentListsService>().To<ShipmentListsService>();
            Bind<IPackingListsService>().To<PackingListsService>();
            Bind<IProjectDetailsService>().To<ProjectDetailsService>();
            Bind<ICityService>().To<CityService>();
            Bind<IWeldStampsService>().To<WeldStampsService>();
            Bind<IMtsNomenclaturesService>().To<MtsNomenclaturesService>();
            Bind<IUnitsService>().To<UnitsService>();
            Bind<IMtsSpecificationsService>().To<MtsSpecificationsService>();
            Bind<IAccountsService>().To<AccountsService>();
            Bind<IBusinessTripsService>().To<BusinessTripsService>();
            Bind<IStoreHouseService>().To<StoreHouseService>();
            Bind<IPeriodService>().To<PeriodService>();
            Bind<IBankPaymentsService>().To<BankPaymentsService>();
            Bind<ICalcWithBuyersService>().To<CalcWithBuyersService>();
            Bind<IAccountingOperationService>().To<AccountingOperationService>();
            Bind<IBankImportService>().To<BankImportService>();
            Bind<IBusinessCardService>().To<BusinessCardService>();
            Bind<ICashBookService>().To<CashBookService>();
            Bind<IAccountingInvoicesService>().To<AccountingInvoicesService>();
            Bind<IFixedAssetsOrderService>().To<FixedAssetsOrderService>();
            Bind<IRequestLogService>().To<RequestLogService>();
            Bind<IMarketingService>().To<MarketingService>();
            Bind<IInfrastructureService>().To<InfrastructureService>();
            Bind<ILogService>().To<LogService>();
        }
    }
}
