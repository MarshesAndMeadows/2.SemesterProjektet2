using BusinessLogic.BusinessLogic;
using Controller;
using UIModels;

namespace UserInterface.Forms
{
    public partial class CustomerOverview : Form
    {
        Form previousForm;
        //CaseBL caseBL;
        UiCase selectedCase;
        UiClient currentClient;
        Controllers controller;

        public CustomerOverview(UiClient currentClient, Form previousForm)
        {
            InitializeComponent();
            //caseBL = new CaseBL();
            this.currentClient = currentClient;
            this.previousForm = previousForm;        
          
            selectedCase = new UiCase();
            controller = new Controllers();
            InitializeDataAsync();
        }
        async void InitializeDataAsync()
        {
            List<UiCase> userCases = await controller.GetAllCasesAsync();
            dgvCases.DataSource = userCases;
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
