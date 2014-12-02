using System.Collections.Generic;

namespace LCD_Kat.Abstracts
{
    public interface INumberSplitter
    {
        IEnumerable<ILCDNumber> SplitNumber(int number);
    }
}