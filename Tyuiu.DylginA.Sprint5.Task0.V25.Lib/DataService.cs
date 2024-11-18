using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DylginA.Sprint5.Task0.V25.Lib
{
    public class DataService : ISprint5Task0V25
    {
        public string SaveToFileTextData(int x)
        {
            string outputfile = Path.GetTempFileName(); ;
            double result = Math.Round((3*Math.Pow(x,4)+1)/Math.Pow(x,3),3);
            File.WriteAllText(outputfile,Convert.ToString(result));
            return outputfile;
        }
    }
}
