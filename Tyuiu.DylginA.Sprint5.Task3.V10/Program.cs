using Tyuiu.DylginA.Sprint5.Task3.V10.Lib;
namespace Tyuiu.DylginA.Sprint5.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5");
            Console.WriteLine("* Тема: Потоковый метод записи");
            Console.WriteLine("* Задание #3");
            Console.WriteLine("* Вариант #10");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Дано выражение , вычислить его значение при x = 4, результат сохранить в бинарный файл OutPutFileTask3.bin" +
                " и вывести на консоль. Округлить до трёх знаков после запятой.");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            int x = 4;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл" + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
