using System;
using System.Collections.Generic;
using StaffSelection.FellowWorkers;

namespace StaffSelection
{
  /// <summary>
  /// List of qualifications
  /// </summary>
  public enum Qualifications
  {
    Junior,
    Middle,
    Senior,
    Lead
  }
  /// <summary>
  /// Constant fields in this class
  /// contain value of cost and productivity
  /// of employees of the company.
  /// Main method initializes instances of company employees
  /// and calls a class to handle data entered by client.
  /// </summary>
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

    /// <summary>
    /// The method creates an instance of the client's handler class
    /// and initializes the employee structure.
    /// After then it calls handler class methods of commands
    /// entered by client.
    /// After each iteration of the loop do-while,
    /// user is asked to press a key Escape
    /// or continue working with application
    /// by pressing any other key.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine(Welcome);
        StaffSelectionConsoleHandler consoleHandler = new StaffSelectionConsoleHandler();

        Staffs staffs = new Staffs(
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
          List<Dictionary<FellowWorker, int>> result = currentSelector.SelectTeams();

          // print results
          consoleHandler.PrintTeams(result);

          Console.WriteLine(Choice);
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);


      }
      catch (Exception exc)
      {
        Console.WriteLine(exc.Message);
      }
    }
  }
}
