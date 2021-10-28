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
using ERP_NEW.BLL.DTO.ModelsDTO;

namespace ERP_NEW.GUI.GodMode.Parser
{
    public partial class ExpenditureParseFm : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource expenditureBS = new BindingSource();

        public ExpenditureParseFm(List<ExpedinturesAccountantDTO> expenditureAccountantList)
        {
            InitializeComponent();

            expenditureBS.DataSource = expenditureAccountantList;
            expenditureGrid.DataSource = expenditureBS;
        }
    }
}