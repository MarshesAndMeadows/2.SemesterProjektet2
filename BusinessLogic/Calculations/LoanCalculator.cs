
namespace BusinessLogic.UiCalculation
{
    namespace BusinessLogic
    {
        public class LoanCalculator
        {
            public double CalculateMonthlyPayment(double loanAmount, double annualInterestRate, int loanTermYears)
            {
                int totalPayments = loanTermYears * 12;
                double monthlyInterestRate = annualInterestRate / 12;
                double monthlyPayment = loanAmount * (monthlyInterestRate / (1 - Math.Pow(1 + monthlyInterestRate, -totalPayments)));
                return monthlyPayment;
            }

            public double CalculateYearlyPayment(double loanAmount, double annualInterestRate, int loanTermYears)
            {
                if (loanTermYears == 0 || loanAmount < 0 || annualInterestRate < 0 || loanTermYears < 0 ) 
                {
                    return 0;
                }
                double monthlyPayment = CalculateMonthlyPayment(loanAmount, annualInterestRate, loanTermYears);
                double yearlyPayment = monthlyPayment * 12;
                return yearlyPayment;
            }

            public double CalculateTotalInterestPaid(double loanAmount, double yearlyPayment, int loanTermYears)
            {
                double totalPayment = yearlyPayment * loanTermYears;
                double totalInterestPaid = totalPayment - loanAmount;
                return totalInterestPaid;
            }

            public double CalculateYearlyInterestPaid(double totalInterestPaid, int loanTermYears)
            {
                double yearlyInterestPaid = totalInterestPaid / loanTermYears;
                return yearlyInterestPaid;
            }
        }
    }
}
