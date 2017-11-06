using System;
using System.Text;
using StaffSelection.Criterions;

namespace StaffSelection
{
  /// <summary>
  /// Class-handler of the data
  /// entered by user into console
  /// </summary>
  public class StaffSelectionConsoleHandler
  {
    private const string ClInputError = "Bad value. Try again.";

    private const string Amount = "Amount: ";
    private const string Productivity = "Productivity: ";
    private const string CriterionChoice = "\nSelect one of suggested criterions:\n";
    private const string Criterion1 = "1/ Maximum productivity within the amount.";
    private const string Criterion2 = "2/ Minimum cost for a fixed productivity.";
    private const string Criterion3 = "3/ Minimum number of employees is higher than Junior for fixed productivity.";
    private const string Answer = "Answer: ";

    /// <summary>
    /// Method packs Amount and Productivity
    /// in a instance of class StaffSelector
    /// </summary>
    /// <returns>Instance of class StaffSelector with clients data</returns>
    public StaffSelector PackingClientPersonalData()
    {
      int clientAmount;
      int clientProductivity;

      // Entering a valid amount
      Console.Write(Amount);
      while (!(int.TryParse(Console.ReadLine(), out clientAmount) && clientAmount > 0))
      {
        Console.WriteLine(ClInputError);
      }

      // Entering a valid productivity
      Console.Write(Productivity);
      while (!(int.TryParse(Console.ReadLine(), out clientProductivity) && clientProductivity > 0))
      {
        Console.WriteLine(ClInputError);
      }

      return new StaffSelector(clientAmount, clientProductivity);
    }

    /// <summary>
    /// Method invites client to enter the desired criterion.
    /// Then he writes down selected criterion in field SelectionCriterion
    /// of parameter staffSelector.
    /// </summary>
    /// <param name="staffSelector"></param>
    public void SelectCriterion(StaffSelector staffSelector)
    {
      StringBuilder criterionsChoiceBuilder = new StringBuilder(CriterionChoice);
      criterionsChoiceBuilder.AppendLine(Criterion1).AppendLine(Criterion2).AppendLine(Criterion3);
      bool isCriterionNotSelected = true;

      do
      {
        Console.WriteLine(criterionsChoiceBuilder);
        int choice;
        Console.Write(Answer);

        if (int.TryParse(Console.ReadLine(), out choice))
        {
          switch (choice)
          {
            // Criteria 1/ Maximum productivity within the amount.
            case 1:
              {
                staffSelector.SelectionCriterion = new MaxProductivityCriterion();
                isCriterionNotSelected = false;
                break;
              }
            // Criteria 2/ Minimum cost for a fixed productivity.
            case 2:
              {
                staffSelector.SelectionCriterion = new MinAmountCriterion();
                isCriterionNotSelected = false;
                break;
              }
            // Criteria 3/ Minimum number of employees is higher than Junior for fixed productivity.
            case 3:
              {
                staffSelector.SelectionCriterion = new MinCountOfElderWorkersCriterion();
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
