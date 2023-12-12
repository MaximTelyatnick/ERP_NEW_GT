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
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using ERP_NEW.GUI.OTK;
using ERP_NEW.GUI.MTS;
using ERP_NEW.GUI.Delivery;
using ERP_NEW.GUI.Classifiers;
using ERP_NEW.GUI.Contractors;
using ERP_NEW.GUI.BusinessTrips;
using ERP_NEW.GUI.CustomerOrders;
using ERP_NEW.GUI.Marketing;
using ERP_NEW.GUI.Production;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Services;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraBars.Navigation;
using System.IO;
using DevExpress.XtraSplashScreen;
using Ninject;
using System.Threading;
using System.DirectoryServices;
using ERP_NEW.GUI.Tools;
using ERP_NEW.BLL.Marketing;
using ERP_NEW.GUI.StoreHouse;
using ERP_NEW.GUI.Accounting;
using ERP_NEW.GUI.BusinessCard;
using ERP_NEW.GUI.GodMode;
using System.Reflection;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Diagnostics;
using System.Deployment.Application;
using Microsoft.Win32;

namespace ERP_NEW.GUI
{
    public partial class MainTabFm : DevExpress.XtraEditors.XtraForm
    {
        private IUserService userService;
        private UserDetailsDTO userInfo;
        private IEnumerable<UserTasksDTO> userAccess;

        public MainTabFm()
        {
           
            InitializeComponent();

            Skin skin = SkinManager.Default.GetSkin(SkinProductId.Common, DevExpress.LookAndFeel.UserLookAndFeel.Default);
            SkinElement elementGlyph = skin[CommonSkins.SkinSplitter];
            elementGlyph.Glyph.Image = null;
            elementGlyph.Color.BackColor = Color.Transparent;
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            // SystemEvents.DisplaySettingsChanged += new
            //EventHandler(SystemEvents_DisplaySettingsChanged);

            // SystemEvents.SessionEnding += new
            //  SessionEndingEventHandler(SystemEvents_SessionEndingEventHandler);

            Microsoft.Win32.SystemEvents.SessionEnded += new Microsoft.Win32.SessionEndedEventHandler(SystemEvents_SessionEnded);

            userService = Program.kernel.Get<IUserService>();
            documentManager.MdiParent = this;
            documentManager.View = new TabbedView();
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fileVersionInfo.ProductVersion;

            //var productVersion = FileVersionInfo.GetVersionInfo(Assembly.Location).ProductVersion.ToString();

            Version myVersion = new Version();

            if (ApplicationDeployment.IsNetworkDeployed)
            myVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion;

            programVersionLbl.Text += myVersion.ToString();
            //programVersionLbl.Text += (FileVersionInfo.GetVersionInfo(Assembly.GetCallingAssembly().Location).ProductVersion).ToString();
            //programVersionLbl.Text += Application.ProductVersion.ToString();

            if (!CheckAccess())
                return;

            userInfo = UserService.AuthorizatedUser;

            userFotoEdit.EditValue = PhotoSource(userInfo);
            fioLabel.Text = userInfo.Fio;
            professionLabel.Text  = userInfo.ProfessionName;
            departmentLabel.Text = userInfo.DepartmentName;
            
            UserAccessMenu();
            UserOnline();


           
        }



        void SystemEvents_SessionEnded(object sender, Microsoft.Win32.SessionEndedEventArgs e)
        {
            //MessageBox.Show("SessionEnded fired");




            //if (!mainWindow.dBSaved) mainWindow.SaveDb(Form1.settings.dBPath);
            //if (mainWindow.index != null) mainWindow.SaveIndex(Form1.settings.indexPath);
            UserOffline();
            Microsoft.Win32.SystemEvents.SessionEnded -= new Microsoft.Win32.SessionEndedEventHandler(SystemEvents_SessionEnded);
            Application.Exit();
        }

        private void UserOnline()
        {
            userService.UserUpdateState(userInfo.UserId, true);
        }

        private void UserOffline()
        {
            userService.UserUpdateState(userInfo.UserId, false);
        }

        private byte[] PhotoSource(UserDetailsDTO source)
        {
            if (source.UserPhoto == null || source.UserPhoto.Length == 0)
            {
                MemoryStream ms = new MemoryStream();
                Image.FromFile("Images/happy-face.png").Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                source.UserPhoto = ms.ToArray();
            }
            return source.UserPhoto;
        }

