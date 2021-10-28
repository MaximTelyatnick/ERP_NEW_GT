using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class FixedAssetsOrder
    {
        [Key]
        public int Id { get; set; }
        public int Id_Parent { get; set; }
        public string InventoryNumber { get; set; }
        public string InventoryName { get; set; }
        public int Balance_Account_Id { get; set; }//
        public int? Supplier_Id { get; set; }
        public DateTime BeginDate { get; set; }//
        public DateTime BeginRecordDate { get; set; }//
        public DateTime? EndRecordDate { get; set; }
        public int Group_Id { get; set; }//
        public int UsefulMonth { get; set; }
        public int? Region_Id { get; set; }
        public int? OperatingPerson_Id { get; set; }
        public int? FixedCardStatus { get; set; }

    }
}
