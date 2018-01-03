using System;
using System.Linq;
using Task3.SquareCalculators;

namespace Task3.Triangles
{
  /// <summary>
  /// 
  /// </summary>
  public class RestangularTriangle : Triangle
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    public RestangularTriangle(Point a, Point b, Point c) : base(a, b, c)
    {
      if (!IsTriangleRestangular(AB, BC, AC))
      {
        throw new ArgumentException();
      }
      SquareCalculator = new RestangularTriangleSquareFormula();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Side GetFirstCatheter()
    {
      return GetSidesArray().OrderBy(side => side.Length).Min();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Side GetSecondCatheter()
    {
      return GetSidesArray().OrderBy(side => side.Length).ElementAt(1);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Side GetHypotenuse()
    {
      return GetSidesArray().OrderBy(side => side.Length).Max();
    }
    /// <summary>
    /// 
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
