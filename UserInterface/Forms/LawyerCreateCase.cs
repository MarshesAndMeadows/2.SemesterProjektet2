using BusinessLogic.CRUD;
using System.ComponentModel;
using UIModels;
using BusinessLogic;
using System;


namespace UserInterface.Forms
{
    public partial class LawyerCreateCase : Form
    {
        DummyData dd;
        Form previousForm;
        List<UiEmployee> employeeList;
        List<UiClient> clientList;
        CaseBL Casebl;
        Validation v;

        public LawyerCreateCase(Form previousForm)
        {
            this.previousForm = previousForm;
            InitializeComponent();
            employeeList = dd.GetUIEmployeeListAsync();
            clientList = dd.GetUIClientListAsync();
            comboboxSelectLawyer.DataSource = employeeList;
            ComboBoxClient.DataSource = clientList;
            ClientDataGrid.DataSource = clientList;
            EmployeeDataGrid.DataSource = employeeList;
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

                //optional switch to using datagridview for selection (seems pointless tho)

                //DataGridViewRow clientRow = ClientDataGrid.SelectedRows[0];
                //DataGridViewRow lawyerRow = EmployeeDataGrid.SelectedRows[0];
                //createdCase.Client = (UiClient)clientRow.DataBoundItem;
                //createdCase.Employee = (UiEmployee)lawyerRow.DataBoundItem;

                Casebl.CreateAsync(createdCase);
            }
            else
            {
                MessageBox.Show("Failed to validate inputs.");
            }
        }
        private void LawyerCreateCase_Load(object sender, EventArgs e)
        {

        }
    }
}