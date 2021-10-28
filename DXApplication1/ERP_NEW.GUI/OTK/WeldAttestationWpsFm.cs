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

namespace ERP_NEW.GUI.OTK
{
    public partial class WeldAttestationWpsFm : DevExpress.XtraEditors.XtraForm
    {
        private IWeldStampsService weldStampsService;

        private BindingSource wpsBS = new BindingSource();

        private List<WeldWpsDTO> _sourceList = new List<WeldWpsDTO>();
        private int _attestationId;

        public WeldAttestationWpsFm(List<WeldWpsDTO> sourceList, int attestationId)
        {
            InitializeComponent();

            _attestationId = attestationId;
            _sourceList = sourceList;

            wpsBS.DataSource = _sourceList;
            weldWpsGrid.DataSource = wpsBS;
        }

        private bool SaveWpsByAttestation()
        {
            try
            {
                if (_sourceList.Any(s => s.CheckForDelete))
                {
                    weldStampsService = Program.kernel.Get<IWeldStampsService>();

                    var saveList = _sourceList.Where(s => s.CheckForDelete).Select(w => new WeldPersonsWpsDTO() { WeldAttestationPersonId = _attestationId, WeldWpsId = w.Id }).ToList();
                    weldStampsService.CreateRangeWeldPersonsWps(saveList);

                    return true;
                }
                else
                {
                    MessageBox.Show("Не відмічено жодного запису!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
 
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveWpsByAttestation())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    return;
                }
            }
        }
    }
}