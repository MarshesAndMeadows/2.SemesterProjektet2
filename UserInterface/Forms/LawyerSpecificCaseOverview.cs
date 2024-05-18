using UIModels;
using Controller;

namespace UserInterface.Forms
{
    public partial class LawyerSpecificCaseOverview : Form
    {
        private Form previousForm;
        private UiCase selectedCase;
        private bool isEditingCase = false;
        private bool isEditingClient = false;
        private UiAppliedService selectedAppliedService;
        private ErrorProvider errorProvider;
        private List<UiAppliedService> appliedServices = new List<UiAppliedService>();
        private LawyerSpecificCaseOverviewController controller;


        public LawyerSpecificCaseOverview(Form previousForm, UiCase uiCase)
        {
            this.selectedCase = uiCase;
            this.previousForm = previousForm;
            errorProvider = new ErrorProvider();
            controller = new LawyerSpecificCaseOverviewController();
            InitializeComponent();
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
            txtBClientZipcode.Text = "Coming Soon"; // <----------- Working progress
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
            //txtBClientZipcode.TextChanged += (s, e) => EnablebtnSaveClient(); <----------- Working progress
            //txtBClientBirthdate.TextChanged += (s, e) => EnablebtnSaveClient(); <----------- Working progress
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
            //dtpCaseStartDate.ValueChanged += (s, e) => EnablebtnSaveCase(); <------------ Working progress
            //dtpCaseEndDate.ValueChanged += (s, e) => EnablebtnSaveCase(); <------------ Working progress
        }

        private async Task GetAppliedServicesAndLoadToDataGridViewAsync()
        {
            appliedServices = await controller.GetAppliedServicesAsync(selectedCase.AppliedServices);
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
                {   // Gemmer data i selectedCase og kalder efterfølgende 'Update'
                    selectedCase.Client.Firstname = txtBClientFirstname.Text;
                    selectedCase.Client.Lastname = txtBClientLastname.Text;
                    selectedCase.Client.Sex = txtBClientSex.Text.First();
                    selectedCase.Client.Birthday = dtpBirthdate.Value;
                    selectedCase.Client.Email = txtBClientEmail.Text;
                    selectedCase.Client.PhoneNumber = txtBClientPhone.Text;
                    selectedCase.Client.Address = txtBClientAddress.Text;
                    //selectedCase.Client.ZipCoce = txtBClientZipcode,Text; <------------ Working progress
                    selectedCase.Client.Subscribed = checkboxClientSubscription.Checked;

                    await controller.UpdateClientAsync(selectedCase.Client);
                    UpdateClientInfo();

                    isEditingClient = false;
                    ToggleEditModeClient();
                }
                else return;
            }
            isEditingClient = false;
            ToggleEditModeClient();
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
                dtpBirthdate.Value != selectedCase.Client.Birthday||
                txtBClientEmail.Text != selectedCase.Client.Email ||
                txtBClientPhone.Text != selectedCase.Client.PhoneNumber ||
                txtBClientAddress.Text != selectedCase.Client.Address ||
                txtBClientZipcode.Text != "Coming Soon" || // <----------- Working progress
                checkboxClientSubscription.Checked != selectedCase.Client.Subscribed)
            {
                return true;
            }
            else return false;
        }

        private async void EnablebtnSaveClient() // <------------- Async? Ja/nej? Skal valideringen være async?
        {
            bool isFirstname = false;
            bool isLastname = false;
            bool isSex = false;
            bool isEmail = false;
            bool isPhone = false;
            bool isAddress = false;
            // bool isBirthday = false; <------------ Working progress
            // bool isZipcode = false; <------------ Working progress


            if (!string.IsNullOrEmpty(txtBClientFirstname.Text))
            {
                isFirstname = await controller.ValidateUserInputAsync("name", txtBClientFirstname.Text);
                ErrorProviderResponse(txtBClientFirstname, isFirstname, "Invalid name");
            }
            if (!string.IsNullOrEmpty(txtBClientLastname.Text))
            {
                isLastname = await controller.ValidateUserInputAsync("name", txtBClientLastname.Text);
                ErrorProviderResponse(txtBClientLastname, isLastname, "Invalid name");
            }
            if (!string.IsNullOrEmpty(txtBClientSex.Text))
            {
                isSex = await controller.ValidateUserInputAsync("Sex", txtBClientSex.Text);
                ErrorProviderResponse(txtBClientSex, isSex, "Specify sex as 'F' or 'M'");
            }
            if (!string.IsNullOrEmpty(txtBClientEmail.Text))
            {
                isEmail = await controller.ValidateUserInputAsync("email", txtBClientEmail.Text);
                ErrorProviderResponse(txtBClientEmail, isEmail, "Invalid email");
            }
            if (!string.IsNullOrEmpty(txtBClientPhone.Text))
            {
                isPhone = await controller.ValidateUserInputAsync("phone", txtBClientPhone.Text);
                ErrorProviderResponse(txtBClientPhone, isPhone, "Invalid phone number");
            }
            if (!string.IsNullOrEmpty(txtBClientAddress.Text))
            {
                isAddress = await controller.ValidateUserInputAsync("address", txtBClientAddress.Text);
                ErrorProviderResponse(txtBClientAddress, isAddress, "Invalid address");
            }

            btnSaveClient.Enabled = isFirstname && isLastname && isSex && isEmail && isPhone && isAddress;
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

                    await controller.UpdateCaseAsync(selectedCase);
                    UpdateCaseInfo();

                    isEditingCase = false;
                    ToggleEditModeCase();
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

        private void btnChangeLawyer_Click(object sender, EventArgs e)
        {
            PickALawyer pickALawyer = new PickALawyer(this);
            pickALawyer.Show();
        }

        private async void EnablebtnSaveCase() // <------------- Async? Ja/nej? Skal valideringen være async?
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

    }
}


