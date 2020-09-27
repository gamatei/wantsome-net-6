﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTesting.Implementation;

namespace Implementation.UnitTests
{
    [TestClass]
    public class BirdLanguageConverterTests
    {
        [TestMethod]
        public void When_ConvertAWord_ShouldReturn_ConvertedWord()
        {
            //Arrange

            var word = "vasile";
            var expectedWord = "vapasipilepe";
            var sut = new BirdLanguageConverter();
            //Act

            var actualResult = sut.Convert(word);

            //Assert

            Assert.AreEqual(expectedWord, actualResult);
        }

        [TestMethod]
        public void When_ConvertACapitalWord_ShouldReturn_ConvertedWord()
        {
            //Arrange

            var word = "VASILE";
            var expectedWord = "VApASIpILEpE";
            var sut = new BirdLanguageConverter();
            //Act

            var actualResult = sut.Convert(word);

            //Assert

            Assert.AreEqual(expectedWord, actualResult);
        }

        [TestMethod]
        public void When_ConvertAPhrase_ShouldReturn_ConvertedPhrase()
        {
            //Arrange

            var word = "Ana are mere!";
            var expectedWord = "ApAnapa aparepe meperepe!";
            var sut = new BirdLanguageConverter();
            //Act

            var actualResult = sut.Convert(word);

            //Assert

            Assert.AreEqual(expectedWord, actualResult);
        }
    }
}
