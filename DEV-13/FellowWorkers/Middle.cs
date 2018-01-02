
namespace StaffSelection.FellowWorkers
{
  public class Middle : FellowWorker
  {
    public Middle(int salary, int productivity) : base(salary, productivity) { }

    public override Qualifications GetQualification()
    {
      return Qualifications.Middle;
    }

    public override string GetQualificationString()
    {
      return GetQualification().ToString();
    }
  }
}
