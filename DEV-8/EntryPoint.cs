using System;
using System.Collections.Generic;

namespace BaseOfProducts
{
  class EntryPoint
  {

    private const string CHOICE = "Press Esc to exit, or any key to continue";
    static void Main(string[] args)
    {
      List<Product> products = new List<Product>();
      ProductBuilder pb = new ProductBuilder();
      ProductParamsInputer ppi = new ProductParamsInputer();
      ListProductsCommander lpc = new ListProductsCommander();
      try
      {
        do
        {
          products.Add(pb.Build(ppi.TypeInput(), ppi.NameInput(), ppi.CountInput(), ppi.PriceInput()));
          Console.WriteLine(CHOICE);
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        lpc.Run(products);
        Console.ReadKey();
      }
      catch (Exception exc)
      {
        Console.WriteLine(exc.Message);
      }
    }
  }
}
