using ExceptionTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExceptionHandle
{
    [TestClass]
    public class UnitTest1
    {
        Program program = null;
        int first = 10;
        int second = 2;
        [TestInitialize]
        public void Setup()
        {
            program = new Program();
        }
        [TestCategory ("Addition")]
        [TestMethod]
        public void TestAdditionMethod()
        {
            ///AAA.....Arrange,Act,Assert
            ///
            //Arrange
            //Program program = new Program();
            //int first = 10;
            //int second = 40;
            int expected = 12;


            //Act
            int actual=program.Addition(first, second);

            //Assert
            Assert.AreEqual(expected, actual);
            
        }
        [TestCategory("Subtraction")]
        public void TestSubtractionMethod()
        {
            //int first = 30;
            //int second = 20;
            int expected = 8;

            //Act
            int actual=program.Subtraction(first, second);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestCategory ("Divide")]
        public void TestDivideMethod()
        {
            //Arrange
            int expected = 5;

            //Act
            int actual=program.Divide(first, second);

            //Assert
            Assert.AreSame(expected, actual);
        }
        public void TestMultiplication()
        {
            //Arrange
            int expected = 20;

            //Act
            int actual=program.Multiply(first, second);

            //Assert
            Assert.AreSame (expected, actual);
        }
    }
}
