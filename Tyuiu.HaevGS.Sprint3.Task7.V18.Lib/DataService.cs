using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.HaevGS.Sprint3.Task7.V18.Lib
{
    public class DataService : ISprint3Task7V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] a = new double[11];
            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) + 1 == 0) a[i] = 0;
                else a[i] = Math.Round(2 * x - 4 + ((2 * x - 1) / (Math.Sin(x) + 1)), 2);
                i++;
            }
            return a;
        }
    }   
}