using System;

namespace TypeOfTriangle
{
  // This class contain method that determines the type of triangle on the sides and builds it
  class TriangleBuilder
  {
    const string BUILDERROR = "Error building triangle";

    public Triangle Build(double[] values)
    {
      try
      {
        TypeOfTriangles type = (new TriangleTypeDetector()).GetTriangleType(values);
        Triangle builtTriangle;
        switch (type)
        {
          case TypeOfTriangles.Equilateralor:
            builtTriangle = new EquilateralorTriangle(values);
            break;

          case TypeOfTriangles.Isosceles:
            builtTriangle = new IsoscelesTriangle(values);
            break;

          default:
            builtTriangle = new UsualTriangle(values);
            break;
        }
        return builtTriangle;
      }
      catch
      {
        // An exception is thrown if there was an error in building the triangle
        throw new Exception(BUILDERROR);
      }
    }
  }
}
