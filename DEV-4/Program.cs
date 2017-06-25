using System;

namespace CheckSequence
{

    class CheckSequence
    {
        static void Main(string[] args)
        {
            try
            {
                // User must specify the size of sequence
                Console.Write("Enter size of sequence: ");
                int n = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter elements of sequence:");
                int[] sequence = new int[n];

                bool check = false;

                for (int i = 0; i < n; i++)
                {
                    // User enter the elements with the new line
                    sequence[i] = int.Parse(Console.ReadLine());
                }

                // Cycle for testing sequence on non-decreasing
                for (int j = 0; j < (n - 1); j++)
                {
                    if (sequence[j + 1] < sequence[j])
                    {
                        check = true;
                        break;
                    }
                }
                if (check)
                {
                    Console.WriteLine("This sequence is not non-decreasing");
                }
                else
                {
                    Console.WriteLine("This sequence is non-decreasing");
                }
            }
            catch(Exception exc)
            {
                Console.WriteLine("Exception: " + exc);
            }
            Console.ReadKey();
        }
    }
}
