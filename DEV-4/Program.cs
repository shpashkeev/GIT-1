﻿using System;

namespace CheckSequence
{

    class CheckSequence
    {
        static void Main(string[] args)
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
