using LCD_Kat.Abstracts;

namespace LCD_Kat
{
    public class LCDMonitor
    {
        private readonly INumberPicker _numberPicker;
        private readonly IMultipleNumberFinder _multipleFinder;

        public LCDMonitor(INumberPicker numberPicker, IMultipleNumberFinder multipleFinder)
        {
            _numberPicker = numberPicker;
            _multipleFinder = multipleFinder;
        }

        public string PrintNumber(int number)
        {
            NumberCount numberCount = _multipleFinder.GetNumberCount(number);
            INumberCreationStrategy creationStrategy = _numberPicker.Create(numberCount);

            return creationStrategy.ConvertNumber(number);
        }
    }
}