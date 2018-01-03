
namespace Task3
{
  /// <summary>
  /// Structure describes point in two-dimensional space
  /// </summary>
  public struct Point
  {
    public double X { get; }
    public double Y { get; }

    public Point(double x, double y)
    {
      X = x;
      Y = y;
    }
  }
}
