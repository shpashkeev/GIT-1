using System;

namespace Task3.SquareCalculators
{
  /// <summary>
  /// 
  /// </summary>
  public class GeneralSquareFormula : ISquareCalculatable
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="triangle"></param>
    /// <returns></returns>
    public double GetSquare(Triangle triangle)
    {
      return 0.5 * triangle.AB.Length * GetHeightOnAB(triangle);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="triangle"></param>
    /// <returns></returns>
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
