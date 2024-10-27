using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BelousovaOD.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res = "";
            string str = "";

            switch (value1)
            {
                case 1:
                    res = "пики";
                    break;
                case 2:
                    res = "трефы";
                    break;
                case 3:
                    res = "бубен";
                    break;
                case 4:
                    res = "червы";
                    break;
                default:
                    throw new ArgumentException($"Масть должна быть от 1 до 4. Значение {value1}");
            }

            switch (value2)
            {
                case 6:
                    str = "Шесть";
                    break;
                case 7:
                    str = "Семь";
                    break;
                case 8:
                    str = "Восемь";
                    break;
                case 9:
                    str = "Девять";
                    break;
                case 10:
                    str = "Десять";
                    break;
                case 11:
                    str = "Валет";
                    break;
                case 12:
                    str = "Дама";
                    break;
                case 13:
                    str = "Король";
                    break;
                case 14:
                    str = "Туз";
                    break;
                default:
                    throw new ArgumentException($"Достоинство должно быть от 6 до 14. Значение {value2}");
            }

            return $"{str} {res}";
        }
    }
}
