using LCD_Kat.Abstracts;
using LCD_Kat.Utilities;

namespace LCD_Kat
{
    public class LCDMonitor
    {
        private readonly INumberPickerFactory _numberPickerFactory;
        private readonly IMultipleNumberFinder _multipleFinder;

        public LCDMonitor(INumberPickerFactory numberPickerFactory, IMultipleNumberFinder multipleFinder)
        {
            _numberPickerFactory = numberPickerFactory;
            _multipleFinder = multipleFinder;
        }

        public string PrintNumber(int number)
        {
            NumberCount numberCount = _multipleFinder.GetNumberCount(number);
            INumberCreationStrategy creationStrategy = _numberPickerFactory.Create(numberCount);

            return creationStrategy.ConvertNumber(number);
        }
    }
}