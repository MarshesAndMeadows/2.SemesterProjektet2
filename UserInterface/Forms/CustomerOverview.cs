using BusinessLogic.BusinessLogic;
using BusinessLogic.CRUD;
using UIModels;

namespace UserInterface.Forms
{
    public partial class CustomerOverview : Form
    {
        Form previousForm;
        CaseBL caseBL;
        ClientBL clientBL;
        UiCase selectedCase;
        List<UiCase> cases;
        public CustomerOverview(Form previousForm)
        {
            caseBL = new CaseBL();
            clientBL = new ClientBL();
            this.previousForm = previousForm;
            InitializeComponent();
            InitializeComponentAsync();
            selectedCase = new UiCase();
        }
        async void InitializeComponentAsync()
        {
            this.cases = await caseBL.GetAllAsync();
            comboSelectedClient.DataSource = await clientBL.GetAllAsync();
            comboSelectedClient.DisplayMember = "Firstname";
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

        private void comboSelectedClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvCases.DataSource = cases.Where(c => c.Client == comboSelectedClient.SelectedItem);
        }
    }
}