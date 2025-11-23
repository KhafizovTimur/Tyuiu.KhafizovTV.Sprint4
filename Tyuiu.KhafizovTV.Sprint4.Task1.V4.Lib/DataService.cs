using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhafizovTV.Sprint4.Task1.V4.Lib
{
    public class DataService : ISprint4Task1V4
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    product *= array[i];
                }
            }
            return product;
        }
    }
}