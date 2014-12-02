using System;
using LCD_Kat.Abstracts;
using LCD_Kat.Numbers;

namespace LCD_Kat.Utilities
{
    public class GenerateLcdNumber : IGenerateLcdNumber
    {
        public ILCDNumber GetNumber(int number)
        {
            switch (number)
            {
                case 0:
                    return new ZeroLcdNumber();
                case 1:
                    return new OneLcdNumber();
                case 2:
                    return new TwoLcdNumber();
                case 3:
                    return new ThreeLcdNumber();
                case 4:
                    return new FourLcdNumber();
                case 5:
                    return new FiveLcdNumber();
                case 6:
                    return new SixLcdNumber();
                case 7:
                    return new SevenLcdNumber();
                case 8:
                    return new EightLcdNumber();
                case 9:
                    return new NineLcdNumber();
                default:
                    throw new ArgumentOutOfRangeException("number");
            }
        }
    }
}