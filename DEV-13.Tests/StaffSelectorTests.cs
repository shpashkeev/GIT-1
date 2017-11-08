using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StaffSelection.Tests
{
  [TestClass]
  public class StaffSelectorTests
  {
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Create_SelectorWithInvalidParams_ArgumentException()
    {
      // arrange

      // act
    }

    [TestMethod]
    public void Create_SelectorWithValidParams_IsStaffSelector()
    {
      // arrange
      // act
      // assert
    }
  }
}
