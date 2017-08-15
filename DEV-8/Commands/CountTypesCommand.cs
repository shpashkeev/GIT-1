using System;
using System.Collections.Generic;

namespace ProductsStorage.Commands
{
  public class CountTypesCommand : Command
  {
    public void execute(List<Product> products, string arg = null)
    {
      HashSet<string> types = new HashSet<string>();
      foreach (var product in products)
      {
        types.Add(product.Type);
      }
      Console.WriteLine(types.Count);
    }

  }
}
