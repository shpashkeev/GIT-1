
namespace TypeOfTriangle
{
  public class UsualTriangle : Triangle
  {
    public UsualTriangle(double[] sides) : base(sides) { }

    public override TypeOfTriangles Type()
    {
      return TypeOfTriangles.Usual;
    }

    public override string TypeString()
    {
      return THISTRIANGLE + Type();
    }
  }
}
