
namespace TypeOfTriangle
{
  class UsualTriangleBuilder : TriangleBuilder
  {
    public UsualTriangleBuilder(TriangleBuilder successor)
    {
      this.successor = successor;
    }

    public override Triangle Build(double[] sides)
    {
      try
      {
        return new UsualTriangle(sides);
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
