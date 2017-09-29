using System;
using System.Collections.Generic;

namespace ReplacementOfCharacterGroups
{
  // Main class method reads two sequences of characters from the file
  // and calls a method to randomly replace groups of characters.
  public class EntryPoint
  {
    private const string InvalidCount = "Invalid sequences count";
    private const int ValidSequencesCount = 2;

    // Argument of method Main contains the path to the file.
    static void Main(string[] args)
    {

      try
      {
        List<string> seqList = new TextFileReader().ReadLines(args[0]);

        if (seqList.Count != ValidSequencesCount)
        {
          throw new Exception(InvalidCount);
        }
        string firstSequence = seqList[0];
        string secondSequence = seqList[1];

        string thirdSequence = new CharacterGroupsReplacer().Replace(firstSequence, secondSequence);

        Console.WriteLine($"#1: {firstSequence}");
        Console.WriteLine($"#2: {secondSequence}");
        Console.WriteLine($"#3: {thirdSequence}");

        Console.ReadKey();
      }
      catch (Exception exc)
      {
        Console.WriteLine(exc.Message);
      }
    }
  }
}
