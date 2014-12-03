using System;
using System.Linq;
using LCD_Kat.Abstracts;
using Ninject;

namespace LCD_Kat
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool quitProgram = false;
            var ninjectKernel = new StandardKernel(new LcdNinjectModule());
            var numberPicker = ninjectKernel.Get<INumberPickerFactory>();
            var multipleNumberFinder = ninjectKernel.Get<IMultipleNumberFinder>();

            var lcdMonitor = new LCDMonitor(numberPicker, multipleNumberFinder);

            while (!quitProgram)
            {
                Console.Write("Podaj liczbę: ");
                var numberText = Console.ReadLine();
                var number = Convert.ToInt32(numberText);

                var output = lcdMonitor.PrintNumber(number);
                Console.Write(output);

                Console.WriteLine();
                Console.Write("Kontynuować? [T\\N]:");
                string result = Console.ReadLine();

                if (result != null)
                    quitProgram = result.ToLower().ElementAt(0) == 'n';
            }
        }
    }


}
