
using BusinessLogic.UiCalculation.BusinessLogic;

namespace UnitTest
{
    public class LoanCalculatorTest
    {
        // Angiver alt herunder er en Nunit test fixture
        [TestFixture]
        public class LoanCalculatorTests
        {
            private LoanCalculator loanCalculator;

            // Dennne køre altid inden test påbegyndes og sørger for at loanCalculator istancieres, og kan bruges
            [SetUp]
            public void Setup()
            {
                loanCalculator = new LoanCalculator();
            }


            // ---------------------- Herunder er alle test ---------------------------------
            [Test]
            public void CalculateMonthlyPayment_ShouldReturnCorrectValue()
            {
                // Arrange: Opsætter variabler med de værdier vil vil teste
                double loanAmount = 100000;
                double annualInterestRate = 0.05;
                int loanTermYears = 30;

                // Act: Her kaldes den metode der vil testes, med variabler ovenover
                double monthlyPayment = loanCalculator.CalculateMonthlyPayment(loanAmount, annualInterestRate, loanTermYears);

                // Assert: Her assertes hvad man mener resultatet vil blive
                Assert.AreEqual(536.82, Math.Round(monthlyPayment, 2));

                // Når test køres med: Test -> Run all test, meldes der tilbage om vores assert er blevet tested til det samme
            }

            [Test]
            public void CalculateYearlyPayment_ShouldReturnCorrectValue()
            {
                double loanAmount = 100000;
                double annualInterestRate = 0.05;
                int loanTermYears = 30;

                double yearlyPayment = loanCalculator.CalculateYearlyPayment(loanAmount, annualInterestRate, loanTermYears);

                Assert.AreEqual(6441.79, Math.Round(yearlyPayment, 2));
            }

            [Test]
            public void CalculateTotalInterestPaid_ShouldReturnCorrectValue()
            {                
                double loanAmount = 100000;
                double yearlyPayment = 6441.79;
                int loanTermYears = 30;
                                
                double totalInterestPaid = loanCalculator.CalculateTotalInterestPaid(loanAmount, yearlyPayment, loanTermYears);
                               
                Assert.AreEqual(93353.98, Math.Round(totalInterestPaid, 2));
            }

            [Test]
            public void CalculateYearlyInterestPaid_ShouldReturnCorrectValue()
            {                
                double totalInterestPaid = 93353.98;
                int loanTermYears = 30;
                               
                double yearlyInterestPaid = loanCalculator.CalculateYearlyInterestPaid(totalInterestPaid, loanTermYears);
                                
                Assert.AreEqual(3111.80, Math.Round(yearlyInterestPaid, 2));
            }
        }
    }
}
