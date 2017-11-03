using StaffSelection.Fellow_Workers;

namespace StaffSelection.Fellow_Workers_Builders
{
  class SeniorBuilder : FellowWorkerBuilder
  {
    public SeniorBuilder(FellowWorkerBuilder successor)
    {
      this.successor = successor;
    }

    public override FellowWorker Build(double salary, int productivity)
    {
      try
      {
        return new Senior(salary, productivity);
      }
      catch (FellowWorkerException)
      {
        if (successor != null)
        {
          return successor.Build(salary, productivity);
        }
        throw new FellowWorkerException();
      }
    }
  }
}
