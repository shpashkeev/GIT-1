using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypeOfTriangle.Tests
{
  [TestClass]
  public class UsualTriangleBuilderTests
  {
    public TestContext TestContext { get; set; }
    private const string SideA = "SideA";
    private const string SideB = "SideB";
    private const string SideC = "SideC";

    private const string connectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\DataSources\\DataForUsualTriangle.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";

    [TestMethod]
    [DataSource(connectionStr, "Valid$")]
    public void Build_UsualTriangleForValidData_IsUsualTriangle()
    {
      // arrange
      var sides = ReadTriangleSidesFromTestContext();

      // act
      var res = new UsualTriangleBuilder(null).Build(sides);

      // assert
      Assert.IsInstanceOfType(res, typeof(UsualTriangle));
    }

    [TestMethod]
    [DataSource(connectionStr, "Invalid$")]
    [ExpectedException(typeof(TriangleBuildException))]
    public void Build_IsoscelesTriangleForInvalidData_TriangleBuildException()
    {
      // arrange
      var sides = ReadTriangleSidesFromTestContext();

      // act
      var res = new UsualTriangleBuilder(null).Build(sides);

      // assert
    }

    [TestMethod]
    [DataSource(connectionStr, "WrongFormat$")]
    [ExpectedException(typeof(FormatException))]
    public void Build_IsoscelesTriangleForInvalidData_FormatException()
    {
      // arrange
      var sides = ReadTriangleSidesFromTestContext();

      // act
      var res = new UsualTriangleBuilder(null).Build(sides);

      // assert
    }

    [TestMethod]
    [DataSource(connectionStr, "WrongType$")]
    [ExpectedException(typeof(TriangleTypeException))]
    public void Build_IsoscelesTriangleForInvalidData_TriangleTypeException()
    {
      // arrange
      var sides = ReadTriangleSidesFromTestContext();

      // act
      var res = new UsualTriangleBuilder(null).Build(sides);

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
