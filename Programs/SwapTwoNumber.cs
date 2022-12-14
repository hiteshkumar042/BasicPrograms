using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Programs
{
    class SwapTwoNumber
    {
      public void SwapFn() 
       {
            int num1, num2, temp;
            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping :\nFirst Number: {0} & Second Number: {1}",num1, num2);

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After Swapping :\nFirst Number: {0} & Second Number: {1}", num1, num2);

      }
    }
}
