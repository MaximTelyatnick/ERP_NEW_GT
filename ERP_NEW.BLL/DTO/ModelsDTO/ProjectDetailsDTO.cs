using System;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class ProjectDetailsDTO : ObjectBase
    {
        public int ProjectDetailId { get; set; }
        public int? CustomerOrderId { get; set; }
        public long? AssemblyId { get; set; }
        public string Drawing { get; set; }
        public string ContractorName { get; set; }
        public string AssemblyGeneralName { get; set; }
        public string AssemblyDrawing { get; set; }
        public string AssemblyName { get; set; }
        public DateTime? AssemblyDate { get; set; }
        
        //CustomerOrders
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        //ControlChecks
        public int? ControlCheckId { get; set; }
        public DateTime? ControlDate { get; set; }
        public string Description { get; set; }
        public int? ControlPersonId { get; set; }
        public string ControlPersonName { get; set; }
        public string MarkDocumentNumber { get; set; }
    }
}
