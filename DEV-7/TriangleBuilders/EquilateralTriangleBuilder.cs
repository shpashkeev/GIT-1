
namespace TypeOfTriangle
{
  class EquilateralTriangleBuilder : TriangleBuilder
  {
    public EquilateralTriangleBuilder(TriangleBuilder successor)
    {
      this.successor = successor;
    }

    public override Triangle Build(double[] sides)
    {
      try
      {
        return new EquilateralTriangle(sides);
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
