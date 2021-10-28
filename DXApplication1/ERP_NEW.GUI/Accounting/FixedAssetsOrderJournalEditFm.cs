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
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Services;
using ERP_NEW.BLL.DTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraEditors.Controls;
using Ninject;
using System.Web;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL;

namespace ERP_NEW.GUI.Accounting
{
    public partial class FixedAssetsOrderJournalEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IFixedAssetsOrderService fixedAssetsOrderService;
        private BindingSource fixedAssetsOrderRegBS = new BindingSource();

        private ObjectBase Item
        {
            get { return fixedAssetsOrderRegBS.Current as ObjectBase; }
            set
            {
                fixedAssetsOrderRegBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public FixedAssetsOrderJournalEditFm(FixedAssetsOrderRegistrationDTO model)
        {
            InitializeComponent();
            fixedAssetsOrderRegBS.DataSource = Item = model;
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            
            numberOrderEdit.EditValue = model.NumberOrder;
            dateEdit.EditValue = model.DateOrder;

        }

        public FixedAssetsOrderRegistrationDTO ReturnInt()
        {
            return ((FixedAssetsOrderRegistrationDTO)Item);
        }

        private bool Save()
        {
            this.Item.EndEdit();

            FixedAssetsOrderRegistrationDTO updateModel = new FixedAssetsOrderRegistrationDTO()
            {
                Id = ((FixedAssetsOrderRegistrationDTO)Item).Id,
                NumberOrder = numberOrderEdit.Text,
                FixedAssetsOrderId = ((FixedAssetsOrderRegistrationDTO)Item).FixedAssetsOrderId,
                DateOrder = (DateTime)dateEdit.EditValue,
                StatusTypeOrder = ((FixedAssetsOrderRegistrationDTO)Item).StatusTypeOrder,
                TypeOrder = ((FixedAssetsOrderRegistrationDTO)Item).TypeOrder
            };
            fixedAssetsOrderService.FixedAssetsOrderRegistrationUpdate(updateModel);
            return true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (Save())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        // MessageBox.Show("Не вірний номер податкової.Такий номер вже існує.", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //numberAccountingEdit.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}