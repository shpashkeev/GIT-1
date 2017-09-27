using System;
using System.Collections.Generic;

namespace ProductsStorage.Commands
{
  public class ExitCommand : Command
  {
    private const string GOODBYE = "Goodbye!";
    public void execute(List<Product> products = null, string arg = null)
    {
      Console.WriteLine(GOODBYE);
      Environment.Exit(0);
    }
  }
}
