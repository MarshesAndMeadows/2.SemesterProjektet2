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
using UIModels;

namespace UserInterface.Forms
{
    public partial class LawyerOverview : Form
    {
        Form previousForm;
        // ----------- Working progress... --------------------
        UiCase selectedCase;
        // ------------------------------------------------

        public LawyerOverview() // LawyerOverview(Form previousForm) ---------- Skal ændres i Master
        {
            // ----------- Working progress... --------------
            DummyData dd = new DummyData();
            selectedCase = dd.GetUICaseAsync(5);
            // ------------------------------------------------
            this.previousForm = previousForm;
            InitializeComponent();
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
    }
}