        private void UserAccessMenu()
        {
            userAccess = UserService.AuthorizatedUserAccess;
            var category = menuNavPane.Buttons.Select(s => s.Element.Name).ToList();
            for (int i = 0; i < category.Count; i++)
            {
                var categoryMenu = userAccess.Where(s => s.TaskName == category[i]).ToList();
                bool availableCategory = (categoryMenu.Count > 0 ? true : false);    

                if (availableCategory == true)  // пункт меню(категория 1 уровень) доступен
                {
                    menuNavPane.Buttons[i].Element.Visible = true;
                    var item = ((TileNavCategory)menuNavPane.Buttons[i]).Items.Select(s => s.Name).ToList();
                    for (int j = 0; j < item.Count; j++)
                    {
                        var itemMenu = userAccess.Where(s => s.TaskName == item[j]).ToList();
                        bool availableItem = (itemMenu.Count > 0 ? true : false);

                        if (availableItem == true) // пункт меню (2 уровень) доступен
                        {
                            ((TileNavCategory)menuNavPane.Buttons[i]).Items[j].Tile.Enabled = true;
                            var subItem = ((TileNavCategory)menuNavPane.Buttons[i]).Items[j].SubItems.Select(s => s.Name).ToList();
                            for (int k = 0; k < subItem.Count; k++)
                            {
                                var subItemMenu = userAccess.Where(s => s.TaskName == subItem[k]).ToList();
                                bool availableSubItem = (subItemMenu.Count > 0 ? true : false);

                                if (availableSubItem == true) // пункт подменю (3 уровень) доступен
                                    ((TileNavCategory)menuNavPane.Buttons[i]).Items[j].SubItems[k].Tile.Enabled = true;
                                else
                                    ((TileNavCategory)menuNavPane.Buttons[i]).Items[j].SubItems[k].Tile.Enabled = false;
                            }
                        }
                        else
                            ((TileNavCategory)menuNavPane.Buttons[i]).Items[j].Tile.Enabled = false;
                    }
                }
               else
                    menuNavPane.Buttons[i].Element.Visible = false;
            }

            if(userAccess.Count() == 0 || userAccess.First().RoleName == "Администратор")
            {
                toolsBtn.Enabled = true;
                toolsBtn.Visible = true;
                godModBtn.Enabled = true;
                godModBtn.Visible = true;
            }
        }

        private void menuNavPane_TileClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            UserTasksDTO userTasksDTO = userAccess
                .Where(s => s.TaskName == e.Element.Name)
                .Select(s => new UserTasksDTO
                {
                    UserTaskId = s.UserTaskId,
                    UserRoleId = s.UserRoleId,
                    UserId = s.UserId,
                    PriceAttribute = s.PriceAttribute,
                    AccessRightId = s.AccessRightId
                })
                .FirstOrDefault();

            string path = Utils.HomePath;

