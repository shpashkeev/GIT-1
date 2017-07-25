using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TypeOfTriangle.Test
{
  [TestClass]
  public class UsualTriangleBuilderTest
  {
    public TestContext TestContext { get; set; }

    private const string dataDriver = "System.Data.OleDb";
    private const string connectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ValidDataForTriangle.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";

    [TestMethod]
    public void Build_UsualTriangleForValidValuesOfSides_IsUsualTriangle()
    {
    }
  }
}
