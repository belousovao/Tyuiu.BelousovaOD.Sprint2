using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BelousovaOD.Sprint2.Task1.V20.Lib
{
    public class DataService : ISprint2Task1V20
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = [(a == b) | (c < d), (a <= b) & (c != d), (a < b) || (c == d), (a != b) && (c > d), !(a == b), (a == b) ^ (c > d)];
            return result;
        }
    }
}
