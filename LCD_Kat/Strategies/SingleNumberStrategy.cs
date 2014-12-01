using System;
using LCD_Kat.Abstracts;
using LCD_Kat.Numbers;

namespace LCD_Kat.Strategies
{
    public class SingleNumberStrategy : INumberCreationStrategy
    {
        public string ConvertNumber(int number)
        {
            ILCDNumber lcdNumber = null;

            switch (number)
            {
                case 0:
                    lcdNumber = new ZeroLcdNumber();
                    break;
                case 1:
                    lcdNumber = new OneLcdNumber();
                    break;
                case 2:
                    lcdNumber = new TwoLcdNumber();
                    break;
                case 3:
                    lcdNumber = new ThreeLcdNumber();
                    break;
                case 4:
                    lcdNumber = new FourLcdNumber();
                    break;
                case 5:
                    lcdNumber = new FiveLcdNumber();
                    break;
                case 6:
                    lcdNumber = new SixLcdNumber();
                    break;
                case 7:
                    lcdNumber = new SevenLcdNumber();
                    break;
                case 8:
                    lcdNumber = new EightLcdNumber();
                    break;
                case 9:
                    lcdNumber = new NineLcdNumber();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("number");
            }

            if (lcdNumber == null)
                throw new NullReferenceException("lcdNumber");

            return lcdNumber.PrintNumber();
        }
    }
}