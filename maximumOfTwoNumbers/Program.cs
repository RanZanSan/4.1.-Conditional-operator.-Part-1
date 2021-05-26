using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            double maxNumber = Math.Max(firstNumber, secondNumber);

            Console.WriteLine(maxNumber);
            Console.ReadKey();
        }
    }
}