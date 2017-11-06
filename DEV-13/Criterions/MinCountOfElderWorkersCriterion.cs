using System;
using System.Text;
using Microsoft.SolverFoundation.Services;
using StaffSelection.FellowWorkers;

namespace StaffSelection.Criterions
{
  public class MinCountOfElderWorkersCriterion : ICriterionSelectable
  {
    public void Select(StaffSelector selector)
    {
      SolverContext context = SolverContext.GetContext();
      Model model = context.CreateModel();

      // init fellow workers
      Junior junior = selector.Staffs.Junior;
      Middle middle = selector.Staffs.Middle;
      Senior senior = selector.Staffs.Senior;
      Lead lead = selector.Staffs.Lead;

      Decision juniorDecision = new Decision(Domain.IntegerNonnegative, junior.GetQualificationString());
      Decision middleDecision = new Decision(Domain.IntegerNonnegative, middle.GetQualificationString());
      Decision seniorDecision = new Decision(Domain.IntegerNonnegative, senior.GetQualificationString());
      Decision leadDecision = new Decision(Domain.IntegerNonnegative, lead.GetQualificationString());
      model.AddDecisions(juniorDecision, middleDecision, seniorDecision, leadDecision);

      model.AddConstraints("limits",
        0 <= juniorDecision,
        0 <= middleDecision,
        0 <= seniorDecision,
        0 <= leadDecision);

      model.AddConstraints("fixProductivity",
       junior.Productivity * juniorDecision +
       middle.Productivity * middleDecision +
       senior.Productivity * seniorDecision +
       lead.Productivity * leadDecision == selector.Productivity);

      model.AddConstraints("maxAmount",
        junior.Salary * juniorDecision +
        middle.Salary * middleDecision +
        senior.Salary * seniorDecision +
        lead.Salary * leadDecision <= selector.Amount);

      model.AddGoal("count", GoalKind.Minimize,
        middleDecision + seniorDecision + leadDecision);

      Solution solution = context.Solve(new ConstraintProgrammingDirective());
      while (solution.Quality != SolverQuality.Infeasible)
      {
        StringBuilder sb = new StringBuilder("Solution\n");
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
