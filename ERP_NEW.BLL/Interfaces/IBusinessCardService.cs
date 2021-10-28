using ERP_NEW.BLL.DTO.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IBusinessCardService
    {
        IEnumerable<BusinessCardsFactoryDTO> GetBusinessCardFactory();

        IEnumerable<BusinessCardDTO> GetContractorNameByFactoryId(int id);

        IEnumerable<BusinessCardPhotosDTO> GetCardPhotoById(int id);

        IEnumerable<BusinessCardDTO> GetBusinessCard();


        int BusinessCardFactoryCreate(BusinessCardsFactoryDTO businessCardsFactoryDTO);
        void BusinessCardFactoryUpdate(BusinessCardsFactoryDTO businessCardFactoryDTO);
        bool BusinessCardFactoryDelete(int id);

        int BusinessCardCreate(BusinessCardDTO businessCardDTO);
        void BusinessCardUpdate(BusinessCardDTO businessCardDTO);
        bool BusinessCardDelete(int id);

        void BusinessCardPhotoCreateRange(List<BusinessCardPhotosDTO> source);
        int BusinessCardPhotoCreate(BusinessCardPhotosDTO businessCardPhtosDTO);
        void BusinessCardPhotoUpdate(BusinessCardPhotosDTO businessCardPhotosDTO);
        bool BusinessCardPhotosRemoveRange(List<BusinessCardPhotosDTO> source);



        void Dispose();
    }
}
