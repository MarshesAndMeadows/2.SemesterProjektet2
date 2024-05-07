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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace UserInterface.Forms
{
    public partial class LawyerCreateClient : Form
    {
        Form previousForm;
        private readonly BusinessLogic.Validation validator;


        public LawyerCreateClient(Form previousForm)
        {
           
            this.previousForm = previousForm;
            InitializeComponent();
            validator = new BusinessLogic.Validation();           
        }

       

        private async void EnableChooseLawyerBtn()
        {
            bool isTxtFirstName = await validator.ValidateUserInput("name", txtFirstName.Text);
            bool isTxLastName = await validator.ValidateUserInput("name", txtLastName.Text); 
            bool isTxtEmail = await validator.ValidateUserInput("email", txtEmail.Text);
            bool isTxtPhone = await validator.ValidateUserInput("phone", txtPhone.Text);
            bool isTxtAdress = await validator.ValidateUserInput("address", txtAddress.Text);

            btnContinue.Enabled = isTxtFirstName && isTxLastName && isTxtEmail && isTxtPhone && isTxtAdress;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }
        
    }
}
