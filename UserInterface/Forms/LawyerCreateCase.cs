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

        public LawyerCreateCase(Form previousForm)
        {
            lawyerBL = new LawyerBL();
            clientBL = new ClientBL();
            caseBL = new CaseBL();

            this.previousForm = previousForm;
            InitializeComponent();
            InitializeAsync();
            //lawyerList = dd.GetUIEmployeeListAsync();
            //clientList = dd.GetUIClientListAsync();

        }

        private async void InitializeAsync()
        {
            lawyerList = await lawyerBL.GetAllAsync();
            clientList = await clientBL.GetAllAsync();
            comboboxSelectLawyer.DataSource = lawyerList;
            ComboBoxClient.DataSource = clientList;
            dgvClientDataGrid.DataSource = clientList;
            dgvEmployeeDataGrid.DataSource = lawyerList;
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

        private void ComboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            void ClientValidating(object sender, CancelEventArgs e)
            {
                if (ComboBoxClient.SelectedItem != null)
                {
                    CreateCaseErrorProvider.Clear();
                }
                else
                {
                    CreateCaseErrorProvider.SetError(ComboBoxClient, "A Client must be selected.");
                    e.Cancel = true;
                }
            }

        }
        private void comboboxSelectLawyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            void LawyerValidating(object sender, CancelEventArgs e)
            {
                if (comboboxSelectLawyer.SelectedItem != null)
                {
                    CreateCaseErrorProvider.Clear();
                }
                else
                {
                    CreateCaseErrorProvider.SetError(comboboxSelectLawyer, "A Lawyer must be selected.");
                    e.Cancel = true;
                }
            }

        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                UiCase createdCase = new UiCase();
                createdCase.StartDate = DateTime.Parse(dateTimePicker1.Text);
                createdCase.EstimatedEndDate = DateTime.Parse(dateTimePicker2.Text);
                createdCase.CaseClosed = false;
                createdCase.CaseDescription = DescriptionTextBox.Text;
                createdCase.CaseName = CaseNameTextBox.Text;
                createdCase.Client = (UiClient)ComboBoxClient.SelectedItem;
                createdCase.Employee = (UiEmployee)comboboxSelectLawyer.SelectedItem;
                caseBL.CreateAsync(createdCase);
                MessageBox.Show("Case created successfully bozo");
            }
            else
            {
                MessageBox.Show("Failed to validate inputs.");
            }
        }
        private void LawyerCreateCase_Load(object sender, EventArgs e)
        {

        }

        private void ComboBoxClient_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is UiClient client)
            {
                e.Value = $"{client.Firstname} {client.Lastname}";
            }
        }

        private void comboboxSelectLawyer_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is UiLawyer lawyer)
            {
                e.Value = $"{lawyer.Firstname} {lawyer.Lastname}";
            }
        }
    }
}