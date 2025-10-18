using tyuiu.cources.programming.interfaces.Sprint2;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.HaevGS.Sprint3.Task2.V18.Lib
{
    public class DataService : ISprint3Task2V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            int sm = 0;
            do
            {
                sm += (int)(Math.Cos(value) + Math.Pow(startValue / 8, 3));
                startValue++;
            } while (startValue <= stopValue);
            return sm;
        }
    }
}
