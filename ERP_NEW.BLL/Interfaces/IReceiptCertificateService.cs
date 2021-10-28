using System.Collections.Generic;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IReceiptCertificateService
    {
        ReceiptCertificatesDTO GetCertificate(long id);
        IEnumerable<ReceiptCertificatesDTO> GetCertificates();
        IEnumerable<OrdersInfoDTO> GetOrdersWithCertificate(DateTime beginDate, DateTime endDate);
        IEnumerable<ExpenditureByOrdersDTO> GetExpenditureByCustomerOrders(DateTime beginDate, DateTime endDate);

        long CreateCertificate(ReceiptCertificatesDTO dtomodel);
        void UpdateCertificate(ReceiptCertificatesDTO dtomodel);
        bool RemoveCertificateById(long id);

        void Dispose();
    }
}
