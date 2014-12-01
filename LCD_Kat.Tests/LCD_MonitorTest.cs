using System.Dynamic;
using Ninject;
using Xunit;

namespace LCD_Kat.Tests
{
    public class LCD_MonitorTest
    {
        [Fact]
        public void NumberOne_PrintNumberOne()
        {
            const string expectedValue = @"   \r\n  |\r\n   \r\n  |\r\n   ";

            var numberPicker = new NumberPicker();
            var multipleNumberFinder = new MultipleNumberFinder();

            var monitor = new LCDMonitor(numberPicker, multipleNumberFinder);

            string actualValue = monitor.PrintNumber(1);

            Assert.Equal(expectedValue, actualValue);
        }
    }
}
