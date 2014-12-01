using System;
using LCD_Kat.Abstracts;

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
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    throw new ArgumentOutOfRangeException("number");
            }

            return lcdNumber.PrintNumber();
        }
    }
}