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
        IEnumerable<ReceiptCertificateDetailDTO> GetCertificateDetail();
        IEnumerable<OrdersInfoDTO> GetOrdersWithCertificate(DateTime beginDate, DateTime endDate);
        IEnumerable<OrdersInfoDTO> GetOrdersWithCertificateV2(DateTime beginDate, DateTime endDate);
        IEnumerable<ExpenditureByOrdersDTO> GetExpenditureByCustomerOrders(DateTime beginDate, DateTime endDate);

        long CreateCertificate(ReceiptCertificatesDTO dtomodel);
        void UpdateCertificate(ReceiptCertificatesDTO dtomodel);
        bool RemoveCertificateById(long id);

        long CreateCertificateDetail(ReceiptCertificateDetailDTO dtomodel);
        void UpdateCertificateDetail(ReceiptCertificateDetailDTO dtomodel);
        bool RemoveCertificateDetailId(long id);

        void Dispose();
    }
}
