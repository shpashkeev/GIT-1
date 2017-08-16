using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductsStorage.Commands;

namespace ProductsStorage.Tests
{
  [TestClass]
  public class AveragePriceCommandTests
  {
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Execute_CommandWithEmptyProductsList_ArgumentNullException()
    {
      // arrange
      var averagePriceCommand = new AveragePriceCommand();
      // act
      averagePriceCommand.execute(new List<Product>());
      // assert
      
    }
  }
}
