using System;
using System.Collections.Generic;

namespace CollectOneArrayFromN
{
  // Class contains method
  // that print input list with arrays
  // in necessary string format
  public class ListWithArraysPrinter
  {
    // Method print in console double arrays from list
    // Format is defined in main class EntryPoint
    public void PrintDoubles(List<double[]> arrays)
    {
      int arraysCount = arrays.Count;
      for (int i = 0; i < arraysCount; i++)
      {
        Console.Write($"#{i}: ");
        foreach (var elem in arrays[i])
        {
          Console.Write(elem.ToString(EntryPoint.StringFormat) + " ");
        }
        Console.WriteLine();
      }
    }
  }
}
