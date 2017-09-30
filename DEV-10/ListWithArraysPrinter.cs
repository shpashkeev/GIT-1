using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectOneArrayFromN
{
  public class ListWithArraysPrinter
  {
    public void PrintListWithDoubleArrays(List<double[]> arrays)
    {
      int arraysCount = arrays.Count;
      for (int i = 0; i < arraysCount; i++)
      {
        Console.Write($"#{i}: ");
        foreach (var elem in arrays[i])
        {
          Console.Write(elem.ToString("F2") + " ");
        }
        Console.WriteLine();
      }
    }
  }
}
