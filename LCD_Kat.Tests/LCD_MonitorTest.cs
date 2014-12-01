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
            const string expectedValue = "   " +
                                         "  |" +
                                         "   " +
                                         "  |" +
                                         "   ";

            var monitor = new LCDMonitor();

            string actualValue = monitor.PrintNumber(1);

            Assert.Equal(expectedValue, actualValue);
        }
    }
}
