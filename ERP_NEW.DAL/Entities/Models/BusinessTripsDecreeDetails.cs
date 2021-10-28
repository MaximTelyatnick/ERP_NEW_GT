using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class BusinessTripsDecreeDetails
    {
        [Key]
        public int Id { get; set; }
        public int DecreeId { get; set; }
        public int BusinessTripDetailId { get; set; }
    }
}
