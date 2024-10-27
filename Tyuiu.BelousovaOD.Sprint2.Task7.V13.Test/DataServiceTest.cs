using Tyuiu.BelousovaOD.Sprint2.Task7.V13.Lib;
namespace Tyuiu.BelousovaOD.Sprint2.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckDotInShadedArea(2, 1));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(2, 0));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0.8, -0.6));
        }
    }
}