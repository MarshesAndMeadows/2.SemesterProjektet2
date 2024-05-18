using Controller;
using UserInterface.Forms;

namespace UserInterface
{
    public partial class LoginPage : Form
    {
        Controller.LoginController controller;

        //DatabaseManipMethods dbManip;
        //UIModels.DummyData dummyData;

        public LoginPage()
        {
            //dbManip = new DatabaseManipMethods();
            //dummyData = new UIModels.DummyData();
            controller = new Controller.LoginController();
            InitializeComponent();
        }       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                this.Hide();
                LawyerOverview overview = new LawyerOverview(this);
                overview.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                this.Hide();
                CustomerOverview  customerOverview = new CustomerOverview(this);
                customerOverview.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnResetDatabase_ClickAsync(object sender, EventArgs e)
        {
            bool resetSuccessful = await controller.ResetDatabaseAsync();
            if (resetSuccessful)
            {
                MessageBox.Show("Database reset!");
            }
            else
            {
                MessageBox.Show("Could not connect to database, check connection");
            }
        }
    }
}