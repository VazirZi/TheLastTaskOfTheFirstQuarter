using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Введите длину массива: ");
            int index = Convert.ToInt32(Console.ReadLine());
            int count = 0;  // счетчик количества элементов для результирующего массива

            string[] array = new string[index];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i} элемент массива: ");
                array[i] = Console.ReadLine();
                
                if (array[i].Length <= 3)
                    count++;
            }

            string[] resultArray = new string[count];
            int j = 0;  // индекс элементов результирующего массива
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    resultArray[j] = array[i];
                    Console.Write($"{resultArray[j]} ");
                    j++;
                }
            }
        }
    }
}