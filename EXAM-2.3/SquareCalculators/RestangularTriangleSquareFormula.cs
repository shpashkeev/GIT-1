using System;
using Task3.Triangles;

namespace Task3.SquareCalculators
{
  /// <summary>
  /// Class contains method
  /// that returns area of restangular triangle with specify formula
  /// </summary>
  public class RestangularTriangleSquareFormula : ISquareCalculatable
  {
    private const string InvalidTriangle = "Invalid input triangle";

    /// <summary>
    /// Formula for calculating the area of ​​a restangular triangle.
    /// First checks if input triangle is restangular.
    /// If false - throws ArgumentException
    /// </summary>
    /// <param name="triangle">input triangle</param>
    /// <returns>Square value</returns>
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
