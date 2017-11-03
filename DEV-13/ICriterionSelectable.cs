using System.Collections.Generic;
using StaffSelection.Fellow_Workers;

namespace StaffSelection
{
  public interface ICriterionSelectable
  {
    List<FellowWorker> Select(double currentSum, int productivity);
  }
}
