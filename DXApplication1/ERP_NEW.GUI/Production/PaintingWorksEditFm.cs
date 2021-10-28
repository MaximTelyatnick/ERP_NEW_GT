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
using DevExpress.Utils;

namespace ERP_NEW.GUI.Production
{
    public partial class PaintingWorksEditFm : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource paintingWorksJournalBS = new BindingSource();
        private Utils.Operation operation;
        private IProjectDetailsService projectDetailsService;
        private IMtsSpecificationsService mtsSpecificationsService;
        public UserTasksDTO userTaskDTO = new UserTasksDTO();
        private int cp;

        private ObjectBase Item
        {
            get { return paintingWorksJournalBS.Current as ObjectBase; }
            set
            {
                paintingWorksJournalBS.DataSource = value;
                value.BeginEdit();
            }
        }
        
        public PaintingWorksEditFm(Utils.Operation operation, PaintingWorksDTO model, UserTasksDTO userTaskDTO, int countPaint)
        {
            InitializeComponent();

            this.operation = operation;
            paintingWorksJournalBS.DataSource = Item = model;
            cp = countPaint;
            this.userTaskDTO = userTaskDTO;
            
         
        
            Dictionary<int, string> qualityDictionary = new Dictionary<int, string>(2);
            qualityDictionary.Add(1, "Відповідає");
            qualityDictionary.Add(2, "Не відповідає");

            projectDetailsService = Program.kernel.Get<IProjectDetailsService>();
            mtsSpecificationsService=Program.kernel.Get<IMtsSpecificationsService>();

            dateEdit.DataBindings.Add("EditValue", paintingWorksJournalBS, "Date", true, DataSourceUpdateMode.OnPropertyChanged);

           
            List<MtsAssembliesDTO> mtsAssembliesList = mtsSpecificationsService.GetAllMtsAssemblies().ToList();
            numberDrawingLookUpEdit.Properties.DataSource = mtsAssembliesList;
            numberDrawingLookUpEdit.Properties.ValueMember = "Id";
            numberDrawingLookUpEdit.Properties.DisplayMember = "Drawing";
            numberDrawingLookUpEdit.Properties.NullText = "Немає даних";

            nameProductEdit.ReadOnly = true;

            nameCheckProductEdit.DataBindings.Add("EditValue", paintingWorksJournalBS, "NameCheckProduct", true, DataSourceUpdateMode.OnPropertyChanged);
            resultEdit.DataBindings.Add("EditValue", paintingWorksJournalBS, "Result", true, DataSourceUpdateMode.OnPropertyChanged);

            qualityLookUpEdit.Properties.DataSource = qualityDictionary.ToList();
            qualityLookUpEdit.Properties.ValueMember = "Key";
            qualityLookUpEdit.Properties.DisplayMember = "Value";
            qualityLookUpEdit.Properties.NullText = "Немає даних";

            checkQualityLookUpEdit.Properties.DataSource = qualityDictionary.ToList(); 
            checkQualityLookUpEdit.Properties.ValueMember = "Key";
            checkQualityLookUpEdit.Properties.DisplayMember = "Value";
            checkQualityLookUpEdit.Properties.NullText = "Немає даних";

            causeReturnEdit.DataBindings.Add("EditValue", paintingWorksJournalBS, "CauseReturn", true, DataSourceUpdateMode.OnPropertyChanged);
            correctiveActiveEdit.DataBindings.Add("EditValue", paintingWorksJournalBS, "CorrectiveAction", true, DataSourceUpdateMode.OnPropertyChanged);
            noteEdit.DataBindings.Add("EditValue", paintingWorksJournalBS, "Note", true, DataSourceUpdateMode.OnPropertyChanged);
            string quality = ((PaintingWorksDTO)Item).QuantityOfExecution;
            if (this.operation == Utils.Operation.Update)
            {
                numberDrawingLookUpEdit.DataBindings.Add("EditValue", paintingWorksJournalBS, "MtsAssembliesId", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            if ((((PaintingWorksDTO)Item).QuantityOfExecution) == "Відповідає")  
                qualityLookUpEdit.EditValue = 1;                    

            if ((((PaintingWorksDTO)Item).CheckQuantityOfExecution) == "Відповідає")
                checkQualityLookUpEdit.EditValue = 1;

            if ((((PaintingWorksDTO)Item).QuantityOfExecution) == "Не відповідає") 
                qualityLookUpEdit.EditValue = 2;
                    
            if((((PaintingWorksDTO)Item).CheckQuantityOfExecution) == "Не відповідає")
                checkQualityLookUpEdit.EditValue = 2;
        }

        private bool SaveItem()
        {
            ((PaintingWorksDTO)Item).MtsAssembliesId = ((MtsAssembliesDTO)numberDrawingLookUpEdit.GetSelectedDataRow()).Id;
            ((PaintingWorksDTO)Item).ResponsiblePersonId = userTaskDTO.UserId;
            this.Item.EndEdit();
            if (paintingWorksJournalBS.Count <= 0)
            {
                MessageBox.Show("Необхідно додати позицію!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (this.operation == Utils.Operation.Add)
            {
                if (causeReturnEdit.Text != "" || correctiveActiveEdit.Text != "" || noteEdit.Text != "")
                {
                    ((PaintingWorksDTO)Item).FinalResponsiblePersonId = userTaskDTO.UserId;
                    ((PaintingWorksDTO)Item).SeqNum = cp+1;
                    if (qualityLookUpEdit.Text == "Відповідає")
                        (((PaintingWorksDTO)Item).QuantityOfExecution) = "Відповідає";
                    else (((PaintingWorksDTO)Item).QuantityOfExecution) = "Не відповідає";

                    if (checkQualityLookUpEdit.Text == "Відповідає")
                        (((PaintingWorksDTO)Item).CheckQuantityOfExecution) = "Відповідає";
                    else (((PaintingWorksDTO)Item).CheckQuantityOfExecution) = "Не відповідає";
                    ((PaintingWorksDTO)Item).Id=projectDetailsService.PaintingWorksCreate((PaintingWorksDTO)Item);   
            
                }
                else
                {
                     ((PaintingWorksDTO)Item).FinalResponsiblePersonId = null;
                     ((PaintingWorksDTO)Item).SeqNum = cp + 1;
                     if (qualityLookUpEdit.Text == "Відповідає")
                         (((PaintingWorksDTO)Item).QuantityOfExecution) = "Відповідає";
                     else (((PaintingWorksDTO)Item).QuantityOfExecution) = "Не відповідає";

                     if (checkQualityLookUpEdit.Text == "Відповідає")
                         (((PaintingWorksDTO)Item).CheckQuantityOfExecution) = "Відповідає";
                     else (((PaintingWorksDTO)Item).CheckQuantityOfExecution) = "Не відповідає";
                     ((PaintingWorksDTO)Item).Id = projectDetailsService.PaintingWorksCreate((PaintingWorksDTO)Item);         
                }
            }
            else
            {
                if (causeReturnEdit.Text != "" || correctiveActiveEdit.Text != "" || noteEdit.Text != "")
                {
                    ((PaintingWorksDTO)Item).FinalResponsiblePersonId = userTaskDTO.UserId;
                    projectDetailsService.PaintingWorksUpdate((PaintingWorksDTO)Item);   
                }
                else
                {
                    projectDetailsService.PaintingWorksUpdate((PaintingWorksDTO)Item);  
                    
                }
            }
            return true;
        }

        public int Return()
        {
            return ((PaintingWorksDTO)Item).Id;
        }

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
                {
                    MessageBox.Show("error" + ex.Message, "Збереження ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void numberDrawingLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            object key = numberDrawingLookUpEdit.EditValue;
            var selectedIndex = numberDrawingLookUpEdit.Properties.GetIndexByKeyValue(key);
            nameProductEdit.EditValue = ((MtsAssembliesDTO)numberDrawingLookUpEdit.GetSelectedDataRow()).Name;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}