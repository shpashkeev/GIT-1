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
          double[] sides = (new InputerForTriangleSides()).Values();
          Triangle verifiableTriangle;

          // The order of builders is important
          TriangleBuilder builder = new EquilateralorTriangleBuilder(
                                                  new IsoscelesTriangleBuilder(
                                                    new UsualTriangleBuilder(null)));
          verifiableTriangle = builder.Build(sides);
          Console.WriteLine(verifiableTriangle.TypeString());
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
