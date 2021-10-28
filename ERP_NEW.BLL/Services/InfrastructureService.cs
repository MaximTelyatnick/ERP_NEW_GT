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
using System.Windows.Forms;

namespace ERP_NEW.BLL.Services
{
    class InfrastructureService : IInfrastructureService
    {
        private IUnitOfWork Database { get; set; }

        private IRepository<Colors> colors;

        private IMapper mapper;

        public InfrastructureService(IUnitOfWork uow)
        {
            Database = uow;
            colors = Database.GetRepository<Colors>();

                                    
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Colors, ColorsDTO>();
                cfg.CreateMap<ColorsDTO, Colors>(); 
            });

            mapper = config.CreateMapper();

        }

        public IEnumerable<ColorsDTO> GetColorsAll()
        {
            return mapper.Map<IEnumerable<Colors>, List<ColorsDTO>>(colors.GetAll());
        }

        #region Colors CRUD method's

        public int ColorsCreate(ColorsDTO colorsDTO)
        {
            var createColors = colors.Create(mapper.Map<Colors>(colorsDTO));
            return (int)createColors.Id;
        }

        public void ColorsUpdate(ColorsDTO colorsDTO)
        {
            var updateColors = colors.GetAll().SingleOrDefault(c => c.Id == colorsDTO.Id);
            colors.Update((mapper.Map<ColorsDTO, Colors>(colorsDTO, updateColors)));
        }

        public bool ColorsDelete(int id)
        {
            try
            {
                colors.Delete(colors.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK);
                return false;
            }
        }

        #endregion

    }
}
