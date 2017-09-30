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
    private const double Epsilon = 10E-3;
    private const int ValidElemRepeat = 2;

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
