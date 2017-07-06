
namespace TypeOfTriangle
{
  class EquilateralorTriangle : Triangle
  {
    const string EQUILATERALOR = "Equilateralor";

    public EquilateralorTriangle(double[] sides) : base(sides) { }

    public override string Type()
    {
      return EQUILATERALOR;
    }
  }
}
