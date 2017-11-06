using StaffSelection.FellowWorkers;

namespace StaffSelection.FellowWorkersBuilders
{
  class SeniorBuilder : FellowWorkerBuilder
  {
    public SeniorBuilder(FellowWorkerBuilder successor)
    {
      this.successor = successor;
    }

    public override FellowWorker Build(int salary, int productivity)
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
