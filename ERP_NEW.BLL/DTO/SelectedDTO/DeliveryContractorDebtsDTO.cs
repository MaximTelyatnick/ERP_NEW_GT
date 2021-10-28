using System;


namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class DeliveryContractorDebtsDTO
    {
        public int VendorId { get; set; }
        public string VendorSrn { get; set; }
        public string VendorName { get; set; }
        public decimal Price { get; set; }
        public string DebtStatus { get; set; }
    }
}
