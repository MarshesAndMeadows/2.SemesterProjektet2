using UIModels;
using BusinessLogic;
using BusinessLogic.BusinessLogic;
using UserInterface.Forms.Helper;
using Controller;

namespace UserInterface.Forms
{
    public partial class LawyerCreateCase : Form
    {
        Form previousForm;
        List<UiLawyer> lawyerList;
        List<UiClient> clientList;
        /*CaseBL caseBL;
        ClientBL clientBL;
        LawyerBL lawyerBL;*/
        UiLawyer selectedLawyer;
        UiClient selectedClient = new UiClient();
        bool nameValid = false;
        bool descValid = false;
        private readonly Controllers controller;

        public LawyerCreateCase(Form previousForm)
        {
            /*lawyerBL = new LawyerBL();
            clientBL = new ClientBL();
            caseBL = new CaseBL();*/
            controller = new Controllers();

            this.previousForm = previousForm;
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            lawyerList = await controller.GetAllLawyersAsync();
            clientList = await controller.GetAllClientsAsync();
            dgvClientDataGrid.DataSource = clientList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        /* private void Createbtn_Click(object sender, EventArgs e)
         {
             if (UserInputsAreValid())
             {
                 UiCase createdCase = new UiCase();
                 createdCase.StartDate = DateTime.Parse(dateTimePicker1.Text);
                 createdCase.EstimatedEndDate = DateTime.Parse(dateTimePicker2.Text);
                 createdCase.CaseClosed = false;
                 createdCase.CaseDescription = DescriptionTextBox.Text;
                 createdCase.CaseName = CaseNameTextBox.Text;
                 createdCase.Client = selectedClient;
                 createdCase.Employee = selectedLawyer;
                 caseBL.CreateAsync(createdCase);
                 MessageBox.Show("Case created successfully bozo");
             }
             else
             {
                 MessageBox.Show("Failed to validate inputs.");
             }
         }*/
        private async void Createbtn_Click(object sender, EventArgs e)
        {
            if (UserInputsAreValid())
            {
                UiCase createdCase = new UiCase
                {
                    StartDate = DateTime.Parse(dateTimePicker1.Text),
                    EstimatedEndDate = DateTime.Parse(dateTimePicker2.Text),
                    CaseClosed = false,
                    CaseDescription = DescriptionTextBox.Text,
                    CaseName = CaseNameTextBox.Text,
                    Client = selectedClient,
                    Employee = selectedLawyer
                };

                // Create the case using the controller method
                bool success = await controller.CreateCaseAsync(createdCase);

                if (success)
                {
                    MessageBox.Show("Case created successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to create case.");
                }
            }
            else
            {
                MessageBox.Show("Failed to validate inputs.");
            }
        }


        private void dgvClients_SelectionChanged(object sender, EventArgs e) // <---- 0 referencer????
        {
            // Check if any row is selected
            if (dgvClientDataGrid.SelectedRows.Count > 0)
            {
                // Retrieve the selected client from the selected row
                DataGridViewRow selectedRow = dgvClientDataGrid.SelectedRows[0];
                selectedClient.Firstname = selectedRow.Cells["FirstName"].Value.ToString();
                selectedClient.Lastname = selectedRow.Cells["LastName"].Value.ToString();
                selectedClient.Sex = (char)selectedRow.Cells["Sex"].Value;
                selectedClient.Birthday = (DateTime)selectedRow.Cells["Birthday"].Value;
                selectedClient.Email = selectedRow.Cells["Email"].Value.ToString();
                selectedClient.PhoneNumber = selectedRow.Cells["PhoneNumber"].Value.ToString();
                selectedClient.Address = selectedRow.Cells["Address"].Value.ToString();
                selectedClient.Subscribed = (bool)selectedRow.Cells["Subscribed"].Value;

                lblSelectedClient.Text = $"{selectedClient.Firstname} {selectedClient.Lastname}";
            }
        }
        
        private void comboboxSelectLawyer_Format(object sender, ListControlConvertEventArgs e) // <---- 0 referencer????
        {
            if (e.ListItem is UiLawyer lawyer)
            {
                e.Value = $"{lawyer.Firstname} {lawyer.Lastname}";
            }
        }
        private void btnSelectLawyer_Click(object sender, EventArgs e)
        {
            PickALawyer lawyerForm = new PickALawyer(this);
            lawyerForm.LawyerSelected += PickALawyer_LawyerSelected;
            selectedLawyer = lawyerForm.chosenLawyer;

            lawyerForm.Show();
        }
        private void PickALawyer_LawyerSelected(object sender, LawyerSelectedEventArgs e)
        {
            selectedLawyer = e.SelectedLawyer;
            lblLawyerName.Text = $"{selectedLawyer.Firstname} {selectedLawyer.Lastname}";
        }
        private void CaseNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CaseNameTextBox.Text != string.Empty)
            {
                CreateCaseErrorProvider.SetError(CaseNameTextBox, string.Empty);
                nameValid = true;

            }
            else
            {
                CreateCaseErrorProvider.SetError(CaseNameTextBox, "Inputs are invalid.");
                nameValid = false;
            }
        }
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DescriptionTextBox.Text != string.Empty)
            {
                CreateCaseErrorProvider.SetError(DescriptionTextBox, string.Empty);
                descValid = true;
            }
            else
            {
                CreateCaseErrorProvider.SetError(DescriptionTextBox, "Inputs are invalid.");
                descValid = false;
            }
        }
        private bool UserInputsAreValid()
        {
            if (nameValid && descValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private async void dgvClientDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedClient = await controller.GetClientAsync(Convert.ToInt32(dgvClientDataGrid.SelectedRows[0].Cells[0].Value));
            lblSelectedClient.Text = $"{selectedClient.Firstname} {selectedClient.Lastname}";
        }

        private void HelpIconClick(object sender, EventArgs e)
        {
            HelpPage helpFunctionality = new HelpPage();
            helpFunctionality.LoadHelperContent(this);
        }
    }
    public class LawyerSelectedEventArgs : EventArgs // <--------- Er du placeret korrekt?
    {
        public UiLawyer SelectedLawyer { get; }
        public LawyerSelectedEventArgs(UiLawyer selectedLawyer)
        {
            SelectedLawyer = selectedLawyer;
        }
    }
}