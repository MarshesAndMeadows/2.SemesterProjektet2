using BusinessLogic;
using UIModels;
using BusinessLogic.BusinessLogic;
using UserInterface.Forms.Helper;
using Controller;
using Models;

namespace UserInterface.Forms
{
    public partial class LawyerSpecificCaseOverview : Form
    {
        private Form previousForm;
        private UiCase selectedCase;
        private UiLawyer selectedLawyer;
        private bool isEditingCase = false;
        private bool isEditingClient = false;
        private UiAppliedService selectedAppliedService;
        private ErrorProvider errorProvider;
        private AppliedServiceBL appliedServiceBL;
        private List<UiAppliedService> appliedServices = new List<UiAppliedService>();
        private readonly Controllers controller;

        public LawyerSpecificCaseOverview(Form previousForm, UiCase uiCase)
        {
            InitializeComponent();
            this.selectedCase = uiCase;
            this.previousForm = previousForm;
            errorProvider = new ErrorProvider();
            this.controller = new Controllers();
            appliedServiceBL = new AppliedServiceBL();
            InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            UpdateCaseInfo();
            UpdateClientInfo();

            await GetAppliedServicesAndLoadToDataGridViewAsync();

            AttachClientEventHandlers();
            AttachCaseEventHandlers();
        }

        private void UpdateClientInfo()
        {
            txtBClientFirstname.Text = selectedCase.Client.Firstname;
            txtBClientLastname.Text = selectedCase.Client.Lastname;
            txtBClientSex.Text = selectedCase.Client.Sex.ToString();
            dtpBirthdate.Value = selectedCase.Client.Birthday;
            txtBClientEmail.Text = selectedCase.Client.Email;
            txtBClientPhone.Text = selectedCase.Client.PhoneNumber;
            txtBClientAddress.Text = selectedCase.Client.Address;
            txtBClientZipcode.Text = "Coming Soon";
            checkboxClientSubscription.Checked = selectedCase.Client.Subscribed;
        }

        private void AttachClientEventHandlers()
        {
            txtBClientFirstname.TextChanged += (s, e) => EnablebtnSaveClient();
            txtBClientLastname.TextChanged += (s, e) => EnablebtnSaveClient();
            txtBClientSex.TextChanged += (s, e) => EnablebtnSaveClient();
            txtBClientEmail.TextChanged += (s, e) => EnablebtnSaveClient();
            txtBClientPhone.TextChanged += (s, e) => EnablebtnSaveClient();
            txtBClientAddress.TextChanged += (s, e) => EnablebtnSaveClient();
        }

        private void UpdateCaseInfo()
        {
            txtBCaseName.Text = selectedCase.CaseName;
            txtBLawyerOnCase.Text = selectedCase.Employee.Firstname + " " + selectedCase.Employee.Lastname;
            dtpCaseStartDate.Value = selectedCase.StartDate;
            dtpCaseEndDate.Value = selectedCase.EstimatedEndDate;
            checkboxCasedClosed.Checked = selectedCase.CaseClosed;
            txtBCaseDescription.Text = selectedCase.CaseDescription;
        }

        private void AttachCaseEventHandlers()
        {
            txtBCaseName.TextChanged += (s, e) => EnablebtnSaveCase();
            txtBLawyerOnCase.TextChanged += (s, e) => EnablebtnSaveCase();
        }

