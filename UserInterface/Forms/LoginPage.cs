using BusinessLogic.DummyData;
using UserInterface.Forms;
using UserInterface.Forms.Helper;

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

        /*  private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
          {
              if (comboBox2.Text == "Frederik (bærbar)")
              {

              }
              if (comboBox2.Text == "Frederik(stationær)")
              {

              }
              if (comboBox2.Text == "Kasper")
              {

              }
              if (comboBox2.Text == "Michael (bærbar)")
              {

              }
              if (comboBox2.Text == "Michael (stationær)")
              {

              }
              if (comboBox2.Text == "Matias (bærbar)")
              {

              }
              if (comboBox2.Text == "Matias(stationær)")
              {

              }

          }*/

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
                CustomerOverview customerOverview = new CustomerOverview(this);
                customerOverview.Show();
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
            MessageBox.Show("Database reset!");
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            HelpFunctionality helpFunctionality = new HelpFunctionality();
            helpFunctionality.LoadHelperContent(this);
        }
    }
}