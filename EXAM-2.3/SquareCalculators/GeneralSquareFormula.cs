using System;

namespace Task3.SquareCalculators
{
  /// <summary>
  /// Class contains 2 methods
  /// First main method returns area of triangle
  /// Second is help method, which gets height in triangle
  /// </summary>
  public class GeneralSquareFormula : ISquareCalculatable
  {
    /// <summary>
    /// General formula for calculating the area of ​​a triangle
    /// </summary>
    /// <param name="triangle">input triangle</param>
    /// <returns>Square value</returns>
    public double GetSquare(Triangle triangle)
    {
      return 0.5 * triangle.AB.Length * GetHeightOnAB(triangle);
    }

    /// <summary>
    /// Calculating height in triangle
    /// </summary>
    /// <param name="triangle">input triangle</param>
    /// <returns>Height value</returns>
    private double GetHeightOnAB(Triangle triangle)
    {
      double halfPerimeter = 0.5 * triangle.GetPerimeter();
      double root = Math.Pow(halfPerimeter
                             * (halfPerimeter - triangle.AB.Length)
                             * (halfPerimeter - triangle.BC.Length)
                             * (halfPerimeter - triangle.AC.Length), 0.5);
      return 2 * root / triangle.AB.Length;
    }
  }
}
