using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaffSelection.Criterions;

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
    private const string ClInputError = "Bad value. Try again.";
    private const string Welcome = "Welcome!";
    private const string Choice = "\nPress Esc to exit, or any key to continue";
    private const string CriterionChoice = "\n Select one of suggested criterions:\n";

    private const string Amount = "Amount: ";
    private const string Productivity = "Productivity: ";

    private const string Criterion1 = "1/ Maximum productivity within the amount.";
    private const string Criterion2 = "2/ Minimum cost for a fixed productivity.";
    private const string Criterion3 = "3/ Minimum number of employees is higher than Junior for fixed productivity.";


    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine(Welcome);

        ////////////////
        double clientAmount;
        int clientProductivity;

        while (!(double.TryParse(Console.ReadLine(), out clientAmount) && clientAmount > 0))
        {
          Console.WriteLine(ClInputError);
        }

        while (!(int.TryParse(Console.ReadLine(), out clientProductivity) && clientProductivity > 0))
        {
          Console.WriteLine(ClInputError);
        }

        StaffSelector staffSelector = new StaffSelector(clientAmount, clientProductivity);
        ////////////////
        do
        {
          StringBuilder criterionsChoiceBuilder = new StringBuilder(CriterionChoice);
          criterionsChoiceBuilder.AppendLine(Criterion1).AppendLine(Criterion2).AppendLine(Criterion3);

          switch (int.Parse(Console.ReadLine()))
          {
            case 1:
              {
                staffSelector.selectionCriterion = new MaxProductivityCriterion();
                break;
              }
            case 2:
              {
                staffSelector.selectionCriterion = new MinAmountCriterion();
                break;
              }
            case 3:
              {
                staffSelector.selectionCriterion = new MinCountOfWorkers();
                break;
              }
            default:
              {
                Console.WriteLine(ClInputError);
                continue;
              }
          }

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
