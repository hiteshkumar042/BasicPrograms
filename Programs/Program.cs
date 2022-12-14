namespace Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the program from the below option:");
            Console.WriteLine("\n1. Swap Two Numbers. \n2. Even and Odd Number Check. \n3. Vowel And Alphabet Check.");
            Console.WriteLine("4. Reverse Number Program. \n5. Leap Year Program. \n6. Prime Number Check.\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //Swap Two Numbers Program
                    SwapTwoNumber swap = new SwapTwoNumber();
                     swap.SwapFn();
                     break;
                case 2:
                    //Even and Odd Number Check
                    EvenAndOdd even = new EvenAndOdd();
                    even.EvenOddFn();
                    break;
                case 3:
                    //Vowel And Alphabet Check
                    VowelAndAlpha vowel = new VowelAndAlpha();
                    vowel.VowelAndAlphaFn();
                    break;
                case 4:
                    //Reverse Number Program
                    ReverseNumber rev = new ReverseNumber();
                    rev.ReverseFn();
                    break;
                case 5:
                    //Leap Year Program
                    LeapYear leap=new LeapYear();
                    leap.LeapYearFn();
                    break;
                case 6:
                    //PrimeNumber Problem
                    PrimeNumber prime = new PrimeNumber();
                    prime.PrimeNumberFn();
                    break;
                default:
                    Console.WriteLine("Enter the option from given option only");
                    break;
            }
        }
            
    }
}