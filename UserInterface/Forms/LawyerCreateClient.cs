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
using BusinessLogic;
using BusinessLogic.BusinessLogic;
using UIModels;

namespace UserInterface.Forms
{
    public partial class LawyerCreateClient : Form
    {
        Form previousForm;
        private readonly BusinessLogic.Validation Validator;
        private readonly LawyerBL lawyerBL;
        private readonly ClientBL clientBL;


        public LawyerCreateClient(Form previousForm, LawyerBL lawyerbl, ClientBL clientbl)
        {
            this.lawyerBL = lawyerbl;
            this.clientBL = clientbl;
            this.previousForm = previousForm;
            InitializeComponent();
            Validator = new BusinessLogic.Validation();
        }

        private async void EnableChooseLawyerBtn()
        {
            bool isTxtFirstName = await Validator.ValidateUserInput("name", txtFirstName.Text);
            bool isTxLastName = await Validator.ValidateUserInput("name", txtLastName.Text);
            bool isTxtSex = await IsValidGenderInput(txtSex.Text);
            bool isTxtEmail = await Validator.ValidateUserInput("email", txtEmail.Text);
            bool isTxtPhone = await Validator.ValidateUserInput("phone", txtPhone.Text);
            bool isTxtAddress = await Validator.ValidateUserInput("address", txtAddress.Text);

            btnCreateClient.Enabled = isTxtFirstName && isTxLastName && isTxtSex && isTxtEmail && isTxtPhone && isTxtAddress;
        }

        public async Task<bool> IsValidGenderInput(string input)
        {
            if (input == "F" || input == "f" || input == "M" || input == "m")
            {
                return await Task.FromResult(true);
            }
            return await Task.FromResult(false);
        }

        private async void LawyerCreateClient_Load(object sender, EventArgs e)
        {
           UIModels.UiClient createClient = new UIModels.UiClient
           {
               Firstname = txtFirstName.Text,
               Lastname = txtLastName.Text,
               Sex = txtSex.Text[0],
               Email = txtEmail.Text,
               PhoneNumber = txtPhone.Text,
               Address = txtAddress.Text,
               Birthday = new DateTime(birthdayPicker.Text),
               
           }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        
    }
}
