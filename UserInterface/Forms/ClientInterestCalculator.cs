using BusinessLogic;
using BusinessLogic.BusinessLogic;
using BusinessLogic.UiCalculation.BusinessLogic;
using System.Globalization;
using UserInterface.Forms.Helper;

namespace UserInterface.Forms
{
    public partial class ClientInterestCalculator : Form
    {
        Form previousForm;
        Validation validator;
        private LoanCalculator loanCalculator;

        public ClientInterestCalculator(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.validator = new Validation();
            this.loanCalculator = new LoanCalculator();

            txtTotalLoanAmount.KeyPress += TextBox_KeyPress;
            txtAnnualInterestRate.KeyPress += TextBox_KeyPress;
            txtLoanTermYears.KeyPress += TextBox_KeyPress;

            txtTotalLoanAmount.TextChanged += async (s, e) => await ValidateTextBoxAsync(txtTotalLoanAmount, "positiveDouble");
            txtAnnualInterestRate.TextChanged += async (s, e) => await ValidateTextBoxAsync(txtAnnualInterestRate, "positiveDouble");
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
                isLoanSizeValid = await validator.ValidateUserInputAsync("double", txtTotalLoanAmount.Text);
            }           
            if (!string.IsNullOrEmpty(txtAnnualInterestRate.Text))
            {
                isInterestPerYearValid = await validator.ValidateUserInputAsync("double", txtAnnualInterestRate.Text);
            }          
            if (!string.IsNullOrEmpty(txtLoanTermYears.Text))
            {
                isLoanTermYearsValid = await validator.ValidateUserInputAsync("int", txtLoanTermYears.Text);
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

        /*private async Task ValidateTextBoxAsync(TextBox textbox, string type)
        {
            if (string.IsNullOrEmpty(textbox.Text))
            {
                return;
            }

            bool isValid = await validator.ValidateUserInputAsync(type, textbox.Text);
            await EnableCalculateButtonAsync();
        }*/

        private async Task ValidateTextBoxAsync(TextBox textbox, string type)
        {
            if (!string.IsNullOrEmpty(textbox.Text))
            {
                await validator.ValidateUserInputAsync(type, textbox.Text);
                await EnableCalculateButtonAsync();
            }
        }

        /*private void BtnCalculateClick(object sender, EventArgs e)
        {
            ValidateTextBoxAsync(txtTotalLoanAmount, "double");
            ValidateTextBoxAsync(txtAnnualInterestRate, "double");
            ValidateTextBoxAsync(txtLoanTermYears, "int");

            if (!btnCalculate.Enabled)
            {
                return;
            }

            double loan = double.Parse(txtTotalLoanAmount.Text);
            double yearlyInterest = double.Parse(txtAnnualInterestRate.Text) / 100;
            int loanInYears = int.Parse(txtLoanTermYears.Text);
            int totalPayment = loanInYears * 12;

            PerformCalculationsAndDisplayResults(loan, yearlyInterest, loanInYears, totalPayment);
        }*/

        private async void BtnCalculateClick(object sender, EventArgs e)
        {
            await ValidateTextBoxAsync(txtTotalLoanAmount, "double");
            await ValidateTextBoxAsync(txtAnnualInterestRate, "double");
            await ValidateTextBoxAsync(txtLoanTermYears, "int");

            if (btnCalculate.Enabled)
            {
                double loanAmount = double.Parse(txtTotalLoanAmount.Text);
                double annualInterestRate = double.Parse(txtAnnualInterestRate.Text) / 100;
                int loanTermYears = int.Parse(txtLoanTermYears.Text);

                PerformCalculationsAndDisplayResults(loanAmount, annualInterestRate, loanTermYears);
            }
        }

        /*private void PerformCalculationsAndDisplayResults(double loan, double yearlyInterest, int loanInYears, int totalPayment)
        {
            double monthlyPayment = loanCalculator.CalculateMonthlyPayment(loan, yearlyInterest, loanInYears);
            double yearlyPayment = loanCalculator.CalculateYearlyPayment(loan, yearlyInterest, loanInYears);
            double totalInterestPaid = loanCalculator.CalculateTotalInterestPaid(loan, yearlyPayment, loanInYears);
            double yearlyInterestPaid = loanCalculator.CalculateYearlyInterestPaid(totalInterestPaid, loanInYears);

            string formattedMonthlyPayment = FormatCurrency(monthlyPayment);
            string formattedYearlyPayment = FormatCurrency(yearlyPayment);
            string formattedYearlyInterestPaid = FormatCurrency(yearlyInterestPaid);

            SetLblShowCalculation(monthlyPayment, yearlyPayment);
            SetLblShowYearlyPayments(loan);
            DisplayMonthlyPayments(monthlyPayment);

            dgvResults.Rows.Add(loan, yearlyInterest, loanInYears, formattedMonthlyPayment, formattedYearlyPayment, formattedYearlyInterestPaid);
        }*/

        private void PerformCalculationsAndDisplayResults(double loanAmount, double annualInterestRate, int loanTermYears)
        {
            double monthlyPayment = loanCalculator.CalculateMonthlyPayment(loanAmount, annualInterestRate, loanTermYears);
            double yearlyPayment = loanCalculator.CalculateYearlyPayment(loanAmount, annualInterestRate, loanTermYears);
            double totalInterestPaid = loanCalculator.CalculateTotalInterestPaid(loanAmount, yearlyPayment, loanTermYears);
            double yearlyInterestPaid = loanCalculator.CalculateYearlyInterestPaid(totalInterestPaid, loanTermYears);

            string formattedMonthlyPayment = FormatCurrency(monthlyPayment);
            string formattedYearlyPayment = FormatCurrency(yearlyPayment);
            string formattedYearlyInterestPaid = FormatCurrency(yearlyInterestPaid);

            SetCalculationLabels(formattedMonthlyPayment, formattedYearlyPayment);
            SetYearlyPaymentsLabel(loanAmount);
            DisplayMonthlyPayments(monthlyPayment);

            dgvResults.Rows.Add(loanAmount, annualInterestRate, loanTermYears, formattedMonthlyPayment, formattedYearlyPayment, formattedYearlyInterestPaid);
        }              

        private void DisplayMonthlyPayments(double monthlyPayment)
        {
            dgvResultEveryMonth.Rows.Clear();

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvResultEveryMonth);

            for (int month = 0; month < 12; month++)
            {
                string paymentPerMonth = FormatCurrency(monthlyPayment);
                row.Cells[month].Value = paymentPerMonth;
            }

            dgvResultEveryMonth.Rows.Add(row);
        }

