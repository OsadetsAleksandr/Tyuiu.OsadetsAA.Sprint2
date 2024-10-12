using Tyuiu.OsadetsAA.Sprint2.Task4.V29.Lib;
namespace Tyuiu.OsadetsAA.Sprint2.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConition()
        {
            DataService ds = new DataService();
            double x = -2;
            double y = 18;
            double res = ds.Calculate(x, y);
            double wait = 213;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidConition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 8.5;
            Assert.AreEqual(wait, res);
        }
    }
}