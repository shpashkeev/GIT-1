using System;

namespace Task3.SquareCalculators
{
  /// <summary>
  /// Class contains method
  /// That returns area of triangle by herons square formula
  /// </summary>
  public class HeronsSquareFormula : ISquareCalculatable
  {
    /// <summary>
    /// Herons formula for calculating the area of ​​a triangle
    /// </summary>
    /// <param name="triangle">input triangle</param>
    /// <returns>Square value</returns>
    public double GetSquare(Triangle triangle)
    {
      double halfPerimeter = 0.5 * triangle.GetPerimeter();
      return Math.Pow(halfPerimeter
                      * (halfPerimeter - triangle.AB.Length)
                      * (halfPerimeter - triangle.BC.Length)
                      * (halfPerimeter - triangle.AC.Length), 0.5);
    }
  }
}
