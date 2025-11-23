using Tyuiu.KhafizovTV.Sprint4.Task5.V20.Lib;

namespace Tyuiu.KhafizovTV.Sprint4.Task5.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 3, 2, -1, -6, 3 },
                                          { -4, 3, -7, 1, -5 },
                                          { 2, -3, -6, 3, 3 },
                                          { -4, -1, -4, -2, -0 },
                                          { -5, -7, -6, 2, -2 } };
            int res = ds.Calculate(mas2);
            int wait = 22;

            Assert.AreEqual(wait, res);
        }
    }
}