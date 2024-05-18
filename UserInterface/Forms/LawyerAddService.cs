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
using BusinessLogic.CRUD;
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

        private BusinessLogic.CRUD.CaseBL caseBL;
        private UiAppliedService pendingAppliedService = new UiAppliedService();
        private BusinessLogic.BusinessLogic.ServiceBL serviceBL;
        private BusinessLogic.BusinessLogic.LawyerBL lawyerBL;
        private BusinessLogic.BusinessLogic.AppliedServiceBL appliedServiceBL;
        private ErrorProvider errorProvider;
        private Validation validator;

        public LawyerAddService(Form previousForm, UiCase uiCase)
        {
            this.relatedCase = uiCase;
            this.previousForm = previousForm;
            appliedServiceBL = new AppliedServiceBL();
            caseBL = new CaseBL();
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
        private async void cboxLawyerOnServiceAsync_MouseClick(object sender, MouseEventArgs e)
        {
            lawyerList = await lawyerBL.GetAllAsync();
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
                /*                relatedCase.AppliedServices.Add(appliedService); <-------- SQL DataAccess
                                await caseBL.CreateAsync(relatedCase);*/
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
            // bool isDate = false; <----- Working progress.
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
                isDoubleStartPayment = await validator.ValidateUserInputAsync("double", txtbStartPayment.Text);
                ErrorProviderResponse(txtbStartPayment, isDoubleStartPayment, "Invalid number"); // <---- Acceptere ikke "0". Men 'StartPayment må godt være 0!
            }
            if (!appliedService.Service.OneTimePayment)
            {
                if (!string.IsNullOrEmpty(txtbUnitCost.Text))
                {
                    isDoubleUnitCost = await validator.ValidateUserInputAsync("double", txtbUnitCost.Text);
                    ErrorProviderResponse(txtbUnitCost, isDoubleUnitCost, "Invalid number");
                }
                if (!string.IsNullOrEmpty(txtbUnitCount.Text))
                {
                    isInt = await validator.ValidateUserInputAsync("int", txtbUnitCount.Text);
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

        private void HelpIcon(object sender, EventArgs e)
        {
            HelpPage helpFunctionality = new HelpPage();
            helpFunctionality.LoadHelperContent(this);
        }
    }
}

