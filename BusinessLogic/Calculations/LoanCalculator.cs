namespace BusinessLogic
{
    public class LoanCalculator
    {
        public decimal CalculateMonthlyPayment(decimal loanAmount, decimal annualInterestRate, int loanTermYears)
        {
            int totalPayments = loanTermYears * 12;
            decimal monthlyInterestRate = annualInterestRate / 12;

            if (annualInterestRate == 0)
            {
                return loanAmount / totalPayments;
            }

            decimal monthlyPayment = 
                loanAmount * (monthlyInterestRate / (1 - (decimal)Math.Pow((double)(1 + monthlyInterestRate), -totalPayments)));
            return monthlyPayment;
        }

        public decimal CalculateYearlyPayment(decimal loanAmount, decimal annualInterestRate, int loanTermYears)
        {
            decimal monthlyPayment = CalculateMonthlyPayment(loanAmount, annualInterestRate, loanTermYears);
            decimal yearlyPayment = monthlyPayment * 12;
            return yearlyPayment;
        }

        public decimal CalculateTotalInterestPaid(decimal loanAmount, decimal yearlyPayment, int loanTermYears)
        {
            decimal totalPayment = yearlyPayment * loanTermYears;
            decimal totalInterestPaid = totalPayment - loanAmount;
            return totalInterestPaid;
        }

        public decimal CalculateYearlyInterestPaid(decimal totalInterestPaid, int loanTermYears)
        {
            decimal yearlyInterestPaid = totalInterestPaid / loanTermYears;
            return yearlyInterestPaid;
        }
    }
}
