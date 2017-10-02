using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductsStorage.Commands
{
  public class CountAllCommand : Command
  {
    public void execute(List<Product> products, string arg = null)
    {
      if (!products.Any())
      {
        throw new ArgumentNullException();
      }
      int count = 0;
      foreach (var product in products)
      {
        count += product.Count;
      }
      Console.WriteLine(count);
    }
  }
}
