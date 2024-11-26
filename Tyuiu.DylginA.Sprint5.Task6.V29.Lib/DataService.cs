using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DylginA.Sprint5.Task6.V29.Lib
{
    public class DataService : ISprint5Task6V29
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] words = text.Split(' ');

            int count = 0;

            foreach (string word in words)
            {
                if (word.Length == 7) 
                {
                    count++;
                }
            }

            return count;
        }


    }
}
