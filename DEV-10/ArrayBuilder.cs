using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectOneArrayFromN
{
  public class ArrayBuilder
  {
    public double[] BuildArrayDoubles(int size)
    {
      Random randGen = new Random();
      if (size == 0)
      {
        throw new ArgumentNullException();
      }
      double[] result = new double[size];
      for (int i = 0; i < size; i++)
      {
        result[i] = randGen.NextDouble();
      }
      return result;
    }
  }
}
