using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseOfProducts
{
  class ListProductsCommander
  {
    private const string PROMPT = ">";
    private const string COMMAND_NOT_FOUND = "Not found such command";

    private const string COUNT_TYPES = "count types";
    private const string COUNT_ALL = "count all";
    private const string AVERAGE_PRICE = "average price";
    private const string EXIT = "exit";

    private string[] Commands = {COUNT_TYPES, COUNT_ALL, AVERAGE_PRICE, EXIT};

    private int CountTypes(List<Product> products)
    { 
      HashSet<string> types = new HashSet<string>();
      foreach (var product in products)
      {
        types.Add(product.Type);
      }
      return types.Count;
    }

    private int CountAll(List<Product> products)
    {
      int count = 0;
      foreach (var product in products)
      {
        count += product.Count;
      }
      return count;
    }
    private double AveragePrice(List<Product> products, IEnumerable<string> args)
    {
      double result = 0.0;
      if (args.Any())
      {

        string type = string.Join(" ", args);
        var productsWithType = products.FindAll(product => product.Type.Equals(type));
        foreach (var pwt in productsWithType)
        {
          result += pwt.Price;
        }
        return result / productsWithType.Count;
      }
      foreach (var product in products)
      {
        result += product.Price;
      }
      return result / products.Count;
    }


    public void Run(List<Product> products)
    {
      bool run = true;
      while (run)
      {
        Console.Write(PROMPT);
        string input = Console.ReadLine();

        var tokens = SplitIntoTokens(input);
        string command = tokens.First();
        int commandLength = 1;
        if (!Commands.Contains(command))
        {
          command = string.Join(" ", tokens.Take(2));
          commandLength++;
        }
        var args = tokens.Skip(commandLength);
        switch (command)
        {
          case COUNT_TYPES:
            Console.WriteLine(COUNT_TYPES + CountTypes(products));
            break;
          case COUNT_ALL:
            Console.WriteLine(COUNT_ALL + CountAll(products));
            break;
          case AVERAGE_PRICE:
            Console.WriteLine(AVERAGE_PRICE + AveragePrice(products, args));
            break;
          case EXIT:
            run = false;
            Console.WriteLine("Goodbye!");
            break;
          default:
            Console.WriteLine(COMMAND_NOT_FOUND);
            break;
        }


      }

    }

    private static IEnumerable<string> SplitIntoTokens(string s)
    {
      return s.Split(null as char[], StringSplitOptions.RemoveEmptyEntries);
    }
  }
}
