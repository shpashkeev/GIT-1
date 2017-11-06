
namespace StaffSelection.FellowWorkers
{
  public class Senior : FellowWorker
  {
    public Senior(int salary, int productivity) : base(salary, productivity) { }

    public override Qualifications GetQualification()
    {
      return Qualifications.Senior;
    }

    public override string GetQualificationString()
    {
      return GetQualification().ToString();
    }
  }
}
