using BusinessLogic;
using BusinessLogic.BusinessLogic;
using System.Globalization;
using System.Windows.Forms;

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

            txtLoanSize.TextChanged += (s, e) => EnableCalculateBtn();
            txtInterestPerYear.TextChanged += (s, e) => EnableCalculateBtn();
            txtLoanTermYears.TextChanged += (s, e) => EnableCalculateBtn();
            btnCalculate.Enabled = false;
            btnCalculate.BackColor = SystemColors.Control;
        }

        private async void EnableCalculateBtn()
        {
            bool isLoanSizeValid = !string.IsNullOrEmpty(txtLoanSize.Text) && await validator.ValidateUserInputAsync("double", txtLoanSize.Text);
            bool isInterestPerYearValid = !string.IsNullOrEmpty(txtInterestPerYear.Text) && await validator.ValidateUserInputAsync("double", txtInterestPerYear.Text);
            bool isLoanTermsYearsValid = !string.IsNullOrEmpty(txtLoanTermYears.Text) && await validator.ValidateUserInputAsync("int", txtLoanTermYears.Text);

            btnCalculate.Enabled = isLoanSizeValid && isInterestPerYearValid && isLoanTermsYearsValid;

            if (btnCalculate.Enabled)
            {
                btnCalculate.BackColor = Color.LightGreen;
            }
            else
            {
                btnCalculate.BackColor = SystemColors.Control;
            }

            ErrorProviderResponse(txtLoanSize, isLoanSizeValid, "");
            ErrorProviderResponse(txtInterestPerYear, isInterestPerYearValid, "");
            ErrorProviderResponse(txtLoanTermYears, isLoanTermsYearsValid, "");
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
            double loanAmount = double.Parse(txtLoanSize.Text);
            double annualInterestRate = double.Parse(txtInterestPerYear.Text);
            int loanTermYears = int.Parse(txtLoanTermYears.Text);
            int totalPayments = loanTermYears * 12;

            double monthlyPayment = CalculateMonthlyPayment(loanAmount, annualInterestRate, totalPayments);
            double yearlyPayment = CalculateYearlyPayment(loanAmount, annualInterestRate, 12);
                    
            string formattedMonthlyPayment = IncludeDanishCurrency(monthlyPayment);           
            string formattedYearlyPayment = IncludeDanishCurrency(yearlyPayment);

            SetLblShowCalculation(monthlyPayment, yearlyPayment);
            SetLblShowYearlyPayments(loanAmount);
            DisplayMonthlyPayments(totalPayments, monthlyPayment);

            dgvResults.Rows.Add(loanAmount, annualInterestRate, loanTermYears, formattedMonthlyPayment, formattedYearlyPayment);
        }

        private double CalculateYearlyPayment(double loanAmount, double annualInterestRate, int installmentsPerYear)
        {
            double monthlyPayment = CalculateMonthlyPayment(loanAmount, annualInterestRate, installmentsPerYear * 12);
            double yearlyPayment = monthlyPayment * installmentsPerYear;
            return yearlyPayment;
        }

        private double CalculateMonthlyPayment(double loanAmount, double annualInterestRate, int totalPayments)
        {
            double monthlyInterestRate = annualInterestRate / 12 / 100;
            double monthlyPayment = loanAmount * (monthlyInterestRate / (1 - Math.Pow(1 + monthlyInterestRate, -totalPayments)));
            return monthlyPayment;
        }

        private void DisplayMonthlyPayments(int totalPayments, double monthlyPayment)
        {
            dgvResultEveryMonth.Rows.Clear();

            for (int month = 1; month <= totalPayments; month++)
            {
                string formattedPayment = IncludeDanishCurrency(monthlyPayment);
                dgvResultEveryMonth.Rows.Add(month, formattedPayment);
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
            string formattedYearlyPayment =IncludeDanishCurrency(yearlyPayment);

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
            txtLoanSize.Clear();
            txtInterestPerYear.Clear();
            txtLoanTermYears.Clear();
            dgvResults.Rows.Clear();
            dgvResultEveryMonth.Rows.Clear();
            lblShowYearlyPayments.Visible = false;
            lblShowCalculation.Visible=false;
        }
       
    }
}

