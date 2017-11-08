using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StaffSelection.Tests
{
  [TestClass]
  public class StaffSelectorTests
  {
    public TestContext TestContext { get; set; }

    private const string connectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\DataSources\\DataForStaffSelector.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";
    private const string Amount = "Amount";
    private const string Productivity = "Productivity";

    [TestMethod]
    [DataSource(connectionStr,"InValid$")]
    [ExpectedException(typeof(ArgumentException))]
    public void Create_SelectorWithInvalidParams_ArgumentException()
    {
      // arrange
      int[] data = ReadData();
      // act
      var res = new StaffSelector(data[0],data[1]);
    }

    [TestMethod]
    [DataSource(connectionStr, "Valid$")]
    public void Create_SelectorWithValidParams_IsStaffSelector()
    {
      // arrange
      int[] data = ReadData();
      // act
      var res = new StaffSelector(data[0],data[1]);
      // assert
      Assert.IsInstanceOfType(res,typeof(StaffSelector));
    }

    private int[] ReadData()
    {
      int amount = Convert.ToInt32(TestContext.DataRow[Amount]);
      int productivity = Convert.ToInt32(TestContext.DataRow[Productivity]);

      return new int[] { amount, productivity };
    }
  }
}
