using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypeOfTriangle.Tests
{
  [TestClass]
  public class EquilateralTriangleTests
  {
    public TestContext TestContext { get; set; }

    private const string connectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\DataSources\\DataForEquilateralTriangle.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";
    private const string SideA = "SideA";
    private const string SideB = "SideB";
    private const string SideC = "SideC";

    [TestMethod]
    [DataSource(connectionStr, "Valid$")]
    public void Create_EquilateralTriangleForValidData_IsEquilateralTriangle()
    {
      // arrange
      var sides = ReadTriangleSidesFromTestContext();

      // act
      var res = new EquilateralTriangle(sides);

      // assert
      Assert.IsInstanceOfType(res, typeof(EquilateralTriangle));
    }

    [TestMethod]
    [DataSource(connectionStr, "Invalid$")]
    [ExpectedException(typeof(TriangleBuildException))]
    public void Create_EquilateralTriangleForInvalidData_TriangleBuildException()
    {
      // arrange
      var sides = ReadTriangleSidesFromTestContext();

      // act
      var res = new EquilateralTriangle(sides);

      // assert
    }

    [TestMethod]
    [DataSource(connectionStr, "WrongFormat$")]
    [ExpectedException(typeof(FormatException))]
    public void Create_EquilateralTriangleForInvalidData_FormatException()
    {
      // arrange
      var sides = ReadTriangleSidesFromTestContext();

      // act
      var res = new EquilateralTriangle(sides);

      // assert
    }

    [TestMethod]
    [DataSource(connectionStr, "WrongType$")]
    [ExpectedException(typeof(TriangleTypeException))]
    public void Create_EquilateralTriangleForInvalidData_TriangleTypeException()
    {
      // arrange
      var sides = ReadTriangleSidesFromTestContext();

      // act
      var res = new EquilateralTriangle(sides);

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
