using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StaffSelection.Tests.FellowWorkers.Tests
{
  [TestClass]
  public class MiddleTests
  {
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Create_MiddleWithNegativeAndNullValues_ArgumentException()
    {
      // arrange
      // act
    }

    [TestMethod]
    public void Create_MiddleWithValidParams_IsMiddle()
    {
      // arrange
      // act
      // assert
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Set_MiddleNegativeAndNullSalary_ArgumentException()
    {
      // arrange
      // act
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Set_MiddleNegativeAndNullProductivity_ArgumentException()
    {
      // arrange
      // act
    }
  }
}
