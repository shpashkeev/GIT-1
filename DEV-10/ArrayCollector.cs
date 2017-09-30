using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectOneArrayFromN
{
  public class ArrayCollector
  {
    private const double Epsilon = 10E-6;
    private const int ValidElemRepeat = 2;

    public double[] CollectArrayDoubles(List<double[]> arrays)
    {
      List<double> listDoubles = new List<double>();
      int arraysCount = arrays.Count;
      int elemRepeat;

      for (int i = 0; i < arraysCount; i++)
      {
        double[] firstArray = arrays[i];

        foreach (var searchItem in firstArray)
        {
          // The number of arrays in which searchItem occurs
          elemRepeat = 1;

          for (int j = i + 1; j < arraysCount; j++)
          {
            // Select the next array to find searchItem
            double[] secondArray = arrays[j];

            foreach (var comparedItem in secondArray)
            {
              if (Math.Abs(searchItem - comparedItem) <= Epsilon)
              {
                elemRepeat++;
              }
            }
          }
          if (elemRepeat >= ValidElemRepeat && !listDoubles.Contains(searchItem))
          {
            listDoubles.Add(searchItem);
          }
        }

      }
      int resultArrayLength = listDoubles.Count;
      double[] result = new double[resultArrayLength];
      for (int i = 0; i < resultArrayLength; i++)
      {
        result[i] = listDoubles[i];
      }
      return result;
    }
  }
}
