using System;
using System.Text;
using LCD_Kat.Abstracts;

namespace LCD_Kat.Strategies
{
    public class SingleNumberStrategy : INumberCreationStrategy
    {
        private const int RowsCount = 5;
        private const int ColumnsCount = 3;

        private readonly IGenerateLcdNumber _numberGenerator;
        private readonly StringBuilder _stringBuilder;

        public SingleNumberStrategy(IGenerateLcdNumber numberGenerator)
        {
            _numberGenerator = numberGenerator;
            _stringBuilder = new StringBuilder();
        }

        public string ConvertNumber(int number)
        {
            ILcdNumber lcdNumber = _numberGenerator.GetNumber(number);

            if (lcdNumber == null)
                throw new NullReferenceException("lcdNumber");

            var array = lcdNumber.PrintNumber();
            _stringBuilder.Clear();

            for (var row = 0; row < RowsCount; row++)
            {
                for (var col = 0; col < ColumnsCount; col++)
                    _stringBuilder.Append(array[row, col]);

                if (row < RowsCount - 1)
                    _stringBuilder.AppendLine();
            }

            return _stringBuilder.ToString();
        }
    }
}