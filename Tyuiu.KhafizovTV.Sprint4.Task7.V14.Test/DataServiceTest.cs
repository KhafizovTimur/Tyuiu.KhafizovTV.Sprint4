using Tyuiu.KhafizovTV.Sprint4.Task7.V14.Lib;

namespace Tyuiu.KhafizovTV.Sprint4.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 4;
            int[,] mtrx = new int[n, m];
            string str = "458712659137";
            int res = ds.Calculate(n, m, str);
            int wait = 38;
            Assert.AreEqual(wait, res);
        }
    }
}