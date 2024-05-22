using BusinessLogic;
using BusinessLogic.BusinessLogic;
using System.Globalization;

namespace UserInterface.Forms
{
    public partial class ClientInterestCalculator : Form
    {
        Form previousForm;
        Validation validator;
        ErrorProvider errorProvider;

        public ClientInterestCalculator(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.validator = new Validation();
            errorProvider = new ErrorProvider();

            txtTotalLoanSize.TextChanged += (s, e) => EnableCalculateBtn();
            txtInterestPerYear.TextChanged += (s, e) => EnableCalculateBtn();
            txtTermYears.TextChanged += (s, e) => EnableCalculateBtn();
            btnCalculate.Enabled = false;
            btnCalculate.BackColor = SystemColors.Control;
        }

        private async void EnableCalculateBtn()
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
            ErrorProviderResponse(txtTotalLoanSize, isLoanSizeValid, "");
            ErrorProviderResponse(txtInterestPerYear, isInterestPerYearValid, "");
            ErrorProviderResponse(txtTermYears, isLoanTermYearsValid, "");
        }

        private void ErrorProviderResponse(TextBox textbox, bool isValid, string errorMessage)
        {
            if (!isValid)
            {
                errorProvider.SetError(textbox, "");
            }
            else
            {
                errorProvider.SetError(textbox, "");
            }
        }

        private void BtnCalculateClick(object sender, EventArgs e)
        {
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

            DataGridViewRow row = new DataGridViewRow();

            for (int month = 1; month <= totalPayments; month++)
            {
                string paymentPerMonth = IncludeDanishCurrency(monthlyPayment);

                row.Cells.Add(new DataGridViewTextBoxCell { Value = paymentPerMonth });
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
        }
    }
}
