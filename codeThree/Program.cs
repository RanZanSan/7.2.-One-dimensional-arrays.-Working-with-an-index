using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int[] a = new int[10];

            a[0] = 5;
            a[1] = 1;
            a[2] = 6;
            a[3] = 7;
            a[4] = 8;
            a[5] = 8;
            a[6] = 7;
            a[7] = 7;
            a[8] = 6;
            a[9] = 9;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i - 1] >= a[i])
                {
                    int t = a[i];
                    a[i] = a[i - 1];
                    a[i - 1] = t;
                }
                else
                {
                    c = c + 1;
                }
            }

            Console.WriteLine(c + " ");
            Console.ReadKey();
        }
    }
}