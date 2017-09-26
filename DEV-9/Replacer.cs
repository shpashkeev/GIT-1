using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplacementOfCharacterGroups
{
  public class Replacer
  {
    public string Replacement(string firstSequence, string secondSequence)
    {
      Randomizer randomizer = new Randomizer();

      int indexInFirstSequence = randomizer.RandomStartIndex(firstSequence);
      int indexInSecondSequence = randomizer.RandomStartIndex(secondSequence);

      int groupLengthFromFirstSequnce = randomizer.RandomCount(firstSequence, indexInFirstSequence);
      int groupLengthFromSecondSequnce = randomizer.RandomCount(secondSequence, indexInSecondSequence);

      string firstGroup = firstSequence.Substring(indexInFirstSequence, groupLengthFromSecondSequnce);
      string secondGroup = secondSequence.Substring(indexInSecondSequence, groupLengthFromSecondSequnce);

      string result = firstSequence.Replace(firstGroup, secondGroup);
      return result;
    }
  }
}
