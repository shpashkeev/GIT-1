using System;

namespace TypeOfTriangle
{
  class TriangleTypeDetector
  {
    private double sideA;
    private double sideB;
    private double sideC;
    const double EPSILON = 10e-6;

    public TypeOfTriangles GetTriangleType(double[] sides)
    {
      sideA = sides[0];
      sideB = sides[1];
      sideC = sides[2];

      // Condition of existance
      if (!(sideA + sideB >= sideC && sideB + sideC >= sideA && sideA + sideC >= sideB))
      {
        throw new Exception();
      }

      // Condition for an equilateralor triangle
      if (Math.Abs(sideA - sideB) < EPSILON && Math.Abs(sideB - sideC) < EPSILON)
      {
        return TypeOfTriangles.Equilateralor;
      }

      // Condition for an isosceles triangle
      if (Math.Abs(sideA - sideB) < EPSILON ||
        Math.Abs(sideA - sideC) < EPSILON ||
        Math.Abs(sideB - sideC) < EPSILON)
      {
        return TypeOfTriangles.Isosceles;
      }

      // Default type of triangle
      return TypeOfTriangles.Usual;
    }
  }
}
