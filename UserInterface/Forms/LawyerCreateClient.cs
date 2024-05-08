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
        private bool checkBoxState;


        public LawyerCreateClient(Form previousForm, LawyerBL lawyerbl, ClientBL clientbl)
        {
            InitializeComponent();
            this.lawyerBL = lawyerbl;
            this.clientBL = clientbl;
            this.previousForm = previousForm;
            Validator = new BusinessLogic.Validation();
            checkBoxYes.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            checkBoxNo.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
        }

        private void CheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox == checkBoxYes)
            {
                checkBoxNo.Checked = !checkBoxYes.Checked;
            }
            else if (checkBox == checkBoxNo)
            {
                checkBoxYes.Checked = !checkBoxNo.Checked;
            }
            checkBoxState = checkBoxYes.Checked;       
        }

        private async void EnableChooseLawyerBtn()
        {
            bool isTxtFirstName = await Validator.ValidateUserInput("name", txtFirstName.Text);
            bool isTxLastName = await Validator.ValidateUserInput("name", txtLastName.Text);
            bool isTxtSex = await IsValidGenderInput(txtSex.Text);
            bool isTxtEmail = await Validator.ValidateUserInput("email", txtEmail.Text);
            bool isTxtPhone = await Validator.ValidateUserInput("phone", txtPhone.Text);
            bool isTxtAddress = await Validator.ValidateUserInput("address", txtAddress.Text);

            btnCreateClient.Visible = isTxtFirstName && isTxLastName && isTxtSex && isTxtEmail && isTxtPhone && isTxtAddress;
            btnCreateClient.Enabled = true;
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
                Birthday = DateTime.Parse(birthdayPicker.Text),
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text,
                Address = txtAddress.Text,
                Subscribed = checkBoxState
            };

            bool isCreated = await clientBL.CreateAsync(createClient);
            if (isCreated) 
            {
                MessageBox.Show("Client created");
            } 
            else
            {
                MessageBox.Show("Failed to create client");
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        
    }
}
