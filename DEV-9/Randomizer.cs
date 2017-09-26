using System;

namespace ReplacementOfCharacterGroups
{
  public class Randomizer
  {
    private readonly Random random = new Random();
    public int RandomStartIndex(string sequence)
    {
      return random.Next(sequence.Length);
    }

    public int RandomCount(string sequence, int startIndex)
    {
      return random.Next(sequence.Length - startIndex);
    }
  }
}