        private async Task GetAppliedServicesAndLoadToDataGridViewAsync()
        {
            foreach (UiAppliedService service in selectedCase.AppliedServices)
            {
                UiAppliedService tempService = await controller.GetAppliedServiceAsync(service.Id);
                appliedServices.Add(tempService);
            }
            dgvService.DataSource = appliedServices;
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

        // ---------------------------------------------------------------------------------------------------------------------
        // ------------------------------------------------- Client info panel -------------------------------------------------
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (isEditingClient == false)
            {   // Aktivere edit mode.
                isEditingClient = true;
                ToggleEditModeClient();
            }
            else
            {
                if (ChangesMadeClient())
                {   // Brugeren har lavet ændringer i clienten.
                    DialogResult result = MessageBox.Show("Do you want to continue without saving your changes?", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {   // Brugeren har valgt at fortsætte uden at gemme, så oprindelige klientoplysninger gendannes.
                        UpdateClientInfo();
                        isEditingClient = false;
                        ToggleEditModeClient();
                    }
                    else return; // Brugeren vælger "nej" og returneres til edit mode
                } // Ingen ændringer, edit mode deaktiveres.
                isEditingClient = false;
                ToggleEditModeClient();
            }
        }
        private async void btnSaveClientAsync_Click(object sender, EventArgs e)
        {
            if (ChangesMadeClient())
            {
                DialogResult result = MessageBox.Show("Do you want to save your changes?", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Update the client information
                    UiClient updatedClient = new UiClient
                    {
                        Id = selectedCase.Client.Id,
                        Firstname = txtBClientFirstname.Text,
                        Lastname = txtBClientLastname.Text,
                        Sex = txtBClientSex.Text.First(),
                        Birthday = dtpBirthdate.Value,
                        Email = txtBClientEmail.Text,
                        PhoneNumber = txtBClientPhone.Text,
                        Address = txtBClientAddress.Text,
                        Subscribed = checkboxClientSubscription.Checked
                    };

                    bool updateSuccess = await controller.UpdateClientAsync(updatedClient);

                    if (updateSuccess)
                    {
                        MessageBox.Show("Client information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateClientInfo();
                        isEditingClient = false;
                        ToggleEditModeClient();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update client information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                isEditingClient = false;
                ToggleEditModeClient();
            }
        }

        private void ToggleEditModeClient()
        {
            txtBClientFirstname.ReadOnly = !isEditingClient;
            txtBClientLastname.ReadOnly = !isEditingClient;
            txtBClientSex.ReadOnly = !isEditingClient;
            dtpBirthdate.Enabled = isEditingClient;
            txtBClientEmail.ReadOnly = !isEditingClient;
            txtBClientPhone.ReadOnly = !isEditingClient;
            txtBClientAddress.ReadOnly = !isEditingClient;
            txtBClientZipcode.ReadOnly = !isEditingClient;
            checkboxClientSubscription.Enabled = isEditingClient;
            btnSaveClient.Visible = isEditingClient;

            if (isEditingClient)
            { btnEditClient.Text = "Close edit mode"; }
            else
            { btnEditClient.Text = "Edit Client"; }
        }

        private bool ChangesMadeClient()
        {
            // Langt if-statement som returner 'true', hvis der er ændringer.
            if (txtBClientFirstname.Text != selectedCase.Client.Firstname ||
                txtBClientLastname.Text != selectedCase.Client.Lastname ||
                txtBClientSex.Text != selectedCase.Client.Sex.ToString() ||
                dtpBirthdate.Value != selectedCase.Client.Birthday ||
                txtBClientEmail.Text != selectedCase.Client.Email ||
                txtBClientPhone.Text != selectedCase.Client.PhoneNumber ||
                txtBClientAddress.Text != selectedCase.Client.Address ||
                txtBClientZipcode.Text != "Coming Soon" ||
                checkboxClientSubscription.Checked != selectedCase.Client.Subscribed)
            {
                return true;
            }
            else return false;
        }

        private async void EnablebtnSaveClient()
        {
            bool isFirstname = false;
            bool isLastname = false;
            bool isSex = false;
            bool isEmail = false;
            bool isPhone = false;
            bool isAddress = false;

            if (!string.IsNullOrEmpty(txtBClientFirstname.Text))
            {
                isFirstname = await controller.ValidateFirstNameAsync(txtBClientFirstname.Text);
                ErrorProviderResponse(txtBClientFirstname, isFirstname, "Invalid name");
            }
            if (!string.IsNullOrEmpty(txtBClientLastname.Text))
            {
                isLastname = await controller.ValidateLastNameAsync(txtBClientLastname.Text);
                ErrorProviderResponse(txtBClientLastname, isLastname, "Invalid name");
            }
            if (!string.IsNullOrEmpty(txtBClientSex.Text))
            {
                isSex = await IsValidGenderInput(txtBClientSex.Text);
            }
            if (!string.IsNullOrEmpty(txtBClientEmail.Text))
            {
                isEmail = await controller.ValidateEmailAsync(txtBClientEmail.Text);
                ErrorProviderResponse(txtBClientEmail, isEmail, "Invalid email");
            }
            if (!string.IsNullOrEmpty(txtBClientPhone.Text))
            {
                isPhone = await controller.ValidatePhoneAsync(txtBClientPhone.Text);
                ErrorProviderResponse(txtBClientPhone, isPhone, "Invalid phone number");
            }
            if (!string.IsNullOrEmpty(txtBClientAddress.Text))
            {
                isAddress = await controller.ValidateAddressAsync(txtBClientAddress.Text);
                ErrorProviderResponse(txtBClientAddress, isAddress, "Invalid address");
            }

            btnSaveClient.Enabled = isFirstname && isLastname && isEmail && isPhone && isAddress;
        }

        public async Task<bool> IsValidGenderInput(string input)
        {
            if (input == "F" || input == "f" || input == "M" || input == "m")
            {
                return await Task.FromResult(true);
            }
            return await Task.FromResult(false);
        }

        // ---------------------------------------------------------------------------------------------------------------------
        // ------------------------------------------------- Case panel --------------------------------------------------------
        private void btnEditCase_Click(object sender, EventArgs e)
        {
            if (isEditingCase == false)
            {
                isEditingCase = true;
                ToggleEditModeCase();
            }
            else
            {
                if (ChangesMadeCase())
                {
                    DialogResult result = MessageBox.Show("Do you want to continue without saving your changes?", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        UpdateCaseInfo();
                        isEditingCase = false;
                        ToggleEditModeCase();
                    }
                    else return;
                }
                isEditingCase = false;
                ToggleEditModeCase();
            }
        }

        private async void btnSaveCaseAsync_Click(object sender, EventArgs e)
        {
            if (ChangesMadeCase())
            {
                DialogResult result = MessageBox.Show("Do you want to save your changes?", "Confirm action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    selectedCase.CaseName = txtBCaseName.Text;
                    selectedCase.StartDate = dtpCaseStartDate.Value;
                    selectedCase.EstimatedEndDate = dtpCaseEndDate.Value;
                    selectedCase.CaseDescription = txtBCaseDescription.Text;
                    selectedCase.CaseClosed = checkboxCasedClosed.Checked;
                    selectedCase.Employee = selectedLawyer;

                    bool updateSuccessful = await controller.UpdateCaseAsync(selectedCase);

                    if (updateSuccessful)
                    {
                        UpdateCaseInfo();
                        isEditingCase = false;
                        ToggleEditModeCase();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update case.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else return;
            }
            isEditingCase = false;
            ToggleEditModeCase();
        }

        private void ToggleEditModeCase()
        {
            txtBCaseName.ReadOnly = !isEditingCase;
            dtpCaseStartDate.Enabled = isEditingCase;
            dtpCaseEndDate.Enabled = isEditingCase;
            checkboxCasedClosed.Enabled = isEditingCase;
            txtBCaseDescription.ReadOnly = !isEditingCase;
            btnSaveCase.Visible = isEditingCase;
            btnChangeLawyer.Visible = isEditingCase;

            if (isEditingCase)
            { btnEditCase.Text = "Close edit mode"; }
            else
            { btnEditCase.Text = "Edit Case"; }
        }

        private bool ChangesMadeCase()
        {
            if (txtBCaseName.Text != selectedCase.CaseName ||
                txtBLawyerOnCase.Text != selectedCase.Employee.Firstname + " " + selectedCase.Employee.Lastname ||
                dtpCaseStartDate.Value != selectedCase.StartDate ||
                dtpCaseEndDate.Value != selectedCase.EstimatedEndDate ||
                checkboxCasedClosed.Checked != selectedCase.CaseClosed ||
                txtBCaseDescription.Text != selectedCase.CaseDescription)
            {
                return true;
            }
            else return false;
        }

        // Skift Lawyer
        private void btnChangeLawyer_Click(object sender, EventArgs e)
        {
            PickALawyer pickALawyer = new PickALawyer(this);
            pickALawyer.LawyerSelected += PickALawyer_LawyerSelected;
            selectedLawyer = pickALawyer.chosenLawyer;
            pickALawyer.Show();
        }

        private void PickALawyer_LawyerSelected(object? sender, Forms.LawyerSelectedEventArgs e)
        {
            selectedLawyer = e.SelectedLawyer;
            txtBLawyerOnCase.Text = $"{selectedLawyer.Firstname} {selectedLawyer.Lastname}";
        }

        private async void EnablebtnSaveCase()
        {
            bool isCaseName = false;

            if (!string.IsNullOrEmpty(txtBCaseName.Text))
            {
                isCaseName = true;
            }
            btnSaveCase.Enabled = isCaseName;
        }

        // ------------------------------------------------------------------------------------------------------------------------
        // ------------------------------------------------- Service panel --------------------------------------------------------

        private void dgvService_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvService.SelectedRows.Count == 1)
            {   // Sikre at der er én markeret række. Derefter gemmes rækken og 'DataBoundItem' returner rækken som et objekt.
                DataGridViewRow selectedRow = dgvService.SelectedRows[0];
                selectedAppliedService = (UiAppliedService)selectedRow.DataBoundItem;
                UpdateAppliedServiceNote();
            }
        }

        private void UpdateAppliedServiceNote()
        {
            txtBServiceNote.Text = selectedAppliedService.Note;
        }

        private void btnAddNewService_Click(object sender, EventArgs e)
        {
            LawyerAddService lawyerAddService = new LawyerAddService(this, selectedCase);
            lawyerAddService.Show();
        }

        // ------------------------------------------------------------------------------------------------------------------------

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


