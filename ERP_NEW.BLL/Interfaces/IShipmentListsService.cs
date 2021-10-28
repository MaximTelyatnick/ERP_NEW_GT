using System.Collections.Generic;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;


namespace ERP_NEW.BLL.Interfaces
{
   public interface IShipmentListsService
    {
       IEnumerable<ShipmentListsDTO> GetShipmentLists(DateTime beginDate, DateTime endDate);
       int CreateShipmentList(ShipmentListsDTO dtomodel);
       void UpdateShipmentList(ShipmentListsDTO dtomodel);
       bool RemoveShipmentListById(long id);
       void Dispose();
    }
}
