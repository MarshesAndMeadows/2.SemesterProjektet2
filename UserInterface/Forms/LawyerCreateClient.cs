using BusinessLogic;
using BusinessLogic.BusinessLogic;
using UserInterface.Forms.Helper;
using Controller;
using System.ComponentModel.DataAnnotations;

namespace UserInterface.Forms
{
    public partial class LawyerCreateClient : Form
    {
        Form previousForm;
        // Validation validator;
        //ClientBL clientBL;
        bool checkBoxState;
        ErrorProvider errorProvider;
        HelpPage helper;
        private readonly Controllers controller;

        public LawyerCreateClient(Form previousForm)
        {
            InitializeComponent();
            this.helper = new HelpPage();
            //this.clientBL = new ClientBL();
            controller = new Controllers();

            this.previousForm = previousForm;
            //this.validator = new Validation();
            checkBoxYes.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            checkBoxNo.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            errorProvider = new ErrorProvider();
            birthdayPicker.MaxDate = DateTime.Today.AddYears(-15);                     

            toolTip1.SetToolTip(pictureBox, "Click here for help");
                        
            txtFirstName.TextChanged += (s, e) => EnableChooseLawyerBtn();
            txtLastName.TextChanged += (s, e) => EnableChooseLawyerBtn();
            txtSex.TextChanged += (s, e) => EnableChooseLawyerBtn();
            txtEmail.TextChanged += (s, e) => EnableChooseLawyerBtn();
            txtPhone.TextChanged += (s, e) => EnableChooseLawyerBtn();
            txtAddress.TextChanged += (s, e) => EnableChooseLawyerBtn();
        }

        private void ErrorProviderResponse(System.Windows.Forms.TextBox textbox, bool isValid, string errorMessage)
        {
            if (!isValid)
            {
                errorProvider.SetError(textbox, errorMessage);
            }
            else
            {
                errorProvider.SetError(textbox, "");
            }
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
            EnableChooseLawyerBtn();
        }

        private async void EnableChooseLawyerBtn()
        {
            bool isFirstNameValid = false;
            bool isLastNameValid = false;
            bool isEmailValid = false;
            bool isPhoneValid = false;
            bool isAddressValid = false;
            bool isAgeValid = false;
            bool isCheckboxChecked = checkBoxYes.Checked || checkBoxNo.Checked;
                      
            if (!string.IsNullOrEmpty(txtFirstName.Text))
            {
                string firstName = txtFirstName.Text;
                isFirstNameValid = await controller.ValidateFirstNameAsync(firstName);
                ErrorProviderResponse(txtFirstName, isFirstNameValid, "Invalid first name");
            }
            if (!string.IsNullOrEmpty(txtLastName.Text))
            {
                string lastName = txtLastName.Text;
                isLastNameValid = await controller.ValidateLastNameAsync(lastName);
                ErrorProviderResponse(txtLastName, isLastNameValid, "Invalid last name");
            }                    
           
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                string email = txtEmail.Text;
                isEmailValid = await controller.ValidateEmailAsync(email);
                ErrorProviderResponse(txtEmail, isEmailValid, "Invalid email");
            }          
            if (!string.IsNullOrEmpty(txtPhone.Text))
            {
                string phone = txtPhone.Text;
                isPhoneValid = await controller.ValidatePhoneAsync(phone);
                ErrorProviderResponse(txtPhone, isPhoneValid, "Invalid phone number");
            }
            if (!string.IsNullOrEmpty(txtAddress.Text))
            {
                string address = txtAddress.Text;
                isAddressValid = await controller.ValidateAddressAsync(address);
                ErrorProviderResponse(txtAddress, isAddressValid, "Invalid address");
            }

            btnCreateClient.Visible = isFirstNameValid && isLastNameValid && isEmailValid &&
                                      isPhoneValid && isAddressValid && isAgeValid && isCheckboxChecked;
            btnCreateClient.Enabled = btnCreateClient.Visible;
        }

        public async Task<bool> IsValidGenderInput(string input)
        {
            if (input == "F" || input == "f" || input == "M" || input == "m")
            {
                return await Task.FromResult(true);
            }
            return await Task.FromResult(false);
        }

        private async void btnCreateClient_Click(object sender, EventArgs e)
        {
            char sex;
            if (string.IsNullOrEmpty(txtSex.Text))
            {
                sex = ' ';
            }
            else
            {
                sex = txtSex.Text[0];
            }

            UIModels.UiClient createClient = new UIModels.UiClient
            {
                Firstname = txtFirstName.Text,
                Lastname = txtLastName.Text,
                Sex = sex,
                Birthday = DateTime.Parse(birthdayPicker.Text),
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text,
                Address = txtAddress.Text,
                Subscribed = checkBoxState
            };

            bool isCreated = await controller.CreateClientAsync(createClient);
            if (isCreated)
            {
                DialogResult result = MessageBox.Show("Press 'OK' to create another client, 'Annuller' to return to overview", "Create another client?", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtSex.Clear();
                    txtEmail.Clear();
                    txtPhone.Clear();
                    txtAddress.Clear();
                    birthdayPicker.ResetText();
                    checkBoxNo.Checked = false;
                    checkBoxYes.Checked = false;
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Close();
                    previousForm.Show();
                }
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

        private void HelpIconClick(object sender, EventArgs e)
        {
            HelpPage helpFunctionality = new HelpPage();
            helpFunctionality.LoadHelperContent(this);      
        }
    }
}
