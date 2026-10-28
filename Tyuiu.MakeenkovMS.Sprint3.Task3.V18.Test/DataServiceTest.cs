using Tyuiu.MakeenkovMS.Sprint3.Task3.V18.Lib;

namespace Tyuiu.MakeenkovMS.Sprint3.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();
            string value = "4n5nvf 56 bgy";
            char item = 'n';
            string wait = "nn5nvf nn bgy";
            string res = ds.ReplaceNumOnChar(value, item);
            Assert.AreEqual(wait, res);
        }
    }
}
