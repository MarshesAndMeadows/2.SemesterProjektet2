using BusinessLogic;
using BusinessLogic.BusinessLogic;
using System.Globalization;
using UserInterface.Forms.Helper;

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
            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }

        private async Task ValidateTextBoxAsync(TextBox textbox, string type)
        {
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
            double yearlyInterest = double.Parse(txtInterestPerYear.Text) / 100;
            int loanInYears = int.Parse(txtTermYears.Text);
            int totalPayment = loanInYears * 12;

            PerformCalculationsAndDisplayResults(loan, yearlyInterest, loanInYears, totalPayment);
        }

        private void PerformCalculationsAndDisplayResults(double loan, double yearlyInterest, int loanInYears, int totalPayment)
        {
            double monthlyPayment = CalculateMonthlyPayment(loan, yearlyInterest, totalPayment);
            double yearlyPayment = CalculateYearlyPayment(loan, yearlyInterest, loanInYears);
            double totalInterestPaid = CalculateTotalInterestPaid(loan, yearlyPayment, loanInYears);
            double yearlyInterestPaid = CalculateYearlyInterestPaid(totalInterestPaid, loanInYears);

            string formattedMonthlyPayment = IncludeDanishCurrency(monthlyPayment);
            string formattedYearlyPayment = IncludeDanishCurrency(yearlyPayment);
            string formattedYearlyInterestPaid = IncludeDanishCurrency(yearlyInterestPaid);

            SetLblShowCalculation(monthlyPayment, yearlyPayment);
            SetLblShowYearlyPayments(loan);
            DisplayMonthlyPayments(monthlyPayment);

            dgvResults.Rows.Add(loan, yearlyInterest, loanInYears, formattedMonthlyPayment, formattedYearlyPayment, formattedYearlyInterestPaid);
        }

        private double CalculateYearlyPayment(double loanAmount, double annualInterestRate, int loanTermYears)
        {
            double monthlyPayment = CalculateMonthlyPayment(loanAmount, annualInterestRate, loanTermYears);
            double yearlyPayment = monthlyPayment * 12;
            return yearlyPayment;
        }

        private double CalculateMonthlyPayment(double loanAmount, double annualInterestRate, int loanTermYears)
        {
            int totalPayments = loanTermYears * 12;
            double monthlyInterestRate = annualInterestRate / 12;
            double monthlyPayment = loanAmount * (monthlyInterestRate / (1 - Math.Pow(1 + monthlyInterestRate, -totalPayments)));
            return monthlyPayment;
        }

        private double CalculateTotalInterestPaid(double loanAmount, double yearlyPayment, int loanTermYears)
        {
            double totalPayment = yearlyPayment * loanTermYears;
            double totalInterestPaid = totalPayment - loanAmount;
            return totalInterestPaid;
        }

        private double CalculateYearlyInterestPaid(double totalInterestPaid, int loanTermYears)
        {
            double yearlyInterestPaid = totalInterestPaid / loanTermYears;
            return yearlyInterestPaid;
        }

        private void DisplayMonthlyPayments(double monthlyPayment)
        {
            dgvResultEveryMonth.Rows.Clear();

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvResultEveryMonth);

            for (int month = 0; month < 12; month++)
            {
                string paymentPerMonth = IncludeDanishCurrency(monthlyPayment);
                row.Cells[month].Value = paymentPerMonth;
            }

            dgvResultEveryMonth.Rows.Add(row);
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
            btnCalculate.Enabled = false;
        }

        private void HelpIconClick(object sender, EventArgs e)
        {
            HelpPage helpFunctionality = new HelpPage();
            helpFunctionality.LoadHelperContent(this);
        }
    }
}
