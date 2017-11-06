using StaffSelection.FellowWorkers;

namespace StaffSelection.FellowWorkersBuilders
{
  class MiddleBuilder : FellowWorkerBuilder
  {
    public MiddleBuilder(FellowWorkerBuilder successor)
    {
      this.Successor = successor;
    }
    public override FellowWorker Build(int salary, int productivity)
    {
      try
      {
        return new Middle(salary, productivity);
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
