using System;
using System.Collections.Generic;
using StaffSelection.Fellow_Workers;

namespace StaffSelection
{
  public class StaffSelector
  {
    private double amount;

    public Team Staffs { get; set; }
    public ICriterionSelectable SelectionCriterion { private get; set; }

    public double Amount
    {
      get { return amount; }
      set
      {
        if (value <= 0)
        {
          throw new ArgumentException();
        }
        amount = value;
      }
    }

    public int Productivity { get; set; }

    public StaffSelector(double amount, int productivity)
    {
      Amount = amount;
      Productivity = productivity;
    }

    public void SelectFellowWorkers()
    {
      SelectionCriterion.Select(this);
    }
  }
}
