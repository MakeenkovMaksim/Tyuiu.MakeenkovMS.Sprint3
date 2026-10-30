using Tyuiu.MakeenkovMS.Sprint3.Task6.V5.Lib;

namespace Tyuiu.MakeenkovMS.Sprint3.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int start = 15;
            int stop = 22;
            int wait = 242; 
            int res = ds.GetSumTheDivisors(start, stop);
            Assert.AreEqual(wait, res);
        }
    }
}
