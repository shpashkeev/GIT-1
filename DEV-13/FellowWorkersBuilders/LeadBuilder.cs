using StaffSelection.FellowWorkers;

namespace StaffSelection.FellowWorkersBuilders
{
  class LeadBuilder : FellowWorkerBuilder
  {
    public LeadBuilder(FellowWorkerBuilder successor)
    {
      this.successor = successor;
    }

    public override FellowWorker Build(int salary, int productivity)
    {
      try
      {
        return new Lead(salary, productivity);
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
