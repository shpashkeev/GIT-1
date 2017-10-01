using System;

namespace CollectOneArrayFromN
{
  public class Inputer
  {
    private const string BadValue = "Bad value. Try again.";
    private const string IntValue = "Please, enter N - count of arrays: ";

    public int ReturnInt()
    {
      int result;
      Console.Write(IntValue);
      while (!int.TryParse(Console.ReadLine(), out result))
      {
        Console.WriteLine(BadValue);
      }
      return result;
    }
  }
}
