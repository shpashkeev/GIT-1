using System.Collections.Generic;
using Microsoft.SolverFoundation.Services;
using StaffSelection.FellowWorkers;

namespace StaffSelection
{
  /// <summary>
  /// Abstract class helps
  /// to implement the pattern Strategy
  /// </summary>
  public abstract class ByCriterionSelector
  {
    /// <summary>
    /// Each select method requires an override
    /// according to its criterion
    /// </summary>
    /// <param name="selector">Contains cash amount and productivity</param>
    /// <returns>Possible solutions for the composition of the team of employees</returns>
    public abstract List<Dictionary<FellowWorker, int>> Select(StaffSelector selector);

    /// <summary>
    /// Method helps to organize solution into the team of employees
    /// like "Staff" - "Count"
    /// </summary>
    /// <param name="decisions">required solution of the optimization problem</param>
    /// <param name="staffs">current staffs in company</param>
    /// <returns></returns>
    protected Dictionary<FellowWorker, int> PackSolutionInDictionary(Decision[] decisions, Staffs staffs)
    {
      Dictionary<FellowWorker, int> result = new Dictionary<FellowWorker, int>();
      int i = 0;
      foreach (var decision in decisions)
      {
        result.Add(staffs.StaffsArray[i++],(int)decision.GetDouble());
      }
      return result;
    }
  }
}
