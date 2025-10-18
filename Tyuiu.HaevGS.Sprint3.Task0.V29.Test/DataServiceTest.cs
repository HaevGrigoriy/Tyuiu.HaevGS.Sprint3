using Tyuiu.HaevGS.Sprint3.Task0.V29.Lib;

namespace Tyuiu.HaevGS.Sprint3.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 5;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 56.352;

            Assert.AreEqual(wait,res);


        }
    }
}
