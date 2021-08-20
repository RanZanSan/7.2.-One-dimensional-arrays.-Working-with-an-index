using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int length = ss.Length;

            for (int i = 0; i < length / 2; i++)
            {
                string tmp = ss[i];
                ss[i] = ss[length - 1 - i];
                ss[length - 1 - i] = tmp;
            }
            for (int i = 0; i < length; i++)
            {
                Console.Write(ss[i] + " ");
            }

            Console.ReadKey();
        }
    }
}