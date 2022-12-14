using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class ReverseNumber
    {
        public void ReverseFn() 
        {
            int rem, rev = 0;
            Console.WriteLine("Enter a number to make it reverse:");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse number is : "+rev);
        }
    }
}
