﻿using System;

namespace ReplacementOfCharacterGroups
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      string firstSequence = "abcdefghijklmnop";
      string secondSequence = "1234567890";

      string thirdSequence = new Replacer().Replacement(firstSequence, secondSequence);

      Console.WriteLine($"#1: {firstSequence}");
      Console.WriteLine($"#2: {secondSequence}");
      Console.WriteLine($"#3: {thirdSequence}");

      Console.ReadKey();
    }
  }
}
