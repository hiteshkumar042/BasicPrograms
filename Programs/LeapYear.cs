using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class LeapYear
    { 
        public void LeapYearFn()
        {
            Console.WriteLine("Enter a year (YYYY): ");
            int yy=Convert.ToInt32(Console.ReadLine());
            if((yy % 400 == 0) || (yy % 4 == 0) && (yy % 100 != 0))
            {
                Console.WriteLine("{0} is a Leap Year", yy);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year",yy);
            }
        }
    }
}
