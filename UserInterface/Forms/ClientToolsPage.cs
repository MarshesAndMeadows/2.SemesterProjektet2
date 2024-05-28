
namespace UserInterface.Forms
{
    public partial class ClientToolsPage : Form
    {
        Form previousPage;
        public ClientToolsPage(Form previousPage)
        {
            InitializeComponent();
            this.previousPage = previousPage;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousPage.Show();
        }

        private void ClientInterestCalculatorClick(object sender, EventArgs e)
        {
            ClientInterestCalculator interestCalculator = new ClientInterestCalculator(this);
            this.Hide();
            interestCalculator.Show();
        }
    }
}