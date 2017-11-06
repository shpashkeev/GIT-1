using System.Collections.Generic;
using StaffSelection.Fellow_Workers;

namespace StaffSelection
{
  public interface ICriterionSelectable
  {
    void Select(double amount, int productivity);
  }
}
