using Controller;

namespace UserInterface.Forms
{
    public partial class LawyerCreateClient : Form
    {
        Form previousForm;
        Controller.LawyerCreateClientController controller;
        private bool checkBoxState;
        private ErrorProvider errorProvider;


        public LawyerCreateClient(Form previousForm)
        {
            InitializeComponent();           
            this.previousForm = previousForm;           
            checkBoxYes.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            checkBoxNo.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            errorProvider = new ErrorProvider();
            // birthday beregnes automatisk, og skal min være 18 fra dd. når alder vælges
            birthdayPicker.MaxDate = DateTime.Today.AddYears(-18);
            /*
             txtFirstName.TextChanged = er event der udløses når txtFirstName modatger ænddringer 
             (s, e) = er blot placeholders, s vil her være txtFirstName, e er eventArgs           
            */
            txtFirstName.TextChanged += (s, e) => EnableChooseLawyerBtn();
            txtLastName.TextChanged += (s, e) => EnableChooseLawyerBtn();
            txtSex.TextChanged += (s, e) => EnableChooseLawyerBtn();
            txtEmail.TextChanged += (s, e) => EnableChooseLawyerBtn();
            txtPhone.TextChanged += (s, e) => EnableChooseLawyerBtn();
            txtAddress.TextChanged += (s, e) => EnableChooseLawyerBtn();
        }

        private void ErrorProviderResponse(TextBox textbox, bool isValid, string errorMessage)
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
            bool IsFirstName = false;
            bool IsLastName = false;
            bool IsSex = false;
            bool IsEmail = false;
            bool IsPhone = false;
            bool IsAddress = false;
            bool IsAgeValid = true;
            bool IsCheckboxChecked = checkBoxYes.Checked || checkBoxNo.Checked;

            if (!string.IsNullOrEmpty(txtFirstName.Text))
            {
                IsFirstName = await controller.ValidateUserInputAsync("name", txtFirstName.Text);
                ErrorProviderResponse(txtFirstName, IsFirstName, "Invalid first name");
            }
            if (!string.IsNullOrEmpty(txtLastName.Text))
            {
                IsLastName = await controller.ValidateUserInputAsync("name", txtLastName.Text);
                ErrorProviderResponse(txtLastName, IsLastName, "Invalid last name");
            }
            if (!string.IsNullOrEmpty(txtSex.Text))
            {
                IsSex = await controller.ValidateUserInputAsync("sex",txtSex.Text);
                ErrorProviderResponse(txtSex, IsSex, "Specify sex as 'F' or 'M'");
            }

            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                IsEmail = await controller.ValidateUserInputAsync("email", txtEmail.Text);
                ErrorProviderResponse(txtEmail, IsEmail, "Invalid email");
            }
            if (!string.IsNullOrEmpty(txtPhone.Text))
            {
                IsPhone = await controller.ValidateUserInputAsync("phone", txtPhone.Text);
                ErrorProviderResponse(txtPhone, IsPhone, "Invalid phone number");
            }
            if (!string.IsNullOrEmpty(txtAddress.Text))
            {
                IsAddress = await controller.ValidateUserInputAsync("address", txtAddress.Text);
                ErrorProviderResponse(txtAddress, IsAddress, "Invalid address");
            }

            btnCreateClient.Visible = IsFirstName && IsLastName && IsSex && IsEmail && IsPhone && IsAddress && IsAgeValid && IsCheckboxChecked;
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
    }
}
