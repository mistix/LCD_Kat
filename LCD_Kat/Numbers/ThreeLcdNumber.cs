using LCD_Kat.Abstracts;

namespace LCD_Kat.Numbers
{
    public class ThreeLcdNumber : ILCDNumber
    {
        public string PrintNumber()
        {
            return @" - \r\n  |\r\n - \r\n  |\r\n - ";
        }
    }
}