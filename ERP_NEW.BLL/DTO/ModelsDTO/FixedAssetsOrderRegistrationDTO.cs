using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class FixedAssetsOrderRegistrationDTO : ObjectBase
    {
        public int Id { get; set; }
        public int FixedAssetsOrderId { get; set; }
        public string NumberOrder { get; set; }
        public DateTime? DateOrder { get; set; }
        public string TypeOrder { get; set; }
        public int StatusTypeOrder { get; set; }

        public DateTime? EndRecordDate { get; set; }
        public decimal? SoldPrice { get; set; }
        public decimal? TransferPrice { get; set; }
        public DateTime BeginDate { get; set; }
        public decimal? BeginPrice { get; set; }
        public int? Supplier_Id { get; set; }
        public int Pos { get; set; }

  

    }
}
