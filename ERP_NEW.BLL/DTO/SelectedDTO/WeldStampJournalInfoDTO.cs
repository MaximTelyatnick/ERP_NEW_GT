using System;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class WeldStampJournalInfoDTO
    {
        public int Id { get; set; }
        public int WeldStampId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string EmployeesFio { get; set; }
        public int AccountNumber { get; set; }
        public string ProfessionName { get; set; }
        public string StampNumber { get; set; }
        public DateTime? StampDate { get; set; }
    }
}
