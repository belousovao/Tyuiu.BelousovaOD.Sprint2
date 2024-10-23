using Tyuiu.BelousovaOD.Sprint2.Task1.V20.Lib;
namespace Tyuiu.BelousovaOD.Sprint2.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            bool[] valid = [false, false, false, true, true, true];
            int a = 242, b = 155, c = 456, d = 17;

            CollectionAssert.AreEqual(valid, ds.GetLogicOperations(a, b, c, d));
        }
    }
}