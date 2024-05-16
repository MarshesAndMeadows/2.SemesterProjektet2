using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.BusinessLogic;
using Models;
using UIModels;
using UserInterface.Forms.Helper;

namespace UserInterface.Forms
{
    public partial class LawyerAddService : Form
    {
        private Form previousForm;
        private UiCase relatedCase;
        private List<UiService> serviceCatalog = new List<UiService>();
        private UiAppliedService pendingAppliedService = new UiAppliedService();
        private BusinessLogic.BusinessLogic.ServiceBL serviceBL;



        public LawyerAddService(Form previousForm, UiCase uiCase)
        {
            this.relatedCase = uiCase;
            this.previousForm = previousForm;
            serviceBL = new ServiceBL();
            InitializeComponent();
            InitializeAsync();
            toolTip1.SetToolTip(pictureBox1, "Click here for help");
        }

        private async Task InitializeAsync()
        {
            await LoadServiceCatalogAsync();
        }




        private async Task LoadServiceCatalogAsync()
        {
            serviceCatalog = await serviceBL.GetAllAsync();
            dgvServiceCatalog.DataSource = serviceCatalog;
        }

        public void LoadAppliedServiceData(UiService pickedService)
        {
            txtbSelectedService.Text = pickedService.ServiceName;
            dtpServicePreformed.Value = DateTime.Now;
            txtbStartPayment.Text = pickedService.StartPaymentDefault.ToString();
            checkBoxHaveUnitCost.Checked = pickedService.OneTimePayment;

            if (!pickedService.OneTimePayment)
            {
                txtbUnitCount.Visible = true;
                txtbUnitCost.Visible = true;
                lblUnitCount.Visible = true;
                lblUnitCost.Visible = true;
                txtbUnitCost.Text = pickedService.UnitCostDefault.ToString();
            }
            else
            {
                txtbUnitCount.Visible = false;
                txtbUnitCost.Visible = false;
                lblUnitCount.Visible = false;
                lblUnitCost.Visible = false;
            }
        }

        // datagridview: dgvDefaultServices


        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void dgvServiceCatalog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServiceCatalog.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgvServiceCatalog.SelectedRows[0];
                UiService tempService = (UiService)selectedRow.DataBoundItem;
                LoadAppliedServiceData(tempService);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            HelpFunctionality helpFunctionality = new HelpFunctionality();
            helpFunctionality.LoadHelperContent(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HelpFunctionality helpFunctionality = new HelpFunctionality();
            helpFunctionality.LoadHelperContent(this);
        }
    }
}
