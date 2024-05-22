using BusinessLogic;
using BusinessLogic.BusinessLogic;
using System.Globalization;

namespace UserInterface.Forms
{
    public partial class ClientInterestCalculator : Form
    {
        Form previousForm;
        Validation validator;
     
        public ClientInterestCalculator(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.validator = new Validation();

            txtTotalLoanSize.KeyPress += TextBox_KeyPress;
            txtInterestPerYear.KeyPress += TextBox_KeyPress;
            txtTermYears.KeyPress += TextBox_KeyPress;

            txtTotalLoanSize.TextChanged += async (s, e) => await ValidateTextBoxAsync(txtTotalLoanSize, "positiveDouble");
            txtInterestPerYear.TextChanged += async (s, e) => await ValidateTextBoxAsync(txtInterestPerYear, "positiveDouble");
            txtTermYears.TextChanged += async (s, e) => await ValidateTextBoxAsync(txtTermYears, "positiveInt");
            btnCalculate.Enabled = false;
            btnCalculate.BackColor = SystemColors.Control;
        }

        private async Task EnableCalculateBtn()
        {
            bool isLoanSizeValid = !string.IsNullOrEmpty(txtTotalLoanSize.Text) && await validator.ValidateUserInputAsync("double", txtTotalLoanSize.Text);
            bool isInterestPerYearValid = !string.IsNullOrEmpty(txtInterestPerYear.Text) && await validator.ValidateUserInputAsync("double", txtInterestPerYear.Text);
            bool isLoanTermYearsValid = !string.IsNullOrEmpty(txtTermYears.Text) && await validator.ValidateUserInputAsync("int", txtTermYears.Text);

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
            // If the key is a negative sign, ignore it
            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }

        private async Task ValidateTextBoxAsync(TextBox textbox, string type)
        {
            // If the textbox is empty, return
            if (string.IsNullOrEmpty(textbox.Text))
            {
                return;
            }

            bool isValid = await validator.ValidateUserInputAsync(type, textbox.Text);
            await EnableCalculateBtn();
        }

        private void BtnCalculateClick(object sender, EventArgs e)
        {
            ValidateTextBoxAsync(txtTotalLoanSize, "double");
            ValidateTextBoxAsync(txtInterestPerYear, "double");
            ValidateTextBoxAsync(txtTermYears, "int");

            if (!btnCalculate.Enabled)
            {
                return;
            }

            double loan = double.Parse(txtTotalLoanSize.Text);
            double yearlyInterest = double.Parse(txtInterestPerYear.Text);
            int loanInYears = int.Parse(txtTermYears.Text);
            int totalPayment = loanInYears * 12;

            double monthlyPayment = CalculateMonthlyPayment(loan, yearlyInterest, totalPayment);
            double yearlyPayment = CalculateYearlyPayment(loan, yearlyInterest, loanInYears);
            double yearlyInterestPaid = CalculateYearlyInterestPaid(loan, yearlyPayment);

            string formattedMonthlyPayment = IncludeDanishCurrency(monthlyPayment);
            string formattedYearlyPayment = IncludeDanishCurrency(yearlyPayment);
            string formattedYearlyInterestPaid = IncludeDanishCurrency(yearlyInterestPaid);

            SetLblShowCalculation(monthlyPayment, yearlyPayment);
            SetLblShowYearlyPayments(loan);
            DisplayMonthlyPayments(totalPayment, monthlyPayment);

            dgvResults.Rows.Add(loan, yearlyInterest, loanInYears, formattedMonthlyPayment, formattedYearlyPayment, formattedYearlyInterestPaid);
        }

        private double CalculateYearlyPayment(double loanAmount, double annualInterestRate, int loanTermYears)
        {
            int totalPayments = loanTermYears * 12;
            double monthlyPayment = CalculateMonthlyPayment(loanAmount, annualInterestRate, totalPayments);
            double yearlyPayment = monthlyPayment * 12;
            return yearlyPayment;
        }

        private double CalculateMonthlyPayment(double loanAmount, double annualInterestRate, int totalPayments)
        {
            double monthlyInterestRate = annualInterestRate / 12 / 100;
            double monthlyPayment = loanAmount * (monthlyInterestRate / (1 - Math.Pow(1 + monthlyInterestRate, -totalPayments)));
            return monthlyPayment;
        }

        private double CalculateYearlyInterestPaid(double loanAmount, double yearlyPayment)
        {
            return yearlyPayment - loanAmount;
        }

        private void DisplayMonthlyPayments(int totalPayments, double monthlyPayment)
        {
            dgvResultEveryMonth.Rows.Clear();

            int totalYears = totalPayments / 12;

            for (int year = 0; year < totalYears; year++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvResultEveryMonth);

                for (int month = 0; month < 12; month++)
                {
                    string paymentPerMonth = IncludeDanishCurrency(monthlyPayment);
                    row.Cells[month].Value = paymentPerMonth;
                }

                dgvResultEveryMonth.Rows.Add(row);
            }
        }

        private string IncludeDanishCurrency(double amount)
        {
            CultureInfo danskeKroner = new CultureInfo("da-DK");
            return amount.ToString("C", danskeKroner);
        }

        private void SetLblShowCalculation(double monthlyPayment, double yearlyPayment)
        {
            string formattedMonthlyPayment = IncludeDanishCurrency(monthlyPayment);
            string formattedYearlyPayment = IncludeDanishCurrency(yearlyPayment);

            lblShowCalculation.Visible = true;
            lblShowCalculation.Text = $"Your monthly payment: {formattedMonthlyPayment} Total yearly payment: {formattedYearlyPayment}";
        }

        private void SetLblShowYearlyPayments(double loanAmount)
        {
            string totalLoan = IncludeDanishCurrency(loanAmount);
            lblShowYearlyPayments.Visible = true;
            lblShowYearlyPayments.Text = $"Example of yearly payment plan based on {totalLoan}";
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void btnClearClick(object sender, EventArgs e)
        {
            txtTotalLoanSize.Clear();
            txtInterestPerYear.Clear();
            txtTermYears.Clear();
            dgvResults.Rows.Clear();
            dgvResultEveryMonth.Rows.Clear();
            lblShowYearlyPayments.Visible = false;
            lblShowCalculation.Visible = false;
        }
    }
}
