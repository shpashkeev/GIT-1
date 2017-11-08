using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StaffSelection.Tests.FellowWorkers.Tests
{
  [TestClass]
  public class SeniorTests
  {
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Create_SeniorWithNegativeAndNullValues_ArgumentException()
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
    public void Set_SeniorNegativeAndNullSalary_ArgumentException()
    {
      // arrange
      // act
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Set_SeniorNegativeAndNullProductivity_ArgumentException()
    {
      // arrange
      // act
    }
  }
}
