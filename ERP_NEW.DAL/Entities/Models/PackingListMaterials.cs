using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class PackingListMaterials
    {
        [Key]
        public int Id { get; set; }
        //public int PackingListId { get; set; }
        public byte[] Scan { get; set; }
        public string FileName { get; set; }
    }
}
