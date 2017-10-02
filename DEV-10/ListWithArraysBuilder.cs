using System;
using System.Collections.Generic;

namespace CollectOneArrayFromN
{
  public class ListWithArraysBuilder
  {
    // Method build list with double arrays.
    // Parameter count - amount of such arrays in returned list.
    public List<double[]> BuildDoubles(int count)
    {
      ArrayBuilder arrayBuilder = new ArrayBuilder();
      Random randGen = new Random();
      List<double[]> resultList = new List<double[]>();

      for (int i = 0; i < count; i++)
      {
        resultList.Add(arrayBuilder.BuildArrayDoubles(randGen.Next(2, 10)));
      }
      return resultList;
    }
  }
}
