using System;

namespace StaffSelection
{
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
