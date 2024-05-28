using Controller;
using System.Globalization;
using UserInterface.Forms.Helper;

namespace UserInterface.Forms
{
    public partial class ClientInterestCalculator : Form
    {
        Form previousForm;
        private Controllers controller;

        public ClientInterestCalculator(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.controller = new Controllers();

            txtTotalLoanAmount.KeyPress += TextBox_KeyPress;
            txtAnnualInterestRate.KeyPress += TextBox_KeyPress;
            txtLoanTermYears.KeyPress += TextBox_KeyPress;

            txtTotalLoanAmount.TextChanged += async (s, e) => await ValidateTextBoxAsync(txtTotalLoanAmount, "positiveDecimal");
            txtAnnualInterestRate.TextChanged += async (s, e) => await ValidateTextBoxAsync(txtAnnualInterestRate, "positiveDecimal");
            txtLoanTermYears.TextChanged += async (s, e) => await ValidateTextBoxAsync(txtLoanTermYears, "positiveInt");

            btnCalculate.Enabled = false;
            btnCalculate.BackColor = SystemColors.Control;
        }

        private async Task EnableCalculateButtonAsync()
        {
            bool isLoanSizeValid = false;
            bool isInterestPerYearValid = false;
            bool isLoanTermYearsValid = false;

            if (!string.IsNullOrEmpty(txtTotalLoanAmount.Text))
            {
                isLoanSizeValid = await controller.ValidateDecimalAsync(txtTotalLoanAmount.Text);
            }
            if (!string.IsNullOrEmpty(txtAnnualInterestRate.Text))
            {
                isInterestPerYearValid = await controller.ValidateDecimalAsync(txtAnnualInterestRate.Text);
            }
            if (!string.IsNullOrEmpty(txtLoanTermYears.Text))
            {
                isLoanTermYearsValid = await controller.ValidateIntAsync(txtLoanTermYears.Text);
            }

            btnCalculate.Enabled = isLoanSizeValid && isInterestPerYearValid && isLoanTermYearsValid;

            if (btnCalculate.Enabled)
            {
                btnCalculate.BackColor = Color.LightGreen;
            }
            else
            {
                btnCalculate.BackColor = SystemColors.Control;
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }

        private async Task ValidateTextBoxAsync(TextBox textbox, string type)
        {
            if (!string.IsNullOrEmpty(textbox.Text))
            {
                if (type == "positiveDecimal")
                {
                    await controller.ValidateDecimalAsync(textbox.Text);
                }
                else if (type == "positiveInt")
                {
                    await controller.ValidateIntAsync(textbox.Text);
                }
                await EnableCalculateButtonAsync();
            }
        }

        private async void BtnCalculateClick(object sender, EventArgs e)
        {
            await ValidateTextBoxAsync(txtTotalLoanAmount, "positiveDecimal");
            await ValidateTextBoxAsync(txtAnnualInterestRate, "positiveDecimal");
            await ValidateTextBoxAsync(txtLoanTermYears, "positiveInt");

            if (btnCalculate.Enabled)
            {
                decimal loanAmount = decimal.Parse(txtTotalLoanAmount.Text);
                decimal annualInterestRate = decimal.Parse(txtAnnualInterestRate.Text) / 100;
                int loanTermYears = int.Parse(txtLoanTermYears.Text);

                PerformCalculationsAndDisplayResults(loanAmount, annualInterestRate, loanTermYears);
            }
        }

        private void PerformCalculationsAndDisplayResults(decimal loanAmount, decimal annualInterestRate, int loanTermYears)
        {
            decimal monthlyPayment = controller.CalculateMonthlyPayment(loanAmount, annualInterestRate, loanTermYears);
            decimal yearlyPayment = controller.CalculateYearlyPayment(loanAmount, annualInterestRate, loanTermYears);
            decimal totalInterestPaid = controller.CalculateTotalInterestPaid(loanAmount, yearlyPayment, loanTermYears);
            decimal yearlyInterestPaid = controller.CalculateYearlyInterestPaid(totalInterestPaid, loanTermYears);

            string formattedMonthlyPayment = FormatToDkkCurrency(monthlyPayment);
            string formattedYearlyPayment = FormatToDkkCurrency(yearlyPayment);
            string formattedYearlyInterestPaid = FormatToDkkCurrency(yearlyInterestPaid);

            SetCalculationLabels(formattedMonthlyPayment, formattedYearlyPayment);
            SetYearlyPaymentLabel(loanAmount);
            DisplayMonthlyPayments(monthlyPayment);

            dgvResults.Rows.Add(loanAmount, annualInterestRate, loanTermYears, formattedMonthlyPayment, formattedYearlyPayment, formattedYearlyInterestPaid);
        }

        private void DisplayMonthlyPayments(decimal monthlyPayment)
        {
            dgvResultEveryMonth.Rows.Clear();

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvResultEveryMonth);

            for (int month = 0; month < 12; month++)
            {
                string paymentPerMonth = FormatToDkkCurrency(monthlyPayment);
                row.Cells[month].Value = paymentPerMonth;
            }

            dgvResultEveryMonth.Rows.Add(row);
        }

        private string FormatToDkkCurrency(decimal amount)
        {
            CultureInfo danskeKroner = new CultureInfo("da-DK");
            return amount.ToString("C", danskeKroner);
        }

        private void SetCalculationLabels(string monthlyPayment, string yearlyPayment)
        {
            lblShowCalculation.Visible = true;
            lblShowCalculation.Text = $"Your monthly payment: {monthlyPayment} Total yearly payment: {yearlyPayment}";
        }

        private void SetYearlyPaymentLabel(decimal loanAmount)
        {
            string formattedLoanAmount = FormatToDkkCurrency(loanAmount);
            lblShowYearlyPayments.Visible = true;
            lblShowYearlyPayments.Text = $"Example of yearly payment plan based on {formattedLoanAmount}";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void btnClearClick(object sender, EventArgs e)
        {
            txtTotalLoanAmount.Clear();
            txtAnnualInterestRate.Clear();
            txtLoanTermYears.Clear();
            dgvResults.Rows.Clear();
            dgvResultEveryMonth.Rows.Clear();
            lblShowYearlyPayments.Visible = false;
            lblShowCalculation.Visible = false;
            btnCalculate.Enabled = false;
        }

        private void HelpIconClick(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm(this);
            helpForm.SetHelpContent("ClientInterestCalculatorClick");
            helpForm.Show();
        }

    }
}
