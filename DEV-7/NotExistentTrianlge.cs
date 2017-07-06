
namespace TypeOfTriangle
{
  class NotExistentTriangle : Triangle
  {
    public NotExistentTriangle(double[] sides) : base(sides) { }

    public override TypeOfTriangles Type()
    {
      return TypeOfTriangles.NotExistent;
    }
  }
}
