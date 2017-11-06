using System;
using StaffSelection.FellowWorkers;

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

    private const int JuniorSalary = 300;
    private const int MiddleSalary = 500;
    private const int SeniorSalary = 700;
    private const int LeadSalary = 1000;

    private const int JuniorProductivity = 170;
    private const int MiddleProductivity = 340;
    private const int SeniorProductivity = 680;
    private const int LeadProductivity = 900;

    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine(Welcome);
        StaffSelectionConsoleHandler consoleHandler = new StaffSelectionConsoleHandler();

        Team staffs = new Team(
          new Junior(JuniorSalary, JuniorProductivity),
          new Middle(MiddleSalary, MiddleProductivity),
          new Senior(SeniorSalary, SeniorProductivity),
          new Lead(LeadSalary, LeadProductivity));

        do
        {
          // called method for input
          // current amount and required productivity of the client
          StaffSelector currentSelector = consoleHandler.PackingClientPersonalData();
          currentSelector.Staffs = staffs;
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
