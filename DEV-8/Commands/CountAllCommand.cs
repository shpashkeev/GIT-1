using System;
using System.Collections.Generic;

namespace ProductsStorage.Commands
{
  public class CountAllCommand : Command
  {
    public void execute(List<Product> products, string arg = null)
    {
      int count = 0;
      foreach (var product in products)
      {
        count += product.Count;
      }
      Console.WriteLine(count);
    }
  }
}
