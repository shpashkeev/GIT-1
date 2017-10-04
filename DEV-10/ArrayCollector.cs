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

      for (int i = 0; i < arrays.Count - 1; i++)
      {
        double[] firstArray = arrays[i];

        foreach (var searchItem in firstArray)
        {
          if (listDoubles.Contains(searchItem))
          {
            continue;
          }
          // The number of arrays in which searchItem occurs
          int elemOccurrences = 1;

          for (int j = i + 1; j < arrays.Count; j++)
          {
            // Select the next array to find searchItem
            double[] secondArray = arrays[j];

            foreach (var comparedItem in secondArray)
            {
              if (Math.Abs(searchItem - comparedItem) <= Epsilon)
              {
                elemOccurrences++;
                break;
              }
            }
          }
          // Condition of occurrence elem in returned array
          if (elemOccurrences >= ValidElemRepeat)
          {
            listDoubles.Add(searchItem);
          }
        }
      }
      return listDoubles.ToArray();
    }
  }
}
