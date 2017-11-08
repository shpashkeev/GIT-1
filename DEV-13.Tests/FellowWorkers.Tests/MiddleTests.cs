using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StaffSelection.Tests.FellowWorkers.Tests
{
  [TestClass]
  public class MiddleTests
  {
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Create_MiddleWithInvalidValues_ArgumentException()
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
    public void Set_MiddleInvalidSalary_ArgumentException()
    {
      // arrange
      // act
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Set_MiddleInvalidProductivity_ArgumentException()
    {
      // arrange
      // act
    }
  }
}
