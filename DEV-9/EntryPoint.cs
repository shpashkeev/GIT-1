using System;
using System.Collections.Generic;

namespace ReplacementOfCharacterGroups
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        List<string> seqList = new FileReader().ReadLines(@"c:\Text.txt");
        string firstSequence = seqList[0];
        string secondSequence = seqList[1];

        string thirdSequence = new Replacer().Replacement(firstSequence, secondSequence);

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
