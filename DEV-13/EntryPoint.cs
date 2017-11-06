using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaffSelection.Criterions;
using StaffSelection.Fellow_Workers;

namespace StaffSelection
{
  public enum Qualifications
  {
    Junior,
    Middle,
    Senior,
    Lead
  }

  public class EntryPoint
  {

    private const string Welcome = "Welcome!";
    private const string Choice = "\nPress Esc to exit, or any key to continue";


    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine(Welcome);
        StaffSelectionConsoleHandler consoleHandler = new StaffSelectionConsoleHandler();

        do
        {
          // called method for input
          // current amount and required productivity of the client
          StaffSelector currentSelector = consoleHandler.PackingClientPersonalData();

          // called method for choice desired criteria
          consoleHandler.SelectCriterion(currentSelector);

          // choice of employees according to the entered parameters
          currentSelector.SelectFellowWorkers();

          // print selected team
          //consoleHandler.PrintSelectedTeam(selectedWorkers);

          Console.WriteLine(Choice);
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);


      }
      catch (Exception exc)
      {
        Console.WriteLine(exc.Message);
        Console.ReadKey();
      }
    }
  }
}
