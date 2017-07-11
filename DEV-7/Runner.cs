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
          Triangle verifiableTriangle;

          // The order of builders is important
          TriangleBuilder[] triangleBuilders = { new EquilateralorTriangleBuilder(),
                                                  new IsoscelesTriangleBuilder(),
                                                  new UsualTriangleBuilder() };

          // Selection cycle for a suitable builder
          foreach (var builder in triangleBuilders)
          {
            try
            {
              verifiableTriangle = builder.Build(valuesOfSides);
              Console.WriteLine(verifiableTriangle.TypeString());
              break;
            }
            catch (TriangleTypeException)
            {
              continue;
            }
          }
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