            switch (e.Element.Name)
            {
                case "certificateItem":
                    ReceiptCertificatesFm receiptCertificatesFm = new ReceiptCertificatesFm(userTasksDTO);
                    receiptCertificatesFm.Text = "Сертифікати та паспорти";
                    receiptCertificatesFm.MdiParent = this;
                    receiptCertificatesFm.Show();
                    break;
                case "expenditureOrdersItem":
                    ExpenditureByOrdersFm expenditureByOrdersFm = new ExpenditureByOrdersFm();
                    expenditureByOrdersFm.Text = "Списання за проектами";
                    expenditureByOrdersFm.MdiParent = this;
                    expenditureByOrdersFm.Show();
                    break;
                case "deliveryOrdersItem":
                    DeliveryOrdersFm deliveryOrdersFm = new DeliveryOrdersFm(userTasksDTO);
                    deliveryOrdersFm.Text = "Надходження матеріалів";
                    deliveryOrdersFm.MdiParent = this;
                    deliveryOrdersFm.Show();
                    break;
                case "deliveryPaymentsItem":
                    DeliveryPaymentsFm deliveryPaymentsFm = new DeliveryPaymentsFm(userTasksDTO);
                    deliveryPaymentsFm.Text = "Платежі";
                    deliveryPaymentsFm.MdiParent = this;
                    deliveryPaymentsFm.Show();
                    break;
                case "deliveryContractorDebtsItem":
                    DeliveryContractorDebtsFm deliveryContractorDebtsFm = new DeliveryContractorDebtsFm(userTasksDTO);
                    deliveryContractorDebtsFm.Text = "Заборгованість по контрагентам";
                    deliveryContractorDebtsFm.MdiParent = this;
                    deliveryContractorDebtsFm.Show();
                    break;
                case "deliveryStoreRemainsItem":
                    DeliveryStoreRemainsFm deliveryStoreRemainsFm = new DeliveryStoreRemainsFm(userTasksDTO);
                    deliveryStoreRemainsFm.Text = "Залишки на складі";
                    deliveryStoreRemainsFm.MdiParent = this;
                    deliveryStoreRemainsFm.Show();
                    break;
                case "employeesInfoItem":
                    if (!Properties.Settings.Default.UserUsedSimpleEmployeeForm)
                    {
                        EmployeesInfoFm employeesInfoFm = new EmployeesInfoFm(userTasksDTO);
                        employeesInfoFm.Text = "Співробітники";
                        employeesInfoFm.MdiParent = this;
                        employeesInfoFm.Show();
                    }else{
                        EmployeesMiniFm employeesminiFm = new EmployeesMiniFm(userTasksDTO);
                        employeesminiFm.Text = "Співробітники";
                        employeesminiFm.MdiParent = this;
                        employeesminiFm.Show();
                    }
                    break;
                case "contractorsItem":
                    ContractorsFm contractorsFm = new ContractorsFm(userTasksDTO);
                    contractorsFm.Text = "Контрагенти";
                    contractorsFm.MdiParent = this;
                    contractorsFm.Show();
                    break;
                case "customerOrdersItem":
                    CustomerOrdersFm customerOrdersFm = new CustomerOrdersFm(userTasksDTO);
                    customerOrdersFm.Text = "Закази";
                    customerOrdersFm.MdiParent = this;
                    customerOrdersFm.Show();
                    break;
                case "contractPaymentItem":
                    ContractPaymentsJournalFm contractPaymentsJournalFm = new ContractPaymentsJournalFm(userTasksDTO);
                    contractPaymentsJournalFm.Text = "Журнал надходжень і витрат";
                    contractPaymentsJournalFm.MdiParent = this;
                    contractPaymentsJournalFm.Show();
                    break;
                case "defectActsItem":
                    DefectActsFm defectActsFm = new DefectActsFm(userTasksDTO);
                    defectActsFm.Text = "Журнал актів рекламації";
                    defectActsFm.MdiParent = this;
                    defectActsFm.Show();
                    break;
                case "packingItem":
                    PackingListsFm packingListsFm = new PackingListsFm(userTasksDTO);
                    packingListsFm.Text = "Пакувальні листи";
                    packingListsFm.MdiParent = this;
                    packingListsFm.Show();
                    break;
                case "shipmentItem":
                    ShipmentListsFm shipmentListsFm = new ShipmentListsFm(userTasksDTO);
                    shipmentListsFm.Text = "Документи на відвантаження";
                    shipmentListsFm.MdiParent = this;
                    shipmentListsFm.Show();
                    break;
                case "executorsItem":
                    ProjectDetailsFm projectDetailsFm = new ProjectDetailsFm(userTasksDTO);
                    projectDetailsFm.Text = "Зварювальні роботи";
                    projectDetailsFm.MdiParent = this;
                    projectDetailsFm.Show();
                    break;
                case "weldAttestationItem":
                    WeldAttestationFm weldAttestationFm = new WeldAttestationFm(userTasksDTO);
                    weldAttestationFm.Text = "Журнал атестації";
                    weldAttestationFm.MdiParent = this;
                    weldAttestationFm.Show();
                    break;
                case "weldAttestationPersonItem":
                    WeldStampJournalFm weldStampJournalFm = new WeldStampJournalFm(userTasksDTO);
                    weldStampJournalFm.Text = "Журнал видачі клейм";
                    weldStampJournalFm.MdiParent = this;
                    weldStampJournalFm.Show();
                    break;
                case "weldWpsItem":
                    WeldWpsFm weldWpsFm = new WeldWpsFm(userTasksDTO);
                    weldWpsFm.Text = "Довідник WPS";
                    weldWpsFm.MdiParent = this;
                    weldWpsFm.Show();
                    break;
                case "weldStampItem":
                    WeldStampsFm weldStampsFm = new WeldStampsFm(userTasksDTO);
                    weldStampsFm.Text = "Довідник клейм";
                    weldStampsFm.MdiParent = this;
                    weldStampsFm.Show();
                    break;
                case "materialsSubItem":
                    MtsNomenclaturesFm mtsNomenclaturesFm = new MtsNomenclaturesFm(userTasksDTO);
                    mtsNomenclaturesFm.Text = "Довідник матеріалів";
                    mtsNomenclaturesFm.MdiParent = this;
                    mtsNomenclaturesFm.Show();
                    break;
                case "gostsSubItem":
                    MtsGostsFm mtsGostsFm = new MtsGostsFm(userTasksDTO);
                    mtsGostsFm.Text = "Довідник ГОСТ,ТУ";
                    mtsGostsFm.MdiParent = this;
                    mtsGostsFm.Show();
                    break;
                case "unitsSubItem":
                    UnitsFm unitsFm = new UnitsFm(userTasksDTO);
                    unitsFm.Text = "Довідник одиниць вимірювання";
                    unitsFm.MdiParent = this;
                    unitsFm.Show();
                    break;
                case "mtsItem":
                    MtsSpecificationFm mtsSpecificationFm = new MtsSpecificationFm(userTasksDTO);
                    mtsSpecificationFm.Text = "Матеріальні специфікації";
                    mtsSpecificationFm.MdiParent = this;
                    mtsSpecificationFm.Show();
                    break;
                case "journalAssembliesItem":
                    JournalAssembliesFm journalAssembliesFm = new JournalAssembliesFm(userTasksDTO);
                    journalAssembliesFm.Text = "Журнал реєстрації виробів";
                    journalAssembliesFm.MdiParent = this;
                    journalAssembliesFm.Show();
                    break;
                case "citiesItem":
                    CitiesFm citiesFm = new CitiesFm(userTasksDTO);
                    citiesFm.Text = "Довідник населених пунктів";
                    citiesFm.MdiParent = this;
                    citiesFm.Show();
                    break;
                case "accountsSubItem":
                    AccountsFm accountsFm = new AccountsFm(userTasksDTO);
                    accountsFm.Text = "Довідник рахунків";
                    accountsFm.MdiParent = this;
                    accountsFm.Show();
                    break;
                case "businessTripsItem":
                    BusinessTripsFm businessTripsFm = new BusinessTripsFm(userTasksDTO);
                    businessTripsFm.Text = "Журнал посвідчень";
                    businessTripsFm.MdiParent = this;
                    businessTripsFm.Show();
                    break;
                case "businessTripsDecreeItem":
                    BusinessTripsDecreeFm businessTripsDecreeFm = new BusinessTripsDecreeFm(userTasksDTO);
                    businessTripsDecreeFm.Text = "Журнал наказів";
                    businessTripsDecreeFm.MdiParent = this;
                    businessTripsDecreeFm.Show();
                    break;
                case "accountClothesItem":
                    StoreHouseFm storeHouseFm = new StoreHouseFm(userTasksDTO);
                    storeHouseFm.Text = "Складський журнал";
                    storeHouseFm.MdiParent = this;
                    storeHouseFm.Show();
                    break;
                case "invoiceRequirementItem":
                    InvoiceRequirementFm invoiceRequirementFm = new InvoiceRequirementFm(userTasksDTO, Utils.InvoiceType.Storehouses);
                    invoiceRequirementFm.Text = "Вимоги";
                    invoiceRequirementFm.MdiParent = this;
                    invoiceRequirementFm.Show();
                    break;
                case "accountClothesJournalItem":
                    StoreHouseJournalFm storeHouseJournalFm = new StoreHouseJournalFm(userTasksDTO);
                    storeHouseJournalFm.Text = "Журнал обліку спецодягу";
                    storeHouseJournalFm.MdiParent = this;
                    storeHouseJournalFm.Show();
                    break;

                case "storeHouseRemainsItem":
                    StoreHouseRemainFm storeHouseRemainFm = new StoreHouseRemainFm(userTasksDTO);
                    storeHouseRemainFm.Text = "Складські залишки";
                    storeHouseRemainFm.MdiParent = this;
                    storeHouseRemainFm.Show();
                    break;
                case "storehouseSubItem":
                    StoreHouseListFm storeHouseListFm = new StoreHouseListFm(userTasksDTO);
                    storeHouseListFm.Text = "Склади";
                    storeHouseListFm.MdiParent = this;
                    storeHouseListFm.Show();
                    break;
                case "storeHouseReceiptsJournalItem":
                    StoreHouseReceiptsJournalFm storeHouseReceiptJournalFm = new StoreHouseReceiptsJournalFm(userTasksDTO);
                    storeHouseReceiptJournalFm.Text = "Журнал надходжень";
                    storeHouseReceiptJournalFm.MdiParent = this;
                    storeHouseReceiptJournalFm.Show();
                    break;
                case "receiptOrdersItem":
                    StoreHouseOrdersFm storeHouseOrdersFm = new StoreHouseOrdersFm(userTasksDTO);
                    storeHouseOrdersFm.Text = "Надходження";
                    storeHouseOrdersFm.MdiParent = this;
                    storeHouseOrdersFm.Show();
                    break;
                case "storeMaterialsSubItem":
                    NomenclaturesFm nomenclaturesFm = new NomenclaturesFm(userTasksDTO);
                    nomenclaturesFm.Text = "Матеріали";
                    nomenclaturesFm.MdiParent = this;
                    nomenclaturesFm.Show();
                    break;
               case "periodsSubItem":
                    PeriodsFm periodsFm = new PeriodsFm(userTasksDTO);
                    periodsFm.Text = "Періоди";
                    periodsFm.MdiParent = this;
                    periodsFm.Show();
                    break;
               case "tripPaymentsJournalItem":
                    BusinessTripsPaymentJournalFm businessTripsPaymentJournalFm = new BusinessTripsPaymentJournalFm(userTasksDTO);
                    businessTripsPaymentJournalFm.Text = "Журнал авансів і звітів";
                    businessTripsPaymentJournalFm.MdiParent = this;
                    businessTripsPaymentJournalFm.Show();
                    break;
               case "toolActsItem":
                    ToolActsFm toolsActsFm = new ToolActsFm(userTasksDTO);
                    toolsActsFm.Text = "Журнал списання";
                    toolsActsFm.MdiParent = this;
                    toolsActsFm.Show();
                    break;
               case "cashPaymentsJournalItem":
                    CashPaymentJournalFm cashPaymentJournalFm = new CashPaymentJournalFm(userTasksDTO);
                    cashPaymentJournalFm.Text = "Журнал господарчих потреб";
                    cashPaymentJournalFm.MdiParent = this;
                    cashPaymentJournalFm.Show();
                    break;
               case "calcWithBuyersItem":
                    CalcWithBuyersJournalFm calcWithBuyersJournalFm = new CalcWithBuyersJournalFm(userTasksDTO);
                    calcWithBuyersJournalFm.Text = "Розрахунки з покупцями та замовниками";
                    calcWithBuyersJournalFm.MdiParent = this;
                    calcWithBuyersJournalFm.Show();
                    break;
               case "bankPaymentsItem":
                    BankPaymentsJournalFm bankPaymentsJournalFm = new BankPaymentsJournalFm(userTasksDTO);
                    bankPaymentsJournalFm.Text = "Банківські операції";
                    bankPaymentsJournalFm.MdiParent = this;
                    bankPaymentsJournalFm.Show();
                    break;
               case "accountingReportItem":
                    ReportsFm reportsFm = new ReportsFm(userTasksDTO);
                    reportsFm.Text = "Звіти";
                    reportsFm.MdiParent = this;
                    reportsFm.Show();
                    break;
               case "dictionaryUKTVSubItem":
                    DictionaryUktvFm dictionaryUktvFm = new DictionaryUktvFm(userTasksDTO);
                    dictionaryUktvFm.Text = "Довідник УКТЗЕД";
                    dictionaryUktvFm.MdiParent = this;
                    dictionaryUktvFm.Show();
                    break;
               case "dictionaryDKPPSubItem":
                    DictionaryDkppFm dictionaryDkppFm = new DictionaryDkppFm(userTasksDTO);
                    dictionaryDkppFm.Text = "Довідник ДКПП";
                    dictionaryDkppFm.MdiParent = this;
                    dictionaryDkppFm.Show();
                    break;
               case "dictionaryCPVSubItem":
                    DictionaryCpvFm dictionaryCpvFm = new DictionaryCpvFm(userTasksDTO);
                    dictionaryCpvFm.Text = "Довідник УКТЗЕД";
                    dictionaryCpvFm.MdiParent = this;
                    dictionaryCpvFm.Show();
                    break;
               case "businessCardItem":
                    BusinessCardFm businessCardFm = new BusinessCardFm(userTasksDTO);
                    businessCardFm.Text = "Довідник візиток";
                    businessCardFm.MdiParent = this;
                    businessCardFm.Show();
                    break;
               case "cashBookItem":
                    CashBookFm cashBookFm = new CashBookFm(userTasksDTO);
                    cashBookFm.Text = "Касова книга";
                    cashBookFm.MdiParent = this;
                    cashBookFm.Show();
                    break;

               case "cashBookSubItem":
                    BasisJournalFm basisJournalFm = new BasisJournalFm(userTasksDTO);
                    basisJournalFm.Text = "Журнал підстав";
                    basisJournalFm.MdiParent = this;
                    basisJournalFm.Show();
                    break;

               case "cashBookContractorSubItem":
                    CashBookContractorFm cashBookContractorFm = new CashBookContractorFm(userTasksDTO);
                    cashBookContractorFm.Text = "Журнал касових контрагентів";
                    cashBookContractorFm.MdiParent = this;
                    cashBookContractorFm.Show();
                    break;

               case "cashBookAdditionalSubItem":
                    CashBookAdditionalFm cashBookAdditionalFm = new CashBookAdditionalFm(userTasksDTO);
                    cashBookAdditionalFm.Text = "Журнал касових додатків";
                    cashBookAdditionalFm.MdiParent = this;
                    cashBookAdditionalFm.Show();
                    break;
             
                case "timeSheetItem":
                    TimeSheetFm timeSheetFm = new TimeSheetFm(userTasksDTO);
                    timeSheetFm.Text = "Табель обліку робочого часу";
                    timeSheetFm.MdiParent = this;
                    timeSheetFm.Show();
                    break;

                case "visitSheduleItem":
                    VisitScheduleFm visitSheduleFm = new VisitScheduleFm(userTasksDTO);
                    visitSheduleFm.Text = "Журнал відвідувань співвробітників";
                    visitSheduleFm.MdiParent = this;
                    visitSheduleFm.Show();
                    break;

                case "manualBookItem":

                    //string path = Utils.HomePath + @"\Temp\Pdf\";

                    System.Diagnostics.Process.Start(path + @"\Temp\Pdf\OperatorERPmanual.pdf");

                    break;

                case "manualBookAccountantItem":

                    //string path = Utils.HomePath + @"\Temp\Pdf\";

                    System.Diagnostics.Process.Start(path + @"\Temp\Pdf\OperatorERPmanualAccountant.pdf");

                    break;

                case "manualBdItem":

                    //string path = Utils.HomePath + @"\Temp\Pdf\";

                    System.Diagnostics.Process.Start(path + @"\Temp\Pdf\OperatorDbManual.xls");

                    break;


                    
                
                case "taxAccountingItem":
                    AccountingInvoicesFm accountingInvoicesFm = new AccountingInvoicesFm(userTasksDTO);
                    accountingInvoicesFm.Text = "Податковий облік";
                    accountingInvoicesFm.MdiParent = this;
                    accountingInvoicesFm.Show();
                    break;

                case "agreementJournalItem":
                    AgreementJournalFm agreementJournalFm = new AgreementJournalFm(userTasksDTO);
                    agreementJournalFm.Text = "Журнал договорів";
                    agreementJournalFm.MdiParent = this;
                    agreementJournalFm.Show();
                    break;

                case "deliveryStoreRemainsReceiptItem":
                    DeliveryStoreRemainsReceiptFm deliveryStoreRemainsReceiptFm = new DeliveryStoreRemainsReceiptFm(userTasksDTO);
                    deliveryStoreRemainsReceiptFm.Text = "Залишки на складі за надходженнями";
                    deliveryStoreRemainsReceiptFm.MdiParent = this;
                    deliveryStoreRemainsReceiptFm.Show();
                    break;
                case "invoiceRequirementAccountItem":
                    InvoiceRequirementFm invoiceRequirementAccountFm = new InvoiceRequirementFm(userTasksDTO, Utils.InvoiceType.Accountint);
                    invoiceRequirementAccountFm.Text = "Вимоги";
                    invoiceRequirementAccountFm.MdiParent = this;
                    invoiceRequirementAccountFm.Show();
                    break;
                case "agreementOrderJournalItem":
                    AgreementOrderJournalFm agreementOrderJournalFm = new AgreementOrderJournalFm(userTasksDTO);
                    agreementOrderJournalFm.Text = "Рахунки";
                    agreementOrderJournalFm.MdiParent = this;
                    agreementOrderJournalFm.Show();
                    break;

                case "requestLogItem":
                    RequestLogFm requestLogFm = new RequestLogFm(userTasksDTO);
                    requestLogFm.Text = "Журнал реєстрації запитів замовників";
                    requestLogFm.MdiParent = this;
                    requestLogFm.Show();
                    break;


                case "fixedAssetsSubItem":
                    FixedAssetsOrderFm fixedAssetsOrderFm = new FixedAssetsOrderFm(userTasksDTO);
                    fixedAssetsOrderFm.Text = "Основні засоби";
                    fixedAssetsOrderFm.MdiParent = this;
                    fixedAssetsOrderFm.Show();
                    break;

                case "archiveSubItem":
                    FixedAssetsOrderArchiveFm fixedAssetsOrderArchiveFm = new FixedAssetsOrderArchiveFm(userTasksDTO);
                    fixedAssetsOrderArchiveFm.Text = "Архів основних засобів";
                    fixedAssetsOrderArchiveFm.MdiParent = this;
                    fixedAssetsOrderArchiveFm.Show();
                    break;

                case "deliveryOrderTTNItem":
                    DeliveryTTNFm deliveryTTNFm = new DeliveryTTNFm(userTasksDTO);
                    deliveryTTNFm.Text = "Журнал ТТН";
                    deliveryTTNFm.MdiParent = this;
                    deliveryTTNFm.Show();
                    break;

                case "deliverySubItem":
                    DeliveryFm deliveryFm = new DeliveryFm(userTasksDTO);
                    deliveryFm.Text = "Журнал перевізників";
                    deliveryFm.MdiParent = this;
                    deliveryFm.Show();
                    break;
                case "storehouseTTNItem":
                    DeliveryTTNFm storehouseTTNFm = new DeliveryTTNFm(userTasksDTO);
                    storehouseTTNFm.Text = "Журнал ТТН";
                    storehouseTTNFm.MdiParent = this;
                    storehouseTTNFm.Show();
                    break;
                case "accountingOrderItem":
                    AccountingOrdersFm accountingOrdersFm = new AccountingOrdersFm(userTasksDTO);
                    accountingOrdersFm.Text = "Журнал надходжень";
                    accountingOrdersFm.MdiParent = this;
                    accountingOrdersFm.Show();
                    break;
                case "accountingOrderCurrencyItem":
                    AccountingOrdersFm accountingOrdersCurrencyFm = new AccountingOrdersFm(userTasksDTO, true);
                    accountingOrdersCurrencyFm.Text = "Журнал надходжень (632 рах.)";
                    accountingOrdersCurrencyFm.MdiParent = this;
                    accountingOrdersCurrencyFm.Show();
                    break;
               case "expendituresItem":
                    ExpendituresFm expendituresFm = new ExpendituresFm(userTasksDTO);
                    expendituresFm.Text = "Журнал списань";
                    expendituresFm.MdiParent = this;
                    expendituresFm.Show();
                    break;
               case "productionInvoicesItem":
                    StoreHouseProjectFm productionInvoicesFm = new StoreHouseProjectFm(userTasksDTO);
                    productionInvoicesFm.Text = "Надходження (виробництво)";
                    productionInvoicesFm.MdiParent = this;
                    productionInvoicesFm.Show();
                    break;
                case "journalAssembliesFromCustomerItem":
                    JournalAssembliesFm journalAssembliesOtherFm = new JournalAssembliesFm(userTasksDTO, false);
                    journalAssembliesOtherFm.Text = "Журнал реєстрації виробів (креслення замовника)";
                    journalAssembliesOtherFm.MdiParent = this;
                    journalAssembliesOtherFm.Show();
                    break;
                case "controlCheckJournalItem":
                    ControlCheckJournalFm controlCheckJournalFm = new ControlCheckJournalFm(userTasksDTO);
                    controlCheckJournalFm.Text = "Журнал приймально-сдавальних накладних";
                    controlCheckJournalFm.MdiParent = this;
                    controlCheckJournalFm.Show();
                    break;
                case "expendituresStorehouseItem":
                    StoreHouseProjectExpendituresFm storeHouseProjectExpendituresFm = new StoreHouseProjectExpendituresFm(userTasksDTO);
                    //StoreHouseProjectFm productionInvoicesFm = new StoreHouseProjectFm(userTasksDTO);
                    storeHouseProjectExpendituresFm.Text = "Списання (виробництво)";
                    storeHouseProjectExpendituresFm.MdiParent = this;
                    storeHouseProjectExpendituresFm.Show();
                    break;
                    
                    //accountingOrderCurrencyItem

                

                case "mtsSpecificationOldItem":
                    MtsSpecificationOldFm mtsSpecificationOldFm = new MtsSpecificationOldFm(userTasksDTO);
                    mtsSpecificationOldFm.Text = "Довідник матеріальних специфікацій";
                    mtsSpecificationOldFm.MdiParent = this;
                    mtsSpecificationOldFm.Show();
                    break;

                case "paintingWorksItem":
                    PaintingWorksFm paintingWorksFm = new PaintingWorksFm(userTasksDTO);
                    paintingWorksFm.Text = "Журнал малярних робіт";
                    paintingWorksFm.MdiParent = this;
                    paintingWorksFm.Show();
                    break;

                case "palitraItem":
                    PalitraFm palitraFm = new PalitraFm(userTasksDTO);
                    palitraFm.Text = "Палітра кольорів";
                    palitraFm.MdiParent = this;
                    palitraFm.Show();
                    break;

                case "converterItem":
                    ConverterFm converterFm = new ConverterFm(userTasksDTO);
                    converterFm.Text = "Конвертер";
                    converterFm.Show();
                    break;
                case "certificatePassItem":
                    CertificatePassFm certificatePassFm = new CertificatePassFm(userTasksDTO);
                    certificatePassFm.Text = "Сертифікати/паспорт";
                    certificatePassFm.MdiParent = this;
                    certificatePassFm.Show();
                    break;
                //кнопка для новых сертификатов;

                case "deliveryNameSubItem":
                    DeliveryFm deliveryNameFm = new DeliveryFm(userTasksDTO);
                    deliveryNameFm.Text = "Журнал перевізників";
                    deliveryNameFm.MdiParent = this;
                    deliveryNameFm.Show();
                    //кнопка для журнала перевозчиков;

                    break;

                case "logItem":

                    //кнопка для логера;
                    LogFm logFm= new LogFm(userTasksDTO);
                    logFm.Text = "Журнал п";
                    logFm.MdiParent = this;
                    logFm.Show();

                    break;




                default:
                    break;
            }

