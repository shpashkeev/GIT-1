
namespace ReplacementOfCharacterGroups
{
  public class Replacer
  {
    public string Replacement(string firstSequence, string secondSequence)
    {
      Randomizer randomizer = new Randomizer();

      // Obtaining random start indices of groops in sequences
      int indexInFirstSequence = randomizer.RandomStartIndex(firstSequence);
      int indexInSecondSequence = randomizer.RandomStartIndex(secondSequence);

      // Obtaining random lengths of groups
      int groupLengthFromFirstSequnce = randomizer.RandomLength(firstSequence, indexInFirstSequence);
      int groupLengthFromSecondSequnce = randomizer.RandomLength(secondSequence, indexInSecondSequence);

      // Selecting a groups from sequences
      string firstGroup = firstSequence.Substring(indexInFirstSequence, groupLengthFromFirstSequnce);
      string secondGroup = secondSequence.Substring(indexInSecondSequence, groupLengthFromSecondSequnce);

      string result = firstSequence.Replace(firstGroup, secondGroup);
      return result;
    }
  }
}
