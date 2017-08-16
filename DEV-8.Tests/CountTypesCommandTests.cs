using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductsStorage.Commands;

namespace ProductsStorage.Tests
{
  [TestClass]
  public class CountTypesCommandTests
  {
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Execute_CommandWithEmptyProductsList_ArgumentNullException()
    {
      // arrange
      var countTypesCommand = new CountTypesCommand();
      // act
      countTypesCommand.execute(new List<Product>());
      // assert
    }
  }
}
