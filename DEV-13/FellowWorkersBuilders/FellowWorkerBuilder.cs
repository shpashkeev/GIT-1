using StaffSelection.Fellow_Workers;

namespace StaffSelection.Fellow_Workers_Builders
{
  abstract class FellowWorkerBuilder
  {
    protected FellowWorkerBuilder successor;

    public abstract FellowWorker Build(double salary, int productivity);
  }
}
