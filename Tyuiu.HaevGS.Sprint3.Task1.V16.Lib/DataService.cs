using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.HaevGS.Sprint3.Task1.V16.Lib
{
    public class DataService : ISprint3Task1V16
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double ms = 1;
            while(startValue <= stopValue)
            {
                ms += (value * value) * Math.Sin(ms) + 1;
                startValue++;
            }
            return Math.Round(ms, 3);
        }
    }
}
