using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhafizovTV.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] array)
        {
            int colums = array.GetUpperBound(1) + 1;
            
            int sumEven = 0;
            int maxOdd = int.MinValue;
            
            for (int j = 0; j < colums; j++)
            {
                if (array[0, j] % 2 == 0)
                {
                    sumEven += array[0, j];
                }
                else
                {
                    if (array[0, j] > maxOdd)
                    {
                        maxOdd = array[0, j];
                    }
                }
            }
            
            if (maxOdd == int.MinValue)
            {
                return sumEven;
            }
            
            return sumEven + maxOdd;
        }
    }
}