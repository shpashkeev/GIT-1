using System;
using System.Collections.Generic;
using System.Linq;

namespace BaseOfProducts
{
  public class ListProductsCommander
  {
    // Command-line messages
    private const string PROMPT = ">";
    private const string WELCOME = "Welcome to ProductBase Commander!";
    private const string COMMAND_NOT_FOUND = "Not found such command. Enter help to display possible commands";
    private const string PRODUCTS_NOT_FOUND = "Not found such product. Displayed average price";
    private const string EMPTY = "Empty storage. Cannot run!";
    private const string GOODBYE = "Goodbye!";

    // Commands that are avaible to the user
    private const string COUNT_TYPES = "count types";
    private const string COUNT_ALL = "count all";
    private const string AVERAGE_PRICE = "average price";
    private const string AVERAGE_PRICE_TYPE = "average price 'type'";
    private const string EXIT = "exit";
    private const string HELP = "help";

    private readonly string[] Commands = { COUNT_TYPES, COUNT_ALL, AVERAGE_PRICE,AVERAGE_PRICE_TYPE, EXIT, HELP };

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

    // Single method for commands
    // "average price" and "average price type"
    // Method search type of product in parameter args
    private double AveragePrice(List<Product> products, string arg)
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
        return result / productsWithType.Count;
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
        // Command reading
        string command = input;
        foreach (var comm in Commands)
        {
          if (input.StartsWith(comm))
          {
            command = comm;
            break;
          }
        }
        string args = input.Substring(command.Length).TrimStart(null);

        // Command execution
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
            Console.WriteLine(GOODBYE);
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

