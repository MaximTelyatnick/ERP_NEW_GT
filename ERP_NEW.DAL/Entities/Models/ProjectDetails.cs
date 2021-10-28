using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class ProjectDetails
    {
        [Key]
        public int ProjectDetailId { get; set; }
        public long? AssemblyId { get; set; }
        public int? CustomerOrderId { get; set; }
        public string AssemblyDrawing { get; set; }
        public string AssemblyName { get; set; }
        public int? ControlCheckId { get; set; }
    }
}
