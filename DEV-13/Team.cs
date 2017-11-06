﻿using StaffSelection.FellowWorkers;

namespace StaffSelection
{
  public struct Team
  {
    public Junior Junior { get; set; }
    public Middle Middle { get; set; }
    public Senior Senior { get; set; }
    public Lead Lead { get; set; }

    public Team(Junior junior, Middle middle, Senior senior, Lead lead)
    {
      this.Junior = junior;
      this.Middle = middle;
      this.Senior = senior;
      this.Lead = lead;
    }
  }
}
