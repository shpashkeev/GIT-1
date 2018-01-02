using StaffSelection.FellowWorkers;

namespace StaffSelection
{
  public struct Staffs
  {
    private FellowWorker[] staffsArray;

    public Junior Junior { get; set; }
    public Middle Middle { get; set; }
    public Senior Senior { get; set; }
    public Lead Lead { get; set; }

    public FellowWorker[] StaffsArray
    {
      get { return staffsArray; }
      private set { staffsArray = value; }
    }

    public Staffs(Junior junior, Middle middle, Senior senior, Lead lead)
    {
      this.Junior = junior;
      this.Middle = middle;
      this.Senior = senior;
      this.Lead = lead;
      this.staffsArray = new FellowWorker[] { junior, middle, senior, lead };
    }
  }
}
