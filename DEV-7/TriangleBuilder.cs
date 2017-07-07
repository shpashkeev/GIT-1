
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
        TypeOfTriangles type = (new DetectorTriangleType()).GetTriangleType(values);
        Triangle builtTriangle;
        switch (type)
        {
          // When detected type is Not-Existent the triangle is constructed as Not-Existent
          case TypeOfTriangles.NotExistent:
            builtTriangle = new NotExistentTriangle(values);
            break;

          // When detected type is Equilateralor the triangle is constructed as Equilateralor
          case TypeOfTriangles.Equilateralor:
            builtTriangle = new EquilateralorTriangle(values);
            break;

          // When detected type is Isosceles the triangle is constructed as Isosceles
          case TypeOfTriangles.Isosceles:
            builtTriangle = new IsoscelesTriangle(values);
            break;

          // Default type of builded triangle is Usual
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
