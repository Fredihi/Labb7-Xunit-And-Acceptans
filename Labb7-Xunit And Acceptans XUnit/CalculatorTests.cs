using Labb7_Xunit_And_Acceptans;

namespace Labb7_Xunit_And_Acceptans_XUnit
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(10, 2, 8)]
        [InlineData(20, 10, 10)]
        [InlineData(15, 3, 12)]
        [InlineData(4, 2, 2)]
        public void PrintResults_ShouldPrintAllResultsFromList(int a, int b, int expected)
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            int actual = calc.Subtraction(a, b);


            //Assert
            Assert.Equal(expected, actual);

        }
    }
}