using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DylginA.Sprint5.Task3.V10.Lib
{
    public class DataService : ISprint5Task3V10
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            double fx = -Math.Pow(x, 3)+4*Math.Pow(x,2)-((3/2)*x);
            fx = Math.Round(fx, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(fx));
            }



            return path;
        }
    }
}
