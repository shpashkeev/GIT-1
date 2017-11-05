using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaffSelection.Criterions;

namespace StaffSelection
{
  public class StaffSelectionConsoleHandler
  {
    private const string ClInputError = "Bad value. Try again.";

    private const string Amount = "Amount: ";
    private const string Productivity = "Productivity: ";
    private const string CriterionChoice = "\n Select one of suggested criterions:\n";
    private const string Criterion1 = "1/ Maximum productivity within the amount.";
    private const string Criterion2 = "2/ Minimum cost for a fixed productivity.";
    private const string Criterion3 = "3/ Minimum number of employees is higher than Junior for fixed productivity.";

    public StaffSelector PackingClientPersonalData()
    {
      double clientAmount;
      int clientProductivity;

      Console.Write(Amount);
      while (!(Double.TryParse(Console.ReadLine(), out clientAmount) && clientAmount > 0))
      {
        Console.WriteLine(ClInputError);
      }

      Console.Write(Productivity);
      while (!(Int32.TryParse(Console.ReadLine(), out clientProductivity) && clientProductivity > 0))
      {
        Console.WriteLine(ClInputError);
      }

      return new StaffSelector(clientAmount, clientProductivity);
    }

    public void SelectCriterion(StaffSelector staffSelector)
    {
      StringBuilder criterionsChoiceBuilder = new StringBuilder(CriterionChoice);
      criterionsChoiceBuilder.AppendLine(Criterion1).AppendLine(Criterion2).AppendLine(Criterion3);
      bool isCriterionNotSelected = true;

      do
      {
        Console.WriteLine(criterionsChoiceBuilder);
        int choice;

        if (int.TryParse(Console.ReadLine(), out choice))
        {
          switch (choice)
          {
            case 1:
              {
                staffSelector.selectionCriterion = new MaxProductivityCriterion();
                isCriterionNotSelected = false;
                break;
              }
            case 2:
              {
                staffSelector.selectionCriterion = new MinAmountCriterion();
                isCriterionNotSelected = false;
                break;
              }
            case 3:
              {
                staffSelector.selectionCriterion = new MinCountOfWorkers();
                isCriterionNotSelected = false;
                break;
              }
            default:
              {
                Console.WriteLine(ClInputError);
                continue;
              }
          }
        }
        else
        {
          Console.WriteLine(ClInputError);
        }
      } while (isCriterionNotSelected);
    }
  }
}
