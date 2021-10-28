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
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;

namespace ERP_NEW.GUI.Classifiers
{
    public partial class DictionaryCpvFm : DevExpress.XtraEditors.XtraForm
    {
        private IAccountsService accountsService;

        private BindingSource dictionaryTreeBS = new BindingSource();

        private UserTasksDTO _userTasksDTO;

        public DictionaryCpvFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            _userTasksDTO = userTasksDTO;

            accountsService = Program.kernel.Get<IAccountsService>();

            dictionaryTreeBS.DataSource = accountsService.GetDictionaryCPV();
            dictionaryTree.DataSource = dictionaryTreeBS;
            dictionaryTree.KeyFieldName = "Id";
            dictionaryTree.ParentFieldName = "ParentId";
            dictionaryTree.ExpandAll();
        }
    }
}