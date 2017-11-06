using System;

namespace StaffSelection.Fellow_Workers
{
  public abstract class FellowWorker
  {
    private double salary;
    private int productivity;
    public double Salary
    {
      get { return salary; }
      set
      {
        if (value <= 0.0)
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

    protected FellowWorker(double salary, int productivity)
    {
      Salary = salary;
      Productivity = productivity;
    }

    public abstract Qualifications GetQualification();

    public abstract string GetQualificationString();
  }
}
