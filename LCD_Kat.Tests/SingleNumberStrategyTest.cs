using LCD_Kat.Strategies;
using LCD_Kat.Utilities;
using Xunit;
using Xunit.Extensions;

namespace LCD_Kat.Tests
{
    public class SingleNumberStrategyTest
    {
        private readonly SingleNumberStrategy _strategy;

        public SingleNumberStrategyTest()
        {
            var generator = new GenerateLcdNumber();
            _strategy = new SingleNumberStrategy(generator);
        }

        [Theory]
        [InlineData(0, " - \r\n| |\r\n   \r\n| |\r\n - ")]
        [InlineData(1, "   \r\n  |\r\n   \r\n  |\r\n   ")]
        [InlineData(2, " - \r\n  |\r\n - \r\n|  \r\n - ")]
        [InlineData(3, " - \r\n  |\r\n - \r\n  |\r\n - ")]
        [InlineData(4, "   \r\n| |\r\n - \r\n  |\r\n   ")]
        [InlineData(5, " - \r\n|  \r\n - \r\n  |\r\n - ")]
        [InlineData(6, " - \r\n|  \r\n - \r\n| |\r\n - ")]
        [InlineData(7, " - \r\n  |\r\n   \r\n  |\r\n   ")]
        [InlineData(8, " - \r\n| |\r\n - \r\n| |\r\n - ")]
        [InlineData(9, " - \r\n| |\r\n - \r\n  |\r\n - ")]
        public void CreateNumberOnAsLcd(int number, string lcdRepresentation)
        {
            var lcdNumber = _strategy.ConvertNumber(number);
            Assert.Equal(lcdRepresentation, lcdNumber);
        }
    }
}