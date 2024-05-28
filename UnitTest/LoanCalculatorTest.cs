using NUnit.Framework;
using BusinessLogic;

namespace UnitTest
{
    public class LoanCalculatorTest
    {
        [TestFixture]
        public class LoanCalculatorTests
        {
            private LoanCalculator loanCalculator;

            [SetUp]
            public void Setup()
            {
                loanCalculator = new LoanCalculator();
            }

            [Test]
            public void MonthlyPayment_CorrectValue()
            {
                decimal loanAmount = 100000m;
                decimal annualInterestRate = 0.05m;
                int loanTermYears = 30;

                decimal monthlyPayment = loanCalculator.CalculateMonthlyPayment(loanAmount, annualInterestRate, loanTermYears);

                Assert.AreEqual(536.82m, Math.Round(monthlyPayment, 2));
            }

            [Test]
            public void YearlyPayment_CorrectValue()
            {
                decimal loanAmount = 100000m;
                decimal annualInterestRate = 0.05m;
                int loanTermYears = 30;

                decimal yearlyPayment = loanCalculator.CalculateYearlyPayment(loanAmount, annualInterestRate, loanTermYears);

                Assert.AreEqual(6441.79m, Math.Round(yearlyPayment, 2));
            }

            [Test]
            public void TotalInterest_CorrectValue()
            {
                decimal loanAmount = 100000m;
                decimal yearlyPayment = 6441.79m;
                int loanTermYears = 30;

                decimal totalInterestPaid = loanCalculator.CalculateTotalInterestPaid(loanAmount, yearlyPayment, loanTermYears);

                Assert.AreEqual(93353.98m, Math.Round(totalInterestPaid, 2));
            }

            [Test]
            public void YearlyInterest_CorrectValue()
            {
                decimal totalInterestPaid = 93353.98m;
                int loanTermYears = 30;

                decimal yearlyInterestPaid = loanCalculator.CalculateYearlyInterestPaid(totalInterestPaid, loanTermYears);

                Assert.AreEqual(3111.80m, Math.Round(yearlyInterestPaid, 2));
            }

            [Test]
            public void MonthlyPayment_ZeroInterest_CorrectValue()
            {
                decimal loanAmount = 100000m;
                decimal annualInterestRate = 0.0m;
                int loanTermYears = 30;

                decimal monthlyPayment = loanCalculator.CalculateMonthlyPayment(loanAmount, annualInterestRate, loanTermYears);

                Assert.AreEqual(277.78m, Math.Round(monthlyPayment, 2));
            }

            [Test]
            public void YearlyPayment_ZeroInterest_CorrectValue()
            {
                decimal loanAmount = 100000m;
                decimal annualInterestRate = 0.0m;
                int loanTermYears = 30;

                decimal yearlyPayment = loanCalculator.CalculateYearlyPayment(loanAmount, annualInterestRate, loanTermYears);

                Assert.AreEqual(3333.33m, Math.Round(yearlyPayment, 2));
            }

            [Test]
            public void TotalInterest_ZeroInterest_CorrectValue()
            {
                decimal loanAmount = 100000m;
                decimal yearlyPayment = 3333.33m;
                int loanTermYears = 30;

                decimal totalInterestPaid = loanCalculator.CalculateTotalInterestPaid(loanAmount, yearlyPayment, loanTermYears);

                Assert.AreEqual(0.0m, Math.Round(totalInterestPaid, 2));
            }

            [Test]
            public void MonthlyPayment_ShortTerm_CorrectValue()
            {
                decimal loanAmount = 100000m;
                decimal annualInterestRate = 0.05m;
                int loanTermYears = 1;

                decimal monthlyPayment = loanCalculator.CalculateMonthlyPayment(loanAmount, annualInterestRate, loanTermYears);

                Assert.AreEqual(8560.74m, Math.Round(monthlyPayment, 2));
            }           
        }
    }
}
