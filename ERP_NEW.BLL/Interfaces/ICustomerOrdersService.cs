using System.Collections.Generic;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;

namespace ERP_NEW.BLL.Interfaces
{
     public interface ICustomerOrdersService
    {
         IEnumerable<CustomerOrdersDTO> GetCustomerOrders();
         bool CheckCustomerOrderEnable(int? customerOrderId);
         IEnumerable<CustomerOrdersDTO> GetCustomerOrdersFull();
         CustomerOrdersDTO GetCustomerOrdersFullById(int customerOrderId);
         IEnumerable<CustomerOrdersDTO> GetCustomerOrdersByPeriod(DateTime beginDate, DateTime endDate, bool money = true);
         IEnumerable<CustomerOrdersDTO> GetCustomerOrdersWithoutSign();
         IEnumerable<CustomerOrderSpecificationsDTO> GetCustomerOrderSpecificationsByOrderId(int orderId);
         IEnumerable<CustomerOrderSpecificationsDTO> GetCustomerOrderSpecificationsByOrderList(List<CustomerOrdersForCWBDTO> orderList);
         IEnumerable<CustomerOrderAssembliesDTO> GetCustomerOrderAssembliesBySpecId(int specId);
         IEnumerable<ContractPaymentsDTO> GetContractPaymentsByPeriod(DateTime beginDate, DateTime endDate);
         IEnumerable<CustomerOrderPrepaymentsDTO> GetCustomerOrderPrepaymentsById(int customerOrderId);
         IEnumerable<CustomerOrderPaymentsDTO> GetCustomerOrderPaymentsById(int customerOrderId);
         IEnumerable<CustomerOrderForWeldingDTO> GetCustomerOrderForWelding(DateTime beginDate, DateTime endDate);
         IEnumerable<CustomerOrdersDTO> GetCustomerOrdersFullWithReceipt();
         

         int CustomerOrderCreate(CustomerOrdersDTO customerOrder);
         void CustomerOrderUpdate(CustomerOrdersDTO customerOrder);
         bool CustomerOrderDelete(int id);

         int CustomerOrderSpecificationCreate(CustomerOrderSpecificationsDTO cosDTO);
         void CustomerOrderSpecificationCreateRange(List<CustomerOrderSpecificationsDTO> source);
         void CustomerOrderSpecificationUpdate(CustomerOrderSpecificationsDTO cosDTO);
         bool CustomerOrderSpecificationDelete(int id);

         int CustomerOrderAssemblyCreate(CustomerOrderAssembliesDTO coaDTO);
         void CustomerOrderAssemblyUpdate(CustomerOrderAssembliesDTO coaDTO);
         bool CustomerOrderAssemblyDelete(int id);

         int CustomerOrderPrepaymentCreate(CustomerOrderPrepaymentsDTO coprDTO);
         bool CustomerOrderPrepaymentDelete(int id);

         int CustomerOrderPaymentCreate(CustomerOrderPaymentsDTO copDTO);
         bool CustomerOrderPaymentDelete(int id);
    }
}
