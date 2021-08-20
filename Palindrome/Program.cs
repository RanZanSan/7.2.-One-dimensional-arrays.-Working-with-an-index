using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
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

            int[] numbersInverted = new int[length];
            for(int index = numbersInverted.Length - 1; index >= 0; index--)
            {
                numbersInverted[index] = Convert.ToInt32(stringArray[index]);
            }

            if (numbers.Reverse().SequenceEqual(numbersInverted))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            Console.ReadKey();
        }
    }
}