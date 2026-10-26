using Tyuiu.MakeenkovMS.Sprint3.Task1.V16.Lib;

namespace Tyuiu.MakeenkovMS.Sprint3.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double x = 0.7;
            int start = 1;
            int stop = 15;

            double res = ds.GetSumSeries(x, start, stop);
            double wait = 15.948;

            Assert.AreEqual(wait, res);
        }
    }
}
