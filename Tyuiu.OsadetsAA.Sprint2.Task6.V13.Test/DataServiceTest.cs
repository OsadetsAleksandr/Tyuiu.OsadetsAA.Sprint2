using Tyuiu.OsadetsAA.Sprint2.Task6.V13.Lib;
namespace Tyuiu.OsadetsAA.Sprint2.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 9;
            int n = 8;
            var res = ds.FindDateOfNextDay(g, m, n);
            string wait = "09.09.2023";
            Assert.AreEqual(wait, res);
        }
    }
}