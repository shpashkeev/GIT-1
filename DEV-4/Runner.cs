using System;

namespace CheckSequence
{
    class Runner
    {
        const string ENTER_LINE = "Enter sequence with splits: ";
        const string ANSWER_NO = "This sequence is not non-decreasing";
        const string ANSWER_YES = "This sequence is non-decreasing";
        const string CHOICE = "Press Esc to exit, or any key to continue";

        static void Main(string[] args)
        {
            do
            {
                try
                {
                    // User read elements of sequence
                    Console.Write(ENTER_LINE);
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
                        Console.WriteLine(ANSWER_NO);
                    }
                    else
                    {
                        Console.WriteLine(ANSWER_YES);
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Exception: " + exc);
                }
                Console.WriteLine(CHOICE);
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
