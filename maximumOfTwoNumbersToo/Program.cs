using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximumOfTwoNumbersToo
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if(firstNumber >= secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }

            Console.ReadKey();
        }
    }
}