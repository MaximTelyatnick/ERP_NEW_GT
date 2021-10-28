using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class InputFixedAssetsForQuarterDTO
    {
        public int RecId { get; set; }
        public int BalanceAccountId { get; set; }
        public string BalanceAccountNum { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public decimal FirstQuarterSum { get; set; }
        public decimal FirstQuarterSumSold { get; set; }
        public decimal SecondQuarterSum { get; set; }
        public decimal SecondQuarterSumSold { get; set; }
        public decimal ThirdQuarterSum { get; set; }
        public decimal ThirdQuarterSumSold { get; set; }
        public decimal FourthQuarterSum { get; set; }
        public decimal FourthQuarterSumSold { get; set; }
    }
}
