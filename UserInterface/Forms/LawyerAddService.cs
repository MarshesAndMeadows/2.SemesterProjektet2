using BusinessLogic;
using BusinessLogic.BusinessLogic;
using Controller;
using System.Runtime.CompilerServices;
using DataAccess;
using Models;
using UIModels;
using UserInterface.Forms.Helper;

namespace UserInterface.Forms
{
    public partial class LawyerAddService : Form
    {
        private Form previousForm;
        private UiCase relatedCase;
        private UiAppliedService appliedService = new UiAppliedService();
        private List<UiLawyer> lawyerList = new List<UiLawyer>();
        private List<UiService> serviceCatalog = new List<UiService>();
        Controllers controller;

        private UiAppliedService pendingAppliedService = new UiAppliedService();
        private ErrorProvider errorProvider;       

        public LawyerAddService(Form previousForm, UiCase uiCase)
        {
            InitializeComponent();
            controller = new Controllers();
            this.relatedCase = uiCase;
            this.previousForm = previousForm;           
            errorProvider = new ErrorProvider();                  
            InitializeAsync();           
        }

        private async Task InitializeAsync()
        {
            await LoadServiceCatalogAsync();
            AttachEventHandlers();
        }

        private async Task LoadServiceCatalogAsync()
        {
            serviceCatalog = await controller.GetAllServicesAsync();
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
        private async void cboxLawyerOnServiceAsync_MouseClick(object sender, MouseEventArgs e)
        {
            lawyerList = await controller.GetAllLawyersAsync();
            cboxLawyerOnService.DataSource = lawyerList;
        }

        private void cboxLawyerOnService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxLawyerOnService.SelectedItem != null)
            {
                appliedService.Lawyer = (UiLawyer)cboxLawyerOnService.SelectedItem;
            }
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
        private async void btnSaveAsync_Click(object sender, EventArgs e)
        {
            UpdateTxtBToAppliedService();
            DialogResult result = MessageBox.Show("Do you want to add this service to the case?", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await controller.CreateAppliedServiceAsync(appliedService, relatedCase.Id);
                this.Close();
            }
            else return;
        }

        public void UpdateTxtBToAppliedService() // Kaldes efter validering.
        {
            appliedService.ServicePerformed = dtpServicePreformed.Value;
            appliedService.Lawyer = (UiLawyer)cboxLawyerOnService.SelectedValue;
            appliedService.StartPaymentActual = double.Parse(txtbStartPayment.Text);
            appliedService.Note = txtbNote.Text;
            if (!appliedService.Service.OneTimePayment)
            {   // Hvis 'OneTimePayment' er false:
                appliedService.UnitCount = int.Parse(txtbUnitCount.Text);
                appliedService.UnitCostActual = double.Parse(txtbUnitCost.Text);
            }
            else
            {
                appliedService.UnitCount = 0;
                appliedService.UnitCostActual = 0;
            }
        }

        public async void EnablebtnAddServiceAsync()
        {
            bool isService = false;
            bool isLawyer = false;
            bool isDoubleStartPayment = false;
            bool isDoubleUnitCost = false;
            bool isInt = false;

            if (appliedService.Service != null)
            {
                isService = true;
            }
            if (appliedService.Lawyer != null)
            {
                isLawyer = true;
            }

            if (!string.IsNullOrEmpty(txtbStartPayment.Text))
            {
                isDoubleStartPayment = await controller.ValidateDoubleAsync(txtbStartPayment.Text);
                ErrorProviderResponse(txtbStartPayment, isDoubleStartPayment, "Invalid number");             
            }
            if (!appliedService.Service.OneTimePayment)
            {
                if (!string.IsNullOrEmpty(txtbUnitCost.Text))
                {
                    isDoubleUnitCost = await controller.ValidateDoubleAsync(txtbUnitCost.Text);
                    ErrorProviderResponse(txtbUnitCost, isDoubleUnitCost, "Invalid number");
                }
                if (!string.IsNullOrEmpty(txtbUnitCount.Text))
                {
                    isInt = await controller.ValidateIntAsync(txtbUnitCount.Text);
                    ErrorProviderResponse(txtbUnitCount, isInt, "Invalid number");
                }
                isDoubleStartPayment = true;
            }
            else
            {
                isDoubleUnitCost = true;
                isInt = true;
            }

            btnAddService.Enabled = isService && isLawyer && isDoubleStartPayment && isDoubleUnitCost && isInt;
        }

        private void AttachEventHandlers()
        {
            txtbStartPayment.TextChanged += (s, e) => EnablebtnAddServiceAsync();
            txtbUnitCost.TextChanged += (s, e) => EnablebtnAddServiceAsync();
            txtbUnitCount.TextChanged += (s, e) => EnablebtnAddServiceAsync();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void HelperIconClicked(object sender, EventArgs e)
        {
            HelpPage helpFunctionality = new HelpPage();
            helpFunctionality.LoadHelperContent(this);
        }
    }
}

