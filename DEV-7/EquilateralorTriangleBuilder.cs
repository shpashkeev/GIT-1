
namespace TypeOfTriangle
{
  class EquilateralorTriangleBuilder : TriangleBuilder
  {
    public override Triangle Build(double[] sides)
    {
      return new EquilateralorTriangle(sides);
    }
  }
}
