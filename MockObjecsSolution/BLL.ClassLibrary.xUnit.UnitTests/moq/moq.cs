using Moq;
using Xunit;

namespace BLL.ClassLibrary.xUnit.UnitTests._1_Manual
{
    public class TaxCalculatorTests
    {
        [Fact]
        public void CalculateTotalValueForPerson_Returns_CorrectTotalValue()
        {
            // Arrange
            int personId = 1;
            double amount = 100;
            double expectedTotalValue = 127; // Amount * (1 + TaxPercentage)

            var mockDatabase = new Mock<IDdatabase>();
            mockDatabase.Setup(db => db.GetTaxPercentageByPersonId(personId)).Returns(0.27);

            var taxCalculator = new TaxCalculator(mockDatabase.Object);

            // Act
            double totalValue = taxCalculator.CalculateTotalValueForPerson(amount, personId);

            // Assert
            Assert.Equal(expectedTotalValue, totalValue);
        }
    }
}
