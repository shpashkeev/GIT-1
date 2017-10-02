using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductsStorage.Commands
{
  public class CountTypesCommand : Command
  {
    public void execute(List<Product> products, string arg = null)
    {
      if (!products.Any())
      {
        throw new ArgumentNullException();
      }
      HashSet<string> types = new HashSet<string>();
      foreach (var product in products)
      {
        types.Add(product.Type);
      }
      Console.WriteLine(types.Count);
    }

  }
}
