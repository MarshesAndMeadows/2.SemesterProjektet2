using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIModels;

namespace UserInterface.Forms
{
    public partial class LawyerSpecificCaseOverview : Form
    {
        //UICase caseTilForm = new UICase();
        Form previousForm;
        new UIClient testClient;

        public LawyerSpecificCaseOverview(Form previousForm)
        {
            this.previousForm = previousForm;
            InitializeComponent();
            UICase testCase = new UICase
            {
                CaseId = 1,
                Name = "Legal Case",
                EstimatedEndDate = new DateOnly(2022, 12, 31),
                StartDate = new DateOnly(2022, 1, 1),
                CaseClosed = false,
                EmployeeId = 1,
                Employee = new UIEmployee
                {
                    EmployeeID = 1,
                    Firstname = "John",
                    Lastname = "Doe",
                    Sex = 'M',
                    Address = "123 Main St",
                    Workposition = "Lawyer",
                    DateHired = new DateOnly(2020, 1, 1),
                    Email = "john.doe@example.com",
                    Workphone = "555-1234",
                    Zipcode = 12345
                },
                ClientID = 1,
                Client = new UIClient
                {
                    ClientID = 1,
                    Firstname = "Big",
                    Lastname = "John",
                    Sex = 'M',
                    Age = 52,
                    EmailAddress = "BigJohn@Slangermail.com",
                    PhoneNumber = "88888888",
                    Address = "LongJohn road 69",
                    Subscribed = true,
                },
                Services = new List<UIService>()
                {
                    // Add 10 services
                    new UIService { ServiceId = 1, Name = "Legal Consultation", Description = "Initial consultation", OneTimePayment = true, StartPayment = 100, HourlyCost = 150, CaseID = 1 },
                    new UIService { ServiceId = 2, Name = "Contract Review", Description = "Review and analysis of contracts", OneTimePayment = true, StartPayment = 200, HourlyCost = 200, CaseID = 1 },
                    new UIService { ServiceId = 3, Name = "Litigation Support", Description = "Support for legal proceedings", OneTimePayment = false, StartPayment = 0, HourlyCost = 250, CaseID = 1 },
                    new UIService { ServiceId = 4, Name = "Legal Research", Description = "Conducting legal research", OneTimePayment = false, StartPayment = 0, HourlyCost = 180, CaseID = 1 },
                    new UIService { ServiceId = 5, Name = "Document Preparation", Description = "Preparation of legal documents", OneTimePayment = true, StartPayment = 300, HourlyCost = 0, CaseID = 1 },
                    new UIService { ServiceId = 6, Name = "Trial Representation", Description = "Representation during trials", OneTimePayment = false, StartPayment = 0, HourlyCost = 300, CaseID = 1 },
                    new UIService { ServiceId = 7, Name = "Mediation", Description = "Mediation services", OneTimePayment = true, StartPayment = 400, HourlyCost = 0, CaseID = 1 },
                    new UIService { ServiceId = 8, Name = "Appeals", Description = "Handling appeals", OneTimePayment = true, StartPayment = 500, HourlyCost = 0, CaseID = 1 },
                    new UIService { ServiceId = 9, Name = "Legal Advice", Description = "Providing legal advice", OneTimePayment = true, StartPayment = 200, HourlyCost = 0, CaseID = 1 },
                    new UIService { ServiceId = 10, Name = "Settlement Negotiations", Description = "Negotiating settlements", OneTimePayment = true, StartPayment = 600, HourlyCost = 0, CaseID = 1 }
                }
            };
            testClient = testCase.Client;
            lblCaseTitle.Text = testCase.Name;
            dgvServices.DataSource = testCase.Services;
            lblClientNameRight.Text = testCase.Client.Firstname;
            lblStartDateRight.Text = testCase.StartDate.ToString();
            lblEstimatedEndDateRight.Text = testCase.EstimatedEndDate.ToString();
            checkboxOngoing.Checked = testCase.CaseClosed;
            lblClientNameRight.Text = testClient.Firstname;
            lblClientNameRight.Text = testClient.Firstname + " " + testClient.Lastname;
            lblClientSexRight.Text = testClient.Sex.ToString();
            lblClientAgeRight.Text = testClient.Age.ToString();
            lblClientEmailRight.Text = testClient.EmailAddress;
            lblClientPhonenumberRight.Text = testClient.PhoneNumber;
            lblClientAddressRight.Text = testClient.Address;
            checkboxClientSubscription.Checked = testClient.Subscribed;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }
    }
}

