using StaffSelection.FellowWorkers;

namespace StaffSelection.FellowWorkersBuilders
{
  class JuniorBuilder : FellowWorkerBuilder
  {
    public JuniorBuilder(FellowWorkerBuilder successor)
    {
      this.Successor = successor;
    }

    public override FellowWorker Build(int salary, int productivity)
    {
      try
      {
        return new Junior(salary, productivity);
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
