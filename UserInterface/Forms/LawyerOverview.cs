using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.BusinessLogic;
using BusinessLogic.CRUD;
using UIModels;

namespace UserInterface.Forms
{
    public partial class LawyerOverview : Form
    {
        Form previousForm;
        CaseBL caseBL;
        ClientBL clientBL;
        List<UiCase> caseList = new List<UiCase>();
        UiCase selectedCase;
        List<UiClient> clientList = new List<UiClient>();

        public LawyerOverview(Form previousForm)
        {
            caseBL = new CaseBL();
            clientBL = new ClientBL();
            this.previousForm = previousForm;
            InitializeComponent();
            InitializeAsync();

        }
        private async void InitializeAsync()
        {
            caseList = await caseBL.GetAllAsync();
            dgvOverview.DataSource = caseList;

            clientList = await clientBL.GetAllAsync();

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboboxSearchSelection.SelectedIndex)
            {
                case 0:
                    dgvOverview.DataSource = caseList;
                    break;

            }
        }
    }
}