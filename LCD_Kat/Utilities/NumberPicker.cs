using System;
using LCD_Kat.Abstracts;
using LCD_Kat.Strategies;

namespace LCD_Kat.Utilities
{
    public class NumberPicker : INumberPicker
    {
        public INumberCreationStrategy Create(NumberCount numberCount)
        {
            switch (numberCount)
            {
                case NumberCount.SingleNumber:
                    // FIXME: change way of injecting this class
                    return new SingleNumberStrategy(new GenerateLcdNumber());
                case NumberCount.MultipleNumber:
                    return new MultipleNumberStrategy(new NumberSplitter(new GenerateLcdNumber()));
                default:
                    throw new ArgumentOutOfRangeException("numberCount");
            }
        }
    }
}