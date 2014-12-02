using System;
using LCD_Kat.Abstracts;
using LCD_Kat.Utilities;

namespace LCD_Kat.Strategies
{
    public class SingleNumberStrategy : INumberCreationStrategy
    {
        private readonly IGenerateLcdNumber _numberGenerator;

        public SingleNumberStrategy(IGenerateLcdNumber numberGenerator)
        {
            _numberGenerator = numberGenerator;
        }

        public string ConvertNumber(int number)
        {
            ILCDNumber lcdNumber = _numberGenerator.GetNumber(number);

            if (lcdNumber == null)
                throw new NullReferenceException("lcdNumber");

            return lcdNumber.PrintNumber();
        }
    }
}