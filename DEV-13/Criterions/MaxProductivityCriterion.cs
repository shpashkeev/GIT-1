using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaffSelection.Fellow_Workers;

namespace StaffSelection.Criterions
{
  public class MaxProductivityCriterion : ICriterionSelectable

  {
    public List<FellowWorker> Select(double amount, int productivity)
    {
      double currentCost = 0.0;
      int currentProductivity = 0;
      List<FellowWorker> currentFellowWorkers = new List<FellowWorker>();

      return currentFellowWorkers;
    }
  }
}
