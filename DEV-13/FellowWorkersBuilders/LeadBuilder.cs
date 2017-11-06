using StaffSelection.FellowWorkers;

namespace StaffSelection.FellowWorkersBuilders
{
  class LeadBuilder : FellowWorkerBuilder
  {
    public LeadBuilder(FellowWorkerBuilder successor)
    {
      this.Successor = successor;
    }

    public override FellowWorker Build(int salary, int productivity)
    {
      try
      {
        return new Lead(salary, productivity);
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
