using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhafizovTV.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] array)
        {
            int colums = array.GetUpperBound(1) + 1;
            
            int max = array[0, 0];
            for (int j = 1; j < colums; j++)
            {
                if (array[0, j] > max)
                {
                    max = array[0, j];
                }
            }
            
            return max;
        }
    }
}