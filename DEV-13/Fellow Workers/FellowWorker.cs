using System;

namespace StaffSelection.Fellow_Workers
{
  public abstract class FellowWorker
  {
    protected const string Iam = "I am ";

    private double salary;

    public double Salary
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
    public int Productivity { get; set; }

    protected FellowWorker(double salary, int productivity)
    {
      Salary = salary;
      Productivity = productivity;
    }

    public abstract Qualifications GetQualification();

    public abstract string GetQualificationString();
  }
}
