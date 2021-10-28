using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class FixedAssetsOrderRegJournalDTO :ObjectBase
    {
        public int Id { get; set; }
        public int FixedAssetsOrderId { get; set; }
        public string NumberOrder { get; set; }
        public string BalanceAccountNum { get; set; }
        public string InventoryNumber { get; set; }
        public DateTime DateOrder { get; set; }
        public string InventoryName { get; set; }
        public string TypeOrder { get; set; }
        public decimal? BeginPrice { get; set; }
        public int UsefulMonth { get; set; }
        public int StatusTypeOrder { get; set; }
        public int Id_Parent { get; set; }
        public int Balance_Account_Id { get; set; }
        public int GroupId { get; set; }
        public DateTime BeginDate { get; set; }
        public string SupplierName { get; set; }
        public DateTime EndRecordDate { get; set; }
        public decimal? SoldPrice { get; set; }
        public decimal TransferPrice { get; set; }
        public int Pos { get; set; }
        public int SeqNumber { get; set; }
        
            
        
     

    }
}
