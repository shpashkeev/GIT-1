using System;

namespace CheckOnFibonacci
{
    class Program
    {
        // This function checks if the entered number is a positive Fibonacci number
        // and checks the correctness of the number input
        static void Main(string[] args)
        {
            // do-while cycle for re-enter numbers
            // when user wants to exit, he must press Esc
            do
            {
                try
                {
                    Console.Write("Input number: ");
                    int checkNumber = Convert.ToInt32(Console.ReadLine());
                    int fibPrev = 1;
                    int fibCurr = 0;
                    int fibNext = 0;

                    // Cycle of calculation of Fibonacci numbers
                    for (fibCurr = 0; fibCurr <= checkNumber; fibCurr = fibNext)
                    {
                        if (checkNumber == fibCurr)
                        {
                            break;
                        }
                        fibNext = fibCurr + fibPrev;
                        fibPrev = fibCurr;
                    }
                    if (checkNumber == fibCurr)
                    {
                        Console.WriteLine("This is a positive Fibonacci number");
                    }
                    else
                    {
                        Console.WriteLine("This is not a positive Fibonacci number");
                    }
                    Console.WriteLine("Press Esc to exit, or any key to continue");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex);
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
