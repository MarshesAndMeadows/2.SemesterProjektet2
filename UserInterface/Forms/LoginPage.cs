using UserInterface.Forms;

namespace UserInterface
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
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
            this.Close();
        }
    }
}