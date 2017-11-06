using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SolverFoundation.Services;
using StaffSelection.Fellow_Workers;

namespace StaffSelection.Criterions
{
  public class MinAmountCriterion : ICriterionSelectable
  {
    public void Select(double amount, int productivity)
    {
      SolverContext context = SolverContext.GetContext();
      Model model = context.CreateModel();

      // init fellow workers
      Junior junior = new Junior(150, 100);
      Middle middle = new Middle(200, 150);
      Senior senior = new Senior(400, 200);
      Lead lead = new Lead(1000, 500);

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

      model.AddConstraints("maxProductivity",
       junior.Salary * juniorDecision +
       middle.Salary * middleDecision +
       senior.Salary * seniorDecision +
       lead.Salary * leadDecision <= productivity);

      model.AddConstraints("maxAmount",
        junior.Salary * juniorDecision +
        middle.Salary * middleDecision +
        senior.Salary * seniorDecision +
        lead.Salary * leadDecision <= amount);

      model.AddGoal("cost", GoalKind.Minimize,
        junior.Salary * juniorDecision +
        middle.Salary * middleDecision +
        senior.Salary * seniorDecision +
        lead.Salary * leadDecision);

      Solution solution = context.Solve(new ConstraintProgrammingDirective());
      while (solution.Quality != SolverQuality.Infeasible)
      {
        StringBuilder sb = new StringBuilder("Solution");
        sb.AppendLine($"{junior.GetQualificationString()}: {juniorDecision} ")
          .Append($"{middle.GetQualificationString()}: {middleDecision} ")
          .Append($"{senior.GetQualificationString()}: {seniorDecision} ")
          .Append($"{lead.GetQualificationString()}: {leadDecision} ");
        foreach (var goal in solution.Goals)
        {
          sb.AppendLine($"{goal.Name}: {goal}");
        }

        Console.WriteLine(sb);
        solution.GetNext();
      }
    }
  }
}
