using LCD_Kat.Abstracts;

namespace LCD_Kat.Numbers
{
    public class EightLcdNumber : ILcdNumber
    {
        public char[,] PrintNumber()
        {
            return new char[5, 3]
            {
                {' ', '-', ' '},
                {'|', ' ', '|'},
                {' ', '-', ' '},
                {'|', ' ', '|'},
                {' ', '-', ' '}
            };
        }
    }
}