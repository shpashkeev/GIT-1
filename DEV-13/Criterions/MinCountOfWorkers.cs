using System;
using System.Text;
using Microsoft.SolverFoundation.Services;
using StaffSelection.Fellow_Workers;

namespace StaffSelection.Criterions
{
  public class MinCountOfWorkers : ICriterionSelectable
  {
    public void Select(StaffSelector selector)
    {
      SolverContext context = SolverContext.GetContext();
      Model model = context.CreateModel();

      // init fellow workers
      Middle middle = selector.Staffs.Middle;
      Senior senior = selector.Staffs.Senior;
      Lead lead = selector.Staffs.Lead;

      Decision middleDecision = new Decision(Domain.IntegerNonnegative, middle.GetQualificationString());
      Decision seniorDecision = new Decision(Domain.IntegerNonnegative, senior.GetQualificationString());
      Decision leadDecision = new Decision(Domain.IntegerNonnegative, lead.GetQualificationString());
      model.AddDecisions(middleDecision, seniorDecision, leadDecision);

      model.AddConstraints("limits",
        0 <= middleDecision,
        0 <= seniorDecision,
        0 <= leadDecision);

      model.AddConstraints("fixProductivity",
       middle.Productivity * middleDecision +
       senior.Productivity * seniorDecision +
       lead.Productivity * leadDecision == selector.Productivity);

      model.AddConstraints("maxAmount",
        middle.Salary * middleDecision +
        senior.Salary * seniorDecision +
        lead.Salary * leadDecision <= selector.Amount);

      model.AddGoal("count", GoalKind.Minimize,
        middleDecision + seniorDecision + leadDecision);

      Solution solution = context.Solve(new ConstraintProgrammingDirective());
      while (solution.Quality != SolverQuality.Infeasible)
      {
        StringBuilder sb = new StringBuilder("Solution\n");
        sb.Append($"{middle.GetQualificationString()}: {middleDecision} ")
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
