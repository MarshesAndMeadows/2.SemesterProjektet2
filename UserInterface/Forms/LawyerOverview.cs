using BusinessLogic;
using BusinessLogic.BusinessLogic;
using UIModels;
using UserInterface.Forms.Helper;
using Controller;

namespace UserInterface.Forms
{
    public partial class LawyerOverview : Form
    {
        Form previousForm;
        //CaseBL caseBL;
        //ClientBL clientBL;
        List<UiCase> caseList = new List<UiCase>();
        List<UiClient> clientList = new List<UiClient>();
        UiCase selectedCase;
        UiClient selectedClient;
        private readonly Controllers controller;


        public LawyerOverview(Form previousForm)
        {
            //caseBL = new CaseBL();
            //clientBL = new ClientBL();
            this.previousForm = previousForm;
            InitializeComponent();
            this.controller = new Controllers();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void btnOpenCase_Click(object sender, EventArgs e)
        {
            LawyerSpecificCaseOverview specificCaseOverview = new LawyerSpecificCaseOverview(this, selectedCase);
            this.Hide();
            specificCaseOverview.Show();
        }

        private void dgvOverview_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOverview.SelectedRows.Count == 1)
            {   // Sikre at der er én markeret række. Derefter gemmes rækken og 'DataBoundItem' returner rækken som et objekt.
                DataGridViewRow selectedRow = dgvOverview.SelectedRows[0];
                selectedCase = (UiCase)selectedRow.DataBoundItem;
            }
            LawyerSpecificCaseOverview specificCaseOverview = new LawyerSpecificCaseOverview(this, selectedCase);
            this.Hide();
            specificCaseOverview.Show();
        }


        private void btnCreateCase_Click(object sender, EventArgs e)
        {
            LawyerCreateCase createCase = new LawyerCreateCase(this);
            this.Hide();
            createCase.Show();
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            LawyerCreateClient createClient = new LawyerCreateClient(this);
            this.Hide();
            createClient.Show();
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboboxSearchSelection.Text)
            {
                case "Cases":
                    caseList = await controller.GetAllCasesAsync();
                    dgvOverview.DataSource = uiCaseBindingSource2;
                    dgvOverview.DataSource = caseList;
                    break;
                case "Clients":
                    clientList = await controller.GetAllClientsAsync();
                    dgvOverview.DataSource = uiClientBindingSource;
                    dgvOverview.DataSource = clientList;
                    break;
                default:
                    dgvOverview.DataSource = null;
                    break;
            }
        }

        private void dgvOverview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboboxSearchSelection.Text == "Cases")
            {
                LawyerSpecificCaseOverview specificCaseOverview = new LawyerSpecificCaseOverview(this, selectedCase);
                this.Hide();
                specificCaseOverview.Show();
            }
            if (comboboxSearchSelection.Text == "Clients")
            {
                // (Form)ClientOverviewPage clientOverviewPage = new ClientOverviewPage(this, selectedClient);
            }
        }

        private async void dgvOverview_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOverview.SelectedRows.Count == 0)
            {
                return;
            }
            if (comboboxSearchSelection.Text == "Cases")
            {
                selectedCase = await controller.GetCaseAsync(Convert.ToInt32(dgvOverview.SelectedRows[0].Cells[0].Value));
            }
            if (comboboxSearchSelection.Text == "Clients")
            {
                selectedClient = await controller.GetClientAsync(Convert.ToInt32(dgvOverview.SelectedRows[0].Cells[0].Value));
            }
        }

        private void HelperIconClicked(object sender, EventArgs e)
        {
            HelpPage helpFunctionality = new HelpPage();
            helpFunctionality.LoadHelperContent(this);
        }
    }
}