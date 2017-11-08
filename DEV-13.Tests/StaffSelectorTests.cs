using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StaffSelection.Tests
{
  [TestClass]
  public class StaffSelectorTests
  {
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void InitSelector_FromInvalidParams_ArgumentException()
    {
      // arrange

      // act
    }

    [TestMethod]
    public void InitSelector_FromValidParams_IsStaffSelector()
    {
      // arrange
      // act
      // assert
    }
  }
}
