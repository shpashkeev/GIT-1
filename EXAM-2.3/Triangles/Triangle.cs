using System;

namespace Task3
{
  /// <summary>
  /// 
  /// </summary>
  public abstract class Triangle
  {
    public Side AB { get; }
    public Side BC { get; }
    public Side AC { get; }

    public ISquareCalculatable SquareCalculator { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    protected Triangle(Point a, Point b, Point c)
    {
      Side ab = new Side(a,b);
      Side bc = new Side(b,c);
      Side ac = new Side(a,c);

      // Check on valid values
      if (ab.Length < Double.Epsilon 
        || bc.Length < Double.Epsilon
        || ac.Length < Double.Epsilon)
      {
        throw new ArgumentException();
      }
      // Condition of existance
      if (!(ab.Length + bc.Length >= ac.Length
         && bc.Length + ac.Length >= ab.Length
         && ab.Length + ac.Length >= bc.Length))
      {
        throw new ArgumentException();
      }
      AB = ab;
      BC = bc;
      AC = ac;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Side[] GetSidesArray()
    {
      return new Side[] {AB, BC, AC};
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public double GetPerimeter()
    {
      return AB.Length + BC.Length + AC.Length;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public double GetSquare()
    {
      return SquareCalculator.GetSquare(this);
    }

  }
}
