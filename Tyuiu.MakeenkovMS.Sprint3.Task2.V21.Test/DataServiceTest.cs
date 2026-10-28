using Tyuiu.MakeenkovMS.Sprint3.Task2.V21.Lib;

namespace Tyuiu.MakeenkovMS.Sprint3.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double x = 1.5;
            int start = 1;
            int stop = 10;
            double wait = 0.297;
            double res = ds.GetSumSeries(x, start, stop);
            Assert.AreEqual(wait, res);
        }
    }
}
