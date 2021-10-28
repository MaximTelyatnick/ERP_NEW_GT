using ERP_NEW.BLL.Infrastructure;
using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class WeldWpsDTO : ObjectBase
    {
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

        public bool CheckForDelete { get; set; }
        public Utils.ConnectionType EnumConnectionType { get; set; }
        public Utils.WeldPosition EnumWeldPosition { get; set; }
        public int WeldPersonWpsId { get; set; }
    }
}
