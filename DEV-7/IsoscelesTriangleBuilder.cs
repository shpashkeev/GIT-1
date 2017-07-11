
namespace TypeOfTriangle
{
  class IsoscelesTriangleBuilder : TriangleBuilder
  {
    public override Triangle Build(double[] sides)
    {
      return new IsoscelesTriangle(sides);
    }
  }
}
