using BusinessLogic.CRUD;
using System.ComponentModel;
using UIModels;
using BusinessLogic;
using System;
using System.Xml.Serialization;
using BusinessLogic.BusinessLogic;

namespace UserInterface.Forms
{
    public partial class LawyerCreateCase : Form
    {
        Form previousForm;
        List<UiLawyer> lawyerList;
        List<UiClient> clientList;
        CaseBL caseBL;
        ClientBL clientBL;
        LawyerBL lawyerBL;
        Validation v;
        UiLawyer selectedLawyer;
        public LawyerCreateCase(Form previousForm)
        {
            lawyerBL = new LawyerBL();
            clientBL = new ClientBL();
            caseBL = new CaseBL();

            this.previousForm = previousForm;
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            lawyerList = await lawyerBL.GetAllAsync();
            clientList = await clientBL.GetAllAsync();
            dgvClientDataGrid.DataSource = clientList;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private async void CaseName_Validating(object sender, CancelEventArgs e)
        {

            if (await v.ValidateUserInput("name", CaseNameTextBox.Text))
            {
                CreateCaseErrorProvider.Clear();
            }
            else
            {
                CreateCaseErrorProvider.SetError(CaseNameTextBox, "Inputs are invalid.");
                e.Cancel = true;
            }
        }
        private async void CaseDescription_Validating(object sender, CancelEventArgs e)
        {
            if (await v.ValidateUserInput("name", DescriptionTextBox.Text))
            {
                CreateCaseErrorProvider.Clear();
            }
            else
            {
                CreateCaseErrorProvider.SetError(DescriptionTextBox, "Inputs are invalid.");
                e.Cancel = true;
            }
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            if (true)
            {
                UiCase createdCase = new UiCase();
                createdCase.StartDate = DateTime.Parse(dateTimePicker1.Text);
                createdCase.EstimatedEndDate = DateTime.Parse(dateTimePicker2.Text);
                createdCase.CaseClosed = false;
                createdCase.CaseDescription = DescriptionTextBox.Text;
                createdCase.CaseName = CaseNameTextBox.Text;
                //createdCase.Client
                //createdCase.Employee = (UiEmployee)comboboxSelectLawyer.SelectedItem;
                createdCase.Employee = selectedLawyer;
                caseBL.CreateAsync(createdCase);
                MessageBox.Show("Case created successfully bozo");
            }
            else
            {
                MessageBox.Show("Failed to validate inputs.");
            }
        }
        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dgvClientDataGrid.SelectedRows.Count > 0)
            {
                // Retrieve the selected client from the selected row
                DataGridViewRow selectedRow = dgvClientDataGrid.SelectedRows[0];
                string clientFirstName = selectedRow.Cells["FirstName"].Value.ToString();
                string clientLastName = selectedRow.Cells["LastName"].Value.ToString();
                char clientSex = (char)selectedRow.Cells["Sex"].Value;
                DateTime clientBirthday = (DateTime)selectedRow.Cells["Birthday"].Value;
                string clientEmail = selectedRow.Cells["Email"].Value.ToString();
                string clientPhoneNumber = selectedRow.Cells["PhoneNumber"].Value.ToString();
                string clientAddress = selectedRow.Cells["Address"].Value.ToString();
                bool clientSubscribed = (bool)selectedRow.Cells["Subscribed"].Value;


                lblSelectedClient.Text = $"{clientFirstName} {clientLastName}";
            }
        }
        private void LawyerCreateCase_Load(object sender, EventArgs e)
        {

        }

        private void comboboxSelectLawyer_Format(object sender, ListControlConvertEventArgs e)
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
            UiLawyer selectedLawyer = e.SelectedLawyer;
            lblLawyerName.Text = $"{selectedLawyer.Firstname} {selectedLawyer.Lastname}";
        }

    }
    public class LawyerSelectedEventArgs : EventArgs
    {
        public UiLawyer SelectedLawyer { get; }

        public LawyerSelectedEventArgs(UiLawyer selectedLawyer)
        {
            SelectedLawyer = selectedLawyer;
        }
    }
}