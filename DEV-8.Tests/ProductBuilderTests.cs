using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductsStorage;

namespace ProductsStorage.Tests
{
  [TestClass]
  public class ProductBuilderTests
  {
    public TestContext TestContext { get; set; }
    private const string TYPE = "type";
    private const string NAME = "name";
    private const int COUNT = 1;
    private const double PRICE = 1.0;

    private const string connectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";

    [TestMethod]
    [DataSource(connectionStr,"PositiveCounts")]
    public void Build_ProductWithValidCountParameter_IsProduct()
    {
      // arrange
      int count = Convert.ToInt32(TestContext.DataRow["Count"]);
      // act
      var res = new ProductBuilder().Build(TYPE, NAME, count, PRICE);
      // assert
      Assert.IsInstanceOfType(res,typeof(Product));
    }

    [TestMethod]
    [DataSource(connectionStr, "PositivePrices")]
    public void Build_ProductWithValidPriceParameter_IsProduct()
    {
      // arrange
      double price = Convert.ToDouble(TestContext.DataRow["Price"]);
      // act
      var res = new ProductBuilder().Build(TYPE, NAME, COUNT, price);
      // assert
      Assert.IsInstanceOfType(res, typeof(Product));
    }
  }
}
