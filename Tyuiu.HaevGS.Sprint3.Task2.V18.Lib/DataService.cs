using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.HaevGS.Sprint3.Task2.V18.Lib
{
    public class DataService : ISprint3Task2V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sm = 1;
            do
            {
                sm *= (Math.Cos(value) + Math.Pow(sm / 8, 3));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(sm, 3);
        }
    }
}
