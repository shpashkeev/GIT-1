using StaffSelection.FellowWorkers;

namespace StaffSelection.FellowWorkersBuilders
{
  class MiddleBuilder : FellowWorkerBuilder
  {
    public MiddleBuilder(FellowWorkerBuilder successor)
    {
      this.successor = successor;
    }
    public override FellowWorker Build(int salary, int productivity)
    {
      try
      {
        return new Middle(salary, productivity);
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
