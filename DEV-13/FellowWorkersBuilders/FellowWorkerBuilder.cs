using StaffSelection.FellowWorkers;

namespace StaffSelection.FellowWorkersBuilders
{
  abstract class FellowWorkerBuilder
  {
    protected FellowWorkerBuilder Successor;

    public abstract FellowWorker Build(int salary, int productivity);
  }
}
