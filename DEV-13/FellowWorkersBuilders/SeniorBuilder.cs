using StaffSelection.FellowWorkers;

namespace StaffSelection.FellowWorkersBuilders
{
  class SeniorBuilder : FellowWorkerBuilder
  {
    public SeniorBuilder(FellowWorkerBuilder successor)
    {
      this.Successor = successor;
    }

    public override FellowWorker Build(int salary, int productivity)
    {
      try
      {
        return new Senior(salary, productivity);
      }
      catch (FellowWorkerException)
      {
        if (Successor != null)
        {
          return Successor.Build(salary, productivity);
        }
        throw new FellowWorkerException();
      }
    }
  }
}
