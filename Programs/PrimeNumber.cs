using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class PrimeNumber
    {
        public void PrimeNumberFn()
        {
            int flag = 1;
            Console.WriteLine("Enter a Number to check Prime or Not: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    flag = 0;
                    break;
                }
                
            }
            if (flag == 1)
            {
                Console.WriteLine("{0} is a Prime Number",num);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number",num);
            }
        }
    }
}
