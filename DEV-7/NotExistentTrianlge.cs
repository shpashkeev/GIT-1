
namespace TypeOfTriangle
{
  class NotExistentTriangle : Triangle
  {
    const string NOTEXISTENT = "Not-Existent";

    public NotExistentTriangle(double[] sides) : base(sides) { }

    public override string Type()
    {
      return NOTEXISTENT;
    }
  }
}
