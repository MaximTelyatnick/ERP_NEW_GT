using System.Collections.Generic;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;


namespace ERP_NEW.BLL.Interfaces
{
    public interface IEmployeesService
    {
        IEnumerable<EmployeesDTO> GetEmployees();
        IEnumerable<EmployeesDetailsDTO> GetEmployeesDetails();
        IEnumerable<EmployeesDetailsStandartDTO> GetEmployeesDetailsStandart();
        int GetLastEmployeesId();
        int GetLastEmployeesDetailsRecordId();
        int GetAccessScheduleEntityEntityId();
        int GetLastProfessionId();
        int GetLastDepartmentId();

        bool CheckEntityPhotos(int EntityID);

        IEnumerable<EmployeesInfoDTO> GetEmployeeHistory(decimal employeeNumber);
        IEnumerable<EmployeesInfoDTO> GetEmployeesWorking();
        IEnumerable<EmployeesInfoDTO> GetEmployeesNotWorking();
        IEnumerable<EmployeesInfoOnlyWithWeldStampDTO> GetEmployeesWorkingWithWeldStamp();
        IEnumerable<EmployeesInfoNonPhotoDTO> GetEmployeesWorkingNonPhoto();
        EmployeePhotoDTO GetPhotoById(int EmployeesId);
        IEnumerable<DepartmentsDTO> GetDepartments();
        IEnumerable<ProfessionsDTO> GetProfessions();
        IEnumerable<EmployeesInfoDTO> GetEmployeesWorkingByDeparmentId(int departmentId);
        IEnumerable<EmployeeVisitScheduleDTO> GetEmployeeVisitScheduleProc(int employeeId, DateTime startDate, DateTime endDate);
        //IEnumerable<EmployeesDetailsDTO> GetEmployesDetals();


        int EmployeesCreate(EmployeesDTO employeesDTO);
        void EmployeesUpdate(EmployeesDTO employeesDTO);
        bool EmployeesDelete(int id);


        int EmployeesDetailsCreate(EmployeesDetailsDTO employeesDetailsDTO);
        void EmployeesDetailsUpdate(EmployeesDetailsDTO employeesDetailsDTO);
        bool EmployeesDetailsDelete(int id);


        int EmployeesDetailsStandartCreate(EmployeesDetailsStandartDTO employeesDetailsStandartDTO);
        void EmployeesDetailsStandartUpdate(EmployeesDetailsStandartDTO employeesDetailsStandartDTO);
        bool EmployeesDetailsStandartDelete(int id);


        int EntityPhotosCreate(EntityPhotosDTO entityPhotosDTO);
        void EntityPhotosUpdate(EntityPhotosDTO employeePhotoDTO);
        bool EntityPhotosDelete(int id);


        int AccessScheduleEntityCreate(AccessScheduleEntityDTO accessScheduleEntityDTO);
        void AccessScheduleEntityUpdate(AccessScheduleEntityDTO accessScheduleEntityDTO);
        bool AccessScheduleEntityDelete(int id);


        int DepartmentsCreate(DepartmentsDTO departmentsDTO);
        void DepartmentUpdate(DepartmentsDTO departmentsDTO);
        bool DepartmentsDelete(int id);

        int ProfessionCreate(ProfessionsDTO professionsDTO);
        void ProfessionUpdate(ProfessionsDTO professionsDTO);
        bool ProfessionDelete(int id);




        void Dispose();
    }
}
