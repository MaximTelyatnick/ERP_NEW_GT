using AutoMapper;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.DAL.Entities.Models;
using ERP_NEW.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Services
{
    public class BusinessCardService : IBusinessCardService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<BusinessCards> businessCard;
        private IRepository<BusinessCardsFactory> businessCardsFactory;
        private IRepository<BusinessCardPhotos> businessCardPhotos;
        private IRepository<City> city;
        private IRepository<Country> country;
        private IRepository<ProductCategories> productCategories;
        private IRepository<Users> users;

        private IMapper mapper;

        public BusinessCardService(IUnitOfWork uow)
        {
            Database = uow;

            businessCardsFactory = Database.GetRepository<BusinessCardsFactory>();
            businessCard = Database.GetRepository<BusinessCards>();
            businessCardPhotos = Database.GetRepository<BusinessCardPhotos>();
            city = Database.GetRepository<City>();
            users = Database.GetRepository<Users>();
            country = Database.GetRepository<Country>();
            productCategories = Database.GetRepository<ProductCategories>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BusinessCardsFactory, BusinessCardsFactoryDTO>();
                cfg.CreateMap<BusinessCardsFactoryDTO, BusinessCardsFactory>();
                cfg.CreateMap<BusinessCards, BusinessCardDTO>();
                cfg.CreateMap<BusinessCardDTO, BusinessCards>();
                cfg.CreateMap<BusinessCardPhotos, BusinessCardPhotosDTO>();
                cfg.CreateMap<BusinessCardPhotosDTO, BusinessCardPhotos>();
                cfg.CreateMap<City, CityDTO>();
                cfg.CreateMap<CityDTO, City>();
                cfg.CreateMap<ProductCategories, ProductCategoriesDTO>();
                cfg.CreateMap<ProductCategoriesDTO, ProductCategories>();
                cfg.CreateMap<Users, UsersDTO>();
                cfg.CreateMap<UsersDTO, Users>();
                cfg.CreateMap<CountryDTO, Country>();
                cfg.CreateMap<Country, CountryDTO>();
                cfg.CreateMap<CountryDTO, Country>();
                cfg.CreateMap<Country, CountryDTO>();
            });

            mapper = config.CreateMapper();
        }

        #region Get method's

        public IEnumerable<BusinessCardsFactoryDTO> GetBusinessCardFactory()
        {
            var result = (from bc in businessCardsFactory.GetAll()
                          join ct in city.GetAll() on bc.CityId equals ct.Id into ctp
                          from ct in ctp.DefaultIfEmpty()
                          join ctr in country.GetAll() on ct.Country_Id equals ctr.Country_Id into ctrp
                          from ctr in ctrp.DefaultIfEmpty()
                          join pc in productCategories.GetAll() on bc.ProductCategoriesId equals pc.Id into pcp
                          from pc in pcp.DefaultIfEmpty()
                          select new BusinessCardsFactoryDTO()
                          {
                              Id = bc.Id,
                              ProductCategoriesId = pc.Id,
                              CityId = ct.Id,
                              CategoryName = pc.CategoryName,
                              Name = bc.Name,
                              CityName = ct.CityName_UA,
                              CountryName = ctr.CountryName_UA
                          }).ToList();
            return result;
        }




        public IEnumerable<BusinessCardDTO> GetContractorNameByFactoryId(int id)
        {
            return mapper.Map<IEnumerable<BusinessCards>, List<BusinessCardDTO>>(businessCard.GetAll().Where(s => s.BusinessCardsFactoryId == id));
        }

        public IEnumerable <BusinessCardPhotosDTO> GetCardPhotoById(int id)
        {
            return mapper.Map<IEnumerable<BusinessCardPhotos>, List<BusinessCardPhotosDTO>>(businessCardPhotos.GetAll().Where(s => s.BusinessCardId == id ));
        }

        public IEnumerable<BusinessCardDTO> GetBusinessCard()
        {
            return mapper.Map<IEnumerable<BusinessCards>, List<BusinessCardDTO>>(businessCard.GetAll());
        }


        #endregion

        #region BusinessCardFactory CRUD method's

        public int BusinessCardFactoryCreate(BusinessCardsFactoryDTO businessCardsFactoryDTO)
        {
            var createBusinessCardFactory = businessCardsFactory.Create(mapper.Map<BusinessCardsFactory>(businessCardsFactoryDTO));
            return (int)createBusinessCardFactory.Id;
        }


        public void BusinessCardFactoryUpdate(BusinessCardsFactoryDTO businessCardFactoryDTO)
        {
            var updateBusinessCardFactory = businessCardsFactory.GetAll().SingleOrDefault(c => c.Id == businessCardFactoryDTO.Id);
            businessCardsFactory.Update((mapper.Map<BusinessCardsFactoryDTO, BusinessCardsFactory>(businessCardFactoryDTO, updateBusinessCardFactory)));
        }



        public bool BusinessCardFactoryDelete(int id)
        {
            try
            {
                businessCardsFactory.Delete(businessCardsFactory.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region BusinessCard CRUD method's

        public int BusinessCardCreate(BusinessCardDTO businessCardDTO)
        {
            var createBusinessCard = businessCard.Create(mapper.Map<BusinessCards>(businessCardDTO));
            return (int)createBusinessCard.Id;
        }


        public void BusinessCardUpdate(BusinessCardDTO businessCardDTO)
        {
            var updateBusinessCard = businessCard.GetAll().SingleOrDefault(c => c.Id == businessCardDTO.Id);
            businessCard.Update((mapper.Map<BusinessCardDTO, BusinessCards>(businessCardDTO, updateBusinessCard)));
        }



        public bool BusinessCardDelete(int id)
        {
            try
            {
                businessCard.Delete(businessCard.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        #endregion

        #region BusinessCardPhoto CRUD method's

        public void BusinessCardPhotoCreateRange(List<BusinessCardPhotosDTO> source)
        {
            businessCardPhotos.CreateRange(mapper.Map<List<BusinessCardPhotosDTO>, IEnumerable<BusinessCardPhotos>>(source));
        }

        public int BusinessCardPhotoCreate(BusinessCardPhotosDTO businessCardPhtosDTO)
        {
            var createBusinessCardPhoto = businessCardPhotos.Create(mapper.Map<BusinessCardPhotos>(businessCardPhtosDTO));
            return (int)createBusinessCardPhoto.Id;
        }

        public void BusinessCardPhotoUpdate(BusinessCardPhotosDTO businessCardPhotosDTO)
        {
            var updateBusinessCardPhotos = businessCardPhotos.GetAll().SingleOrDefault(c => c.Id == businessCardPhotosDTO.Id);
            businessCardPhotos.Update((mapper.Map<BusinessCardPhotosDTO, BusinessCardPhotos>(businessCardPhotosDTO, updateBusinessCardPhotos)));
        }

       

        public bool BusinessCardPhotosRemoveRange(List<BusinessCardPhotosDTO> source)
        {
            try
            {
                foreach (var item in source)
                {
                    var deleteModel = businessCardPhotos.GetAll().SingleOrDefault(p => p.Id == item.Id);
                    businessCardPhotos.Delete(deleteModel);
                }


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        public void Dispose()
        {
            Database.Dispose();
        }

    }
}
