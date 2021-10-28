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
using Ninject;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.XtraBars;
using ERP_NEW.BLL.Infrastructure;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;

namespace ERP_NEW.GUI.OTK
{
    public partial class WeldAttestationFm : DevExpress.XtraEditors.XtraForm
    {
        private IWeldStampsService weldStampsService;

        private BindingSource weldTreeBS = new BindingSource();
        private BindingSource weldAttestationsBS = new BindingSource();
        private BindingSource weldWpsBS = new BindingSource();
        private BindingSource weldDocumentsBS = new BindingSource();

        private List<WeldAttestationTreeInfoDTO> weldAttestationList = new List<WeldAttestationTreeInfoDTO>();
        private List<WeldAttestationPersonsInfoDTO> weldPersonsByNodeList = new List<WeldAttestationPersonsInfoDTO>();
        private List<WeldAttestationPersonsInfoDTO> weldAttestationPersonsList = new List<WeldAttestationPersonsInfoDTO>();
        private List<EmployeeCertificatesDTO> weldDocumentList = new List<EmployeeCertificatesDTO>();
        private List<WeldWpsDTO> weldWpsList = new List<WeldWpsDTO>();

        private UserTasksDTO _userTasksDTO;

        public WeldAttestationFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            _userTasksDTO = userTasksDTO;

            AuthorizatedUserAccess();
            
            splashScreenManager.ShowWaitForm();

            LoadAttestationData();

            splashScreenManager.CloseWaitForm();
        }

        #region Method's

        private void AuthorizatedUserAccess()
        {
            addBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            addParentBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            addWeldCertificateBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteWeldCertificateBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            addWpsBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteWpsBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            addEmpCertificateBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteEmpCertificateBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
        }

        private void LoadAttestationData()
        {
            weldStampsService = Program.kernel.Get<IWeldStampsService>();
            weldAttestationList = weldStampsService.GetWeldAttestationForTree().ToList();
            weldAttestationPersonsList = weldStampsService.GetWeldAttestationWithPersons().ToList();

            weldTreeBS.DataSource = weldAttestationList;
            attestationTree.DataSource = weldTreeBS;
            attestationTree.KeyFieldName = "Id";
            attestationTree.ParentFieldName = "ParentId";
            attestationTree.ExpandAll();
        }

        private void LoadPersonsData(int attestationId)
        {
            stampAttestationGridView.BeginDataUpdate();
            
            weldPersonsByNodeList = weldAttestationPersonsList.Where(w => w.Id == attestationId).ToList();
            weldAttestationsBS.DataSource = weldPersonsByNodeList;
            stampAttestationGrid.DataSource = weldAttestationsBS;
            
            stampAttestationGridView.EndDataUpdate();
        }

        private void LoadWpsData(int weldAttestationPersonId)
        {
            weldStampsService = Program.kernel.Get<IWeldStampsService>();
            weldWpsList = weldStampsService.GetWeldWpsByAttestationPersonId(weldAttestationPersonId).ToList();
            weldWpsBS.DataSource = weldWpsList;
            weldWpsGrid.DataSource = weldWpsBS;
        }

        private void LoadDocumentsData(int employeeId)
        {
            weldStampsService = Program.kernel.Get<IWeldStampsService>();
            weldDocumentList = weldStampsService.GetEmployeesDocuments(employeeId).ToList();
            weldDocumentsBS.DataSource = weldDocumentList;
            weldDocumentsGrid.DataSource = weldDocumentsBS;
        }

        private void EditWeldStamps(Utils.Operation operation, WeldAttestationsDTO model, List<WeldAttestationPersonsInfoDTO> personsList)
        {
            using (WeldAttestationEditFm weldAttestationEditFm = new WeldAttestationEditFm(operation, model, personsList))
            {
                if (weldAttestationEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int return_Id = weldAttestationEditFm.Return();
                    attestationTree.BeginUpdate();

                    LoadAttestationData();

                    attestationTree.EndUpdate();

                    attestationTree.SetFocusedNode(attestationTree.FindNodeByKeyID(return_Id));
                }
            }
        }

