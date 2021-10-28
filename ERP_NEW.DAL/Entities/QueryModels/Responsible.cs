using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class Responsible
    {
        [Key]
        public int EMPLOYEEID { get; set; }
        public string EMPLOYEE_NUMBER { get; set; }
        public string LASTNAME { get; set; }
        public string FIRSTNAME { get; set; }
        public string MIDDLENAME { get; set; }
        public string FIO { get; set; }
        public string FULLNAME { get; set; }
        public string PROFFESION { get; set; }
        public string STARTDATE { get; set; }
        public string ENDDATE { get; set; }
   
    }
}
