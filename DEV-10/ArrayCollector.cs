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
    public double[] CollectArrayDoubles(List<double[]> arrays)
    {
      List<double> listDoubles = new List<double>();
      int arraysCount = arrays.Count;

      for (int i = 0; i < arraysCount; i++)
      {
        double[] firstArray = arrays[i];
        for (int j = i; j < arraysCount; j++)
        {
          double[] secondArray = arrays[j];
          foreach (var elem1 in firstArray)
          {
            foreach (var elem2 in secondArray)
            {
              if (Math.Abs(elem1 - elem2) <= Epsilon && !listDoubles.Contains(elem1) && !listDoubles.Contains(elem2))
              {
                listDoubles.Add(elem1);
              }
            }
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
