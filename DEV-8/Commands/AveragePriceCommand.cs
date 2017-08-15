using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductsStorage.Commands
{
  // Single class for commands
  // "average price" and "average price type"
  // Method search type of product in parameter args
  public class AveragePriceCommand : Command
  {
    private const string PRODUCTS_NOT_FOUND = "Not found such product. Displayed average price";

    public void execute(List<Product> products, string arg)
    {
      double result = 0.0;

      // If user entered command like "average price type"
      if (arg.Any() && products.Exists(product => product.Type.Equals(arg)))
      {

        var productsWithType = products.FindAll(product => product.Type.Equals(arg));
        foreach (var product in productsWithType)
        {
          result += product.Price;
        }
        Console.WriteLine(result / productsWithType.Count);
      }
      if (arg.Any() && !(products.Exists(product => product.Type.Equals(arg))))
      {
        Console.WriteLine(PRODUCTS_NOT_FOUND);
      }
      // User entered command "average price"
      foreach (var product in products)
      {
        result += product.Price;
      }
      Console.WriteLine(result / products.Count);
    }
  }
}
