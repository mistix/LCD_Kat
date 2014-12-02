using LCD_Kat.Utilities;

namespace LCD_Kat.Abstracts
{
    public interface INumberPicker
    {
        INumberCreationStrategy Create(NumberCount numberCount);
    }
}