        private string FormatCurrency(double amount)
        {
            CultureInfo danskeKroner = new CultureInfo("da-DK");
            return amount.ToString("C", danskeKroner);
        }

        /*private void SetLblShowCalculation(double monthlyPayment, double yearlyPayment)
        {
            string formattedMonthlyPayment = FormatCurrency(monthlyPayment);
            string formattedYearlyPayment = FormatCurrency(yearlyPayment);

            lblShowCalculation.Visible = true;
            lblShowCalculation.Text = $"Your monthly payment: {formattedMonthlyPayment} Total yearly payment: {formattedYearlyPayment}";
        }*/

        private void SetCalculationLabels(string monthlyPayment, string yearlyPayment)
        {
            lblShowCalculation.Visible = true;
            lblShowCalculation.Text = $"Your monthly payment: {monthlyPayment} Total yearly payment: {yearlyPayment}";
        }


        /* private void SetLblShowYearlyPayments(double loanAmount)
         {
             string totalLoan = FormatCurrency(loanAmount);
             lblShowYearlyPayments.Visible = true;
             lblShowYearlyPayments.Text = $"Example of yearly payment plan based on {totalLoan}";
         }*/

        private void SetYearlyPaymentsLabel(double loanAmount)
        {
            string formattedLoanAmount = FormatCurrency(loanAmount);
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
            HelpPage helpFunctionality = new HelpPage();
            helpFunctionality.LoadHelperContent(this);
        }
    }
}
