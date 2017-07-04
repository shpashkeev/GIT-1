namespace CheckSequence
{
  class Checker
  {
    // Method for testing sequence on non-decreasing
    public bool IsNonDecreasing(int[] sequence)
    {
      for (int j = 0; j < (sequence.Length - 1); j++)
      {
        if (sequence[j + 1] < sequence[j])
        {
          return false;
        }
      }
      return true;
    }
  }
}
