using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DylginA.Sprint5.Task1.V7.Lib
{
    public class DataService : ISprint5Task1V7
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                 File.Delete(path); 
            }
            double fx;
            string strY;
            for(int x = startValue; x<= stopValue; x++)
            {
                fx = ((Math.Sin(x)) / (x + 1.2)) - Math.Sin(x) * 2 - (2 * x); ;
                strY = Convert.ToString(fx);
                 if (x != stopValue)
                 {
                     File.AppendAllText(path, strY + Environment.NewLine);
                 }
                 else
            {
            File.AppendAllText(path, strY);
            }
            }
            return path;
        }
    }     
}
