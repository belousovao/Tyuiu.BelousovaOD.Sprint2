using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BelousovaOD.Sprint2.Task0.V28.Lib
{
    public class DataService : ISprint2Task0V29
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y;
            res[1] = x + 624 != y;
            res[2] = y < x;
            res[3] = x * 2 > y;
            res[4] = x + 630 <= y;
            res[5] = x - 1000 >= y;
            return res;
        }
    }
}
