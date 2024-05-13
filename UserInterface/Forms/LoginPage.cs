using BusinessLogic.DummyData;
using UserInterface.Forms;

namespace UserInterface
{
    public partial class LoginPage : Form
    {
        DatabaseManipMethods dbManip;
        UIModels.DummyData dummyData;
        public LoginPage()
        {
            //comboBox2.SelectedIndex = 0;
            dbManip = new DatabaseManipMethods();
            dummyData = new UIModels.DummyData();
            
            InitializeComponent();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Frederik (b�rbar)")
            {

            }
            if (comboBox2.Text == "Frederik(station�r)")
            {

            }
            if (comboBox2.Text == "Kasper")
            {

            }
            if (comboBox2.Text == "Michael (b�rbar)")
            {

            }
            if (comboBox2.Text == "Michael (station�r)")
            {

            }
            if (comboBox2.Text == "Matias (b�rbar)")
            {

            }
            if (comboBox2.Text == "Matias(station�r)")
            {

            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                this.Hide();
                LawyerOverview overview = new LawyerOverview(this);
                overview.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnResetDatabase_ClickAsync(object sender, EventArgs e)
        {

            await dbManip.ClearAllDataAsync();
            dbManip.CreateAllDataAsync();
            MessageBox.Show("Database (hopefully) reset correctly!");
        }



    }
}