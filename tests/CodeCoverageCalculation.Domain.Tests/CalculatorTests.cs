using Xunit;

namespace CodeCoverageCalculation.Domain.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(12, 10)]
        [InlineData(-4, 5)]
        [InlineData(-4, 0)]
        [InlineData(-5, 23)]
        public void Add_ValidArguments_ReturnsCorrectSum(int value1, int value2)
        {
            // Arrange
            var expectedSum = value1 + value2;

            // Act
            var actualSum = Calculator.Add(value1, value2);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }
    }
}
