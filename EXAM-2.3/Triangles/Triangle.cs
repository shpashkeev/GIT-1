using System;

namespace Task3
{
  /// <summary>
  /// Abstract class Triangle
  /// with 3 sides
  /// Perimeter and Square
  /// </summary>
  public abstract class Triangle
  {
    public Side AB { get; }
    public Side BC { get; }
    public Side AC { get; }

    public ISquareCalculatable SquareCalculator { get; set; }

    /// <summary>
    /// Create triangle from 3 points in space
    /// Check if possible creating with such points
    /// </summary>
    /// <param name="a">Point A</param>
    /// <param name="b">Point B</param>
    /// <param name="c">Point C</param>
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
    /// Packs triangles sides in array
    /// </summary>
    /// <returns>Array with sides</returns>
    public Side[] GetSidesArray()
    {
      return new Side[] {AB, BC, AC};
    }

    /// <summary>
    /// Perimeter of triangle
    /// </summary>
    /// <returns>Perimeter value</returns>
    public double GetPerimeter()
    {
      return AB.Length + BC.Length + AC.Length;
    }

    /// <summary>
    /// Square of triangle calculates with helps from specific Calculator
    /// </summary>
    /// <returns>Square value</returns>
    public double GetSquare()
    {
      return SquareCalculator.GetSquare(this);
    }

  }
}
