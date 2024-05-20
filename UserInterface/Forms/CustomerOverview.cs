using BusinessLogic.BusinessLogic;
using BusinessLogic;
using Models;
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
            this.currentClient = currentClient;
            this.previousForm = previousForm;
            InitializeComponent();
            InitializeDataAsync();
            selectedCase = new UiCase();
        }
        async void InitializeDataAsync()
        {
            List<UiCase> userCases = new List<UiCase>();
            userCases = await caseBL.GetAllAsync();
            dgvCases.DataSource = userCases.Where(c => c.Client.Id == currentClient.Id).ToList();
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
