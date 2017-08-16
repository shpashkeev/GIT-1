using System;

namespace ProductsStorage
{
  public class Product
  {
    public string Type { get; }
    public string Name { get; }
    private int count;
    private double price;

    public int Count
    {
      get { return count; }
      set
      {
        if (value <= MIN_COUNT)
        {
          throw new ArgumentException();
        }
        count = value;
      }
    }

    public double Price
    {
      get { return price; }
      set
      {
        if ((value - MIN_PRICE)<=EPS)
        {
          throw new ArgumentException();
        }
        price = value;
      }
    }

    public Product(string type, string name, int count, double price)
    {
      Type = type;
      Name = name;
      Count = count;
      Price = price;
    }

    public string Info()
    {
      return $"Type: {Type} Name: {Name} Count: {Count} Price: {Price}";
    }

    public const int MIN_COUNT = 0;
    public const double MIN_PRICE = 0.0D;
    private const double EPS = 1e-2;
  }
}
