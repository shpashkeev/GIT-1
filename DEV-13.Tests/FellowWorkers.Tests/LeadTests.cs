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
  }
}
