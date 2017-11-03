using System;

namespace StaffSelection
{
  public class FellowWorkerException : Exception
  {
    private const string IncorrectedQualification = "Incorrect qualification";

    public FellowWorkerException() : base(IncorrectedQualification) { }
  }
}
