using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MakeenkovMS.Sprint3.Task2.V21.Lib
{
    public class DataService : ISprint3Task2V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;

            do
            {
                double denominator = Math.Sin(k) + 2 * Math.Pow(value, k);
                double term = Math.Pow(1 / denominator, k);
                sum += term;
                k++;
            }
            while (k <= stopValue);

            return Math.Round(sum, 3);
        }
    }
}
