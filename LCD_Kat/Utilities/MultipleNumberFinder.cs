using System;
using LCD_Kat.Abstracts;

namespace LCD_Kat.Utilities
{
    public class MultipleNumberFinder : IMultipleNumberFinder
    {
        public NumberCount GetNumberCount(int number)
        {
            if (number < -1)
                throw new ArgumentException("number");

            return number >= 0 && number < 10
                ? NumberCount.SingleNumber
                : NumberCount.MultipleNumber;
        }
    }
}