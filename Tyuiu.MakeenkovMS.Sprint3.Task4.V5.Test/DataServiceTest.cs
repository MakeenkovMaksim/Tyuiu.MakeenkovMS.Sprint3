using Tyuiu.MakeenkovMS.Sprint3.Task4.V5.Lib;

namespace Tyuiu.MakeenkovMS.Sprint3.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            double wait = -0.323;
            double res = ds.Calculate(start, stop);
            Assert.AreEqual(wait, res);
        }
    }
}
