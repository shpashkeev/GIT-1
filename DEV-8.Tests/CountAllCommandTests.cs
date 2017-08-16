using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductsStorage.Commands;

namespace ProductsStorage.Tests
{
  [TestClass]
  public class CountAllCommandTests
  {
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Execute_CommandWithEmptyProductsList_ArgumentNullException()
    {
      // arrange
      var countAllCommand = new CountAllCommand();
      // act
      countAllCommand.execute(new List<Product>());
      // assert
    }
  }
}
