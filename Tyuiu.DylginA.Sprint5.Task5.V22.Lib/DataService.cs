using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.DylginA.Sprint5.Task5.V22.Lib
{
    public class DataService : ISprint5Task5V22
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path).Replace('.', ',');
            string[] strings = text.Split(' ');

            double minNumber = double.MaxValue;

            foreach (string str in strings)
            {
                if (double.TryParse(str.Trim(), out double number))
                {
                    if (number % 1 == 0 && number % 4 == 0)
                    {
                        minNumber = number;
                    }
                }
            }
            return minNumber;
        }
    }
}
