
namespace TypeOfTriangle
{
  class IsoscelesTriangle : Triangle
  {
    public IsoscelesTriangle(double[] sides) : base(sides) { }

    public override TypeOfTriangles Type()
    {
      return TypeOfTriangles.Isosceles;
    }
  }
}
