﻿using StaffSelection.Fellow_Workers;

namespace StaffSelection.Fellow_Workers_Builders
{
  class LeadBuilder : FellowWorkerBuilder
  {
    public LeadBuilder(FellowWorkerBuilder successor)
    {
      this.successor = successor;
    }

    public override FellowWorker Build(double salary, int productivity)
    {
      try
      {
        return new Lead(salary, productivity);
      }
      catch (FellowWorkerException)
      {
        if (successor != null)
        {
          return successor.Build(salary, productivity);
        }
        throw new FellowWorkerException();
      }
    }
  }
}