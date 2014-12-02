using System.Linq;
using LCD_Kat.Numbers;
using LCD_Kat.Utilities;
using Xunit;

namespace LCD_Kat.Tests
{
    public class NumberSplitterTest
    {
        private readonly NumberSplitter _target;

        public NumberSplitterTest()
        {
            var generator = new GenerateLcdNumber();
            _target = new NumberSplitter(generator);
        }

        [Fact]
        public void SplitsNumber_To_SingleNumbers_CompareIfTypesMatch()
        {
            var numbers = _target.SplitNumber(123);

            Assert.Equal(numbers.Count(), 3);
            Assert.IsType(typeof(OneLcdNumber), numbers.ElementAt(0));
            Assert.IsType(typeof(TwoLcdNumber), numbers.ElementAt(1));
            Assert.IsType(typeof(ThreeLcdNumber), numbers.ElementAt(2));
        }

        [Fact]
        public void SplitsNumberToSingleNumbers_CompareIfTypesMatch_Number5209()
        {
            var numbers = _target.SplitNumber(5209);

            Assert.Equal(numbers.Count(), 4);
            Assert.IsType(typeof(FiveLcdNumber), numbers.ElementAt(0));
            Assert.IsType(typeof(TwoLcdNumber), numbers.ElementAt(1));
            Assert.IsType(typeof(ZeroLcdNumber), numbers.ElementAt(2));
            Assert.IsType(typeof(NineLcdNumber), numbers.ElementAt(3));
        }
    }
}