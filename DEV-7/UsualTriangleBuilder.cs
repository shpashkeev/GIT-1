
namespace TypeOfTriangle
{
  class UsualTriangleBuilder : TriangleBuilder
  {
    public override Triangle Build(double[] sides)
    {
      return new UsualTriangle(sides);
    }
  }
}
