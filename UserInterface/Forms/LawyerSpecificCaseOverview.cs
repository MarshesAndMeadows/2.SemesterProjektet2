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
        new UiClient testClient;

        public LawyerSpecificCaseOverview(Form previousForm)
        {
            this.previousForm = previousForm;
            InitializeComponent();
            UiClient testClient = new UiClient
            {
                Firstname = "John",
                Lastname = "Doe",
                Sex = 'M',
                Birthday = new DateTime(1980, 1, 1),
                Email = "john.doe@example.com",
                PhoneNumber = "123456789",
                Address = "123 Main St",
                Subscribed = true
            };

            // Create a dummy employee
            UiEmployee employee = new UiEmployee
            {
                Firstname = "Jane",
                Lastname = "Smith",
                Sex = 'F',
                WorkPosition = "Lawyer",
                DateHired = new DateTime(2015, 1, 1),
                Email = "jane.smith@example.com",
                WorkPhone = "987654321"
            };

            // Create a dummy case
            UiCase dummyCase = new UiCase
            {
                CaseName = "Dummy Case",
                EstimatedEndDate = DateTime.Now.AddDays(30),
                StartDate = DateTime.Now,
                CaseClosed = false,
                Client = testClient,
                Employee = employee,
                AppliedServices = new List<UiAppliedService>()
            };

            // Create 10 dummy applied services
            for (int i = 1; i <= 10; i++)
            {
                UiAppliedService appliedService = new UiAppliedService
                {
                    Note = $"Applied Service {i}",
                    UnitCount = i,
                    UnitCostActual = 100.00 + i * 10,
                    StartPaymentActual = 50.00 + i * 5,
                    ServicePerformed = DateTime.Now.AddDays(-i),
                    Service = new UiService
                    {
                        ServiceName = $"Service {i}",
                        Description = $"Description of Service {i}",
                        OneTimePayment = i % 2 == 0,
                        StartPaymentDefault = 100.00,
                        UnitCostDefault = 50.00
                    }
                };

                dummyCase.AppliedServices.Add(appliedService);
            }
            testClient = new UiClient
            {
                Firstname = "John",
                Lastname = "Doe",
                Sex = 'M',
                Birthday = new DateTime(1980, 1, 1),
                Email = "john.doe@example.com",
                PhoneNumber = "123456789",
                Address = "123 Main St",
                Subscribed = true
            };

            // Create a dummy employee
            UiEmployee testEmployee = new UiEmployee
            {
                Firstname = "Jane",
                Lastname = "Smith",
                Sex = 'F',
                WorkPosition = "Lawyer",
                DateHired = new DateTime(2015, 1, 1),
                Email = "jane.smith@example.com",
                WorkPhone = "987654321"
            };

            // Create a dummy case
            UiCase testCase = new UiCase
            {
                CaseName = "Dummy Case",
                EstimatedEndDate = DateTime.Now.AddDays(30),
                StartDate = DateTime.Now,
                CaseClosed = false,
                Client = testClient,
                Employee = testEmployee,
                AppliedServices = new List<UiAppliedService>()
            };

            // Create 10 dummy applied services
            for (int i = 1; i <= 10; i++)
            {
                UiAppliedService appliedService = new UiAppliedService
                {
                    Note = $"Applied Service {i}",
                    UnitCount = i,
                    UnitCostActual = 100.00 + i * 10,
                    StartPaymentActual = 50.00 + i * 5,
                    ServicePerformed = DateTime.Now.AddDays(-i),
                    Service = new UiService
                    {
                        ServiceName = $"Service {i}",
                        Description = $"Description of Service {i}",
                        OneTimePayment = i % 2 == 0,
                        StartPaymentDefault = 100.00,
                        UnitCostDefault = 50.00
                    }
                };

                testCase.AppliedServices.Add(appliedService);
            }
            this.testClient = testCase.Client;
            lblCaseTitle.Text = testCase.CaseName;
            dgvServices.DataSource = testCase.AppliedServices;
            lblClientNameRight.Text = testCase.Client.Firstname;
            lblStartDateRight.Text = testCase.StartDate.ToString();
            lblEstimatedEndDateRight.Text = testCase.EstimatedEndDate.ToString();
            checkboxOngoing.Checked = testCase.CaseClosed;
            lblClientNameRight.Text = this.testClient.Firstname;
            lblClientNameRight.Text = this.testClient.Firstname + " " + this.testClient.Lastname;
            lblClientSexRight.Text = this.testClient.Sex.ToString();
            //lblClientAgeRight.Text = testClient.Age.ToString();
            lblClientEmailRight.Text = this.testClient.Email;
            lblClientPhonenumberRight.Text = this.testClient.PhoneNumber;
            lblClientAddressRight.Text = this.testClient.Address;
            checkboxClientSubscription.Checked = this.testClient.Subscribed;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }
    }
}

