using System;
using System.Collections.Generic;

namespace CollectOneArrayFromN
{
  // Main method of this class takes N arrays of real numbers
  // and collects one of these arrays, whose elements obey a certain rule.
  // Result of this process displayed in certain string format.
  public class EntryPoint
  {
    public const string StringFormat = "F3";
    private const string ResultLine = "Result: ";

    static void Main(string[] args)
    {
      try
      {
        // Init
        ArrayCollector arrayCollector = new ArrayCollector();
        ListArraysBuilder arraysBuilder = new ListArraysBuilder();
        ListArraysPrinter arraysPrinter = new ListArraysPrinter();

        // Process
        int countN = new IntegerInputer().ReturnPositiveInt();
        List<double[]> doubleArraysList = arraysBuilder.BuildDoubles(countN);
        double[] result = arrayCollector.CollectArrayDoubles(doubleArraysList);

        // Result
        arraysPrinter.PrintDoubles(doubleArraysList);
        Console.Write(ResultLine);
        foreach (var elem in result)
        {
          Console.Write(elem.ToString(StringFormat) + " ");
        }
        Console.ReadKey();
      }
      catch (Exception exc)
      {
        Console.WriteLine(exc.Message);
      }
    }
  }
}
