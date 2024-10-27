using Tyuiu.BelousovaOD.Sprint2.Task5.V6.Lib;
namespace Tyuiu.BelousovaOD.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Шесть пики", ds.FindCardNameAndValue(1, 6));
            Assert.AreEqual("Дама бубен", ds.FindCardNameAndValue(3, 12));
            Assert.AreEqual("Восемь червы", ds.FindCardNameAndValue(4, 8));
            Assert.AreEqual("Туз трефы", ds.FindCardNameAndValue(2, 14));
            Assert.AreEqual("Король пик", ds.FindCardNameAndValue(1, 13));
            Assert.AreEqual("Валет трефы", ds.FindCardNameAndValue(2, 11));

        }
    }
}