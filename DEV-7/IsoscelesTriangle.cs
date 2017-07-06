
namespace TypeOfTriangle
{
  class IsoscelesTriangle : Triangle
  {
    const string ISOSCELES = "Isosceles";

    public IsoscelesTriangle(double[] sides) : base(sides) { }

    public override string Type()
    {
      return ISOSCELES;
    }
  }
}
