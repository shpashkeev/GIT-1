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
    private const string WELCOME = "Welcome to ProductBase Commander!";
    private const string COMMAND_NOT_FOUND = "Not found such command. Enter HELP to display possible commands";
    private const string EMPTY = "Empty storage. Cannot run!";

    private const string COUNT_TYPES = "count types";
    private const string COUNT_ALL = "count all";
    private const string AVERAGE_PRICE = "average price";
    private const string AVERAGE_PRICE_TYPE = "average price 'type'";
    private const string EXIT = "exit";
    private const string HELP = "help";

    private string[] Commands = { COUNT_TYPES, COUNT_ALL, AVERAGE_PRICE,AVERAGE_PRICE_TYPE, EXIT, HELP };

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

    private void Help()
    {
      foreach (var command in Commands)
      {
        Console.WriteLine(command);
      }
    }

    public void Run(List<Product> products)
    {
      bool run = true;
      if (!products.Any())
      {
        throw new Exception(EMPTY);
      }
      Console.WriteLine(WELCOME);
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
            Console.WriteLine(CountTypes(products));
            break;
          case COUNT_ALL:
            Console.WriteLine(CountAll(products));
            break;
          case AVERAGE_PRICE:
            Console.WriteLine(AveragePrice(products, args));
            break;
          case EXIT:
            run = false;
            Console.WriteLine("Goodbye!");
            break;
          case HELP:
            Help();
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

