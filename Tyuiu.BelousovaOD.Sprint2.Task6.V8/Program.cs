using Tyuiu.BelousovaOD.Sprint2.Task6.V8.Lib;
namespace Tyuiu.BelousovaOD.Sprint2.Task6.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Белоусова О. Д. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Белоусова Ольга Дмитриевна  | СМАРТб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами: m и n.  *");
            Console.WriteLine("* По заданным n и m определить дату предыдущего дня                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int m, n;
            Console.WriteLine("Введите порядковый номер месяца: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число: ");
            n = Convert.ToInt32(Console.ReadLine());
            string res;
            if ((m < 1 || m > 12) || (n < 1 || n > 31))
            {
                res = "Введено неверное значение.";
            }
            else
            {
                res = ds.FindDateOfPreviousDay(m, n);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
