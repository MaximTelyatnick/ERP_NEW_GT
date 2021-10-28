using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Services;
using ERP_NEW.BLL.DTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;

namespace ERP_NEW.GUI.MTS
{
    public partial class MtsSpecificationOldEditFm : DevExpress.XtraEditors.XtraForm
    {
        private Utils.Operation operation;
        private IMtsSpecificationsService mtsService;
        private BindingSource specificationBS = new BindingSource();
        public UserTasksDTO userTaskDTO = new UserTasksDTO();

        public MtsSpecificationOldEditFm(Utils.Operation operation, MTSSpecificationsDTO model, UserTasksDTO userTaskDTO)
        {
            InitializeComponent();
            this.operation = operation;
            specificationBS.DataSource = Item = model;
            this.userTaskDTO = userTaskDTO;

            nameSpecificationEdit.DataBindings.Add("EditValue", specificationBS, "NAME", true, DataSourceUpdateMode.OnPropertyChanged);
            drawingEdit.DataBindings.Add("EditValue", specificationBS, "DRAWING", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityEdit.DataBindings.Add("EditValue", specificationBS, "QUANTITY", true, DataSourceUpdateMode.OnPropertyChanged);
            weightEdit.DataBindings.Add("EditValue", specificationBS, "WEIGHT", true, DataSourceUpdateMode.OnPropertyChanged);
            dateEdit.DataBindings.Add("EditValue", specificationBS, "CREATION_DATE", true, DataSourceUpdateMode.OnPropertyChanged);
      
        }
        #region Method's
         private ObjectBase Item
        {
            get { return specificationBS.Current as ObjectBase; }
            set
            {
                specificationBS.DataSource = value;
                value.BeginEdit();
            }
        }

        private bool SaveItem()
         {
             this.Item.EndEdit();
             mtsService = Program.kernel.Get<IMtsSpecificationsService>();
             switch (this.userTaskDTO.UserId)
             {
                 case 1: ((MTSSpecificationsDTO)Item).AUTHORIZATION_USERS_NAME = "Калайда Н.Б.";
                     ((MTSSpecificationsDTO)Item).AUTHORIZATION_USERS_ID = 1;
                     break;
                 case 4: ((MTSSpecificationsDTO)Item).AUTHORIZATION_USERS_NAME = "Петрова Л.Г.";
                     ((MTSSpecificationsDTO)Item).AUTHORIZATION_USERS_ID = 4;
                     break;
                 case 52: ((MTSSpecificationsDTO)Item).AUTHORIZATION_USERS_NAME = "Литвиненко Є.С.";
                     ((MTSSpecificationsDTO)Item).AUTHORIZATION_USERS_ID = 105;
                     break;
             }
             if (quantityEdit.Text.Length <= 5)
             {
                 if (weightEdit.Text.Length <= 7)
                 {
                     if (operation == Utils.Operation.Add)
                     {
                         ((MTSSpecificationsDTO)Item).CREATION_DATE = (DateTime)dateEdit.EditValue;
                         ((MTSSpecificationsDTO)Item).NAME = nameSpecificationEdit.Text;
                         ((MTSSpecificationsDTO)Item).DRAWING = drawingEdit.Text;
                         ((MTSSpecificationsDTO)Item).WEIGHT = (decimal)weightEdit.EditValue;
                         ((MTSSpecificationsDTO)Item).QUANTITY = (int)quantityEdit.EditValue;
                         ((MTSSpecificationsDTO)Item).ID = mtsService.MTSSpecificationCreate((MTSSpecificationsDTO)Item);
                         ((MTSSpecificationsDTO)Item).COMPILATION_NAMES = "";
                         ((MTSSpecificationsDTO)Item).COMPILATION_DRAWINGS = "";
                         ((MTSSpecificationsDTO)Item).COMPILATION_QUANTITIES = "";
                         ((MTSSpecificationsDTO)Item).SET_COLOR = 0;
                         
                     }
                     else
                         mtsService.MTSSpecificationUpdate((MTSSpecificationsDTO)Item);
             return true;           
             }
            else
            {
                MessageBox.Show("Перевище максимальна довжина поля 'Вага!'", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            }
            else
            {
                MessageBox.Show("Перевище максимальна довжина поля 'Кількість!'", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public MTSSpecificationsDTO Return()
        {
            return ((MTSSpecificationsDTO)Item);
        }
        #endregion

        #region Event's
        
        
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveItem())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                { MessageBox.Show("" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
    }
}