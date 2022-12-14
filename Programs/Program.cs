namespace Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the program from the below option:");
            Console.WriteLine("\n1. Swap Two Numbers \n2. Even and Odd Number Check \n3. Vowel And Alphabet Check \n4. Reverse Number Program");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                     SwapTwoNumber swap = new SwapTwoNumber();
                     swap.SwapFn();
                     break;
                case 2:
                    EvenAndOdd even = new EvenAndOdd();
                    even.EvenOddFn();
                    break;
                case 3:
                    VowelAndAlpha vowel = new VowelAndAlpha();
                    vowel.VowelAndAlphaFn();
                    break;
                case 4:
                    ReverseNumber rev = new ReverseNumber();
                    rev.ReverseFn();
                    break;
                default:
                    Console.WriteLine("Enter the option from given option only");
                    break;
            }
        }
            
    }
}