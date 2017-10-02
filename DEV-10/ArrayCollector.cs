using System;
using System.Collections.Generic;

namespace CollectOneArrayFromN
{
  // Class contains method
  // that collect from N input arrays one array
  // which consists of elements that are contained in a certain number of inputs arrays
  public class ArrayCollector
  {
    // Certain number of inputs arrays, in which the element should be contained
    private const int ValidElemRepeat = 2;
    private const double Epsilon = 1E-3;

    public double[] CollectArrayDoubles(List<double[]> arrays)
    {
      List<double> listDoubles = new List<double>();
      int arraysCount = arrays.Count;

      for (int i = 0; i < arraysCount - 1; i++)
      {
        double[] firstArray = arrays[i];

        foreach (var searchItem in firstArray)
        {
          // The number of arrays in which searchItem occurs
          int elemRepeat = 1;

          for (int j = i + 1; j < arraysCount; j++)
          {
            // Select the next array to find searchItem
            double[] secondArray = arrays[j];

            foreach (var comparedItem in secondArray)
            {
              if (Math.Abs(searchItem - comparedItem) <= Epsilon)
              {
                elemRepeat++;
                break;
              }
            }
          }
          // Condition of occurrence elem in returned array
          if (elemRepeat >= ValidElemRepeat && !listDoubles.Contains(searchItem))
          {
            listDoubles.Add(searchItem);
          }
        }
      }
      return listDoubles.ToArray();
    }
  }
}
