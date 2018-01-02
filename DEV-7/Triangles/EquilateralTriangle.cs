using System;

namespace TypeOfTriangle
{
  public class EquilateralTriangle : Triangle
  {
    public EquilateralTriangle(double[] sides) : base(sides)
    {
      // Condition for an equilateralor triangle
      if (!(Math.Abs(SideA - SideB) < EPSILON && Math.Abs(SideB - SideC) < EPSILON))
      {
        throw new TriangleTypeException();
      }
    }

    public override TypeOfTriangles Type()
    {
      return TypeOfTriangles.Equilateral;
    }

    public override string TypeString()
    {
      return THISTRIANGLE + Type();
    }
  }
}
