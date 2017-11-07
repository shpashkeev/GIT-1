using System;
using System.Text;
using Microsoft.SolverFoundation.Services;
using StaffSelection.FellowWorkers;

namespace StaffSelection.Criterions
{
  /// <summary>
  /// Criterion
  /// 3/ Minimum number of employees is higher than Junior for fixed productivity.
  /// </summary>
  public class MinCountOfElderWorkersCriterion : ICriterionSelectable
  {
    /// <summary>
    /// The problem of integer programming:
    /// Selection employees necessary to minimize number of employees is higher than Junior
    /// for given parameters of the cash amount and fixed productivity.
    /// </summary>
    /// <param name="selector">Contains cash amount and productivity</param>
    public void Select(StaffSelector selector)
    {
      SolverContext context = SolverContext.GetContext();
      Model model = context.CreateModel();

      // init fellow workers
      Junior junior = selector.Staffs.Junior;
      Middle middle = selector.Staffs.Middle;
      Senior senior = selector.Staffs.Senior;
      Lead lead = selector.Staffs.Lead;

      // init decisions - counts of number of employees of different qualifications
      Decision juniorDecision = new Decision(Domain.IntegerNonnegative, junior.GetQualificationString());
      Decision middleDecision = new Decision(Domain.IntegerNonnegative, middle.GetQualificationString());
      Decision seniorDecision = new Decision(Domain.IntegerNonnegative, senior.GetQualificationString());
      Decision leadDecision = new Decision(Domain.IntegerNonnegative, lead.GetQualificationString());
      model.AddDecisions(juniorDecision, middleDecision, seniorDecision, leadDecision);

      // constraint of fixed productivity
      model.AddConstraints("fixProductivity",
       junior.Productivity * juniorDecision +
       middle.Productivity * middleDecision +
       senior.Productivity * seniorDecision +
       lead.Productivity * leadDecision == selector.Productivity);

      // constraint of max cash amount
      model.AddConstraints("maxAmount",
        junior.Salary * juniorDecision +
        middle.Salary * middleDecision +
        senior.Salary * seniorDecision +
        lead.Salary * leadDecision <= selector.Amount);

      // criterion of optimization - minimize elder workers
      model.AddGoal("count", GoalKind.Minimize,
        middleDecision + seniorDecision + leadDecision);

      Solution solution = context.Solve(new ConstraintProgrammingDirective());

      // print results
      int numberOfSolution = 0;
      while (solution.Quality != SolverQuality.Infeasible)
      {
        StringBuilder sb = new StringBuilder($"Solution #{++numberOfSolution}\n");
        sb.Append($"{junior.GetQualificationString()}: {juniorDecision} ")
          .Append($"{middle.GetQualificationString()}: {middleDecision} ")
          .Append($"{senior.GetQualificationString()}: {seniorDecision} ")
          .Append($"{lead.GetQualificationString()}: {leadDecision} ");
        foreach (var goal in solution.Goals)
        {
          sb.Append($"\n{goal.Name}: {goal}");
        }

        Console.WriteLine(sb);
        solution.GetNext();
      }
      context.ClearModel();
    }
  }
}
