using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.Interfaces;
using Demo.Classes;
using Xunit;
using Moq;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace DemoTests
{
    [TestClass]
    public class CalCulateVowelsTests
    {
        
        CountVowels cntVowels = new CountVowels();
        [Theory]
        [InlineData("PrathimaGowda",5)]
        [InlineData("DirectFerry", 3)]
        [InlineData("Toby", 1)]
        [InlineData("", 0)]
        public void ShouldCalucateVowelsForGivenFullName(String Fullname,int expecetdCnt)
        {
            //Arrange Data

            //Act
            var result = cntVowels.CalCulateVowels(Fullname);
            //Assert 
            //Assert
            Assert.AreEqual(expecetdCnt, result);
        }
    }
}
