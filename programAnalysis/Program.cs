using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 1;
            int a = 5;

            if (s > 1)
            {
                a = a + s;
            }
            else
            {
                s = s + a * 2;
            }

            Console.WriteLine("s = " + s);
            Console.WriteLine("a = " + a);
            Console.ReadKey();
        }
    }
}