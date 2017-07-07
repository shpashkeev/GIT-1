
namespace TypeOfTriangle
{
  // Absract class Triangle without type
  abstract class Triangle
  {
    public double SideA
    { get; }

    public double SideB
    { get; }

    public double SideC
    { get; }

    public Triangle(double[] sides)
    {
      SideA = sides[0];
      SideB = sides[1];
      SideC = sides[2];
    }

    // Abstract method then return type of Triangle in child classes
    public abstract TypeOfTriangles Type();
  }
}
