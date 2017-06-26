using System;

namespace CheckSequence
{
    class Runner
    {
        static void Main(string[] args)
        {
            do
            {
				try
				{
					// User read elements of sequence
					Console.Write("Enter sequence with splits: ");
					string[] stringSequence = Console.ReadLine().Split();

					int sizeOfSequence = stringSequence.Length;
					int[] sequence = new int[sizeOfSequence];

					bool check = false;

					for (int i = 0; i < sizeOfSequence; i++)
					{
						// Parse stringSequence element to int sequence
						sequence[i] = int.Parse(stringSequence[i]);
					}

					// Cycle for testing sequence on non-decreasing
					for (int j = 0; j < (sizeOfSequence - 1); j++)
					{
						if (sequence[j + 1] < sequence[j])
						{
							check = true;
							break;
						}
					}
					if (check == true)
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
                Console.WriteLine("Press Esc to exit, or any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
