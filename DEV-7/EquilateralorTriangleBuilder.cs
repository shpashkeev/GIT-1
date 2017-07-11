
namespace TypeOfTriangle
{
  class EquilateralorTriangleBuilder : TriangleBuilder
  {
    public EquilateralorTriangleBuilder(TriangleBuilder successor)
    {
      this.successor = successor;
    }

    public override Triangle Build(double[] sides)
    {
      try
      {
        return new EquilateralorTriangle(sides);
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
