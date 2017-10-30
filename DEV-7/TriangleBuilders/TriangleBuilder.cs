
namespace TypeOfTriangle
{
  abstract class TriangleBuilder
  {
    protected TriangleBuilder successor;

    public abstract Triangle Build(double[] sides);
  }
}
