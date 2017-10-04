using System;
using System.Collections.Generic;

namespace CollectOneArrayFromN
{
  public class ListArraysBuilder
  {
    private const int MinArrayLength = 2;
    private const int MaxArrayLength = 10;

    // Method builds list with double arrays.
    // Parameter count - amount of such arrays in returned list.
    public List<double[]> BuildDoubles(int count)
    {
      ArrayBuilder arrayBuilder = new ArrayBuilder();
      Random randGen = new Random();
      List<double[]> resultList = new List<double[]>();

      for (int i = 0; i < count; i++)
      {
        resultList.Add(arrayBuilder.BuildArrayDoubles(randGen.Next(MinArrayLength, MaxArrayLength)));
      }
      return resultList;
    }
  }
}
