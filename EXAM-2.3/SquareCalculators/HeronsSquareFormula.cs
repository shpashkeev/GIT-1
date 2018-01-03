using System;

namespace Task3.SquareCalculators
{
  /// <summary>
  /// 
  /// </summary>
  public class HeronsSquareFormula : ISquareCalculatable
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="triangle"></param>
    /// <returns></returns>
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
