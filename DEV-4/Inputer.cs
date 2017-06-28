using System;

namespace CheckSequence
{
  // Class then contains methods to return in main programm integer sequence for after analysis
  class Inputer
  {
    const string CONSOLE_ARGS_EMPTY = "Console arguments is empty.\nEnter sequence with spaces: ";

    // This method check on empty console arguments
    // And suggest user to enter sequence in console
    public int[] SequenceReturn(string[] strSequence)
    {
      if (strSequence.Length != 0)
      {
        foreach (var arg in strSequence)
        {
          Console.Write(arg + " ");
        }
        return strToIntParser(strSequence);
      }
      else
      {
        // User read elements of sequence
        Console.Write(CONSOLE_ARGS_EMPTY);
        string[] stringSequence = Console.ReadLine().Split();
        return strToIntParser(stringSequence);
      }
    }

    // Private method to parse string sequence in integer sequence
    private int[] strToIntParser(string[] strSequence)
    {
      int sizeOfSequence = strSequence.Length;
      int[] intSequence = new int[sizeOfSequence];

      for (int i = 0; i < sizeOfSequence; i++)
      {
        intSequence[i] = int.Parse(strSequence[i]);
      }
      return intSequence;
    }

  }
}
