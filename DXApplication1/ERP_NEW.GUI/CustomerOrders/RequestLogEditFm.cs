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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraBars;
using Ninject;
using System.IO;
using System.Diagnostics;
using ERP_NEW.BLL.Infrastructure;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ERP_NEW.BLL;
using DevExpress.Data.Filtering;
using System.Reflection;
using System.Collections;
using System.Security.AccessControl;

namespace ERP_NEW.GUI.CustomerOrders
{
    public partial class RequestLogEditFm : DevExpress.XtraEditors.XtraForm
    {
        private Utils.Operation operation;
        private BindingSource requestLogJournalBS = new BindingSource();
        private IRequestLogService requestLogService;
         
        private ObjectBase Item
        {
            get { return requestLogJournalBS.Current as ObjectBase; }
            set
            {
                requestLogJournalBS.DataSource = value;
                value.BeginEdit();
            }
        }
        public RequestLogDTO Return()
        {
            return ((RequestLogDTO)Item);
        }

        List<RequestLogDTO> requesLogList = new List<RequestLogDTO>();
        public RequestLogEditFm(Utils.Operation operation, RequestLogDTO model, List<RequestLogDTO> requestLogListModel)
        {
            InitializeComponent();

            this.operation = operation;
            requestLogJournalBS.DataSource = Item = model;
            requesLogList = requestLogListModel.OrderByDescending(a=>a.SeqNum).ToList();
            LoadData();
            

            seqNumEdit.DataBindings.Add("EditValue", requestLogJournalBS, "SeqNum", true, DataSourceUpdateMode.OnPropertyChanged);

            contractorsLookUpEdit.DataBindings.Add("EditValue", requestLogJournalBS, "RequestLogContractorId", true, DataSourceUpdateMode.OnPropertyChanged);
            List<RequestLogContractorsDTO> contractorsList = requestLogService.GetRequestLogContractors().ToList();
            contractorsLookUpEdit.Properties.DataSource = contractorsList;
            contractorsLookUpEdit.Properties.ValueMember = "Id";
            contractorsLookUpEdit.Properties.DisplayMember = "Name";
            contractorsLookUpEdit.Properties.NullText = "Немає даних";

            docEdit.DataBindings.Add("EditValue", requestLogJournalBS, "InformationDoc", true, DataSourceUpdateMode.OnPropertyChanged);

            taskEdit.DataBindings.Add("EditValue", requestLogJournalBS, "Task", true, DataSourceUpdateMode.OnPropertyChanged);

            specificationMemoEdit.DataBindings.Add("EditValue", requestLogJournalBS, "Spesification", true, DataSourceUpdateMode.OnPropertyChanged);

            dateEdit.DataBindings.Add("EditValue", requestLogJournalBS, "DateRegistration", true, DataSourceUpdateMode.OnPropertyChanged);

            contactAddressMemoEdit.DataBindings.Add("EditValue", requestLogJournalBS, "ContactAddress", true, DataSourceUpdateMode.OnPropertyChanged);

            stageRegistrationEdit.DataBindings.Add("EditValue", requestLogJournalBS, "StageRegistration", true, DataSourceUpdateMode.OnPropertyChanged);
            docForTenderEdit.DataBindings.Add("EditValue", requestLogJournalBS, "DocForTender", true, DataSourceUpdateMode.OnPropertyChanged);
            dateNumberEdit.DataBindings.Add("EditValue", requestLogJournalBS, "OrderDate", true, DataSourceUpdateMode.OnPropertyChanged);
            orderNumberEdit.DataBindings.Add("EditValue", requestLogJournalBS, "OrderNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            detalsMemoEdit.DataBindings.Add("EditValue", requestLogJournalBS, "Detals", true, DataSourceUpdateMode.OnPropertyChanged);

            if (operation==Utils.Operation.Add)
            {
                ((RequestLogDTO)Item).DateRegistration = DateTime.Now;
              //  ((RequestLogDTO)Item).OrderDate = DateTime.MinValue;
                dateNumberEdit.EditValue = null;
                int qw=requestLogListModel.Count;

                var seqNum = requestLogListModel.First();
                seqNumEdit.EditValue = GetLastNumber();
                ((RequestLogDTO)Item).SeqNum = GetLastNumber();
                //int index = seqNum.
                //seqNumEdit.EditValue = seqNum.SeqNum + 1;
                //((RequestLogDTO)Item).SeqNum = seqNum.SeqNum + 1;
            }
        }

        #region Method's     
        
        private void LoadData()
        {
            requestLogService = Program.kernel.Get<IRequestLogService>();
        }

        private int GetLastNumber()
        {
            int requestLogNumberlast = requestLogService.GetRequestLog().Select(srt => srt.SeqNum).Max();

            requestLogNumberlast++;

            return requestLogNumberlast;
        }

        private bool SaveItem()
        {
            
            this.Item.EndEdit();
            requestLogService = Program.kernel.Get<IRequestLogService>();

            if (operation == Utils.Operation.Add)
            {
                ((RequestLogDTO)Item).SeqNum = (int)seqNumEdit.EditValue;
                ((RequestLogDTO)Item).InformationDoc = docEdit.Text;
                ((RequestLogDTO)Item).Spesification = specificationMemoEdit.Text;
                
                ((RequestLogDTO)Item).ContactAddress = contactAddressMemoEdit.Text;
                ((RequestLogDTO)Item).StageRegistration = stageRegistrationEdit.Text;
                ((RequestLogDTO)Item).DocForTender = docForTenderEdit.Text;
                ((RequestLogDTO)Item).Detals = detalsMemoEdit.Text;
                ((RequestLogDTO)Item).OrderNumber = orderNumberEdit.Text;
                
                ((RequestLogDTO)Item).NameContractor = contractorsLookUpEdit.Text;
                ((RequestLogDTO)Item).Task = taskEdit.Text;
                ((RequestLogDTO)Item).ColorId = 1;
                ((RequestLogDTO)Item).ColorDetals = false;
                ((RequestLogDTO)Item).Id = requestLogService.RequestLogCreate((RequestLogDTO)Item);
                requesLogList = (requesLogList.Where(a => a.SeqNum >= (int)seqNumEdit.EditValue).ToList());
                for (int i = 0; i < requesLogList.Count; i++)
                {
                    requesLogList[i].SeqNum = requesLogList[i].SeqNum + 1;
                    requestLogService.RequestLogUpdate(requesLogList[i]);
                }

                if (dateNumberEdit.Text=="")
                    ((RequestLogDTO)Item).OrderDate=null;
                else
                ((RequestLogDTO)Item).OrderDate = (DateTime)dateNumberEdit.EditValue;
            }
            else
            { requestLogService.RequestLogUpdate((RequestLogDTO)Item); }
            return true;
          
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

        private void contractorsLookUpEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            requestLogService = Program.kernel.Get<IRequestLogService>();
            switch(e.Button.Index)
            {
                case 1:
                    {
                        using (RequestLogContractorsEditFm requestLogContractorsEditFm=
                            new RequestLogContractorsEditFm(Utils.Operation.Add,new RequestLogContractorsDTO()))
                        {
                            if (requestLogContractorsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                int return_Id = requestLogContractorsEditFm.Return();
                                requestLogService = Program.kernel.Get<IRequestLogService>();
                                contractorsLookUpEdit.Properties.DataSource = requestLogService.GetRequestLogContractors();
                                contractorsLookUpEdit.EditValue = return_Id;


                            }
                        }break;
                    }
                case 2:
                    {
                        if (contractorsLookUpEdit.EditValue == DBNull.Value)
                            return;
                        using (RequestLogContractorsEditFm requestLogContractorsEditFm =
                            new RequestLogContractorsEditFm(Utils.Operation.Update, (RequestLogContractorsDTO)contractorsLookUpEdit.GetSelectedDataRow()))
                        {
                            if (requestLogContractorsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                int return_Id = requestLogContractorsEditFm.Return();
                                requestLogService = Program.kernel.Get<IRequestLogService>();
                                contractorsLookUpEdit.Properties.DataSource = requestLogService.GetRequestLogContractors();
                                contractorsLookUpEdit.EditValue = return_Id;


                            }
                        } break;
                    }
                case 3:
                    {
                        if (contractorsLookUpEdit.EditValue == DBNull.Value)
                            return;

                        if (contractorsLookUpEdit.EditValue == null)
                            return;

                        if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            requestLogService.RequestLogContractorDelete
                                (((RequestLogContractorsDTO)contractorsLookUpEdit.GetSelectedDataRow()).Id);
                            requestLogService = Program.kernel.Get<IRequestLogService>();
                            contractorsLookUpEdit.Properties.DataSource = requestLogService.GetRequestLogContractors();
                            contractorsLookUpEdit.EditValue = null;
                            contractorsLookUpEdit.Properties.NullText = "Немає данних";
                        }
                        break;
                    }
            }
        }

