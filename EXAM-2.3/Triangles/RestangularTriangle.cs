using System;
using System.Linq;
using Task3.SquareCalculators;

namespace Task3.Triangles
{
  /// <summary>
  /// Class restangular triangle
  /// With 3 sides: 2 catheters and hypotenuse
  /// </summary>
  public class RestangularTriangle : Triangle
  {
    /// <summary>
    /// Create restangular triangle from 3 points in space
    /// Checks if is possible creating rest triangle from such points
    /// </summary>
    /// <param name="a">Point A</param>
    /// <param name="b">Point B</param>
    /// <param name="c">Point C</param>
    public RestangularTriangle(Point a, Point b, Point c) : base(a, b, c)
    {
      if (!IsTriangleRestangular(AB, BC, AC))
      {
        throw new ArgumentException();
      }
      SquareCalculator = new RestangularTriangleSquareFormula();
    }

    /// <summary>
    /// Side - catheter with smaller length
    /// </summary>
    /// <returns></returns>
    public Side GetFirstCatheter()
    {
      return GetSidesArray().OrderBy(side => side.Length).Min();
    }

    /// <summary>
    /// Side - catheter with bigger length for catheters
    /// </summary>
    /// <returns></returns>
    public Side GetSecondCatheter()
    {
      return GetSidesArray().OrderBy(side => side.Length).ElementAt(1);
    }

    /// <summary>
    /// Side hypotenuse - side with the biggest side length in triangle
    /// </summary>
    /// <returns></returns>
    public Side GetHypotenuse()
    {
      return GetSidesArray().OrderBy(side => side.Length).Max();
    }

    /// <summary>
    /// Condition for restangular triangle
    /// </summary>
    /// <returns></returns>
    private bool IsTriangleRestangular(Side a, Side b, Side c)
    {
      if (Math.Pow(a.Length, 2) + Math.Pow(b.Length, 2) - Math.Pow(c.Length, 2) <= Double.Epsilon
          || Math.Pow(b.Length, 2) + Math.Pow(c.Length, 2) - Math.Pow(a.Length, 2) <= Double.Epsilon
          || Math.Pow(c.Length, 2) + Math.Pow(a.Length, 2) - Math.Pow(b.Length, 2) <= Double.Epsilon)
      {
        return true;
      }
      return false;
    }

  }
}
