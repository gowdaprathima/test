using System;
using System.Collections.Generic;
using System.Text;
using Demo.Interfaces;
using Demo.Classes;
using Xunit;
using Moq;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoTests
{
    [TestClass]
    public class CalculateAgeTests
    {

        CalculateAge CalAge = new CalculateAge();
        [Theory]
        [InlineData("1983/01/16", 38,55)]
        [InlineData("2018/10/01", 3,313)]
        [InlineData("2021/11/21", 0,364)]

        public void ShouldCalucateAgeandDaysForGivenDOB(DateTime DOB, int expecetedAge ,int expectedDays)
        {
            //Arrange Data
            CalAge.age = expecetedAge;
            CalAge.days = expectedDays;
            //Act
            var result = CalAge.Calcualteage(DOB);           
            //Assert
            Assert.AreEqual(CalAge.age, result.age);
            Assert.AreEqual(CalAge.days, result.days);
        }

    }
}
