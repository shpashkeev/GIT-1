using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProductsStorage.Tests
{
  [TestClass]
  public class ProductTests
  {
    private const string TYPE = "type";
    private const string NAME = "name";
    private const int COUNT = 1;
    private const double PRICE = 1.0;

    public TestContext TestContext { get; set; }
    private const string connectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\DataSources\\ProductTestsData.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";

    [TestMethod]
    [DataSource(connectionStr, "Counts$")]
    [ExpectedException(typeof(ArgumentException))]
    public void Build_ProductWithInvalidCountParameter_Exception()
    {
      // arrange
      int count = Convert.ToInt32(TestContext.DataRow["Negative Count"]);
      // act
      var res = new Product(TYPE, NAME, count, PRICE);
      // assert
    }

    [TestMethod]
    [DataSource(connectionStr, "Prices$")]
    public void Build_ProductWithValidPriceParameter_IsProduct()
    {
      // arrange
      double price = Convert.ToDouble(TestContext.DataRow["Positive Price"]);
      // act
      var res = new Product(TYPE, NAME, COUNT, price);
      // assert
      Assert.IsInstanceOfType(res, typeof(Product));
    }

    [TestMethod]
    [DataSource(connectionStr, "Prices$")]
    [ExpectedException(typeof(ArgumentException))]
    public void Build_ProductWithInvalidPriceParameter_IsProduct()
    {
      // arrange
      double price = Convert.ToDouble(TestContext.DataRow["Negative Price"]);
      // act
      var res = new Product(TYPE, NAME, COUNT, price);
      // assert
    }
  }
}
