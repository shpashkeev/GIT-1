using System;

namespace BaseOfProducts
{
  class ProductParamsInputer
  {
    private const string TYPE = "Type: ";
    private const string NAME = "Name: ";
    private const string COUNT = "Count: ";
    private const string PRICE = "Price: ";
    private const string BAD_VALUE = "Bad value. Try again";

    public string TypeInput()
    {
      Console.WriteLine(TYPE);
      return Console.ReadLine();
    }

    public string NameInput()
    {
      Console.WriteLine(NAME);
      return Console.ReadLine();
    }

    public int CountInput()
    {
      bool checker = false;
      int count = 0;
      while (!checker)
      {
        Console.WriteLine(COUNT);
        checker = Int32.TryParse(Console.ReadLine(), out count);
        if (!checker || count < Product.MIN_COUNT)
        {
          Console.WriteLine(BAD_VALUE);
          checker = false;
        }
      }
      return count;
    }

    public double PriceInput()
    {
      bool checker = false;
      double price = 0.0;
      while (!checker)
      {
        Console.WriteLine(PRICE);
        checker = Double.TryParse(Console.ReadLine(), out price);
        if (!checker || price < Product.MIN_PRICE)
        {
          Console.WriteLine(BAD_VALUE);
          checker = false;
        }
      }
      return price;
    }
  }
}
