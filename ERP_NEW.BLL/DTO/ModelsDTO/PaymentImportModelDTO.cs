using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class PaymentImportModelDTO
    {
        public string DocumentNum; //1
        public ulong PayerBankAccountNum; //2
        public int PaymentCurrencyCode; //3 ushort
        public uint PayerBankCode; //4 
        public uint RecipientBankCode; //5 
        public ulong RecipientBankAccountNum; //6
        public byte OperationType; //7
        public DateTime BankApplyDate; //8
        public string PaymentCurrencyName; //9
        public string DocumentTypeName; //10
        public string PaymentPurpose; //11
        public DateTime DocumentApplyDate; //12
        public string RecipientBankName; //13
        public string RecipientSrn; //14
        public string RecipientName; //15
        public string PayerBankName; //16
        public string PayerSrn; //17
        public string PayerFullName; //18
        public string PayerName; //19
        public int PayerInnerCode; //20
        public DateTime PaymentTime; //21
        public int DocumentTypeId; //22 
        public uint RecordVersion; //23
        public decimal SumEq; //24
        public decimal Sum; //25

        public decimal Rate; //26
    }
}
