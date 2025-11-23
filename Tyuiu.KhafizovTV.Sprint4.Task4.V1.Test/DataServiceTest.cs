using Tyuiu.KhafizovTV.Sprint4.Task4.V1.Lib;

namespace Tyuiu.KhafizovTV.Sprint4.Task4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas = new int[5, 5] { { 2, 5, 1, 7, 5 },
                                          { 4, 4, 7, 4, 4 },
                                          { 7, 1, 6, 8, 8 },
                                          { 8, 1, 5, 8, 4 },
                                          { 8, 9, 1, 7, 3 } };
            int res = ds.Calculate(mas);
            int wait = 68;

            Assert.AreEqual(wait, res);
        }
    }
}