using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeToo
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

            string answer = "";
            if (length == 1)
                answer = "YES";
            else
            {
                for (int index = 0; index < numbers.Length / 2; index++)
                {
                    if (numbers[index] == numbers[numbers.Length - index - 1])
                        answer = "YES";
                    else
                    {
                        answer = "NO";
                        break;
                    }
                }
            }

            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}