            menuNavPane.HideDropDownWindow();
        }
           
        private bool CheckAccess()
        {
            int num = GetActiveDirectoryUser();
            
            switch (num)
            {
                case -1:
                    
                    Load += (s, e) => Close();
                    return false;
                case 0:
                    MessageBox.Show("Інформація про користувача відсутня на сервері підприємства. \nЗверніться у відділ АСУВ", "Авторизація користувача", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    Load += (s, e) => Close();
                    return false;
                default:
                    userService = Program.kernel.Get<IUserService>();
             
                    SplashScreenManager.ShowForm(typeof(StartScreenFm));
                    SplashScreenManager.Default.SendCommand(StartScreenFm.SplashScreenCommand.SetLabel, "Авторизація користувача...");
                    Thread.Sleep(200);

                    if (userService.TryAuthorize(num))
                    {
                        //добавить трай-кач
                        SplashScreenManager.Default.SendCommand(StartScreenFm.SplashScreenCommand.SetLabel, "Користувач успішно авторизований \n(" + UserService.AuthorizatedUser.Fio + ")");
                        Thread.Sleep(200);
                        SplashScreenManager.Default.SendCommand(StartScreenFm.SplashScreenCommand.SetLabel, "Налаштування прав доступу...");
                        Thread.Sleep(200);
                        SplashScreenManager.CloseForm();
                        return true;
                    }
                    else
                    {
                        SplashScreenManager.CloseForm();
                        MessageBox.Show("Вам не дозволено працювати в системі. \nЗверніться у відділ АСУВ. \nВаш ідентифікатор "+ num, "Авторизація користувача", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Load += (s, e) => Close();
                        return false;
                    }
            }
        }
   
        private int GetActiveDirectoryUser()
        {
            // если нужно отключить систему авторизации через табельный номер подвязанный к домену
            // указываем табельный номер который нужно вернуть
            //return 690;
            var currentDomain = ADUser.CurrentDC();

            if (currentDomain != null)
            {
                var searchString = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                //Для тестирования чужой учетки на машине разработчика используем строку ниже, верхнюю нужно закоментить!!!
                //var searchString = "TVAGONM\\{учетка_пользователя}";
                //var searchString = "dc1.tvm.loc\\lagno";
                var member = searchString.Split('\\');
                var ulogin = member[1];
                var uDomen = member[0];

                var filter = string.Format("(&(ObjectClass={0})(sAMAccountName={1}))", "person", ulogin);
                var domain = uDomen;
                var properties = new[] { "fullname" };

                var adRoot = new DirectoryEntry("LDAP://" + domain, null, null, AuthenticationTypes.Secure);
                var searcher = new DirectorySearcher(adRoot)
                {
                    SearchScope = SearchScope.Subtree,
                    ReferralChasing = ReferralChasingOption.All
                };
                searcher.PropertiesToLoad.AddRange(properties);
                searcher.Filter = filter;
                var result = searcher.FindOne();
                var directoryEntry = result.GetDirectoryEntry();
                try
                {
                    var lastname = directoryEntry.Properties["sn"][0].ToString();
                    var firstname = directoryEntry.Properties["givenname"][0].ToString();
                    var tabnumber = directoryEntry.Properties["description"].Value.ToString();

                    if (ulogin == "pozyabin")
                        return 656;
                    if (ulogin == "kostirenko")
                        return 723;
                    if (ulogin == "asup")
                        return 690;


                    int userNumber;
                    bool isParse = int.TryParse(tabnumber, out userNumber);

                    return (isParse) ? userNumber : 0;
                }
                catch (Exception ex)
                {
                    if (ulogin == "krasilnikova")
                        return 844;
                    //if (ulogin == "zavorotniy")+
                    //    return 757;
                    //if (ulogin == "firsova")
                    //    return 784;
                    //else if (ulogin == "bibicheva")
                    //    return 802;
                    //else if (ulogin == "zaloilo")
                    //    return 804;А

                    MessageBox.Show("Вам не дозволено працювати в системі. \nПеревірте підключення до мережі або зверніться до адміністратора. \nПользователь: " + System.Security.Principal.WindowsIdentity.GetCurrent().Name, "Авторизація користувача", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return -1;
        }

        private void menuNavPane_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (e.Element is TileNavItem)
                menuNavPane.HideDropDownWindow();
        }

        private void MainTabFm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserOffline();
            foreach (string FileName in Directory.GetFiles(Utils.HomePath + @"\Temp\"))
            {
                try
                {
                   if (Path.GetFileName(FileName) != "Dummy.txt")
                        File.Delete(FileName);
                }
                catch { }
            }
            Application.Exit();
        }

        private void toolsBtn_ElementClick(object sender, NavElementEventArgs e)
        {
            UsersByRolesFm usersByRolesFm = new UsersByRolesFm();
            usersByRolesFm.ShowDialog();
            
            //refresh menu
            userService = Program.kernel.Get<IUserService>();
            userService.TryAuthorize(UserService.AuthorizatedUser.AccountNumber);

            UserAccessMenu();
        }

        //------------

        UserTasksDTO userTasksDTO;
        //-------------
        private void godModBtn_ElementClick(object sender, NavElementEventArgs e)
        {
            //ReportsFm re = new ReportsFm(userTasksDTO);
            //re.testChess();

            GodModeFm godModeFm = new GodModeFm();
            godModeFm.ShowDialog();

            //refresh menu
            userService = Program.kernel.Get<IUserService>();
            userService.TryAuthorize(UserService.AuthorizatedUser.AccountNumber);

            UserAccessMenu();
        }

        private void userFotoEdit_Click(object sender, EventArgs e)
        {
            UserSettingsFm userSettingsFm = new UserSettingsFm();
            userSettingsFm.ShowDialog();
        }
    }
}