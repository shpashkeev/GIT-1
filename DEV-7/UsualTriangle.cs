
using System;

namespace TypeOfTriangle
{
  class UsualTriangle : Triangle
  {

    public UsualTriangle(double[] sides) : base(sides) { }

    public override TypeOfTriangles Type()
    {
      return TypeOfTriangles.Usual;
    }
  }
}
