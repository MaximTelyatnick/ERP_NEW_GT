using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IWeldStampsService
    {
        IEnumerable<WeldWpsDTO> GetWeldWps();
        IEnumerable<WeldStampsDTO> GetWeldStamps();
        IEnumerable<WeldAttestationPersonsInfoDTO> GetWeldAttestationWithPersons();
        IEnumerable<WeldAttestationTreeInfoDTO> GetWeldAttestationForTree();
        IEnumerable<WeldWpsDTO> GetWeldWpsByAttestationPersonId(int weldAttestationPersonId);
        IEnumerable<WeldAttestationsDTO> GetWeldAttestations();
        IEnumerable<WeldStampJournalInfoDTO> GetWeldStampJournalByPeriod(DateTime beginDate, DateTime endDate);
        IEnumerable<WeldStampJournalDTO> GetWeldStampJournals();
        IEnumerable<EmployeesForWeldDTO> GetEmployeesByWeldAttestations();
        List<EmployeeCertificatesDTO> GetEmployeesDocuments(int employeeId);
        WeldCertificatesDTO GetWeldCertificateById(int id);
        EmployeeCertificatesDTO GetEmployeesCertificateById(int id);

        int CreateWeldStampJournal(WeldStampJournalDTO dtomodel);
        void UpdateWeldStampJournal(WeldStampJournalDTO dtomodel);
        bool RemoveWeldStampJournalById(int id);

        int CreateWeldWps(WeldWpsDTO dtomodel);
        void UpdateWeldWps(WeldWpsDTO dtomodel);
        bool RemoveWeldWpsById(int id);

        int CreateWeldCertificate(WeldCertificatesDTO dtomodel);
        void UpdateWeldCertificate(WeldCertificatesDTO dtomodel);
        bool RemoveWeldCertificateById(int id);

        int CreateEmployeeCertificate(EmployeeCertificatesDTO dtomodel);
        void UpdateEmployeeCertificate(EmployeeCertificatesDTO dtomodel);
        bool RemoveEmployeeCertificateById(int id);

        int CreateWeldStamps(WeldStampsDTO dtomodel);
        void UpdateWeldStamps(WeldStampsDTO dtomodel);
        bool RemoveWeldStampsById(int id);

        int CreateWeldAttestations(WeldAttestationsDTO dtomodel);
        void UpdateWeldAttestations(WeldAttestationsDTO dtomodel);
        bool RemoveWeldAttestationsById(int id);

        int CreateWeldAttestationPersons(WeldAttestationPersonsDTO dtomodel);
        void CreateRangeWeldAttestationPersons(List<WeldAttestationPersonsDTO> source);
        void UpdateWeldAttestationPersons(WeldAttestationPersonsDTO dtomodel);
        bool RemoveRangeWeldAttestationsPersons(List<WeldAttestationPersonsDTO> source);
        
        void CreateRangeWeldPersonsWps(List<WeldPersonsWpsDTO> source);
        bool RemoveRangeWeldPersonsWps(List<WeldPersonsWpsDTO> source);

        void Dispose();
    }
}
