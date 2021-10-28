using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IPackingListsService
    {
        IEnumerable<PackingListsJournalDTO> GetPackingJournal(DateTime beginDate, DateTime endDate);
        PackingListMaterialsDTO GetPackingListMaterialsById(int? packingListId);
        IEnumerable<PackingListsDTO> GetPackingLists();
        IEnumerable<PackingListDetailDTO> GetPackingListDetailId(int id);


        int PackingListCreate(PackingListsDTO pdto);
        void PackingListUpdate(PackingListsDTO pdto);
        bool PackingListDeleteById(int? id);

        int PackingListDetailsCreate(PackingListDetailDTO plddto);
        void PackingListDetailsUpdate(PackingListDetailDTO plddto);
        bool PackingListDetailsDeleteById(int? id);

        void PackingListMaterialsCreateRange(List<PackingListMaterialsDTO> source);
        int PackingListMaterialsCreate(PackingListMaterialsDTO pmdto);
        void PackingListMaterialsUpdate(PackingListMaterialsDTO pmdto);
        bool PackingListMaterialsDeleteById(int? id);
        
        void Dispose();
    }
}