        private void EditEmployeeCertificate(Utils.Operation operation, EmployeeCertificatesDTO model)
        {
            using (EmployeeCertificateEditFm employeeCertificateEditFm = new EmployeeCertificateEditFm(operation, model))
            {
               
                if (employeeCertificateEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int currEmpId = ((WeldAttestationPersonsInfoDTO)weldAttestationsBS.Current).AttestationPersonId;
                    stampAttestationGridView.BeginDataUpdate();

                    LoadAttestationData();

                    stampAttestationGridView.EndUpdate();

                    int handle = stampAttestationGridView.LocateByValue("AttestationPersonId", currEmpId);
                    stampAttestationGridView.FocusedRowHandle = handle;
                }
            }
        }

        private void EditWeldCertificate(Utils.Operation operation, WeldCertificatesDTO model)
        {
            using (WeldCertificateEditFm weldCertificateEditFm = new WeldCertificateEditFm(operation, model))
            {
                if (weldCertificateEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int currWeldId = ((WeldAttestationTreeInfoDTO)weldTreeBS.Current).Id;
                    attestationTree.BeginUpdate();

                    LoadAttestationData();

                    attestationTree.EndUpdate();

                    attestationTree.SetFocusedNode(attestationTree.FindNodeByKeyID(currWeldId));
                }
            }
        }

        #endregion

