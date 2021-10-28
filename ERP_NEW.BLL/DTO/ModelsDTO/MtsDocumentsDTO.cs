using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class MtsDocumentsDTO
    {
        public int Id { get; set; }
        public long MtsSpecificationId { get; set; }
        public char[] DocumentScan { get; set; }
        public string FileName { get; set; }
    }
}
