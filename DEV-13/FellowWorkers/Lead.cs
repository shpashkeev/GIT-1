
namespace StaffSelection.FellowWorkers
{
  public class Lead : FellowWorker
  {
    public Lead(double salary, int productivity) : base(salary, productivity) { }

    public override Qualifications GetQualification()
    {
      return Qualifications.Lead;
    }

    public override string GetQualificationString()
    {
      return GetQualification().ToString();
    }
  }
}
