using BusinessLogic.BusinessLogic;
using BusinessLogic.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.BusinessLogic;
using BusinessLogic.CRUD;
using UIModels;

namespace UserInterface.Forms
{
    public partial class CustomerOverview : Form
    {
        Form previousForm;
        CaseBL caseBL;
        UiCase selectedCase;
        public CustomerOverview(Form previousForm)
        {
            caseBL = new CaseBL();
            this.previousForm = previousForm;
            InitializeComponent();
            dgvCases.DataSource = caseBL.GetAllAsync();
            selectedCase = new UiCase();
        }
    }
}
