using System;
using System.Collections.Generic;

namespace CollectOneArrayFromN
{
  public class ListWithArraysPrinter
  {
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
