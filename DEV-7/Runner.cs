using System;

namespace TypeOfTriangle
{
  // Enumeration with types of triangles
  enum TypeOfTriangles
  {
    Equilateralor,
    Isosceles,
    Usual
  }

  class Runner
  {
    const string CHOICE = "\nPress Esc to exit, or any key to continue";

    static void Main(string[] args)
    {
      do
      {
        try
        {
          double[] valuesOfSides = (new InputerForTriangleSides()).Values();
          Triangle testTriangle = (new TriangleBuilder()).Build(valuesOfSides);
          Console.WriteLine("This triangle is " + testTriangle.Type());
        }
        catch (Exception exc)
        {
          Console.WriteLine("Exception: " + exc.Message);
        }
        Console.WriteLine(CHOICE);
      }
      while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
  }
}
