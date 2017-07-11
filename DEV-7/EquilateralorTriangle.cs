
namespace TypeOfTriangle
{
  class EquilateralorTriangle : Triangle
  {
    public EquilateralorTriangle(double[] sides) : base(sides) { }

    public override TypeOfTriangles Type()
    {
      return TypeOfTriangles.Equilateralor;
    }
  }
}
