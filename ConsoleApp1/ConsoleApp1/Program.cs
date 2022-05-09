using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 4, 1, 7, 2, 3, 4, 4, 4, 5, 1, 7, 7, 7, 7, 7, 2, 3, 4, 2, 1, 2, 3, 4, 1, 7, 2, 3 };
            int localCount = 0;
            int count = 0;
            int number = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i] + " ");
            }

            for (int i = 1; i < array.GetLength(0); i++)
            {

                if (array[i] == array[i - 1])
                {
                    localCount++;

                    if (localCount > count)
                    {
                        count = localCount;
                        number = array[i];
                    }
                }
                else if (array[i] != array[i - 1])
                {
                    localCount = 0;
                }
            }
            Console.WriteLine($"\nЧисло {number}");
            Console.WriteLine($"Число повторений {count}");
        }
    }
}