
namespace TypeOfTriangle
{
  public class IsoscelesTriangleBuilder : TriangleBuilder
  {
    public IsoscelesTriangleBuilder(TriangleBuilder successor)
    {
      this.successor = successor;
    }

    public override Triangle Build(double[] sides)
    {
      try
      {
        return new IsoscelesTriangle(sides);
      }
      catch (TriangleTypeException)
      {
        if (successor != null)
        {
          return successor.Build(sides);
        }
        throw new TriangleBuildException();
      }
    }
  }
}
