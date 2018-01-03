using System;

namespace Task3
{
  /// <summary>
  /// Class describes figures side (like AB) in two-dimensional space.
  /// Side keeps its length in field Length, which is calculated in the corresponding method
  /// </summary>
  public class Side
  {
    public Point A { get; set; }
    public Point B { get; set; }

    public double Length { get; }

    /// <summary>
    /// Sets start and end points of side
    /// and calls calculate method for Length
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
    /// Calculates length of side AB with points A and B
    /// </summary>
    /// <param name="a">Start side point</param>
    /// <param name="b">End side point</param>
    /// <returns>Side length</returns>
    private double GetLength(Point a, Point b)
    {
      return Math.Pow(Math.Pow(
                        Math.Abs(A.X - B.X), 2) + Math.Pow(Math.Abs(A.Y - B.Y), 2), 0.5);
    }
  }
}
