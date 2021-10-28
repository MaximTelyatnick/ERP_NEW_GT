using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class WeldWps
    {
        [Key]
        public int Id { get; set; }
        public decimal WireDiameter { get; set; }
        public string SeamSizeZ { get; set; }
        public string SeamSizeA { get; set; }
        public string ConnectionType { get; set; }
        public string Wpqr { get; set; }
        public string Wps { get; set; }
        public string LayerMark { get; set; }
        public string MaterialThickness { get; set; }
        public string WeldPosition { get; set; }
    }
}