        //private void taskLookUpEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    requestLogService = Program.kernel.Get<IRequestLogService>();
        //    switch (e.Button.Index)
        //    {
        //        case 1:
        //            {
        //                using (RequestLogTaskEditFm requestLogTaskEditFm =
        //                    new RequestLogTaskEditFm(Utils.Operation.Add, new RequestLogTaskDTO()))
        //                {
        //                    if (requestLogTaskEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //                    {
        //                        int return_Id = requestLogTaskEditFm.Return();
        //                        requestLogService = Program.kernel.Get<IRequestLogService>();
        //                        taskLookUpEdit.Properties.DataSource = requestLogService.GetRequestLogTask();
        //                        taskLookUpEdit.EditValue = return_Id;


        //                    }
        //                } break;
        //            }
        //        case 2:
        //            {
        //                if (taskLookUpEdit.EditValue == DBNull.Value)
        //                    return;
        //                using (RequestLogTaskEditFm requestLogTaskEditFm =
        //                    new RequestLogTaskEditFm(Utils.Operation.Update, (RequestLogTaskDTO)taskLookUpEdit.GetSelectedDataRow()))
        //                {
        //                    if (requestLogTaskEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //                    {
        //                        int return_Id = requestLogTaskEditFm.Return();
        //                        requestLogService = Program.kernel.Get<IRequestLogService>();
        //                        taskLookUpEdit.Properties.DataSource = requestLogService.GetRequestLogTask();
        //                        taskLookUpEdit.EditValue = return_Id;


        //                    }
        //                } break;
        //            }
        //        case 3:
        //            {
        //                if (taskLookUpEdit.EditValue == DBNull.Value)
        //                    return;

        //                if (taskLookUpEdit.EditValue == null)
        //                    return;

        //                if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //                {
        //                    requestLogService.RequestLogTaskDelete
        //                        (((RequestLogTaskDTO)taskLookUpEdit.GetSelectedDataRow()).Id);
        //                    requestLogService = Program.kernel.Get<IRequestLogService>();
        //                    taskLookUpEdit.Properties.DataSource = requestLogService.GetRequestLogTask();
        //                    taskLookUpEdit.EditValue = null;
        //                    taskLookUpEdit.Properties.NullText = "Немає данних";
        //                }
        //                break;
        //            }
        //    }
        //}
        
        #endregion

        #region Validation's
        
        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
        }

        private void contractorsLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void seqNumEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }
        #endregion


    }
}