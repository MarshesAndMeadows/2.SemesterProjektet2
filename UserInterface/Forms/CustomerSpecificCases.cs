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
    public partial class CustomerSpecificCases : Form
    {
        Form previousForm;
        UiCase selectedCase;
        public CustomerSpecificCases(Form previousForm, UiCase uiCase)
        {
            
                this.selectedCase = uiCase;
                this.previousForm = previousForm;
                InitializeComponent();
        }
    }
}
