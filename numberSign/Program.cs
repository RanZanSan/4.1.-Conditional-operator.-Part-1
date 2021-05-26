using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            if(x < 0)
            {
                Console.WriteLine(-1);
            }
            else if(x == 0)
            {
                Console.WriteLine(0);
            }
            else if(x > 0)
            {
                Console.WriteLine(1);
            }

            Console.ReadKey();
        }
    }
}