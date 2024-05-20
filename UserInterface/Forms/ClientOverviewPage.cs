using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIModels;

namespace UserInterface.Forms
{
    public partial class ClientOverviewPage : Form
    {
        Form previousPage;
        UiClient loginClient;
        public ClientOverviewPage(Form previousForm, UiClient loginClient)
        {
            this.previousPage = previousForm;
            this.loginClient = loginClient;
            lblTitle.Text = $"Welcome {loginClient.Firstname}";
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previousPage.Show();
            this.Close();
        }

        private void btnToolspage_Click(object sender, EventArgs e)
        {
            ClientToolsPage toolsPage = new ClientToolsPage(this);
            this.Hide();
            toolsPage.Show();
        }
    }
}