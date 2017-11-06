using StaffSelection.FellowWorkers;

namespace StaffSelection.FellowWorkersBuilders
{
  class JuniorBuilder : FellowWorkerBuilder
  {
    public JuniorBuilder(FellowWorkerBuilder successor)
    {
      this.successor = successor;
    }

    public override FellowWorker Build(double salary, int productivity)
    {
      try
      {
        return new Junior(salary, productivity);
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
