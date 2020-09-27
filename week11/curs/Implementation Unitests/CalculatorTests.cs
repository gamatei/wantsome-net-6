using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Implementation;

namespace ImplementationUnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void When_DivideSixToThree_ShouldReturnTwo()
        {
            //Arrange
            var sut = new Calculator();
            var operantOne = 6;
            var operandTwo = 3;
            var expectedResult = 2;
            //Act
            var result = sut.Divide(operantOne, operandTwo);

            //Assert

            Assert.AreEqual(expectedResult, result);
        }
    }
}
