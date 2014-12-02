using LCD_Kat.Utilities;
using Xunit;
using Xunit.Extensions;

namespace LCD_Kat.Tests
{
    public class MultipleNumberFinderTest
    {
        [Theory]
        [InlineData(1, NumberCount.SingleNumber)]
        [InlineData(12, NumberCount.MultipleNumber)]
        public void SingleNumberExpected_Successfull(int number, NumberCount expectedResult)
        {
            var target = new MultipleNumberFinder();
            var actualNumber = target.GetNumberCount(number);

            Assert.Equal(expectedResult, actualNumber);
        }
    }
}