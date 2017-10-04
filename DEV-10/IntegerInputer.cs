using System;

namespace CollectOneArrayFromN
{
  // Class contains method
  // that returns valid integer numbers entered by user
  public class IntegerInputer
  {
    private const string BadValue = "Bad value. Try again.";
    private const string IntValue = "Please, enter N - count of arrays: ";

    // Method returns valid positive integer number entered by user from console
    public int ReturnPositiveInt()
    {
      int result;
      Console.Write(IntValue);
      while (!int.TryParse(Console.ReadLine(), out result) && result <= 0)
      {
        Console.WriteLine(BadValue);
      }
      return result;
    }
  }
}
