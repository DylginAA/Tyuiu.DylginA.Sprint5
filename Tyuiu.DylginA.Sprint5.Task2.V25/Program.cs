using Tyuiu.DylginA.Sprint5.Task2.V25.Lib;
namespace Tyuiu.DylginA.Sprint5.Task2.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5");
            Console.WriteLine("* Тема: Класс File");
            Console.WriteLine("* Задание #2");
            Console.WriteLine("* Вариант #25");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с клавиатуры. " +
                "Заменить нечетные элементы массива на 0. Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = {
            { 4, 8, 5 },
            { 1, 4, 2 },
            { 4, 9, 9 }
        };
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Файл" + res);
            Console.WriteLine("Создан");
        }
    }
}
