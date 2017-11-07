using StaffSelection.FellowWorkers;

namespace StaffSelection
{
  public struct Staffs
  {
    public Junior Junior { get; set; }
    public Middle Middle { get; set; }
    public Senior Senior { get; set; }
    public Lead Lead { get; set; }

    public Staffs(Junior junior, Middle middle, Senior senior, Lead lead)
    {
      this.Junior = junior;
      this.Middle = middle;
      this.Senior = senior;
      this.Lead = lead;
    }
  }
}
