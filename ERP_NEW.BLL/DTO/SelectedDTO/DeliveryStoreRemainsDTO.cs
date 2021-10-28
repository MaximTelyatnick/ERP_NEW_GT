using System;


namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class DeliveryStoreRemainsDTO
    {
        public int NomenclatureId { get; set; }
        public string Nomenclature { get; set; }
        public string NomenclatureName { get; set; }
        public decimal? RemainsQuantity { get; set; }
        public decimal? RemainsPrice { get; set; }
        public string Measure { get; set; }
    }
}
