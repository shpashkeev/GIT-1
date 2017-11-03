using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffSelection
{
  public class StaffSelector
  {
    private double currentSum;
    private int productivity;

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

    public int Productivity
    {
      get { return productivity; }
      set { productivity = value; }
    }
  }
}
