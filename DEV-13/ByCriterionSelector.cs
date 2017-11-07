using System.Collections.Generic;
using Microsoft.SolverFoundation.Services;

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
    public abstract List<Dictionary<string, int>> Select(StaffSelector selector);

    /// <summary>
    /// Method helps to organize solution into the team of employees
    /// like "Staff" - "Count"
    /// </summary>
    /// <param name="decisions">required solution of the optimization problem</param>
    /// <returns></returns>
    protected Dictionary<string, int> PackSolutionInDictionary(Decision[] decisions)
    {
      Dictionary<string, int> result = new Dictionary<string, int>();

      foreach (var decision in decisions)
      {
        result.Add(decision.Name,(int)decision.GetDouble());
      }

      return result;
    }
  }
}
