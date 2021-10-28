using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class FixedAssetsOrderArchiveJournal
    {
        [Key]
        public int Id { get; set; }
        public int? Id_Parent { get; set; }
        public string InventoryNumber { get; set; }
        public string InventoryName { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime BeginRecordDate { get; set; }
        public DateTime? EndRecordDate { get; set; }
        public int Balance_Account_Id { get; set; }
        public int? UsefulMonth { get; set; }
        public int? Region_Id { get; set; }
        public int? FixedCardStatus { get; set; }
        public string RegionName { get; set; }
        public string BalanceAccountNum { get; set; }
        public int? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Fio { get; set; }
        public int? OperatingPersonId { get; set; }
        public string OperatingPersonName { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public decimal? SoldPrice { get; set; }
        public decimal? TransferPrice { get; set; }
        public int? OperationStatus { get; set; }
        public string OperationName { get; set; }
        public string SelectedCard { get; set; }
        public string NameGenitive { get; set; }


    }
}
