using System;

namespace TypeOfTriangle
{
  class Runner
  {
    const string CHOICE = "\nPress Esc to exit, or any key to continue";

    static void Main(string[] args)
    {
      do
      {
        try
        {
          double[] valuesOfSides = (new Inputer()).Values();
          Triangle testTriangle = new Triangle(valuesOfSides);
          Console.WriteLine("This triangle is " + testTriangle.Type);
        }
        catch (Exception exc)
        {
          Console.WriteLine("Exception: " + exc);
        }
        Console.WriteLine(CHOICE);
      }
      while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
  }
}
