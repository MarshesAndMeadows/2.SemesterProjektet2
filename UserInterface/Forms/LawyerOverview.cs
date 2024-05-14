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
using BusinessLogic.CRUD;
using UIModels;

namespace UserInterface.Forms
{
    public partial class LawyerOverview : Form
    {
        Form previousForm;
        CaseBL caseBL;
        List<UIModels.UiCase> caseList = new List<UIModels.UiCase>();
        UiCase selectedCase;

        public LawyerOverview(Form previousForm)
        {
            caseBL = new CaseBL();
            this.previousForm = previousForm;
            InitializeComponent();
            InitializeAsync();

        }
        private async void InitializeAsync()
        {
            caseList = await caseBL.GetAllAsync();
            dgvOverview.DataSource = caseList;
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




    }
}/*           if (dgvOverview.SelectedRows.Count == 1)
            {   // Sikre at der er én markeret række. Derefter gemmes rækken og 'DataBoundItem' returner rækken som et objekt.
                DataGridViewRow selectedRow = dgvOverview.SelectedRows[0];
                selectedCase = (UiCase)selectedRow.DataBoundItem;
            }*/