        #region Event's
                
        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditWeldStamps(Utils.Operation.Add, new WeldAttestationsDTO() , new List<WeldAttestationPersonsInfoDTO>());
        }

        private void addParentBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditWeldStamps(Utils.Operation.Add, new WeldAttestationsDTO() {ParentId = ((WeldAttestationTreeInfoDTO)weldTreeBS.Current).Id}, new List<WeldAttestationPersonsInfoDTO>());
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (weldAttestationsBS.Count > 0)
            {
                var currRecord = (WeldAttestationPersonsInfoDTO)weldAttestationsBS.Current;

                var model = new WeldAttestationsDTO()
                {
                    Id = currRecord.Id,
                    AttestationNumber = currRecord.AttestationNumber,
                    AttestationDate = currRecord.AttestationDate,
                    ResponsiblePersonId = currRecord.ResponsiblePersonId,
                    BeginDate = currRecord.BeginDate,
                    EndDate = currRecord.EndDate,
                    DateAdded = currRecord.DateAdded,
                    UserId = currRecord.UserId,
                    Description = currRecord.Description
                };

                var personsList = weldAttestationPersonsList.Where(a => a.Id == currRecord.Id).ToList();

                EditWeldStamps(Utils.Operation.Update, model, personsList);
            }

        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (weldAttestationsBS.Count > 0)
            {
                if (MessageBox.Show("Видалити атестаційний протокол?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    weldStampsService = Program.kernel.Get<IWeldStampsService>();

                    attestationTree.BeginUpdate();

                    if (weldStampsService.RemoveWeldAttestationsById(((WeldAttestationTreeInfoDTO)weldTreeBS.Current).Id));
                        LoadAttestationData();

                    attestationTree.EndUpdate();
                }
            }
        }

        private void refreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager.ShowWaitForm();
            stampAttestationGridView.BeginDataUpdate();
            LoadAttestationData();
            stampAttestationGridView.EndDataUpdate();
            splashScreenManager.CloseWaitForm();
        }

        private void stampAttestationGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (weldAttestationsBS.Count > 0)
            {
                LoadWpsData(((WeldAttestationPersonsInfoDTO)weldAttestationsBS.Current).AttestationPersonId);
                LoadDocumentsData(((WeldAttestationPersonsInfoDTO)weldAttestationsBS.Current).EmployeesID);
            }
        }

        private void addWpsBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (weldAttestationsBS.Count > 0)
            {
                weldStampsService = Program.kernel.Get<IWeldStampsService>();
                var allWpsList = weldStampsService.GetWeldWps();

                var currWpsList = allWpsList.Where(w => !weldWpsList.Any(l => l.Id == w.Id)).ToList();

                using (WeldAttestationWpsFm weldAttestationWpsFm = new WeldAttestationWpsFm(currWpsList, ((WeldAttestationPersonsInfoDTO)weldAttestationsBS.Current).AttestationPersonId))
                {
                    if (weldAttestationWpsFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        weldWpsGridView.BeginDataUpdate();

                        LoadWpsData(((WeldAttestationPersonsInfoDTO)weldAttestationsBS.Current).AttestationPersonId);

                        weldWpsGridView.EndDataUpdate();
                    }
                }
            }
        }

        private void deleteWpsBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            weldWpsGridView.CloseEditor();

            if (weldWpsList.Any(w => w.CheckForDelete))
            {
                if (MessageBox.Show("Видалити інформацію по WPS?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    weldStampsService = Program.kernel.Get<IWeldStampsService>();

                    weldWpsGridView.BeginDataUpdate();
                    
                    var deleteSource = weldWpsList
                        .Where(w => w.CheckForDelete)
                        .Select(s => new WeldPersonsWpsDTO(){ 
                            Id = s.WeldPersonWpsId, 
                            WeldWpsId = s.Id, 
                            WeldAttestationPersonId = ((WeldAttestationPersonsInfoDTO)weldAttestationsBS.Current).AttestationPersonId
                        })
                        .ToList();

                    if (weldStampsService.RemoveRangeWeldPersonsWps(deleteSource))
                        LoadWpsData(((WeldAttestationPersonsInfoDTO)weldAttestationsBS.Current).AttestationPersonId);

                    weldWpsGridView.EndDataUpdate();
                }
            }
        }

        private void addWeldCertificateBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (((WeldAttestationTreeInfoDTO)weldTreeBS.Current).WeldCertificateId == 0)
            {
                EditWeldCertificate(Utils.Operation.Add, new WeldCertificatesDTO() { WeldAttestationId = ((WeldAttestationTreeInfoDTO)weldTreeBS.Current).Id });
            }
            else
            {
                weldStampsService = Program.kernel.Get<IWeldStampsService>();
                EditWeldCertificate(Utils.Operation.Update, weldStampsService.GetWeldCertificateById(((WeldAttestationTreeInfoDTO)weldTreeBS.Current).WeldCertificateId));
            }
        }

        private void deleteWeldCertificateBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (((WeldAttestationTreeInfoDTO)weldTreeBS.Current).WeldCertificateId > 0)
            {
                if (MessageBox.Show("Видалити файл протоколу?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    weldStampsService = Program.kernel.Get<IWeldStampsService>();

                    attestationTree.BeginUpdate();

                    if (weldStampsService.RemoveWeldCertificateById(((WeldAttestationTreeInfoDTO)weldTreeBS.Current).WeldCertificateId))
                    {
                        ((WeldAttestationTreeInfoDTO)weldTreeBS.Current).WeldCertificateId = 0;
                        weldTreeBS.EndEdit();
                    }
                    
                    attestationTree.EndUpdate();
                }
            }
        }

        private void addEmpCertificateBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            
           EditEmployeeCertificate(Utils.Operation.Add, new EmployeeCertificatesDTO() { EmployeeId = ((WeldAttestationPersonsInfoDTO)weldAttestationsBS.Current).EmployeesID });
          
        }

        private void editEmpCertificateBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditEmployeeCertificate(Utils.Operation.Update, ((EmployeeCertificatesDTO)weldDocumentsBS.Current));
        }

        private void deleteEmpCertificateBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (((EmployeeCertificatesDTO)weldDocumentsBS.Current).Id > 0)
            {
                if (MessageBox.Show("Видалити документ?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    weldWpsGridView.BeginDataUpdate();

                    if (weldStampsService.RemoveEmployeeCertificateById(((EmployeeCertificatesDTO)weldDocumentsBS.Current).Id))
                    {
                        ((WeldAttestationPersonsInfoDTO)weldAttestationsBS.Current).EmployeeCertificateEntry = 0;
                        weldAttestationsBS.EndEdit();

                        LoadDocumentsData(((WeldAttestationPersonsInfoDTO)weldAttestationsBS.Current).EmployeesID);
                    }

                    weldWpsGridView.EndDataUpdate();
                }
            }
        }

        private void attestationTree_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            addParentBtn.Enabled = (attestationTree.FocusedNode.Level == 0 && _userTasksDTO.AccessRightId == 2);

            LoadPersonsData((int)attestationTree.FocusedNode[attestationTree.KeyFieldName]);
            LoadWpsData(((WeldAttestationPersonsInfoDTO)weldAttestationsBS.Current).AttestationPersonId);
            LoadDocumentsData(((WeldAttestationPersonsInfoDTO)weldAttestationsBS.Current).EmployeesID);
        }
                
        private void stampAttestationGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            WeldAttestationPersonsInfoDTO item = (WeldAttestationPersonsInfoDTO)weldAttestationsBS[e.ListSourceRowIndex];

            if (e.Column == stampStatusCol && e.IsGetData)
            {
                if(item.StampNumber != null)
                    e.Value = imageCollection.Images[2];
            }

            if (e.Column == empCertificateCol)
            {
                if (item.EmployeeCertificateEntry == 1)
                {
                    e.Value = imageCollection.Images[3];
                }
            }
        }

        private void attestationTree_CustomNodeCellEdit(object sender, DevExpress.XtraTreeList.GetCustomNodeCellEditEventArgs e)
        {
            if (weldTreeBS.Count > 0)
            {
                if (e.Column == weldCertificateCol && e.Node.Level >= 0)
                {   
                    var rowData = (WeldAttestationTreeInfoDTO)attestationTree.GetDataRecordByNode(e.Node);
                    bool status = (rowData != null && rowData.WeldCertificateId == 0);

                    if (status)
                    {
                        RepositoryItemButtonEdit ritem = new RepositoryItemButtonEdit();
                        ritem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
                        ritem.ReadOnly = true;
                        ritem.Buttons[0].Enabled = false;
                        e.RepositoryItem = ritem;
                    }
                }
            }
        }

         
        private void showWeldCertificateRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            weldStampsService = Program.kernel.Get<IWeldStampsService>();

            var model = weldStampsService.GetWeldCertificateById(((WeldAttestationTreeInfoDTO)weldTreeBS.Current).WeldCertificateId);

            if (model.CertificateScan != null)
            {
                string fileName = model.FileName;
                byte[] scan = model.CertificateScan;
                string puth = Utils.HomePath + @"\Temp\";

                System.IO.File.WriteAllBytes(puth + fileName, scan);

                System.Diagnostics.Process.Start(puth + fileName);
            }
        }

        private void attestationTree_DoubleClick(object sender, EventArgs e)
        {
            if (weldAttestationsBS.Count > 0)
            {
                var currRecord = (WeldAttestationPersonsInfoDTO)weldAttestationsBS.Current;

                var model = new WeldAttestationsDTO()
                {
                    Id = currRecord.Id,
                    AttestationNumber = currRecord.AttestationNumber,
                    AttestationDate = currRecord.AttestationDate,
                    ResponsiblePersonId = currRecord.ResponsiblePersonId,
                    BeginDate = currRecord.BeginDate,
                    EndDate = currRecord.EndDate,
                    DateAdded = currRecord.DateAdded,
                    UserId = currRecord.UserId,
                    Description = currRecord.Description
                };

                var personsList = weldAttestationPersonsList.Where(a => a.Id == currRecord.Id).ToList();

                EditWeldStamps(Utils.Operation.Update, model, personsList);
            }
        }
        
        private void documentBtnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            weldStampsService = Program.kernel.Get<IWeldStampsService>();

            var model = weldStampsService.GetEmployeesCertificateById(((EmployeeCertificatesDTO)weldDocumentsBS.Current).Id);

            if (model.CertificateScan != null)
            {
                string fileName = model.FileName;
                byte[] scan = model.CertificateScan;
                string puth = Utils.HomePath + @"\Temp\";

                System.IO.File.WriteAllBytes(puth + fileName, scan);

                System.Diagnostics.Process.Start(puth + fileName);
            }
        }

        #endregion
    }
}