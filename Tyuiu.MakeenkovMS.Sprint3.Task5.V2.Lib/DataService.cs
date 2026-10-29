using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MakeenkovMS.Sprint3.Task5.V2.Lib
{
    public class DataService : ISprint3Task5V2
    {
        public double GetSumSumSeries(int value, int startValue1, int stopValue1, int startValue2, int stopValue2)
        {
            double sum = 0;
            double x = value;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sum += (Math.Cos(k) + x) / x;
                }
            }

            return Math.Round(sum, 3);
        }
    }
}
