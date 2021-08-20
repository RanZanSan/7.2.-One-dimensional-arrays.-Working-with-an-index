using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapMaxMin
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
                numbers[index] = Convert.ToInt32(stringArray[index]);
            }

            int min = numbers[0];
            int indexMin = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] < min)
                {
                    min = numbers[index];
                    indexMin = index;
                    break;
                }
            }

            int max = numbers[0];
            int indexMax = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] >= max)
                {
                    max = numbers[index];
                    indexMax = index;
                }
            }

            for(int index = 0; index < numbers.Length; index++)
            {
                if (index == indexMin)
                    numbers[index] = max;
                if (index == indexMax)
                    numbers[index] = min;

                Console.Write(numbers[index] + " ");
            }
            Console.ReadKey();
        }
    }
}