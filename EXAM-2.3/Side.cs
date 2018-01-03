using System;

namespace Task3
{
  /// <summary>
  /// 
  /// </summary>
  public class Side
  {
    public Point A { get; set; }
    public Point B { get; set; }

    public double Length { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public Side(Point a, Point b)
    {
      A = a;
      B = b;
      Length = GetLength(A, B);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    private double GetLength(Point a, Point b)
    {
      return Math.Pow(Math.Pow(
                        Math.Abs(A.X - B.X), 2) + Math.Pow(Math.Abs(A.Y - B.Y), 2), 0.5);
    }
  }
}
