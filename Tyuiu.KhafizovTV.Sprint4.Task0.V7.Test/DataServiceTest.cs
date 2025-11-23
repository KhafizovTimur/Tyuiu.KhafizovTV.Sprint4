using Tyuiu.KhafizovTV.Sprint4.Task0.V7.Lib;

namespace Tyuiu.KhafizovTV.Sprint4.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();

            int wait = 0;
            int[] numsArray = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            int res = ds.GetMultOddArrEl(numsArray);
            Assert.AreEqual(wait, res);
        }
    }
}
