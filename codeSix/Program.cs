using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeSix
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int n = 10;
            int[] a = new int[n];

            a[0] = 7;
            a[1] = 9;
            a[2] = 8;
            a[3] = 1;
            a[4] = 2;
            a[5] = 3;
            a[6] = 3;
            a[7] = 10;
            a[8] = 8;
            a[9] = 6;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i - 1] < a[i])
                {
                    a[i] = a[i - 1] + 1;
                    s = s + 1;
                }
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}