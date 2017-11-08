using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StaffSelection.Tests.FellowWorkers.Tests
{
  [TestClass]
  public class LeadTests
  {
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Create_LeadWithNegativeAndNullValues_ArgumentException()
    {
      // arrange
      // act

    }

    [TestMethod]
    [ExpectedException(typeof(FellowWorkerException))]
    public void Create_LeadWithInvalidParams_FellowWorkerException()
    {
      // arrange
      // act
    }

    [TestMethod]
    public void Create_LeadWithValidParams_IsLead()
    {
      // arrange
      // act
      // assert
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Set_LeadNegativeAndNullSalary_ArgumentException()
    {
      // arrange
      // act
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Set_LeadNegativeAndNullProductivity_ArgumentException()
    {
      // arrange
      // act
    }

    [TestMethod]
    [ExpectedException(typeof(FellowWorkerException))]
    public void Set_LeadInvalidSalary_FellowWorkerException()
    {
      // arrange
      // act
    }

    [TestMethod]
    [ExpectedException(typeof(FellowWorkerException))]
    public void Set_LeadInvalidProductivity_FellowWorkerException()
    {
      // arrange
      // act
    }
  }
}
