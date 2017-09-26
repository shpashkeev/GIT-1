using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplacementOfCharacterGroups
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      string firstSequence = "abcdefg";
      string secondSequence = "1234567";

      string thirdSequence = new Replacer().Replacement(firstSequence,secondSequence);

      Console.WriteLine($"#1: {firstSequence}");
      Console.WriteLine($"#2: {secondSequence}");
      Console.WriteLine($"#3: {thirdSequence}");

      Console.ReadKey();
    }
  }
}
