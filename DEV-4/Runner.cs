using System;

namespace CheckSequence
{
  class Runner
  {
    const string ANSWER_NO = "This sequence is not non-decreasing";
    const string ANSWER_YES = "This sequence is non-decreasing";
    const string CHOICE = "\nPress Esc to exit, or any key to continue";

    static void Main(string[] args)
    {
      do
      {
        try
        {
          bool check = false;
          int[] sequence = (new Inputer()).SequenceReturn(args);

          // Cycle for testing sequence on non-decreasing
          for (int j = 0; j < (sequence.Length - 1); j++)
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
