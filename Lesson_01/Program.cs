using System;

namespace Lesson_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 2, 4, 1, 6, 3, 8, 7, 0, 5, 9 };
            for (int i = 0; i < numbers.Length; i++)
            {
                var value = numbers[i];
                if (value % 3 != 0)
                {
                    Console.WriteLine(value);
                }

            }
        }
    }
}
