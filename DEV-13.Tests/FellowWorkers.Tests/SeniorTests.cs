using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StaffSelection.Tests.FellowWorkers.Tests
{
  [TestClass]
  public class SeniorTests
  {
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Create_SeniorWithInvalidValues_ArgumentException()
    {
      // arrange
      // act

    }

    [TestMethod]
    [ExpectedException(typeof(FellowWorkerException))]
    public void Create_SeniorWithInvalidParams_FellowWorkerException()
    {
      // arrange
      // act
    }

    [TestMethod]
    public void Create_SeniorWithValidParams_IsSenior()
    {
      // arrange
      // act
      // assert
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Set_SeniorInvalidSalary_ArgumentException()
    {
      // arrange
      // act
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Set_SeniorInvalidProductivity_ArgumentException()
    {
      // arrange
      // act
    }
  }
}
