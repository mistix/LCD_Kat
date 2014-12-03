using LCD_Kat.Abstracts;
using LCD_Kat.Utilities;
using Ninject.Modules;

namespace LCD_Kat
{
    public class LcdNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGenerateLcdNumber>().To<GenerateLcdNumber>();
            Bind<INumberSplitter>().To<NumberSplitter>();
            Bind<INumberPickerFactory>().To<NumberPickerFactory>();
            Bind<IMultipleNumberFinder>().To<MultipleNumberFinder>();
        }
    }
}