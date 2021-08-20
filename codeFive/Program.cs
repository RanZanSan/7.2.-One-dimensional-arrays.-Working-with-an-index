using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 9;
            int n = 10;
            int[] a = new int[n];

            a[0] = 1;
            a[1] = 2;
            a[2] = 18;
            a[3] = 8;
            a[4] = 14;
            a[5] = 9;
            a[6] = 23;
            a[7] = 7;
            a[8] = 51;
            a[9] = 99;

            while (a[i] < 10)
            {
                i = i + 1;
            }
            while (a[j] > 10)
            {
                j = j - 1;
            }
            int t = a[i] - a[j];

            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}