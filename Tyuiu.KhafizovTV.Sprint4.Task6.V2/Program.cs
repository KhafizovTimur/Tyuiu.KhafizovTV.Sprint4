using Tyuiu.KhafizovTV.Sprint4.Task6.V2.Lib;

namespace Tyuiu.KhafizovTV.Sprint4.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Хафизов Т.В. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Класс Array                                                      *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #2                                                             *");
            Console.WriteLine("* Выполнил: Хафизов Т.В. | ИСПб-25-1                                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан строковый массив данных ['Белый', 'Черный', 'Зеленый',             *");
            Console.WriteLine("* 'Синий', 'Красный', 'Желтый', 'Фиолетовый'] используя класс            *");
            Console.WriteLine("* Array, выведите элементы массива, длина которых больше 5 символов.     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            var cities = new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= cities.Length - 1; i++)
            {
                Console.WriteLine(cities[i]);
            }

            Console.WriteLine("************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                               *");
            Console.WriteLine("************************************************************");
            Console.WriteLine("Элементы массива, длина которых > 5 символов:");

            string[] result = ds.Calculate(cities);

            foreach (string element in result)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}