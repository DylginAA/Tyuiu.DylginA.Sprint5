using Tyuiu.DylginA.Sprint5.Task6.V29.Lib;
namespace Tyuiu.DylginA.Sprint5.Task6.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5");
            Console.WriteLine("* Тема: Чтение данных");
            Console.WriteLine("* Задание #6");
            Console.WriteLine("* Вариант #29");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Найти количество слов длиной семь символов в заданной строке. ");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine(Path.GetTempPath(), "DataSprint5", "InPutDataFileTask6V29.txt");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Данные находятся в: {path}");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Ответ:" + res);
            Console.ReadKey();
        }
    }
}
