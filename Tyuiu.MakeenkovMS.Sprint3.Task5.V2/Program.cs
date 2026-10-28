using Tyuiu.MakeenkovMS.Sprint3.Task5.V2.Lib;

namespace Tyuiu.MakeenkovMS.Sprint3.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Макенков М. С. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* SPRINT #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Макенков Максим Сергеевич | ПИНб-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение функции по формуле при вложенных циклах              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int start1 = 1;
            int stop1 = 3;
            int start2 = 1;
            int stop2 = 12;

            Console.WriteLine("Переменная X = " + x);
            Console.WriteLine("Старт шага первого цикла = " + start1);
            Console.WriteLine("Конец шага первого цикла = " + stop1);
            Console.WriteLine("Старт шага второго цикла = " + start2);
            Console.WriteLine("Конец шага второго цикла = " + stop2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSumSeries(x, start1, stop1, start2, stop2);

            Console.WriteLine("Сумма сумм ряда = " + res);
            Console.ReadKey();
        }
    }
}
