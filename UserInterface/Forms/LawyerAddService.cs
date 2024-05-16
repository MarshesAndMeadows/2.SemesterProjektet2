using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.BusinessLogic;
using Models;
using UIModels;

namespace UserInterface.Forms
{
    public partial class LawyerAddService : Form
    {
        private Form previousForm;
        private UiCase relatedCase;
        private UiAppliedService appliedService = new UiAppliedService();
        private List<UiLawyer> lawyerList = new List<UiLawyer>();
        private List<UiService> serviceCatalog = new List<UiService>();

        private UiAppliedService pendingAppliedService = new UiAppliedService();
        private BusinessLogic.BusinessLogic.ServiceBL serviceBL;
        private BusinessLogic.BusinessLogic.LawyerBL lawyerBL;
        private ErrorProvider errorProvider;
        private Validation validator;

        public LawyerAddService(Form previousForm, UiCase uiCase)
        {
            this.relatedCase = uiCase;
            this.previousForm = previousForm;
            validator = new Validation();
            errorProvider = new ErrorProvider();
            serviceBL = new ServiceBL();
            lawyerBL = new LawyerBL();
            InitializeComponent();
            InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            await LoadServiceCatalogAsync();
            AttachEventHandlers();
        }

        private async Task LoadServiceCatalogAsync()
        {
            serviceCatalog = await serviceBL.GetAllAsync();
            dgvServiceCatalog.DataSource = serviceCatalog;
        }

        private void ErrorProviderResponse(TextBox textbox, bool isValid, string errorMessage)
        {
            if (!isValid)
            {
                errorProvider.SetError(textbox, errorMessage);
            }
            else
            {
                errorProvider.SetError(textbox, "");
            }
        }

        // ---------------------------- Combo Box ------------------------------
        private async void cboxLawyerOnService_MouseClick(object sender, MouseEventArgs e)
        {
            lawyerList = await lawyerBL.GetAllAsync();
            cboxLawyerOnService.DataSource = lawyerList;
        }

        // ------------------------- DataGridView ----------------------------------
        private void dgvServiceCatalog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServiceCatalog.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgvServiceCatalog.SelectedRows[0];
                UiService tempService = (UiService)selectedRow.DataBoundItem;

                GetPickedServiceToTextBoxes(tempService);
                GetPickedServiceToAppliedService(tempService);
            }
        }

        public void GetPickedServiceToTextBoxes(UiService pickedService)
        {
            txtbSelectedService.Text = pickedService.ServiceName;
            txtbStartPayment.Text = pickedService.StartPaymentDefault.ToString();
            checkBoxHaveUnitCost.Checked = pickedService.OneTimePayment;
            if (!pickedService.OneTimePayment)
            {
                txtbUnitCount.Visible = true;
                txtbUnitCost.Visible = true;
                lblUnitCount.Visible = true;
                lblUnitCost.Visible = true;
                txtbUnitCost.Text = pickedService.UnitCostDefault.ToString();
            }
            else
            {
                txtbUnitCount.Visible = false;
                txtbUnitCost.Visible = false;
                lblUnitCount.Visible = false;
                lblUnitCost.Visible = false;
            }
        }

        public void GetPickedServiceToAppliedService(UiService pickedService)
        {
            appliedService.Service = pickedService;
            appliedService.StartPaymentActual = pickedService.StartPaymentDefault;
            appliedService.UnitCostActual = pickedService.UnitCostDefault;
        }





        // ------------------------ Add 'AppliedService' til Case -----------------
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        public void UpdateTxtBToAppliedService() // Kaldes efter validering.
        {
            appliedService.ServicePerformed = dtpServicePreformed.Value;
            appliedService.Lawyer = (UiLawyer)cboxLawyerOnService.SelectedValue;
            appliedService.StartPaymentActual = double.Parse(txtbStartPayment.Text);
            appliedService.Note = txtbNote.Text;
            if (!appliedService.Service.OneTimePayment)
            {
                appliedService.UnitCount = int.Parse(txtbUnitCount.Text);
                appliedService.UnitCostActual = double.Parse(txtbUnitCost.Text);
            }
        }

        public void EnablebtnAddService()
        {
            bool isService = false;
            bool isLawyer = false;
            bool isDate = false;
            bool isDouble = false;
            bool isInt = false;


        }

        private void AttachEventHandlers()
        {
            txtbStartPayment.TextChanged += (s, e) => EnablebtnAddService();
            txtbUnitCost.TextChanged += (s, e) => EnablebtnAddService();
            txtbUnitCount.TextChanged += (s, e) => EnablebtnAddService();
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }
    }
}
