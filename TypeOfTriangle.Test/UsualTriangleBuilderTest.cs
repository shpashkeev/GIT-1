using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeOfTriangle;

namespace TypeOfTriangle.Test
{
  [TestClass]
  public class UsualTriangleBuilderTest
  {
    public TestContext TestContext { get; set; }

    private const string connectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ValidDataForTriangle.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";

    [TestMethod]
    [DataSource(connectionStr,"Usual$")]
    public void Build_UsualTriangleForValidValuesOfSides_IsUsualTriangle()
    {
      // arrange
      double sideA = Convert.ToDouble(TestContext.DataRow["SideA"]);
      double sideB = Convert.ToDouble(TestContext.DataRow["SideB"]);
      double sideC = Convert.ToDouble(TestContext.DataRow["SideC"]);

      double[] sides = { sideA, sideB, sideC };

      // act
      var res = (new UsualTriangleBuilder(null)).Build(sides);

      // assert
      Assert.IsInstanceOfType(res, typeof(UsualTriangle));
    }
  }
}
