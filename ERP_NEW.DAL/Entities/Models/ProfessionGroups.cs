using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class ProfessionGroups
    {
        [Key]
        public int ProfessionGroupId { get; set; }
        public string Name { get; set; }
    }
}
