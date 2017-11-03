using System;

namespace StaffSelection
{
  public class StaffSelector
  {
    private double currentSum;

    public ICriterionSelectable selectionCriterion;

    public double CurrentSum
    {
      get { return currentSum; }
      set
      {
        if (value <= 0)
        {
          throw new ArgumentException();
        }
        currentSum = value;
      }
    }

    public int Productivity { get; set; }

  }
}
