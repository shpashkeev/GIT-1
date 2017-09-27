using System;

namespace ReplacementOfCharacterGroups
{
  public class Randomizer
  {
    private readonly Random random = new Random();

    public int RandomStartIndex(string sequence)
    {
      return random.Next(1, sequence.Length - 1);
    }

    public int RandomLength(string sequence, int startIndex)
    {
      return random.Next(1, sequence.Length - startIndex);
    }
  }
}
