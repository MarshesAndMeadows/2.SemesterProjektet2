using BusinessLogic.BusinessLogic;
using BusinessLogic.CRUD;
using Models;
using System.ComponentModel;
using UIModels;

namespace UserInterface.Forms
{
    public partial class CustomerOverview : Form
    {
        Form previousForm;
        CaseBL caseBL;
        UiCase selectedCase;
        UiClient currentClient;
        public CustomerOverview(UiClient currentClient, Form previousForm)
        {
            caseBL = new CaseBL();
            this.previousForm = previousForm;
            InitializeComponent();
            dgvCases.DataSource = InitializeDataAsync();
            selectedCase = new UiCase();
        }

        async Task<List<UiCase>> InitializeDataAsync()
        {
            List<UiCase> userCases = new List<UiCase>();
            userCases = await caseBL.GetAllAsync();
            return (List<UiCase>)userCases.Where(c => c.Client == currentClient);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            CustomerSpecificCases specificCaseOverview = new CustomerSpecificCases(this, selectedCase);
            this.Hide();
            specificCaseOverview.Show();
        }
    }
}
