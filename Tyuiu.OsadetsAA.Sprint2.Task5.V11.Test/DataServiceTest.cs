using Tyuiu.OsadetsAA.Sprint2.Task5.V11.Lib;
namespace Tyuiu.OsadetsAA.Sprint2.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int g = 2022;
            int m = 6;
            int n = 25;
            var res = ds.FindDateOfNextDay(g, m, n);
            string wait = "2022626";
            Assert.AreEqual(wait, res);
        }
    }
}