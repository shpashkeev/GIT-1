using System;

namespace StaffSelection
{
  public class StaffSelector
  {
    private double amount;

    public ICriterionSelectable selectionCriterion;

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

  }
}
