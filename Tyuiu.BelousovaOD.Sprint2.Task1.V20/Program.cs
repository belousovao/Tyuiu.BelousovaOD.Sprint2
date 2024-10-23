using Tyuiu.BelousovaOD.Sprint2.Task1.V20.Lib;
namespace Tyuiu.BelousovaOD.Sprint2.Task1.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Белоусова О. Д. | СМАРТб-24-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #2                                                            *");
            Console.WriteLine("* Тема: Логические операции                                            *");
            Console.WriteLine("* Задание #1                                                           *");
            Console.WriteLine("* Вариант #20                                                          *");
            Console.WriteLine("* Выполнила: Белоусова О. Д. | СМАРТб-24-1                             *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций,      *");
            Console.WriteLine("* а также арифметических выражений,                                    *");
            Console.WriteLine("* которая вернет логическую последовательность(массив)                 *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            int a = 242, b = 155, c = 456, d = 17;
            bool[] res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine($"a = {a}\nb = {b}\nc = {c}\nd = {d}");

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadLine();
        }
    }
}
