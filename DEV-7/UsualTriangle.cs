
namespace TypeOfTriangle
{
  class UsualTriangle : Triangle
  {
    const string USUAL = "Usual";

    public UsualTriangle(double[] sides) : base(sides) { }

    public override string Type()
    {
      return USUAL;
    }
  }
}
