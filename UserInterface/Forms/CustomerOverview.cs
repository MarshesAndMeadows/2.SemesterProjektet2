using BusinessLogic.BusinessLogic;
using BusinessLogic.CRUD;
using UIModels;

namespace UserInterface.Forms
{
    public partial class CustomerOverview : Form
    {
        Form previousForm;
        CaseBL caseBL;
        UiCase selectedCase;
        public CustomerOverview(Form previousForm)
        {
            caseBL = new CaseBL();
            this.previousForm = previousForm;
            InitializeComponent();
            dgvCases.DataSource = caseBL.GetAllAsync();

            selectedCase = new UiCase();
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
