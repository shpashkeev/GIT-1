using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StaffSelection.FellowWorkers;

namespace StaffSelection.Tests.FellowWorkers.Tests
{
  [TestClass]
  public class JuniorTests
  {
    public TestContext TestContext { get; set; }

    private const string connectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\DataSources\\DataForFellowWorkers.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";
    private const string Salary = "Salary";
    private const string Productivity = "Productivity";

    [TestMethod]
    [DataSource(connectionStr, "InValid$")]
    [ExpectedException(typeof(ArgumentException))]
    public void Create_JuniorWithInvalidValues_ArgumentException()
    {
      // arrange
      int[] data = ReadData();
      // act
      var res = new Junior(data[0], data[1]);
    }

    [TestMethod]
    [DataSource(connectionStr, "Valid$")]
    public void Create_JuniorWithValidValues_IsJunior()
    {
      // arrange
      int[] data = ReadData();
      // act
      var res = new Junior(data[0], data[1]);
      // assert
      Assert.IsInstanceOfType(res, typeof(Junior));
    }

    [TestMethod]
    [DataSource(connectionStr, "InValid$")]
    [ExpectedException(typeof(ArgumentException))]
    public void Set_JuniorInvalidSalary_ArgumentException()
    {
      // arrange
      Junior res = new Junior(10, 10);
      // act
      res.Salary = Convert.ToInt32(TestContext.DataRow[Salary]);
    }

    [TestMethod]
    [DataSource(connectionStr, "InValid$")]
    [ExpectedException(typeof(ArgumentException))]
    public void Set_JuniorInvalidProductivity_ArgumentException()
    {
      // arrange
      Junior res = new Junior(10, 10);
      // act
      res.Salary = Convert.ToInt32(TestContext.DataRow[Productivity]);
    }

    private int[] ReadData()
    {
      int salary = Convert.ToInt32(TestContext.DataRow[Salary]);
      int productivity = Convert.ToInt32(TestContext.DataRow[Productivity]);

      return new int[] { salary, productivity };
    }
  }
}
