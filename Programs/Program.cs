namespace Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the program from the below option:");
            Console.WriteLine("\n1. Swap Two Numbers \t2. Even and Odd Check");
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
                default:
                    Console.WriteLine("Enter the option from given option only");
                    break;
            }
        }
            
    }
}