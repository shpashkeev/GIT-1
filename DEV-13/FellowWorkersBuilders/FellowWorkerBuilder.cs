using StaffSelection.FellowWorkers;

namespace StaffSelection.FellowWorkersBuilders
{
  abstract class FellowWorkerBuilder
  {
    protected FellowWorkerBuilder successor;

    public abstract FellowWorker Build(double salary, int productivity);
  }
}
