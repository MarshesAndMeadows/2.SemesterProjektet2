using UIModels;

namespace UserInterface.Forms
{
    public partial class ClientOverviewPage : Form
    {
        Form previousPage;
        UiClient loginClient;
        public ClientOverviewPage(Form previousForm, UiClient loginClient)
        {
            this.previousPage = previousForm;
            this.loginClient = loginClient;
            InitializeComponent();
            lblTitle.Text = $"Welcome {loginClient.Firstname}";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previousPage.Show();
            this.Close();
        }

        private void btnToolspage_Click(object sender, EventArgs e)
        {
            ClientToolsPage toolsPage = new ClientToolsPage(this);
            this.Hide();
            toolsPage.Show();
        }

        private void btnViewCases_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerOverview overview = new CustomerOverview(loginClient,this);
            overview.Show();
        }
    }
}