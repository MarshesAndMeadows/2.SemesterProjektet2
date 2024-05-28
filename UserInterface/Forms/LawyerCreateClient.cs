using UserInterface.Forms.Helper;
using Controller;
using System.ComponentModel.DataAnnotations;
using UserInterface.Forms.Helper;
namespace UserInterface.Forms
{
    public partial class LawyerCreateClient : Form
    {
        Form previousForm;
        bool checkBoxState;
        ErrorProvider errorProvider;       
        private readonly Controllers controller;

        public LawyerCreateClient(Form previousForm)
        {
            InitializeComponent();           
            controller = new Controllers();
            this.previousForm = previousForm;
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
            foreach (Control control in this.Controls)
            {
                if (control is TextBox otherTextBox && otherTextBox != textbox)
                {
                    errorProvider.SetError(otherTextBox, ""); 
                }
            }

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
            bool isSexValid = false;
            bool isEmailValid = false;
            bool isPhoneValid = false;
            bool isAddressValid = false;
            bool isAgeValid = true;
            bool isCheckboxChecked = checkBoxYes.Checked || checkBoxNo.Checked;

            if (!string.IsNullOrEmpty(txtFirstName.Text))
            {
                isFirstNameValid = await controller.ValidateFirstNameAsync(txtFirstName.Text);
                ErrorProviderResponse(txtFirstName, isFirstNameValid, "Invalid first name");
            }
            if (!string.IsNullOrEmpty(txtLastName.Text))
            {
                isLastNameValid = await controller.ValidateLastNameAsync(txtLastName.Text);
                ErrorProviderResponse(txtLastName, isLastNameValid, "Invalid last name");
            }

            if (!string.IsNullOrEmpty(txtSex.Text))
            {
                isSexValid = await controller.ValidateSexAsync(txtSex.Text);
                ErrorProviderResponse(txtSex, isSexValid, "Specify sex as 'F' or 'M'");
            }

            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                isEmailValid = await controller.ValidateEmailAsync(txtEmail.Text);
                ErrorProviderResponse(txtEmail, isEmailValid, "Invalid email");
            }

            if (!string.IsNullOrEmpty(txtPhone.Text))
            {
                isPhoneValid = await controller.ValidatePhoneAsync(txtPhone.Text);
                ErrorProviderResponse(txtPhone, isPhoneValid, "Invalid phone number");
            }

            if (!string.IsNullOrEmpty(txtAddress.Text))
            {
                isAddressValid = await controller.ValidateAddressAsync(txtAddress.Text);
                ErrorProviderResponse(txtAddress, isAddressValid, "Invalid address");
            }

            btnCreateClient.Enabled = isFirstNameValid && isLastNameValid && isSexValid && isEmailValid &&
                                      isPhoneValid && isAddressValid && isAgeValid && isCheckboxChecked;
            btnCreateClient.Visible = btnCreateClient.Enabled;
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
