using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Interfaces
{
   public interface IProjectDetailsService
    {
       IEnumerable<ProjectDetailsDTO> GetProjectDetails();
       IEnumerable<ProjectDetailExecutorsDTO> GetProjectDetailExecutors(int id);
       IEnumerable<ControlChecksDTO> GetControlChecks();

       IEnumerable<ControlChecksDTO> GetControlChecksJournal();

       IEnumerable<PaintingWorksJournalDTO> GetPaintingWorks(DateTime beginDate, DateTime endDate);

       int ProjectDetailCreate(ProjectDetailsDTO projectDetail);
       void ProjectDetailUpdate(ProjectDetailsDTO projectDetail);
       bool ProjectDetailDelete(int id);

       int ControlCheckCreate(ControlChecksDTO projectDetail);
       void ControlCheckUpdate(ControlChecksDTO ccdto);
       bool ControlCheckDelete(int id);

       int PaintingWorksCreate(PaintingWorksDTO pWorks);
       void PaintingWorksUpdate(PaintingWorksDTO pWorks);
       bool PaintingWorksDelete(int id);

       void ProjectExecutorsUpdateRange(List<ProjectDetailExecutorsDTO> source);
       bool ProjectExecutorsDelete(int id);

       void Dispose();
    }
}
