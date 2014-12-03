using System;
using LCD_Kat.Abstracts;
using LCD_Kat.Strategies;

namespace LCD_Kat.Utilities
{
    public class NumberPickerFactory : INumberPickerFactory
    {
        private readonly IGenerateLcdNumber _generateLcdNumber;
        private readonly INumberSplitter _numberSplitter;

        public NumberPickerFactory(IGenerateLcdNumber generateLcdNumber, INumberSplitter numberSplitter)
        {
            _generateLcdNumber = generateLcdNumber;
            _numberSplitter = numberSplitter;
        }

        public INumberCreationStrategy Create(NumberCount numberCount)
        {
            switch (numberCount)
            {
                case NumberCount.SingleNumber:
                    return new SingleNumberStrategy(_generateLcdNumber);
                case NumberCount.MultipleNumber:
                    return new MultipleNumberStrategy(_numberSplitter);
                default:
                    throw new ArgumentOutOfRangeException("numberCount");
            }
        }
    }
}