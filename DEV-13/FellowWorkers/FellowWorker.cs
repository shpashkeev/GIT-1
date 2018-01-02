using System;

namespace StaffSelection.FellowWorkers
{
  public abstract class FellowWorker
  {
    private int salary;
    private int productivity;
    public int Salary
    {
      get { return salary; }
      set
      {
        if (value <= 0)
        {
          throw new ArgumentException();
        }
        salary = value;
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

    protected FellowWorker(int salary, int productivity)
    {
      Salary = salary;
      Productivity = productivity;
    }

    public abstract Qualifications GetQualification();

    public abstract string GetQualificationString();
  }
}
