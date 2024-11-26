using Tyuiu.DylginA.Sprint5.Task5.V22.Lib;
namespace Tyuiu.DylginA.Sprint5.Task5.V22
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
            Console.WriteLine("* Задание #5");
            Console.WriteLine("* Вариант #22");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Найти минимальное целое число в файле, которое делится на 4. Полученный результат вывести на консоль. ");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine(Path.GetTempPath(), "DataSprint5", "InPutDataFileTask5V22.txt");
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
