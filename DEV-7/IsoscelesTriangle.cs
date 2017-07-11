using System;

namespace TypeOfTriangle
{
  class IsoscelesTriangle : Triangle
  {
    public IsoscelesTriangle(double[] sides) : base(sides)
    {
      // Condition for an isosceles triangle
      if (!(Math.Abs(SideA - SideB) < EPSILON ||
          Math.Abs(SideA - SideC) < EPSILON ||
          Math.Abs(SideB - SideC) < EPSILON))
      {
        throw new TriangleTypeException();
      }
    }

    public override TypeOfTriangles Type()
    {
      return TypeOfTriangles.Isosceles;
    }

    public override string TypeString()
    {
      return THISTRIANGLE + Type();
    }
  }
}
