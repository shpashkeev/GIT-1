﻿using System;
using System.Text;
using StaffSelection.Criterions;

namespace StaffSelection
{
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

    public StaffSelector PackingClientPersonalData()
    {
      int clientAmount;
      int clientProductivity;

      Console.Write(Amount);
      while (!(int.TryParse(Console.ReadLine(), out clientAmount) && clientAmount > 0))
      {
        Console.WriteLine(ClInputError);
      }

      Console.Write(Productivity);
      while (!(int.TryParse(Console.ReadLine(), out clientProductivity) && clientProductivity > 0))
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
        Console.Write(Answer);

        if (int.TryParse(Console.ReadLine(), out choice))
        {
          switch (choice)
          {
            case 1:
              {
                staffSelector.SelectionCriterion = new MaxProductivityCriterion();
                isCriterionNotSelected = false;
                break;
              }
            case 2:
              {
                staffSelector.SelectionCriterion = new MinAmountCriterion();
                isCriterionNotSelected = false;
                break;
              }
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
