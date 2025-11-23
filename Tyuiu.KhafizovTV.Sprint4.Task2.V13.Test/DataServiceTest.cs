using Tyuiu.KhafizovTV.Sprint4.Task2.V13.Lib;

namespace Tyuiu.KhafizovTV.Sprint4.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();

            int[] numsArray = { 3, 4, 3, 4, 2, 5, 6, 5, 4, 3, 5, 6, 2 };
            int res = ds.Calculate(numsArray);
            int wait = 9216;
            Assert.AreEqual(wait, res);
        }
    }
}