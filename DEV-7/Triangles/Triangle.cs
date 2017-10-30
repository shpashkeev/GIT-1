
using System;

namespace TypeOfTriangle
{
  // Absract class Triangle without type
  abstract class Triangle
  {
    protected const double EPSILON = 10e-6;
    protected const string THISTRIANGLE = "This triangle is ";

    public double SideA
    { get; }

    public double SideB
    { get; }

    public double SideC
    { get; }

    public Triangle(double[] sides)
    {
      // Condition of existance
      if (!(sides[0] + sides[1] >= sides[2] && sides[1] + sides[2] >= sides[0] && sides[0] + sides[2] >= sides[1]))
      {
        throw new TriangleBuildException();
      }

      SideA = sides[0];
      SideB = sides[1];
      SideC = sides[2];
    }

    // Method then return type of Triangle in child classes
    public abstract TypeOfTriangles Type();

    // Method then return type of Triangle in String format
    public abstract string TypeString();

  }
}
