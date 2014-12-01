namespace LCD_Kat.Abstracts
{
    public interface IMultipleNumberFinder
    {
        NumberCount GetNumberCount(int number);
    }

    public class MultipleNumberFinder : IMultipleNumberFinder
    {
        public NumberCount GetNumberCount(int number)
        {
            throw new System.NotImplementedException();
        }
    }
}