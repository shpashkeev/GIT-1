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
    [ExpectedException(typeof(FellowWorkerException))]
    public void Create_MiddleWithInvalidParams_FellowWorkerException()
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

    [TestMethod]
    [ExpectedException(typeof(FellowWorkerException))]
    public void Set_MiddleInvalidSalary_FellowWorkerException()
    {
      // arrange
      // act
    }

    [TestMethod]
    [ExpectedException(typeof(FellowWorkerException))]
    public void Set_MiddleInvalidProductivity_FellowWorkerException()
    {
      // arrange
      // act
    }
  }
}
