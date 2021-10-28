
namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class MtsDetailsInfoDTO
    {
        public long MtsSpecificationId { get; set; }
        public long MtsCreatedDetailId { get; set; }
        public long MtsDetailId { get; set; }
        public long MtsNomenclatureId { get; set; }
        public string Name { get; set; }
        public string Drawing { get; set; }
        public string MaterialName { get; set; }
        public string GostName { get; set; }
        public string Gauge { get; set; }
        public string Note { get; set; }
        public string ProcessingName { get; set; }
        public decimal? Height { get; set; }
        public decimal? Width { get; set; }
        public decimal? QuantityOfBlanks { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Quantity { get; set; }
    }
}
