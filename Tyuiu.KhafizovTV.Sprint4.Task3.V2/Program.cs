using Tyuiu.KhafizovTV.Sprint4.Task3.V2.Lib;

namespace Tyuiu.KhafizovTV.Sprint4.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 4, 3, 2, 8, 7 },
                                          { 4, 6, 5, 5, 7 },
                                          { 3, 8, 8, 3, 5 },
                                          { 5, 7, 5, 4, 4 },
                                          { 8, 8, 3, 7, 6 } };
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;
            Console.Title = "Спринт #4 | Выполнил: Хафизов Т.В. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                            *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #2                                                             *");
            Console.WriteLine("* Выполнил: Хафизов Т.В. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный       *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 8. Найдите максимальный    *");
            Console.WriteLine("* элемент в первой строке массива.                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
            Console.WriteLine("************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine("Максимальный элемент в первой строке = " + res);
            Console.ReadKey();
        }
    }
}