using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOnFibonacci
{
    class Program
    {
        // This function checks if the entered number is a positive Fibonacci number
        // and checks the correctness of the number input
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input number: ");
                int checkNumber = Convert.ToInt32(Console.ReadLine());
                int fibPrev = 1;
                int fibCurr;
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

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
            }
            Console.ReadKey();
        }
    }
}
