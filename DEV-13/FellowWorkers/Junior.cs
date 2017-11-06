
namespace StaffSelection.FellowWorkers
{
  public class Junior : FellowWorker
  {
    public Junior(double salary, int productivity): base(salary, productivity) { }

    public override Qualifications GetQualification()
    {
      return Qualifications.Junior;
    }

    public override string GetQualificationString()
    {
      return GetQualification().ToString();
    }
  }
}
