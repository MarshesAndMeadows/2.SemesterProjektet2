using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIModels;

namespace UserInterface.Forms
{
    public partial class LawyerSpecificCaseOverview : Form
    {
        private Form previousForm;
        private UiCase selectedCase;
        private bool isEditingCase = false;
        private bool isEditingClient = false;
        private UiAppliedService selectedAppliedService;

        public LawyerSpecificCaseOverview(Form previousForm, UiCase uiCase)
        {
            this.selectedCase = uiCase; // working progress
            this.previousForm = previousForm;
            InitializeComponent();
            UpdateCaseInfo();
            UpdateClientInfo();
            LoadServicesToGridView();
        }


        private void UpdateCaseInfo()
        {
            txtBCaseName.Text = selectedCase.CaseName;
            txtBLawyerOnCase.Text = selectedCase.Employee.Firstname + " " + selectedCase.Employee.Lastname;
            txtBCaseStartDate.Text = selectedCase.StartDate.ToShortDateString();
            txtBCaseEndDate.Text = selectedCase.EstimatedEndDate.ToShortDateString();
            checkboxCasedClosed.Checked = selectedCase.CaseClosed;
            txtBCaseDescription.Text = selectedCase.CaseDescription;
        }

        private void UpdateClientInfo()
        {
            txtBClientName.Text = selectedCase.Client.Firstname + " " + selectedCase.Client.Lastname;
            txtBClientSex.Text = selectedCase.Client.Sex.ToString();
            txtBClientBirthdate.Text = selectedCase.Client.Birthday.ToShortDateString();
            txtBClientEmail.Text = selectedCase.Client.Email;
            txtBClientPhone.Text = selectedCase.Client.PhoneNumber;
            txtBClientAddress.Text = selectedCase.Client.Address;
            txtBClientZipcode.Text = "Coming Soon"; // <----------- Working progress
            checkboxClientSubscription.Checked = selectedCase.Client.Subscribed;
        }

        private void LoadServicesToGridView()
        {
            dgvService.DataSource = selectedCase.AppliedServices;
        }

        private void UpdateAppliedServiceNote()
        {
            txtBServiceNote.Text = selectedAppliedService.Note;
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
                    DialogResult result = MessageBox.Show("Vil du fortsætte uden at gemme dine ændringer?", "Bekræft handling", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChangesMadeClient())
            {
                DialogResult result = MessageBox.Show("Vil du gemme dine ændringer?", "Bekræft handling", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // UpdateUIClient(); kald til BusinessLogic <------------- Working progress
                    // 
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
            txtBClientName.ReadOnly = !isEditingClient;
            txtBClientSex.ReadOnly = !isEditingClient;
            txtBClientBirthdate.ReadOnly = !isEditingClient;
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
            if (txtBClientName.Text != selectedCase.Client.Firstname + " " + selectedCase.Client.Lastname ||
                txtBClientSex.Text != selectedCase.Client.Sex.ToString() ||
                txtBClientBirthdate.Text != selectedCase.Client.Birthday.ToShortDateString() ||
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

        // ---------------------------------------------------------------------------------------------------------------------
        // ------------------------------------------------- Cace panel --------------------------------------------------------
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
                    DialogResult result = MessageBox.Show("Vil du fortsætte uden at gemme dine ændringer?", "Bekræft handling", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        private void btnSaveCase_Click(object sender, EventArgs e)
        {
            if (ChangesMadeCase())
            {
                DialogResult result = MessageBox.Show("Vil du gemme dine ændringer?", "Bekræft handling", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // UpdateUICase(); kald til BusinessLogic <------------- Working progress
                    // 
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
            txtBLawyerOnCase.ReadOnly = !isEditingCase;
            txtBCaseStartDate.ReadOnly = !isEditingCase;
            txtBCaseEndDate.ReadOnly = !isEditingCase;
            checkboxCasedClosed.Enabled = !isEditingCase;
            txtBCaseDescription.ReadOnly = !isEditingCase;
            btnSaveCase.Visible = isEditingCase;

            if (isEditingCase)
            { btnEditCase.Text = "Close edit mode"; }
            else
            { btnEditCase.Text = "Edit Case"; }
        }

        private bool ChangesMadeCase()
        {
            if (txtBCaseName.Text != selectedCase.CaseName ||
                txtBLawyerOnCase.Text != selectedCase.Employee.Firstname + " " + selectedCase.Employee.Lastname ||
                txtBCaseStartDate.Text != selectedCase.StartDate.ToShortDateString() ||
                txtBCaseEndDate.Text != selectedCase.EstimatedEndDate.ToShortDateString() ||
                checkboxCasedClosed.Checked != selectedCase.CaseClosed ||
                txtBCaseDescription.Text != selectedCase.CaseDescription)
            {
                return true;
            }
            else return false;
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





        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

    }
}


