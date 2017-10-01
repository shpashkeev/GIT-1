using System;
using System.Collections.Generic;

namespace CollectOneArrayFromN
{
  public class EntryPoint
  {
    public static string StringFormat = "F3";
    private static string ResultLine = "Result: ";

    static void Main(string[] args)
    {
      ArrayCollector arrayCollector = new ArrayCollector();
      ListWithArraysBuilder arraysBuilder = new ListWithArraysBuilder();
      ListWithArraysPrinter arraysPrinter = new ListWithArraysPrinter();

      int countN = new Inputer().ReturnInt();
      List<double[]> doubleArraysList = arraysBuilder.BuildDoubles(countN);

      double[] result = arrayCollector.CollectArrayDoubles(doubleArraysList);

      arraysPrinter.PrintDoubles(doubleArraysList);
      Console.Write(ResultLine);
      foreach (var elem in result)
      {
        Console.Write(elem.ToString(StringFormat) + " ");
      }
      Console.ReadKey();
    }
  }
}
