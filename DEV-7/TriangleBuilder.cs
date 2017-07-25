
namespace TypeOfTriangle
{
  public abstract class TriangleBuilder
  {
    protected TriangleBuilder successor;

    public abstract Triangle Build(double[] sides);
  }
}
