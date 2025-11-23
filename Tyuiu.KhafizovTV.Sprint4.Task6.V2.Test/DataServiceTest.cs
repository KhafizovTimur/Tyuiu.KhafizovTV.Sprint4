using Tyuiu.KhafizovTV.Sprint4.Task6.V2.Lib;

namespace Tyuiu.KhafizovTV.Sprint4.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var cities = new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };
            string[] res = ds.Calculate(cities);
            string[] wait = new string[] { "Черный", "Зеленый", "Красный", "Желтый", "Фиолетовый" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}