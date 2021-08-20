using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int s = 0;

            int[] a = new int[n];

            a[0] = 3;
            a[1] = 14;
            a[2] = 15;
            a[3] = 92;
            a[4] = 6;
            a[5] = 2;
            a[6] = 7;
            a[7] = 18;
            a[8] = 28;
            a[9] = 17;

            for (int i = 2; i < n; i++)
            {
                s = s + a[i] - a[i - 2];
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}