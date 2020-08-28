using System;
using System.Diagnostics;
using System.Reflection;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddNominalCaseSuccess()
        {
            //given
            int actualResult;
            int expectedResult = 6;
            int op1 = 2;
            int op2 = 4;
            Calculator calculator = new Calculator();

            //when
            actualResult = calculator.Add(op1, op2);


            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubstractNominalCaseSuccess()
        {
            //given
            int actualResult;
            int expectedResult = 3;
            int op1 = 5;
            int op2 = 2;
            Calculator calculator = new Calculator();


            //when
            actualResult = calculator.Substract(op1, op2);


            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MultiplyNominalCaseSuccess()
        {
            //given
            int actualResult;
            int expectedResult = 15;
            int op1 = 5;
            int op2 = 3;
            Calculator calculator = new Calculator();


            //when
            actualResult = calculator.Multiply(op1, op2);


            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DivideNominalCaseSuccess()
        {
            //given
            int actualResult;
            int expectedResult = 4;
            int op1 = 25;
            int op2 = 5;
            Calculator calculator = new Calculator();


            //when
            actualResult = calculator.Divide(op1, op2);


            //then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
