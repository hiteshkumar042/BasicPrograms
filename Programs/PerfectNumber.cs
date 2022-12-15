using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class PerfectNumber
    {
        public void PerfectNumberFn()
        {
            int sum = 0;
            Console.WriteLine("Enter a Number to check  Perfect Number: ");
            int number =Convert.ToInt32(Console.ReadLine());
          //  int temp = number;
            for (int i=1;i<number;i++) //6 = divided by 1,2,3 and total is 6 (1+2+3)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (number == sum)
            {
                Console.WriteLine("{0} is a Perfect Number",number);
            }
            else
            {
                Console.WriteLine("{0} is not a Perfect Number",number);
            }
        }
    }
}
