using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class MtsAssemblyDetailsDTO
    {
        public long Id { get; set; }
        public long MtsSpecificationId { get; set; }
        public long MtsCreatedDetails { get; set; }
        public decimal QuantityOfBlanks { get; set; }
        public decimal Quantity { get; set; }
        public short Changes { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
