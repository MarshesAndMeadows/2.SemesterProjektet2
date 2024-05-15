using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Forms.Helper
{
    public partial class HelpForm : Form
    {
        Form previousForm;
        
        public HelpForm(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        public void SetHelpContent(string formName)
        {
            // Label 1-2 må ikke benyttes det er hardcoded overskrift og beskrielse
            switch (formName)
            {
                case "LawyerCreateClient":
                    label3.Text = "First name: Insert client firstname.";
                    label4.Text = "Last name: Insert client lastneme.";
                    label5.Text = "Sex: Indicate client sex by inserting 'F' female or 'M' male";
                    label6.Text = "Birthday: Choose client birthday, and Year";
                    label7.Text = "Email: Insert client email";
                    label8.Text = "Phone: Insert client phone";
                    label9.Text = "Address: Insert client official address";
                    label10.Text = "Select if client is subscriber or not";
                    label11.Text = "";
                    label12.Text = "If validation is OK, 'Create client' button is shown";
                    label13.Text = "To create client click 'Create client'";
                    break;
                case "CustomerOverview":
                    label1.Text = "This is the Customer Overview form.";

                    break;

                default:
                    label1.Text = "No formName received, what's the name of the form?";
                    break;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        
    }
}
