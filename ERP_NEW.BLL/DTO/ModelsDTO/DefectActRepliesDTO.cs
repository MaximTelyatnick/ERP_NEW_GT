using System;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class DefectActRepliesDTO : ObjectBase
    {
        public int Id { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public int? DocumentTypeId { get; set; }
        public string Description { get; set; }
        public byte[] DocumentScan { get; set; }
        public string FileName { get; set; }
        public string Details { get; set; }
        public int? DefectActId { get; set; }

        public string DocumentTypeName { get; set; }
        public int ScanPersence { get; set; }
    }
}