using System;
using System.Collections.Generic;
using StaffSelection.FellowWorkers;

namespace StaffSelection
{
  /// <summary>
  /// The parameters required for recruiting employees
  /// are recorded in the appropriate fields: Amount and Productivity.
  /// The process of selecting employees passes
  /// according to the criterion recorded in the appropriate field.
  /// </summary>
  public class StaffSelector
  {
    private int amount;
    private int productivity;

    public Staffs Staffs { get; set; }
    public ByCriterionSelector SelectionCriterion { private get; set; }

    public int Amount
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

    public int Productivity
    {
      get { return productivity; }
      set
      {
        if (value <= 0)
        {
          throw new ArgumentException();
        }
        productivity = value;
      }
    }

    public StaffSelector(int amount, int productivity)
    {
      Amount = amount;
      Productivity = productivity;
    }

    public List<Dictionary<string, int>> SelectTeams()
    {
      return SelectionCriterion.Select(this);
    }
  }
}
