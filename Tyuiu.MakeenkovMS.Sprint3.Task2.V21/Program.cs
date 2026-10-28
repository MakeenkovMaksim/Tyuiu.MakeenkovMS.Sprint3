using Tyuiu.MakeenkovMS.Sprint3.Task2.V21.Lib;

namespace Tyuiu.MakeenkovMS.Sprint3.Task2.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Макенков М. С. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* SPRINT #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Макенков Максим Сергеевич | ПИНб-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя цикл do...while, которая вычисляет        *");
            Console.WriteLine("* сумму ряда по формуле, при x = 1,5                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 1.5;
            int start = 1;
            int stop = 10;

            Console.WriteLine("Переменная X = " + x);
            Console.WriteLine("Старт шага = " + start);
            Console.WriteLine("Конец шага = " + stop);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSeries(x, start, stop);

            Console.WriteLine("Сумма ряда S = " + res);
            Console.ReadKey();
        }
    }
}
