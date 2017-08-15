using System;

namespace BaseOfProducts
{
  public class ProductBuilder
  {
    private const string BUILD_ERROR = "Product build error";

    public Product Build(string type, string name, int count, double price)
    {
      try
      {
        return new Product(type, name, count, price);
      }
      catch (Exception)
      {
        throw new Exception(BUILD_ERROR);
      }
    }
  }
}
