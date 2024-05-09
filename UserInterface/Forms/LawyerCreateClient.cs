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
using BusinessLogic.BusinessLogic;
using BusinessLogic.CRUD;

namespace UserInterface.Forms
{
    public partial class LawyerCreateClient : Form
    {
        Form previousForm;
        Validation validator;
        ClientBL clientBL;
        private bool checkBoxState;

        public LawyerCreateClient(Form previousForm)
        {            
            this.clientBL = new ClientBL();
            this.previousForm = previousForm;
            this.validator = new Validation();
            checkBoxYes.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            checkBoxNo.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);

            InitializeComponent();
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
            bool isTxtFirstName = await validator.ValidateUserInput("name", txtFirstName.Text);
            bool isTxLastName = await validator.ValidateUserInput("name", txtLastName.Text);
            bool isTxtSex = await IsValidGenderInput(txtSex.Text);
            bool isTxtEmail = await validator.ValidateUserInput("email", txtEmail.Text);
            bool isTxtPhone = await validator.ValidateUserInput("phone", txtPhone.Text);
            bool isTxtAddress = await validator.ValidateUserInput("address", txtAddress.Text);

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
