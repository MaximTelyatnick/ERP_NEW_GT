using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class WeldPersonsWps
    {
        [Key]
        public int Id { get; set; }
        public int WeldAttestationPersonId { get; set; }
        public int WeldWpsId { get; set; }
    }
}
