using System.Collections.Generic;
using System.Linq;
using LCD_Kat.Abstracts;

namespace LCD_Kat.Utilities
{
    public class NumberSplitter : INumberSplitter
    {
        private readonly IGenerateLcdNumber _numberGenerator;

        public NumberSplitter(IGenerateLcdNumber numberGenerator)
        {
            _numberGenerator = numberGenerator;
        }

        public IEnumerable<ILcdNumber> SplitNumber(int number)
        {
            int initialNumber = number;
            var numberStack = new Stack<int>();

            while (initialNumber > 0)
            {
                var divided = initialNumber / 10;
                var lastNumber = initialNumber - divided * 10;
                initialNumber = divided;

                numberStack.Push(lastNumber);
            }

            return numberStack
                .Select(stackNumber => _numberGenerator.GetNumber(stackNumber))
                .ToList();
        }
    }
}