using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LCD_Kat.Abstracts;

namespace LCD_Kat.Strategies
{
    public class MultipleNumberStrategy : INumberCreationStrategy
    {
        private const int ColumnsInLcdDisplay = 3;
        private const int RowsInLcdDisplay = 5;
        private const int SpaceBeetweneNumbers = 4;

        private readonly INumberSplitter _numberSplitter;
        private readonly StringBuilder _stringBuilder;

        private char[,] _lcdDisplay;
        private int _columnsInDisplay;

        public MultipleNumberStrategy(INumberSplitter numberSplitter)
        {
            _numberSplitter = numberSplitter;
            _stringBuilder = new StringBuilder();
        }

        public string ConvertNumber(int number)
        {
            _stringBuilder.Clear();
            IEnumerable<ILcdNumber> lcdNumbers = _numberSplitter.SplitNumber(number).ToArray();

            int positionInArray = 0;
            CreateLcdDisplay(lcdNumbers);

            foreach (ILcdNumber lcdNumber in lcdNumbers)
            {
                var array = lcdNumber.PrintNumber();

                for (var row = 0; row < RowsInLcdDisplay; row++)
                {
                    for (var col = 0; col < ColumnsInLcdDisplay; col++)
                        _lcdDisplay[row, col + positionInArray] = array[row, col];
                }
                positionInArray += SpaceBeetweneNumbers;
            }

            ConvertToString();

            return _stringBuilder.ToString();
        }

        private void CreateLcdDisplay(IEnumerable<ILcdNumber> lcdNumbers)
        {
            var numberCount = lcdNumbers.Count();
            _columnsInDisplay = numberCount * ColumnsInLcdDisplay + numberCount - 1;

            _lcdDisplay = new char[RowsInLcdDisplay, _columnsInDisplay];

            InitializeLcdDisplayWithSpaces();
        }

        private void InitializeLcdDisplayWithSpaces()
        {
            for (var row = 0; row < RowsInLcdDisplay; row++)
            {
                for (var col = 0; col < _columnsInDisplay; col++)
                    _lcdDisplay[row, col] = ' ';
            }
        }

        private void ConvertToString()
        {
            for (var row = 0; row < RowsInLcdDisplay; row++)
            {
                for (var col = 0; col < _columnsInDisplay; col++)
                    _stringBuilder.Append(_lcdDisplay[row, col]);

                if (row < RowsInLcdDisplay - 1)
                    _stringBuilder.AppendLine();
            }
        }
    }
}