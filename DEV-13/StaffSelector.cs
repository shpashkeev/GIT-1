using System;

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

    public Team Staffs { get; set; }
    public ICriterionSelectable SelectionCriterion { private get; set; }

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

    public int Productivity { get; set; }

    public StaffSelector(int amount, int productivity)
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
