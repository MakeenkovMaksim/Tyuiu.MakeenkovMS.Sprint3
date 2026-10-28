using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MakeenkovMS.Sprint3.Task3.V18.Lib
{
    public class DataService : ISprint3Task3V18
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string result = "";
            foreach (char chr in value)
            {
                if (char.IsDigit(chr))
                {
                    result += item;
                }
                else
                {
                    result += chr;
                }
            }
            return result;
        }
    }
}
