using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeOfTriangle;

namespace TypeOfTriangle.Tests
{
  [TestClass]
  public class EquilateralTriangleTests
  {
    public TestContext TestContext { get; set; }

    private const string connectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\DataSources\\DataForEquilateralTriangle.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";

    [TestMethod]
    [DataSource(connectionStr, "Valid$")]
    public void Create_EquilateralTriangleForValidData_IsEquilateralTriangle()
    {
      // arrange
      double sideA = Convert.ToDouble(TestContext.DataRow["SideA"]);
      double sideB = Convert.ToDouble(TestContext.DataRow["SideB"]);
      double sideC = Convert.ToDouble(TestContext.DataRow["SideC"]);

      double[] sides = { sideA, sideB, sideC };

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
      double sideA = Convert.ToDouble(TestContext.DataRow["SideA"]);
      double sideB = Convert.ToDouble(TestContext.DataRow["SideB"]);
      double sideC = Convert.ToDouble(TestContext.DataRow["SideC"]);

      double[] sides = { sideA, sideB, sideC };

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
      double sideA = Convert.ToDouble(TestContext.DataRow["SideA"]);
      double sideB = Convert.ToDouble(TestContext.DataRow["SideB"]);
      double sideC = Convert.ToDouble(TestContext.DataRow["SideC"]);

      double[] sides = { sideA, sideB, sideC };

      // act
      var res = new EquilateralTriangle(sides);

      // assert
    }
  }
}
