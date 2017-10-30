using System;

namespace TypeOfTriangle
{
  class EquilateralorTriangle : Triangle
  {
    public EquilateralorTriangle(double[] sides) : base(sides)
    {
      // Condition for an equilateralor triangle
      if (!(Math.Abs(SideA - SideB) < EPSILON && Math.Abs(SideB - SideC) < EPSILON))
      {
        throw new TriangleTypeException();
      }
    }

    public override TypeOfTriangles Type()
    {
      return TypeOfTriangles.Equilateralor;
    }

    public override string TypeString()
    {
      return THISTRIANGLE + Type();
    }
  }
}
