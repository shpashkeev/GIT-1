using System;
using Task3.Triangles;

namespace Task3.SquareCalculators
{
  /// <summary>
  /// 
  /// </summary>
  public class RestangularTriangleSquareFormula : ISquareCalculatable
  {
    private const string InvalidTriangle = "Invalid input triangle";

    /// <summary>
    /// 
    /// </summary>
    /// <param name="triangle"></param>
    /// <returns></returns>
    public double GetSquare(Triangle triangle)
    {
      RestangularTriangle restangularTriangle = (RestangularTriangle) triangle;
      if (restangularTriangle == null)
      {
        throw new ArgumentException(InvalidTriangle);
      }
      return 0.5 * restangularTriangle.GetFirstCatheter().Length * restangularTriangle.GetSecondCatheter().Length;
    }
  }
}
