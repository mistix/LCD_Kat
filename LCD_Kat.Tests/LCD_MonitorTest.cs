using LCD_Kat.Utilities;
using Xunit;

namespace LCD_Kat.Tests
{
    public class LCD_MonitorTest
    {
        private readonly LCDMonitor _lcdMonitor;

        public LCD_MonitorTest()
        {
            var generateNumber = new GenerateLcdNumber();
            var numberSplitter = new NumberSplitter(generateNumber);

            var numberPicker = new NumberPickerFactory(generateNumber, numberSplitter);
            var multipleNumberFinder = new MultipleNumberFinder();

            _lcdMonitor = new LCDMonitor(numberPicker, multipleNumberFinder);
        }

        [Fact]
        public void NumberOne_PrintNumberOne()
        {
            const string expectedValue = "   \r\n  |\r\n   \r\n  |\r\n   ";
            string actualValue = _lcdMonitor.PrintNumber(1);

            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void PrintNumber_123()
        {
            const string expectedString = "     -   - \r\n  |   |   |\r\n     -   - \r\n  | |     |\r\n     -   - ";
            string actualValue = _lcdMonitor.PrintNumber(123);

            Assert.Equal(expectedString, actualValue);
        }
    }
}
