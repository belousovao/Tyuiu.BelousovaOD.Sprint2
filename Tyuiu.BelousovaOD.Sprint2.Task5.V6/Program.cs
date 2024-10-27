using Tyuiu.BelousovaOD.Sprint2.Task5.V6.Lib;
namespace Tyuiu.BelousovaOD.Sprint2.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Белоусова О. Д. | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Белоусова Ольга Дмитриевна | СМАРТБ-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                     *");
            Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера:    *");
            Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3,                 *");
            Console.WriteLine("* масти «червы» — 4, а достоинству карт: «валету» — 11, «даме» — 12,      *");
            Console.WriteLine("*«королю» — 13, «тузу» — 14 (порядковые номера карт остальных достоинств  *");
            Console.WriteLine("*  соответствуют их названиям: «шестерка», «девятка» и т. п.).            *");
            Console.WriteLine("*  По заданным номеру масти m (1 <= m <= 4) и номеру достоинства карты    *");
            Console.WriteLine("* k (6 <= k <= 14) определить полное название (масть и достоинство)       *");
            Console.WriteLine("* соответствующей карты в виде «Дама пик», Шестерка бубен» и т. п.        *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер масти: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номер достоинства карты: ");
            int k = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((m < 1) || (m > 4) && (k < 6) || (k > 14))
            {
                res = "Введен неверный номер масти или номер достоинства карты!";
            }
            else
            {
                res = " Название карты = " + ds.FindCardNameAndValue(m, k);

            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);


            Console.ReadKey();
        }
    }
}
