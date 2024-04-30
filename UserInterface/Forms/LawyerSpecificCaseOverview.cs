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
    public partial class LawyerSpecificCaseOverview : Form
    {
        UICase caseTilForm = new UICase();
        public LawyerSpecificCaseOverview()
        {
            InitializeComponent();
            caseTilForm.Name = "Casen har et navn";
            lblCaseTitle.Text = caseTilForm.Name;
        }
    }
}
