using ERP_NEW.BLL.Infrastructure;
namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class CustomerOrderSpecificationsDTO : ObjectBase
    {
        public int Id { get; set; }
        public int CustomerOrderId { get; set; }
        public string Name { get; set; }
        public decimal? SinglePrice { get; set; }
        public decimal? SingleCurrencyPrice { get; set; }
        public decimal? SumPrice { get; set; }
        public decimal? SumCurrencyPrice { get; set; }
        public decimal? Quantity { get; set; }

        public string CustomerOrderNumber { get; set; }
    }
}
