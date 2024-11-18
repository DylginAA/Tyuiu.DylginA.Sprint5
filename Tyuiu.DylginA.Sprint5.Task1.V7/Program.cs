using System.IO;
using Tyuiu.DylginA.Sprint5.Task1.V7.Lib;
namespace Tyuiu.DylginA.Sprint5.Task1.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4");
            Console.WriteLine("* Тема: Класс File");
            Console.WriteLine("* Задание #0");
            Console.WriteLine("* Вариант #25");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Дано выражение вычислить его значение при x = 3, результат сохранить в текстовый файл OutPutFileTask0.txt и вывести на консоль. " +
                "Округлить до трёх знаков после запятой.");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            int startValue = 5;
            int stopValue = -5;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл" + res);
            Console.WriteLine("Создан");
        }
    }
}
