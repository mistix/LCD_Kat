using LCD_Kat.Utilities;

namespace LCD_Kat.Abstracts
{
    public interface INumberPickerFactory
    {
        INumberCreationStrategy Create(NumberCount numberCount);
    }
}