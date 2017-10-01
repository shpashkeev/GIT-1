using System;

namespace CollectOneArrayFromN
{
  public class ArrayBuilder
  {
    private static readonly Random RandGen = new Random();
    public double[] BuildArrayDoubles(int size)
    {
      if (size == 0)
      {
        throw new ArgumentException();
      }
      double[] result = new double[size];
      for (int i = 0; i < size; i++)
      {
        result[i] = RandGen.NextDouble();
      }
      return result;
    }
  }
}
