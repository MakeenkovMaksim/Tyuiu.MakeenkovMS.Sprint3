using Tyuiu.MakeenkovMS.Sprint3.Task7.V25.Lib;

namespace Tyuiu.MakeenkovMS.Sprint3.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;

            double[] wait = new double[11];
            wait[0] = -12.18;
            wait[1] = -15.11;
            wait[2] = -12.03;
            wait[3] = -7.02;
            wait[4] = -4.08;
            wait[5] = 1;
            wait[6] = -1.46;
            wait[7] = -2.31;
            wait[8] = 0.22;
            wait[9] = 17.5;
            wait[10] = 23.86;

            double[] res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
