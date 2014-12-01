using System;
using LCD_Kat.Abstracts;
using LCD_Kat.Strategies;

namespace LCD_Kat
{
    public class NumberPicker : INumberPicker
    {
        public INumberCreationStrategy Create(NumberCount numberCount)
        {
            switch (numberCount)
            {
                case NumberCount.SingleNumber:
                    return new SingleNumberStrategy();
                case NumberCount.MultipleNumber:
                    return new MultipleNumberStrategy();
                default:
                    throw new ArgumentOutOfRangeException("numberCount");
            }
        }
    }
}