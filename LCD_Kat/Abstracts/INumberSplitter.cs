using System.Collections.Generic;

namespace LCD_Kat.Abstracts
{
    public interface INumberSplitter
    {
        IEnumerable<ILcdNumber> SplitNumber(int number);
    }
}