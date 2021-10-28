using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Interfaces
{
    public interface ICalcWithBuyersService
    {
        IEnumerable<CalcWithBuyersInfoDTO> GetCalcWithBuyersJournal(DateTime beginDate, DateTime endDate);
        IEnumerable<CalcWithBuyersSpecDTO> GetCalcWithBuyersSpec(int id);
        IEnumerable<CustomerOrdersForCWBDTO> GetCustomerOrdersByCWBId(int id);
        CalcWithBuyersPaymentVatDTO GetCalcWithBuyersPaymentVatById(int id);
        
        int CalcWithBuyerCreate(CalcWithBuyersDTO cwbDTO);
        void CalcWithBuyerUpdate(CalcWithBuyersDTO cwbDTO);
        bool CalcWithBuyerDelete(int id);

        int CalcWithBuyerSpecCreate(CalcWithBuyersSpecDTO cwbsDTO);
        void CalcWithBuyerSpecCreateRange(List<CalcWithBuyersSpecDTO> source);
        void CalcWithBuyerSpecUpdate(CalcWithBuyersSpecDTO cwbsDTO);
        bool CalcWithBuyerSpecRemoveRange(List<CalcWithBuyersSpecDTO> source);

        int CalcWithBuyersPaymentVatCreate(CalcWithBuyersPaymentVatDTO cwbpvDTO);
        void CalcWithBuyersPaymentVatUpdate(CalcWithBuyersPaymentVatDTO cwbpvDTO);
        bool CalcWithBuyersPaymentVatDelete(int id);

        int CustomerOrdersForCWBCreate(CustomerOrdersForCWBDTO cofDTO);
        bool CustomerOrdersForCWBDelete(int id);

        void Dispose();
    }
}
