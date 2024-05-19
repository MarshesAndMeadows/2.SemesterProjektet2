using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Forms
{
    public partial class ClientOverviewPage : Form
    {
        Form previousPage;
        public ClientOverviewPage(Form previousForm)
        {
            this.previousPage = previousForm;
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