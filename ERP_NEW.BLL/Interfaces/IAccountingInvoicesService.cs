using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IAccountingInvoicesService
    {
        IEnumerable<InvoicesDTO> GetInvoicesInfo(DateTime startDate, DateTime endDate);
        IEnumerable<InvoicesDTO> GetInvoices(DateTime startDate, DateTime endDate);
        IEnumerable<Balance_AccountDTO> GetBalaneAccount();
        IEnumerable<RegistriesDTO> GetRegistriesName();
        IEnumerable<Invoices_NotesDTO> GetInvNoteName();
        IEnumerable<ContractorsDTO> GetContractorName();
        InvoicesDTO GetInvoicesById(int id);
        bool CheckInvoicesNum(InvoicesDTO invoicesDTO);
        int AccountsInvoiceCreate(InvoicesDTO invoicesDTO);
        void AccountsInvoiceUpdate(InvoicesDTO invoicesDTO);
        bool AccountsInvoiceDelete(int id);
        void Dispose();
    }
}
