using BusinessLogic.BusinessLogic;
using BusinessLogic.DummyData;
using UIModels;
using UserInterface.Forms;
using UserInterface.Forms.Helper;
using Controller;

namespace UserInterface
{
    public partial class LoginPage : Form
    {      
        DatabaseManipMethods dbManip;
        UIModels.DummyData dummyData;
        UiClient chosenClient;
        private readonly Controllers controller;
        public LoginPage()
        {
            InitializeComponent();
            controller = new Controllers();           
            dbManip = new DatabaseManipMethods();
            dummyData = new UIModels.DummyData();           
            InitializeAsync();
        }

        private async void InitializeAsync()
        {           
            var clients = await controller.GetAllClientsAsync();
            comboboxSelectClient.DataSource = clients;
            comboboxSelectClient.DisplayMember = "Firstname";
            comboboxSelectClient.ValueMember = "Id";
            comboboxSelectClient.Format += ComboboxSelectClient_Format;
        }

        private void ComboboxSelectClient_Format(object sender, ListControlConvertEventArgs e)
        {
            UiClient client = (UiClient)e.ListItem;
            e.Value = $"{client.Firstname} {client.Lastname}";
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
                ClientOverviewPage clientOverviewPage = new ClientOverviewPage(this, chosenClient);
                clientOverviewPage.Show();
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

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                comboboxSelectClient.Visible = true;
                chosenClient = (UiClient)comboboxSelectClient.SelectedItem;

            }
            if (comboBox1.SelectedIndex == 0)
            {
                comboboxSelectClient.Visible = false;
            }
        }

        private void comboboxSelectClient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            chosenClient = (UiClient)comboboxSelectClient.SelectedItem;
        }

        private void HelpIconClicked(object sender, EventArgs e)
        {
            HelpPage helpFunctionality = new HelpPage();
            helpFunctionality.LoadHelperContent(this);
        }
    }
}