
namespace StaffSelection.Fellow_Workers
{
  public class Senior : FellowWorker
  {
    public Senior(double salary, int productivity) : base(salary, productivity) { }

    public override Qualifications GetQualification()
    {
      return Qualifications.Senior;
    }

    public override string GetQualificationString()
    {
      return Iam + GetQualification();
    }
  }
}
