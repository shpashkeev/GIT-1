using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StaffSelection.Tests.FellowWorkers.Tests
{
  [TestClass]
  public class JuniorTests
  {
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Create_JuniorWithNegativeAndNullValues_ArgumentException()
    {
      // arrange
      // act

    }

    [TestMethod]
    public void Create_JuniorWithValidParams_IsJunior()
    {
      // arrange
      // act
      // assert
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Set_JuniorNegativeAndNullSalary_ArgumentException()
    {
      // arrange
      // act
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Set_JuniorNegativeAndNullProductivity_ArgumentException()
    {
      // arrange
      // act
    }
  }
}
