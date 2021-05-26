using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            if(number % 2 == 0)
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