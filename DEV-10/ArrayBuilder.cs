using System;

namespace CollectOneArrayFromN
{
  // Class contain method
  // that build arrays from random numbers
  public class ArrayBuilder
  {
    // Field is static
    // so that each time the methods of the instance of class are called
    // returned arrays consisted of different random elements
    private static readonly Random RandGen = new Random();

    // Method returns double array consisted of random elements.
    // Parameter size - size of returned array
    public double[] BuildArrayDoubles(int size)
    {
      if (size <= 0)
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
