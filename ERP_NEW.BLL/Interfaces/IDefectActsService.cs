using System.Collections.Generic;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;

namespace ERP_NEW.BLL.Interfaces
{
   public interface IDefectActsService
    {
       IEnumerable<DefectActsDTO> GetDefectActs(DateTime beginDate, DateTime endDate);
       IEnumerable<DefectActRepliesDTO> GetDefectActReplies(int id);
       
       int CreateDefectAct(DefectActsDTO dtomodel);
       void UpdateDefectAct(DefectActsDTO dtomodel);
       bool RemoveDefectActById(long id);
       
       int CreateDefectActReplie(DefectActRepliesDTO dtomodel);
       void UpdateDefectActReplie(DefectActRepliesDTO dtomodel);
       bool RemoveDefectActReplieById(long id);
       
       void Dispose();
    }
}
