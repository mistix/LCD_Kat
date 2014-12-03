using LCD_Kat.Strategies;
using LCD_Kat.Utilities;
using Xunit;

namespace LCD_Kat.Tests
{
    public class MultipleNumberStrategyTest
    {
        private readonly MultipleNumberStrategy _target;

        public MultipleNumberStrategyTest()
        {

            var generator = new GenerateLcdNumber();
            var splitter = new NumberSplitter(generator);
            _target = new MultipleNumberStrategy(splitter);
        }

        [Fact]
        public void CreatesMultipleNumberOutput_TestIfOutputIsCorrect()
        {
            const string expectedString = "     -   - \r\n  |   |   |\r\n     -   - \r\n  | |     |\r\n     -   - ";
            var output = _target.ConvertNumber(123);

            Assert.Equal(expectedString, output);
        }
    }
}