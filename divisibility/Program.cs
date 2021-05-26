using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisibility
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if(a % b == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            Console.ReadKey();
        }
    }
}