using Tyuiu.MakeenkovMS.Sprint3.Task0.V25.Lib;

namespace Tyuiu.MakeenkovMS.Sprint3.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int x = 5;
            int start = 1;
            int stop = 14;

            double res = ds.GetSumSeries(x, start, stop);
            double wait = 0.691;

            Assert.AreEqual(wait, res);
        }
    }
}
