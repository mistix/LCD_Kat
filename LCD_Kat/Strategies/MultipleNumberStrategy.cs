using System.Collections;
using System.Collections.Generic;
using LCD_Kat.Abstracts;

namespace LCD_Kat.Strategies
{
    public class MultipleNumberStrategy : INumberCreationStrategy
    {
        private readonly INumberSplitter _numberSplitter;

        public MultipleNumberStrategy(INumberSplitter numberSplitter)
        {
            _numberSplitter = numberSplitter;
        }

        public string ConvertNumber(int number)
        {
            IEnumerable<ILCDNumber> lcdNumbers = _numberSplitter.SplitNumber(number);

            return string.Empty;
        }
    }
}