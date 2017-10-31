using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypeOfTriangle.Tests
{
  [TestClass]
  public class IsoscelesTriangleTests
  {
    public TestContext TestContext { get; set; }
    private const string SideA = "SideA";
    private const string SideB = "SideB";
    private const string SideC = "SideC";

    private const string connectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\DataSources\\DataForIsoscelesTriangle.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";

    [TestMethod]
    [DataSource(connectionStr, "Valid$")]
    public void Create_IsoscelesTriangleForValidData_IsIsoscelesTriangle()
    {
      // arrange
      var sides = ReadTriangleSidesFromTestContext();

      // act
      var res = new IsoscelesTriangle(sides);

      // assert
      Assert.IsInstanceOfType(res, typeof(IsoscelesTriangle));
    }


    [TestMethod]
    [DataSource(connectionStr, "Invalid$")]
    [ExpectedException(typeof(TriangleBuildException))]
    public void Create_IsoscelesTriangleForInvalidData_TriangleBuildException()
    {
      // arrange
      var sides = ReadTriangleSidesFromTestContext();

      // act
      var res = new IsoscelesTriangle(sides);

      // assert
    }

    [TestMethod]
    [DataSource(connectionStr, "WrongFormat$")]
    [ExpectedException(typeof(FormatException))]
    public void Create_IsoscelesTriangleForInvalidData_FormatException()
    {
      // arrange
      var sides = ReadTriangleSidesFromTestContext();

      // act
      var res = new IsoscelesTriangle(sides);

      // assert
    }

    [TestMethod]
    [DataSource(connectionStr, "WrongType$")]
    [ExpectedException(typeof(TriangleTypeException))]
    public void Create_IsoscelesTriangleForInvalidData_TriangleTypeException()
    {
      // arrange
      var sides = ReadTriangleSidesFromTestContext();

      // act
      var res = new IsoscelesTriangle(sides);

      // assert
    }

    private double[] ReadTriangleSidesFromTestContext()
    {
      double sideA = Convert.ToDouble(TestContext.DataRow[SideA]);
      double sideB = Convert.ToDouble(TestContext.DataRow[SideB]);
      double sideC = Convert.ToDouble(TestContext.DataRow[SideC]);

      double[] sides = { sideA, sideB, sideC };
      return sides;
    }
  }
}
