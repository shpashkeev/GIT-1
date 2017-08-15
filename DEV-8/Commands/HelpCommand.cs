using System;
using System.Collections.Generic;

namespace ProductsStorage.Commands
{
  public class HelpCommand : Command
  {
    public void execute(List<Product> products = null, string arg = null)
    {
      foreach (var command in StorageCommander.Commands)
      {
        Console.WriteLine(command);
      }
    }
  }
}
