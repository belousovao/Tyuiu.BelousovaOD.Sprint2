using Tyuiu.BelousovaOD.Sprint2.Task2.V6.Lib;
namespace Tyuiu.BelousovaOD.Sprint2.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 3;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wair = true;
            Assert.AreEqual(wair, res);
        }
    }
}