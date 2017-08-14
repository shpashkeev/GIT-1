using System;

namespace BaseOfProducts
{
  class Product
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
        if (value <= MIN_PRICE)
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

    private const int MIN_COUNT = 0;
    private const double MIN_PRICE = 0.0;
  }
}
