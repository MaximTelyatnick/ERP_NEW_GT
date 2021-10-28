using System;
using ERP_NEW.BLL.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class DefectActsDTO : ObjectBase
    {
        public int Id { get; set; }
        public int MtsAssemblyId { get; set; }
        public int? CustomerOrderId { get; set; }
        public string ActNumber { get; set; } 
        public DateTime ActDate { get; set; }
        public string Description { get; set; }
        public byte[] ActScan { get; set; }
        public string FileName { get; set; }
        public string Details { get; set; }
                        
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string AssemblyDrawing { get; set; }
        public string AssemblyName { get; set; }

        public int ScanPersence { get; set; } 
        
    }
}
