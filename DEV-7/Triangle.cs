using System;

namespace TypeOfTriangle
{
  // This class descibes a triangle
  // And contain method that automatically determines the type of triangle that is created
  class Triangle
  {
    const string USUAL = "Usual";
    const string EQUILATERALOR = "Equilateralor";
    const string ISOSCELES = "Isosceles";
    const string DONOTEXIST = "Triangle with such sides does not exist";
    const double EPSILON = 10e-6;

    public double SideA
    { get; }

    public double SideB
    { get; }

    public double SideC
    { get; }

    public string Type
    { get; }

    public Triangle(double[] sides)
    {
      SideA = sides[0];
      SideB = sides[1];
      SideC = sides[2];
      Type = setType();
    }

    private string setType()
    {
      // Condition of existance
      if (!(SideA + SideB >= SideC && SideB + SideC >= SideA && SideA + SideC >= SideB))
      {
        return DONOTEXIST;
      }

      // Condition for an equilateralor triangle
      if (Math.Abs(SideA - SideB) < EPSILON && Math.Abs(SideB - SideC) < EPSILON)
      {
        return EQUILATERALOR;
      }

      // Condition for an isosceles triangle
      if (Math.Abs(SideA - SideB) < EPSILON || Math.Abs(SideA - SideC) < EPSILON || Math.Abs(SideB - SideC) < EPSILON)
      {
        return ISOSCELES;
      }

      // Default type of triangle
      return USUAL;
    }
  }
}
