using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.HaevGS.Sprint3.Task7.V18.Lib
{
    public class DataService : ISprint3Task7V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = (((2*x - 3) / Math.Cos(x) + x) + 5);
                valueArray[count] = y;
                count++;

            }
            return valueArray;
        }
    }
}
