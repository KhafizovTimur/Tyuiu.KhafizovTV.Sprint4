using Tyuiu.KhafizovTV.Sprint4.Task1.V4.Lib;

namespace Tyuiu.KhafizovTV.Sprint4.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int wait = 0;
            int[] numsArray = { 1, 2, 5, 3, 4, 7, 8, 8, 3, 9 };
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(wait, res);
        }
    }
}