using System;

namespace ReplacementOfCharacterGroups
{
  public class CharacterGroupsReplacer
  {
    public string Replacement(string firstSequence, string secondSequence)
    {
      Random random = new Random();

      // Obtaining random start indices of groops in sequences
      int indexInFirstSequence = random.Next(1, firstSequence.Length - 1);
      int indexInSecondSequence = random.Next(1, secondSequence.Length - 1);

      // Obtaining random lengths of groups
      int groupLengthFromFirstSequnce = random.Next(1, firstSequence.Length - indexInFirstSequence);
      int groupLengthFromSecondSequnce = random.Next(1, secondSequence.Length - indexInSecondSequence);

      // Selecting a groups from sequences
      string firstGroup = firstSequence.Substring(indexInFirstSequence, groupLengthFromFirstSequnce);
      string secondGroup = secondSequence.Substring(indexInSecondSequence, groupLengthFromSecondSequnce);

      string result = firstSequence.Replace(firstGroup, secondGroup);
      return result;
    }
  }
}
