using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mintIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = Console.ReadLine().Split(' ');

            int[] numbers = new int[length];
            for (int index = 0; index < numbers.Length; index++)
            {
                int number = Convert.ToInt32(stringArray[index]);
                numbers[index] = number;
            }

            int min = numbers[0];
            int indexMin = 0;
            for (int index = 1; index < numbers.Length; index++)
            {
                if (numbers[index] < min)
                {
                    min = numbers[index];
                    indexMin = index;
                }
            }

            Console.WriteLine(indexMin);
            Console.ReadKey();
        }
    }
}