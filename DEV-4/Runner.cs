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
          int[] sequence = (new Inputer()).ReturnIntSequence(args);
          if (new Checker().IsNonDecreasing(sequence))
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
