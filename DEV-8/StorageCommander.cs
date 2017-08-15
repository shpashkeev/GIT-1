using System;
using System.Collections.Generic;
using System.Linq;
using ProductsStorage.Commands;

namespace ProductsStorage
{
  public class StorageCommander
  {
    // Command-line messages
    private const string PROMPT = ">";
    private const string WELCOME = "Welcome to ProductBase Commander!";
    private const string COMMAND_NOT_FOUND = "Not found such command. Enter help to display possible commands";
    private const string EMPTY = "Empty storage. Cannot run!";

    // Commands that are avaible to the user
    private const string COUNT_TYPES = "count types";
    private const string COUNT_ALL = "count all";
    private const string AVERAGE_PRICE = "average price";
    private const string AVERAGE_PRICE_TYPE = "average price 'type'";
    private const string EXIT = "exit";
    private const string HELP = "help";

    public static readonly string[] Commands = { COUNT_TYPES, COUNT_ALL, AVERAGE_PRICE, AVERAGE_PRICE_TYPE, EXIT, HELP };

    private readonly Dictionary<string, Command> CommandsDictionary =
      new Dictionary<string, Command>()
      {
        {COUNT_TYPES, new CountTypesCommand()},
        {COUNT_ALL, new CountAllCommand()},
        {AVERAGE_PRICE, new AveragePriceCommand() },
        {EXIT, new ExitCommand() },
        {HELP, new HelpCommand() }
      };

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
        if (Commands.Contains(command))
        {
          CommandsDictionary[command].execute(products, args);
        }
        else
        {
          Console.WriteLine(COMMAND_NOT_FOUND);
        }
      }
    }
  }
}

