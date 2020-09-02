using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntroTDD;
using System;

namespace TestIntroTDD
{
    [TestClass]
    public class TestCalculator
    {
        #region private attributes
        private int actualResult;
        private int op1;
        private int op2;
        private int expectedResult;
        private Calculator calculator;
        #endregion private attributes

        [TestInitialize]
        public void Init()
        {
            this.op1 = 4;
            this.op2 = 2;
            this.calculator = new Calculator();
        }

        [TestMethod]
        public void AddNominalCaseSuccess()
        {
            //given
            this.expectedResult = 6;

            //when
            this.actualResult = this.calculator.Add(this.op1, this.op2);

            //then
            Assert.AreEqual(this.expectedResult,this.actualResult);
        }

        [TestMethod]
        public void SubNominalCaseSuccess()
        {
            //given
            this.expectedResult = 2;

            //when
            this.actualResult = this.calculator.Sub(this.op1, this.op2);

            //then
            Assert.AreEqual(this.expectedResult, this.actualResult);
        }

        [TestMethod]
        public void MulNominalCaseSuccess()
        {
            //given
            this.expectedResult = 8;

            //when
            this.actualResult = this.calculator.Mul(this.op1, this.op2);

            //then
            Assert.AreEqual(this.expectedResult, this.actualResult);
        }

        [TestMethod]
        public void DivNominalCaseSuccess()
        {
            //given
            this.expectedResult = 2;

            //when
            this.actualResult = this.calculator.Div(this.op1, this.op2);

            //then
            Assert.AreEqual(this.expectedResult, this.actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivDividByZeroThrowException()
        {
            //given
            this.op2 = 0;

            //when
            this.actualResult = this.calculator.Div(this.op1, this.op2);

            //then
        }
    }
}
