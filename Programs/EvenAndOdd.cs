using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class EvenAndOdd
    {
        public void EvenOddFn() 
        {
            Console.WriteLine("Enter a Number:");
            int number=Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0) {
                Console.WriteLine("Entered number is Evern Number");
            }
            else
            {
                Console.WriteLine("Entered Number is Odd Number");
            }

        }
    }
}
